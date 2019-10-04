using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class TextAlignmentForTableRowContent
    {
        public static void Run()
        {
            //ExStart: TextAlignmentForTableRowContent
            var dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            // Create PDF document
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document();
            // Initializes a new instance of the Table
            Aspose.Pdf.Table table = new Aspose.Pdf.Table();
            // Set the table border color as LightGray
            table.Border = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));
            // set the border for table cells
            table.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));
            // create a loop to add 10 rows
            for (int row_count = 0; row_count < 10; row_count++)
            {
                // add row to table
                Aspose.Pdf.Row row = table.Rows.Add();
                row.VerticalAlignment = VerticalAlignment.Center;

                row.Cells.Add("Column (" + row_count + ", 1)" + DateTime.Now.Ticks);
                row.Cells.Add("Column (" + row_count + ", 2)");
                row.Cells.Add("Column (" + row_count + ", 3)");
            }
            Page tocPage = doc.Pages.Add();
            // Add table object to first page of input document
            tocPage.Paragraphs.Add(table);
            // Save updated document containing table object
            doc.Save(dataDir + "43620_ByWords_out.pdf");
            //ExEnd: TextAlignmentForTableRowContent
        }
    }
}
