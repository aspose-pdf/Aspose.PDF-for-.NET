using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeNUp
{
    public class MakeNUpUsingStreams
    {
        public static void Run()
        {
            // ExStart:MakeNUpUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream1 = new FileStream(dataDir + "input.pdf", FileMode.Open);
            FileStream inputStream2 = new FileStream(dataDir + "input2.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "MakeNUpUsingStreams_out.pdf", FileMode.Create);
            // Make NUp
            pdfEditor.MakeNUp(inputStream1, inputStream2, outputStream);
            // ExEnd:MakeNUpUsingStreams
        }
    }
}