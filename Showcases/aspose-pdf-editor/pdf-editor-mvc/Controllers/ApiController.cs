using System.Globalization;
using System.Reflection;
using Aspose.Pdf;
using Aspose.Pdf.Devices;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Forms;
using Aspose.Pdf.Text;
using Microsoft.AspNetCore.Mvc;
using ImageMagick;
using Aspose.PDF.Editor.Models;
using Aspose.PDF.Editor.Services.Interface;

namespace Aspose.PDF.Editor.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApiController : Controller
{
    private const string SearchMarker = "Aspose.PDF Editor Free App Search";

    private readonly IStorageService _storageService;

    public ApiController(IStorageService storageService)
    {
        _storageService = storageService;
    }

    [HttpPost]
    [Route("/pdf/editor/api/upload")]
    public async Task<DocStatusModel> Upload()
    {
        var httpRequest = HttpContext.Request;
        var documentId = httpRequest.Form.Keys.Contains("documentId") &&
                         httpRequest.Form["documentId"][0] != null ? 
            httpRequest.Form["documentId"][0] : 
            Guid.NewGuid().ToString();
        var fullPath = Path.Combine(
            _storageService.WorkingDirectory,
            documentId);

        var postedFile = httpRequest.Form.Files.FirstOrDefault();

        if (postedFile == null)
            throw new ArgumentException("no files");


        if (httpRequest.Form["Opp"].ToString()!.StartsWith("uploading"))
        {
            var guid = Guid.NewGuid().ToString();
            var tempFolder = Path.Combine(_storageService.WorkingDirectory, guid);
            Directory.CreateDirectory(tempFolder);
            var filePath = Path.Combine(tempFolder, "document.pdf");
            await using (var fileStream = new FileStream(filePath, FileMode.CreateNew))
            {
                await postedFile.CopyToAsync(fileStream);
            }

            var url = Path.Combine(guid, "document.pdf");

            await using (var s = postedFile.OpenReadStream())
            {
                s.Seek(0, SeekOrigin.Begin);
                var model = new DocStatusModel
                {
                    D = await ImageConverter(s, guid, "document.pdf"),
                    Path = guid,
                    OriginalFileName = postedFile.FileName
                };
                s.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(s, url);

                return model;
            }
        }

        if (httpRequest.Form["Opp"].ToString()!.StartsWith("appending"))
        {
            string appPages = httpRequest.Form["pages"];
            string appRatios = httpRequest.Form["ratios"];
            string appHeights = httpRequest.Form["heights"];

            var url = Path.Combine(httpRequest.Form["documentId"], "document.pdf");

            await using (var s = postedFile.OpenReadStream())
            {
                await using (Stream docStream = await _storageService.Download(url))
                {
                    var model = new DocStatusModel
                    {
                        D = await AppendConverter(
                            docStream,
                            s,
                            httpRequest.Form["documentId"],
                            appPages,
                            appRatios,
                            appHeights),
                        Path = httpRequest.Form["documentId"]
                    };

                    return model;
                }
            }
        }

        if (httpRequest.Form["Opp"].ToString()!.StartsWith("addAttachment"))
        {
            var documentFileName = Path.Combine(fullPath, "document.pdf");
            using MemoryStream ms = new MemoryStream();
            using (PdfContentEditor contentEditor = new PdfContentEditor())
            {
                contentEditor.BindPdf(documentFileName);
                await using (var fs = postedFile.OpenReadStream())
                {
                    contentEditor.AddDocumentAttachment(
                        fs,
                        postedFile.FileName,
                        "File added by Aspose.PDF Editor");
                    contentEditor.Save(ms);
                }    
            }

            var url = Path.Combine(httpRequest.Form["documentId"], "document.pdf");
            await _storageService.Upload(ms, url);

            return new DocStatusModel
            {
                D = postedFile.FileName,
                Path = httpRequest.Form["documentId"]
            };
        }
        else
        {
            //Or just save it locally

            var url = Path.Combine(httpRequest.Form["documentId"], postedFile.FileName);

            using (var s = postedFile.OpenReadStream())
            {
                await _storageService.Upload(s, url);
            }

            var model = new DocStatusModel
            {
                D = postedFile.FileName,
                Path = httpRequest.Form["documentId"]
            };
            return model;
        }
    }

