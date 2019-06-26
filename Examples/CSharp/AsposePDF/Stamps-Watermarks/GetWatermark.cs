using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class GetWatermark
    {
        public static void Run()
        {
            // ExStart:GetWatermark
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Open document
            Document pdfDocument = new Document( dataDir +  "watermark.pdf");
            // Iterate through and get tub-type, text and location of artifact
            foreach (Artifact artifact in pdfDocument.Pages[1].Artifacts)
            {
                Console.WriteLine(artifact.Subtype + " " + artifact.Text + " " + artifact.Rectangle);
            }
            // ExEnd:GetWatermark            
        }
    }
}