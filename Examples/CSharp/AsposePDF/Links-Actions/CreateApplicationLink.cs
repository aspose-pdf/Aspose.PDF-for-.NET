using System.IO;
using System;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.LinksActions
{
    public class CreateApplicationLink
    {
        public static void Run()
        {
            // ExStart:CreateApplicationLink
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();

            // Open document
            Document document = new Document( dataDir + "CreateApplicationLink.pdf");

            // Create link
            Page page = document.Pages[1];
            LinkAnnotation link = new LinkAnnotation(page, new Aspose.Pdf.Rectangle(100, 100, 300, 300));
            link.Color = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Green);
            link.Action = new LaunchAction(document, dataDir + "CreateApplicationLink.pdf");
            page.Annotations.Add(link);

            dataDir = dataDir + "CreateApplicationLink_out.pdf";
            // Save updated document
            document.Save(dataDir);
            // ExEnd:CreateApplicationLink
            Console.WriteLine("\nApplication link created successfully.\nFile saved at " + dataDir);
                      
        }
    }
}