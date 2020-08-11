---
title: Aspose.Pdf for Java 17.4 Release Notes
type: docs
weight: 90
url: /java/aspose-pdf-for-java-17-4-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-36644|Exception throws when using Pdf Digital signature|Exception|
|PDFJAVA-34001|API reference is not upto date|Bug|
|PDFJAVA-34533|PDF to PDFA: compliance failure error messages details|Bug|
|PDFJAVA-34651|PDF to TIFF: output image is jumbled|Bug|
|PDFJAVA-35178|PDF to PDF/A - Resultant file size is significantly increased|Bug|
|PDFJAVA-35356|Incorrect output when Importing XML Data into XFA Document|Bug|
|PDFJAVA-35405|Corrupted watermark when using API in trial mode|Bug|
|PDFJAVA-35417|PDF to JPEG - Resultant image is not correct|Bug|
|PDFJAVA-35421|Incorrect results while Importing multiline annotation via XFDF|Bug|
|PDFJAVA-35427|PDF to PDFA1a: Background color is missing|Bug|
|PDFJAVA-35856|PDF to PDF/A - Resultant file is not compliant|Bug|
|PDFJAVA-35876|HtmlFragment is not honoring hyperlink tag|Bug|
|PDFJAVA-35977|Incorrect ColorType information is being returned|Bug|
|PDFJAVA-35998|PDF to PNG: data is missing in resultant image|Bug|
|PDFJAVA-36616|Forms.PKCS1 locks certificate file|Bug|
|PDFJAVA-35675|PDF to PDF/A - Resultant file is not compliant|Bug|
### **Public API Changes in Aspose.PDF for Java 17.4**


Changes in class **com.aspose.pdf.ColorType:**

**Added method:** 
public static String getName(int value)

**Added new exception class:**

com.aspose.pdf.exceptions.**FontEmbeddingException**

Added new interface **com.aspose.pdf.IFontOptions** with the following methods

public boolean getNotifyAboutFontEmbeddingError()
public void setNotifyAboutFontEmbeddingError(boolean value)

Changes in class **com.aspose.pdf.Font**:

Added methods:
public IFontOptions getFontOptions()
public String getLastFontEmbeddingError()
