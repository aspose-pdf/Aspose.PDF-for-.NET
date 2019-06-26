using Aspose.Pdf.Facades;
using Aspose.Pdf.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.SecuritySignatures
{
    public class SignWithSmartCardUsingSignatureField
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_SecuritySignatures();

            File.Copy(dataDir + "blank.pdf", dataDir + "externalSignature1.pdf", true);
            using (FileStream fs = new FileStream(dataDir + "externalSignature1.pdf", FileMode.Open, FileAccess.ReadWrite))
            {
                using (Document doc = new Document(fs))
                {
                    SignatureField field1 = new SignatureField(doc.Pages[1], new Rectangle(100, 400, 10, 10));

                    // Sign with certificate selection in the windows certificate store
                    System.Security.Cryptography.X509Certificates.X509Store store = new System.Security.Cryptography.X509Certificates.X509Store(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
                    store.Open(System.Security.Cryptography.X509Certificates.OpenFlags.ReadOnly);
                    // Manually chose the certificate in the store
                    System.Security.Cryptography.X509Certificates.X509Certificate2Collection sel = System.Security.Cryptography.X509Certificates.X509Certificate2UI.SelectFromCollection(store.Certificates, null, null, System.Security.Cryptography.X509Certificates.X509SelectionFlag.SingleSelection);

                    Aspose.Pdf.Forms.ExternalSignature externalSignature = new Aspose.Pdf.Forms.ExternalSignature(sel[0])
                    {
                        Authority = "Me",
                        Reason = "Reason",
                        ContactInfo = "Contact"
                    };

                    field1.PartialName = "sig1";
                    doc.Form.Add(field1, 1);
                    field1.Sign(externalSignature);
                    doc.Save();
                }
            }
            
            using (PdfFileSignature pdfSign = new PdfFileSignature(new Document(dataDir + "externalSignature1.pdf")))
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
