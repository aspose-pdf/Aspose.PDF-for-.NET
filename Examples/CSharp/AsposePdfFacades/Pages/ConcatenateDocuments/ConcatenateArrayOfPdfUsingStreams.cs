using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ConcatenateDocuments
{
    public class ConcatenateArrayOfPdfUsingStreams
    {
        public static void Run()
        {
            // ExStart:ConcatenateArrayOfPdfUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Output stream
            FileStream outputStream = new FileStream(dataDir + "ConcatenateArrayOfPdfUsingStreams_out.pdf", FileMode.Create);
            // Array of streams
            FileStream[] inputStreams = new FileStream[2];
            inputStreams[0] = new FileStream(dataDir + "input.pdf", FileMode.Open);
            inputStreams[1] = new FileStream(dataDir + "input2.pdf", FileMode.Open);
            // Concatenate file
            pdfEditor.Concatenate(inputStreams, outputStream);
            // ExEnd:ConcatenateArrayOfPdfUsingStreams
        }
       
    }
}