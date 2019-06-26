using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class SearchTextAndAddHyperlink
    {
        public static void Run()
        {
            // ExStart:SearchTextAndAddHyperlink
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Create absorber object to find all instances of the input search phrase
            TextFragmentAbsorber absorber = new TextFragmentAbsorber("\\d{4}-\\d{4}");
            // Enable regular expression search
            absorber.TextSearchOptions = new TextSearchOptions(true);
            // Open document
            PdfContentEditor editor = new PdfContentEditor();
            // Bind source PDF file
            editor.BindPdf(dataDir + "SearchRegularExpressionPage.pdf");
            // Accept the absorber for the page
            editor.Document.Pages[1].Accept(absorber);

            int[] dashArray = { };
            String[] LEArray = { };
            System.Drawing.Color blue = System.Drawing.Color.Blue;

            // Loop through the fragments
            foreach (TextFragment textFragment in absorber.TextFragments)
            {
                textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.Blue;
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle((int)textFragment.Rectangle.LLX,
                    (int)Math.Round(textFragment.Rectangle.LLY), (int)Math.Round(textFragment.Rectangle.Width + 2),
                    (int)Math.Round(textFragment.Rectangle.Height + 1));
                Enum[] actionName = new Enum[2] { Aspose.Pdf.Annotations.PredefinedAction.Document_AttachFile, Aspose.Pdf.Annotations.PredefinedAction.Document_ExtractPages };
                editor.CreateWebLink(rect, "http:// Www.aspose.com", 1, blue, actionName);
                editor.CreateLine(rect, "", (float)textFragment.Rectangle.LLX + 1, (float)textFragment.Rectangle.LLY - 1,
                    (float)textFragment.Rectangle.URX, (float)textFragment.Rectangle.LLY - 1, 1, 1, blue, "S", dashArray, LEArray);
            }

            dataDir = dataDir + "SearchTextAndAddHyperlink_out.pdf";
            editor.Save(dataDir);
            editor.Close();
            // ExEnd:SearchTextAndAddHyperlink
            Console.WriteLine("\nText replaced and hyperlink added successfully based on a regular expression.\nFile saved at " + dataDir);
        }
    }
}