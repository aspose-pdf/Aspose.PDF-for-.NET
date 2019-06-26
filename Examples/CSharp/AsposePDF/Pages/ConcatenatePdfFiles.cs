using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class ConcatenatePdfFiles
    {
        public static void Run()
        {
            // ExStart:ConcatenatePdfFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            // Open first document
            Document pdfDocument1 = new Document(dataDir + "Concat1.pdf");
            // Open second document
            Document pdfDocument2 = new Document(dataDir + "Concat2.pdf");

            // Add pages of second document to the first
            pdfDocument1.Pages.Add(pdfDocument2.Pages);

            dataDir = dataDir + "ConcatenatePdfFiles_out.pdf";
            // Save concatenated output file
            pdfDocument1.Save(dataDir);
            // ExEnd:ConcatenatePdfFiles
            System.Console.WriteLine("\nPDFs are concatenated successfully.\nFile saved at " + dataDir);
        }
    }
}