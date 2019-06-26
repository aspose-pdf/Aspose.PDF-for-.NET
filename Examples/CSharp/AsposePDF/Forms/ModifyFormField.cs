using System;
using System.IO;
using Aspose.Pdf.Forms;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class ModifyFormField
    {
        public static void Run()
        {
            // ExStart:ModifyFormField
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Open document
            Document pdfDocument = new Document(dataDir + "ModifyFormField.pdf");

            // Get a field
            TextBoxField textBoxField = pdfDocument.Form["textbox1"] as TextBoxField;

            // Modify field value
            textBoxField.Value = "New Value";
            textBoxField.ReadOnly = true;
            dataDir = dataDir + "ModifyFormField_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            // ExEnd:ModifyFormField
            Console.WriteLine("\nForm field modified successfully.\nFile saved at " + dataDir);
        }
    }
}