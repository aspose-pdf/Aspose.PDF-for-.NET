using System.IO;
using Aspose.Pdf;
using System.Data;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class IntegrateWithDatabase
    {
        public static void Run()
        {
            // ExStart:IntegrateWithDatabase
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            DataTable dt = new DataTable("Employee");
            dt.Columns.Add("Employee_ID", typeof(Int32));
            dt.Columns.Add("Employee_Name", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            // Add 2 rows into the DataTable object programmatically
            DataRow dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "John Smith";
            dr[2] = "Male";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "Mary Miller";
            dr[2] = "Female";
            dt.Rows.Add(dr);
            // Create Document instance
            Document doc = new Document();
            doc.Pages.Add();
            // Initializes a new instance of the Table
            Aspose.Pdf.Table table = new Aspose.Pdf.Table();
            // Set column widths of the table
            table.ColumnWidths = "40 100 100 100";
            // Set the table border color as LightGray
            table.Border = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));
            // Set the border for table cells
            table.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));
            table.ImportDataTable(dt, true, 0, 1, 3, 3);

            // Add table object to first page of input document
            doc.Pages[1].Paragraphs.Add(table);
            dataDir = dataDir + "DataIntegrated_out.pdf";
            // Save updated document containing table object
            doc.Save(dataDir);
            // ExEnd:IntegrateWithDatabase
            Console.WriteLine("\nDatabase integrated successfully.\nFile saved at " + dataDir); 
        }
    }
}