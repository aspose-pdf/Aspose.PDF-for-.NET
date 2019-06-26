using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class GetNumberofPages
    {
        public static void Run()
        {
            // ExStart:GetNumberofPages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetNumberofPages.pdf");

            // Get page count
            System.Console.WriteLine("Page Count : {0}", pdfDocument.Pages.Count);
            // ExEnd:GetNumberofPages
        }
    }
}