    [HttpGet]
    [Route("/pdf/editor/api/FileExists")]
    public async Task<DocStatusModel> FileExists(string? folder, string? fileName)
    {
        if (string.IsNullOrWhiteSpace(folder))
        {
            folder = Guid.NewGuid().ToString();
            fileName = "document.pdf";
        }

        var downloadFileName = "document.pdf";

        var url = Path.Combine(folder, fileName);
        await using (Stream docStream = await _storageService.Download(url))
        {
            var model = new DocStatusModel
            {
                D = await ImageConverter(docStream, folder, fileName),
                Path = folder,
                OriginalFileName = downloadFileName
            };

            return model;
        }
    }

    [HttpPost]
    [Route("/pdf/editor/api/upload-pic")]
    public async Task<DocStatusModel> UploadPic([FromBody] UploadPicModel uploadPicModel)
    {
        var url = Path.Combine(uploadPicModel.DocumentId, "document.pdf");
        await using (Stream docStream = await _storageService.Download(url))
        using (Document doc = new Document(docStream))
        {
            foreach (var t in uploadPicModel.Shapes)
            {
                float shapeX = float.Parse(t.X.Replace(',', '.'), CultureInfo.InvariantCulture) * 72 / 150 /
                               (float)double.Parse(t.ratio.Replace(',', '.'), CultureInfo.InvariantCulture);
                float shapeY = float.Parse(t.Y.Replace(',', '.'), CultureInfo.InvariantCulture) * 72 / 150 /
                               (float)double.Parse(t.ratio.Replace(',', '.'), CultureInfo.InvariantCulture);
                float shapeW = float.Parse(t.W.Replace(',', '.'), CultureInfo.InvariantCulture) * 72 / 150 /
                               (float)double.Parse(t.ratio.Replace(',', '.'), CultureInfo.InvariantCulture);
                float shapeH = float.Parse(t.H.Replace(',', '.'), CultureInfo.InvariantCulture) * 72 / 150 /
                               (float)double.Parse(t.ratio.Replace(',', '.'), CultureInfo.InvariantCulture);

                float yaxis = (float)(doc.Pages[int.Parse(t.P)].Rect.URY - (shapeH + shapeY));

                var isSpecial = true;

                if (t.Itype == "highlight" || t.Itype == "image")
                {
                    //Create image stamp
                    Stream stream;

                    if (t.Itype == "highlight")
                    {
                        var assembly = Assembly.GetExecutingAssembly();
                        var resourcePath = assembly.GetManifestResourceNames()
                            .First(name => name.EndsWith("test.png"));
                        stream = assembly.GetManifestResourceStream(resourcePath);
                    }
                    else
                    {
                        var url1 = Path.Combine(uploadPicModel.DocumentId, t.imName);
                        stream = await _storageService.Download(url1);
                    }
                    
                    var imageStamp = new ImageStamp(stream)
                    {
                        Background = false,
                        XIndent = shapeX,
                        YIndent = yaxis,
                        Height = shapeH,
                        Width = shapeW
                    };

                    //Add stamp to particular page
                    doc.Pages[int.Parse(t.P)].AddStamp(imageStamp);

                    if (stream != null)
                        await stream.DisposeAsync();
                }
                else if (t.Itype == "text")
                {
                    //create text stamp
                    TextStamp textStamp = new TextStamp(t.t);
                    textStamp.XIndent = shapeX;
                    textStamp.YIndent = yaxis;
                    //rotate stamp
                    textStamp.RotateAngle = 360 - double.Parse(t.fieldType, CultureInfo.InvariantCulture) * 180 / Math.PI;

                    //set text properties
                    try
                    {
                        textStamp.TextState.Font = FontRepository.FindFont(t.n);
                    }
                    catch
                    {
                        //TODO: do something with font
                    }

                    textStamp.TextState.FontSize = Convert.ToInt32(t.s) * 0.75f;

                    if (t.wt == "bold")
                    {
                        textStamp.TextState.FontStyle = FontStyles.Bold;
                    }

                    if (t.st == "italic")
                    {
                        textStamp.TextState.FontStyle = FontStyles.Italic;
                    }

                    textStamp.TextState.ForegroundColor = Color.Parse(t.c);

                    //add stamp to particular page
                    doc.Pages[int.Parse(t.P)].AddStamp(textStamp);
                }
                else if (t.Itype == "field" && isSpecial)
                {
                    if (t.fieldType == "Text")
                    {
                        // Get a field
                        TextBoxField textBoxField = doc.Form.Fields[Convert.ToInt32(t.imName)] as TextBoxField;
                        // Modify field value
                        textBoxField.Value = t.t;
                    }
                    else if (t.fieldType == "CheckBox")
                    {
                        // Get a field
                        CheckboxField? checkBoxField = doc.Form.Fields[Convert.ToInt32(t.imName)] as CheckboxField;
                        if (t.t != "")
                            // Modify field value
                            checkBoxField.Checked = Convert.ToBoolean(t.t);
                    }
                    else if (t.fieldType == "Radio")
                    {
                        RadioButtonOptionField field =
                            (RadioButtonOptionField)doc.Form.Fields[Convert.ToInt32(t.imName)];

                        RadioButtonField rbf = (RadioButtonField)field.Parent;
                        if (Convert.ToBoolean(t.t))
                        {
                            rbf.Selected = rbf.Options[field.OptionName].Index;
                        }
                        else
                        {
                            field.ActiveState = "Off";
                        }
                    }
                    else if (t.fieldType == "ComboBox")
                    {
                        // Get a field
                        ComboBoxField? comboBoxField = doc.Form.Fields[Convert.ToInt32(t.imName)] as ComboBoxField;
                        var values = t.t.Split(new[] { "^^^" }, StringSplitOptions.None)[0];

                        foreach (var item in comboBoxField.Options)
                        {
                            if (item.Value == values)
                            {
                                comboBoxField.Selected = item.Index;
                            }
                        }
                    }
                }
            }

            using (MemoryStream ms = new MemoryStream())
            {
                doc.Save(ms);
                await _storageService.Upload(ms, url);
            }
        }

        return new DocStatusModel();
    }

