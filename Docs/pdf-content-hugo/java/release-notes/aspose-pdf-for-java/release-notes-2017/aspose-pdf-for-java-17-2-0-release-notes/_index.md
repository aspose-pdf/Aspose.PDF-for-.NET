---
title: Aspose.Pdf for Java 17.2.0 Release Notes
type: docs
weight: 110
url: /java/aspose-pdf-for-java-17-2-0-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-34604|Support PDF/A_3U format|New Feature|
|PDFJAVA-35730|Get graph chart from PDF file|New Feature|
|PDFJAVA-35208|HTML to PDF - Formatting issues in resultant file|Bug|
|PDFJAVA-36447|HTML to PDF: some text is overlapped in resultant PDF|Bug|
|PDFJAVA-34556|PCL to PDF: multiple pages are overlaping in output PDF|Bug|
|PDFJAVA-35803|PCL to PDF: contents(table columns) are not expanding as per page layour|Bug|
|PDFJAVA-36445|Formatting Issue when converting pdf to ppt|Bug|
|PDFJAVA-35644|Exception when trying to extract table from PDF file|Bug|
|PDFJAVA-36323|TIFF to PDF - Exception during conversion|Bug|
|PDFJAVA-35609|PDF to PDFA problem with transparent images after conversion|Bug|
|PDFJAVA-36115|PDF to PDF/A - illegible text on page 9|Bug|
|PDFJAVA-35662|PDF to PDFA conversion generates a very large file in size|Bug|
|PDFJAVA-36365|Text to PDF is not working in multithreading|Bug|
|PDFJAVA-36232|PDF to PDFA: conversion was working fine in 11.2.0 but 12.0.0|Bug|
|PDFJAVA-35681|PDF to TIFF conversion loses the image quality|Bug|
|PDFJAVA-36209|PDF to DOC: data alignment issue|Bug|
|PDFJAVA-36203|PDF to DOC: Table headers are disappeared|Bug|
|PDFJAVA-35193|Table header not being grouped with first row|Bug|
|PDFJAVA-36391|When FormType is changed to Standard, the NullPointerException occurs.|Bug|
|PDFJAVA-36497|PDF TO PDF/A Conversion Shows incorrect output|Bug|
|PDFJAVA-36114|DropDown value is not preserved when calling flatten() method|Bug|
|PDFJAVA-35968|PdfFileInfo hangs forever for a large TIFF image|Bug|
### **Public API Changes in Aspose.PDF for Java 17.2.0**


Changes in class **com.aspose.pdf.devices.TiffSettings:**

Added methods:
public void setIndexedConversionType(/* IndexedConversionType */int value)
public /* IndexedConversionType */int getIndexedConversionType()

Implemented new enum class **com.aspose.pdf.devices.TiffSettings.IndexedConversionType** with two fields:

public static final int Simple = 0;
public static final int Pixelated = 1;

Changes in class **com.aspose.pdf.Document:**

Added method:
public boolean convert(PdfFormatConversionOptions options)

Changes in class **com.aspose.pdf.facades.PdfExtractor:**

Added method:
public void extractMarkedContentAsImages(Page page, String path)

Changes in class **com.aspose.pdf.Form:**

Added methods:
public boolean getRemovePermission()
public void setRemovePermission(boolean value)
public boolean getEmulateRequierdGroups()
public void setEmulateRequierdGroups(boolean value)

Implemented new class **com.aspose.pdf.devices.PdfFileInfo** with the following methods:

public boolean getUpdateAppearances()
public void setUpdateAppearances(boolean value)
public boolean getCallEvents()
public void setCallEvents(boolean value)

Changes in class **com.aspose.pdf.LevelFormat:**

Added method:
public /* TabLeaderType */int getLineDash()
public void setLineDash(/* TabLeaderType */int value)

Changes in class **com.aspose.pdf.WatermarkAnnotation:**

Added method:
public double getOpacity()
public void setOpacity(double value)

Changes in class **com.aspose.pdf.XfaParserOptions:**

Added method:
public boolean getEmulateRequierdGroups()
public void setEmulateRequierdGroups(boolean value)




[Add Labels](https://saltov.dynabic.com/wiki/display/PDFJAVA/Public+API+Changes+for+version+17.2.0 "Add Labels ( Type 'l' )")


