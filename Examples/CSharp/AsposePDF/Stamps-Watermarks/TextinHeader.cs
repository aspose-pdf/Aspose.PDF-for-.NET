using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class TextinHeader
    {
        public static void Run()
        {
            // ExStart:TextinHeader
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Open document
            Document pdfDocument = new Document(dataDir+ "TextinHeader.pdf");

            // Create header
            TextStamp textStamp = new TextStamp("Header Text");
            // Set properties of the stamp
            textStamp.TopMargin = 10;
            textStamp.HorizontalAlignment = HorizontalAlignment.Center;
            textStamp.VerticalAlignment = VerticalAlignment.Top;
            // Add header on all pages
            foreach (Page page in pdfDocument.Pages)
            {
                page.AddStamp(textStamp);
            }

            // Save updated document
            pdfDocument.Save(dataDir+ "TextinHeader_out.pdf");
            // ExEnd:TextinHeader
            Console.WriteLine("\nText in header added successfully.\nFile saved at " + dataDir);
            
        }
    }
}