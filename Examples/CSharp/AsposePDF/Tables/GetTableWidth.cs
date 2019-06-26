using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class GetTableWidth
    {
        public static void Run()
        {
            // ExStart:GetTableWidth
            // Create a new document
            Document doc = new Document();
            // Add page in document
            Page page = doc.Pages.Add();
            // Initialize new table
            Table table = new Table
            {
                ColumnAdjustment = ColumnAdjustment.AutoFitToContent
            };
            // Add row in table 
            Row row = table.Rows.Add();
            // Add cell in table
            Cell cell = row.Cells.Add("Cell 1 text");
            cell = row.Cells.Add("Cell 2 text");
            // Get table width
            Console.WriteLine(table.GetWidth());
            // ExEnd:GetTableWidth
            System.Console.WriteLine("Extracted table width succesfully!");
        }
    }
}
