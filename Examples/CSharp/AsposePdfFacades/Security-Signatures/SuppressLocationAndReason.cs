using Aspose.Pdf.Forms;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfFacades.Security_Signatures
{
    public class SuppressLocationAndReason
    {
        public static void Run()
        {
            try
            {
                // ExStart:SuppressLocationAndReason
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();
                string inPfxFile = dataDir + "certificate.pfx";
                string inFile = dataDir + "input.pdf"; 
                string outFile = dataDir + "output.pdf";
                using (Aspose.Pdf.Facades.PdfFileSignature pdfSign = new Aspose.Pdf.Facades.PdfFileSignature())
                {
                    pdfSign.BindPdf(inFile);
                    //create a rectangle for signature location
                    System.Drawing.Rectangle rect = new System.Drawing.Rectangle(100, 100, 200, 100);

                    //create any of the three signature types
                    PKCS1 signature = new PKCS1(inPfxFile, "12345");
                    // sign the PDF file
                    pdfSign.Sign(1, "", "Contact", "", true, rect, signature);
                    //save output PDF file
                    pdfSign.Save(outFile);
                }
                // ExEnd:SuppressLocationAndReason 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
