using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.StampsWatermarks
{
    public class ExtractImageImageStamp
    {
        public static void Run()
        {
            try
            {
                // ExStart:ExtractImageImageStamp
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();
                // Instantiate PdfContentEditor Object
                PdfContentEditor pdfContentEditor = new PdfContentEditor();

                // Bind input PDF file
                pdfContentEditor.BindPdf(dataDir + "ExtractImage-ImageStamp.pdf");

                // Get Stamp info for the first stamp
                StampInfo[] infos = pdfContentEditor.GetStamps(1);

                // Get the image from Stamp Info           
                System.Drawing.Image image = infos[0].Image;

                // Save the extracted image
                image.Save(dataDir + "image_out.jpg");
                // ExEnd:ExtractImageImageStamp  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}