using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.SplitPages
{
    public class SplitPagesToBulkUsingStreams
    {
        public static void Run()
        {
            // ExStart:SplitPagesToBulkUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create input stream
            FileStream inputStream = new FileStream(dataDir + "MultiplePages.pdf", FileMode.Open);
            int fileNumber = 1;
            // Create array of pages to split
            int[][] numberOfPages = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4} };
            // Split to bulk
            MemoryStream[] outBuffer = pdfEditor.SplitToBulks(inputStream, numberOfPages);
            // Save individual files
            foreach (MemoryStream aStream in outBuffer)
            {
                FileStream outStream = new FileStream(dataDir + "File_" + fileNumber.ToString() + "_out.pdf", FileMode.Create);
                aStream.WriteTo(outStream);
                outStream.Close();
                fileNumber++;
            }
            // ExEnd:SplitPagesToBulkUsingStreams
        }
    }
}