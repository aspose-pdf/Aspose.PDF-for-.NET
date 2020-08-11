---
title: Aspose.Pdf for Java 17.8 Release Notes
type: docs
weight: 50
url: /java/aspose-pdf-for-java-17-8-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-36518|DropDown value is cropped when form is flatten|Bug|
|PDFJAVA-36517|DropDown value is rendered incorrectly|Bug|
|PDFJAVA-37015|One text line is misplaced after PDF-to-HTML conversion|Bug|
|PDFJAVA-36807|Epub to PDF: java.awt.HeadlessException|Bug|
|PDFJAVA-37025|When PDF converted to PDF_A_1B, a blue color on image is different|Bug|
|PDFJAVA-36809|Image PDF to Searchable PDF - Search in output file doesn't work|Bug|
|PDFJAVA-36448|PNG to PDF conversion issue|Bug|
### **Public API Changes in Aspose.PDF for Java 17.8**


Added new class **com.aspose.pdf.DocumentFactory** with the following method:

public Document createDocument(InputStream input, LoadOptions options)

Changes in class **com.aspose.pdf.EmbeddedFileCollection**:

Added methods:
public void add(String key, FileSpecification file)
public void deleteByKey(String key)

Changes in class **com.aspose.pdf.PdfFormatConversionOptions**:

Added methods:
public String getIccProfileFileName()
public void setIccProfileFileName(String value)

Changes in class **com.aspose.pdf.RenderingOptions**:

Added methods:
public boolean getScaleImagesToFitPageWidth()
public void setScaleImagesToFitPageWidth(boolean value)
