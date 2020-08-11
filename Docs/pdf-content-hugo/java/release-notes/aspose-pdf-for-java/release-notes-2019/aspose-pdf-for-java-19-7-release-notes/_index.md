---
title: Aspose.PDF for Java 19.7 Release Notes
type: docs
weight: 60
url: /java/aspose-pdf-for-java-19-7-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 19.7](https://repository.aspose.com/repo/com/aspose/aspose-pdf/19.7/)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-38602|PDF to HTML consumes much time|Enhancement|
|PDFJAVA-38665|PDF to Excel: Recognize text in superscript|Bug|
|PDFJAVA-38633|Exception replacing text|Bug|
|PDFJAVA-36683|Aspose PDF adding white-space|Bug|
|PDFJAVA-36690|PDF to PDF/A - compliance failure: Form field has multiple appearances|Bug|
|PDFJAVA-35184|PDF to PDF/A - Resultant file is not compliant|Bug|
|PDFJAVA-34654|PDF to HTML:output HTML is approx 14 times larger than source PDF|Bug|
|PDFJAVA-38362|The stamping performance issue|Bug|
### **Public API Changes**
**Added new fields:** 
com.aspose.pdf.facades.**FieldType**.Numeric
com.aspose.pdf.facades.**FieldType**.DateTime
com.aspose.pdf.TextEditOptions.**NoCharacterAction**.UseCustomReplacementFont
com.aspose.pdf.**HtmlSaveOptions**.ExcludeFontNameList

**Added new methods:**

com.aspose.pdf.**Form**.getSignaturesExist()
com.aspose.pdf.**Form**.setSignaturesExist(boolean)
com.aspose.pdf.**Form**.getSignaturesAppendOnly()
com.aspose.pdf.**Form**.setSignaturesAppendOnly(boolean)
com.aspose.pdf.**HtmlLoadOptions**.isRenderToSinglePage()
com.aspose.pdf.**HtmlLoadOptions**.setRenderToSinglePage(boolean)
com.aspose.pdf.**HtmlLoadOptions**.isEmbedFonts()
com.aspose.pdf.**HtmlLoadOptions**.setEmbedFonts(boolean)
com.aspose.pdf.**HtmlSaveOptions**.getProcessingBatchSize()
com.aspose.pdf.**HtmlSaveOptions**.setProcessingBatchSize(int)
com.aspose.pdf.**HtmlSaveOptions**.getSimpleTextboxModeGrouping()
com.aspose.pdf.**HtmlSaveOptions**.setSimpleTextboxModeGrouping(boolean)
com.aspose.pdf.**PptxSaveOptions**.getImageResolution()
com.aspose.pdf.**PptxSaveOptions**.setImageResolution(int)
com.aspose.pdf.**TextEditOptions**.getReplacementFont()
com.aspose.pdf.**TextEditOptions**.setReplacementFont(Font)
com.aspose.pdf.**XFA**.getXfaField(String)
com.aspose.pdf.**XmpValue**.toStructure()
com.aspose.pdf.**XmpValue**.toField()
com.aspose.pdf.**XmpValue**.toNamedValue()
com.aspose.pdf.**XmpValue**.toNamedValues()

**Added new classes:**

com.aspose.pdf.**XmpField** 
com.aspose.pdf.**XmpFieldType**
