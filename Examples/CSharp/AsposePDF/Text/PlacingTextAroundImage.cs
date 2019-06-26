using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class PlacingTextAroundImage
    {
        public static void Run()
        {
            // ExStart:PlacingTextAroundImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Instantiate document object 
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document();
            // Create a page in the Pdf 
            Aspose.Pdf.Page page = doc.Pages.Add();

            // Instantiate a table object 
            Aspose.Pdf.Table table1 = new Aspose.Pdf.Table();
            // Add the table in paragraphs collection of the desired section 
            page.Paragraphs.Add(table1);
            // Set with column widths of the table 
            table1.ColumnWidths = "120 270";

            // Create MarginInfo object and set its left, bottom, right and top margins 
            Aspose.Pdf.MarginInfo margin = new Aspose.Pdf.MarginInfo();
            margin.Top = 5f;
            margin.Left = 5f;
            margin.Right = 5f;
            margin.Bottom = 5f;
            // Set the default cell padding to the MarginInfo object 
            table1.DefaultCellPadding = margin;

            // Create rows in the table and then cells in the rows 
            Aspose.Pdf.Row row1 = table1.Rows.Add();

            // Create an image object
            Aspose.Pdf.Image logo = new Aspose.Pdf.Image();
            // Specify the image file path
            logo.File = dataDir + "aspose-logo.jpg";
            // Specify the image Fixed Height
            logo.FixHeight = 120;
            // Specify the image Fixed Width
            logo.FixWidth = 110;
            row1.Cells.Add();
            // Add the image to paragraphs collection of the table cell
            row1.Cells[0].Paragraphs.Add(logo);

            // Create string variables with text containing html tags 
            string TitleString = "<font face=\"Arial\" size=6 color=\"#101090\"><b> Aspose.Pdf for .NET</b></font>";

            string BodyString1 = "<font face=\"Arial\" size=2><br/>Aspose.Pdf for .NET is a non-graphical PDF� document reporting component that enables .NET applications to <b> create PDF documents from scratch </b> without utilizing Adobe Acrobat�. Aspose.Pdf for .NET is very affordably priced and offers a wealth of strong features including: compression, tables, graphs, images, hyperlinks, security and custom fonts. </font>";

            // Create a text object to be added to the right of image
            Aspose.Pdf.HtmlFragment TitleText = new Aspose.Pdf.HtmlFragment(TitleString + BodyString1);
            row1.Cells.Add();
            // Add the text paragraphs containing HTML text to the table cell
            row1.Cells[1].Paragraphs.Add(TitleText);
            // Set the vertical alignment of the row contents as Top
            row1.Cells[1].VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;

            // Create rows in the table and then cells in the rows
            Aspose.Pdf.Row SecondRow = table1.Rows.Add();
            SecondRow.Cells.Add();
            // Set the row span value for Second row as 2
            SecondRow.Cells[0].ColSpan = 2;
            // Set the vertical alignment of the second row as Top
            SecondRow.Cells[0].VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;

            string SecondRowString = "<font face=\"Arial\" size=2>Aspose.Pdf for .NET supports the creation of PDF files through API and XML or XSL-FO templates. Aspose.Pdf for .NET is very easy to use and is provided with 14 fully featured demos written in both C# and Visual Basic.</font>";
            Aspose.Pdf.HtmlFragment SecondRowText = new Aspose.Pdf.HtmlFragment(SecondRowString);
            // Add the text paragraphs containing HTML text to the table cell
            SecondRow.Cells[0].Paragraphs.Add(SecondRowText);
            // Save the Pdf file
            doc.Save(dataDir + "PlacingTextAroundImage_out.pdf");
            // ExEnd:PlacingTextAroundImage
        }
    }
}
