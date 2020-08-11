---
title: Aspose.PDF for Java 18.8 Release Notes
type: docs
weight: 50
url: /java/aspose-pdf-for-java-18-8-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 18.8](https://repository.aspose.com/repo/com/aspose/aspose-pdf/18.8/)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-37857|Support for Setting locale|New Feature|
|PDFJAVA-37926|Extending API for the image support.|New Feature|
|PDFJAVA-36314|PDF to PDF/A - Resultant file is not compliant|Bug|
|PDFJAVA-37373|JPEG to PDF: Inserted image is invisible|Bug|
|PDFJAVA-35569|Text overlaps after replace operation|Bug|
|PDFJAVA-37925|Can't configure using of another default font until application will not be rerun|Bug|
|PDFJAVA-37785|FontRepository findFont throws "String index out of range" exception|Bug|
|PDFJAVA-37399|After conversion PDF-to-PDFA the output contains corrupted diagram|Bug|
|PDFJAVA-37753|JPEG to PDF: Error after openning PDF and inserted image is invisible|Bug|
### **Public API Changes**
The class location moved: 
com.aspose.pdf.**Document**.**FontSubsetStrategy** -> com.aspose.pdf.**FontSubsetStrategy**

Added methods:
com.aspose.pdf.**IDocument**.bindXml(InputStream)

com.aspose.pdf.**IIndexBitmapConverter**.get4BppImage(java.awt.image.BufferedImage)
com.aspose.pdf.**IIndexBitmapConverter**.get8BppImage(java.awt.image.BufferedImage)

com.aspose.pdf.**ImagePlacement**.replace(InputStream)

com.aspose.pdf.**XImage**.getRawParameters
com.aspose.pdf.**XImage**.toStream

com.aspose.pdf.**PptxSaveOptions**.isRecognizeTextColumns()
com.aspose.pdf.**PptxSaveOptions**.setRecognizeTextColumns(boolean)

Added costructors:
com.aspose.pdf.**TextEditOptions**.TextEditOptions()
com.aspose.pdf.**TextEditOptions**.TextEditOptions(int,Class)

Added classes:
com.aspose.pdf.**LocaleOptions**()
methods:
setLocale(Locale)
getLocale()
clear()

com.aspose.pdf.**XImage**.**RawParameters** 
fields:
Type
Subtype
ColorSpace
Length
Filter
Name
BitsPerComponent
Width
Height
DecodeParms
