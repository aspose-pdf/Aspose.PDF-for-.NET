---
title: Aspose.PDF for Java 19.9 Release Notes
type: docs
weight: 40
url: /java/aspose-pdf-for-java-19-9-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 19.9](https://downloads.aspose.com/pdf/java/new-releases/aspose.pdf-for-java-19.9/).

{{% /alert %}} 
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-38882|Add [ImageStamp as a background](/pdf/java/adding-stamp-in-a-pdf-file/#addingstampinapdffile-addimagestampasbackgroundinfloatingbox) in FloatingBox|New Feature|
|PDFJAVA-38883|Unsupported Latex tags: [\begin \end \qedhere](/pdf/java/advanced-features/#advancedfeatures-supportforlatextags)|New Feature|
|PDFJAVA-36860|API is taking too long for HTML to PDF Conversion|Enhancement|
|PDFJAVA-38810|Part of the content is missing after conversion|Bug|
|PDFJAVA-38582|Form data is not being imported correctly from XFDF|Bug|
|PDFJAVA-37688|PDF to XPS - an empty argument error occurred|Bug|
|PDFJAVA-38733|hOCR text alignment issue|Bug|
|PDFJAVA-38826|Exception while getting annotation modification date|Bug|
|PDFJAVA-38734|The stamping performance issue - Fix locks in font process|Bug|
|PDFJAVA-38853|XPS to PDF - API is throwing an exception|Bug|
### **Public API changes in Aspose.PDF for Java19.9**
-----
See the list of any changes made to the public API such as added, renamed, removed or deprecated members as well as any non-backward compatible change made to Aspose.PDF for Java. If you have concerns about any change listed, please raise it on the [Aspose.PDF support forum](https://forum.aspose.com/c/pdf).
### **New Methods**
com.aspose.pdf.**CheckboxField**.getExportValue()
com.aspose.pdf.**CheckboxField**.setExportValue(String)

com.aspose.pdf.**Document**.isManualDisposeEnabled()
com.aspose.pdf.**Document**.setManualDisposeEnabled(boolean)

com.aspose.pdf.**FloatingBox**.getBackgroundImage()
com.aspose.pdf.**FloatingBox**.setBackgroundImage(Image)

com.aspose.pdf.**FreeTextAnnotation**.getTextRectangle()
com.aspose.pdf.**FreeTextAnnotation**.setTextRectangle(Rectangle)

com.aspose.pdf.**Rectangle**.isInclude(Rectangle,double)

com.aspose.pdf.**TextEditOptions**.getClippingPathsProcessing()
com.aspose.pdf.**TextEditOptions**.setClippingPathsProcessing(int)

com.aspose.pdf.**IDocument**.isManualDisposeEnabled()
com.aspose.pdf.**IDocument**.setManualDisposeEnabled(boolean)

By default any method "save" in the Document class will close internal streams and free up memory resources. We can do some operations and continue work with the document instance after execute method "save" if this ManualDispose parameter is enabled. But it is strongly recommended to call the "dispose" method when the Document instance is no longer needed.
### **New Fields**
com.aspose.pdf.**ExcelSaveOptions**.ConversionEngine()
### **New Classes**
class com.aspose.pdf.**ImportDataAction** with methods:
FileSpecification getData()
setData(FileSpecification)

class com.aspose.pdf.ExcelSaveOptions.**ConversionEngines** with field:
int LegacyEngine = 0;
int NewEngine = 1;

class com.aspose.pdf.TextEditOptions.**ClippingPathsProcessingMode** with field:
int KeepIntact = 0;
int Expand = 1;
int Remove = 2;
