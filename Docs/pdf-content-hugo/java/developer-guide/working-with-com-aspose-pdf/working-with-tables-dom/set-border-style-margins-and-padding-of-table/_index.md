---
title: Set Border Style, Margins and Padding of Table
type: docs
weight: 10
url: /java/set-border-style-margins-and-padding-of-table/
---

{{% alert color="primary" %}} 

Aspose.PDF for Java allows developers to create tables in PDF documents. According to of Aspose.PDF's Document Object Model, a table is a paragraph level element.

{{% /alert %}} 
### **Working with Borders, Margins and Padding**
Please note that it also supports the feature to set border style, margins and cell padding for tables. Before going into more technical details, it's important to understand the concepts of border, margins and padding which are presented below in a diagram:

**Borders, margins and padding** 

![todo:image_alt_text](set-border-style-margins-and-padding-of-table_1.png)

In the above figure, you can see that the borders of table, row and cell overlap. Using Aspose.PDF, a table can have margins and cells can have paddings. To set cell margins, we have to set cell padding.
#### **Borders**
To set the borders of [Table](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Table), Row and Cell objects, use the [Table.setBorder()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Table#setBorder-com.aspose.pdf.BorderInfo-), [Row.setBorder()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Row#setBorder-com.aspose.pdf.BorderInfo-) and [Cell.setBorder()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Cell#setBorder-com.aspose.pdf.BorderInfo-) methods. Cell borders can also be set using the [Table](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Table) class' [setDefaultCellBorder()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Table#setDefaultCellBorder-com.aspose.pdf.BorderInfo-) method. All border related methods above are assigned an instance of the [BorderInfo](https://apireference.aspose.com/java/pdf/com.aspose.pdf/BorderInfo) class, which is created by calling its constructor. The [BorderInfo](https://apireference.aspose.com/java/pdf/com.aspose.pdf/BorderInfo) constructor has many overloads that take almost all parameters required to customize the border.
#### **Margins Or Padding**
Cell padding can be managed using the [Table](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Table) class' [setDefaultCellBorder()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Table#setDefaultCellBorder-com.aspose.pdf.BorderInfo-) method. All padding related properties are assigned an instance of the [MarginInfo](https://apireference.aspose.com/java/pdf/com.aspose.pdf/MarginInfo) class that takes information about the Left, Right, Top and Bottom parameters for creating customized margins.

In the example below, the cell border width is set to 0.1 point, the table border width is set to 1 point and cell padding is set to 5 points.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-tables-SetBorderStyleMarginsAndPaddingOfTable-.java" >}}
