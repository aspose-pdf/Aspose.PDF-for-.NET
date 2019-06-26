using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Devices;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class BradleyAlgorithm
    {
        public static void Run()
        {
            // ExStart:BradleyAlgorithm
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document pdfDocument = new Document(dataDir+ "PageToTIFF.pdf");

            string outputImageFile = dataDir + "resultant_out.tif";
            string outputBinImageFile = dataDir + "37116-bin_out.tif";

            // Create Resolution object
            Resolution resolution = new Resolution(300);
            // Create TiffSettings object
            TiffSettings tiffSettings = new TiffSettings();
            tiffSettings.Compression = CompressionType.LZW;
            tiffSettings.Depth = Aspose.Pdf.Devices.ColorDepth.Format1bpp;
            // Create TIFF device
            TiffDevice tiffDevice = new TiffDevice(resolution, tiffSettings);
            // Convert a particular page and save the image to stream
            tiffDevice.Process(pdfDocument, outputImageFile);

            using (FileStream inStream = new FileStream(outputImageFile, FileMode.Open))
            {
                using (FileStream outStream = new FileStream(outputBinImageFile, FileMode.Create))
                {
                    tiffDevice.BinarizeBradley(inStream, outStream, 0.1);
                }
            }
            // ExEnd:BradleyAlgorithm
            System.Console.WriteLine("Conversion using bradley algorithm performed successfully!");
        }
    }
}