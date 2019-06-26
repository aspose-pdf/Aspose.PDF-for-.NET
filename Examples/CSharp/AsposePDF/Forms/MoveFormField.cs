using System;
using System.IO;
using Aspose.Pdf.Forms;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class MoveFormField
    {
        public static void Run()
        {
            // ExStart:MoveFormField
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Open document
            Document pdfDocument = new Document(dataDir + "MoveFormField.pdf");

            // Get a field
            TextBoxField textBoxField = pdfDocument.Form["textbox1"] as TextBoxField;

            // Modify field location
            textBoxField.Rect = new Aspose.Pdf.Rectangle(300, 400, 600, 500);

            dataDir = dataDir + "MoveFormField_out.pdf";
            // Save modified document
            pdfDocument.Save(dataDir);
            // ExEnd:MoveFormField
            Console.WriteLine("\nForm field moved successfully to a new location.\nFile saved at " + dataDir);

        }
    }
}