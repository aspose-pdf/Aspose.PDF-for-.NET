using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.InsertPages
{
    public class InsertPagesBetweenNumbersUsingStreams
    {
        public static void Run()
        {
            // ExStart:InsertPagesBetweenNumbersUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream = new FileStream(dataDir + "MultiplePages.pdf", FileMode.Open);
            FileStream portStream = new FileStream(dataDir + "InsertPages.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "InsertPagesBetweenNumbersUsingStreams_out.pdf", FileMode.Create);
            // Insert pages
            pdfEditor.Insert(inputStream, 1, portStream, 1, 4, outputStream);
            // ExEnd:InsertPagesBetweenNumbersUsingStreams
        }
    }
}