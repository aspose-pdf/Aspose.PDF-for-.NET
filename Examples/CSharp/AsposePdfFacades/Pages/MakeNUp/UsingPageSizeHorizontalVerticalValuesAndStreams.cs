using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeNUp
{
    public class UsingPageSizeHorizontalVerticalValuesAndStreams
    {
        public static void Run()
        {
            // ExStart:UsingPageSizeHorizontalVerticalValuesAndStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream = new FileStream(dataDir + "input.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "UsingPageSizeHorizontalVerticalValuesAndStreams_out.pdf", FileMode.Create);
            // Make NUp
            pdfEditor.MakeNUp(inputStream, outputStream, 2, 3);
            // ExEnd:UsingPageSizeHorizontalVerticalValuesAndStreams
        }
    }
}