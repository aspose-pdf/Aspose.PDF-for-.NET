
namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class AddRepeatingColumn
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            string outFile = dataDir + "AddRepeatingColumn_out.pdf";
            // Create a new document
            Document doc = new Document();
            Aspose.Pdf.Page page = doc.Pages.Add();

            // Instantiate an outer table that takes up the entire page
            Aspose.Pdf.Table outerTable = new Aspose.Pdf.Table();
            outerTable.ColumnWidths = "100%";
            outerTable.HorizontalAlignment = HorizontalAlignment.Left;

            // Instantiate a table object that will be nested inside outerTable that will break inside the same page
            Aspose.Pdf.Table mytable = new Aspose.Pdf.Table();
            mytable.Broken = TableBroken.VerticalInSamePage;
            mytable.ColumnAdjustment = ColumnAdjustment.AutoFitToContent;

            // Add the outerTable to the page paragraphs
            // Add mytable to outerTable
            page.Paragraphs.Add(outerTable);
            var bodyRow = outerTable.Rows.Add();
            var bodyCell = bodyRow.Cells.Add();
            bodyCell.Paragraphs.Add(mytable);
            mytable.RepeatingColumnsCount = 5;
            page.Paragraphs.Add(mytable);

            // Add header Row
            Aspose.Pdf.Row row = mytable.Rows.Add();
            row.Cells.Add("header 1");
            row.Cells.Add("header 2");
            row.Cells.Add("header 3");
            row.Cells.Add("header 4");
            row.Cells.Add("header 5");
            row.Cells.Add("header 6");
            row.Cells.Add("header 7");
            row.Cells.Add("header 11");
            row.Cells.Add("header 12");
            row.Cells.Add("header 13");
            row.Cells.Add("header 14");
            row.Cells.Add("header 15");
            row.Cells.Add("header 16");
            row.Cells.Add("header 17");

            for (int RowCounter = 0; RowCounter <= 5; RowCounter++)

            {
                // Create rows in the table and then cells in the rows 
                Aspose.Pdf.Row row1 = mytable.Rows.Add();
                row1.Cells.Add("col " + RowCounter.ToString() + ", 1");
                row1.Cells.Add("col " + RowCounter.ToString() + ", 2");
                row1.Cells.Add("col " + RowCounter.ToString() + ", 3");
                row1.Cells.Add("col " + RowCounter.ToString() + ", 4");
                row1.Cells.Add("col " + RowCounter.ToString() + ", 5");
                row1.Cells.Add("col " + RowCounter.ToString() + ", 6");
                row1.Cells.Add("col " + RowCounter.ToString() + ", 7");
                row1.Cells.Add("col " + RowCounter.ToString() + ", 11");
                row1.Cells.Add("col " + RowCounter.ToString() + ", 12");
                row1.Cells.Add("col " + RowCounter.ToString() + ", 13");
                row1.Cells.Add("col " + RowCounter.ToString() + ", 14");
                row1.Cells.Add("col " + RowCounter.ToString() + ", 15");
                row1.Cells.Add("col " + RowCounter.ToString() + ", 16");
                row1.Cells.Add("col " + RowCounter.ToString() + ", 17");
            }
            doc.Save(outFile);
            // ExEnd:1
        }
    }
}
