using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class AddTable
    {
        public static void Run()
        {
            // ExStart:AddTable
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            // Load source PDF document
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir+ "AddTable.pdf");
            // Initializes a new instance of the Table
            Aspose.Pdf.Table table = new Aspose.Pdf.Table();
            // Set the table border color as LightGray
            table.Border = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));
            // Set the border for table cells
            table.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));
            // Create a loop to add 10 rows
            for (int row_count = 1; row_count < 10; row_count++)
            {
                // Add row to table
                Aspose.Pdf.Row row = table.Rows.Add();
                // Add table cells
                row.Cells.Add("Column (" + row_count + ", 1)");
                row.Cells.Add("Column (" + row_count + ", 2)");
                row.Cells.Add("Column (" + row_count + ", 3)");
            }
            // Add table object to first page of input document
            doc.Pages[1].Paragraphs.Add(table);
            dataDir = dataDir + "document_with_table_out.pdf";
            // Save updated document containing table object
            doc.Save(dataDir);
            // ExEnd:AddTable
            Console.WriteLine("\nText added successfully to an existing pdf file.\nFile saved at " + dataDir);            
        }
    }
}