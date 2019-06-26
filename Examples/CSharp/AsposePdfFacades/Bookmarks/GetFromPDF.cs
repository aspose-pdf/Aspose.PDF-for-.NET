using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks
{
    public class GetFromPDF
    {
        public static void Run()
        {
            // ExStart:GetFromPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            // Create PdfBookmarkEditor
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            // Open PDF file
            bookmarkEditor.BindPdf(dataDir + "GetFromPDF.PDF");
            // Extract bookmarks
            Aspose.Pdf.Facades.Bookmarks bookmarks = bookmarkEditor.ExtractBookmarks();
            foreach (Aspose.Pdf.Facades.Bookmark bookmark in bookmarks)
            {
                // Get the title information of bookmark item
                Console.WriteLine("Title: {0}", bookmark.Title);
                // Get the destination page for bookmark
                Console.WriteLine("Page Number: {0}", bookmark.PageNumber);
                // Get the information related to associated action with bookmark
                Console.WriteLine("Bookmark Action: " + bookmark.Action);
            }
            // ExEnd:GetFromPDF
        }
    }
}