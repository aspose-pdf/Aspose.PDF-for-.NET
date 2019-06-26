using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class GetDimensions
    {
        public static void Run()
        {
            // ExStart:GetDimensions
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            // Open document
            Document pdfDocument = new Document(dataDir + "UpdateDimensions.pdf");

            // Adds a blank page to pdf document
            Page page = pdfDocument.Pages.Count > 0 ? pdfDocument.Pages[1] : pdfDocument.Pages.Add();
            // Get page height and width information
            Console.WriteLine(page.GetPageRect(true).Width.ToString() + ":" + page.GetPageRect(true).Height);
            // Rotate page at 90 degree angle
            page.Rotate = Rotation.on90;
            // Get page height and width information
            Console.WriteLine(page.GetPageRect(true).Width.ToString() + ":" + page.GetPageRect(true).Height);
            // ExEnd:GetDimensions          
        }
    }
}