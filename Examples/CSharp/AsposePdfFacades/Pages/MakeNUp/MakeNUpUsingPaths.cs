using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeNUp
{
    public class MakeNUpUsingPaths
    {
        public static void Run()
        {
            // ExStart:MakeNUpUsingPaths
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Make NUp
            pdfEditor.MakeNUp(dataDir + "input.pdf", dataDir + "input2.pdf", "MakeNUpUsingPaths_out.pdf");
            // ExEnd:MakeNUpUsingPaths
        }
    }
}