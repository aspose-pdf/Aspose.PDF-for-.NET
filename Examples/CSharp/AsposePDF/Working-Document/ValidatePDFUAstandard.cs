using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document
{
    public class ValidatePDFUAstandard
    {
        public static void Run()
        {
            // ExStart:ValidatePDFUAstandard
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Open document
            Document pdfDocument = new Document(dataDir + "ValidatePDFUAStandard.pdf");

            // Validate PDF for PDF/UA
            bool isValidPdfUa = pdfDocument.Validate(dataDir + "validation-result-UA.xml", PdfFormat.PDF_UA_1);
            // ExEnd:ValidatePDFUAstandard
        }

    }
}