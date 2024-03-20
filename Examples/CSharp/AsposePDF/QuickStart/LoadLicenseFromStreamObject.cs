using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.QuickStart
{
    public class LoadLicenseFromStreamObject
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_QuickStart();
            // Initialize license object
            Aspose.Pdf.License license = new Aspose.Pdf.License();
            // Load license in FileStream
            FileStream myStream = new FileStream(@"c:\Keys\Aspose.Pdf.net.lic", FileMode.Open);
            // Set license
            license.SetLicense(myStream);
            Console.WriteLine("License set successfully.");
            // ExEnd:1
        }
    }
}
