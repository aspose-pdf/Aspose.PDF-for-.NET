using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeBooklet
{
    public class MakeBookletUsingStreams
    {
        public static void Run()
        {
            // ExStart:MakeBookletUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream = new FileStream( dataDir + "input.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "MakeBookletUsingStreams_out.pdf", FileMode.Create);
            // Make booklet
            pdfEditor.MakeBooklet(inputStream, outputStream);
            // ExEnd:MakeBookletUsingStreams
        }
    }
}