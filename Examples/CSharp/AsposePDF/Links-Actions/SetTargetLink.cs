using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.LinksActions
{
    public class SetTargetLink
    {
        public static void Run()
        {
            try
            {
                // ExStart:SetTargetLink
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();
                // Load the PDF file
                Document document = new Document(dataDir + "UpdateLinks.pdf");

                LinkAnnotation linkAnnot = (LinkAnnotation)document.Pages[1].Annotations[1];

                GoToRemoteAction goToR = (GoToRemoteAction)linkAnnot.Action;
                // Next line update destination, do not update file
                goToR.Destination = new XYZExplicitDestination(2, 0, 0, 1.5);
                // Next line update file
                goToR.File = new FileSpecification(dataDir +  "input.pdf");

                dataDir = dataDir + "SetTargetLink_out.pdf";
                // Save the document with updated link
                document.Save(dataDir);
                // ExEnd:SetTargetLink
                Console.WriteLine("\nTarget link setup successfully.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}