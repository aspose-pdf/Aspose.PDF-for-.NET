using System.Data;
using System.IO;
using System.Linq;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class ExportExcelWorksheetDataToTable
    {
        public static void Run()
        {
            // ExStart:ExportExcelWorksheetDataToTable
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(new FileStream(dataDir + "newBook1.xlsx", FileMode.Open));
            // Accessing the first worksheet in the Excel file
            Aspose.Cells.Worksheet worksheet = workbook.Worksheets[0];
            // Exporting the contents of 7 rows and 2 columns starting from 1st cell to DataTable
            DataTable dataTable = worksheet.Cells.ExportDataTable(0, 0, worksheet.Cells.MaxRow + 1, worksheet.Cells.MaxColumn + 1, true);

            // Instantiate a Document instanc
            Aspose.Pdf.Document pdf1 = new Aspose.Pdf.Document();
            // Create a page in the document instance
            Aspose.Pdf.Page sec1 = pdf1.Pages.Add();

            // Create a Table object
            Aspose.Pdf.Table tab1 = new Aspose.Pdf.Table();

            // Add the Table object in the paragraphs collection of the section
            sec1.Paragraphs.Add(tab1);

            // Set column widths of the table.  We need to specify the ColumnCount manually.
            // As the curent excel worksheet has three columsn, so we are specifying the same count
            tab1.ColumnWidths = "40 100 100";

            // Set default cell border of the table using BorderInfo object
            tab1.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, 0.1F);

            // Import data into the Table object from the DataTable created above
            tab1.ImportDataTable(dataTable, true, 0, 0, dataTable.Rows.Count + 1, dataTable.Columns.Count);
            // Get 1st row from the table
            Aspose.Pdf.Row row1 = tab1.Rows[0];

            // Iterate through all cells in the 1st row and set their background color to blue
            foreach (Aspose.Pdf.Cell curCell in row1.Cells)
            {
                // Set the background of all the cells in 1st row of the table.
                curCell.BackgroundColor = Color.Blue;
                // Set the font face for the cells of 1st row in the table.
                curCell.DefaultCellTextState.Font = Aspose.Pdf.Text.FontRepository.FindFont("Helvetica-Oblique");
                // Set the font Color of all the cells in 1st row of the table.
                curCell.DefaultCellTextState.ForegroundColor = Color.Yellow;
                // Set the text allignment for the cells of 1st row as Center.
                curCell.DefaultCellTextState.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            }

            for (int All_Rows = 1; All_Rows <= dataTable.Rows.Count; All_Rows++)
            {
                // Iterate through all cells in the 1st row and set their background color to blue
                foreach (Aspose.Pdf.Cell curCell in tab1.Rows[All_Rows].Cells)
                {
                    // Set the background color of all the cells except of the 1st row.
                    curCell.BackgroundColor = Color.Gray;
                    // Set the Text color of all the cells except the 1st row.
                    curCell.DefaultCellTextState.ForegroundColor = Color.White;
                }
            }

            // Save the Pdf
            pdf1.Save(dataDir + @"Exceldata_toPdf_table.pdf");
            // ExEnd:ExportExcelWorksheetDataToTable
        }
    }
}
