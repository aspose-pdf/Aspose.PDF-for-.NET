using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class AvoidSavingImages
    {
        public static void Run()
        {
            try
            {
                // ExStart:AvoidSavingImages
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();

                Document pdfDocument = new Document(dataDir + "input.pdf");
                
                // Create HtmlSaveOption with tested feature
                HtmlSaveOptions saveOptions = new HtmlSaveOptions();
                saveOptions.FixedLayout = true;
                saveOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground;

                pdfDocument.Save(dataDir + "AvoidSavingImages_out.html", saveOptions);
                // ExEnd:AvoidSavingImages
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}