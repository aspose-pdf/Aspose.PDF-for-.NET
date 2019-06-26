using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks
{
    public class UpdateBookmarks
    {
        public static void Run()
        {
            // ExStart:UpdateBookmarks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            // Open document
            Document pdfDocument = new Document(dataDir + "UpdateBookmarks.pdf");

            // Get a bookmark object
            OutlineItemCollection pdfOutline = pdfDocument.Outlines[1];
            pdfOutline.Title = "Updated Outline";
            pdfOutline.Italic = true;
            pdfOutline.Bold = true;

            dataDir = dataDir + "UpdateBookmarks_out.pdf";
            // Save output
            pdfDocument.Save(dataDir);
            // ExEnd:UpdateBookmarks
            Console.WriteLine("\nBookmarks updated successfully.\nFile saved at " + dataDir);

        }
    }
}