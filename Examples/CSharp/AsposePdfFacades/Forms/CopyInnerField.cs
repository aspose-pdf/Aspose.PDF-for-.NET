using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class CopyInnerField
    {
        public static void Run()
        {
            try
            {
                // ExStart:CopyInnerField
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();
                // Create FormEditor object
                FormEditor formEditor = new FormEditor();
                // Open Document
                formEditor.BindPdf(dataDir + "CopyInnerField.pdf");
                // Copy a field to another page
                formEditor.CopyInnerField("textfield", "newfieldname", 1);

                // Close and save the output document
                formEditor.Save(dataDir + "CopyInnerField_out.pdf");
                // ExEnd:CopyInnerField
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            
        }
    }
}