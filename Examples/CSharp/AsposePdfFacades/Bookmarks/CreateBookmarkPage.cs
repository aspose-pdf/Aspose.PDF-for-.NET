using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks
{
    public class CreateBookmarkPage
    {
        public static void Run()
        {
            // ExStart:CreateBookmarkPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            // Open document
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            bookmarkEditor.BindPdf(dataDir+ "CreateBookmark-Page.pdf");
            // Create bookmark of a particular page
            bookmarkEditor.CreateBookmarkOfPage("Bookmark Name", 2);
            // Save updated PDF file
            bookmarkEditor.Save(dataDir+ "CreateBookmark-Page_out.pdf");
            // ExEnd:CreateBookmarkPage
        }
    }
}