using System;
using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks
{
    public class InheritZoom
    {
        public static void Run()
        {
            // ExStart:InheritZoom
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            // Open document
            Document doc = new Document(dataDir + "input.pdf");

            // Get outlines/bookmarks collection of PDF file
            OutlineItemCollection item = new OutlineItemCollection(doc.Outlines);
            // Set zoom level as 0
            XYZExplicitDestination dest = new XYZExplicitDestination(2, 100, 100, 0);
            // Add XYZExplicitDestination as action to outlines collection of PDF
            item.Action = new GoToAction(dest);
            // Add item to outlines collection of PDF file
            doc.Outlines.Add(item);

            dataDir = dataDir + "InheritZoom_out.pdf";
            // Save output
            doc.Save(dataDir);
            // ExEnd:InheritZoom
            Console.WriteLine("\nBookmarks updated successfully.\nFile saved at " + dataDir);

        }
    }
}