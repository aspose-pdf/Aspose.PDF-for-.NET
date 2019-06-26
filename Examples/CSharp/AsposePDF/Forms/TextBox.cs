using System.IO;
using System;
using Aspose.Pdf.Forms;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class TextBox
    {
        public static void Run()
        {
            // ExStart:AddTextBoxField
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Open document
            Document pdfDocument = new Document(dataDir + "TextField.pdf");

            // Create a field
            TextBoxField textBoxField = new TextBoxField(pdfDocument.Pages[1], new Aspose.Pdf.Rectangle(100, 200, 300, 300));
            textBoxField.PartialName = "textbox1";
            textBoxField.Value = "Text Box";

            // TextBoxField.Border = new Border(
            Border border = new Border(textBoxField);
            border.Width = 5;
            border.Dash = new Dash(1, 1);
            textBoxField.Border = border;

            textBoxField.Color = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Green);

            // Add field to the document
            pdfDocument.Form.Add(textBoxField, 1);

            dataDir = dataDir + "TextBox_out.pdf";
            // Save modified PDF
            pdfDocument.Save(dataDir);
            // ExEnd:AddTextBoxField
            Console.WriteLine("\nTextbox field added successfully.\nFile saved at " + dataDir);

        }
    }
}