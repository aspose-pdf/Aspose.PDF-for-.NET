using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.LinksActions
{
    public class AddHyperlink
    {
        public static void Run()
        {
            // ExStart:AddHyperlink
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();

            // Open document
            Document document = new Document(dataDir + "AddHyperlink.pdf");
            // Create link
            Page page = document.Pages[1];
            // Create Link annotation object
            LinkAnnotation link = new LinkAnnotation(page, new Aspose.Pdf.Rectangle(100, 100, 300, 300));
            // Create border object for LinkAnnotation
            Border border = new Border(link);
            // Set the border width value as 0
            border.Width = 0;
            // Set the border for LinkAnnotation
            link.Border = border;
            // Specify the link type as remote URI
            link.Action = new GoToURIAction("www.aspose.com");
            // Add link annotation to annotations collection of first page of PDF file
            page.Annotations.Add(link);

            // Create Free Text annotation
            FreeTextAnnotation textAnnotation = new FreeTextAnnotation(document.Pages[1], new Aspose.Pdf.Rectangle(100, 100, 300, 300), new DefaultAppearance(Aspose.Pdf.Text.FontRepository.FindFont("TimesNewRoman"), 10, System.Drawing.Color.Blue));
            // String to be added as Free text
            textAnnotation.Contents = "Link to Aspose website";
            // Set the border for Free Text Annotation
            textAnnotation.Border = border;
            // Add FreeText annotation to annotations collection of first page of Document
            document.Pages[1].Annotations.Add(textAnnotation);
            dataDir = dataDir + "AddHyperlink_out.pdf";
            // Save updated document
            document.Save(dataDir);
            // ExEnd:AddHyperlink
            Console.WriteLine("\nHyperlink added successfully.\nFile saved at " + dataDir);            
        }
    }
}