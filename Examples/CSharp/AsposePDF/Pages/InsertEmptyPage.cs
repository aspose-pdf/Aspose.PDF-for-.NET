using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class InsertEmptyPage
    {
        public static void Run()
        {
            // ExStart:InsertEmptyPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            // Open document
            Document pdfDocument1 = new Document(dataDir + "InsertEmptyPage.pdf");

            // Insert a empty page in a PDF
            pdfDocument1.Pages.Insert(2);
            dataDir = dataDir + "InsertEmptyPage_out.pdf";
            // Save output file
            pdfDocument1.Save(dataDir);
            // ExEnd:InsertEmptyPage
            System.Console.WriteLine("\nEmpty page inserted successfully.\nFile saved at " + dataDir);
        }
    }
}