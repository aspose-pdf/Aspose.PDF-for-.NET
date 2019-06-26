using System.IO;
using Aspose.Pdf.Forms;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.SecuritySignatures
{
    public class ExtractSignatureInfo
    {
        public static void Run()
        {
            try
            {
                // ExStart:ExtractSignatureInfo
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_SecuritySignatures();

                string input = dataDir + "ExtractSignatureInfo.pdf";
                using (Document pdfDocument = new Document(input))
                {
                    foreach (Field field in pdfDocument.Form)
                    {
                        SignatureField sf = field as SignatureField;
                        if (sf != null)
                        {
                            Stream cerStream = sf.ExtractCertificate();
                            if (cerStream != null)
                            {
                                using (cerStream)
                                {
                                    byte[] bytes = new byte[cerStream.Length];
                                    using (FileStream fs = new FileStream(dataDir + @"input.cer", FileMode.CreateNew))
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