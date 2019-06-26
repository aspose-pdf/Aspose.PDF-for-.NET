using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeBooklet
{
    public class MakeBookletUsingPageSizeAndStreams
    {
        public static void Run()
        {
            // ExStart:MakeBookletUsingPageSizeAndStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream = new FileStream(dataDir + "input.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "MakeBookletUsingPageSizeAndStreams_out.pdf", FileMode.Create);
            // Make booklet
            pdfEditor.MakeBooklet(inputStream, outputStream, PageSize.A5);
            // ExEnd:MakeBookletUsingPageSizeAndStreams
        }
    }
}