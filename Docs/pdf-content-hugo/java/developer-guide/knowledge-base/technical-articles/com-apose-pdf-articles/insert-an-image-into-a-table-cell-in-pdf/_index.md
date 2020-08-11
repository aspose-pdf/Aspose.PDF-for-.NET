---
title: Insert an Image into a Table Cell in PDF
type: docs
weight: 20
url: /java/insert-an-image-into-a-table-cell-in-pdf/
---

{{% alert color="primary" %}} 

Tables are important elements for displaying data. They provide a presentable format for data representation. Tables are often used to display numeric information. Aspose.PDF API provides a class, Table, which offers you the capability to create tables in PDF file.

Rather than creating a simple table you can set different formatting options, for example the table border style, margin information, alignment, background color, column width, title information, the value of rows to be repeated on every page and many more.

{{% /alert %}} 
### **Aspose.PDF Approach**
According to our DOM (Document Object Model) a document is composed of Pages. A page contains one or more paragraphs, and a paragraph may be an image, text, a form field, a heading, a floating box, graph, attachment, or a table. A table, in turn, has a collection of rows and each row has a collection of cells. A cell is a collection of paragraphs.

So according to our DOM a table cell can contain any of the paragraph elements specified above, including images.
#### **Understanding Cell Width**
One must have a clear understanding of cell width, especially when displaying an image in table cell, so that the image width is fixed to the width of a cell so it displays properly. The width of an image can be set by using the Image class' setFixedWidth() method.

In the example below, the image is scaled to the fixed width of table cell, that is

![todo:image_alt_text](/plugins/servlet/confluence/placeholder/unknown-attachment)
#### **Code Example**
**Java**

{{< highlight csharp >}}

 String dataDir = "C:\\temp\\";

//Instantiate a Document object by calling its empty constructor

Document pdfDocument = new Document();

//Create a page in the Document object

com.aspose.pdf.Page page = pdfDocument.getPages().add();



//Instantiate a table object

Table table = new Table();

//Add the table in paragraphs collection of the desired page

page.getParagraphs().add(table);

//Set with column widths of the table

table.setColumnWidths("100 100 120");



//Set table border using another customized BorderInfo object

table.setDefaultCellBorder(new BorderInfo(BorderSide.All, 1F));



//Create an image object in the page

com.aspose.pdf.Image img1 = new com.aspose.pdf.Image();

//Set the path of image file

img1.setFile(dataDir + "logo.jpg");		

img1.setFixWidth(100);

img1.setFixHeight(100);

//Create rows in the table and then cells in the rows

Row row1 = table.getRows().add();

row1.getCells().add("Sample text in cell");

// Add the cell which holds the image

Cell cell2 = row1.getCells().add();

//Add the image to the table cell

cell2.getParagraphs().add(img1);



row1.getCells().add("Previous cell with image");

row1.getCells().get_Item(2).setVerticalAlignment(VerticalAlignment.Center);



//Save the document 

pdfDocument.save(dataDir + "Image_in_Cell.pdf");     

{{< /highlight >}}
