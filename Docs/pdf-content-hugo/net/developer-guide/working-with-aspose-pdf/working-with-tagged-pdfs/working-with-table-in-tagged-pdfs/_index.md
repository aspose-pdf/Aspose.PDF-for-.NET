---
title: Working with Table in Tagged PDFs
type: docs
weight: 40
url: /net/working-with-table-in-tagged-pdfs/
---

{{% alert color="primary" %}} 

This feature is supported by version 19.6 or greater.

{{% /alert %}} 
## **Create Table in Tagged PDF**
Aspose.PDF for .NET allows creating a table in Tagged PDF documents. For working with tables, the API provides [TableElement](https://apireference.aspose.com/net/pdf/aspose.pdf.logicalstructure/tableelement) class. In order to create a table, you can use [CreateTableElement()](https://apireference.aspose.com/net/pdf/aspose.pdf.tagged/itaggedcontent/methods/createtableelement) method of [ITaggedContent](https://apireference.aspose.com/net/pdf/aspose.pdf.tagged/itaggedcontent) interface. Furthermore, you can use [CreateTHead()](https://apireference.aspose.com/net/pdf/aspose.pdf.logicalstructure/tableelement/methods/createthead), [CreateTBody()](https://apireference.aspose.com/net/pdf/aspose.pdf.logicalstructure/tableelement/methods/createtbody) and [CreateTFoot()](https://apireference.aspose.com/net/pdf/aspose.pdf.logicalstructure/tableelement/methods/createtfoot) methods of TableElement class for creating Table Head, Table Body, and Table Foot respectively. To create a table row, you can use [CreateTR()](https://apireference.aspose.com/net/pdf/aspose.pdf.logicalstructure/tablerowcollectionelement/methods/createtr) method of [TableRowCollectionElement](https://apireference.aspose.com/net/pdf/aspose.pdf.logicalstructure/tablerowcollectionelement) class. You can also check if the created PDF document is PDF/UA compliance using the Validate() method of Document class. The following code snippet shows, how to create a table in the Tagged PDF document: 

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-with-TaggedPDFs-CreateTableElement-1.cs" >}}
## **Style Table Element**
Aspose.PDF for .NET allows styling a table in Tagged PDF document. In order to style a table, you can create a table using [CreateTableElement()](https://apireference.aspose.com/net/pdf/aspose.pdf.tagged/itaggedcontent/methods/createtableelement) method of [ITaggedContent](https://apireference.aspose.com/net/pdf/aspose.pdf.tagged/itaggedcontent) interface and set style table using properties of [TableElement](https://apireference.aspose.com/net/pdf/aspose.pdf.logicalstructure/tableelement) class. The following is the list properties you can use to style a table:

- BackgroundColor
- Border
- Alignment
- CornerStyle
- Broken
- ColumnAdjustment
- ColumnWidths
- DefaultCellBorder
- DefaultCellPadding
- DefaultCellTextState
- DefaultColumnWidth
- IsBroken
- IsBordersIncluded
- Left
- Top

The following code snippet shows how to style a table in Tagged PDF document:



{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-with-TaggedPDFs-StyleTableElement-1.cs" >}}
## **Style Table Row**
Aspose.PDF for .NET allows styling a table row in Tagged PDF document. In order to style a table row, you can use the properties of [TableTRElement](https://apireference.aspose.com/net/pdf/aspose.pdf.logicalstructure/tabletrelement) class. The following is the list properties you can use to style a table row:

- BackgroundColor
- Border
- DefaultCellBorder
- MinRowHeight
- FixedRowHeight
- IsInNewPage
- IsRowBroken
- DefaultCellTextState
- DefaultCellPadding
- VerticalAlignment

The following code snippet shows how to style a table row in the Tagged PDF document:



{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-with-TaggedPDFs-StyleTableRow-1.cs" >}}
## **Style Table Cell**
Aspose.PDF for .NET allows styling a table cell in Tagged PDF document. In order to style a table cell, you can use the properties of [TableCellElement](https://apireference.aspose.com/net/pdf/aspose.pdf.logicalstructure/tablecellelement) class. The following is the list properties you can use to style a table cell:

- BackgroundColor
- Border
- IsNoBorder
- Margin
- Alignment
- DefaultCellTextState
- IsWordWrapped
- VerticalAlignment
- ColSpan
- RowSpan

The following code snippet shows how to style a table cell in the Tagged PDF document:



{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-with-TaggedPDFs-StyleTableCell-1.cs" >}}








