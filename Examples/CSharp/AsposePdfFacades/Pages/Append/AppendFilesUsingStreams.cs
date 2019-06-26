using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.Append
{
    public class AppendFilesUsingStreams
    {
        public static void Run()
        {
            // ExStart:AppendFilesUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream = new FileStream( dataDir + "input.pdf", FileMode.Open);
            FileStream portStream = new FileStream(dataDir + "input2.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "AppendFilesUsingStreams_out.pdf", FileMode.Create);
            // Append file
            pdfEditor.Append(inputStream, portStream, 1, 1, outputStream);	
            // ExEnd:AppendFilesUsingStreams
        }
    }
}