using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class ImageInFooter
    {
        public static void Run()
        {
            // ExStart:ImageInFooter
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Open document
            Document pdfDocument = new Document(dataDir+ "ImageInFooter.pdf");
            // Create footer
            ImageStamp imageStamp = new ImageStamp(dataDir+ "aspose-logo.jpg");
            // Set properties of the stamp
            imageStamp.BottomMargin = 10;
            imageStamp.HorizontalAlignment = HorizontalAlignment.Center;
            imageStamp.VerticalAlignment = VerticalAlignment.Bottom;
            // Add footer on all pages
            foreach (Page page in pdfDocument.Pages)
            {
                page.AddStamp(imageStamp);
            }
            dataDir = dataDir + "ImageInFooter_out.pdf";
            // Save updated PDF file
            pdfDocument.Save(dataDir);
            // ExEnd:ImageInFooter
            Console.WriteLine("\nImage in footer added successfully.\nFile saved at " + dataDir);
        }
    }
}