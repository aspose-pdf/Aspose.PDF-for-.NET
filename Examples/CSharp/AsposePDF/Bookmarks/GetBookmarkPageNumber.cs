using System.IO;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks
{
    public class GetBookmarkPageNumber
    {
        public static void Run()
        {
            // ExStart:GetBookmarkPageNumber
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            // Create PdfBookmarkEditor
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            // Open PDF file
            bookmarkEditor.BindPdf(dataDir + "GetBookmarks.pdf");
            // Extract bookmarks
            Aspose.Pdf.Facades.Bookmarks bookmarks = bookmarkEditor.ExtractBookmarks();
            foreach (Aspose.Pdf.Facades.Bookmark bookmark in bookmarks)
            {
                string strLevelSeprator = string.Empty;
                for (int i = 1; i < bookmark.Level; i++)
                {
                    strLevelSeprator += "----";
                }

                Console.WriteLine("{0}Title: {1}", strLevelSeprator, bookmark.Title);
                Console.WriteLine("{0}Page Number: {1}", strLevelSeprator, bookmark.PageNumber);
                Console.WriteLine("{0}Page Action: {1}", strLevelSeprator, bookmark.Action);
            }
            // ExEnd:GetBookmarkPageNumber
        }
    }
}