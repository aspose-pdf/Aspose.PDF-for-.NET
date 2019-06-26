using System.IO;
using Aspose.Pdf;
using  Aspose.Pdf.Forms;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class DetermineRequiredField
    {
        public static void Run()
        {
            // ExStart:DetermineRequiredField
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Load source PDF file
            Document pdf = new Document(dataDir + "DetermineRequiredField.pdf");

            // Instantiate Form object
            Aspose.Pdf.Facades.Form pdfForm = new Aspose.Pdf.Facades.Form(pdf);

            // Iterate through each field inside PDF form
            foreach (Field field in pdf.Form.Fields)
            {
                // Determine if the field is marked as required or not
                bool isRequired = pdfForm.IsRequiredField(field.FullName);
                if (isRequired)
                {
                    // Print either the field is marked as required or not
                    Console.WriteLine("The field named " + field.FullName + " is required");
                }
            }
            // ExEnd:DetermineRequiredField
        }
    }
}