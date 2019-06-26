using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToPDFA3b
    {
        public static void Run()
        {
            // ExStart:PDFToPDFA3b
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Open document
            Document pdfDocument = new Document(dataDir + "input.pdf");            
            
            pdfDocument.Convert(new MemoryStream(), PdfFormat.PDF_A_3B, ConvertErrorAction.Delete);

            dataDir = dataDir + "PDFToPDFA3b_out.pdf";
            // Save output document
            pdfDocument.Save(dataDir);
            // ExEnd:PDFToPDFA3b
            Console.WriteLine("\nPDF file converted to PDF/A-3B format.\nFile saved at " + dataDir);
        }
    }
}