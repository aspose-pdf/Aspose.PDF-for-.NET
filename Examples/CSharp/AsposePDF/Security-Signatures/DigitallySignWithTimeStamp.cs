using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Forms;
using System.Collections;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.SecuritySignatures
{
    public class DigitallySignWithTimeStamp
    {
        public static void Run()
        {
            // ExStart:DigitallySignWithTimeStamp
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_SecuritySignatures();
            string pfxFile = "";
            using (Document document = new Document(dataDir + @"DigitallySign.pdf"))
            {
                using (PdfFileSignature signature = new PdfFileSignature(document))
                {
                    PKCS7 pkcs = new PKCS7(pfxFile, "pfx_password");
                    TimestampSettings timestampSettings = new TimestampSettings("https:\\your_timestamp_settings", "user:password"); // User/Password can be omitted
                    pkcs.TimestampSettings = timestampSettings;
                    System.Drawing.Rectangle rect = new System.Drawing.Rectangle(100, 100, 200, 100);
                    // Create any of the three signature types
                    signature.Sign(1, "Signature Reason", "Contact", "Location", true, rect, pkcs);
                    // Save output PDF file
                    signature.Save(dataDir + "DigitallySignWithTimeStamp_out.pdf");
                }
            }
            // ExEnd:DigitallySignWithTimeStamp
        }
    }
}