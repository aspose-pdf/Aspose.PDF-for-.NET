---
title: Aspose.Pdf for Java 11.6.0 Release Notes
type: docs
weight: 80
url: /java/aspose-pdf-for-java-11-6-0-release-notes/
---

### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|PDFNEWJAVA-34455 |XPS to PDF conversion slow performance issue |Enhancement |
|PDFNEWJAVA-34324 |XPS to PDF: throws unknown char exception |Exception |
|PDFNEWJAVA-34427 |PCL to PDF: Unexpected font parsing exception |Exception |
|PDFNEWJAVA-35060 |PDF to HTML throws internal exception |Exception |
|PDFNEWJAVA-35280 |XFA to Static - Exception during conversion |Exception |
|PDFNEWJAVA-34647 |Signing PDF document results in incorrect Signatures |Bug |
|PDFNEWJAVA-34971 |HTML to PDF conversion does not honor horizontal line background color |Bug |
|PDFNEWJAVA-35078 |Append Html - Page Format Changes |Bug |
|PDFNEWJAVA-35103 |HTML to PDF: centered image is rendered incorrectly |Bug |
|PDFNEWJAVA-35180 |HTML to PDF: image is missing in resultant PDF document |Bug |
|PDFNEWJAVA-35446 |PDF to PDF/A - Output file is blank |Bug |
|PDFNEWJAVA-35613 |Header row styles not continuing on next page |Bug |
|PDFNEWJAVA-35190 |HTML to conversion throws ClassCastException |Bug |
|PDFNEWJAVA-35344 |XFA to Standard form: Font size and style are incorrect |Bug |
|PDFNEWJAVA-35677 |Multiple HtmlFragments inside table cell |Bug |
|PDFNEWJAVA-34930 |PDF to IMAGE: text is being rendered incorrectly |Bug |
|PDFNEWJAVA-34612 |PDF is not being converted to PDF/A_1a format |Bug |
|PDFNEWJAVA-35633 |PDF to PDF/A - Compliance issue and file contents are garbled |Bug |
|PDFNEWJAVA-35648 |XFA to standard PDF - Missing contents and formatting issues |Bug |
|PDFNEWJAVA-35679 |HOCR text and position is incorrect |Bug |
|PDFNEWJAVA-34978 |PDF Printing - Text is fuzzy in resultant file |Bug |
|PDFNEWJAVA-35527 |Text is blurred in print output |Bug |
|PDFNEWJAVA-35603 |PDF to PS - Resultant file is not correct |Bug |
### **Public API Changes**
Added new **com.aspose.pdf.ConvertTransparencyAction** class with constructor:
public XfaParserOptions(Dimension2D pageSize)
and methods:

- public URI getBasePath()
- public void setBasePath(URI value)
- public Dimension2D getPageSize()
- public void setPageSize(Dimension2D value)
- public boolean getSigned()
- public void setSigned(boolean value)

Changes in class **com.aspose.pdf.TextFormattingMode:** 
added new constant:

- public static final int MemorySaving = 2;

Changes in class **com.aspose.pdf.Table:** 
added methods:

- public boolean isBordersIncluded()
- public void setBordersIncluded(boolean value)

Changes in class **com.aspose.pdf.PageNumberStamp:** 
added methods:

- public NumberingStyle int getNumberingStyle()
- public void setNumberingStyle(NumberingStyle int value)

Changes in class **com.aspose.pdf.PdfFileStamp:** 
added methods:

- public NumberingStyle int getNumberingStyle()
- public void setNumberingStyle(NumberingStyle int value)

Changes in class **com.aspose.pdf.XImageCollection:** 
added methods:

- public void addWithImageFilterType(InputStream image, ImageFilterType int filterType)
- public void deleteByIndex(int index)

Changes in class **com.aspose.pdf.OperatorCollection:** 
added method:

- public boolean isFastTextExtractionMode()

Changes in class **com.aspose.pdf.LightweightOperatorCollection:** 
added method:

- public boolean isFastTextExtractionMode()

Changes in class **com.aspose.pdf.BaseOperatorCollection:** 
added method:

- public boolean isFastTextExtractionMode()

Changes in class **com.aspose.pdf.devices.DocumentDevice:** 
added method:

- public void binarizeBradley(InputStream inputImageStream, OutputStream outputImageStream, double threshold)

Changes in class **com.aspose.pdf.InvalidCgmFileFormatException:**

- moved to package com.aspose.pdf.exceptions.*

Added new abstract **com.aspose.pdf.IColorSpaceConversionStrategy** class
with method:
public void convert(Page page);

Changes in class **com.aspose.pdf.Document:** 
added method:

- public boolean convert(String outputLogFileName, PdfFormat int format, ConvertErrorAction int action, ConvertTransparencyAction int transparencyAction)

Added new enum **com.aspose.pdf.ConvertTransparencyAction** class
with constants:

- public static final int Default = 0;
- public static final int Mask = 1;

Changes in class **com.aspose.pdf.CompositingParameters:** 
added constructor:

- public CompositingParameters(BlendMode int blendMode, ImageFilterType int filterType, boolean isMasked)
  and method:
- public boolean isMasked()
