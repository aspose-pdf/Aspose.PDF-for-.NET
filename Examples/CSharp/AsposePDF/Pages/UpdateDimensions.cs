using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class UpdateDimensions
    {
        public static void Run()
        {
            // ExStart:UpdateDimensions
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            // Open document
            Document pdfDocument = new Document(dataDir + "UpdateDimensions.pdf");

            // Get page collection
            PageCollection pageCollection = pdfDocument.Pages;

            // Get particular page
            Page pdfPage = pageCollection[1];

            // Set the page size as A4 (11.7 x 8.3 in) and in Aspose.Pdf, 1 inch = 72 points
            // So A4 dimensions in points will be (842.4, 597.6)
            pdfPage.SetPageSize(597.6, 842.4);

            dataDir = dataDir + "UpdateDimensions_out.pdf";
            // Save the updated document
            pdfDocument.Save(dataDir);
            // ExEnd:UpdateDimensions
            System.Console.WriteLine("\nPage dimensions updated successfully.\nFile saved at " + dataDir);

        }
    }
}