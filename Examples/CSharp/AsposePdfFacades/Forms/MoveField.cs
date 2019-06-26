using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class MoveField
    {
        public static void Run()
        {
            // ExStart:MoveField
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();
    
            FormEditor formEditor = new FormEditor();
            // Open Document
            formEditor.BindPdf(dataDir + "input.pdf");

            // Move field to new location
            formEditor.MoveField("textfield", 300, 300, 400, 400);
            // Save updated file
            formEditor.Save( dataDir + "MoveFormField_out.pdf");
            // ExEnd:MoveField
        }
    }
}