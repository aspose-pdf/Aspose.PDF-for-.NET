using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class ShrinkImages
    {
        public static void Run()
        {
            // ExStart:ShrinkImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();
            // Open document
            Document pdfDocument = new Document(dataDir + "Shrinkimage.pdf");
            // Initialize OptimizationOptions
            var optimizeOptions = new Pdf.Optimization.OptimizationOptions();
            // Set CompressImages option
            optimizeOptions.ImageCompressionOptions.CompressImages = true;
            // Set ImageQuality option
            optimizeOptions.ImageCompressionOptions.ImageQuality = 50;
            // Optimize PDF document using OptimizationOptions
            pdfDocument.OptimizeResources(optimizeOptions);
            dataDir = dataDir + "Shrinkimage_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            // ExEnd:ShrinkImages
            Console.WriteLine("\nImage shrinked successfully.\nFile saved at " + dataDir);
        }

    }
}
