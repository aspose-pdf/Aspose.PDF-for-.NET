using System.Reflection;
using Aspose.Pdf;
using Aspose.Pdf.Forms;
using Aspose.Pdf.Text;
using Microsoft.AspNetCore.Mvc;
using Aspose.PDF.Editor.Models;
using Aspose.PDF.Editor.Services.Interface;
using System.Globalization;
using Microsoft.AspNetCore.Http;

namespace Aspose.PDF.Editor.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShapeController : Controller
{
    private readonly IStorageService _storageService;

    public ShapeController(IStorageService storageService)
    {
        _storageService = storageService;
    }

    [HttpPost]
    [Route("add")]
    public async Task<DocInfoModel> AddShapes([FromBody] PrimitivesModel uploadPicModel)
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

                if (t.IType == "highlight" || t.IType == "image")
                {
                    //Create image stamp
                    Stream stream;

                    if (t.IType == "highlight")
                    {
                        var assembly = Assembly.GetExecutingAssembly();
                        var resourcePath = assembly.GetManifestResourceNames()
                            .First(name => name.EndsWith("test.png"));
                        stream = assembly.GetManifestResourceStream(resourcePath);
                    }
                    else
                    {
                        var url1 = Path.Combine(uploadPicModel.DocumentId, t.ImName);
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
                else if (t.IType == "text")
                {
                    //create text stamp
                    TextStamp textStamp = new TextStamp(t.t);
                    textStamp.XIndent = shapeX;
                    textStamp.YIndent = yaxis;
                    //rotate stamp
                    textStamp.RotateAngle = 360 - double.Parse(t.FieldType, CultureInfo.InvariantCulture) * 180 / Math.PI;

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
                else if (t.IType == "field" && isSpecial)
                {
                    if (t.FieldType == "Text")
                    {
                        // Get a field
                        TextBoxField textBoxField = doc.Form.Fields[Convert.ToInt32(t.ImName)] as TextBoxField;
                        // Modify field value
                        textBoxField.Value = t.t;
                    }
                    else if (t.FieldType == "CheckBox")
                    {
                        // Get a field
                        CheckboxField? checkBoxField = doc.Form.Fields[Convert.ToInt32(t.ImName)] as CheckboxField;
                        if (t.t != "")
                            // Modify field value
                            checkBoxField.Checked = Convert.ToBoolean(t.t);
                    }
                    else if (t.FieldType == "Radio")
                    {
                        RadioButtonOptionField field =
                            (RadioButtonOptionField)doc.Form.Fields[Convert.ToInt32(t.ImName)];

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
                    else if (t.FieldType == "ComboBox")
                    {
                        // Get a field
                        ComboBoxField? comboBoxField = doc.Form.Fields[Convert.ToInt32(t.ImName)] as ComboBoxField;
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

        return new DocInfoModel();
    }

    [HttpPost]
    [Route("upload")]
    public async Task<DocInfoModel> UploadImage()
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

        var url = Path.Combine(httpRequest.Form["documentId"], postedFile.FileName);

        using (var s = postedFile.OpenReadStream())
        {
            await _storageService.Upload(s, url);
        }

        var model = new DocInfoModel
        {
            Pages = postedFile.FileName,
            Path = httpRequest.Form["documentId"]
        };
        return model;
    }


    [HttpPost]
    [Route("signature")]
    public async Task<DocInfoModel> CreateSignature([FromBody] SignatureModel signatureModel)
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

        var model = new DocInfoModel
        {
            Pages = $"sign{rand}.png"
        };

        return model;
    }

    //[HttpPost]
    //[Route("image")]
    //public async Task<DocStatusModel> UploadImage([FromBody] UploadPicModel uploadPicModel)
    //{
    //    var url = Path.Combine(uploadPicModel.DocumentId, "document.pdf");
    //    await using (Stream docStream = await _storageService.Download(url))
    //    using (Document doc = new Document(docStream))
    //    {
    //        foreach (var t in uploadPicModel.Shapes)
    //        {
    //            float shapeX = float.Parse(t.X, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeY = float.Parse(t.Y, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeW = float.Parse(t.W, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeH = float.Parse(t.H, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);

    //            float yaxis = (float)(doc.Pages[int.Parse(t.P)].Rect.URY - (shapeH + shapeY));

    //            var isSpecial = true;

    //            if (t.Itype == "highlight" || t.Itype == "image")
    //            {
    //                //Create image stamp
    //                Stream stream;

    //                if (t.Itype == "highlight")
    //                {
    //                    var assembly = Assembly.GetExecutingAssembly();
    //                    var resourcePath = assembly.GetManifestResourceNames()
    //                        .FirstOrDefault(name => name.EndsWith("Test.png"));
    //                    stream = assembly.GetManifestResourceStream(resourcePath);
    //                }
    //                else
    //                {
    //                    var url1 = Path.Combine(uploadPicModel.DocumentId, t.imName);
    //                    stream = await _storageService.Download(url1);
    //                }

    //                var imageStamp = new ImageStamp(stream)
    //                {
    //                    Background = false,
    //                    XIndent = shapeX,
    //                    YIndent = yaxis,
    //                    Height = shapeH,
    //                    Width = shapeW
    //                };

    //                //Add stamp to particular page
    //                doc.Pages[int.Parse(t.P)].AddStamp(imageStamp);

    //                if (stream != null)
    //                    await stream.DisposeAsync();
    //            }
    //        }

    //        using (MemoryStream ms = new MemoryStream())
    //        {
    //            doc.Save(ms);
    //            await _storageService.Upload(ms, url);
    //        }
    //    }

    //    return new DocStatusModel();
    //}

    //[HttpPost]
    //[Route("text")]
    //public async Task<DocStatusModel> UploadText([FromBody] UploadPicModel uploadPicModel)
    //{
    //    var url = Path.Combine(uploadPicModel.DocumentId, "document.pdf");
    //    await using (Stream docStream = await _storageService.Download(url))
    //    using (Document doc = new Document(docStream))
    //    {
    //        foreach (var t in uploadPicModel.Shapes)
    //        {
    //            float shapeX = float.Parse(t.X, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeY = float.Parse(t.Y, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeW = float.Parse(t.W, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeH = float.Parse(t.H, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);

    //            float yaxis = (float)(doc.Pages[int.Parse(t.P)].Rect.URY - (shapeH + shapeY));

    //            var isSpecial = true;

    //            if (t.Itype == "text")
    //            {
    //                //create text stamp
    //                TextStamp textStamp = new TextStamp(t.t);
    //                textStamp.XIndent = shapeX;
    //                textStamp.YIndent = yaxis;
    //                //rotate stamp
    //                textStamp.RotateAngle = 360 - double.Parse(t.fieldType, CultureInfo.InvariantCulture) * 180 / Math.PI;

    //                //set text properties
    //                try
    //                {
    //                    textStamp.TextState.Font = FontRepository.FindFont(t.n);
    //                }
    //                catch
    //                {
    //                    textStamp.TextState.Font = FontRepository.FindFont("Lato");
    //                    //TODO: do something with font
    //                }

    //                textStamp.TextState.FontSize = Convert.ToInt32(t.s) * 0.75f;

    //                if (t.wt == "bold")
    //                {
    //                    textStamp.TextState.FontStyle = FontStyles.Bold;
    //                }

    //                if (t.st == "italic")
    //                {
    //                    textStamp.TextState.FontStyle = FontStyles.Italic;
    //                }

    //                textStamp.TextState.ForegroundColor = Color.Parse(t.c);

    //                //add stamp to particular page
    //                doc.Pages[int.Parse(t.P)].AddStamp(textStamp);
    //            }
    //        }

    //        using (MemoryStream ms = new MemoryStream())
    //        {
    //            doc.Save(ms);
    //            await _storageService.Upload(ms, url);
    //        }
    //    }

    //    return new DocStatusModel();
    //}

    //[HttpPost]
    //[Route("input")]
    //public async Task<DocStatusModel> UploadInputField([FromBody] UploadPicModel uploadPicModel)
    //{
    //    var url = Path.Combine(uploadPicModel.DocumentId, "document.pdf");
    //    await using (Stream docStream = await _storageService.Download(url))
    //    using (Document doc = new Document(docStream))
    //    {
    //        foreach (var t in uploadPicModel.Shapes)
    //        {
    //            float shapeX = float.Parse(t.X, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeY = float.Parse(t.Y, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeW = float.Parse(t.W, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeH = float.Parse(t.H, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);

    //            float yaxis = (float)(doc.Pages[int.Parse(t.P)].Rect.URY - (shapeH + shapeY));

    //            var isSpecial = true;

    //            if (t.Itype == "field" && isSpecial)
    //            {
    //                if (t.fieldType == "Text")
    //                {
    //                    // Get a field
    //                    TextBoxField textBoxField = doc.Form.Fields[Convert.ToInt32(t.imName)] as TextBoxField;
    //                    // Modify field value
    //                    textBoxField.Value = t.t;
    //                }
    //            }
    //        }

    //        using (MemoryStream ms = new MemoryStream())
    //        {
    //            doc.Save(ms);
    //            await _storageService.Upload(ms, url);
    //        }
    //    }

    //    return new DocStatusModel();
    //}

    //[HttpPost]
    //[Route("checkbox")]
    //public async Task<DocStatusModel> UploadCheckBoxField([FromBody] UploadPicModel uploadPicModel)
    //{
    //    var url = Path.Combine(uploadPicModel.DocumentId, "document.pdf");
    //    await using (Stream docStream = await _storageService.Download(url))
    //    using (Document doc = new Document(docStream))
    //    {
    //        foreach (var t in uploadPicModel.Shapes)
    //        {
    //            float shapeX = float.Parse(t.X, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeY = float.Parse(t.Y, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeW = float.Parse(t.W, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeH = float.Parse(t.H, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);

    //            float yaxis = (float)(doc.Pages[int.Parse(t.P)].Rect.URY - (shapeH + shapeY));

    //            var isSpecial = true;

    //            if (t.Itype == "field" && isSpecial)
    //            {
    //                if (t.fieldType == "CheckBox")
    //                {
    //                    // Get a field
    //                    CheckboxField? checkBoxField = doc.Form.Fields[Convert.ToInt32(t.imName)] as CheckboxField;
    //                    if (t.t != "")
    //                        // Modify field value
    //                        checkBoxField.Checked = Convert.ToBoolean(t.t);
    //                }
    //            }
    //        }

    //        using (MemoryStream ms = new MemoryStream())
    //        {
    //            doc.Save(ms);
    //            await _storageService.Upload(ms, url);
    //        }
    //    }

    //    return new DocStatusModel();
    //}

    //[HttpPost]
    //[Route("radio")]
    //public async Task<DocStatusModel> UploadRadioField([FromBody] UploadPicModel uploadPicModel)
    //{
    //    var url = Path.Combine(uploadPicModel.DocumentId, "document.pdf");
    //    await using (Stream docStream = await _storageService.Download(url))
    //    using (Document doc = new Document(docStream))
    //    {
    //        foreach (var t in uploadPicModel.Shapes)
    //        {
    //            float shapeX = float.Parse(t.X, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeY = float.Parse(t.Y, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeW = float.Parse(t.W, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeH = float.Parse(t.H, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);

    //            float yaxis = (float)(doc.Pages[int.Parse(t.P)].Rect.URY - (shapeH + shapeY));

    //            var isSpecial = true;

    //            if (t.Itype == "field" && isSpecial)
    //            {
    //                if (t.fieldType == "Radio")
    //                {
    //                    RadioButtonOptionField field =
    //                        (RadioButtonOptionField)doc.Form.Fields[Convert.ToInt32(t.imName)];

    //                    RadioButtonField rbf = (RadioButtonField)field.Parent;
    //                    if (Convert.ToBoolean(t.t))
    //                    {
    //                        rbf.Selected = rbf.Options[field.OptionName].Index;
    //                    }
    //                    else
    //                    {
    //                        field.ActiveState = "Off";
    //                    }
    //                }
    //            }
    //        }

    //        using (MemoryStream ms = new MemoryStream())
    //        {
    //            doc.Save(ms);
    //            await _storageService.Upload(ms, url);
    //        }
    //    }

    //    return new DocStatusModel();
    //}

    //[HttpPost]
    //[Route("combobox")]
    //public async Task<DocStatusModel> UploadComboBoxField([FromBody] UploadPicModel uploadPicModel)
    //{
    //    var url = Path.Combine(uploadPicModel.DocumentId, "document.pdf");
    //    await using (Stream docStream = await _storageService.Download(url))
    //    using (Document doc = new Document(docStream))
    //    {
    //        foreach (var t in uploadPicModel.Shapes)
    //        {
    //            float shapeX = float.Parse(t.X, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeY = float.Parse(t.Y, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeW = float.Parse(t.W, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);
    //            float shapeH = float.Parse(t.H, CultureInfo.InvariantCulture) * 72 / 150 /
    //                           float.Parse(t.ratio, CultureInfo.InvariantCulture);

    //            float yaxis = (float)(doc.Pages[int.Parse(t.P)].Rect.URY - (shapeH + shapeY));

    //            var isSpecial = true;

    //            if (t.Itype == "field" && isSpecial)
    //            {
    //                if (t.fieldType == "ComboBox")
    //                {
    //                    // Get a field
    //                    ComboBoxField? comboBoxField = doc.Form.Fields[Convert.ToInt32(t.imName)] as ComboBoxField;
    //                    var values = t.t.Split(new[] { "^^^" }, StringSplitOptions.None)[0];

    //                    foreach (var item in comboBoxField.Options)
    //                    {
    //                        if (item.Value == values)
    //                        {
    //                            comboBoxField.Selected = item.Index;
    //                        }
    //                    }
    //                }
    //            }
    //        }

    //        using (MemoryStream ms = new MemoryStream())
    //        {
    //            doc.Save(ms);
    //            await _storageService.Upload(ms, url);
    //        }
    //    }

    //    return new DocStatusModel();
    //}

}
