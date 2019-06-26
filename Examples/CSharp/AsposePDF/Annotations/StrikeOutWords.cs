using System;
using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class StrikeOutWords
    {
        public static void Run()
        {
            
            // ExStart:StrikeOutWords
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            // Open document
            Document document = new Document(dataDir + "input.pdf");

            // Create TextFragment Absorber instance to search particular text fragment
            Aspose.Pdf.Text.TextFragmentAbsorber textFragmentAbsorber = new Aspose.Pdf.Text.TextFragmentAbsorber("Estoque");
            // Iterate through pages of PDF document
            for (int i = 1; i <= document.Pages.Count; i++)
            {
                // Get first page of PDF document
                Page page = document.Pages[1];
                page.Accept(textFragmentAbsorber);
            }

            // Create a collection of Absorbed text
            Aspose.Pdf.Text.TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;

            // Iterate on above collection
            for (int j = 1; j <= textFragmentCollection.Count; j++)
            {
                Aspose.Pdf.Text.TextFragment textFragment = textFragmentCollection[j];

                // Get rectangular dimensions of TextFragment object  	
                Aspose.Pdf.Rectangle rect = new Aspose.Pdf.Rectangle(
                            (float)textFragment.Position.XIndent,
                            (float)textFragment.Position.YIndent,
                            (float)textFragment.Position.XIndent +
                            (float)textFragment.Rectangle.Width,
                            (float)textFragment.Position.YIndent +
                            (float)textFragment.Rectangle.Height);

                // Instantiate StrikeOut Annotation instance
                StrikeOutAnnotation strikeOut = new StrikeOutAnnotation(textFragment.Page, rect);
                // Set opacity for annotation
                strikeOut.Opacity = .80f;
                // Set the border for annotation instance
                strikeOut.Border = new Border(strikeOut);
                // Set the color of annotation
                strikeOut.Color = Aspose.Pdf.Color.Red;
                // Add annotation to annotations collection of TextFragment
                textFragment.Page.Annotations.Add(strikeOut);
            }
            dataDir = dataDir + "StrikeOutWords_out.pdf";
            document.Save(dataDir);
            // ExEnd:StrikeOutWords    
            Console.WriteLine("\nWords strikeout successfully.\nFile saved at " + dataDir);

        }
    }
}