using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class AddListItem
    {
        public static void Run()
        {
            // ExStart:AddListItem
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            FormEditor form = new FormEditor();
            // Open the document and create a FormEditor object
            form.BindPdf(dataDir + "AddListItem.pdf");
            // Add list field in PDF file
            form.AddField(FieldType.ListBox, "listbox", 1, 300, 200, 350, 225);
            // Add list items
            form.AddListItem("listbox", "Item 1");
            form.AddListItem("listbox", "Item 2");
            // Add multiple list items once
            string[] listItems = { "Item 3", "Item 4", "Item 5" };
            form.AddListItem("listbox", listItems);
            // Save updated file
            form.Save(dataDir + "AddListItem_out.pdf");
            // ExEnd:AddListItem
        }        
    }
}