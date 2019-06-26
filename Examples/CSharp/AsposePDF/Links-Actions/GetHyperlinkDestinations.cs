using System;
using System.IO;
using Aspose.Pdf;
using System.Collections;
using Aspose.Pdf.Annotations;
using System.Collections.Generic;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.LinksActions
{
    public class GetHyperlinkDestinations
    {
        public static void Run()
        {
            try
            {
                // ExStart:GetHyperlinkDestinations
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();
                // Load the PDF file
                Document document = new Document(dataDir + "input.pdf");

                // Traverse through all the page of PDF
                foreach (Aspose.Pdf.Page page in document.Pages)
                {
                    // Get the link annotations from particular page
                    AnnotationSelector selector = new AnnotationSelector(new Aspose.Pdf.Annotations.LinkAnnotation(page, Aspose.Pdf.Rectangle.Trivial));

                    page.Accept(selector);
                    // Create list holding all the links
                    IList<Annotation> list = selector.Selected;
                    // Iterate through invidiaul item inside list
                    foreach (LinkAnnotation a in list)
                    {
                        // Print the destination URL
                        Console.WriteLine("\nDestination: " + (a.Action as Aspose.Pdf.Annotations.GoToURIAction).URI + "\n");
                    }
                }
                // ExEnd:GetHyperlinkDestinations               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}