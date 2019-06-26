using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.Append
{
    public class AppendArrayOfFilesUsingStream
    {
        public static void Run()
        {
            // ExStart:AppendArrayOfFilesUsingStream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Input and output stream
            FileStream inputStream = new FileStream( dataDir + "input.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "AppendArrayOfFilesUsingStream_out.pdf", FileMode.Create);
            // Srray of streams
            FileStream[] portStreams = new FileStream[2];
            portStreams[0] = new FileStream( dataDir + "input2.pdf", FileMode.Open);
            portStreams[1] = new FileStream(dataDir + "input3.pdf", FileMode.Open);

            // Append file
            pdfEditor.Append(inputStream, portStreams, 1, 1, outputStream);
            // ExEnd:AppendArrayOfFilesUsingStream
        }
    }
}