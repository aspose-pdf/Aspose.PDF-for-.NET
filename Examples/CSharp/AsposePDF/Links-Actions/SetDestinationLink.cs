using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.LinksActions
{
    public class SetDestinationLink
    {
        public static void Run()
        {
            try
            {
                // ExStart:SetDestinationLink
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();
                // Load the PDF file
                Document doc = new Document(dataDir + "UpdateLinks.pdf");
               
                // Get the first link annotation from first page of document
                LinkAnnotation linkAnnot = (LinkAnnotation)doc.Pages[1].Annotations[1];
                // Modification link: change link action and set target as web address
                linkAnnot.Action = new GoToURIAction("www.aspose.com");           

                dataDir = dataDir + "SetDestinationLink_out.pdf";
                // Save the document with updated link
                doc.Save(dataDir);
                // ExEnd:SetDestinationLink
                Console.WriteLine("\nDestination link setup successfully.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}