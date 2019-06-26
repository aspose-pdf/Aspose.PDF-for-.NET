using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class PageNumberStamps
    {
        public static void Run()
        {
            // ExStart:PageNumberStamps
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Open document
            Document pdfDocument = new Document(dataDir+ "PageNumberStamp.pdf");

            // Create page number stamp
            PageNumberStamp pageNumberStamp = new PageNumberStamp();
            // Whether the stamp is background
            pageNumberStamp.Background = false;
            pageNumberStamp.Format = "Page # of " + pdfDocument.Pages.Count;
            pageNumberStamp.BottomMargin = 10;
            pageNumberStamp.HorizontalAlignment = HorizontalAlignment.Center;
            pageNumberStamp.StartingNumber = 1;
            // Set text properties
            pageNumberStamp.TextState.Font = FontRepository.FindFont("Arial");
            pageNumberStamp.TextState.FontSize = 14.0F;
            pageNumberStamp.TextState.FontStyle = FontStyles.Bold;
            pageNumberStamp.TextState.FontStyle = FontStyles.Italic;
            pageNumberStamp.TextState.ForegroundColor = Color.Aqua;

            // Add stamp to particular page
            pdfDocument.Pages[1].AddStamp(pageNumberStamp);

            dataDir = dataDir + "PageNumberStamp_out.pdf";
            // Save output document
            pdfDocument.Save(dataDir);
            // ExEnd:PageNumberStamps
            Console.WriteLine("\nPage number stamp added successfully.\nFile saved at " + dataDir);
            
        }
    }
}