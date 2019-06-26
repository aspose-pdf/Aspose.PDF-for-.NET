using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class RemoveUnusedFonts
    {
        public static void Run()
        {
            try
            {
                // ExStart:RemoveUnusedFonts
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

                // Load source PDF file
                Document doc = new Document(dataDir + "ReplaceTextPage.pdf");
                TextFragmentAbsorber absorber = new TextFragmentAbsorber(new TextEditOptions(TextEditOptions.FontReplace.RemoveUnusedFonts));
                doc.Pages.Accept(absorber);

                // Iterate through all the TextFragments
                foreach (TextFragment textFragment in absorber.TextFragments)
                {
                    textFragment.TextState.Font = FontRepository.FindFont("Arial, Bold");
                }

                dataDir = dataDir + "RemoveUnusedFonts_out.pdf";
                // Save updated document
                doc.Save(dataDir);
                // ExEnd:RemoveUnusedFonts            
                Console.WriteLine("\nUnused fonts removed successfully from pdf document.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}