using System;
using System.IO;
using Aspose.Pdf.Forms;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class ArabicTextFilling
    {
        public static void Run()
        {
            // ExStart:ArabicTextFilling
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Load PDF form contents
            FileStream fs = new FileStream(dataDir + "FillFormField.pdf", FileMode.Open, FileAccess.ReadWrite);
            // Instantiate Document instance with stream holding form file
            Aspose.Pdf.Document pdfDocument = new Aspose.Pdf.Document(fs);
            // Get referecne of particuarl TextBoxField
            TextBoxField txtFld = pdfDocument.Form["textbox1"] as TextBoxField;
            // Fill form field with arabic text
            txtFld.Value = "يولد جميع الناس أحراراً متساوين في";

            dataDir = dataDir + "ArabicTextFilling_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            // ExEnd:ArabicTextFilling
            Console.WriteLine("\nArabic text filled successfully in form field.\nFile saved at " + dataDir);
        }
    }
}