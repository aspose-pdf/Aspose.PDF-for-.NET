using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeNUp
{
    public class UsingPageSizeHorizontalAndVerticalValues
    {
        public static void Run()
        {
            // ExStart:UsingPageSizeHorizontalAndVerticalValues
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Make NUp
            pdfEditor.MakeNUp(dataDir + "input.pdf", "UsingPageSizeHorizontalAndVerticalValues_out.pdf", 2, 3);
            // ExEnd:UsingPageSizeHorizontalAndVerticalValues
        }
    }
}