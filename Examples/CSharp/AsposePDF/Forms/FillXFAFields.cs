using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class FillXFAFields
    {
        public static void Run()
        {
            // ExStart:FillXFAFields
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Load XFA form
            Document doc = new Document(dataDir + "FillXFAFields.pdf");

            // Get names of XFA form fields
            string[] names = doc.Form.XFA.FieldNames;

            // Set field values
            doc.Form.XFA[names[0]] = "Field 0";
            doc.Form.XFA[names[1]] = "Field 1";
            dataDir = dataDir + "Filled_XFA_out.pdf";
            // Save the updated document
            doc.Save(dataDir);
            // ExEnd:FillXFAFields
            Console.WriteLine("\nXFA fields filled successfully.\nFile saved at " + dataDir);
        }
    }
}