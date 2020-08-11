---
title: Aspose.Pdf for Java 12.0.0 Release Notes
type: docs
weight: 40
url: /java/aspose-pdf-for-java-12-0-0-release-notes/
---

### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|PDFNEWJAVA-34945 |PDF to DOC: Set default ImageResolutions to 300 dpi |Enhancement |
|PDFNEWJAVA-35581 |PDF to PDF/A_3a - Resultant file is not PDF/A compliant |Bug |
|PDFNEWJAVA-35854 |PDF to DOC - Space between words is removed |Bug |
|PDFNEWJAVA-35061 |Aspose.PDF for Java v10+ do not work on HPUX |Bug |
|PDFJAVA-36064 |License Issue : The signature is invalid |Bug |
|PDFNEWJAVA-34923 |Aspose.PDf for Java throws exception while using it in OSGI Container |Bug |
|PDFNEWJAVA-35283 |NullPointerException: when printing as background service |Bug |
|PDFNEWJAVA-34373 |Unable to find text in PDF file |Bug |
|PDFNEWJAVA-35567 |Saving Nested table hangs on save() |Bug |
|PDFNEWJAVA-35392 |PDF to DOCX - Spaces between words in output file are missing |Bug |
|PDFNEWJAVA-34336 |Issue Applying the license in start up servlet init() method |Bug |
|PDFNEWJAVA-35857 |XML to PDF: Accessing TextFragement/TextSegment elements inside Row element throws NPE |Bug |
|PDFNEWJAVA-34470 |PDF to DOC - Conversion taking too much time |Bug |
|PDFNEWJAVA-35790 |Content redaction does not work properly |Bug |
|PDFNEWJAVA-35189 |PDF to DOC: Invalid characters are rendered |Bug |
|PDFNEWJAVA-34561 |HTML to PDF - Exception during conversion |Bug |
|PDFNEWJAVA-35655 |PDF to PDF/A_1b - The alignment of text is disturbed |Bug |
|PDFNEWJAVA-35426 |PDF to PDFA1a: Image background color turns into black |Bug |
|PDFNEWJAVA-35429 |PDF to PDFA1a: a circle turns into square in resultant PDFA1a |Bug |
|PDFJAVA-35959 |PDF to PDFA converts highlight annotation into black rectangle |Bug |
|PDFJAVA-35960 |PDF to XPS conversion loses the background image |Bug |
|PDFNEWJAVA-35850 |PDF to XPS conversion throws ArrayIndexOutOfBound Exception |Bug |
### **Public API Changes**
Changes in class **com.aspose.pdf.AnnotationSelector**:

added method:

- public void visit(WatermarkAnnotation watermark)

Changes in class **com.aspose.pdf.Color**:

added methods:

- public void setTextAndState(String text, TextState textState)
- public void setLinesAndState(String[] text, TextState textState)
- public boolean isBackground()
- public void setBackground(boolean value)

Changes in class **com.aspose.pdf.Color**:

added default constructor:

- public Color()

Changes in class **com.aspose.pdf.DocSaveOptions**:

added methods:

- public boolean isUseEmbeddedTrueTypeFonts()
- public void setUseEmbeddedTrueTypeFonts(boolean value)

Changes in class **com.aspose.pdf.Document.OptimizationOptions**:

added methods:

- public int getResolution()
- public void setResolution(int dpi)
- public int getMaximumImageDimension()
- public void setMaximumImageDimension(int dimension)

Changes in class **com.aspose.pdf.Rectangle**:

added method:

- public boolean isIntersect(Rectangle otherRect)

Changes in class **com.aspose.pdf.TextFragment**:

added methods:

- public int getWrapLinesCount()
- public void setWrapLinesCount(int value)

Changes in class **com.aspose.pdf.TextSegment**:

deleted method:

- public static String myHtmlEncode(String value)

Added new class **com.aspose.pdf.drawing.WatermarkAnnotation extends Annotation** 
with the following constructors and methods:

- public WatermarkAnnotation(Page page, Rectangle rect)
- public void accept(AnnotationSelector visitor)
- public /* AnnotationType */int getAnnotationType()
- public FixedPrint getFixedPrint()
- public void setText(FormattedText text)
- public void setTextAndState(String[] text, TextState textState)

Added new class **com.aspose.pdf.drawing.GradientAxialShading extends PatternColorSpace** 
with the following constructors and methods:

- public GradientAxialShading()
- public GradientAxialShading(Color startColor, Color endColor)
- public Point getEnd()
- public void setEnd(Point value)
- public Color getEndColor()
- public void setEndColor(Color value)
- public Point getStart()
- public void setStart(Point value)
- public Color getStartColor()
- public void setStartColor(Color value)

Added new class **com.aspose.pdf.FixedPrint** 
with the following methods:

- public double getHorizontalTranslation()
- public void setHorizontalTranslation(double value)
- public Matrix getMatrix()
- public void setMatrix(Matrix value)
- public double getVerticalTranslation()
- public void setVerticalTranslation(double value)
