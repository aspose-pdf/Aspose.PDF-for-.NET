---
title: Aspose.PDF for Java 18.9 Release Notes
type: docs
weight: 40
url: /java/aspose-pdf-for-java-18-9-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 18.9](https://repository.aspose.com/repo/com/aspose/aspose-pdf/18.9/)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-37999|PDF/UA support and features porting from .NET Library|New Feature|
|PDFJAVA-37654|Input PDF - an incorrect sequence of the retrieved paragraphs|Bug|
|PDFJAVA-37711|PDF to XPS - the redaction and additional blank pages are being added|Bug|
|PDFJAVA-37847|The conversion PDF to PDFA_1A hangs.|Bug|
|PDFJAVA-37733|The method RedactExactArea throws an exception.|Bug|
|PDFJAVA-34613|PDF file is not properly being converted to PDF/A_1a format|Bug|
|PDFJAVA-37289|PDF replace text process shows an argument out of range error|Bug|
|PDFJAVA-37775|An exception raises while flattening the document|Bug|
|PDFJAVA-37409|PDF to TIFF creates empty file|Bug|
|PDFJAVA-37029|PDF to TIFF - an empty TIFF is generated|Bug|
|PDFJAVA-36816|PDF to TIFF - Problem generating Image file|Bug|
### **Public API Changes**
Changes:
com.aspose.pdf.**IWarningCallback** -> com.aspose.pdf.**WarningCallback** 
M:com.aspose.pdf.**LatexLoadOptions**.setWarningCallback(IWarningCallback) -> M:com.aspose.pdf.**LatexLoadOptions**.setWarningCallback(WarningCallback)
M:com.aspose.pdf.**LoadOptions**.setWarningHandler(IWarningCallback) -> M:com.aspose.pdf.**LoadOptions**.setWarningHandler(WarningCallback)
M:com.aspose.pdf.**SaveOptions**.setWarningHandler(IWarningCallback) -> M:com.aspose.pdf.**SaveOptions**.setWarningHandler(WarningCallback)

Added class:

com.aspose.pdf.**XmpValue**

Added methods:
com.aspose.pdf.**HtmlFragment**.getRectangle()
com.aspose.pdf.**Matrix**.getData()
com.aspose.pdf.**PageMarkup**.isMulticolumnParagraphsAllowed()
com.aspose.pdf.**PageMarkup**.setMulticolumnParagraphsAllowed(boolean)

Added field:
com.aspose.pdf.**TextReplaceOptions**.**ReplaceAdjustment**.ShiftRestOfLine
