using System;
using System.IO;
using Aspose.Pdf.Forms;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class SelectRadioButton
    {
        public static void Run()
        {
            try
            {
                // ExStart:SelectRadioButton
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();
                // Open document
                Document pdfDocument = new Document(dataDir + "RadioButton.pdf");
                // Get a field
                RadioButtonField radioField = pdfDocument.Form["radio"] as RadioButtonField;
                // Specify the index of radio button from group
                radioField.Selected = 2;

                dataDir = dataDir + "SelectRadioButton_out.pdf";
                // Save the PDF file
                pdfDocument.Save(dataDir);
                // ExEnd:SelectRadioButton
                Console.WriteLine("\nRadioButton from group selected successfully.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}