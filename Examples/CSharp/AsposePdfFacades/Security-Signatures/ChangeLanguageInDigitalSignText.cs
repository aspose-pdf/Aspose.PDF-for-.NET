using Aspose.Pdf.Forms;
using System;
using System.Globalization;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfFacades.Security_Signatures
{
    public class ChangeLanguageInDigitalSignText
    {
        public static void Run()
        {
            try
            {
                // ExStart:ChangeLanguageInDigitalSignText
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();
                string inPfxFile = dataDir + "certificate.pfx";
                string inFile = dataDir + "input.pdf";
                string outFile = dataDir + "output.pdf";

                using (Aspose.Pdf.Facades.PdfFileSignature pdfSign = new Aspose.Pdf.Facades.PdfFileSignature())
                {
                    pdfSign.BindPdf(inFile);
                    //create a rectangle for signature location
                    System.Drawing.Rectangle rect = new System.Drawing.Rectangle(310, 45, 200, 50);

                    //create any of the three signature types
                    PKCS7 pkcs = new PKCS7(inPfxFile, "12345");
                    pkcs.Reason = "Pruebas Firma";
                    pkcs.ContactInfo = "Contacto Pruebas";
                    pkcs.Location = "Población (Provincia)";
                    pkcs.Date = DateTime.Now;
                    SignatureCustomAppearance signatureCustomAppearance = new SignatureCustomAppearance();
                    signatureCustomAppearance.DateSignedAtLabel = "Fecha";
                    signatureCustomAppearance.DigitalSignedLabel = "Digitalmente firmado por";
                    signatureCustomAppearance.ReasonLabel = "Razón";
                    signatureCustomAppearance.LocationLabel = "Localización";
                    signatureCustomAppearance.FontFamilyName = "Arial";
                    signatureCustomAppearance.FontSize = 10d;
                    signatureCustomAppearance.Culture = CultureInfo.InvariantCulture;
                    signatureCustomAppearance.DateTimeFormat = "yyyy.MM.dd HH:mm:ss";
                    pkcs.CustomAppearance = signatureCustomAppearance;
                    // sign the PDF file
                    pdfSign.Sign(1, true, rect, pkcs);
                    //save output PDF file
                    pdfSign.Save(outFile);

                    // ExEnd:ChangeLanguageInDigitalSignText 
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
