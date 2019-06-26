using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.LinksActions
{
    public class RemoveOpenAction
    {
        public static void Run()
        {
            // ExStart:RemoveOpenAction
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();
            // Open document
            Document document = new Document(dataDir + "RemoveOpenAction.pdf");
            // Remove document open action
            document.OpenAction = null;
            dataDir = dataDir + "RemoveOpenAction_out.pdf";
            // Save updated document
            document.Save(dataDir);
            // ExEnd:RemoveOpenAction
            Console.WriteLine("\nOpen action removed successfully.\nFile saved at " + dataDir); 
            
        }
    }
}