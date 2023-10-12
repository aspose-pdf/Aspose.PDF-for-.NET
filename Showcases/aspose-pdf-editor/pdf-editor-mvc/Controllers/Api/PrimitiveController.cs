using System.Reflection;
using Aspose.Pdf;
using Aspose.Pdf.Forms;
using Aspose.Pdf.Text;
using Microsoft.AspNetCore.Mvc;
using Aspose.PDF.Editor.Models;
using Aspose.PDF.Editor.Services.Interface;

namespace Aspose.PDF.Editor.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PrimitiveController : Controller
{
    private readonly IStorageService _storageService;

    public PrimitiveController(IStorageService storageService)
    {
        _storageService = storageService;
    }

    [HttpPost]
    [Route("image")]
    public async Task<DocStatusModelN> UploadImage([FromBody] UploadPicModelN uploadPicModel)
    {
        var url = Path.Combine(uploadPicModel.DocumentId, "document.pdf");
        await using (Stream docStream = await _storageService.Download(url))
        using (Document doc = new Document(docStream))
        {
            foreach (var t in uploadPicModel.Shapes)
            {
                float shapeX = float.Parse(t.X.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeY = float.Parse(t.Y.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeW = float.Parse(t.W.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeH = float.Parse(t.H.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));

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
                            .FirstOrDefault(name => name.EndsWith("Test.png"));
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
            }

            using (MemoryStream ms = new MemoryStream())
            {
                doc.Save(ms);
                await _storageService.Upload(ms, url);
            }
        }

        return new DocStatusModelN();
    }

    [HttpPost]
    [Route("text")]
    public async Task<DocStatusModelN> UploadText([FromBody] UploadPicModelN uploadPicModel)
    {
        var url = Path.Combine(uploadPicModel.DocumentId, "document.pdf");
        await using (Stream docStream = await _storageService.Download(url))
        using (Document doc = new Document(docStream))
        {
            foreach (var t in uploadPicModel.Shapes)
            {
                float shapeX = float.Parse(t.X.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeY = float.Parse(t.Y.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeW = float.Parse(t.W.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeH = float.Parse(t.H.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));

                float yaxis = (float)(doc.Pages[int.Parse(t.P)].Rect.URY - (shapeH + shapeY));

                var isSpecial = true;

                if (t.Itype == "text")
                {
                    //create text stamp
                    TextStamp textStamp = new TextStamp(t.t);
                    textStamp.XIndent = shapeX;
                    textStamp.YIndent = yaxis;
                    //rotate stamp
                    textStamp.RotateAngle = 360 - Convert.ToDouble(t.fieldType) * 180 / Math.PI;

                    //set text properties
                    try
                    {
                        textStamp.TextState.Font = FontRepository.FindFont(t.n);
                    }
                    catch
                    {
                        textStamp.TextState.Font = FontRepository.FindFont("Lato");
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
            }

            using (MemoryStream ms = new MemoryStream())
            {
                doc.Save(ms);
                await _storageService.Upload(ms, url);
            }
        }

        return new DocStatusModelN();
    }

    [HttpPost]
    [Route("input")]
    public async Task<DocStatusModelN> UploadInputField([FromBody] UploadPicModelN uploadPicModel)
    {
        var url = Path.Combine(uploadPicModel.DocumentId, "document.pdf");
        await using (Stream docStream = await _storageService.Download(url))
        using (Document doc = new Document(docStream))
        {
            foreach (var t in uploadPicModel.Shapes)
            {
                float shapeX = float.Parse(t.X.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeY = float.Parse(t.Y.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeW = float.Parse(t.W.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeH = float.Parse(t.H.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));

                float yaxis = (float)(doc.Pages[int.Parse(t.P)].Rect.URY - (shapeH + shapeY));

                var isSpecial = true;

                if (t.Itype == "field" && isSpecial)
                {
                    if (t.fieldType == "Text")
                    {
                        // Get a field
                        TextBoxField textBoxField = doc.Form.Fields[Convert.ToInt32(t.imName)] as TextBoxField;
                        // Modify field value
                        textBoxField.Value = t.t;
                    }
                }
            }

            using (MemoryStream ms = new MemoryStream())
            {
                doc.Save(ms);
                await _storageService.Upload(ms, url);
            }
        }

        return new DocStatusModelN();
    }

    [HttpPost]
    [Route("checkbox")]
    public async Task<DocStatusModelN> UploadCheckBoxField([FromBody] UploadPicModelN uploadPicModel)
    {
        var url = Path.Combine(uploadPicModel.DocumentId, "document.pdf");
        await using (Stream docStream = await _storageService.Download(url))
        using (Document doc = new Document(docStream))
        {
            foreach (var t in uploadPicModel.Shapes)
            {
                float shapeX = float.Parse(t.X.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeY = float.Parse(t.Y.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeW = float.Parse(t.W.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeH = float.Parse(t.H.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));

                float yaxis = (float)(doc.Pages[int.Parse(t.P)].Rect.URY - (shapeH + shapeY));

                var isSpecial = true;

                if (t.Itype == "field" && isSpecial)
                {
                    if (t.fieldType == "CheckBox")
                    {
                        // Get a field
                        CheckboxField? checkBoxField = doc.Form.Fields[Convert.ToInt32(t.imName)] as CheckboxField;
                        if (t.t != "")
                            // Modify field value
                            checkBoxField.Checked = Convert.ToBoolean(t.t);
                    }
                }
            }

            using (MemoryStream ms = new MemoryStream())
            {
                doc.Save(ms);
                await _storageService.Upload(ms, url);
            }
        }

        return new DocStatusModelN();
    }

    [HttpPost]
    [Route("radio")]
    public async Task<DocStatusModelN> UploadRadioField([FromBody] UploadPicModelN uploadPicModel)
    {
        var url = Path.Combine(uploadPicModel.DocumentId, "document.pdf");
        await using (Stream docStream = await _storageService.Download(url))
        using (Document doc = new Document(docStream))
        {
            foreach (var t in uploadPicModel.Shapes)
            {
                float shapeX = float.Parse(t.X.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeY = float.Parse(t.Y.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeW = float.Parse(t.W.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeH = float.Parse(t.H.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));

                float yaxis = (float)(doc.Pages[int.Parse(t.P)].Rect.URY - (shapeH + shapeY));

                var isSpecial = true;

                if (t.Itype == "field" && isSpecial)
                {
                    if (t.fieldType == "Radio")
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
                }
            }

            using (MemoryStream ms = new MemoryStream())
            {
                doc.Save(ms);
                await _storageService.Upload(ms, url);
            }
        }

        return new DocStatusModelN();
    }

    [HttpPost]
    [Route("combobox")]
    public async Task<DocStatusModelN> UploadComboBoxField([FromBody] UploadPicModelN uploadPicModel)
    {
        var url = Path.Combine(uploadPicModel.DocumentId, "document.pdf");
        await using (Stream docStream = await _storageService.Download(url))
        using (Document doc = new Document(docStream))
        {
            foreach (var t in uploadPicModel.Shapes)
            {
                float shapeX = float.Parse(t.X.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeY = float.Parse(t.Y.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeW = float.Parse(t.W.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));
                float shapeH = float.Parse(t.H.Replace(',', '.')) * 72 / 150 /
                               (float)Convert.ToDouble(t.ratio.Replace(',', '.'));

                float yaxis = (float)(doc.Pages[int.Parse(t.P)].Rect.URY - (shapeH + shapeY));

                var isSpecial = true;

                if (t.Itype == "field" && isSpecial)
                {
                    if (t.fieldType == "ComboBox")
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

        return new DocStatusModelN();
    }

}
