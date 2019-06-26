using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class GetZoomFactor
    {
        public static void Run()
        {
            // ExStart:GetZoomFactor
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Instantiate new Document object
            Document doc = new Document(dataDir + "Zoomed_pdf.pdf");

            // Create GoToAction object
            GoToAction action = doc.OpenAction as GoToAction;
            
            // Get the Zoom factor of PDF file
            System.Console.WriteLine((action.Destination as XYZExplicitDestination).Zoom); // Document zoom value;
            // ExEnd:GetZoomFactor
        }
    }
}