using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Forms;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class GroupedCheckBoxes
    {
        public static void Run()
        {
            try
            {
                // ExStart:GroupedCheckBoxes
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

                // Instantiate Document object
                Document pdfDocument = new Document();
                // Add a page to PDF file
                Page page = pdfDocument.Pages.Add();
                // Instatiate RadioButtonField object with page number as argument
                RadioButtonField radio = new RadioButtonField(pdfDocument.Pages[1]);
                // Add first radio button option and also specify its origin using Rectangle object
                RadioButtonOptionField opt1 = new RadioButtonOptionField(page, new Aspose.Pdf.Rectangle(0, 0, 20, 20));
                RadioButtonOptionField opt2 = new RadioButtonOptionField(page, new Aspose.Pdf.Rectangle(100, 0, 120, 20));
                opt1.OptionName = "Test1";
                opt2.OptionName = "Test2";

                radio.Add(opt1);
                radio.Add(opt2);
                opt1.Style = BoxStyle.Square;
                opt2.Style = BoxStyle.Square;
                opt1.Style = BoxStyle.Cross;
                opt2.Style = BoxStyle.Cross;
                opt1.Border = new Border(opt1);
                opt1.Border.Style = BorderStyle.Solid;
                opt1.Border.Width = 1;
                opt1.Characteristics.Border = System.Drawing.Color.Black;
                opt2.Border = new Border(opt2);
                opt2.Border.Width = 1;

                opt2.Border.Style = BorderStyle.Solid;
                opt2.Characteristics.Border = System.Drawing.Color.Black;
                
                // Add radio button to form object of Document object
                pdfDocument.Form.Add(radio);

                dataDir = dataDir + "GroupedCheckBoxes_out.pdf";
                // Save the PDF document
                pdfDocument.Save(dataDir);
                // ExEnd:GroupedCheckBoxes
                Console.WriteLine("\nGrouped checkboxes added successfully.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}