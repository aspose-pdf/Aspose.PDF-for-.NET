using System;
using System.IO;
using Aspose.Pdf.Annotations;
using Aspose.Pdf;
using Aspose.Pdf.Forms;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class CreateDoc
    {
        public static void Run()
        {
            try
            {
                // ExStart:CreateDoc
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

                // Create a new document
                Document doc = new Document();
                Page page = doc.Pages.Add();
                // Add radio button field
                RadioButtonField field = new RadioButtonField(page);
                field.Rect = new Aspose.Pdf.Rectangle(40, 650, 100, 720);
                field.PartialName = "NewField";

                // Add radio button options. please note that these options are situated 
                // Neither horizontally nor vertically. 
                // You can try to set any coordinates (and even size) for them. 
                RadioButtonOptionField opt1 = new RadioButtonOptionField();
                opt1.Rect = new Aspose.Pdf.Rectangle(40, 650, 60, 670);
                opt1.OptionName = "Item1";
                opt1.Border = new Border(opt1);
                opt1.Border.Width = 1;
                opt1.Characteristics.Border = System.Drawing.Color.Black;

                RadioButtonOptionField opt2 = new RadioButtonOptionField();
                opt2.Rect = new Aspose.Pdf.Rectangle(60, 670, 80, 690);
                opt2.OptionName = "Item2";
                opt2.Border = new Border(opt2);
                opt2.Border.Width = 1;
                opt2.Characteristics.Border = System.Drawing.Color.Black;

                RadioButtonOptionField opt3 = new RadioButtonOptionField();
                opt3.Rect = new Aspose.Pdf.Rectangle(80, 690, 100, 710);
                opt3.OptionName = "Item3";
                opt3.Border = new Border(opt3);
                opt3.Border.Width = 1;
                opt3.Characteristics.Border = System.Drawing.Color.Black;
                field.Add(opt1);
                field.Add(opt2);
                field.Add(opt3);
                doc.Form.Add(field);

                dataDir = dataDir + "CreateDoc_out.pdf";
                // Save the PDF document
                doc.Save(dataDir);
                // ExEnd:CreateDoc
                Console.WriteLine("\nNew doc with 3 items radio button created successfully.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}