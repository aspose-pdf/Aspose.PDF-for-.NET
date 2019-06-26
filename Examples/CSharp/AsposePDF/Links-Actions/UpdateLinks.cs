using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.LinksActions
{
    public class UpdateLinks
    {
        public static void Run()
        {
            try
            {
                // ExStart:UpdateLinks
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();
                // Load the PDF file
                Document doc = new Document(dataDir + "UpdateLinks.pdf");
                // Get the first link annotation from first page of document
                LinkAnnotation linkAnnot = (LinkAnnotation)doc.Pages[1].Annotations[1];
                // Modification link: change link destination
                GoToAction goToAction = (GoToAction)linkAnnot.Action;
                // Specify the destination for link object
                // The first parameter is document object, second is destination page number.
                // The 5ht argument is zoom factor when displaying the respective page. When using 2, the page will be displayed in 200% zoom
                goToAction.Destination = new Aspose.Pdf.Annotations.XYZExplicitDestination(1, 1, 2, 2);
                dataDir = dataDir + "PDFLINK_Modified_UpdateLinks_out.pdf";
                // Save the document with updated link
                doc.Save(dataDir);
                // ExEnd:UpdateLinks
                Console.WriteLine("\nLinks updated successfully.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}