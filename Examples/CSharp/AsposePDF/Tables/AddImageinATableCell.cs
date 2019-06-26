using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class AddImageinATableCell
    {
        public static void Run()
        {
            // ExStart:AddImageinATableCell
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            // Instantiate a Document object
            Document pdfDocument = new Document();
            // Create a page in the pdf document
            Page sec1 = pdfDocument.Pages.Add();
            // Instantiate a table object
            Aspose.Pdf.Table tab1 = new Aspose.Pdf.Table();
            // Add the table in paragraphs collection of the desired page
            sec1.Paragraphs.Add(tab1);
            // Set default cell border using BorderInfo object
            tab1.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, 0.1F);
            // Set with column widths of the table
            tab1.ColumnWidths = "100 100 120";
            Aspose.Pdf.Image img = new Aspose.Pdf.Image();
            img.File = dataDir + "aspose.jpg";
            // Create rows in the table and then cells in the rows
            Aspose.Pdf.Row row1 = tab1.Rows.Add();
            row1.Cells.Add("Sample text in cell");
            // Add the cell which holds the image
            Aspose.Pdf.Cell cell2 = row1.Cells.Add();
            // Add the image to the table cell
            cell2.Paragraphs.Add(img);
            row1.Cells.Add("Previous cell with image");
            row1.Cells[2].VerticalAlignment = Aspose.Pdf.VerticalAlignment.Center;
            // Save the Document
            pdfDocument.Save(dataDir + "AddImageInTableCell_out.pdf");
            // ExEnd:AddImageinATableCell
        }
    }
}
