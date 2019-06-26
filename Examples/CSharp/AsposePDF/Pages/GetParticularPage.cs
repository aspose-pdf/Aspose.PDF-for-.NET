using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class GetParticularPage
    {
        public static void Run()
        {
            // ExStart:GetParticularPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetParticularPage.pdf");

            // Get particular page
            Page pdfPage = pdfDocument.Pages[2];

            // Save the page as PDF file
            Document newDocument = new Document();

            newDocument.Pages.Add(pdfPage);

            dataDir = dataDir + "GetParticularPage_out.pdf";
            newDocument.Save(dataDir);
            // ExEnd:GetParticularPage
            System.Console.WriteLine("\nParticular page accessed successfully.\nFile saved at " + dataDir);
        }
    }
}