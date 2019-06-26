using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks
{
    public class AddChildBookmark
    {
        public static void Run()
        {
            // ExStart:AddChildBookmark
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            // Create bookmarks
            Aspose.Pdf.Facades.Bookmarks bookmarks = new Aspose.Pdf.Facades.Bookmarks();
            Bookmark childBookmark1 = new Bookmark();
            childBookmark1.PageNumber = 1;
            childBookmark1.Title = "First Child";
            Bookmark childBookmark2 = new Bookmark();
            childBookmark2.PageNumber = 2;
            childBookmark2.Title = "Second Child";

            bookmarks.Add(childBookmark1);
            bookmarks.Add(childBookmark2);

            Bookmark bookmark = new Bookmark();
            bookmark.Action = "GoTo";
            bookmark.PageNumber = 1;
            bookmark.Title = "Parent";

            bookmark.ChildItems = bookmarks;

            // Create PdfBookmarkEditor class
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            // Bind PDF document
            bookmarkEditor.BindPdf(dataDir+ "AddChildBookmark.pdf");
            // Create bookmarks
            bookmarkEditor.CreateBookmarks(bookmark);
            // Save updated document
            bookmarkEditor.Save(dataDir+ "AddChildBookmark_out.pdf");
            // ExEnd:AddChildBookmark
        }
    }
}