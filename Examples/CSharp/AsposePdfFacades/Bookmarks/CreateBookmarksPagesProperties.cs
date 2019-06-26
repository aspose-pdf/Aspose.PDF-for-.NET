using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks
{
    public class CreateBookmarksPagesProperties
    {
        public static void Run()
        {
            // ExStart:CreateBookmarksPagesProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            // Open document
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            bookmarkEditor.BindPdf(dataDir+ "CreateBookmarks-PagesProperties.pdf");
            // Create bookmark of all pages
            bookmarkEditor.CreateBookmarks(System.Drawing.Color.Green, true, true);
            // Save updated PDF file
            bookmarkEditor.Save(dataDir+ "CreateBookmarks-PagesProperties_out.pdf");
            // ExEnd:CreateBookmarksPagesProperties
            
        }
    }
}