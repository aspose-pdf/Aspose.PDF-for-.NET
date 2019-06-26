using System;
using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks
{
    public class AddChildBookmark
    {
        public static void Run()
        {
            // ExStart:AddChildBookmark
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            // Open document
            Document pdfDocument = new Document(dataDir + "AddChildBookmark.pdf");

            // Create a parent bookmark object
            OutlineItemCollection pdfOutline = new OutlineItemCollection(pdfDocument.Outlines);
            pdfOutline.Title = "Parent Outline";
            pdfOutline.Italic = true;
            pdfOutline.Bold = true;      
          
            // Create a child bookmark object
            OutlineItemCollection pdfChildOutline = new OutlineItemCollection(pdfDocument.Outlines);
            pdfChildOutline.Title = "Child Outline";
            pdfChildOutline.Italic = true;
            pdfChildOutline.Bold = true;
     
            // Add child bookmark in parent bookmark's collection
            pdfOutline.Add(pdfChildOutline);
            // Add parent bookmark in the document's outline collection.
            pdfDocument.Outlines.Add(pdfOutline);
            
            dataDir = dataDir + "AddChildBookmark_out.pdf";
            // Save output
            pdfDocument.Save(dataDir);
            // ExEnd:AddChildBookmark
            Console.WriteLine("\nChild bookmark added successfully.\nFile saved at " + dataDir);

        }
    }
}