---
title: Public API Changes in Aspose.PDF for Java 10.6.0
type: docs
weight: 120
url: /java/public-api-changes-in-aspose-pdf-for-java-10-6-0/
---

{{% alert color="primary" %}} 

This page lists the public API changes introduced in [Aspose.PDF for Java 10.6.0](http://www.aspose.com/community/files/72/java-components/aspose.pdf-for-java/entry649204.aspx). It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.PDF for Java which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

{{% /alert %}} 

**Public API Changes 10.6.0**

Added classes:

- com.aspose.pdf.printer.**PrinterPaperKind**
- com.aspose.pdf.printer.**PrintPaperSourceKind**
- com.aspose.pdf.**AbsorbedCell**
- com.aspose.pdf.**AbsorbedColumn**
- com.aspose.pdf.**AbsorbedRow**
- com.aspose.pdf.**AbsorbedTable**
- com.aspose.pdf.**ITableElement**
- com.aspose.pdf.LoadOptions.**MarginsAreaUsageModes**
- com.aspose.pdf.**TableAbsorber**
- com.aspose.pdf.**TableElementCollection**

Removed clsasses:

- com.aspose.pdf.**NewParagraphPlacementInfo**

Changes in com.aspose.pdf.drawind.**Circle** class:

- public float getPosX() -> public double getPosX() 
- public void setPosX(float value) -> public void setPosX(double value)
- public float getPosY() -> public double getPosY()
- public void setPosY(float value) -> public void setPosY(double value)
- public float getRadius() -> public double getRadius()
- public void setRadius(float value) -> public void setRadius(double value)

Changes in com.aspose.pdf.drawind.**Curve** class:
Added:

- public float[] getPositionArray()
- public void setPositionArray(float[] value)

Removed:

- public float getPosition1Y()
- public void setPosition1Y(float value)
- public float getPosition2X() 
- public void setPosition2X(float value)
- public float getPosition2Y()
- public void setPosition2Y(float value)
- public float getPosition3X()
- public void setPosition3X(float value)
- public float getPosition3Y()
- public void setPosition3Y(float value)
- public float getPosition4X()
- public void setPosition4X(float value)
- public float getPosition4Y()
- public void setPosition4Y(float value)

Changes in com.aspose.pdf.drawind.**Ellipse** class:

- public Ellipse(float left, float bottom, float width, float height) -> public Ellipse(double left, double bottom, double width, double height)

Changes in com.aspose.pdf.drawing.**Graph** class:
Added:

- public GraphInfo getGraphInfo()

Removed:

- public double getSkewAngleX()
- public void setSkewAngleX(double value)
- public double getSkewAngleY()
- public void setSkewAngleY(double value)
- public double getRotationAngle() 
- public void setRotationAngle(double value)

Changes in com.aspose.pdf.**GraphInfo** class:
Added:

- public double getSkewAngleX()
- public void setSkewAngleX(double value)
- public double getSkewAngleY()
- public void setSkewAngleY(double value)
- public double getRotationAngle() 
- public void setRotationAngle(double value)
- public double getScalingRateX()
- public void setScalingRateX(double value)
- public double getScalingRateY()
- public void setScalingRateY(double value)

Changes in com.aspose.pdf.drawind.**Rectangle** class:

- public float getRadiusForRoundCorner() -> public double getRoundedCornerRadius()
- public void setRadiusForRoundCorner(float value) -> public void setRoundedCornerRadius(double value)
- public float getLeft() -> public double getLeft()
- public void setLeft(float value) -> public void setLeft(double value)
- public float getBottom() -> public double getBottom()
- public void setBottom(float value) -> public void setBottom(double value)
- public float getWidth() -> public double getWidth()
- public void setWidth(float value) -> public void setWidth(double value)
- public float getHeight() -> public double getHeight()
- public void setHeight(float value) -> public void setHeight(double value)

Added:

- public Rectangle()

Changes in com.aspose.pdf.**PdfFileEditor** class:

- public boolean concatenate(Document[] src, Document dest) -> public boolean concatenate(IDocument[] src, IDocument dest)

Added:

- public boolean getUseDiskBuffer()
- public void setUseDiskBuffer(boolean value)
- public int getConcatenationPacketSize()
- public void setConcatenationPacketSize(int value)

Changes in com.aspose.pdf.ReplaceTextStrategy.**Scope** class:

- REPLACE_FIRST -> ReplaceFirst
- REPLACE_ALL -> ReplaceAll

Class com.aspose.pdf.**ImageFormatInternal *renamed to com.aspose.pdf.*ImageType**

Changes in com.aspose.pdf.**Document** class:

- public void loadXml(String file) -> public void bindXml(String file)

Added:

- public void bindXml(String xmlFile, String xslFile)

Changes in com.aspose.pdf.**EpubLoadOptions** class:
Added field:

- public int MarginsAreaUsageMode

Changes in com.aspose.pdf.**FontAbsorber** class:
Added:

- public void visit(Document pdf,int startPage, int pageCount)

Changes in com.aspose.pdf.**Heading** class:
Added:

- public int getStartNumber()
- public void setStartNumber(int value)

Changes in com.aspose.pdf.**HtmlSaveOptions** class:
Added fields:

- public boolean SaveTransparentTexts
- public boolean SaveShadowedTextsAsTransparentTexts

Changes in com.aspose.pdf.**Image** class:
Added:

- public TextFragment getTitle()
- public void setTitle(TextFragment value)

Changes in com.aspose.pdf.**Matrix** class:
Added:

- public static Matrix scale(double x, double y)
- public Matrix add(Matrix other)

Changes in com.aspose.pdf.**Note** class:
Added:

- public Note()

Changes in com.aspose.pdf.**PageCollection** class:
Added:

- public void clear()

Changes in com.aspose.pdf.**Paragraphs** class:
Removed:

- public void add(BaseParagraph paragraph, NewParagraphPlacementInfo placementInfo)

Changes in com.aspose.pdf.**RadioButtonOptionField** class:
Added:

- public /* BoxStyle */int getStyle()
- public void setStyle(/* BoxStyle */int value)

Changes in com.aspose.pdf.**TextFragment** class:
Removed:

- public NewParagraphPlacementInfo getPlacementInfo()
- public void setPlacementInfo(NewParagraphPlacementInfo value)

Changes in com.aspose.pdf.**UnifiedSaveOptions** class:
Added field:

- public boolean TryMergeAdjacentSameBackgroundImages
