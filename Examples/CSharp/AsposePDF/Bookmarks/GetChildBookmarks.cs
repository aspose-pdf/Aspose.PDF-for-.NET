using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks
{
    public class GetChildBookmarks
    {
        public static void Run()
        {
            // ExStart:GetChildBookmarks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetChildBookmarks.pdf");

            // Loop through all the bookmarks
            foreach (OutlineItemCollection outlineItem in pdfDocument.Outlines)
            {
                Console.WriteLine(outlineItem.Title);
                Console.WriteLine(outlineItem.Italic);
                Console.WriteLine(outlineItem.Bold);
                Console.WriteLine(outlineItem.Color);

                if (outlineItem.Count > 0)
                {
                    Console.WriteLine("Child Bookmarks");
                    // There are child bookmarks then loop through that as well
                    foreach (OutlineItemCollection childOutline in outlineItem)
                    {
                        Console.WriteLine(childOutline.Title);
                        Console.WriteLine(childOutline.Italic);
                        Console.WriteLine(childOutline.Bold);
                        Console.WriteLine(childOutline.Color);
                    }
                }
            }
            // ExEnd:GetChildBookmarks
        }
    }
}