using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class EmbedStandardType1Fonts
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Load an existing PDF Document
            Document pdfDocument = new Document(dataDir + "input.pdf");
            // Set EmbedStandardFonts property of document
            pdfDocument.EmbedStandardFonts = true;
            foreach (Aspose.Pdf.Page page in pdfDocument.Pages)
            {
                if (page.Resources.Fonts != null)
                {
                    foreach (Aspose.Pdf.Text.Font pageFont in page.Resources.Fonts)
                    {
                        // Check if font is already embedded
                        if (!pageFont.IsEmbedded)
                        {
                            pageFont.IsEmbedded = true;
                        }
                    }
                }
            }
            pdfDocument.Save(dataDir + "EmbeddedFonts-updated_out.pdf");
            // ExEnd:1            
        }
    }
}
