using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Forms;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class PreserveRights
    {
        public static void Run()
        {
            // ExStart:PreserveRights
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Read the source PDF form with FileAccess of Read and Write.
            // We need ReadWrite permission because after modification,
            // We need to save the updated contents in same document/file.
            FileStream fs = new FileStream(dataDir + "input.pdf", FileMode.Open, FileAccess.ReadWrite);
            // Instantiate Document instance
            Aspose.Pdf.Document pdfDocument = new Aspose.Pdf.Document(fs);
            // Get values from all fields
            foreach (Field formField in pdfDocument.Form)
            {
                // If the fullname of field contains A1, perform the operation
                if (formField.FullName.Contains("A1"))
                {
                    // Cast form field as TextBox
                    TextBoxField textBoxField = formField as TextBoxField;
                    // Modify field value
                    textBoxField.Value = "Testing";
                }
            }
            // Save the updated document in save FileStream
            pdfDocument.Save();
            // Close the File Stream object
            fs.Close();
            // ExEnd:PreserveRights            
        }
        public static void PreserveRightsUsingFormClass()
        {
            // ExStart:PreserveRightsUsingFormClass
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();
            // Input and output file paths are equal, this forces incremental update when form saved.
            Aspose.Pdf.Facades.Form form = new Aspose.Pdf.Facades.Form(dataDir + "input.pdf");
            // Fill value in form field
            form.FillField("topmostSubform[0].Page1[0].f1_29_0_[0]", "Nayyer");
            // Save updated document
            form.Save(dataDir + "PreserveRightsUsingFormClass_out.pdf");
            // ExEnd:PreserveRightsUsingFormClass
        }       
    }
}