using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.SplitPages
{
    public class SplitToIndividualPagesUsingStreams
    {
        public static void Run()
        {
            // ExStart:SplitToIndividualPagesUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEdito object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create input stream
            FileStream inputStream = new FileStream(dataDir + "input.pdf", FileMode.Open);
            int fileNumber = 1;
            // Split to pages
            MemoryStream[] outBuffer = pdfEditor.SplitToPages(inputStream);
            // Save individual files
            foreach (MemoryStream aStream in outBuffer)
            {
                FileStream outStream = new FileStream(dataDir + "File_" + fileNumber.ToString() + "_out.pdf", FileMode.Create);
                aStream.WriteTo(outStream);
                outStream.Close();
                fileNumber++;
            }
            // ExEnd:SplitToIndividualPagesUsingStreams
        }
    }
}