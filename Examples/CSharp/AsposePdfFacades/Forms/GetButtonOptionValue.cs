using System.IO;
using System;
using System.Collections;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class GetButtonOptionValue
    {
        public static void Run()
        {
            try
            {
                // ExStart:GetButtonOptionValue
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

                // Create Form Object
                Aspose.Pdf.Facades.Form pdfForm = new Aspose.Pdf.Facades.Form();

                // Open Document
                pdfForm.BindPdf(dataDir + "FormField.pdf");

                // Get button option values
                var optionValues = pdfForm.GetButtonOptionValues("Gender");

                IDictionaryEnumerator optionValueEnumerator = optionValues.GetEnumerator();

                while (optionValueEnumerator.MoveNext())
                    Console.WriteLine("Key : {0} , Value : {1} ", optionValueEnumerator.Key, optionValueEnumerator.Value);
                // ExEnd:GetButtonOptionValue
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void GetCurrentValue()
        {
            // ExStart:GetCurrentValue
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            // Create Form Object
            Aspose.Pdf.Facades.Form pdfForm = new Aspose.Pdf.Facades.Form();

            // Open Document
            pdfForm.BindPdf(dataDir + "FormField.pdf");

            // Get button option values
            string optionValue = pdfForm.GetButtonOptionCurrentValue("Gender");

            Console.WriteLine("Current Value : {0} ", optionValue);
            // ExEnd:GetCurrentValue
        }
    }
}