using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToPDFA
    {
        public static void Run()
        {
            // ExStart:PDFToPDFA
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Open document
            Document pdfDocument = new Document(dataDir + "PDFToPDFA.pdf");
            
            // Convert to PDF/A compliant document
            // During conversion process, the validation is also performed
            pdfDocument.Convert(dataDir + "log.xml", PdfFormat.PDF_A_1B, ConvertErrorAction.Delete);

            dataDir = dataDir + "PDFToPDFA_out.pdf";
            // Save output document
            pdfDocument.Save(dataDir);
            // ExEnd:PDFToPDFA
            Console.WriteLine("\nPDF file converted to PDF/A-1b compliant PDF.\nFile saved at " + dataDir);
        }
    }
}