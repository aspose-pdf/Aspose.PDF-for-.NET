---
title: Aspose.Pdf for Android via Java 17.12 Release Notes
type: docs
weight: 10
url: /java/aspose-pdf-for-android-via-java-17-12-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFANDROID-487|Implementation com.aspose.pdf.TableAbsorber|New Feature|
|PDFANDROID-493|PDF to EXCEL conversion support|New Feature|
|PDFANDROID-491|Handle extracted text based on columns|New Feature|
|PDFANDROID-499|PatternColorSpace support in new generator|New Feature|
|PDFANDROID-500|Checking the status of Concatenation|New Feature|
|PDFANDROID-486|java.lang.NullPointerException when creating com.aspose.pdf.engine.commondata.text.segmenting.TextSegmenter|Bug|
|PDFANDROID-490|Adopted TextFragmentCollection for Java Iterable interface"|Bug|
|PDFANDROID-492|Pdf to text: space between text increased|Bug|
|PDFANDROID-494|The extracted text from pdf is incorrect|Bug|
## **Public API Changes**
Added new class **com.aspose.pdf.AbsorbedCell** 
methods:

- com.aspose.pdf.AbsorbedCell.getTextFragments
- com.aspose.pdf.AbsorbedCell.getRectangle

Added new class **com.aspose.pdf.AbsorbedRow** 
methods:

- com.aspose.pdf.AbsorbedRow.getCellList
- com.aspose.pdf.AbsorbedRow.getRectangle

Added new class **com.aspose.pdf.AbsorbedTable** 
methods:

- com.aspose.pdf.AbsorbedTable.getRowList
- com.aspose.pdf.AbsorbedTable.getRectangle
- com.aspose.pdf.AbsorbedTable.getPageNum

Changes in **class com.aspose.pdf.Color** 
Added constructors:

- com.aspose.pdf.Color

Added methods:

- com.aspose.pdf.Color.getA
- com.aspose.pdf.Color.deepClone
- com.aspose.pdf.Color.fromArgb(int,int,int,int)
- com.aspose.pdf.Color.getPatternColorSpace
- com.aspose.pdf.Color.setPatternColorSpace(PatternColorSpace)

Changes in class **com.aspose.pdf.drawing.Arc** 
Changes in constructor:

- com.aspose.pdf.drawing.Arc.#ctor(float,float,float,float,float) 
  has been changed to 
  com.aspose.pdf.drawing.Arc.#ctor(double,double,double,double,double)

Changes in methods:

- com.aspose.pdf.drawing.Arc.setPosX(float) 
  has been changed to 
  com.aspose.pdf.drawing.Arc.setPosX(double)
- com.aspose.pdf.drawing.Arc.setPosY(float) 
  has been changed to 
  com.aspose.pdf.drawing.Arc.setPosY(double)
- com.aspose.pdf.drawing.Arc.setRadius(float) 
  has been changed to 
  com.aspose.pdf.drawing.Arc.setRadius(double)
- com.aspose.pdf.drawing.Arc.setAlpha(float) 
  has been changed to 
  com.aspose.pdf.drawing.Arc.setAlpha(double)
- com.aspose.pdf.drawing.Arc.setBeta(float) 
  has been changed to 
  com.aspose.pdf.drawing.Arc.setBeta(double)

Changes in class **com.aspose.pdf.drawing.Circle** 
Changes in constructor:

- com.aspose.pdf.drawing.Circle

Changes in methods:

- com.aspose.pdf.drawing.Circle.setPosX(float)
  has been changed to
  com.aspose.pdf.drawing.Circle.setPosX(double)
- com.aspose.pdf.drawing.Circle.setPosY(float) 
  has been changed to 
  com.aspose.pdf.drawing.Circle.setPosY(double)

Added constructors:

- com.aspose.pdf.drawing.Curve

Added methods:

- com.aspose.pdf.drawing.Curve.setPositionArray(float[])
- com.aspose.pdf.drawing.Curve.getPositionArray

Removed methods:

- com.aspose.pdf.drawing.Curve.getPosition1X
- com.aspose.pdf.drawing.Curve.setPosition1X(float)
- com.aspose.pdf.drawing.Curve.getPosition1Y
- com.aspose.pdf.drawing.Curve.setPosition1Y(float)
- com.aspose.pdf.drawing.Curve.getPosition2X
- com.aspose.pdf.drawing.Curve.setPosition2X(float)
- com.aspose.pdf.drawing.Curve.getPosition2Y
- com.aspose.pdf.drawing.Curve.setPosition2Y(float)
- com.aspose.pdf.drawing.Curve.getPosition3X
- com.aspose.pdf.drawing.Curve.setPosition3X(float)
- com.aspose.pdf.drawing.Curve.getPosition3Y
- com.aspose.pdf.drawing.Curve.setPosition3Y(float)
- com.aspose.pdf.drawing.Curve.getPosition4X
- com.aspose.pdf.drawing.Curve.setPosition4X(float)
- com.aspose.pdf.drawing.Curve.getPosition4Y
- com.aspose.pdf.drawing.Curve.setPosition4Y(float)

