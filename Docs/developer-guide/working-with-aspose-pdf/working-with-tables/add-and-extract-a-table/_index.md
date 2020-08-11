---
title: Add and Extract a Table
type: docs
weight: 10
url: /net/add-and-extract-a-table/
---

## **Add Table**
Tables are important when working with PDF documents. They provide great features for displaying information in a systematic manner. The Aspose.PDF.Generator namespace contains classes named Table, Cell and Row which provides functionality for creating tables when generating PDF documents from scratch.

There has been a great demand from our customers for the ability to add tables to existing PDF documents. To support this functionality, we have introduced new classes named [Table](https://apireference.aspose.com/net/pdf/aspose.pdf/table), [Cell](https://apireference.aspose.com/net/pdf/aspose.pdf/cell) and [Row](https://apireference.aspose.com/net/pdf/aspose.pdf/row) under the Aspose.PDF namespace.
### **Add Table in Existing PDF Document**
To add a table to an existing PDF file with Aspose.PDF for .NET, take the following steps:

1. Load the source file.
1. Initialize a table and set its columns and rows.
1. Set table setting (we've set the borders).
1. Populate table.
1. Add the table to a page.
1. Save the file.

The following code snippets show how to add text in an existing PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Tables-AddTable-AddTable.cs" >}}
### **AutoFitToWindow property in ColumnAdjustmentType enumeration**
{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Tables-AutoFitToWindow-AutoFitToWindow.cs" >}}
### **Get Table Width**
Sometimes, it is required to get table width dynamically. Aspose.PDF.Table class has a method GetWidth() for the purpose. For example, you have not set table columns width explicitly and set ColumnAdjustment to AutoFitToContent. In this case you can get table width as following.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Tables-GetTableWidth-GetTableWidth.cs" >}}
## **Add SVG Object to Table Cell**
Aspose.PDF for .NET supports the feature to add a table cell into a PDF file. While creating a table, it is possible to add text or images into the cells. Furthermore, the API also offers the feature to [convert SVG files to PDF format](/pdf/net/convert-a-file-to-pdf-format/#convertafiletopdfformat-convertsvgfiletopdfformat). Using a combination of these features, it is possible to load an SVG image and add it into a table cell.

The following code snippet shows the steps for creating a table instance and adding an SVG image inside a table cell.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Tables-AddSVGObject-AddSVGObject.cs" >}}
## **Add HTML Tags inside Table**
Sometimes you can come up with a requirement to import database contents that have some HTML tags and then import the content to the Table object. When importing the content, it should be rendered the HTML tags accordingly inside PDF document. We have enhanced **ImprotDataTable()** method, in order to achieve such requirement as follows:

{{% alert color="primary" %}} 

Please take into account that using of HTML Tags inside table element increases document generation time, as API needs to process HTML Tags accordingly and render them in the output PDF document.

{{% /alert %}} 

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Tables-HTMLTagsInsideTable-1.cs" >}}
## **Insert a Page Break between rows of table**
As a default behavior, when creating a table inside a PDF file, the table flows to subsequent pages when it reaches tables Bottom margin. However, we may have a requirement to forcefully insert page break when a certain number of rows are added for table. The following code snippet shows the steps to insert page break when 10 rows are added for the table.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Tables-InsertPageBreak-InsertPageBreak.cs" >}}
## **Extract table border as Image**
The page borders are path drawing operations. Therefore the Pdf->Html processing logic just performs drawing instructions and places the background behind the text. So, to repeat the logic, you have to process contents operators manually and draw the graphics yourself. Also please note that following code snippet might not work accurately for various PDF files but if you encounter any issue, please feel free to contact. This code was developed for specific PDF files. The following code snippet shows the steps to extract the table border as Image from PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Tables-ExtractBorder-ExtractBorder.cs" >}}
## **Render Table on New Page**
By default, paragraphs are added to a Page object's Paragraphs collection. However, it is possible to render a table on a new page instead of directly after the previously added paragraph level object on the page.
### **Adding a Table**
To render table on a new page, use the IsInNewPage property in the BaseParagraph class. The following code snippet shows how.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Tables-RenderTable-RenderTable.cs" >}}
