using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class RearrangeContentsUsingTextReplacement
    {
        public static void Run()
        {
            try
            {
                // ExStart:RearrangeContentsUsingTextReplacement
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

                // Load source PDF file
                Document doc = new Document(dataDir + "ExtractTextPage.pdf");
                // Create TextFragment Absorber object with regular expression
                TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber("[TextFragmentAbsorber,companyname,Textbox,50]");
                doc.Pages.Accept(textFragmentAbsorber);
                // Replace each TextFragment
                foreach (TextFragment textFragment in textFragmentAbsorber.TextFragments)
                {
                    // Set font of text fragment being replaced
                    textFragment.TextState.Font = FontRepository.FindFont("Arial");
                    // Set font size
                    textFragment.TextState.FontSize = 12;
                    textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.Navy;
                    // Replace the text with larger string than placeholder
                    textFragment.Text = "This is a Larger String for the Testing of this issue";
                }
                dataDir = dataDir + "RearrangeContentsUsingTextReplacement_out.pdf";
                // Save resultant PDF
                doc.Save(dataDir);
                // ExEnd:RearrangeContentsUsingTextReplacement            
                Console.WriteLine("\nContents rearranged successfully using text replacement.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}