Added new class **com.aspose.pdf.drawing.Ellipse** 
constructors:

- com.aspose.pdf.drawing.Ellipse
- com.aspose.pdf.drawing.Ellipse(double,double,double,double)

methods:

- com.aspose.pdf.drawing.Ellipse.getLeft
- com.aspose.pdf.drawing.Ellipse.setLeft(double)
- com.aspose.pdf.drawing.Ellipse.getBottom
- com.aspose.pdf.drawing.Ellipse.setBottom(double)
- com.aspose.pdf.drawing.Ellipse.getWidth
- com.aspose.pdf.drawing.Ellipse.setWidth(double)
- com.aspose.pdf.drawing.Ellipse.getHeight
- com.aspose.pdf.drawing.Ellipse.setHeight(double)

Added new class **com.aspose.pdf.drawing.GradientAxialShading** 
constructors:

- com.aspose.pdf.drawing.GradientAxialShading
- com.aspose.pdf.drawing.GradientAxialShading(Color,Color)

methods:

- com.aspose.pdf.drawing.GradientAxialShading.getStart
- com.aspose.pdf.drawing.GradientAxialShading.setStart(Point)
- com.aspose.pdf.drawing.GradientAxialShading.getEnd
- com.aspose.pdf.drawing.GradientAxialShading.setEnd(Point)
- com.aspose.pdf.drawing.GradientAxialShading.getStartColor
- com.aspose.pdf.drawing.GradientAxialShading.setStartColor(Color)
- com.aspose.pdf.drawing.GradientAxialShading.getEndColor
- com.aspose.pdf.drawing.GradientAxialShading.setEndColor(Color)

Changes in class **com.aspose.pdf.drawing.Graph** 
Added methods:

- com.aspose.pdf.drawing.Graph.getBorder
- com.aspose.pdf.drawing.Graph.setBorder(BorderInfo)
- com.aspose.pdf.drawing.Graph.isChangePosition
- com.aspose.pdf.drawing.Graph.setChangePosition(boolean)
- com.aspose.pdf.drawing.Graph.getLeft
- com.aspose.pdf.drawing.Graph.setLeft(double)
- com.aspose.pdf.drawing.Graph.getTop
- com.aspose.pdf.drawing.Graph.setTop(double)
- com.aspose.pdf.drawing.Graph.getShapes
- com.aspose.pdf.drawing.Graph.deepClone

Changes in methods:

- com.aspose.pdf.drawing.Graph.setShapes(java.util.List) 
  has been changed to 
  com.aspose.pdf.drawing.Graph.setShapes(java.util.List,Shape)
- com.aspose.pdf.drawing.Graph.setTitle(String) 
  has been changed to 
  com.aspose.pdf.drawing.Graph.setTitle(TextFragment)
- com.aspose.pdf.drawing.Graph.setWidth(float) 
  has been changed to
  com.aspose.pdf.drawing.Graph.setWidth(double)
- com.aspose.pdf.drawing.Graph.setHeight(float) 
  has been changed to 
  com.aspose.pdf.drawing.Graph.setHeight(double)

Removed methods:

- com.aspose.pdf.drawing.Graph.process(double[],double[],ArrayList)

Changes in class **com.aspose.pdf.drawing.Line** 
Added constructors:

- com.aspose.pdf.drawing.Line

Changes in class **com.aspose.pdf.drawing.Path** 
Added constructors:

- com.aspose.pdf.drawing.Path
- com.aspose.pdf.drawing.Path(Shape[])

Added methods:

- com.aspose.pdf.drawing.Path.getShapes

Changes in class **com.aspose.pdf.drawing.Rectangle** 
Added constructors:

- com.aspose.pdf.drawing.Rectangle

Added methods:

- com.aspose.pdf.drawing.Rectangle.getRoundedCornerRadius
- com.aspose.pdf.drawing.Rectangle.setRoundedCornerRadius(double)

Changes in methods:

- com.aspose.pdf.drawing.Rectangle.setLeft(float) 
  has been changed to 
  com.aspose.pdf.drawing.Rectangle.setLeft(double)
