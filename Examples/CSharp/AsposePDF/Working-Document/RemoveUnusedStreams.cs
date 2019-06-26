using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document
{
    public class RemoveUnusedStreams
    {
        public static void Run()
        {
            // ExStart:RemoveUnusedStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            // Open document
            Document pdfDocument = new Document(dataDir + "OptimizeDocument.pdf");
            // Set RemoveUsedStreams option 
            var optimizeOptions = new Pdf.Optimization.OptimizationOptions
            {
                RemoveUnusedStreams = true
            };
            // Optimize PDF document using OptimizationOptions
            pdfDocument.OptimizeResources(optimizeOptions);
            dataDir = dataDir + "OptimizeDocument_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            // ExEnd:RemoveUnusedStreams
            Console.WriteLine("\nUnused streams removed successfully.\nFile saved at " + dataDir);
        }
    }
}