    [HttpGet]
    [Route("/pdf/editor/api/image/{folder}/{filename}")]
    public async Task<FileContentResult> GetPageImage(string folder, string filename)
    {
        //converting Pdf file into bytes array
        int extensionPosition = filename.LastIndexOf('-');
        int extensionPosition2 = filename.LastIndexOf('.');
        if (extensionPosition != -1 && extensionPosition2 < extensionPosition)
        {
            filename = filename.Remove(extensionPosition, 1).Insert(extensionPosition, ".");
        }

        var url = Path.Combine(folder, filename);
        await using (Stream imgStream = await _storageService.Download(url))
        {
            using var bs = new BinaryReader(imgStream);
            byte[] content = bs.ReadBytes((int)imgStream.Length);

            return File(content, "image/png");
        }
    }

    [HttpGet]
    [Route("/pdf/editor/api/download/{fileType}/{folder}")]
    public async Task<FileContentResult> Download(string fileType, string folder)
    {
        var downloadFileName = "document.pdf";
        string contentType = "application/pdf";
        switch (fileType)
        {
            case "docx":
                downloadFileName = "document.docx";
                contentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                break;
            case "svg":
                downloadFileName = "document.svg";
                contentType = "image/svg+xml";
                break;
            case "xps":
                downloadFileName = "document.xps";
                contentType = "application/oxps, application/vnd.ms-xpsdocument";
                break;
            case "xls":
                downloadFileName = "document.xlsx";
                contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                break;
            case "html":
                downloadFileName = "document.html";
                contentType = "text/html";
                break;
        }

        var url = Path.Combine(folder, downloadFileName);
        await using (Stream docStream = await _storageService.Download(url))
        {
            using var bs = new BinaryReader(docStream);
            byte[] content = bs.ReadBytes((int)docStream.Length);

            return File(content, contentType);
        }
    }

