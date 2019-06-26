using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeNUp
{
    public class MakeNUpUsingPageSizeAndPaths
    {
        public static void Run()
        {
            // ExStart:MakeNUpUsingPageSizeAndPaths
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Make NUp
            pdfEditor.MakeNUp(dataDir + "MultiplePages.pdf", dataDir + "MakeNUpUsingPageSizeAndPaths_out.pdf", 2, 3, PageSize.A5);
            // ExEnd:MakeNUpUsingPageSizeAndPaths
        }
    }
}