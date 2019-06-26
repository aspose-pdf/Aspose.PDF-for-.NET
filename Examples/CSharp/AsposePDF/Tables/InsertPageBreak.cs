using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class InsertPageBreak
    {
        public static void Run()
        {
            // ExStart:InsertPageBreak
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            // Instantiate Document instance
            Document doc = new Document();
            // Add page to pages collection of PDF file
            doc.Pages.Add();
            // Create table instance
            Aspose.Pdf.Table tab = new Aspose.Pdf.Table();
            // Set border style for table
            tab.Border = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, Aspose.Pdf.Color.Red);
            // Set default border style for table with border color as Red
            tab.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, Aspose.Pdf.Color.Red);
            // Specify table columsn widht
            tab.ColumnWidths = "100 100";
            // Create a loop to add 200 rows for table
            for (int counter = 0; counter <= 200; counter++)
            {
                Aspose.Pdf.Row row = new Aspose.Pdf.Row();
                tab.Rows.Add(row);
                Aspose.Pdf.Cell cell1 = new Aspose.Pdf.Cell();
                cell1.Paragraphs.Add(new TextFragment("Cell " + counter + ", 0"));
                row.Cells.Add(cell1); Aspose.Pdf.Cell cell2 = new Aspose.Pdf.Cell();
                cell2.Paragraphs.Add(new TextFragment("Cell " + counter + ", 1"));
                row.Cells.Add(cell2);
                // When 10 rows are added, render new row in new page
                if (counter % 10 == 0 && counter != 0) row.IsInNewPage = true;
            }
            // Add table to paragraphs collection of PDF file
            doc.Pages[1].Paragraphs.Add(tab);

            dataDir = dataDir + "InsertPageBreak_out.pdf";
            // Save the PDF document
            doc.Save(dataDir);
            // ExEnd:InsertPageBreak
            Console.WriteLine("\nPage break inserted successfully.\nFile saved at " + dataDir);
            
        }
    }
}