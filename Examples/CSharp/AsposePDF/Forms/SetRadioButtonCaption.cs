using System;
using Aspose.Pdf.Forms;
using System.Collections.Generic;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class SetRadioButtonCaption
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Load source PDF form
            Aspose.Pdf.Facades.Form form1 = new Aspose.Pdf.Facades.Form(dataDir + "RadioButtonField.pdf");
            Document PDF_Template_PDF_HTML = new Document(dataDir + "RadioButtonField.pdf");
            foreach (var item in form1.FieldNames)
            {
                Console.WriteLine(item.ToString());
                Dictionary<string, string> radioOptions = form1.GetButtonOptionValues(item);
                if (item.Contains("radio1"))
                {
                    Aspose.Pdf.Forms.RadioButtonField field0 = PDF_Template_PDF_HTML.Form[item] as Aspose.Pdf.Forms.RadioButtonField;
                    Aspose.Pdf.Forms.RadioButtonOptionField fieldoption = new Aspose.Pdf.Forms.RadioButtonOptionField();
                    fieldoption.OptionName = "Yes";
                    fieldoption.PartialName = "Yesname";

                    var updatedFragment = new Aspose.Pdf.Text.TextFragment("test123");
                    updatedFragment.TextState.Font = FontRepository.FindFont("Arial");
                    updatedFragment.TextState.FontSize = 10;
                    updatedFragment.TextState.LineSpacing = 6.32f;

                    // Create TextParagraph object
                    TextParagraph par = new TextParagraph();

                    // Set paragraph position
                    par.Position = new Position(field0.Rect.LLX, field0.Rect.LLY + updatedFragment.TextState.FontSize);
                    // Specify word wraping mode
                    par.FormattingOptions.WrapMode = TextFormattingOptions.WordWrapMode.ByWords;

                    // Add new TextFragment to paragraph
                    par.AppendLine(updatedFragment);

                    // Add the TextParagraph using TextBuilder
                    TextBuilder textBuilder = new TextBuilder(PDF_Template_PDF_HTML.Pages[1]);
                    textBuilder.AppendParagraph(par);

                    field0.DeleteOption("item1");
                }
            }
            PDF_Template_PDF_HTML.Save(dataDir + "RadioButtonField_out.pdf");
            // ExEnd:1   
        }
    }
}
