---
title: Aspose.Pdf for Java 11.7.0 Release Notes
type: docs
weight: 70
url: /java/aspose-pdf-for-java-11-7-0-release-notes/
---

### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|PDFNEWJAVA-34913 |PDF to PNG - conversion process takes too much time |Enhancement |
|PDFNEWJAVA-34818 |PDF to HTML - Lines width issues |Bug |
|PDFNEWJAVA-34957 |HTML to PDF results into incorrect output |Bug |
|PDFNEWJAVA-35583 |PDF to PDF/A_3a - Resultant file is not PDFA compliant |Bug |
|PDFNEWJAVA-35729 |PDF to PDF/A - Resultant file is not PDFA compliant |Bug |
|PDFNEWJAVA-34396 |HTML to PDF - Formatting issues in resultant file |Bug |
|PDFNEWJAVA-35224 |PDF to HTML - Exception during conversion process |Bug |
|PDFNEWJAVA-35329 |API throws NullPointerException upon page copy |Bug |
|PDFNEWJAVA-35510 |PDF to DOC - Blank page being appended and contents in footer are missing |Bug |
|PDFNEWJAVA-35564 |PDF to PDFA conversion throws internal Exception |Bug |
|PDFNEWJAVA-35608 |SVG to PDF - SVG image is not appearing in PDF file |Bug |
|PDFNEWJAVA-35641 |PDF to DOCX - Field value appears in subsequent line |Bug |
|PDFNEWJAVA-35736 |HTMl to PDF - Exception during conversion |Bug |
|PDFNEWJAVA-35765 |HTML to PDF: formatting issue |Bug |
|PDFNEWJAVA-35602 |PDF to DOCX - Contents are not appearing properly |Bug |
|PDFNEWJAVA-35776 |PDF to HTML: extra white lines on background - regression |Bug |
|PDFNEWJAVA-34531 |Exception while loading PDF file in multiple threads |Bug |
|PDFNEWJAVA-35257 |PDF to PDFA2a - compliance failure |Bug |
|PDFNEWJAVA-35264 |PDF to PDFA3a - conversion fails compliance |Bug |
|PDFNEWJAVA-35631 |HTML to PDF - Page contents are overlapping eachother |Bug |
|PDFNEWJAVA-35822 |PDF to PDF/A - Header in Resultant file gets corrupted |Bug |
|PDFNEWJAVA-35805 |Redaction throws NullPointer Exception |Bug |
|PDFNEWJAVA-34859 |HTML to PDF is not working in multithreading |Bug |
|PDFNEWJAVA-35565 |Exception during PDF printing |Bug |
|PDFNEWJAVA-35330|PDF to HTML: some text is missing in resultant HTML|Bug |
|PDFNEWJAVA-35520|PDF to PDFA2b: Text overlapping and spacing issue|Bug |
|PDFJAVA-35948 |PDF to PDFA1b: resultant PDFA document failing the compliance |Bug |
|PDFJAVA-35875 |HTML to PDF: incorrect text position |Bug |
|PDFJAVA-35882 |PDF to DOCX - Tab indent is being ignored |Bug |
### **Public API Changes**
Changes in class **com.aspose.pdf.PdfAction:** 
moved method:

- public void execute(IDocument document)

Changes in class **com.aspose.pdf.ExplicitDestination:** 
moved method:

- com.aspose.pdf.ExplicitDestination.createDestination(com.aspose.pdf.Document,int,int,double[])

Changes in class **com.aspose.pdf.XYZExplicitDestination:** 
added methods:

- public static XYZExplicitDestination createDestination(Page page, double left, double top, double zoom, boolean considerRotation)
- public static XYZExplicitDestination createDestinationToUpperLeftCorner(Page page, double zoom)
- public static XYZExplicitDestination createDestinationToUpperLeftCorner(Page page)

Changes in class **com.aspose.pdf.ColumnAdjustment:** 
added field:

- public static final int AutoFitToWindow = 2;

Changes in class **com.aspose.pdf.Document:** 
added method:

- public boolean convert(String outputLogFileName, /* PdfFormat **/int format, /** ConvertErrorAction **/int action, /** ConvertTransparencyAction */int transparencyAction)

Changes in class **com.aspose.pdf.PdfFileStamp:** 
added methods:

- public /* NumberingStyle */int getNumberingStyle()
- public void setNumberingStyle(/* NumberingStyle */int value)

Changes in class **com.aspose.pdf.HtmlSaveOptions:** 
added methods:

- public boolean getUseZOrder()
- public void setUseZOrder(boolean value)
- public boolean getConvertMarkedContentToLayers()
- public void setConvertMarkedContentToLayers(boolean value)
- public float getMinimalLineWidth()
- public void setMinimalLineWidth(float value)
- public boolean getPreventGlyphsGrouping()
- public void setPreventGlyphsGrouping(boolean value)

Changes in class **com.aspose.pdf.LaTeXSaveOptions:** 
added methods:

- public int getPagesCount()
- public void setPagesCount(int value)

Added new class **com.aspose.pdf.PdfFormatConversionOptions** with the following structure:

enum:

- internal enum class PuaProcessingStrategy with constants (None = 0; SurroundPuaTextWithEmptyActualText = 1;SubstitutePuaSymbols = 2; )
- internal enum class SegmentAlignStrategy with constants (None = 0; RestoreSegmentBounds = 1; )

constructors:

- public PdfFormatConversionOptions(/* PdfFormat */int format)
- public PdfFormatConversionOptions(/* PdfFormat **/int format, /** ConvertErrorAction */int action)
- public PdfFormatConversionOptions(OutputStream outputLogStream, /* PdfFormat **/int format, /** ConvertErrorAction */int action)
- public PdfFormatConversionOptions(String outputLogFileName, /* PdfFormat */int format)
- public PdfFormatConversionOptions(String outputLogFileName, /* PdfFormat **/int format, /** ConvertErrorAction */int action)
- public PdfFormatConversionOptions(String outputLogFileName, /* PdfFormat **/int format, /** ConvertErrorAction **/int action, /** ConvertTransparencyAction*/int transparencyAction)

methods:

- public boolean getAlignText()
- public void setAlignText(boolean value)
- public /* ConvertErrorAction */int getErrorAction()
- public void setErrorAction(/* ConvertErrorAction */int value)
- public /* PdfFormat */int getFormat()
- public void setFormat(/* PdfFormat */int value)
- public String getLogFileName()
- public void setLogFileName(String value)
- public OutputStream getLogStream()
- public void setLogStream(OutputStream value)
- public /* PuaProcessingStrategy */int getPuaTextProcessingStrategy()
- public void setPuaTextProcessingStrategy(/* PuaProcessingStrategy */int value)
- public /* ConvertTransparencyAction */int getTransparencyAction()
- public void setTransparencyAction(/* ConvertTransparencyAction */int value)
- public static PdfFormatConversionOptions getDefault()

field:

- public /* SegmentAlignStrategy */byte AlignStrategy;
