using System.IO;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class CreateNestedBookmarks
    {
        public static void Run()
        {
            // ExStart:CreateNestedBookmarks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // New a object of Class PdfContentEditor
            PdfContentEditor editor = new PdfContentEditor();
            editor.BindPdf(dataDir + "inFile.pdf");
            // Creating child items of a chapter, in this example, the first child item also include a child item.
            Bookmark bm11 = new Bookmark();
            // Set the action type of BookMark
            bm11.Action = "GoTo";
            // Set the BookMark Destination page
            bm11.PageNumber = 3;
            // Set the BookMark title. 
            bm11.Title = "Section - 1.1.1";

            Bookmark bm1 = new Bookmark();
            bm1.Action = "GoTo";
            bm1.PageNumber = 2;
            bm1.Title = "Section - 1.1";

            Aspose.Pdf.Facades.Bookmarks bms1 = new Aspose.Pdf.Facades.Bookmarks();
            bms1.Add(bm11);
            bm1.ChildItems = bms1;

            // Creating a child item of a chapter.
            Bookmark bm2 = new Bookmark();
            bm2.Action = "GoTo";
            bm2.PageNumber = 4;
            bm2.Title = "Section - 1.2";

            // Creating a chapter (Parent Level Bookmark)
            Bookmark bm = new Bookmark();
            bm.Action = "GoTo";
            bm.PageNumber = 1;
            bm.Title = "Chapter - 1";

            Aspose.Pdf.Facades.Bookmarks bms = new Aspose.Pdf.Facades.Bookmarks();
            // Add the Section - 1.1, bookmark to bookmarks collection
            bms.Add(bm1);
            // Add the Section - 1.2, bookmark to bookmarks collection
            bms.Add(bm2);
            // Add the Bookmarks collection as child_Item of Chapter_Level bookmark
            bm.ChildItems = bms;

            // Creating a chapter (Parent Level Bookmark)
            Bookmark bm_parent2 = new Bookmark();
            bm_parent2.Action = "GoTo";
            bm_parent2.PageNumber = 5;
            bm_parent2.Title = "Chapter - 2";

            // Creating a child item of a chapter.
            Bookmark bm22 = new Bookmark();
            bm22.Action = "GoTo";
            bm22.PageNumber = 6;
            bm22.Title = "Section - 2.1";

            Aspose.Pdf.Facades.Bookmarks bms_parent2 = new Aspose.Pdf.Facades.Bookmarks();
            // Add the Section - 2.1, bookmark to bookmarks collection
            bms_parent2.Add(bm22);
            // Add the Bookmarks collection as child_Item of Chapter2_Level bookmark
            bm_parent2.ChildItems = bms_parent2;
           
            // Saves the result PDF to file
            editor.Save(dataDir + "Nested_BookMarks_out.pdf");
            // ExEnd:CreateNestedBookmarks                      
        }
    }
}