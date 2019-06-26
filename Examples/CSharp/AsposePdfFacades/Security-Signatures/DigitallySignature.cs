using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Collections;
using Aspose.Pdf.Forms;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.SecuritySignatures
{
    public class DigitallySignature
    {
        public static void Run()
        {
            try
            {
                // ExStart:DigitallySignature
                string pbxFile = "";
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();
                // Create PdfFileSignature object and bind input and output PDF files
                PdfFileSignature pdfSign = new PdfFileSignature();
                pdfSign.BindPdf(dataDir + "DigitallySign.pdf");
                // Create a rectangle for signature location
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(100, 100, 200, 100);
                // Set signature appearance
                pdfSign.SignatureAppearance = dataDir + "aspose-logo.jpg";
                // Create any of the three signature types
                PKCS1 signature = new PKCS1(pbxFile, "password"); // PKCS#1 or
                
                pdfSign.Sign(1, "Signature Reason", "Contact", "Location", true, rect, signature);
                // Save output PDF file
                pdfSign.Save(dataDir + "DigitallySignature_out.pdf");
                // ExEnd:DigitallySignature
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}