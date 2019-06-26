using System;
using System.IO;
using Aspose.Pdf.Facades;
using Aspose.Pdf;
using Aspose.Pdf.Forms;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class HorizontallyAndVerticallyRadioButtons
    {
        public static void Run()
        {
            try
            {
                // ExStart:HorizontallyAndVerticallyRadioButtons
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

                // Load the previously saved document
                FormEditor formEditor = new FormEditor();
                formEditor.BindPdf(dataDir + "input.pdf");
                // RadioGap is distance between two radio button options. 
                formEditor.RadioGap = 4;
                // Add horizontal radio button
                formEditor.RadioHoriz = true;
                // RadioButtonItemSize if size of radio button item.
                formEditor.RadioButtonItemSize = 20;
                formEditor.Facade.BorderWidth = 1;
                formEditor.Facade.BorderColor = System.Drawing.Color.Black;
                formEditor.Items = new string[] { "First", "Second", "Third" };
                formEditor.AddField(FieldType.Radio, "NewField1", 1, 40, 600, 120, 620);

                // Add other radio button situated vertically
                formEditor.RadioHoriz = false;
                formEditor.Items = new string[] { "First", "Second", "Third" };
                formEditor.AddField(FieldType.Radio, "NewField2", 1, 40, 500, 60, 550);


                dataDir = dataDir + "HorizontallyAndVerticallyRadioButtons_out.pdf";
                // Save the PDF document
                formEditor.Save(dataDir);
                // ExEnd:HorizontallyAndVerticallyRadioButtons
                Console.WriteLine("\nHorizontally and vertically laid out radio buttons successfully.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}