using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeNUp
{
    public class UsingArrayOfFilesAndStreams
    {
        public static void Run()
        {
            // ExStart:UsingArrayOfFilesAndStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream[] fileStreams = new FileStream[2];
            fileStreams[0] = new FileStream(dataDir + "input.pdf", FileMode.Open);
            fileStreams[1] = new FileStream(dataDir + "input2.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "UsingArrayOfFilesAndStreams_out.pdf", FileMode.Create);
            // Make NUp
            pdfEditor.MakeNUp(fileStreams, outputStream, true);
            // ExEnd:UsingArrayOfFilesAndStreams
        }
    }
}