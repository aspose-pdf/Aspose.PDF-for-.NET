using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.QuickStart
{
    public class SetLicenseUsingEmbeddedResource
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_QuickStart();
            // Initialize license object
            Aspose.Pdf.License license = new Aspose.Pdf.License();
            // Set license
            license.SetLicense("MergedAPI.Aspose.Total.lic");
            // Set the value to indicate that license will be embedded in the application
            license.Embedded = true;
            Console.WriteLine("License set successfully.");
            // ExEnd:1  
        }
    }
}
