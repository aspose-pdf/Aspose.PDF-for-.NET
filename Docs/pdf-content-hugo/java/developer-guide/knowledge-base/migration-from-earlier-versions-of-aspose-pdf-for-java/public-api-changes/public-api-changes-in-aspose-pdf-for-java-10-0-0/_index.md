---
title: Public API Changes in Aspose.PDF for Java 10.0.0
type: docs
weight: 90
url: /java/public-api-changes-in-aspose-pdf-for-java-10-0-0/
---

{{% alert color="primary" %}} 

This page lists the public API changes introduced in [Aspose.PDF for Java 10.0.0](http://www.aspose.com/community/files/72/java-components/aspose.pdf-for-java/entry608514.aspx). It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.PDF for Java which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

{{% /alert %}} 

**Public API and Backwards Incompatible Changes**
#### **com.aspose.pdf.facades.Form class:**
*Deprecated methods:*

- public OutputStream getDestStream() 
- public void setDestStream(OutputStream value)

*Deprecated constructor:*

- public Form(InputStream srcStream, OutputStream destStream)
#### **com.aspose.pdf.facades.PdfFileEdito class:**
*Added internal class:*

- public static class PageBreak

*Added methods:*

- public void addPageBreak(Document src, Document dest, PageBreak[] pageBreaks)
- public void addPageBreak(String src, String dest, PageBreak[] pageBreaks)
#### **com.aspose.pdf.facades.PdfFileStamp class:**
*Deprecated methods:*

- public String getInputFile() 
- public void setInputFile(String value)
- public InputStream getInputStream() 
- public void setInputStream(InputStream value)
- public String getOutputFile() 
- public void setOutputFile(String value)
- public OutputStream getOutputStream() 
- public void setOutputStream(OutputStream value)
#### **com.aspose.pdf.facades.AutoFiller class:**
*Deprecated methods:*

- public OutputStream getOutputStream() 
- public void setOutputStream(OutputStream value)
- public InputStream getInputStream() 
- public void setInputStream(InputStream value)
#### **com.aspose.pdf.facades.FormEditor class:**
*Deprecated constructors:*

- public FormEditor(IDocument document, OutputStream destStream)
- public FormEditor(IDocument document, String destFileName)
- public FormEditor(InputStream srcStream, OutputStream destStream)

h34. com.aspose.pdf.facades.PdfFileMend class:

*Deprecated constructors:*

- public PdfFileMend(IDocument document, String outputFileName)
#### **com.aspose.pdf.facades.PdfFileSecurity class:**
*Deprecated methods:*

- public void setInputStream(InputStream value)
- public void setOutputStream(OutputStream value)

*Deprecated constructors:*

- public PdfFileSecurity(InputStream inputStream, OutputStream outputStream)
#### **Added new class PdfPrintPageInfo**
#### **com.aspose.pdf.generator.legacyxmlmodel.PathArea class:**
*Added method:*

- public java.util.Map getShapes()
#### **com.aspose.pdf.generator.legacyxmlmodel.ShadingPattern class:**
*Added method:*

- public java.awt.Color getColor()
#### **com.aspose.pdf.generator.legacyxmlmodel.ShadingPatternFactory class:**
*Added method:*

- public static ShadingPattern getShadingPattern(int level,java.awt.Color color)
#### **com.aspose.pdf.Document class:**
*Added methods:*

- public boolean getAllowReusePageContent()
- public void setAllowReusePageContent(boolean value)
#### **com.aspose.pdf.Artifact class:**
*Added methods:*

- public void setImage(InputStream imageStream)
#### **com.aspose.pdf.ArtifactCollection class:**
*Added methods:*

- public java.util.List<Artifact> findByValue(String name, String expectedValue)
#### **com.aspose.pdf.BackgroundArtifact class:**
*Added methods:*

- public InputStream getBackgroundImage()
#### **com.aspose.pdf.BaseParagraph class:**
*Added methods:*

- public boolean isInLineParagraph()
- public void setInLineParagraph(boolean value)
#### **com.aspose.pdf.BaseParagraph class:**
*Changes in methods:*

- public java.awt.geom.Point2D.Float getPageSize() -> public java.awt.geom.Dimension2D getPageSize()
- public void setPageSize(java.awt.geom.Point2D.Float value) - > public void setPageSize(java.awt.geom.Dimension2D value)
#### **com.aspose.pdf.CgmLoadOptions class:**
*Changes in methods:*

- public java.awt.geom.Point2D.Float getPageSize() -> public java.awt.geom.Dimension2D getPageSize()
- public CgmLoadOptions(java.awt.geom.Point2D.Float pageSize) -> public CgmLoadOptions(java.awt.geom.Dimension2D pageSize)
#### **com.aspose.pdf.Color class:**
*Added methods:*

- public PatternColorSpace getPatternColorSpace()
- public void setPatternColorSpace(PatternColorSpace value)
#### **com.aspose.pdf.ComHelper class:**
*Added methods:*

- public Document openStream(InputStream input)
- public Document openStream(InputStream input, String password)
- public Document openStream(InputStream input, boolean isManagedStream)
- public Document openStream(InputStream input, String password, boolean isManagedStream)
- public Document openStream(InputStream input, LoadOptions options)
#### **com.aspose.pdf.ComHelper class:**
*Added constructors:*

- public ContentsAppender(XForm form)
#### **com.aspose.pdf.ComHelper class:**
*Added methods:*

- public void setCreationDate(java.util.Date value)
- public double getCreationTimeZone()
- public void setCreationTimeZone(double value)
- public double getModTimeZone()
- public void setModTimeZone(double value)
- public java.util.Date getModDate()
- public void setModDate(java.util.Date value)
#### **Added enum class com.aspose.pdf.FileEncoding**
#### **com.aspose.pdf.FileParams class:**
*Added methods:*

- public java.util.Date getCreationDate()
- public void setCreationDate(java.util.Date value)
- public java.util.Date getModDate()
- public void setModDate(java.util.Date value)

*Added constructor:*

- public FileParams(FileSpecification spec)
#### **com.aspose.pdf.FileParams class:**
*Added methods:*

- public int getEncoding()
- public void setEncoding(int value)
- public void setParams(FileParams value)
#### **com.aspose.pdf.FloatingBox class:**
*Changes:*

- public int VerticalAlignment; -> 
- public int getVerticalAlignment_Rename_Namesake() and public void setVerticalAlignment_Rename_Namesake(int value)
#### **com.aspose.pdf.IIndexBitmapConverte class:**
*Added methods:*

- public java.awt.image.BufferedImage get1BppImage(java.awt.image.BufferedImage src);
- public java.awt.image.BufferedImage get4BppImage(java.awt.image.BufferedImage src);
- public java.awt.image.BufferedImage get8BppImage(java.awt.image.BufferedImage src);
#### **com.aspose.pdf.Image class:**
*Changes:*

- public int getFileType() -> public int getFileType()
- public void setFileType(nt value) -> public void setFileType(int value)

*Added methods:*

- public boolean isBlackWhite() 
- public void setBlackWhite(boolean value)
#### **com.aspose.pdf.Layer class:**
*Added methods:*

- public java.util.List<Operator> getContents()
#### **com.aspose.pdf.LevelFormat class:**
*Changes:*

- public aspose.pdf.MarginInfo getMargin() -> public com.aspose.pdf.MarginInfo getMargin()
- public void setMargin(aspose.pdf.MarginInfo value)  -> public void setMargin(com.aspose.pdf.MarginInfo value) 
#### **Added class com.aspose.pdf.Note**
#### **com.aspose.pdf.Page class:**
*Added methods:*

- public GraphInfo getNoteLineStyle()
- public void setNoteLineStyle(GraphInfo value)
#### **com.aspose.pdf.Page class:**
*Added fields:*

- public boolean SupressErrors;
#### **com.aspose.pdf.PKCS7 Detached class:**
*Added constructor:*

- public PKCS7Detached(InputStream pfx, String password)
#### **com.aspose.pdf.SoundData class:**
*Added methods:*

- public InputStream getContents()
#### **com.aspose.pdf.TextExtractionOptions class:**
*Added methods:*

- public double getScaleFactor()
- public void setScaleFactor(double value)
#### **com.aspose.pdf.TextFragment class:**
*Added methods:*

- public Note getEndNote()
- public void setEndNote(Note value)
- public Note getFootNote()
- public void setFootNote(Note value)
#### **com.aspose.pdf.TextFragmentState class:**
*Added methods:*

- public float getCharacterSpacing() 
#### **com.aspose.pdf.TextStamp class:**
*Added methods:*

- public boolean getDraw()
- public void setDraw(boolean value)
#### **com.aspose.pdf.TextStamp class:**
*Added methods:*

- public float getCharacterSpacing() 
#### **com.aspose.pdf.TocInfo class:**
*Added methods:*

- public void setLevelIndentation(int value)
- public int getLevelIndentation()
#### **com.aspose.pdf.XImage class:**
*Added methods:*

- public boolean containsTransparency()
- public int getColorType()
