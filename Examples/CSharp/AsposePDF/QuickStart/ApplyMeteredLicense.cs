using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.QuickStart
{
    public class ApplyMeteredLicense
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_QuickStart();
            // set metered public and private keys
            Aspose.Pdf.Metered metered = new Aspose.Pdf.Metered();
            // Access the setMeteredKey property and pass public and private keys as parameters
            metered.SetMeteredKey("*****", "*****");

            // Load the document from disk.
            Document doc = new Document(dataDir + "input.pdf");
            //Get the page count of document
            Console.WriteLine(doc.Pages.Count);
            // ExEnd:1  
        }
    }
}
