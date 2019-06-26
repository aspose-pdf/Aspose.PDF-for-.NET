
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Forms;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class HiddenTextBlock
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            string outputFile = dataDir + "TextBlock_HideShow_MouseOverOut_out.pdf";

            // Create sample document with text
            Document doc = new Document();
            doc.Pages.Add().Paragraphs.Add(new TextFragment("Move the mouse cursor here to display floating text"));
            doc.Save(outputFile);

            // Open document with text
            Document document = new Document(outputFile);
            // Create TextAbsorber object to find all the phrases matching the regular expression
            TextFragmentAbsorber absorber = new TextFragmentAbsorber("Move the mouse cursor here to display floating text");
            // Accept the absorber for the document pages
            document.Pages.Accept(absorber);
            // Get the first extracted text fragment
            TextFragmentCollection textFragments = absorber.TextFragments;
            TextFragment fragment = textFragments[1];

            // Create hidden text field for floating text in the specified rectangle of the page
            TextBoxField floatingField = new TextBoxField(fragment.Page, new Rectangle(100, 700, 220, 740));
            // Set text to be displayed as field value
            floatingField.Value = "This is the \"floating text field\".";
            // We recommend to make field 'readonly' for this scenario
            floatingField.ReadOnly = true;
            // Set 'hidden' flag to make field invisible on document opening
            floatingField.Flags |= AnnotationFlags.Hidden;

            // Setting a unique field name isn't necessary but allowed
            floatingField.PartialName = "FloatingField_1";

            // Setting characteristics of field appearance isn't necessary but makes it better
            floatingField.DefaultAppearance = new DefaultAppearance("Helv", 10, System.Drawing.Color.Blue);
            floatingField.Characteristics.Background = System.Drawing.Color.LightBlue;
            floatingField.Characteristics.Border = System.Drawing.Color.DarkBlue;
            floatingField.Border = new Border(floatingField);
            floatingField.Border.Width = 1;
            floatingField.Multiline = true;

            // Add text field to the document
            document.Form.Add(floatingField);

            // Create invisible button on text fragment position
            ButtonField buttonField = new ButtonField(fragment.Page, fragment.Rectangle);
            // Create new hide action for specified field (annotation) and invisibility flag.
            // (You also may reffer floating field by the name if you specified it above.)
            // Add actions on mouse enter/exit at the invisible button field
            buttonField.Actions.OnEnter = new HideAction(floatingField, false);
            buttonField.Actions.OnExit = new HideAction(floatingField);

            // Add button field to the document
            document.Form.Add(buttonField);

            // Save document
            document.Save(outputFile);
            // ExEnd:1
        }
    }
}
