using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeBooklet
{
    public class MakeBookletUsingPaths
    {
        public static void Run()
        {
            // ExStart:MakeBookletUsingPaths
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Make booklet
            pdfEditor.MakeBooklet(dataDir + "input.pdf", dataDir + "MakeBookletUsingPaths_out.pdf");
            // ExEnd:MakeBookletUsingPaths
        }
    }
}