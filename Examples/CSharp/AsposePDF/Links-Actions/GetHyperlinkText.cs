using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System.Collections;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.LinksActions
{
    public class GetHyperlinkText
    {
        public static void Run()
        {
            try
            {
                // ExStart:GetHyperlinkText
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();
                // Load the PDF file
                Document document = new Document(dataDir + "input.pdf");
                // Iterate through each page of PDF
                foreach (Page page in document.Pages)
                {
                    // Show link annotation
                    ShowLinkAnnotations(page);
                }
                // ExEnd:GetHyperlinkText               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // ExStart:ShowLinkAnnotations
        public static void ShowLinkAnnotations(Page page)
        {
            foreach (Aspose.Pdf.Annotations.Annotation annot in page.Annotations)
            {
                if (annot is LinkAnnotation)
                {
                    // Print the URL of each Link Annotation
                    Console.WriteLine("URI: " + ((annot as LinkAnnotation).Action as GoToURIAction).URI);
                    TextAbsorber absorber = new TextAbsorber();
                    absorber.TextSearchOptions.LimitToPageBounds = true;
                    absorber.TextSearchOptions.Rectangle = annot.Rect;
                    page.Accept(absorber);
                    string extractedText = absorber.Text;
                    // Print the text associated with hyperlink
                    Console.WriteLine(extractedText);
                }

            }
        }
        // ExEnd:ShowLinkAnnotations
    }
}