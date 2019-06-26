using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Collections;
using Aspose.Pdf.Forms;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.SecuritySignatures
{
    public class VerifySignature
    {
        public static void Run()
        {
            try
            {
                // ExStart:VerifySignature               
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();
                PdfFileSignature pdfSign = new PdfFileSignature();
                pdfSign.BindPdf(dataDir + "DigitallySign.pdf");
                if (pdfSign.VerifySigned("Signature1"))
                {
                    Console.WriteLine("PDF Signed");
                }
                // ExEnd:VerifySignature
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void VerifyPDFSigned()
        {
            // ExStart:VerifyPDFSigned               
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();

            PdfFileSignature pdfSign = new PdfFileSignature();
            pdfSign.BindPdf(dataDir + "DigitallySign.pdf");
            pdfSign.ContainsSignature();
            // Any signatures?
            pdfSign.Close();
            // ExEnd:VerifyPDFSigned  
        }
    }
}