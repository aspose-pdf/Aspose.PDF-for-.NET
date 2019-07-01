using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class StyleTableElement
    {
        /// <summary>
        /// This feature is supported by version 19.6 or greater
        /// </summary>
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            // Create document
            Document document = new Document();
            ITaggedContent taggedContent = document.TaggedContent;

            taggedContent.SetTitle("Example table style");
            taggedContent.SetLanguage("en-US");

            // Get root structure element
            StructureElement rootElement = taggedContent.RootElement;


            // Create table structure element
            TableElement tableElement = taggedContent.CreateTableElement();
            rootElement.AppendChild(tableElement);


            tableElement.BackgroundColor = Color.Beige;
            tableElement.Border = new BorderInfo(BorderSide.All, 0.80F, Color.Gray);
            tableElement.Alignment = HorizontalAlignment.Center;
            tableElement.Broken = TableBroken.Vertical;
            tableElement.ColumnAdjustment = ColumnAdjustment.AutoFitToWindow;
            tableElement.ColumnWidths = "80 80 80 80 80";
            tableElement.DefaultCellBorder = new BorderInfo(BorderSide.All, 0.50F, Color.DarkBlue);
            tableElement.DefaultCellPadding = new MarginInfo(16.0, 2.0, 8.0, 2.0);
            tableElement.DefaultCellTextState.ForegroundColor = Color.DarkCyan;
            tableElement.DefaultCellTextState.FontSize = 8F;
            tableElement.DefaultColumnWidth = "70";

            tableElement.IsBroken = false;
            tableElement.IsBordersIncluded = true;

            tableElement.Left = 0F;
            tableElement.Top = 40F;

            tableElement.RepeatingColumnsCount = 2;
            tableElement.RepeatingRowsCount = 3;
            TextState rowStyle = new TextState();
            rowStyle.BackgroundColor = Color.LightCoral;
            tableElement.RepeatingRowsStyle = rowStyle;




            TableTHeadElement tableTHeadElement = tableElement.CreateTHead();
            TableTBodyElement tableTBodyElement = tableElement.CreateTBody();
            TableTFootElement tableTFootElement = tableElement.CreateTFoot();
            int rowCount = 10;
            int colCount = 5;
            int rowIndex;
            int colIndex;

            TableTRElement headTrElement = tableTHeadElement.CreateTR();
            headTrElement.AlternativeText = "Head Row";

            for (colIndex = 0; colIndex < colCount; colIndex++)
            {
                TableTHElement thElement = headTrElement.CreateTH();
                thElement.SetText(String.Format("Head {0}", colIndex));
            }

            for (rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                TableTRElement trElement = tableTBodyElement.CreateTR();
                trElement.AlternativeText = String.Format("Row {0}", rowIndex);

                for (colIndex = 0; colIndex < colCount; colIndex++)
                {
                    TableTDElement tdElement = trElement.CreateTD();
                    tdElement.SetText(String.Format("Cell [{0}, {1}]", rowIndex, colIndex));
                }
            }

            TableTRElement footTrElement = tableTFootElement.CreateTR();
            footTrElement.AlternativeText = "Foot Row";

            for (colIndex = 0; colIndex < colCount; colIndex++)
            {
                TableTDElement tdElement = footTrElement.CreateTD();
                tdElement.SetText(String.Format("Foot {0}", colIndex));
            }

            // Save Tagged Pdf Document
            document.Save(dataDir + "StyleTableElement.pdf");

            

            // Checking PDF/UA compliance
            document = new Document(dataDir + "StyleTableElement.pdf");
            bool isPdfUaCompliance = document.Validate(dataDir + "StyleTableElement.xml", PdfFormat.PDF_UA_1);
            Console.WriteLine(String.Format("PDF/UA compliance: {0}", isPdfUaCompliance));

            // ExEnd:1

        }
    }
}
