using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class ReplaceTextAll
    {
        public static void Run()
        {
            // ExStart:ReplaceTextAll
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Open document
            Document pdfDocument = new Document(dataDir + "ReplaceTextAll.pdf");
            
            // Create TextAbsorber object to find all instances of the input search phrase
            TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber("text");
            
            // Accept the absorber for all the pages
            pdfDocument.Pages.Accept(textFragmentAbsorber);
            
            // Get the extracted text fragments
            TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;
            
            // Loop through the fragments
            foreach (TextFragment textFragment in textFragmentCollection)
            {
                // Update text and other properties
                textFragment.Text = "TEXT";
                textFragment.TextState.Font = FontRepository.FindFont("Verdana");
                textFragment.TextState.FontSize = 22;
                textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Blue);
                textFragment.TextState.BackgroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Green);
            }

            dataDir = dataDir + "ReplaceTextAll_out.pdf";
            // Save resulting PDF document.
            pdfDocument.Save(dataDir);
            // ExEnd:ReplaceTextAll
            Console.WriteLine("\nText replaced  successfully.\nFile saved at " + dataDir);
        }
    }
}