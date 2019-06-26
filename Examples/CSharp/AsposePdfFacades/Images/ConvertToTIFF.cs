using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Devices;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class ConvertToTIFF
    {
        public static void Run()
        {
            // ExStart:ConvertToTIFF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();
            // Create PdfConverter object and bind input PDF file
            PdfConverter pdfConverter = new PdfConverter();           
            // Bind the source PDF file
            pdfConverter.BindPdf(dataDir+ "ConvertToTIFF-Settings.pdf");
            // Start the conversion process
            pdfConverter.DoConvert();            
            // Convert to TIFF image
            pdfConverter.SaveAsTIFF(dataDir+ "output_out.tif");
            // Close Converter object
            pdfConverter.Close();
            // ExEnd:ConvertToTIFF
        }
    }
}