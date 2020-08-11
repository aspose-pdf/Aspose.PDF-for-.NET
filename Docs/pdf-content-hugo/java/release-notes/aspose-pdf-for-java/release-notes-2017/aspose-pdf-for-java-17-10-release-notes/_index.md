---
title: Aspose.Pdf for Java 17.10 Release Notes
type: docs
weight: 30
url: /java/aspose-pdf-for-java-17-10-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-34776|PDF to Image conversion is very slow|Enhancement|
|PDFJAVA-36570|PDF TO PPTX - spacing issue|Bug|
|PDFJAVA-36260|PDF to PDF/A_1b - Text is garbled in resultant file|Bug|
|PDFJAVA-36435|PDF to pptx (java) conversion issues|Bug|
|PDFJAVA-37099|Too much memory usage when calling delegate CallBackGetHocr|Bug|
|PDFJAVA-37154|An exception has thrown in a multithreaded environment|Bug|
|PDFJAVA-36847|Foreign Language Characters get mangled while Text Extraction using HOCR|Bug|
|PDFJAVA-37068|Unable to supply the license outside of the callable|Bug|
|PDFJAVA-36819|PDF to DOCX - Content is missing in the resultant file|Bug|
### **Public API changes**
Changes in class **com.aspose.pdf.ViewerPreference** 
Added field:
public static final int SIMPLEX = 4194304;
public static final int DUPLEX_FLIP_SHORT_EDGE = 8388608;
public static final int DUPLEX_FLIP_LONG_EDGE = 16777216;

Changes in class **com.aspose.pdf.Form** 
Added method:
public void setCalculatedFields( java.util.List<Field> value)

Changes in interface **com.aspose.pdf.IDocument** 
Added method:
public /* PrintDuplex */int getDuplex();
public void setDuplex(/* PrintDuplex */int value);
public boolean convert(Document.CallBackGetHocr callback, boolean isTestVisible, boolean isOriginalImage);

Changes in class **com.aspose.pdf.Document** 
Added method:
public /* PrintDuplex */int getDuplex()
public void setDuplex(/* PrintDuplex */int value)
public boolean convert(Document.CallBackGetHocr callback, boolean isTestVisible, boolean isOriginalImage)

Changes in class **com.aspose.pdf.Image** 
Added method:
public boolean isApplyResolution()
public void setApplyResolution(boolean value)

Added new enum class **com.aspose.pdf.PrintDuplex** with the following fields:
public static final int Simplex = 0;
public static final int DuplexFlipShortEdge = 1;
public static final int DuplexFlipLongEdge = 2;

Changes in class **com.aspose.pdf.XFA** 
Added method:
public String tryGetTemplateString(String value)