    [HttpPost]
    [Route("/pdf/editor/api/exportfile/")]
    public async Task<DocStatusModel> Export(string fileType, string folder)
    {
        var url = Path.Combine(folder, "document.pdf");
        await using Stream docStream = await _storageService.Download(url);

        using var doc = new Document(docStream);
        using MemoryStream ms = new MemoryStream();
        switch (fileType)
        {
            case "txt":
                TextAbsorber textAbsorber = new TextAbsorber();
                doc.Pages.Accept(textAbsorber);
                string extractedText = textAbsorber.Text;
                var url6 = Path.Combine(folder, "document.txt");
                var ms1 = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(extractedText));
                ms1.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms1, url6);
                return new DocStatusModel
                {
                    Path = folder,
                    OriginalFileName = "document.txt"
                };
            case "docx":
                doc.Save(ms, SaveFormat.DocX);
                var url1 = Path.Combine(folder, "document.docx");
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url1);
                return new DocStatusModel
                {
                    Path = folder,
                    OriginalFileName = "document.docx"
                };
            case "svg":
                doc.Save(ms, SaveFormat.Svg);
                var url2 = Path.Combine(folder, "document.svg");
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url2);
                return new DocStatusModel
                {
                    Path = folder,
                    OriginalFileName = "document.svg"
                };
            case "xps":
                doc.Save(ms, SaveFormat.Xps);
                var url3 = Path.Combine(folder, "document.xps");
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url3);
                return new DocStatusModel
                {
                    Path = folder,
                    OriginalFileName = "document.xps"
                };
            case "xls":
                doc.Save(ms, SaveFormat.Excel);
                var url4 = Path.Combine(folder, "document.xlsx");
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url4);
                return new DocStatusModel
                {
                    Path = folder,
                    OriginalFileName = "document.xlsx"
                };
            case "html":
                doc.Save(ms, new HtmlSaveOptions
                {
                    DocumentType = HtmlDocumentType.Html5,
                    PartsEmbeddingMode = HtmlSaveOptions.PartsEmbeddingModes.EmbedAllIntoHtml,
                    RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes
                        .AsEmbeddedPartsOfPngPageBackground
                });
                var url5 = Path.Combine(folder, "document.html");
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url5);
                return new DocStatusModel
                {
                    Path = folder,
                    OriginalFileName = "document.html"
                };
            case "pdf":
                doc.Save(ms, SaveFormat.Pdf);
                var url7 = Path.Combine(folder, "document.pdf");
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url7);
                return new DocStatusModel
                {
                    Path = folder,
                    OriginalFileName = "document.pdf"
                };
        }

        throw new NotSupportedException(fileType);
    }

    [HttpPost]
    [Route("/pdf/editor/api/add-page/{folder}")]
    public async Task<DocStatusModel> AddPage(string folder)
    {
        var url = Path.Combine(folder, "document.pdf");
        int pageCount = 0;
        await using (Stream docStream = await _storageService.Download(url))
        {
            using (MemoryStream ms = new MemoryStream())
            using (Document doc = new Document(docStream))
            {
                doc.Pages.Add();
                doc.Save(ms);
                pageCount = doc.Pages.Count;
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url);

                var imageFileName = "image" + pageCount + ".png";
                using (MemoryStream imageStream = new MemoryStream())
                {
                    //create PNG device with specified attributes
                    PngDevice pngDevice = new PngDevice(new Resolution(150));
                    //Convert a particular page and save the image to stream
                    pngDevice.Process(doc.Pages[pageCount], imageStream);

                    var (height, aspectRatio) =  await ScaleImage(imageStream, folder, imageFileName, 1138);
                    return new DocStatusModel
                    {
                        D = $"image{pageCount}.png#{height}#{aspectRatio}",
                        Path = folder,
                        Heights = height
                    };
                }
            }
        }
    }

    [HttpPost]
    [Route("/pdf/editor/api/delete-page")]
    public async Task<DeletePageModel> DeletePage([FromBody] DeletePageModel deletePageModel)
    {
        var url = Path.Combine(deletePageModel.DocumentId, "document.pdf");
        var imgUrl = Path.Combine(deletePageModel.DocumentId, deletePageModel.ImageName);

        await using (Stream docStream = await _storageService.Download(url))
        {
            using Document doc = new Document(docStream);
            doc.Pages.Delete(Convert.ToInt32(deletePageModel.ImageData));
            using MemoryStream ms = new MemoryStream();
            doc.Save(ms);
            ms.Seek(0, SeekOrigin.Begin);
            await _storageService.Upload(ms, url);
            _storageService.Delete(imgUrl);
            return deletePageModel;
        }
    }

    [HttpPost]
    [Route("/pdf/editor/api/search-data")]
    public async Task<DocStatusModel> SearchData([FromBody] SearchDataModel searchDataModel)
    {
        var url = Path.Combine(searchDataModel.DocumentId, "document.pdf");
        await using Stream docStream = await _storageService.Download(url);

        using Document document = new Document(docStream);
        TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber(searchDataModel.SearchText);
        textFragmentAbsorber.Visit(document);
        foreach (var textFragment in textFragmentAbsorber.TextFragments)
        {
            textFragment.Page.Annotations.Add(
                new Pdf.Annotations.HighlightAnnotation(textFragment.Page, textFragment.Rectangle)
                {
                    Title = SearchMarker
                }
            );
        }

        using MemoryStream ms = new MemoryStream();
        document.Save(ms);
        ms.Seek(0, SeekOrigin.Begin);
        var model = new DocStatusModel
        {
            D = await ImageConverter(ms, searchDataModel.DocumentId, "document.pdf"),
            Path = searchDataModel.DocumentId,
            OriginalFileName = ""
        };
        ms.Seek(0, SeekOrigin.Begin);
        await _storageService.Upload(ms, url);

        return model;
    }

    [HttpPost]
    [Route("/pdf/editor/api/search-clear")]
    public async Task<DocStatusModel> SearchClear([FromBody] SearchDataModel searchDataModel)
    {
        var url = Path.Combine(searchDataModel.DocumentId, "document.pdf");
        await using Stream docStream = await _storageService.Download(url);

        using Document document = new Document(docStream);
        foreach (var page in document.Pages)
        {
            var annotations = page.Annotations
                .Where(a => a.AnnotationType == Pdf.Annotations.AnnotationType.Highlight)
                .Cast<Pdf.Annotations.HighlightAnnotation>();
            foreach (var highlightAnnotation in annotations)
            {
                if (highlightAnnotation.Title.Equals(SearchMarker))
                    page.Annotations.Delete(highlightAnnotation);
            }
        }

        using MemoryStream ms = new MemoryStream();
        document.Save(ms);
        ms.Seek(0, SeekOrigin.Begin);

        var model = new DocStatusModel
        {
            D = await ImageConverter(ms, searchDataModel.DocumentId, "document.pdf"),
            Path = searchDataModel.DocumentId,
            OriginalFileName = ""
        };
        ms.Seek(0, SeekOrigin.Begin);
        await _storageService.Upload(ms, url);

        return model;
    }

    [HttpPost]
    [Route("/pdf/editor/api/replace-text")]
    public async Task<DocStatusModel> ReplaceText([FromBody] ReplaceTextModel replaceTextModel)
    {
        var url = Path.Combine(replaceTextModel.DocumentId, "document.pdf");
        await using Stream docStream = await _storageService.Download(url);
        using Document doc = new Document(docStream);

        TextFragmentAbsorber textFragmentAbsorber =
            new TextFragmentAbsorber(replaceTextModel.TxtFind);

        doc.Pages.Accept(textFragmentAbsorber);

        //get the extracted text fragments
        TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;

        //loop through the fragments
        foreach (TextFragment textFragment in textFragmentCollection)
        {
            //update text and other properties
            textFragment.Text = replaceTextModel.TxtReplace;
        }

        using MemoryStream ms = new MemoryStream();
        doc.Save(ms);
        ms.Seek(0, SeekOrigin.Begin);
        var model = new DocStatusModel
        {
            D = await ImageConverter(ms, replaceTextModel.DocumentId, "document.pdf"),
            Path = replaceTextModel.DocumentId
        };
        ms.Seek(0, SeekOrigin.Begin);
        await _storageService.Upload(ms, url);

        return model;
    }

    [HttpPost]
    [Route("/pdf/editor/api/move-pages")]
    public async Task<MovePagesModel> MovePages([FromBody] MovePagesModel movePagesModel)
    {
        var url = Path.Combine(movePagesModel.DocumentId, "document.pdf");

        await using (Stream docStream = await _storageService.Download(url))
        {
            int pageFrom = Convert.ToInt32(movePagesModel.MoveFrom);
            int pageTo = Convert.ToInt32(movePagesModel.MoveTo);
            List<string> str = movePagesModel.PageList.ToList();

            using var doc = new Document(docStream);
            var page = doc.Pages[pageFrom];

            doc.Pages.Insert(pageTo + 1, page);

            if (pageFrom > pageTo)
            {
                doc.Pages.Delete(pageFrom + 1);
                str.Insert(pageTo, movePagesModel.PageList[pageFrom - 1]);
                str.RemoveAt(pageFrom);
            }
            else
            {
                doc.Pages.Delete(pageFrom);
                str.Insert(pageTo, movePagesModel.PageList[pageFrom - 1]);
                str.RemoveAt(pageFrom - 1);
            }

            using MemoryStream ms = new MemoryStream();
            doc.Save(ms);
            ms.Seek(0, SeekOrigin.Begin);
            await _storageService.Upload(ms, url);
            movePagesModel.PageList = str.ToArray();

            return movePagesModel;
        }
    }

    [HttpGet]
    [Route("/pdf/editor/api/createNewFile")]
    public async Task<DocStatusModel> CreateNewFile()
    {
        var guid = Guid.NewGuid().ToString();
        var url = Path.Combine(guid, "document.pdf");

        using Document doc = new Document();
        doc.Pages.Add();

        using MemoryStream ms = new MemoryStream();
        doc.Save(ms);
        ms.Seek(0, SeekOrigin.Begin);
        var model = new DocStatusModel
        {
            D = await ImageConverter(ms, guid, "document.pdf"),
            Path = guid
        };
        ms.Seek(0, SeekOrigin.Begin);
        await _storageService.Upload(ms, url);

        return model;
    }

    [HttpPost]
    [Route("/pdf/editor/api/GetFileAttachments/{folder}")]
    public async Task<FileAttachmentsModel> GetFileAttachments(string folder)
    {
        var url = Path.Combine(folder, "document.pdf");
        await using Stream docStream = await _storageService.Download(url);

        string outAttach = "";

        // Open document
        using (Document pdfDocument = new Document(docStream))
        {
            // Get embedded files collection
            EmbeddedFileCollection embeddedFiles = pdfDocument.EmbeddedFiles;
            // Loop through the collection to get all the attachments
            foreach (FileSpecification fileSpecification in embeddedFiles)
            {
                outAttach = outAttach + "," + fileSpecification.Name + "," + fileSpecification.Description;
            }

            if (outAttach.Length > 1)
            {
                outAttach = outAttach.Substring(1);
            }
        }

        var model = new FileAttachmentsModel
        {
            D = outAttach
        };

        return model;
    }

    [HttpPost]
    [Route("/pdf/editor/api/remove-attachment")]
    public async Task<FileAttachmentsModel> RemoveFileAttachment([FromBody] RemoveAttachmentModel removeAttachmentModel)
    {
        var url = Path.Combine(removeAttachmentModel.DocumentId, "document.pdf");
        await using Stream docStream = await _storageService.Download(url);

        // Open document
        using (Document pdfDocument = new Document(docStream))
        {
            EmbeddedFileCollection embeddedFiles = pdfDocument.EmbeddedFiles;
            embeddedFiles.Delete(removeAttachmentModel.AttachmentFileName);
            using MemoryStream ms = new MemoryStream();
            pdfDocument.Save(ms);
            ms.Seek(0, SeekOrigin.Begin);
            await _storageService.Upload(ms, url);
        }

        var model = new FileAttachmentsModel
        {
            D = "Success",
            Path = HttpContext.Request.Form["documentId"]
        };

        return model;
    }

    [HttpPost]
    [Route("/pdf/editor/api/create-signature")]
    public async Task<DocStatusModel> CreateSignature([FromBody] SignatureModel signatureModel)
    {
        Random random = new Random();
        int rand = random.Next(1000000);
        string fileNameWitPath = $"sign{rand}.png";
        var url = Path.Combine(signatureModel.DocumentId, fileNameWitPath);

        byte[] data = Convert.FromBase64String(signatureModel.ImageData);
        using (MemoryStream fs = new MemoryStream(data))
        {
            await _storageService.Upload(fs, url);
        }

        var model = new DocStatusModel
        {
            D = $"sign{rand}.png"
        };

        return model;
    }

    private async Task<string> AppendConverter(Stream docStream, Stream appendStream, string folder,
        string appPages, string appRatios, string appHeights)
    {
        using Document doc = new Document(docStream);
        int initialPageCount = doc.Pages.Count;

        //open second document
        using Document pdfDocument2 = new Document(appendStream);

        //add pages of second document to the first
        doc.Pages.Add(pdfDocument2.Pages);
        using MemoryStream ms = new MemoryStream();
        //save concatenated output file
        doc.Save(ms);

        var url = Path.Combine(folder, "document.pdf");

        await _storageService.Upload(ms, url);

        for (int pageIndex = initialPageCount + 1; pageIndex <= doc.Pages.Count; pageIndex++)
        {
            var imageFileName = "image" + pageIndex + ".png";
            using (MemoryStream imageStream = new MemoryStream())
            {
                PngDevice pngDevice = new PngDevice(new Resolution(150));
                pngDevice.Process(doc.Pages[pageIndex], imageStream);

                var r = await ScaleImage(imageStream, folder, imageFileName, 1138);
                appPages = appPages + "," + "image" + pageIndex + ".png";
                appRatios = appRatios + "," + r.Item2;
                appHeights = appHeights + "," + r.Item1;
            }
        }

        return appPages + "%#" + appRatios + "%#" + appHeights;
    }

    private async Task<string> ImageConverter(Stream docStream, string folder, string fileName)
    {
        using Document doc = new Document(docStream);
        string pages = "";
        string ratios = "";
        string allHeights = "";
        string fields = "";
        int totalPages = doc.Pages.Count;
        for (int pageCount = 1; pageCount <= totalPages; pageCount++)
        {
            var imgFile = "/image" + pageCount + ".png";
            var url = Path.Combine(folder, imgFile);

            using (var imageStream = new MemoryStream())
            {
                PngDevice pngDevice = new PngDevice(new Resolution(150));
                pngDevice.Process(doc.Pages[pageCount], imageStream);

                var r = await ScaleImage(imageStream, folder, imgFile, 1138);

                if (pageCount == 1)
                    fields = CheckFields(doc, pageCount, fields, double.Parse(r.Item2, CultureInfo.InvariantCulture));

                pages = pages + "," + "image" + pageCount + ".png";
                ratios = $"{ratios},{r.Item2.Replace(',', '.')}";
                allHeights = allHeights + "," + r.Item1;
            }
        }

        ratios = ratios.Substring(1, ratios.Length - 1);
        pages = pages.Substring(1, pages.Length - 1);
        allHeights = allHeights.Substring(1, allHeights.Length - 1);

        if (fields != "")
        {
            fields = fields.Substring(3, fields.Length - 3);
        }

        return pages + "%#" + ratios + "%#" + allHeights + "%#" + fields;
    }

    private async Task<(string, string)> ScaleImage(Stream imgStream, string folder, string fileName, int maxWidth)
    {
        string height;
        string aspectRatio;

        var url = Path.Combine(folder, fileName.TrimStart('/'));

        imgStream.Seek(0, SeekOrigin.Begin);
        using (var image = new MagickImage(imgStream))
        {
            var ratio = (double)maxWidth / image.Width;
            aspectRatio = ratio.ToString(CultureInfo.InvariantCulture);
            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);
            height = newHeight.ToString();

            image.Resize(newWidth, newHeight);

            byte[] resizedImageBytes = image.ToByteArray();
            using (var ms = new MemoryStream(resizedImageBytes))
            {
                ms.Seek(0, SeekOrigin.Begin);
                await _storageService.Upload(ms, url);
            }
        }

        return (height, aspectRatio);
    }

    private static string CheckFields(Document doc, int pageCount, string fields, double ratio,
        bool licensed = true)
    {
        int fieldCounter = 0;

        Pdf.Facades.Form pdfForm = new Pdf.Facades.Form(doc);

        // Get values from all fields
        foreach (Field formField in doc.Form.Fields)
        {
            double lowerLeftY = doc.Pages[pageCount].Rect.Height - (formField.Rect.ToRect().Y + formField.Height);

            double lowerLeftX = formField.Rect.ToRect().X;
            var fieldType = formField.GetType().Name;
            var imValue = "";

            if (fieldType == "CheckboxField" ||
                fieldType == "ComboBoxField" ||
                fieldType == "RadioButtonOptionField" ||
                fieldType == "TextBoxField")
            {
                var value = formField.Value;

                if (fieldType == "TextBoxField")
                {
                    fieldType = "Text";
                }

                if (fieldType == "CheckboxField")
                {
                    CheckboxField field = (CheckboxField)formField;
                    if (field.Parent != null)
                        imValue = field.Parent.FullName;
                    fieldType = "CheckBox";
                    value = field.Checked ? "true" : "false";
                }

                if (fieldType == "RadioButtonOptionField")
                {
                    RadioButtonOptionField field = (RadioButtonOptionField)formField;
                    RadioButtonField rbf = (RadioButtonField)field.Parent;

                    fieldType = "Radio";
                    if (field.Parent != null)
                        imValue = field.Parent.FullName;
                    value = rbf.Options[field.OptionName].Index == rbf.Selected ? "true" : "false";
                }

                if (fieldType == "ComboBoxField")
                {
                    ComboBoxField field = (ComboBoxField)formField;
                    string optValues = value;
                    fieldType = "ComboBox";
                    foreach (Option opt in field.Options)
                    {
                        optValues = optValues + "^^^" + opt.Value;
                    }

                    value = optValues;
                }

                bool isRequired = pdfForm.IsRequiredField(formField.FullName);
                fields += "$#$" + lowerLeftX * 2.08 * ratio + "$#$" + lowerLeftY * 2.08 * ratio + "$#$" +
                          formField.Width * 2.08 * ratio + "$#$" + formField.Height * 2.08 * ratio + "$#$" +
                          formField.PageIndex + "$#$" + "image" + formField.PageIndex + ".png" + "$#$" + value +
                          "$#$" + formField.DefaultAppearance.FontName + "$#$" +
                          formField.DefaultAppearance.FontSize + "$#$" + " " + "$#$" + " " + "$#$" + isRequired +
                          "$#$" + ratio + "$#$" + imValue + "$#$" + fieldCounter + "$#$" + fieldType;
            }

            fieldCounter += 1;
            if (!licensed && fieldCounter == 5)
            {
                break;
            }
        }

        return fields;
    }
}