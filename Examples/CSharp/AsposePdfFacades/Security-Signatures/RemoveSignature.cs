using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Collections;
using Aspose.Pdf.Forms;
using System.Collections.Generic;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.SecuritySignatures
{
    public class RemoveSignature
    {
        public static void Run()
        {
            try
            {
                // ExStart:RemoveSignature                
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();
                // Create PdfFileSignature object
                PdfFileSignature pdfSign = new PdfFileSignature();
                // Open PDF document
                pdfSign.BindPdf(dataDir + "DigitallySign.pdf");
                // Get list of signature names
                IList<string> names = pdfSign.GetSignNames();
                // Remove all the signatures from the PDF file
                for (int index = 0; index < names.Count; index++)
                {
                    pdfSign.RemoveSignature((string)names[index]);
                }
                // Save updated PDF file
                pdfSign.Save(dataDir + "RemoveSignature_out.pdf");
                // ExEnd:RemoveSignature
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Run_34561_tests()
        {
            // ExStart:Run_34561_tests
            new License().SetLicense(@"E:\Aspose.Pdf.lic");
            string inSingleSignedFile = @"C:\pdftest\PDFNEWNET_34561_SingleSigned.pdf";
            string outSingleUnsignedFile = @"C:\pdftest\PDFNEWNET_34561_SingleUnSigned.pdf";
            string inOutSingleResignedFile = @"C:\pdftest\PDFNEWNET_34561_SingleReSigned.pdf";

            PdfFileSignature pdfSignSingle = new PdfFileSignature();
            pdfSignSingle.BindPdf(inSingleSignedFile);
            IList<string> names = pdfSignSingle.GetSignNames();
            Stream pfx = new FileStream(@"C:\pdftest\test1.pfx", FileMode.Open);
            PKCS7 pcks = new PKCS7(pfx, "test1");
            string sigNameSingle = names[0] as string;
            if (sigNameSingle != null && sigNameSingle != string.Empty)
            {
                pdfSignSingle.RemoveSignature(sigNameSingle, false);
                pdfSignSingle.Save(outSingleUnsignedFile);

                PdfFileSignature pdfSignSingle2 = new PdfFileSignature();
                pdfSignSingle2.BindPdf(outSingleUnsignedFile);
                pdfSignSingle2.SignatureAppearance = @"C:\pdftest\butterfly.jpg";
                pdfSignSingle2.Sign("Signature1", pcks);
                pdfSignSingle2.Save(inOutSingleResignedFile);
                pdfSignSingle2.BindPdf(inOutSingleResignedFile);
                // Assert.True(pdfSignSingle2.VerifySignature("Signature1"));
                Console.Write("Signature 1 check result : " + pdfSignSingle2.VerifySignature("Signature1").ToString() + " \n");
            }

            // Test file with multiple signatures         
            string outManyUnsignedFile = @"C:\pdftest\PDFNEWNET_34561_ManyUnSigned.pdf";
            string inOutManyResignedFile = @"C:\pdftest\PDFNEWNET_34561_ManyReSigned.pdf";
            PdfFileSignature pdfSignMany = new Aspose.Pdf.Facades.PdfFileSignature();

            IList<string> sigNames = pdfSignMany.GetSignNames();
            foreach (string sigName in sigNames)
            {
                pdfSignMany.RemoveSignature(sigName, false);
            }

            pdfSignMany.Save(outManyUnsignedFile);

            PdfFileSignature pdfSignMany2 = new PdfFileSignature();
            pdfSignMany2.BindPdf(outManyUnsignedFile);
            pdfSignMany2.Sign("Signature1", pcks);
            pdfSignMany2.Save(inOutManyResignedFile);
            pdfSignMany2.BindPdf(inOutSingleResignedFile);
            // Assert.IsTrue(pdfSignMany2.VerifySignature("Signature1"));
            Console.Write("Signature 2 check result : " + pdfSignMany2.VerifySignature("Signature1").ToString() + " ");
            // ExEnd:Run_34561_tests
        }
    }
}