using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.SplitPages
{
    public class SplitPagesUsingStreams
    {
        public static void Run()
        {
            // ExStart:SplitPagesUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream = new FileStream(dataDir + "MultiplePages.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "SplitPagesUsingStreams_out.pdf", FileMode.Create);
            // Split pages
            pdfEditor.SplitFromFirst(inputStream, 3, outputStream);
            // ExEnd:SplitPagesUsingStreams
        }
    }
}