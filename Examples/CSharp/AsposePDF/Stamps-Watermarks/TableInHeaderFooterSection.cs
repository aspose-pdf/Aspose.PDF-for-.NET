using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class TableInHeaderFooterSection
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Instantiate Document instance by calling empty constructor
            Aspose.Pdf.Document pdfDocument = new Aspose.Pdf.Document();
            // Create a page in the pdf document
            Aspose.Pdf.Page page = pdfDocument.Pages.Add();

            // Create a Header Section of the PDF file
            Aspose.Pdf.HeaderFooter header = new Aspose.Pdf.HeaderFooter();
            // Set the Odd Header for the PDF file
            page.Header = header;
            // Set the top margin for the header section
            header.Margin.Top = 20;

            // Instantiate a table object
            Aspose.Pdf.Table tab1 = new Aspose.Pdf.Table();
            // Add the table in paragraphs collection of the desired section
            header.Paragraphs.Add(tab1);
            // Set default cell border using BorderInfo object
            tab1.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, 0.1F);
            // Set with column widths of the table
            tab1.ColumnWidths = "60 300";

            Aspose.Pdf.Image img = new Aspose.Pdf.Image();
            img.File = dataDir + "aspose-logo.jpg";

            // Create rows in the table and then cells in the rows
            Aspose.Pdf.Row row1 = tab1.Rows.Add();

            row1.Cells.Add("Table in Header Section");
            row1.BackgroundColor = Color.Gray;
            // Set the row span value for first row as 2
            tab1.Rows[0].Cells[0].ColSpan = 2;
            tab1.Rows[0].Cells[0].DefaultCellTextState.ForegroundColor = Color.Cyan;
            tab1.Rows[0].Cells[0].DefaultCellTextState.Font = FontRepository.FindFont("Helvetica");
            // Create rows in the table and then cells in the rows
            Aspose.Pdf.Row row2 = tab1.Rows.Add();
            // Set the background color for Row2
            row2.BackgroundColor = Color.White;
            // Add the cell which holds the image
            Aspose.Pdf.Cell cell2 = row2.Cells.Add();
            // Set the image width to 60
            img.FixWidth = 60;

            // Add the image to the table cell
            cell2.Paragraphs.Add(img);
            row2.Cells.Add("Logo is looking fine !");
            row2.Cells[1].DefaultCellTextState.Font = FontRepository.FindFont("Helvetica");
            // Set the vertical allignment of the text as center alligned
            row2.Cells[1].VerticalAlignment = Aspose.Pdf.VerticalAlignment.Center;
            row2.Cells[1].Alignment = Aspose.Pdf.HorizontalAlignment.Center;

            // Save the Pdf file
            pdfDocument.Save(dataDir + "TableInHeaderFooterSection_out.pdf");
            // ExEnd:1
        }
    }
}
