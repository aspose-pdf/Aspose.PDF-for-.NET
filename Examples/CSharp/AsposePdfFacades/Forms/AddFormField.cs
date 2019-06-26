using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class AddFormField
    {
        public static void Run()
        {
            // ExStart:AddFormField
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();
 
            FormEditor formEditor = new FormEditor();
            // Open Document
            formEditor.BindPdf(dataDir+ "AddFormField.pdf");

            // Add field
            formEditor.AddField(FieldType.Text, "textfield", 1, 100, 100, 200, 150);
            formEditor.AddField(FieldType.CheckBox, "checkboxfield", 1, 100, 200, 200, 250);
            formEditor.AddField(FieldType.ComboBox, "comboboxfield", 1, 100, 300, 200, 350);
            formEditor.AddField(FieldType.ListBox, "listboxfield", 1, 100, 400, 200, 450);
            formEditor.AddField(FieldType.MultiLineText, "multilinetextfield", 1, 100, 500, 200, 550);

            // Save updated file
            formEditor.Save(dataDir+ "AddFormField_out.pdf");
            // ExEnd:AddFormField
        }
    }
}