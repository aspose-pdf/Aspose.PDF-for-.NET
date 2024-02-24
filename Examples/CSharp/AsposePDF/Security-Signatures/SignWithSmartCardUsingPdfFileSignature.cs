using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.SecuritySignatures
{
    public class SignWithSmartCardUsingPdfFileSignature
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_SecuritySignatures();

            Document doc = new Document(dataDir + "blank.pdf");

            using (Facades.PdfFileSignature pdfSign = new Facades.PdfFileSignature())
            {
                pdfSign.BindPdf(doc);

                // Sign with certificate selection in the windows certificate store
                System.Security.Cryptography.X509Certificates.X509Store store = new System.Security.Cryptography.X509Certificates.X509Store(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
                store.Open(System.Security.Cryptography.X509Certificates.OpenFlags.ReadOnly);
                // Manually chose the certificate in the store
                System.Security.Cryptography.X509Certificates.X509Certificate2Collection sel =
                    System.Security.Cryptography.X509Certificates.X509Certificate2UI.SelectFromCollection(
                        store.Certificates, null, null, System.Security.Cryptography.X509Certificates.X509SelectionFlag.SingleSelection);

                Aspose.Pdf.Forms.ExternalSignature externalSignature = new Aspose.Pdf.Forms.ExternalSignature(sel[0]);
                pdfSign.SignatureAppearance = dataDir + "demo.png";
                pdfSign.Sign(1, "Reason", "Contact", "Location", true, new System.Drawing.Rectangle(100, 100, 200, 200), externalSignature);
                pdfSign.Save(dataDir + "externalSignature2.pdf");
            }

            using (Facades.PdfFileSignature pdfSign = new Facades.PdfFileSignature(new Document(dataDir + "externalSignature2.pdf")))
            {
                IList<string> sigNames = pdfSign.GetSignNames();
                for (int index = 0; index <= sigNames.Count - 1; index++)
                {
                    if (!pdfSign.VerifySigned(sigNames[index]) || !pdfSign.VerifySignature(sigNames[index]))
                    {
                        throw new ApplicationException("Not verified");
                    }
                }
            }
            // ExEnd:1
        }
    }
}
