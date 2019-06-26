using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class ReplaceTextonRegularExpression
    {
        public static void Run()
        {
            // ExStart:ReplaceTextonRegularExpression
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Open document
            Document pdfDocument = new Document(dataDir + "SearchRegularExpressionPage.pdf");
            
            // Create TextAbsorber object to find all the phrases matching the regular expression
            TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber("\\d{4}-\\d{4}"); // Like 1999-2000
            
            // Set text search option to specify regular expression usage
            TextSearchOptions textSearchOptions = new TextSearchOptions(true);
            textFragmentAbsorber.TextSearchOptions = textSearchOptions;
            
            // Accept the absorber for a single page
            pdfDocument.Pages[1].Accept(textFragmentAbsorber);
            
            // Get the extracted text fragments
            TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;
            
            // Loop through the fragments
            foreach (TextFragment textFragment in textFragmentCollection)
            {
                // Update text and other properties
                textFragment.Text = "New Phrase";
                // Set to an instance of an object.
                textFragment.TextState.Font = FontRepository.FindFont("Verdana");
                textFragment.TextState.FontSize = 22;
                textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Blue);
                textFragment.TextState.BackgroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Green);
            }
            dataDir = dataDir + "ReplaceTextonRegularExpression_out.pdf";
            pdfDocument.Save(dataDir);
            // ExEnd:ReplaceTextonRegularExpression
            Console.WriteLine("\nText replaced successfully based on a regular expression.\nFile saved at " + dataDir);
        }
    }
}