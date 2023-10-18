using Aspose.Pdf;
using Aspose.Pdf.Text;
using Microsoft.AspNetCore.Mvc;
using Aspose.PDF.Editor.Models;
using Aspose.PDF.Editor.Services.Interface;

namespace Aspose.PDF.Editor.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DocumentController : Controller
{
    private readonly IDocumentServicecs _documentServicecs;
    private readonly IStorageService _storageService;
    private readonly IImageService _imageService;

    public DocumentController(IDocumentServicecs documentServicecs, IStorageService storageService, IImageService imageService)
    {
        _documentServicecs = documentServicecs;
        _storageService = storageService;
        _imageService = imageService;
    }

    [HttpPost]
    [Route("create")]
    public async Task<DocInfoModel> Create()
    {
        var guid = Guid.NewGuid().ToString();
        var file = Path.Combine(guid, "document.pdf");

        using Document doc = new Document();
        doc.Pages.Add();

        using MemoryStream ms = new MemoryStream();
        doc.Save(ms);
        ms.Seek(0, SeekOrigin.Begin);
        var model = new DocInfoModel
        {
            Pages = await _imageService.ImageConverter(ms, guid, "document.pdf"),
            DocumentId = guid
        };
        ms.Seek(0, SeekOrigin.Begin);
        await _storageService.Upload(ms, file);

        return model;
    }

    [HttpPut]
    [Route("append")]
    public async Task<DocInfoModel> Append()
    {
        var httpRequest = HttpContext.Request;

        var postedFile = httpRequest.Form.Files.FirstOrDefault();

        string appPages = httpRequest.Form["pages"];
        string appRatios = httpRequest.Form["ratios"];
        string appHeights = httpRequest.Form["heights"];

        var file = Path.Combine(httpRequest.Form["documentId"], "document.pdf");

        await using (var s = postedFile.OpenReadStream())
        {
            await using (Stream docStream = await _storageService.Download(file))
            {
                var model = new DocInfoModel
                {
                    Pages = await _documentServicecs.AppendConverter(
                        docStream,
                        s,
                        httpRequest.Form["documentId"],
                        appPages,
                        appRatios,
                        appHeights),
                    DocumentId = httpRequest.Form["documentId"]
                };

                return model;
            }
        }
    }

    [HttpGet]
    [Route("info")]
    public async Task<DocInfoModel> GetInfo(string? folder, string? fileName)
    {
        if (string.IsNullOrWhiteSpace(folder))
        {
            folder = Guid.NewGuid().ToString();
            fileName = "document.pdf";
        }

        var file = Path.Combine(folder, fileName);
        await using (Stream docStream = await _storageService.Download(file))
        {
            var model = new DocInfoModel
            {
                Pages = await _imageService.ImageConverter(docStream, folder, fileName),
                DocumentId = folder
            };

            return model;
        }
    }

    [HttpPut]
    [Route("upload")]
    public async Task<DocInfoModel> Upload()
    {
        var httpRequest = HttpContext.Request;
        var postedFile = httpRequest.Form.Files.FirstOrDefault();

        if (postedFile == null)
            throw new ArgumentException("no files");

        var guid = Guid.NewGuid().ToString();
        var tempFolder = Path.Combine(_storageService.WorkingDirectory, guid);
        Directory.CreateDirectory(tempFolder);
        var filePath = Path.Combine(tempFolder, "document.pdf");
        await using (var fileStream = new FileStream(filePath, FileMode.CreateNew))
        {
            await postedFile.CopyToAsync(fileStream);
        }

        var file = Path.Combine(guid, "document.pdf");

        await using (var fs = postedFile.OpenReadStream())
        {
            fs.Seek(0, SeekOrigin.Begin);
            var model = new DocInfoModel
            {
                Pages = await _imageService.ImageConverter(fs, guid, "document.pdf"),
                DocumentId = guid
            };
            fs.Seek(0, SeekOrigin.Begin);
            await _storageService.Upload(fs, file);

            return model;
        }
    }

    [HttpGet]
    [Route("download/{fileType}/{folder}")]
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

        var file = Path.Combine(folder, downloadFileName);
        await using (Stream docStream = await _storageService.Download(file))
        {
            using var bs = new BinaryReader(docStream);
            byte[] content = bs.ReadBytes((int)docStream.Length);

            return File(content, contentType);
        }
    }

    [HttpPost]
    [Route("export")]
    public async Task<DocInfoModel> Export(string fileType, string folder)
    {
        var sourceFile = Path.Combine(folder, "document.pdf");
        await using Stream docStream = await _storageService.Download(sourceFile);

        string exportFile;
        using var doc = new Document(docStream);
        MemoryStream ms = new MemoryStream();
        switch (fileType)
        {
            case "txt":
                TextAbsorber textAbsorber = new TextAbsorber();
                doc.Pages.Accept(textAbsorber);
                string extractedText = textAbsorber.Text;
                exportFile = Path.Combine(folder, "document.txt");
                ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(extractedText));
                break;
            case "docx":
                doc.Save(ms, SaveFormat.DocX);
                exportFile = Path.Combine(folder, "document.docx");
                break;
            case "svg":
                doc.Save(ms, SaveFormat.Svg);
                exportFile = Path.Combine(folder, "document.svg");
                break;
            case "xps":
                doc.Save(ms, SaveFormat.Xps);
                exportFile = Path.Combine(folder, "document.xps");
                break;
            case "xls":
                doc.Save(ms, SaveFormat.Excel);
                exportFile = Path.Combine(folder, "document.xlsx");
                break;
            case "html":
                doc.Save(ms, new HtmlSaveOptions
                {
                    DocumentType = HtmlDocumentType.Html5,
                    PartsEmbeddingMode = HtmlSaveOptions.PartsEmbeddingModes.EmbedAllIntoHtml,
                    RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes
                        .AsEmbeddedPartsOfPngPageBackground
                });
                exportFile = Path.Combine(folder, "document.html");
                break;
            case "pdf":
                doc.Save(ms, SaveFormat.Pdf);
                exportFile = Path.Combine(folder, "document.pdf");
                break;
            default:
                throw new NotSupportedException(fileType);
        }

        ms.Seek(0, SeekOrigin.Begin);
        await _storageService.Upload(ms, exportFile);
        return new DocInfoModel
        {
            DocumentId = folder
        };
    }
}
