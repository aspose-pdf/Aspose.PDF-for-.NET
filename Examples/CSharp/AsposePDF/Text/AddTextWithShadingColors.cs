using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class AddTextWithShadingColors
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            
            using (Document pdfDocument = new Document(dataDir + "text_sample4.pdf"))
            {
                TextFragmentAbsorber absorber = new TextFragmentAbsorber("Lorem ipsum");
                pdfDocument.Pages.Accept(absorber);

                TextFragment textFragment = absorber.TextFragments[1];

                // Create new color with pattern colorspace
                textFragment.TextState.ForegroundColor = new Aspose.Pdf.Color()
                {
                    PatternColorSpace = new Aspose.Pdf.Drawing.GradientAxialShading(Color.Red, Color.Blue)
                };
                textFragment.TextState.Underline = true;

                pdfDocument.Save(dataDir + "text_out.pdf");
            }
            // ExEnd:1
        }
    }
}
