using Aspose.Pdf.Optimization;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class FlateDecodeCompression
    {
        /// <summary>
        ///  This method is supported by version 18.12 or greater 
        /// </summary>
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();
            // Open Document
            Document doc = new Document(dataDir + "AddImage.pdf");
            // Initialize OptimizationOptions  
            var optimizationOptions = new Aspose.Pdf.Optimization.OptimizationOptions();
            // To optimise image using FlateDecode Compression set optimization options to Flate
            optimizationOptions.ImageCompressionOptions.Encoding = ImageEncoding.Flate;
            // Set Optimization Options 
            doc.OptimizeResources(optimizationOptions);
            // Save Document
            doc.Save(dataDir + "FlateDecodeCompression.pdf");
            // ExEnd:1
        }
    }
}
