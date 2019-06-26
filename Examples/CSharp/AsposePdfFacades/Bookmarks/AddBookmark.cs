using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks
{
    public class AddBookmark
    {
        public static void Run()
        {
            // ExStart:AddBookmark
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            // Create bookmark
            Bookmark boomark = new Bookmark();
            boomark.PageNumber = 1;
            boomark.Title = "New Bookmark";
            // Create PdfBookmarkEditor class
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            // Bind PDF document
            bookmarkEditor.BindPdf(dataDir+ "AddBookmark.pdf");
            // Create bookmarks
            bookmarkEditor.CreateBookmarks(boomark);
            // Save updated document
            bookmarkEditor.Save(dataDir+ "AddBookmark_out.pdf");
            // ExEnd:AddBookmark
        }
    }
}