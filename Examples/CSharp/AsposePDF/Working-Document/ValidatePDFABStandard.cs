using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class ValidatePDFABStandard
    {
        public static void Run()
        {
            // ExStart:ValidatePDFABStandard
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Open document
            Document pdfDocument = new Document(dataDir + "ValidatePDFAStandard.pdf");

            // Validate PDF for PDF/A-1a
            pdfDocument.Validate(dataDir + "validation-result-A1A.xml", PdfFormat.PDF_A_1B);
            // ExEnd:ValidatePDFABStandard
        }
    }
}