using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.LinksActions
{
    public class CreateDocumentLink
    {
        public static void Run()
        {
            // ExStart:CreateDocumentLink
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();
            // Open document
            Document document = new Document(dataDir+ "CreateDocumentLink.pdf");
            // Create link
            Page page = document.Pages[1];
            LinkAnnotation link = new LinkAnnotation(page, new Aspose.Pdf.Rectangle(100, 100, 300, 300));
            link.Color = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Green);
            link.Action = new GoToRemoteAction(dataDir + "RemoveOpenAction.pdf", 1);
            page.Annotations.Add(link);
            dataDir = dataDir + "CreateDocumentLink_out.pdf";
            // Save updated document
            document.Save(dataDir);
            // ExEnd:CreateDocumentLink
            Console.WriteLine("\nDocument link created successfully.\nFile saved at " + dataDir);            
        }
    }
}