---
title: Aspose.PDF for Java 19.8 Release Notes
type: docs
weight: 50
url: /java/aspose-pdf-for-java-19-8-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 19.8](https://repository.aspose.com/repo/com/aspose/aspose-pdf/19.8/)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-38770|[Render all contents in a single page](/pdf/java/convert-html-to-pdf/#converthtmltopdf-renderingcontenttosinglepage)|New Feature|
|PDFJAVA-38814|PDF/UA: Implement [Table support](/pdf/java/working-with-table-in-tagged-pdfs/) in Tagged PDF|New Feature|
|PDFJAVA-38771|HTML to PDF: [Rendering HTML with SVG](/pdf/java/convert-html-to-pdf/#converthtmltopdf-renderhtmlwithsvgdata)|Enhancement|
|PDFJAVA-38551|PDF to DOCX results in java.lang.IndexOutOfBoundsException|Bug|
|PDFJAVA-38325|SVG to PDF - Text is not rendering with correct font|Bug|
|PDFJAVA-38791|File handling issues|Bug|
|PDFJAVA-38527|HTML to PDF - Failed to parse URL Exception thrown|Bug|
|PDFJAVA-38784|The code is throwing the NullPointException on saving|Bug|
|PDFJAVA-38555|HTML to PDF - Failed to parse URL exception occurs if image tag has no value|Bug|
|PDFJAVA-36943|Spacing issue in the page numbering|Bug|
|PDFJAVA-37360|When an image is inserted to PDF, the page is blank|Bug|
### **Public API Changes**
#### **PDF/UA: Implement Table support in Tagged PDF**


Table support was added to Tagged PDF. Use **createTableElement**() method of **ITaggedContent** interface to create table. For creating Head, Body and Foot for table use **createTHead**(), **createTBody**() and **createTFoot**() methods of **TableElement** object. Abstract class **TableRowCollectionElement** is base for **TableTHeadElement**, **TableTBodyElement** and **TableTFootElement** classes.Method **TableRowCollectionElement.createTR**() creates the row for corresponded object. Table row object belong to TableTRElement calss. Methods **TableTRElement.createTH**() and **TableTRElement.createTD**() creates the row's cell for corresponded row. You can also verify **PDF/UA** compliance of the created document. Code snippet below show how to use this functionality.

{{< highlight java >}}

 Document document = new Document();

ITaggedContent taggedContent = document.getTaggedContent();

taggedContent.setTitle("Table example - THead, TBody, TFoot; Summary");

taggedContent.setLanguage("en-US");

StructureElement rootElement = taggedContent.getRootElement();

TableElement tableElement = taggedContent.createTableElement();

rootElement.appendChild(tableElement);

TableTHeadElement tableTHeadElement = tableElement.createTHead();

TableTBodyElement tableTBodyElement = tableElement.createTBody();

TableTFootElement tableTFootElement = tableElement.createTFoot();

int rowCount = 7;

int colCount = 3;

int rowIndex;

int colIndex;

TableTRElement headTrElement = tableTHeadElement.createTR();

headTrElement.setAlternativeText("Head Row");

for (colIndex = 0; colIndex < colCount; colIndex++)

{

    TableTHElement thElement = headTrElement.createTH();

    thElement.setText("Head Cell [head row, "+colIndex+"  ]");

}

for (rowIndex = 0; rowIndex < rowCount; rowIndex++)

{

    TableTRElement trElement = tableTBodyElement.createTR();

    trElement.setAlternativeText("Row "+rowIndex);

    for (colIndex = 0; colIndex < colCount; colIndex++)

    {

        TableTDElement tdElement = trElement.createTD();

        tdElement.setText("Cell ["+rowIndex+", "+colIndex+"]");

    }

}

TableTRElement footTrElement = tableTFootElement.createTR();

footTrElement.setAlternativeText("Foot Row");

for (colIndex = 0; colIndex < colCount; colIndex++)

{

    TableTDElement tdElement = footTrElement.createTD();

    tdElement.setText("Foot Cell [foot row, "+colIndex+"]");

}

StructureAttributes tableAttributes = tableElement.getAttributes().getAttributes(AttributeOwnerStandard.Table);

StructureAttribute summaryAttribute = new StructureAttribute(AttributeKey.Summary);

summaryAttribute.setStringValue("The summary text for table");

tableAttributes.setAttribute(summaryAttribute);

// Save document

document.save(dataDir+"TaggedTable_"+version+".pdf");

boolean isPdfUaCompliance = document.validate(new ByteArrayOutputStream(), PdfFormat.PDF_UA_1);

System.out.println("PDF/UA compliance: "+ isPdfUaCompliance);

{{< /highlight >}}
