using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class RenderTable
    {
        public static void Run()
        {
            // ExStart:RenderTable
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            Document doc = new Document();
            PageInfo pageInfo = doc.PageInfo;
            Aspose.Pdf.MarginInfo marginInfo = pageInfo.Margin;

            marginInfo.Left = 37;
            marginInfo.Right = 37;
            marginInfo.Top = 37;
            marginInfo.Bottom = 37;

            pageInfo.IsLandscape = true;

            Aspose.Pdf.Table table = new Aspose.Pdf.Table();
            table.ColumnWidths = "50 100";
            // Added page.
            Page curPage = doc.Pages.Add();
            for (int i = 1; i <= 120; i++)
            {
                Aspose.Pdf.Row row = table.Rows.Add();
                row.FixedRowHeight = 15;
                Aspose.Pdf.Cell cell1 = row.Cells.Add();
                cell1.Paragraphs.Add(new TextFragment("Content 1"));
                Aspose.Pdf.Cell cell2 = row.Cells.Add();
                cell2.Paragraphs.Add(new TextFragment("HHHHH"));
            }
            Aspose.Pdf.Paragraphs paragraphs = curPage.Paragraphs;
            paragraphs.Add(table);
            /********************************************/
            Aspose.Pdf.Table table1 = new Aspose.Pdf.Table();
            table.ColumnWidths = "100 100";
            for (int i = 1; i <= 10; i++)
            {
                Aspose.Pdf.Row row = table1.Rows.Add();
                Aspose.Pdf.Cell cell1 = row.Cells.Add();
                cell1.Paragraphs.Add(new TextFragment("LAAAAAAA"));
                Aspose.Pdf.Cell cell2 = row.Cells.Add();
                cell2.Paragraphs.Add(new TextFragment("LAAGGGGGG"));
            }
            table1.IsInNewPage = true;
            // I want to keep table 1 to next page please...
            paragraphs.Add(table1);
            dataDir = dataDir + "IsNewPageProperty_Test_out.pdf";
            doc.Save(dataDir);
            // ExEnd:RenderTable
            Console.WriteLine("\nTable render successfully on a page.\nFile saved at " + dataDir); 
            
            
        }
    }
}