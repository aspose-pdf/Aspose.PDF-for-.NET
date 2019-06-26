using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ExtractPages
{
    public class ExtractPagesBetweenTwoNumbersUsingStreams
    {
        public static void Run()
        {
            // ExStart:ExtractPagesBetweenTwoNumbersUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream = new FileStream(dataDir + "MultiplePages.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "ExtractPagesBetweenTwoNumbers_out.pdf", FileMode.Create);
            // Extract pages
            pdfEditor.Extract(inputStream, 1, 3, outputStream);
            // ExEnd:ExtractPagesBetweenTwoNumbersUsingStreams
        }
    }
}