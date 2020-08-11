---
title: Add Table in Existing PDF Document
type: docs
weight: 50
url: /java/add-table-in-existing-pdf-document/
---

Tables are important when working with PDF documents. They provide great features for displaying information in a systematic manner. The com.aspose.pdf package contains classes named [Table](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Table), [Cell](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Cell) and [Row](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Row) which provide functionality for creating tables when generating PDF documents from scratch.

In this article, we show how to use these new classes to add a table to an existing PDF.
### **Adding a Table**
To add a table to an existing PDF file with Aspose.PDF for Java, take the following steps:

1. Load the source file.
1. Initialize a table and set its columns and rows.
1. Set table setting (we've set the borders).
1. Populate table.
1. Add the table to a page.
1. Save the file.

The following code snippets show how to add table in an existing PDF file.

{{< gist "" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-Tables-AddTableInExistingPDFDocument-AddTableInExistingPDFDocument.java" >}}
### **AutoFitToWindow property in ColumnAdjustmentType enumeration**
{{< gist "" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-Tables-AddTableInExistingPDFDocument-SetAutoFitToWindowPropertyInColumnAdjustmentTypeEnumeration.java" >}}
### **Hide Spanned Cell Borders**
While adding cells to a table, the spanned cell borders may show up when they break to another row. Such spanned borders can be made hidden as shown in the following code sample.

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-Tables-HideSpannedCellBorder-HideSpannedCellBorder.java" >}}
