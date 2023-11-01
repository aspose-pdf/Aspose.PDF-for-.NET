using System.Globalization;
using Aspose.Pdf;
using Aspose.Pdf.Devices;
using Aspose.PDF.Editor.Services.Interface;
using Aspose.Pdf.Forms;
using ImageMagick;
using System.Threading.Tasks;
using System.IO;

namespace Aspose.PDF.Editor.Services
{
    public class ImageService : IImageService
    {
        private readonly IStorageService _storageService;

        public ImageService(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public async Task<string> ImageConverter(Stream docStream, string folder, string fileName)
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

        public async Task<(string, string)> ScaleImage(Stream imgStream, string folder, string fileName, int maxWidth)
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
}