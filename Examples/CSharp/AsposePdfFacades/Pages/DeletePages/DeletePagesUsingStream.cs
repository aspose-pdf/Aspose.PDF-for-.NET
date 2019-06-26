using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.DeletePages
{
    public class DeletePagesUsingStream
    {
        public static void Run()
        {
            // ExStart:DeletePagesUsingStream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream = new FileStream( dataDir + "input.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "DeletePagesUsingStream_out.pdf", FileMode.Create);
            // Array of pages to delete
            int[] pagesToDelete = new int[] { 1, 3 };
            // Delete pages
            pdfEditor.Delete(inputStream, pagesToDelete, outputStream);
            // ExEnd:DeletePagesUsingStream
        }
    }
}