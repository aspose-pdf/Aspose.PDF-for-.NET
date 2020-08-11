---
title: Aspose.PDF for Java 18.7 Release Notes
type: docs
weight: 60
url: /java/aspose-pdf-for-java-18-7-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 18.7](https://repository.aspose.com/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-pdf/18.7)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-35745|PDF to HTML: Saving html file without fonts|Enhancement|
|PDFJAVA-37679|Multi byte characters not displayed in PDF|Bug|
|PDFJAVA-37829|PDF to image - out of memory exception|Bug|
|PDFJAVA-37792|PDF to HTML - local links are not preserved|Bug|
|PDFJAVA-37675|NullPointerException during PDF to PDF/A|Bug|
|PDFJAVA-37453|Yellow background not same after converting PDF to PDF/A|Bug|
|PDFJAVA-37827|PDF to Excel - Incorrect ouput|Bug|
|PDFJAVA-37825|API is unable to extract table data using TableAbsorber Class|Bug|
|PDFJAVA-34879|PDF to PDFA3b: Converting PDF, generated from Aspose.Cells, to PDFA3b fails the compliance (Linux)|Bug|
|PDFJAVA-34878|PDF to PDFA2b: Converting PDF, generated from Aspose.Cells, to PDFA2b fails the compliance (Linux)|Bug|
### **Public API Changes**
Added new classes:
com.aspose.pdf.drawing.**GradientRadialShading** 
com.aspose.pdf.taggedpdf.**TaggedPdfFigureElement** 
com.aspose.pdf.taggedpdf.**TaggedPdfElement** 
com.aspose.pdf.taggedpdf.**TaggedPdfParentTree** 
com.aspose.pdf.taggedpdf.**TaggedPdfContent** 
com.aspose.pdf.taggedpdf.**TaggedPdfChildElements** 
com.aspose.pdf.taggedpdf.**TaggedPdfTextElement**

Added new methods:
com.aspose.pdf.**Document**.isPdfUaCompliant()
com.aspose.pdf.**Document**.isPdfTaggedMarked()
com.aspose.pdf.**Document**.saveIncrementally(String)
com.aspose.pdf.**Document**.removePdfUaCompliance()

Added new methods:
com.aspose.pdf.**TableAbsorber**.remove(AbsorbedTable)
com.aspose.pdf.**TableAbsorber**.replace(Page,AbsorbedTable,Table)

Added new methods:
com.aspose.pdf.taggedpdf.**TaggedPdfContent**.add(TaggedPdfFigureElement)
com.aspose.pdf.taggedpdf.**TaggedPdfDocumentElement**.add(Page,TaggedPdfFigureElement)

Added new method:
com.aspose.pdf.**TextFragment**.setRectangle(Rectangle)

Added new method:
com.aspose.pdf.**AppearanceDictionary**.getKeys_()

Added new methods:
com.aspose.pdf.**TextFragmentAbsorber**.removeAllText(Page)
com.aspose.pdf.**TextFragmentAbsorber**.removeAllText(Document)

Added new methods:
com.aspose.pdf.**XImage**.toString()
com.aspose.pdf.**XImage**.getRawBytes()

Added new methods:
com.aspose.pdf.**ExcelSaveOptions**.getFormat()
com.aspose.pdf.**ExcelSaveOptions**.setFormat(int)

Added new enum-class com.aspose.pdf.ExcelSaveOptions.ExcelFormat with the following fields:
com.aspose.pdf.**ExcelSaveOptions**.ExcelFormat.XMLSpreadSheet2003 = 0;
com.aspose.pdf.**ExcelSaveOptions**.ExcelFormat.XLSX = 1;
