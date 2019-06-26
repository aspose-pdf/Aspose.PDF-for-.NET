using System;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks
{
    public class AddBookmark
    {
        public static void Run()
        {
            // ExStart:AddBookmark
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            // Open document
            Document pdfDocument = new Document(dataDir + "AddBookmark.pdf");

            // Create a bookmark object
            OutlineItemCollection pdfOutline = new OutlineItemCollection(pdfDocument.Outlines);
            pdfOutline.Title = "Test Outline";
            pdfOutline.Italic = true;
            pdfOutline.Bold = true;
            // Set the destination page number
            pdfOutline.Action = new GoToAction(pdfDocument.Pages[1]);
            // Add bookmark in the document's outline collection.
            pdfDocument.Outlines.Add(pdfOutline);

            dataDir = dataDir + "AddBookmark_out.pdf";
            // Save output
            pdfDocument.Save(dataDir);
            // ExEnd:AddBookmark
            Console.WriteLine("\nBookmark added successfully.\nFile saved at " + dataDir);
        }
    }
}