using System.IO;
using System;
using System.Collections;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Forms;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class PDFSigningMechanism
    {
        public static void Run()
        {
            // ExStart:PDFSigningMechanism
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            Document doc = new Document(dataDir + "inFile.pdf");
            // Create PdfFileSignature object and bind input and output PDF files
            PdfFileSignature pdfSign = new PdfFileSignature(doc);
            // Create a rectangle for signature location
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(100, 100, 200, 100);
            // Set signature appearance
            pdfSign.SignatureAppearance = dataDir + "aspose-logo.jpg";
           
            // Create any of the three signature types
            PKCS1 signature = new PKCS1(dataDir + "inFile2.pdf", "password"); 
         
            pdfSign.Sign(1, "Signature Reason", "Alice", "Odessa", true, rect, signature);         
            // ExEnd:PDFSigningMechanism                      
        }
        public static void AddSignatureFields()
        {
            // ExStart:AddSignatureFields
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();
            Document doc = new Document(dataDir + "inFile.pdf");
            // Create FormEditor object
            FormEditor editor = new FormEditor(doc);
            // Add signature fields
            editor.AddField(FieldType.Signature, "Signature from Alice", 1, 10, 10, 110, 110);
            editor.AddField(FieldType.Signature, "Signature from John", 1, 120, 150, 220, 250);
            editor.AddField(FieldType.Signature, "Signature from Smith", 1, 300, 200, 400, 300);
            // Save the form
            editor.Save(dataDir + "AddSignatureFields_1_out.pdf");

            Document doc2 = new Document(dataDir + "inFile2.pdf");
            // Add signature to any of the signature fields
            PdfFileSignature pdfSign = new PdfFileSignature(doc2);
            pdfSign.Sign("Signature from John", "Signature Reason", "John", "Kharkov", new PKCS1("inFile1.pdf", "password"));
            // Each time new signature is added you must save the document
            pdfSign.Save(dataDir + "AddSignatureFields_2_out.pdf");

            Document doc3 = new Document(dataDir + "FilledForm.pdf");
            // Add second signature
            PdfFileSignature pdfSign2 = new PdfFileSignature(doc3);
            pdfSign2.Sign("Signature from Alice", "Signature Reason", "Alice", "Odessa", new PKCS1(dataDir + "FilledForm - 2.pfx", "password"));
            // Each time new signature is added you must save the document
            pdfSign2.Save(dataDir + "AddSignatureFields_3_out.pdf");
            // ExEnd:AddSignatureFields
        }
        public static void VerifySignatures()
        {
            // ExStart:VerifySignatures
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();
            // Create PdfFileSignature object
            PdfFileSignature pdfVerify = new PdfFileSignature();
            // Bind input PDF file
            pdfVerify.BindPdf(dataDir + "inFile.pdf");
            // Check if PDF contains signature
            bool isSigned = pdfVerify.ContainsSignature();
            // All signatures have names Signaure#, this names kit generates automatically
            bool isSignatureVerified = pdfVerify.VerifySignature("Signature1");
            // However we can set necessary name manualy if we use signature fields (see below)
            bool isSignatureVerified2 = pdfVerify.VerifySignature("Signature from Alice");
            // ExEnd:VerifySignatures
        }
    }
}