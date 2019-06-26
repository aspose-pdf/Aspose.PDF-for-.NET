using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class DecorateFields
    {
        public static void Run()
        {
            // ExStart:DecorateFields
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            // Open document
            FormEditor form = new FormEditor();

            // Open the document and create a FormEditor object
            form.BindPdf(dataDir + "DecorateFields.pdf");

            // Create a new facade object
            FormFieldFacade facade = new FormFieldFacade();

            // Assign the facade to form editor
            form.Facade = facade;

            // Set the backgroud color as red
            facade.BackgroundColor = System.Drawing.Color.Red;

            // Set the alignment as center
            facade.Alignment = FormFieldFacade.AlignCenter;

            // All text fields will be modified:
            form.DecorateField(FieldType.Text);

            // Close and validate the modification like this:
            form.Save(dataDir + "DecorateFields_out.pdf");
            // ExEnd:DecorateFields
        }
    }
}