using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class SetZoomFactor
    {
        public static void Run()
        {
            // ExStart:SetZoomFactor
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Instantiate new Document object
            Document doc = new Document(dataDir + "SetZoomFactor.pdf");

            GoToAction action = new GoToAction(new XYZExplicitDestination(1, 0, 0, .5));
            doc.OpenAction = action;
            dataDir = dataDir + "Zoomed_pdf_out.pdf";
            // Save the document
            doc.Save(dataDir);
            // ExEnd:SetZoomFactor
            Console.WriteLine("\nZoom factor setup successfully.\nFile saved at " + dataDir);
        }
    }
}