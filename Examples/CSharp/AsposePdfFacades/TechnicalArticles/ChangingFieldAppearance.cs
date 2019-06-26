using System.IO;
using System;
using System.Collections;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class ChangingFieldAppearance
    {
        public static void Run()
        {
            // ExStart:ChangingFieldAppearance
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            Document doc = new Document(dataDir + "FilledForm.pdf");
            // Open the document and create a Form object
            FormEditor formEditor = new FormEditor(doc);
            // Add a text field
            formEditor.AddField(FieldType.Text, "text1", 1, 200, 550, 300, 575);
           
            // Set field attribute - PropertyFlag enumeration contains 4 options
            formEditor.SetFieldAttribute("text1", PropertyFlag.Required);
            // Set field limit - this field will take maximum 20 characters as input
            formEditor.SetFieldLimit("text1", 20);

            // Close the document
            formEditor.Save(dataDir + "ChangingFieldAppearance_out.pdf");
            // ExEnd:ChangingFieldAppearance                      
        }
    }
}