using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class TextInFooter
    {
        public static void Run()
        {
            // ExStart:TextinFooter
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Open document
            Document pdfDocument = new Document(dataDir+ "TextinFooter.pdf");
            // Create footer
            TextStamp textStamp = new TextStamp("Footer Text");
            // Set properties of the stamp
            textStamp.BottomMargin = 10;
            textStamp.HorizontalAlignment = HorizontalAlignment.Center;
            textStamp.VerticalAlignment = VerticalAlignment.Bottom;
            // Add footer on all pages
            foreach (Page page in pdfDocument.Pages)
            {
                page.AddStamp(textStamp);
            }
            dataDir = dataDir + "TextinFooter_out.pdf";
            // Save updated PDF file
            pdfDocument.Save(dataDir);
            // ExEnd:TextinFooter
            Console.WriteLine("\nText in footer added successfully.\nFile saved at " + dataDir);
        }
    }
}