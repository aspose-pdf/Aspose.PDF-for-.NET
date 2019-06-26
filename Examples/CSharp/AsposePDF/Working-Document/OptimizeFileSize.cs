using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Optimization;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class OptimizeFileSize
    {
        public static void Run()
        {
            // ExStart:OptimizeFileSize
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Open document
            Document pdfDocument = new Document(dataDir + "OptimizeDocument.pdf");

            OptimizationOptions optimizationOptions = new OptimizationOptions();
            optimizationOptions.LinkDuplcateStreams = true;
            optimizationOptions.RemoveUnusedObjects = true;
            optimizationOptions.RemoveUnusedStreams = true;
            optimizationOptions.ImageCompressionOptions.CompressImages = true;
            optimizationOptions.ImageCompressionOptions.ImageQuality = 10;
            // Optimzie the file size by removing unused objects
            pdfDocument.OptimizeResources(optimizationOptions);
            dataDir = dataDir + "OptimizeFileSize_out.pdf";
            // Save output document
            pdfDocument.Save(dataDir);
            // ExEnd:OptimizeFileSize
            Console.WriteLine("\nFile size optimized successfully.\nFile saved at " + dataDir);
        }
    }
}