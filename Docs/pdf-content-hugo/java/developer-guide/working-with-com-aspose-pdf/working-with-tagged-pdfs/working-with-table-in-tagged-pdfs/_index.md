---
title: Working with Table in Tagged PDFs
type: docs
weight: 40
url: /java/working-with-table-in-tagged-pdfs/
---

{{% alert color="primary" %}} 

This feature is supported by version 19.6 or greater.

{{% /alert %}} 
## **Create Table in Tagged PDF**
Aspose.PDF for Java allows creating a table in Tagged PDF documents. For working with tables, the API provides [TableElement](https://apireference.aspose.com/java/pdf/com.aspose.pdf.tagged.logicalstructure.elements.bls/TableElement) class. In order to create a table, you can use [createTableElement()](https://apireference.aspose.com/java/pdf/com.aspose.pdf.tagged/ITaggedContent#createTableElement--) method of [ITaggedContent](https://apireference.aspose.com/java/pdf/com.aspose.pdf.tagged/ITaggedContent) interface. Furthermore, you can use [createTHead()](https://apireference.aspose.com/java/pdf/com.aspose.pdf.tagged.logicalstructure.elements.bls/TableElement#createTHead--), [createTBody()](https://apireference.aspose.com/java/pdf/com.aspose.pdf.tagged.logicalstructure.elements.bls/TableElement#createTBody--) and [createTFoot()](https://apireference.aspose.com/java/pdf/com.aspose.pdf.tagged.logicalstructure.elements.bls/TableElement#createTFoot--) methods of TableElement class for creating Table Head, Table Body, and Table Foot respectively. To create a table row, you can use [createTR()](https://apireference.aspose.com/java/pdf/com.aspose.pdf.tagged.logicalstructure.elements.bls/TableRowCollectionElement#createTR--) method of [TableRowCollectionElement](https://apireference.aspose.com/java/pdf/com.aspose.pdf.tagged.logicalstructure.elements.bls/TableRowCollectionElement) class. The following code snippet shows, how to create a table in the Tagged PDF document: 

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-TaggedPDFs-CreateTableElement-1.java" >}}
## **Style Table Element**
Aspose.PDF for Java allows styling a table in Tagged PDF document. In order to style a table, you can create a table using [createTableElement()](https://apireference.aspose.com/java/pdf/com.aspose.pdf.tagged/ITaggedContent#createTableElement--) method of [ITaggedContent](https://apireference.aspose.com/java/pdf/com.aspose.pdf.tagged/ITaggedContent) interface.  and set style table using properties of [TableElement](https://apireference.aspose.com/java/pdf/com.aspose.pdf.tagged.logicalstructure.elements.bls/TableElement) class. The following is the list properties you can use to style a table:

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



{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-TaggedPDFs-StyleTableElement-1.java" >}}
## **Style Table Row**
Aspose.PDF for Java allows styling a table row in Tagged PDF document. In order to style a table row, you can use the properties of [TableTRElement](https://apireference.aspose.com/java/pdf/com.aspose.pdf.tagged.logicalstructure.elements.bls/TableTRElement) class. The following is the list properties you can use to style a table row:

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



{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-TaggedPDFs-StyleTableRow-1.java" >}}
## **Style Table Cell**
Aspose.PDF for Java allows styling a table cell in Tagged PDF document. In order to style a table cell, you can use the properties of [TableCellElement](https://apireference.aspose.com/java/pdf/com.aspose.pdf.tagged.logicalstructure.elements.bls/TableCellElement) class. The following is the list properties you can use to style a table cell:

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

The following code snippet shows how to style a table cell in the Tagged PDF document. You can also verify **PDF/UA** compliance of the created document. Code snippet below show how to use this functionality.

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-TaggedPDFs-StyleTableCell-1.java" >}}
