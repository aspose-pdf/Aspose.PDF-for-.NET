---
title: Aspose.PDF for Java 18.10 Release Notes
type: docs
weight: 30
url: /java/aspose-pdf-for-java-18-10-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 18.10](https://repository.aspose.com/repo/com/aspose/aspose-pdf/18.10/)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-36993|Support of custom fonts on IBM iSeries|Enhancement|
|PDFJAVA-38100|Move Java APIs Code Baseline to JDK 1.8|Bug|
|PDFJAVA-37992|Exception when applying HOCR to PDF in multithreaded maven test|Bug|
|PDFJAVA-37980|HOCR text isn't properly aligned in the output document|Bug|
|PDFJAVA-37292|Output PDF - the text stamp is invisible|Bug|
|PDFJAVA-38060|NullPointerException on getNamedDestinations().getNames()|Bug|
|PDFJAVA-37652|The FreeTextAnnotation text content isn't shown in the output document.|Bug|
|PDFJAVA-37865|An exception occurs while applying the text stamp|Bug|
|PDFJAVA-34868|PDF to PDFA2a: Converting PDF, generated from Aspose.Cells, to PDFA2a fails the compliance|Bug|
### **Public API Changes**
Renamed methods:
com.aspose.pdf.**Artifact**.getContents_Rename_Namesake -> com.aspose.pdf.**Artifact**.getContents
com.aspose.pdf.**Characteristics**.setBorder(Object) -> com.aspose.pdf.**Characteristics**.setBorder(Color)
com.aspose.pdf.**PptxSaveOptions**.isRecognizeTextColumns -> com.aspose.pdf.**PptxSaveOptions**.isOptimizeTextBoxes
com.aspose.pdf.**PptxSaveOptions**.setRecognizeTextColumns(boolean) -> com.aspose.pdf.**PptxSaveOptions**.setOptimizeTextBoxes(boolean)
com.aspose.pdf.**RichMediaAnnotation**.getContent_Rename_Namesake -> com.aspose.pdf.**RichMediaAnnotation**.getContent

Interface changed into class:
com.aspose.pdf.**IWarningCallback** -> com.aspose.pdf.**WarningCallback** 
com.aspose.pdf.**LatexLoadOptions**.setWarningCallback(IWarningCallback) -> com.aspose.pdf.**LatexLoadOptions**.setWarningCallback(WarningCallback)
com.aspose.pdf.**LoadOptions**.setWarningHandler(IWarningCallback) -> com.aspose.pdf.**LoadOptions**.setWarningHandler(WarningCallback)
com.aspose.pdf.**SaveOptions**.setWarningHandler(IWarningCallback) -> com.aspose.pdf.**SaveOptions**.setWarningHandler(WarningCallback)

Added new methods:
com.aspose.pdf.**CharInfoCollection**.copyTo(CharInfo[],int)
com.aspose.pdf.**HtmlFragment**.getRectangle
com.aspose.pdf.**Matrix**.getData
com.aspose.pdf.nameddestinations.**NamedDestinationCollection**.isEmpty
com.aspose.pdf.**OutlineCollection**.remove(int)
com.aspose.pdf.**OutlineItemCollection**.remove(int)
com.aspose.pdf.**PageMarkup**.isMulticolumnParagraphsAllowed
com.aspose.pdf.**PageMarkup**.setMulticolumnParagraphsAllowed(boolean)
com.aspose.pdf.**TextFragmentState**.getUnderline
com.aspose.pdf.**TextFragmentState**.getTextHeight
com.aspose.pdf.**TextState**.getTextHeight

Added new field:
com.aspose.pdf.TextReplaceOptions.**ReplaceAdjustment**.ShiftRestOfLine

Added new class:
com.aspose.pdf.**XmpValue**


