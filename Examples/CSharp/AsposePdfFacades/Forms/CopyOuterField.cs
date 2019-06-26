using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class CopyOuterField
    {
        public static void Run()
        {
            try
            {
                // ExStart:CopyOuterField
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

                // Open document
                FormEditor formEditor = new FormEditor();

                // Open the document and create a FormEditor object
                formEditor.BindPdf(dataDir + "CopyOuterField.pdf");

                // Copy a text field from one document to another one
                formEditor.CopyOuterField( dataDir + "input.pdf", "textfield", 1);

                // Close and save the output document
                formEditor.Save(dataDir + "CopyOuterField_out.pdf");
                // ExEnd:CopyOuterField
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }           
            
        }
    }
}