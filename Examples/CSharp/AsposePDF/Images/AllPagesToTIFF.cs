using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Devices;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class AllPagesToTIFF
    {
        public static void Run()
        {
            // ExStart:AllPagesToTIFF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document pdfDocument = new Document(dataDir+ "PageToTIFF.pdf");

            // Create Resolution object
            Resolution resolution = new Resolution(300);

            // Create TiffSettings object
            TiffSettings tiffSettings = new TiffSettings();
            tiffSettings.Compression = CompressionType.None;
            tiffSettings.Depth = ColorDepth.Default;
            tiffSettings.Shape = ShapeType.Landscape;
            tiffSettings.SkipBlankPages = false;

            // Create TIFF device
            TiffDevice tiffDevice = new TiffDevice(resolution, tiffSettings);

            // Convert a particular page and save the image to stream
            tiffDevice.Process(pdfDocument, dataDir + "AllPagesToTIFF_out.tif");

            // ExEnd:AllPagesToTIFF
            System.Console.WriteLine("PDF all pages converted to one tiff file successfully!");
        }
    }
}