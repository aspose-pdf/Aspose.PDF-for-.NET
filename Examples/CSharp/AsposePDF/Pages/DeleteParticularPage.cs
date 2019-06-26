using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class DeleteParticularPage
    {
        public static void Run()
        {
            // ExStart:DeleteParticularPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            // Open document
            Document pdfDocument = new Document(dataDir + "DeleteParticularPage.pdf");

            // Delete a particular page
            pdfDocument.Pages.Delete(2);

            dataDir = dataDir + "DeleteParticularPage_out.pdf";
            // Save updated PDF
            pdfDocument.Save(dataDir);
            // ExEnd:DeleteParticularPage
            System.Console.WriteLine("\nParticular page deleted successfully.\nFile saved at " + dataDir);
        }
    }
}