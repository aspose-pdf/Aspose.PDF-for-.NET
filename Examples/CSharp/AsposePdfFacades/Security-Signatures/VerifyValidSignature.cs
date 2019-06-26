using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Collections;
using Aspose.Pdf.Forms;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.SecuritySignatures
{
    public class VerifyValidSignature
    {
        public static void Run()
        {
            try
            {
                // ExStart:VerifyValidSignature               
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();
                PdfFileSignature pdfSign = new PdfFileSignature();
                pdfSign.BindPdf(dataDir + "DigitallySign.pdf");
                if (pdfSign.VerifySignature("Signature1"))
                {
                    Console.WriteLine("Signature Verified");
                }
                // ExEnd:VerifyValidSignature
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }       
    }
}