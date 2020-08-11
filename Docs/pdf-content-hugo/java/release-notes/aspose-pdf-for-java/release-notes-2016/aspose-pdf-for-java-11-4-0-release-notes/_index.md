---
title: Aspose.Pdf for Java 11.4.0 Release Notes
type: docs
weight: 100
url: /java/aspose-pdf-for-java-11-4-0-release-notes/
---

### **New Features**
- Add and search hidden text in PDF document
- Rotate method is added for FreeTextAnnotation
- Using same Page object after processPragraphs() call
### **Other Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|PDFNEWJAVA-35202 |PDF Text extraction takes several minutes, with 100% CPU |Enhancement |
|PDFNEWJAVA-33212 |Image Inserted to PDF is abit blur |Enhancement |
|PDFNEWJAVA-35556 |HTML to PDFconversion throws internal exception |Exception |
|PDFNEWJAVA-35534 |PDF to PDFA conversion throws NullPointerException |Exception|
|PDFNEWJAVA-34838 |TIFF to PDF conversion throws TiffImageException |Exception |
|PDFNEWJAVA-34060 |OutOfMemoryError when printing PDF file |Exception |
|PDFNEWJAVA-35187 |PDF to PNG conversion throws java.lang.InternalError exception |Exception |
|PDFNEWJAVA-35042 |TIFF to PDF - Conversion is failing |Bug |
|PDFNEWJAVA-34677 |XPS to PDF: Text missing in output PDF |Bug |
|PDFNEWJAVA-34953 |When printing PDF file, the font quality is dropped |Bug |
|PDFNEWJAVA-34003 |PDF print - resultant printout is not correct |Bug |
|PDFNEWJAVA-34954 |PDF to PS conversion - font quality is dropped |Bug |
|PDFNEWJAVA-35259 |PDF to PDFA3a conversion fails compliance test - AnalyseMediendatenbank.pdf |Bug |
|PDFNEWJAVA-35255 |PDF to PDF/A_2a - Resultant file is not PDF/A_2a compliant |Bug |
|PDFNEWJAVA-34996 |PDF to HTML - Conversion process takes much time |Bug |
|PDFNEWJAVA-35553 |PDF to HTML - Conversion process takes much time |Bug |
|PDFNEWJAVA-35554 |PDF to HTML - Conversion process takes 1 minute |Bug |
|PDFNEWJAVA-34635 |PdfViewer: print quality is poor |Bug |
|PDFNEWJAVA-35303 |PDF to HTML - Conversion is taking too much time |Bug |
|PDFNEWJAVA-34041 |Images not getting delete when using ImagePlacementAbsorber |Bug |
|PDFNEWJAVA-34207 |PdfViewer is printing blury image. |Bug |
|PDFNEWJAVA-34092 |Second occurrence of a text is not being searched with regular expression and replaced |Bug |
|PDFNEWJAVA-34113 |XML Import - not all form fields are being populated |Bug |
|PDFNEWJAVA-34126 |TextFragmentAbsorber does not replace flatten form text |Bug |
|PDFNEWJAVA-35107 |Printing quality of resultant file is not correct |Bug |
|PDFNEWJAVA-34010 |PDF to PNG - resultant image is not correct |Bug |
|PDFNEWJAVA-34781 |PDF to PDFA1b: output PDFA1b fails compliance verification |Bug |
### **Public API Changes**
**class com.aspose.pdf.FreeTextAnnotation:**

*Added methods:*

- public com.aspose.pdf.Rotation value int getRotate()
- public void setRotate(com.aspose.pdf.Rotation) int value

**class com.aspose.pdf.Rectangle:**

*Added method:*

- public void rotateAngle(int angle)

**class com.aspose.pdf.MemoryCleaner:**

*Added method:*

- public void clearAllTempFiles()

**class com.aspose.pdf.Paragraphs:**

*Added method:*

- public Object deepClone()

**class com.aspose.pdf.RenderingOptions:**

*Added methods:*

- public void setWidthExtraUnits(float value)
- public float getWidthExtraUnits()

**class com.aspose.pdf.TextFragmentState:**

*Added methods:*

- public boolean isInvisible()
- public void setInvisible(boolean value)

**class com.aspose.pdf.TextState:**

*Added methods:*

- public boolean isInvisible()
- public void setInvisible(boolean value)

**class com.aspose.pdf.LightweightOperatorCollection:**

*Added method:*

- public boolean isEmpty()

**class com.aspose.pdf.OperatorCollection:**

*Added method:*

- public boolean isEmpty()

**class com.aspose.pdf.PageCollection:**

*Added method:*

- public boolean isEmpty()
