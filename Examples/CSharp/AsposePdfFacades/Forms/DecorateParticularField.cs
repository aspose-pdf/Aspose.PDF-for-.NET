using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class DecorateParticularField
    {
        public static void Run()
        {
            // ExStart:DecorateParticularField
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            FormEditor form = new FormEditor();
            // Open the document and create a FormEditor object
            form.BindPdf(dataDir + "input.pdf");
            // Set field facade
            FormFieldFacade fieldFacade = new FormFieldFacade();
            form.Facade = fieldFacade;
            fieldFacade.BackgroundColor = System.Drawing.Color.Red;
            fieldFacade.FontSize = 14;
            // Specify the form field which needs to be decorated
            form.DecorateField("textfield");
            // Save updated PDF form
            form.Save(dataDir + "DecorateParticularField_out.pdf");
            // ExEnd:DecorateParticularField
        }
        public static void SetFont()
        {
            // ExStart:SetFont
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            FormEditor form = new FormEditor();
            // Open the document and create a FormEditor object
            form.BindPdf(dataDir + "input.pdf");
            // Set field facade
            FormFieldFacade fieldFacade = new FormFieldFacade();
            form.Facade = fieldFacade;
            fieldFacade.BackgroundColor = System.Drawing.Color.Red;
            fieldFacade.FontSize = 14;
            // Set font for form field
            fieldFacade.CustomFont = "CourierNew";
            // Specify the form field which needs to be decorated
            form.DecorateField("textfield");
            // Save updated PDF form
            form.Save("SetFont_out.pdf");
            // ExEnd:SetFont
        }
    }
}