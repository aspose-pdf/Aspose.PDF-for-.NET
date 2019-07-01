using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Tagged;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs
{
    public class StyleTableRow
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

            taggedContent.SetTitle("Example table row style");
            taggedContent.SetLanguage("en-US");

            // Get root structure element
            StructureElement rootElement = taggedContent.RootElement;


            // Create table structure element
            TableElement tableElement = taggedContent.CreateTableElement();
            rootElement.AppendChild(tableElement);


            TableTHeadElement tableTHeadElement = tableElement.CreateTHead();
            TableTBodyElement tableTBodyElement = tableElement.CreateTBody();
            TableTFootElement tableTFootElement = tableElement.CreateTFoot();
            int rowCount = 7;
            int colCount = 3;
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

                trElement.BackgroundColor = Color.LightGoldenrodYellow;
                trElement.Border = new BorderInfo(BorderSide.All, 0.75F, Color.DarkGray);

                trElement.DefaultCellBorder = new BorderInfo(BorderSide.All, 0.50F, Color.Blue);
                trElement.MinRowHeight = 100.0;
                trElement.FixedRowHeight = 120.0;
                trElement.IsInNewPage = (rowIndex % 3 == 1);
                trElement.IsRowBroken = true;

                TextState cellTextState = new TextState();
                cellTextState.ForegroundColor = Color.Red;
                trElement.DefaultCellTextState = cellTextState;

                trElement.DefaultCellPadding = new MarginInfo(16.0, 2.0, 8.0, 2.0);
                trElement.VerticalAlignment = VerticalAlignment.Bottom;

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
            document.Save(dataDir + "StyleTableRow.pdf");

            // Checking PDF/UA compliance
            document = new Document(dataDir + "StyleTableRow.pdf");
            bool isPdfUaCompliance = document.Validate(dataDir + "StyleTableRow.xml", PdfFormat.PDF_UA_1);
            Console.WriteLine(String.Format("PDF/UA compliance: {0}", isPdfUaCompliance));

            // ExEnd:1
        }
    }
}
