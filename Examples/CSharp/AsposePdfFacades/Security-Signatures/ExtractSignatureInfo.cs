using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Collections;
using Aspose.Pdf.Forms;
using System.Collections.Generic;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.SecuritySignatures
{
    public class ExtractSignatureInfo
    {
        public static void Run()
        {
            try
            {
                // ExStart:ExtractSignatureInfo               
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();
                string input = dataDir + "DigitallySign.pdf";
                string pkcs1File = "";
                using (PdfFileSignature pdfFileSignature = new PdfFileSignature())
                {
                    pdfFileSignature.BindPdf(input);
                    IList<string> sigNames = pdfFileSignature.GetSignNames();
                    if (sigNames.Count > 0)
                    {
                        string sigName = sigNames[0] as string;
                        if (string.IsNullOrEmpty(sigName))
                        {
                            Stream cerStream = pdfFileSignature.ExtractCertificate(sigName);
                            if (cerStream != null)
                            {
                                using (cerStream)
                                {
                                    byte[] bytes = new byte[cerStream.Length];
                                    using (FileStream fs = new FileStream(dataDir + pkcs1File, FileMode.CreateNew))
                                    {
                                        cerStream.Read(bytes, 0, bytes.Length);
                                        fs.Write(bytes, 0, bytes.Length);
                                    }
                                }
                            }
                        }
                    }
                }
                // ExEnd:ExtractSignatureInfo
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }       
    }
}