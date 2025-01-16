using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToPDFX4
    {
        public static void Run()
        {
            // ExStart:PDFToPDFX4
            // The path to the documents directory
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
    
            // Open document
            using (var document = new Aspose.Pdf.Document(dataDir + "PDFToPDFX.pdf"))
            {
                // Set up the desired PDF/X format with PdfFormatConversionOptions
                Aspose.Pdf.PdfFormatConversionOptions options = new Aspose.Pdf.PdfFormatConversionOptions(Aspose.Pdf.PdfFormat.PDF_X_4, Aspose.Pdf.ConvertErrorAction.Delete);

                // Provide the name of the external ICC profile file (optional)
                options.IccProfileFileName = dataDir + "ISOcoated_v2_eci.icc";

                // Provide an output condition identifier and other necessary OutputIntent properties (optional)
                options.OutputIntent = new Aspose.Pdf.OutputIntent("FOGRA39");

                // Convert to PDF/X compliant document
                document.Convert(options);
        
                // Save output document
                document.Save(dataDir + "PDFToPDFX4_out.pdf");
            }
        }
    }
}