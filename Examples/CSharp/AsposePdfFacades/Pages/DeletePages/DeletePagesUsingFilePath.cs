using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.DeletePages
{
    public class DeletePagesUsingFilePath
    {
        public static void Run()
        {
            // ExStart:DeletePagesUsingFilePath
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Array of pages to delete
            int[] pagesToDelete = new int[] { 1, 2};
            // Delete pages
            pdfEditor.Delete(dataDir + "input.pdf", pagesToDelete, dataDir + "DeletePagesUsingFilePath_out.pdf");
            // ExEnd:DeletePagesUsingFilePath
        }
    }
}