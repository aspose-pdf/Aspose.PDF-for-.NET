using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class GetNumberOfPages
    {
        public static void Run()
        {
            // ExStart:GetNumberOfPages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetNumberOfPages.pdf");

            // Get page count
            System.Console.WriteLine("Page Count : {0}", pdfDocument.Pages.Count);
            // ExEnd:GetNumberOfPages
        }
    }
}