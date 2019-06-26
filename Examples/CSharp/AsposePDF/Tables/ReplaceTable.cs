using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class ReplaceTable
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            // Load existing PDF document
            Document pdfDocument = new Document(dataDir + @"Table_input.pdf");

            // Create TableAbsorber object to find tables
            TableAbsorber absorber = new TableAbsorber();

            // Visit first page with absorber
            absorber.Visit(pdfDocument.Pages[1]);

            // Get first table on the page
            AbsorbedTable table = absorber.TableList[0];

            // Create new table
            Table newTable = new Table();
            newTable.ColumnWidths = "100 100 100";
            newTable.DefaultCellBorder = new BorderInfo(BorderSide.All, 1F);

            Row row = newTable.Rows.Add();
            row.Cells.Add("Col 1");
            row.Cells.Add("Col 2");
            row.Cells.Add("Col 3");

            // Replace the table with new one
            absorber.Replace(pdfDocument.Pages[1], table, newTable);

            // Save document
            pdfDocument.Save(dataDir + "TableReplaced_out.pdf");
            // ExEnd:1
        }
    }
}
