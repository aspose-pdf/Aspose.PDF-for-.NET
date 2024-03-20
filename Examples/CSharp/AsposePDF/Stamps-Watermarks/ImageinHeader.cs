using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class ImageInHeader
    {
        public static void Run()
        {
            // ExStart:ImageinHeader
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Open document
            Document pdfDocument = new Document(dataDir+ "ImageinHeader.pdf");

            // Create header
            ImageStamp imageStamp = new ImageStamp(dataDir+ "aspose-logo.jpg");
            // Set properties of the stamp
            imageStamp.TopMargin = 10;
            imageStamp.HorizontalAlignment = HorizontalAlignment.Center;
            imageStamp.VerticalAlignment = VerticalAlignment.Top;
            // Add header on all pages
            foreach (Page page in pdfDocument.Pages)
            {
                page.AddStamp(imageStamp);
            }
            dataDir = dataDir + "ImageinHeader_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            // ExEnd:ImageinHeader
            Console.WriteLine("\nImage in header added successfully.\nFile saved at " + dataDir);                        
        }
    }
}