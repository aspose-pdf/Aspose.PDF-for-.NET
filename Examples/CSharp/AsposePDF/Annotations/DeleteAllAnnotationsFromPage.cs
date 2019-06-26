using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class DeleteAllAnnotationsFromPage
    {
        public static void Run()
        {
            // ExStart:DeleteAllAnnotationsFromPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            // Open document
            Document pdfDocument = new Document(dataDir + "DeleteAllAnnotationsFromPage.pdf");

            // Delete particular annotation
            pdfDocument.Pages[1].Annotations.Delete();

            dataDir = dataDir + "DeleteAllAnnotationsFromPage_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            // ExEnd:DeleteAllAnnotationsFromPage
            Console.WriteLine("\nAll annotation from a page deleted successfully.\nFile saved at " + dataDir);
        }
    }
}