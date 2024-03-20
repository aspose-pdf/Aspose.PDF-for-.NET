using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.QuickStart
{
    public class LoadLicenseFromFile
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_QuickStart();
            // Initialize license object
            Aspose.Pdf.License license = new Aspose.Pdf.License();
            // Set license
            license.SetLicense("c:\\keys\\Aspose.Pdf.net.lic");
            Console.WriteLine("License set successfully.");
            // ExEnd:1
        }
    }
}
