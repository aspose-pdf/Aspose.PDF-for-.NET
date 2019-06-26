using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document
{
    public class AllowResusePageContent
    {
        public static void Run()
        {
            // ExStart:AllowResusePageContent
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            // Open document
            Document pdfDocument = new Document(dataDir + "OptimizeDocument.pdf");
            // Set AllowReusePageContent  option 
            var optimizeOptions = new Pdf.Optimization.OptimizationOptions
            {
                AllowReusePageContent = true
            };
            Console.WriteLine("Start");
            // Optimize PDF document using OptimizationOptions
            pdfDocument.OptimizeResources(optimizeOptions);
            // Save updated document
            pdfDocument.Save(dataDir + "OptimizeDocument_out.pdf");
            Console.WriteLine("Finished");
            var fi1 = new System.IO.FileInfo(dataDir + "OptimizeDocument.pdf");
            var fi2 = new System.IO.FileInfo(dataDir + "OptimizeDocument_out.pdf");
            Console.WriteLine("Original file size: {0}. Reduced file size: {1}", fi1.Length, fi2.Length);
            // ExEnd:AllowResusePageContent
            Console.WriteLine("\nAllowed resuse page content successfully.\nFile saved at " + dataDir);
        }
    }
}
