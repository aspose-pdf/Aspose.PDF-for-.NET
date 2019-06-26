using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class ReplaceableSymbolsInHeaderFooter
    {
        public static void Run()
        {
            // ExStart:ReplaceableSymbolsInHeaderFooter
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            Document doc = new Document();
            Page page = doc.Pages.Add();

            MarginInfo marginInfo = new MarginInfo();
            marginInfo.Top = 90;
            marginInfo.Bottom = 50;
            marginInfo.Left = 50;
            marginInfo.Right = 50;
            // Assign the marginInfo instance to Margin property of sec1.PageInfo
            page.PageInfo.Margin = marginInfo;

            HeaderFooter hfFirst = new HeaderFooter();
            page.Header = hfFirst;
            hfFirst.Margin.Left = 50;
            hfFirst.Margin.Right = 50;

            // Instantiate a Text paragraph that will store the content to show as header
            TextFragment t1 = new TextFragment("report title");
            t1.TextState.Font = FontRepository.FindFont("Arial");
            t1.TextState.FontSize = 16;
            t1.TextState.ForegroundColor = Aspose.Pdf.Color.Black;
            t1.TextState.FontStyle = FontStyles.Bold;
            t1.TextState.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            t1.TextState.LineSpacing = 5f;
            hfFirst.Paragraphs.Add(t1);

            TextFragment t2 = new TextFragment("Report_Name");
            t2.TextState.Font = FontRepository.FindFont("Arial");
            t2.TextState.ForegroundColor = Aspose.Pdf.Color.Black;
            t2.TextState.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            t2.TextState.LineSpacing = 5f;
            t2.TextState.FontSize = 12;
            hfFirst.Paragraphs.Add(t2);

            // Create a HeaderFooter object for the section
            HeaderFooter hfFoot = new HeaderFooter();
            // Set the HeaderFooter object to odd & even footer
            page.Footer = hfFoot;
            hfFoot.Margin.Left = 50;
            hfFoot.Margin.Right = 50;

            // Add a text paragraph containing current page number of total number of pages
            TextFragment t3 = new TextFragment("Generated on test date");
            TextFragment t4 = new TextFragment("report name ");
            TextFragment t5 = new TextFragment("Page $p of $P");

            // Instantiate a table object
            Table tab2 = new Table();

            // Add the table in paragraphs collection of the desired section
            hfFoot.Paragraphs.Add(tab2);

            // Set with column widths of the table
            tab2.ColumnWidths = "165 172 165";

            // Create rows in the table and then cells in the rows
            Row row3 = tab2.Rows.Add();

            row3.Cells.Add();
            row3.Cells.Add();
            row3.Cells.Add();

            // Set the vertical allignment of the text as center alligned
            row3.Cells[0].Alignment = Aspose.Pdf.HorizontalAlignment.Left;
            row3.Cells[1].Alignment = Aspose.Pdf.HorizontalAlignment.Center;
            row3.Cells[2].Alignment = Aspose.Pdf.HorizontalAlignment.Right;

            row3.Cells[0].Paragraphs.Add(t3);
            row3.Cells[1].Paragraphs.Add(t4);
            row3.Cells[2].Paragraphs.Add(t5);

            // Sec1.Paragraphs.Add(New Text("Aspose.Total for Java is a compilation of every Java component offered by Aspose. It is compiled on a#$NL" + "daily basis to ensure it contains the most up to date versions of each of our Java components. #$NL " + "Using Aspose.Total for Java developers can create a wide range of applications. #$NL #$NL #$NP" + "Aspose.Total for Java is a compilation of every Java component offered by Aspose. It is compiled on a#$NL" + "daily basis to ensure it contains the most up to date versions of each of our Java components. #$NL " + "Using Aspose.Total for Java developers can create a wide range of applications. #$NL #$NL #$NP" + "Aspose.Total for Java is a compilation of every Java component offered by Aspose. It is compiled on a#$NL" + "daily basis to ensure it contains the most up to date versions of each of our Java components. #$NL " + "Using Aspose.Total for Java developers can create a wide range of applications. #$NL #$NL"))
            Table table = new Table();

            table.ColumnWidths = "33% 33% 34%";
            table.DefaultCellPadding = new MarginInfo();
            table.DefaultCellPadding.Top = 10;
            table.DefaultCellPadding.Bottom = 10;

            // Add the table in paragraphs collection of the desired section
            page.Paragraphs.Add(table);

            // Set default cell border using BorderInfo object
            table.DefaultCellBorder = new BorderInfo(BorderSide.All, 0.1f);

            // Set table border using another customized BorderInfo object
            table.Border = new BorderInfo(BorderSide.All, 1f);

            table.RepeatingRowsCount = 1;

            // Create rows in the table and then cells in the rows
            Row row1 = table.Rows.Add();

            row1.Cells.Add("col1");
            row1.Cells.Add("col2");
            row1.Cells.Add("col3");
            const string CRLF = "\r\n";
            for (int i = 0; i <= 10; i++)
            {
                Row row = table.Rows.Add();
                row.IsRowBroken = true;
                for (int c = 0; c <= 2; c++)
                {
                    Cell c1;
                    if (c == 2)
                        c1 = row.Cells.Add("Aspose.Total for Java is a compilation of every Java component offered by Aspose. It is compiled on a" + CRLF + "daily basis to ensure it contains the most up to date versions of each of our Java components. " + CRLF + "daily basis to ensure it contains the most up to date versions of each of our Java components. " + CRLF + "Using Aspose.Total for Java developers can create a wide range of applications.");
                    else
                        c1 = row.Cells.Add("item1" + c);
                    c1.Margin = new MarginInfo();
                    c1.Margin.Left = 30;
                    c1.Margin.Top = 10;
                    c1.Margin.Bottom = 10;
                }
            }

            dataDir = dataDir + "ReplaceableSymbolsInHeaderFooter_out.pdf";
            doc.Save(dataDir);
            // ExEnd:ReplaceableSymbolsInHeaderFooter            
            Console.WriteLine("\nSymbols replaced successfully in header and footer.\nFile saved at " + dataDir);
        }
    }
}