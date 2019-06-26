using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class GetXFAProperties
    {
        public static void Run()
        {
            // ExStart:GetXFAProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Load XFA form
            Document doc = new Document(dataDir + "GetXFAProperties.pdf");

            string[] names = doc.Form.XFA.FieldNames;

            // Set field values
            doc.Form.XFA[names[0]] = "Field 0";
            doc.Form.XFA[names[1]] = "Field 1";

            // Get field position
            Console.WriteLine(doc.Form.XFA.GetFieldTemplate(names[0]).Attributes["x"].Value);

            // Get field position
            Console.WriteLine(doc.Form.XFA.GetFieldTemplate(names[0]).Attributes["y"].Value);

            dataDir = dataDir + "Filled_XFA_out.pdf";
            // Save the updated document
            doc.Save(dataDir);
            // ExEnd:GetXFAProperties
            Console.WriteLine("\nXFA fields properties retrieved successfully.\nFile saved at " + dataDir);

        }
    }
}