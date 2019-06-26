using Aspose.Pdf.Forms;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class AddTooltipToText
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            string outputFile = dataDir + "Tooltip_out.pdf";

            // Create sample document with text
            Document doc = new Document();
            doc.Pages.Add().Paragraphs.Add(new TextFragment("Move the mouse cursor here to display a tooltip"));
            doc.Pages[1].Paragraphs.Add(new TextFragment("Move the mouse cursor here to display a very long tooltip"));
            doc.Save(outputFile);

            // Open document with text
            Document document = new Document(outputFile);
            // Create TextAbsorber object to find all the phrases matching the regular expression
            TextFragmentAbsorber absorber = new TextFragmentAbsorber("Move the mouse cursor here to display a tooltip");
            // Accept the absorber for the document pages
            document.Pages.Accept(absorber);
            // Get the extracted text fragments
            TextFragmentCollection textFragments = absorber.TextFragments;

            // Loop through the fragments
            foreach (TextFragment fragment in textFragments)
            {
                // Create invisible button on text fragment position
                ButtonField field = new ButtonField(fragment.Page, fragment.Rectangle);
                // AlternateName value will be displayed as tooltip by a viewer application
                field.AlternateName = "Tooltip for text.";
                // Add button field to the document
                document.Form.Add(field);
            }

            // Next will be sapmle of very long tooltip
            absorber = new TextFragmentAbsorber("Move the mouse cursor here to display a very long tooltip");
            document.Pages.Accept(absorber);
            textFragments = absorber.TextFragments;

            foreach (TextFragment fragment in textFragments)
            {
                ButtonField field = new ButtonField(fragment.Page, fragment.Rectangle);
                // Set very long text
                field.AlternateName = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
                                        " sed do eiusmod tempor incididunt ut labore et dolore magna" +
                                        " aliqua. Ut enim ad minim veniam, quis nostrud exercitation" +
                                        " ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                                        " Duis aute irure dolor in reprehenderit in voluptate velit" +
                                        " esse cillum dolore eu fugiat nulla pariatur. Excepteur sint" +
                                        " occaecat cupidatat non proident, sunt in culpa qui officia" +
                                        " deserunt mollit anim id est laborum.";
                document.Form.Add(field);
            }

            // Save document
            document.Save(outputFile);
            // ExEnd:1
        }
    }
}
