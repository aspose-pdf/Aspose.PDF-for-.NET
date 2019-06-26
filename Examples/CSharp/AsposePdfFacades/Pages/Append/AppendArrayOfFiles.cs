using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.Append
{
    public class AppendArrayOfFiles
    {
        public static void Run()
        {
            // ExStart:AppendArrayOfFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Array of files
            string[] portFiles = new string[2];
            portFiles[0] = dataDir + "input.pdf";
            portFiles[1] = dataDir + "input2.pdf";
            // Append file
            pdfEditor.Append(dataDir + "input3.pdf", portFiles, 1, 1, dataDir + "AppendArrayOfFiles_out.pdf");
            // ExEnd:AppendArrayOfFiles
        }
    }
}