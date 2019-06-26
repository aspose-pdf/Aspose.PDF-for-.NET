using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ExtractPages
{
    public class ExtractArrayOfPagesUsingStreams
    {
        public static void Run()
        {
            // ExStart:ExtractArrayOfPagesUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream = new FileStream( dataDir + "MultiplePages.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "ExtractArrayOfPagesUsingStreams_out.pdf", FileMode.Create);
            int[] pagesToExtract = new int[] { 1, 2};
            // Extract pages
            pdfEditor.Extract(inputStream, pagesToExtract, outputStream);
            // ExEnd:ExtractArrayOfPagesUsingStreams
        }
    }
}