using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks
{
    public class ExtractBookmarks
    {
        public static void Run()
        {
            // ExStart:ExtractBookmarks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            // Create PdfBookmarkEditor
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            // Open PDF file
            bookmarkEditor.BindPdf(dataDir+ "ExtractBookmarks.pdf");
            // Extract bookmarks
            Aspose.Pdf.Facades.Bookmarks bookmarks = bookmarkEditor.ExtractBookmarks();

            foreach (Bookmark bookmark in bookmarks)
            {
                Console.WriteLine("Title: {0}", bookmark.Title);
                Console.WriteLine("Page Number: {0}", bookmark.PageNumber);
            }
            // ExEnd:ExtractBookmarks
        }
    }
}