- com.aspose.pdf.drawing.Rectangle.setWidth(float) 
  has been changed to 
  com.aspose.pdf.drawing.Rectangle.setWidth(double)
- com.aspose.pdf.drawing.Rectangle.setHeight(float) 
  has been changed to 
  com.aspose.pdf.drawing.Rectangle.setHeight(double)

Added new class **com.aspose.pdf.drawing.Shape** 
methods:

- com.aspose.pdf.drawing.Shape.getText
- com.aspose.pdf.drawing.Shape.setText(TextFragment)

Changes in interface **com.aspose.pdf.facades.IPdfFileEditor** 
Added methods:

- com.aspose.pdf.facades.IPdfFileEditor.splitToPages(String,String)
- com.aspose.pdf.facades.IPdfFileEditor.splitToPages(InputStream,String)

Changes in methods:

- com.aspose.pdf.facades.IPdfFileEditor.resizeContentsPct(Stream,Stream,int[],double,double) 
  has been changed to 
  com.aspose.pdf.facades.IPdfFileEditor.resizeContentsPct(InputStream,OutputStream,int[],double,double)
- com.aspose.pdf.facades.IPdfFileEditor.resizeContents(Stream,Stream,int[],double,double)
  has been changed to 
  com.aspose.pdf.facades.IPdfFileEditor.resizeContents(InputStream,OutputStream,int[],double,double)
- com.aspose.pdf.facades.IPdfFileEditor.addMargins(Stream,Stream,int[],double,double,double,double) 
  has been changed to 
  com.aspose.pdf.facades.IPdfFileEditor.addMargins(InputStream,OutputStream,int[],double,double,double,double)
- com.aspose.pdf.facades.IPdfFileEditor.addMarginsPct(Stream,Stream,int[],double,double,double,double) 
  has been changed to 
  com.aspose.pdf.facades.IPdfFileEditor.addMarginsPct(InputStream,OutputStream,int[],double,double,double,double)

Removed fields:

- com.aspose.pdf.facades.IPdfFileEditor.E_EMPTY_PAGE_RANGE
- com.aspose.pdf.facades.IPdfFileEditor.E_SMALL_PAGE_RANGE
- com.aspose.pdf.facades.IPdfFileEditor.E_WRONG_PAGE_RANGE

Changes in class **com.aspose.pdf.facades.IPdfFileEditor** 
Changes in methods:

- com.aspose.pdf.facades.PdfFileEditor.resizeContents(Stream,Stream,int[],ContentsResizeParameters) 
  has been changed to 
  com.aspose.pdf.facades.PdfFileEditor.resizeContents(InputStream,OutputStream,int[],ContentsResizeParameters)
- com.aspose.pdf.facades.PdfFileEditor.resizeContents(Stream,Stream,int[],double,double)
  has been changed to 
  com.aspose.pdf.facades.PdfFileEditor.resizeContents(InputStream,OutputStream,int[],double,double)
- com.aspose.pdf.facades.PdfFileEditor.addMargins(Stream,Stream,int[],double,double,double,double) 
  has been changed to 
  com.aspose.pdf.facades.PdfFileEditor.addMargins(InputStream,OutputStream,int[],double,double,double,double)
- com.aspose.pdf.facades.IPdfFileEditor.addMarginsPct(Stream,Stream,int[],double,double,double,double) 
  has been changed to 
  com.aspose.pdf.facades.PdfFileEditor.addMarginsPct(InputStream,OutputStream,int[],double,double,double,double)

Added new class **com.aspose.pdf.facades.PdfFileEditor.ProgressEventType** 
Added fields:

- com.aspose.pdf.facades.PdfFileEditor.ProgressEventType.PageConcatenated
- com.aspose.pdf.facades.PdfFileEditor.ProgressEventType.BlankPage
- com.aspose.pdf.facades.PdfFileEditor.ProgressEventType.DocumentEmbeddedFiles
- com.aspose.pdf.facades.PdfFileEditor.ProgressEventType.DocumentForms
- com.aspose.pdf.facades.PdfFileEditor.ProgressEventType.DocumentOutlines
- com.aspose.pdf.facades.PdfFileEditor.ProgressEventType.DocumentJavaScript
- com.aspose.pdf.facades.PdfFileEditor.ProgressEventType.DocumentLogicalStructure
- com.aspose.pdf.facades.PdfFileEditor.ProgressEventType.AllPagesCopied
- com.aspose.pdf.facades.PdfFileEditor.ProgressEventType.DocumentConcated
- com.aspose.pdf.facades.PdfFileEditor.ProgressEventType.TotalPercentage
- com.aspose.pdf.facades.PdfFileEditor.ProgressEventHandlerInfo.MaxValue

