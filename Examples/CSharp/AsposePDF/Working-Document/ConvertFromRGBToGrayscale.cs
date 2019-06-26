using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class ConvertFromRGBToGrayscale 
    {
        public static void Run()
        {
            // ExStart:ConvertFromRGBToGrayscale 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Load source PDF file
            using (Document document = new Document(dataDir + "input.pdf"))
            {
                Aspose.Pdf.RgbToDeviceGrayConversionStrategy strategy = new Aspose.Pdf.RgbToDeviceGrayConversionStrategy();
                for (int idxPage = 1; idxPage <= document.Pages.Count; idxPage++)
                {
                    // Get instance of particular page inside PDF
                    Page page = document.Pages[idxPage];
                    // Convert the RGB colorspace image to GrayScale colorspace
                    strategy.Convert(page);
                }
                // Save resultant file
                document.Save(dataDir + "Test-gray_out.pdf");
            }
            // ExEnd:ConvertFromRGBToGrayscale             
        }
    }
}