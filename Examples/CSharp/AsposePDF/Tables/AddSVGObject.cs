using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class AddSVGObject
    {
        public static void Run()
        {
            // ExStart:AddSVGObject
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            // Instantiate Document object
            Document doc = new Document();
            // Create an image instance
            Aspose.Pdf.Image img = new Aspose.Pdf.Image();
            // Set image type as SVG
            img.FileType = Aspose.Pdf.ImageFileType.Svg;
            // Path for source file
            img.File = dataDir + "SVGToPDF.svg";
            // Set width for image instance
            img.FixWidth = 50;
            // Set height for image instance
            img.FixHeight = 50;
            // Create table instance
            Aspose.Pdf.Table table = new Aspose.Pdf.Table();
            // Set width for table cells
            table.ColumnWidths = "100 100";
            // Create row object and add it to table instance
            Aspose.Pdf.Row row = table.Rows.Add();
            // Create cell object and add it to row instance
            Aspose.Pdf.Cell cell = row.Cells.Add();
            // Add textfragment to paragraphs collection of cell object
            cell.Paragraphs.Add(new TextFragment("First cell"));
            // Add another cell to row object
            cell = row.Cells.Add();
            // Add SVG image to paragraphs collection of recently added cell instance
            cell.Paragraphs.Add(img);
            // Create page object and add it to pages collection of document instance
            Page page = doc.Pages.Add();
            // Add table to paragraphs collection of page object
            page.Paragraphs.Add(table);

            dataDir = dataDir + "AddSVGObject_out.pdf";
            // Save PDF file
            doc.Save(dataDir);
            // ExEnd:AddSVGObject
            Console.WriteLine("\nSVG image added successfully inside a table cell.\nFile saved at " + dataDir);            
        }
    }
}