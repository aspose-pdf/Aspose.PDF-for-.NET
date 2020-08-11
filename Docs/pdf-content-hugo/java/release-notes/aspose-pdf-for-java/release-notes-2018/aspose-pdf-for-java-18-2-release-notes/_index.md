---
title: Aspose.PDF for Java 18.2 Release Notes
type: docs
weight: 110
url: /java/aspose-pdf-for-java-18-2-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 18.2](http://maven.aspose.com/repository/simple/ext-release-local/com/aspose/aspose-pdf/18.2/).

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-37494|Creating NamedDestination in existing PDF|Enhancement|
|PDFJAVA-37427|Redaction API throws an exception|Bug|
|PDFJAVA-37380|Output PDF - incorrect count of the bookmarks|Bug|
|PDFJAVA-35363|Text extraction hikes memory utilization|Bug|
|PDFJAVA-37371|Sign and Encryption of a PDF file|Bug|
|PDFJAVA-36574|PDF to HTML - icon position is wrong|Bug|
|PDFJAVA-37218|Import XSL-FO - absolute URI is too short error occurred|Bug|
|PDFJAVA-37016|Some text at the top of the page is corrupted after conversion to HTML.|Bug|
|PDFJAVA-37425|Unable to delete a non-PDF file after PdfFileInfo|Bug|
|PDFJAVA-37218|Import XSL-FO - absolute URI is too short error occurred|Bug|
|PDFJAVA-37372|Tiff to PDF: Output file is empty when color type is Grayscale|Bug|
### **Enhancement - Creating NamedDestination in existing PDF**


**Related issue:** PDFJAVA-37494

**Description:**

Some of our customers have requirement to create NamedDestination in existing PDF:

The method **Document.getNamedDestinations()** was implemented. This allows to manipulate with Named Destinations. 

**NamedDestinationCollection** has the following properties: 

public IAppointment get_Item(String name);
Gets destination by its name.

public void set_Item(String name, IAppointment value);
Sets destination by its name.

public int getCount();
Returns count of the destinations.

public void remove(String name);
Removes destination by its name.

public void add(String name, IAppointment appointment);
Adds new named destination.

**Usage:**

{{< highlight cs >}}

 Document pdf = new Document();

//create document with 100 pages

for (int i = 1; i <= 100; i++)

{

 Page page = pdf.getPages().add();

 page.addStamp(new com.aspose.pdf.TextStamp("Page " + i));

 //named destinations for every page

 pdf.getNamedDestinations().add("Page" + i, new com.aspose.pdf.XYZExplicitDestination(i, 0, 600, 0.5));

}

for (int i = 1; i <= 100; i++)

{

 //create outlines (two outlines for every page)

 com.aspose.pdf.OutlineItemCollection item1 = new com.aspose.pdf.OutlineItemCollection(pdf.getOutlines());

 item1.setDestination (new com.aspose.pdf.NamedDestination(pdf, "Page" + i));

 item1.setTitle ("Page  " + i + "(1)");

 pdf.getOutlines().add(item1);

 com.aspose.pdf.OutlineItemCollection item2 = new com.aspose.pdf.OutlineItemCollection(pdf.getOutlines());

 item2.setDestination (new com.aspose.pdf.NamedDestination(pdf, "Page" + i));

 item2.setTitle ("Page  " + i + "(2)");

 pdf.getOutlines().add(item2);

}

//let's update on of the named destinations

pdf.getNamedDestinations().set_Item("Page50", new com.aspose.pdf.XYZExplicitDestination(50, 0, 100, 2));

pdf.save(myDir+"result.pdf");

{{< /highlight >}}
### **Public API changes**
Added new constructor:
com.aspose.pdf.**GoToAction**.#ctor(Document,String)

Added new methods:
com.aspose.pdf.**HtmlSaveOptions**.getDefaultFontName()
com.aspose.pdf.**HtmlSaveOptions**.setDefaultFontName(String)

Added new method:
com.aspose.pdf.**IDocument**.getNamedDestinations

Added new constructors:
com.aspose.pdf.**NamedDestination**.#ctor(Document,String)

Added new interface **com.aspose.pdf.nameddestinations.INamedDestinationCollection** 
Methods:
get_Item(String)
set_Item(String,IAppointment)
getCount()
remove(String)
add(String,IAppointment)
getNames()

Added new class **com.aspose.pdf.nameddestinations.NamedDestinationCollection** 
Methods:
get_Item(String)
set_Item(String,IAppointment)
getCount()
remove(String)
add(String,IAppointment)
getNames()

Added new method:
com.aspose.pdf.**PdfFormatConversionOptions**.getNotAccessibleFonts

Added new methods:
com.aspose.pdf.**RenderingOptions**.getMaxFontsCacheSize()
com.aspose.pdf.**RenderingOptions**.setMaxFontsCacheSize(int)
com.aspose.pdf.**RenderingOptions**.getMaxSymbolsCacheSize()
com.aspose.pdf.**RenderingOptions**.setMaxSymbolsCacheSize(int)

Added new methods:
com.aspose.pdf.**Table**.getRepeatingColumnsCount()
com.aspose.pdf.**Table**.setRepeatingColumnsCount(int)


