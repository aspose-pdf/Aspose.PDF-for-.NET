using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.InsertPages
{
    public class InsertPagesBetweenNumbers
    {
        public static void Run()
        {
            // ExStart:InsertPagesBetweenNumbers
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Insert pages
            pdfEditor.Insert(dataDir + "MultiplePages.pdf", 1, dataDir + "InsertPages.pdf", 2, 5,  dataDir + "InsertPagesBetweenNumbers_out.pdf");
            // ExEnd:InsertPagesBetweenNumbers
        }
    }
}