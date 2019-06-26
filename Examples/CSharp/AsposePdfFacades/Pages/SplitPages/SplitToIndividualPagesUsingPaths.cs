using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.SplitPages
{
    public class SplitToIndividualPagesUsingPaths
    {
        public static void Run()
        {
            // ExStart:SplitToIndividualPagesUsingPaths
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            int fileNumber = 1;
            // Split to pages
            MemoryStream[] outBuffer = pdfEditor.SplitToPages(dataDir + "input.pdf");
            // Save individual files
            foreach (MemoryStream aStream in outBuffer)
            {
                FileStream outStream = new FileStream(dataDir + "File_" + fileNumber.ToString() + "_out.pdf", FileMode.Create);
                aStream.WriteTo(outStream);
                outStream.Close();
                fileNumber++;
            }
            // ExEnd:SplitToIndividualPagesUsingPaths
        }
    }
}