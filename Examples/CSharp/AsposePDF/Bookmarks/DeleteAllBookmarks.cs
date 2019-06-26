using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks
{
    public class DeleteAllBookmarks
    {
        public static void Run()
        {
            // ExStart:DeleteAllBookmarks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            // Open document
            Document pdfDocument = new Document(dataDir + "DeleteAllBookmarks.pdf");

            // Delete all bookmarks
            pdfDocument.Outlines.Delete();

            dataDir = dataDir + "DeleteAllBookmarks_out.pdf";
            // Save updated file
            pdfDocument.Save(dataDir);
            // ExEnd:DeleteAllBookmarks
            Console.WriteLine("\nAll bookmarks deleted successfully.\nFile saved at " + dataDir);
        }
    }
}