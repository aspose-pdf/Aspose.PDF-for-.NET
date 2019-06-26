using System;
using System.IO;
using Aspose.Pdf.Forms;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class RadioButtonWithOptions
    {
        public static void Run()
        {
            try
            {
                // ExStart:RadioButtonWithOptions
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

                Document doc = new Document();
                Page page = doc.Pages.Add();
                Aspose.Pdf.Table table = new Aspose.Pdf.Table();
                table.ColumnWidths = "120 120 120";
                page.Paragraphs.Add(table);
                Row r1 = table.Rows.Add();
                Cell c1 = r1.Cells.Add();
                Cell c2 = r1.Cells.Add();
                Cell c3 = r1.Cells.Add();

                RadioButtonField rf = new RadioButtonField(page);
                rf.PartialName = "radio";
                doc.Form.Add(rf, 1);

                RadioButtonOptionField opt1 = new RadioButtonOptionField();
                RadioButtonOptionField opt2 = new RadioButtonOptionField();
                RadioButtonOptionField opt3 = new RadioButtonOptionField();

                opt1.OptionName = "Item1";
                opt2.OptionName = "Item2";
                opt3.OptionName = "Item3";

                opt1.Width = 15;
                opt1.Height = 15;
                opt2.Width = 15;
                opt2.Height = 15;
                opt3.Width = 15;
                opt3.Height = 15;

                rf.Add(opt1);
                rf.Add(opt2);
                rf.Add(opt3);

                opt1.Border = new Border(opt1);
                opt1.Border.Width = 1;
                opt1.Border.Style = BorderStyle.Solid;
                opt1.Characteristics.Border = System.Drawing.Color.Black;
                opt1.DefaultAppearance.TextColor = System.Drawing.Color.Red;
                opt1.Caption = new TextFragment("Item1");
                opt2.Border = new Border(opt1);
                opt2.Border.Width = 1;
                opt2.Border.Style = BorderStyle.Solid;
                opt2.Characteristics.Border = System.Drawing.Color.Black;
                opt2.DefaultAppearance.TextColor = System.Drawing.Color.Red;
                opt2.Caption = new TextFragment("Item2");
                opt3.Border = new Border(opt1);
                opt3.Border.Width = 1;
                opt3.Border.Style = BorderStyle.Solid;
                opt3.Characteristics.Border = System.Drawing.Color.Black;
                opt3.DefaultAppearance.TextColor = System.Drawing.Color.Red;
                opt3.Caption = new TextFragment("Item3");
                c1.Paragraphs.Add(opt1);
                c2.Paragraphs.Add(opt2);
                c3.Paragraphs.Add(opt3);

                dataDir = dataDir + "RadioButtonWithOptions_out.pdf";
                // Save the PDF file
                doc.Save(dataDir);
                // ExEnd:RadioButtonWithOptions
                Console.WriteLine("\nRadio button field with three options added successfully.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}