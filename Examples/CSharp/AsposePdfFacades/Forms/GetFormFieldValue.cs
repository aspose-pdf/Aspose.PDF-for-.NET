using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class GetFormFieldValue
    {
        public static void Run()
        {
            // ExStart:GetFormFieldValue
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            // Create Form Object
            Aspose.Pdf.Facades.Form pdfForm = new Aspose.Pdf.Facades.Form();

            // Open Document
            pdfForm.BindPdf(dataDir + "FormField.pdf");

            // Get form field facade
            FormFieldFacade fieldFacade = pdfForm.GetFieldFacade("textfield");

            // Get facade values
            Console.WriteLine("Alignment : {0} ", fieldFacade.Alignment);
            Console.WriteLine("Background Color : {0} ", fieldFacade.BackgroundColor);
            Console.WriteLine("Border Color : {0} ", fieldFacade.BorderColor);
            Console.WriteLine("Border Style : {0} ", fieldFacade.BorderStyle);
            Console.WriteLine("Border Width : {0} ", fieldFacade.BorderWidth);
            Console.WriteLine("Box : {0} ", fieldFacade.Box);
            Console.WriteLine("Caption : {0} ", fieldFacade.Caption);
            Console.WriteLine("Font Name : {0} ", fieldFacade.Font);
            Console.WriteLine("Font Size : {0} ", fieldFacade.FontSize);
            Console.WriteLine("Page Number : {0} ", fieldFacade.PageNumber);
            Console.WriteLine("Text Color : {0} ", fieldFacade.TextColor);
            Console.WriteLine("Text Encoding : {0} ", fieldFacade.TextEncoding);
            // ExEnd:GetFormFieldValue
        }
    }
}