using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Forms;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class SetFieldLimit
    {
        public static void Run()
        {
            // ExStart:SetFieldLimit
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Adding Field with limit
            FormEditor form = new FormEditor();

            form.BindPdf( dataDir + "input.pdf");
            form.SetFieldLimit("textbox1", 15);
            dataDir = dataDir + "SetFieldLimit_out.pdf";
            form.Save(dataDir);
            // ExEnd:SetFieldLimit
            Console.WriteLine("\nField added successfully with limit.\nFile saved at " + dataDir);
        }
        public static void GetMaxFieldLimit()
        {
            // ExStart:GetMaxFieldLimit
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();
            // Getting maximum field limit using DOM
            Document doc = new Document(dataDir + "FieldLimit.pdf");
            Console.WriteLine("Limit: " + (doc.Form["textbox1"] as TextBoxField).MaxLen);
            // ExEnd:GetMaxFieldLimit
        }
        public static void GetMaxFieldLimitUsingFacades()
        {
            // ExStart:GetMaxFieldLimitUsingFacades
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();
            // Getting maximum field limit using Facades
            Aspose.Pdf.Facades.Form form = new Aspose.Pdf.Facades.Form();
            form.BindPdf(dataDir + "FieldLimit.pdf");
            Console.WriteLine("Limit: " + form.GetFieldLimit("textbox1"));
            // ExEnd:GetMaxFieldLimitUsingFacades
        }
    }
}