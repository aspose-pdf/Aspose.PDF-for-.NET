---
title: Aspose.Pdf for Java 17.9 Release Notes
type: docs
weight: 40
url: /java/aspose-pdf-for-java-17-9-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-36564|JPG to PDF increased PDF file size|Bug|
|PDFJAVA-37076|Significant performance decrease issue regarding memory usage and time consumption.|Bug|
|PDFJAVA-35731|XPS to PDF: performance issue|Bug|
|PDFJAVA-35944|PDF to HTML: some text become smaller|Bug|
|PDFJAVA-36840|Using CallBackGetHocr results with blank image|Bug|
|PDFJAVA-36821|API is throwing java.awt.HeadlessException Exception at Document load|Bug|
|PDFJAVA-37106|PDF to DOCX - incorrect rendering of the Hebrew text|Bug|
|PDFJAVA-37084|Evaluation mark is being added in output while using valid license|Bug|
|PDFJAVA-36710|PDF to PDF/A - compliance error: Real value out of range|Bug|
|PDFJAVA-36268|TIFF to PDF - Image is darker in shade|Bug|
### **Public API Changes in Aspose.PDF for Java 17.9**


Changes in class **com.aspose.pdf.Collection**:

Added method:
public String getDefaultEntry()

Changes in class **com.aspose.pdf.Document**:

Added method:
public boolean check(boolean doRepair)

Changes in interface **com.aspose.pdf.IDocument**:

Added method:
public boolean check(boolean doRepair);

Changes in class **com.aspose.pdf.DocumentFactory**:

Added methods:
public Document createDocument()
public Document createDocument(InputStream input)
public Document createDocument(InputStream input, String password)
public Document createDocument(String fileName)

Changes in class **com.aspose.pdf.EmbeddedFileCollection**:

Added methods:
public void add(String key, FileSpecification file)
public void deleteByKey(String key)

Changes in class **com.aspose.pdf.HtmlSaveOptions**:

Added methods:
public int getImageResolution()
public void setImageResolution(int value)

Changes in class **com.aspose.pdf.PdfFormatConversionOptions**:

Added methods:
public String getIccProfileFileName()
public void setIccProfileFileName(String value)

Changes in class **com.aspose.pdf.PptxSaveOptions**:

Added methods:
public boolean getSlidesAsImages()
public void setSlidesAsImages(boolean value)
public boolean getSeparateImages()
public void setSeparateImages(boolean value)

Changes in class **com.aspose.pdf.RenderingOptions**:

Added methods:
public boolean getScaleImagesToFitPageWidth()
public void setScaleImagesToFitPageWidth(boolean value)
public boolean getInterpolationHighQuality()
public void setInterpolationHighQuality(boolean value)

Changes in class **com.aspose.pdf.Table**:

Removed internal methods from public api:
com.aspose.pdf.Table.getParentTable
com.aspose.pdf.Table.setParentTable(Table)