Added new class **com.aspose.pdf.facades.PdfFileEditor.PageBreak** 
constructors:

- M:com.aspose.pdf.facades.PdfFileEditor.PageBreak(int,double)

methods:

- M:com.aspose.pdf.facades.PdfFileEditor.PageBreak.getPageNumber
- M:com.aspose.pdf.facades.PdfFileEditor.PageBreak.setPageNumber(int)
- M:com.aspose.pdf.facades.PdfFileEditor.PageBreak.getPosition
- M:com.aspose.pdf.facades.PdfFileEditor.PageBreak.setPosition(double)

Changes in **class com.aspose.pdf.GraphInfo** 
Added methods:

- com.aspose.pdf.GraphInfo.getDashArray
- com.aspose.pdf.GraphInfo.setDashArray(int[])
- com.aspose.pdf.GraphInfo.getDashPhase
- com.aspose.pdf.GraphInfo.setDashPhase(int)
- com.aspose.pdf.GraphInfo.getSkewAngleX
- com.aspose.pdf.GraphInfo.setSkewAngleX(double)
- com.aspose.pdf.GraphInfo.getSkewAngleY
- com.aspose.pdf.GraphInfo.setSkewAngleY(double)
- com.aspose.pdf.GraphInfo.getScalingRateX
- com.aspose.pdf.GraphInfo.setScalingRateX(double)
- com.aspose.pdf.GraphInfo.getScalingRateY
- com.aspose.pdf.GraphInfo.setScalingRateY(double)
- com.aspose.pdf.GraphInfo.getRotationAngle
- com.aspose.pdf.GraphInfo.setRotationAngle(double)

Changes in methods:

- com.aspose.pdf.GraphInfo.isDoubled(boolean) 
  has been changed to 
  com.aspose.pdf.GraphInfo.setDoubled(boolean)

Added new interface **com.aspose.pdf.ITableElement** 
methods:

- com.aspose.pdf.ITableElement.getRectangle

Changes in class **com.aspose.pdf.Matrix** 
Added methods:

- com.aspose.pdf.Matrix.skew(double,double)
- com.aspose.pdf.Matrix.scale(double,double)

Added new class **com.aspose.pdf.MemoryExtender** 
methods:

- com.aspose.pdf.MemoryExtender.isSwapEnabled
- com.aspose.pdf.MemoryExtender.setSwapEnabled(boolean)
- com.aspose.pdf.MemoryExtender.isSkipHeavyContentEnabled
- com.aspose.pdf.MemoryExtender.setSkipHeavyContentEnabled(boolean)

Changes in class **com.aspose.pdf.Page** 
Added methods:

- com.aspose.pdf.Page.getRotationMatrix

Changes in class **com.aspose.pdf.Rectangle** 
Added methods:

- com.aspose.pdf.Rectangle.deepClone
- com.aspose.pdf.Rectangle.getEmpty
- com.aspose.pdf.Rectangle.isIntersect(Rectangle)
- com.aspose.pdf.Rectangle._Intersect(Rectangle)

Added new class **com.aspose.pdf.text.ExtractedTextPostProcessor** 
methods:

- com.aspose.pdf.text.ExtractedTextPostProcessor.process(String)

Changes in class **com.aspose.pdf.TextExtractionOptions** 
Added methods:

- com.aspose.pdf.TextExtractionOptions.getScaleFactor
- com.aspose.pdf.TextExtractionOptions.setScaleFactor(double)

Added fields:

- com.aspose.pdf.TextExtractionOptions.TextFormattingMode.MemorySaving

Changes in class **com.aspose.pdf.TextFragment** 
Added methods:

- com.aspose.pdf.TextFragment.getWrapLinesCount
- com.aspose.pdf.TextFragment.setWrapLinesCount(int)

Changes in class **com.aspose.pdf.TextFragmentState** 
Added methods:

- com.aspose.pdf.TextFragmentState.getCharacterSpacing

Changes in class **com.aspose.pdf.TextSearchOptions** 
Added methods:

- com.aspose.pdf.TextSearchOptions.setRegularExpressionUsed(boolean)
- com.aspose.pdf.TextSearchOptions.getUseFontEngineEncoding
- com.aspose.pdf.TextSearchOptions.isIgnoreShadowText
- com.aspose.pdf.TextSearchOptions.setIgnoreShadowText(boolean)

Changes in **class com.aspose.pdf.TextState** 
Added methods:

- com.aspose.pdf.TextState.getCharacterSpacing
