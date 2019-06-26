using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ConcatenateDocuments
{
    public class ConcatenateBlankPdfUsingStreams
    {
        public static void Run()
        {
            // ExStart:ConcatenateBlankPdfUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream1 = new FileStream( dataDir + "input.pdf", FileMode.Open);
            FileStream inputStream2 = new FileStream( dataDir + "input2.pdf", FileMode.Open);
            FileStream blankStream = new FileStream(dataDir + "blank.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "ConcatenateBlankPdfUsingStreams_out.pdf", FileMode.Create);
            // Concatenate file
            pdfEditor.Concatenate(inputStream1, inputStream2, blankStream, outputStream);
            // ExEnd:ConcatenateBlankPdfUsingStreams
        }
       
    }
}