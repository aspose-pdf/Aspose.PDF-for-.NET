using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class DeleteListItem
    {
        public static void Run()
        {
            // ExStart:DeleteListItem
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            FormEditor form = new FormEditor();
            // Open the document and create a FormEditor object
            form.BindPdf(dataDir + "AddListItem.pdf");
            // Delete list item
            form.DelListItem("listbox", "Item 2");
            // Save updated file
            form.Save(dataDir + "DeleteListItem_out.pdf");
            // ExEnd:DeleteListItem
        }        
    }
}