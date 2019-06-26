
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class ReplaceFirstOccurrence
    {
        public static void Run()
        {
            // ExStart:ReplaceFirstOccurrence 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Open document
            Document pdfDocument = new Document(dataDir + "ReplaceTextPage.pdf");

            // Create TextAbsorber object to find all instances of the input search phrase
            TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber("text");
            // Accept the absorber for all the pages
            pdfDocument.Pages.Accept(textFragmentAbsorber);
            // Get the extracted text fragments
            TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;
            if (textFragmentCollection.Count > 0)
            {
                // Get first occurance of text and replace
                TextFragment textFragment = textFragmentCollection[1];
                // Update text and other properties
                textFragment.Text = "New Phrase";
                textFragment.TextState.Font = FontRepository.FindFont("Verdana");
                textFragment.TextState.FontSize = 22;
                textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Blue);

                dataDir = dataDir + "ReplaceFirstOccurrence_out.pdf";
                pdfDocument.Save(dataDir);                 

                Console.WriteLine("\nText replaced successfully.\nFile saved at " + dataDir);
            }
            // ExEnd:ReplaceFirstOccurrence 
        }
    }
}