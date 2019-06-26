using Aspose.Pdf.Facades;
using Aspose.Pdf.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfFacades.Security_Signatures
{
    public class HideDigitallySignedByCaption
    {
        public static void Run()
        {
            // ExStart:HideDigitallySignedByCaption
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();
            string inPfxFile = dataDir + "SampleCertificate.pfx";
            string inFile = dataDir + "input.pdf";
            string outFile = dataDir + "output.pdf";

            using (PdfFileSignature pdfSign = new PdfFileSignature())
            {
                pdfSign.BindPdf(inFile);
                //create a rectangle for signature location
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(310, 45, 200, 50);

                //create any of the three signature types
                PKCS7 pkcs = new PKCS7(inPfxFile, "idsrv3test");
                SignatureCustomAppearance signatureCustomAppearance = new SignatureCustomAppearance();
                signatureCustomAppearance.FontSize = 6;
                signatureCustomAppearance.FontFamilyName = "Times New Roman";
                signatureCustomAppearance.DigitalSignedLabel = "Signed by me";
                pkcs.CustomAppearance = signatureCustomAppearance;
                // sign the PDF file
                pdfSign.Sign(1, true, rect, pkcs);
                //save output PDF file
                pdfSign.Save(outFile);
            }
            // ExEnd:HideDigitallySignedByCaption
        }
    }
}
