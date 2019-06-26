using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class DeleteFormField
    {
        public static void Run()
        {
            // ExStart:DeleteFormField
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Open document
            Document pdfDocument = new Document(dataDir + "DeleteFormField.pdf");

            // Delete a particular field by name
            pdfDocument.Form.Delete("textbox1");
            dataDir = dataDir + "DeleteFormField_out.pdf";
            // Save modified document
            pdfDocument.Save(dataDir);
            // ExEnd:DeleteFormField
            Console.WriteLine("\nParticular field deleted successfully.\nFile saved at " + dataDir);
        }
    }
}