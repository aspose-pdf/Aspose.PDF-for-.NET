using System;
using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.LinksActions
{
    public class SpecifyPageWhenViewing
    {
        public static void Run()
        {
            // ExStart:SpecifyPageWhenViewing
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();

            // Load the PDF file
            Document doc = new Document(dataDir + "SpecifyPageWhenViewing.pdf");
            // Get the instance of second page of document
            Page page2 = doc.Pages[2];
            // Create the variable to set the zoom factor of target page
            double zoom = 1;
            // Create GoToAction instance
            GoToAction action = new GoToAction(doc.Pages[2]);
            // Go to 2 page
            action.Destination = new XYZExplicitDestination(page2, 0, page2.Rect.Height, zoom);
            // Set the document open action
            doc.OpenAction = action;
            // Save updated document
            doc.Save(dataDir + "goto2page_out.pdf");
            // ExEnd:SpecifyPageWhenViewing                        
        }
    }
}