using System.IO;
using Aspose.Pdf.Forms;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class GetValueFromField
    {
        public static void Run()
        {
            // ExStart:GetValueFromField
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetValueFromField.pdf");

            // Get a field
            TextBoxField textBoxField = pdfDocument.Form["textbox1"] as TextBoxField;

            // Get field value
            Console.WriteLine("PartialName : {0} ", textBoxField.PartialName);
            Console.WriteLine("Value : {0} ", textBoxField.Value);
            // ExEnd:GetValueFromField
        }
        public static void GetSubmitButtonURL()
        {
            // ExStart:GetSubmitButtonURL
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetValueFromField.pdf");
            SubmitFormAction act = pdfDocument.Form[1].OnActivated as SubmitFormAction;
            if(act != null)
            Console.WriteLine(act.Url.Name);
            // ExEnd:GetSubmitButtonURL
        }
    }
}