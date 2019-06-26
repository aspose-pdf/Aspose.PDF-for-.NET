using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Devices;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class ConvertToTIFFSettings
    {
        public static void Run()
        {
            // ExStart:ConvertToTIFFSettings
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();
            // Create PdfConverter object and bind input PDF file
            PdfConverter pdfConverter = new PdfConverter();
            // Create Resolution object with 300 as an argument
            Aspose.Pdf.Devices.Resolution resolution = new Aspose.Pdf.Devices.Resolution(300);
            // Specify the resolution value for PdfConverter object
            pdfConverter.Resolution = resolution;
            // Bind the source PDF file
            pdfConverter.BindPdf(dataDir+ "ConvertToTIFF-Settings.pdf");
            // Start the conversion process
            pdfConverter.DoConvert();
            // Create TiffSettings object and set ColorDepth
            TiffSettings tiffSettings = new TiffSettings();
            tiffSettings.Depth = Aspose.Pdf.Devices.ColorDepth.Format1bpp;
            // Convert to TIFF image
            pdfConverter.SaveAsTIFF(dataDir+ "output_out.tif", 300, 300, tiffSettings);
            // Close Converter object
            pdfConverter.Close();
            // ExEnd:ConvertToTIFFSettings
        }
    }
}