using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Forms;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class GetValuesFromAllFields
    {
        public static void Run()
        {
            // ExStart:GetValuesFromAllFields
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetValuesFromAllFields.pdf");

            // Get values from all fields
            foreach (Field formField in pdfDocument.Form)
            {
                Console.WriteLine("Field Name : {0} ", formField.PartialName);
                Console.WriteLine("Value : {0} ", formField.Value);
            }
            // ExEnd:GetValuesFromAllFields
        }
    }
}