using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class StyleTableCell
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

            taggedContent.SetTitle("Example table cell style");
            taggedContent.SetLanguage("en-US");

            // Get root structure element
            StructureElement rootElement = taggedContent.RootElement;


            // Create table structure element
            TableElement tableElement = taggedContent.CreateTableElement();
            rootElement.AppendChild(tableElement);


            TableTHeadElement tableTHeadElement = tableElement.CreateTHead();
            TableTBodyElement tableTBodyElement = tableElement.CreateTBody();
            TableTFootElement tableTFootElement = tableElement.CreateTFoot();
            int rowCount = 4;
            int colCount = 4;
            int rowIndex;
            int colIndex;

            TableTRElement headTrElement = tableTHeadElement.CreateTR();
            headTrElement.AlternativeText = "Head Row";

            for (colIndex = 0; colIndex < colCount; colIndex++)
            {
                TableTHElement thElement = headTrElement.CreateTH();
                thElement.SetText(String.Format("Head {0}", colIndex));

                thElement.BackgroundColor = Color.GreenYellow;
                thElement.Border = new BorderInfo(BorderSide.All, 4.0F, Color.Gray);

                thElement.IsNoBorder = true;
                thElement.Margin = new MarginInfo(16.0, 2.0, 8.0, 2.0);

                thElement.Alignment = HorizontalAlignment.Right;
            }

            for (rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                TableTRElement trElement = tableTBodyElement.CreateTR();
                trElement.AlternativeText = String.Format("Row {0}", rowIndex);

                for (colIndex = 0; colIndex < colCount; colIndex++)
                {
                    int colSpan = 1;
                    int rowSpan = 1;

                    if (colIndex == 1 && rowIndex == 1)
                    {
                        colSpan = 2;
                        rowSpan = 2;
                    }
                    else if (colIndex == 2 && (rowIndex == 1 || rowIndex == 2))
                    {
                        continue;
                    }
                    else if (rowIndex == 2 && (colIndex == 1 || colIndex == 2))
                    {
                        continue;
                    }

                    TableTDElement tdElement = trElement.CreateTD();
                    tdElement.SetText(String.Format("Cell [{0}, {1}]", rowIndex, colIndex));


                    tdElement.BackgroundColor = Color.Yellow;
                    tdElement.Border = new BorderInfo(BorderSide.All, 4.0F, Color.Gray);

                    tdElement.IsNoBorder = false;
                    tdElement.Margin = new MarginInfo(8.0, 2.0, 8.0, 2.0);

                    tdElement.Alignment = HorizontalAlignment.Center;

                    TextState cellTextState = new TextState();
                    cellTextState.ForegroundColor = Color.DarkBlue;
                    cellTextState.FontSize = 7.5F;
                    cellTextState.FontStyle = FontStyles.Bold;
                    cellTextState.Font = FontRepository.FindFont("Arial");
                    tdElement.DefaultCellTextState = cellTextState;

                    tdElement.IsWordWrapped = true;
                    tdElement.VerticalAlignment = VerticalAlignment.Center;

                    tdElement.ColSpan = colSpan;
                    tdElement.RowSpan = rowSpan;
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
            document.Save(dataDir + "StyleTableCell.pdf");

            // Checking PDF/UA compliance
            document = new Document(dataDir + "StyleTableCell.pdf");
            bool isPdfUaCompliance = document.Validate(dataDir + "StyleTableCell.xml", PdfFormat.PDF_UA_1);
            Console.WriteLine(String.Format("PDF/UA compliance: {0}", isPdfUaCompliance));
        }
    }
}
