---
title: Public API Changes in Aspose.PDF for Java 9.3.0
type: docs
weight: 50
url: /java/public-api-changes-in-aspose-pdf-for-java-9-3-0/
---

{{% alert color="primary" %}} 

This page lists the public API changes introduced in [Aspose.PDF for Java 9.3.0](http://www.aspose.com/community/files/72/java-components/aspose.pdf-for-java/entry559320.aspx). It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.PDF for Java which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

{{% /alert %}} 
##### **Classes Added:**
com.aspose.pdf.MemoryCleaner
com.aspose.pdf.generator.legacy.CmykColorSpace
com.aspose.pdf.generator.legacy.GrayColorSpace
com.aspose.pdf.generator.legacyxmlmodel.ClippingPath
com.aspose.pdf.generator.legacyxmlmodel.ColouredTilingPattern
com.aspose.pdf.generator.legacyxmlmodel.CompareValidator
com.aspose.pdf.generator.legacyxmlmodel.CrossHatchPattern
com.aspose.pdf.generator.legacyxmlmodel.CustomValidator
com.aspose.pdf.generator.legacyxmlmodel.Function
com.aspose.pdf.generator.legacyxmlmodel.FunctionExpInterpolation
com.aspose.pdf.generator.legacyxmlmodel.GradientAxialShading
com.aspose.pdf.generator.legacyxmlmodel.GradientRadialShading
com.aspose.pdf.generator.legacyxmlmodel.HatchingPattern
com.aspose.pdf.generator.legacyxmlmodel.ImagePattern
com.aspose.pdf.generator.legacyxmlmodel.PointsPattern
com.aspose.pdf.generator.legacyxmlmodel.RangeValidator
com.aspose.pdf.generator.legacyxmlmodel.RegularExpressionValidator
com.aspose.pdf.generator.legacyxmlmodel.RequiredFieldValidator
com.aspose.pdf.generator.legacyxmlmodel.ShadingGradientPattern
com.aspose.pdf.generator.legacyxmlmodel.ShadingPattern
com.aspose.pdf.generator.legacyxmlmodel.ShadingPatternFactory
com.aspose.pdf.generator.legacyxmlmodel.TilingPattern
com.aspose.pdf.generator.legacyxmlmodel.UncolouredTilingPattern
com.aspose.pdf.Artifact.ArtifactType
com.aspose.pdf.Artifact.ArtifactSubtype
com.aspose.pdf.ILicenseProvider
com.aspose.pdf.Layer
com.aspose.pdf.LettersPositioningMethods
##### **Enumeration Classes Added:**
com.aspose.pdf.generator.legacyxmlmodel.enums.FunctionType
com.aspose.pdf.generator.legacyxmlmodel.enums.PaintType
com.aspose.pdf.generator.legacyxmlmodel.enums.PatternType
com.aspose.pdf.generator.legacyxmlmodel.enums.ShadingGradientType
com.aspose.pdf.generator.legacyxmlmodel.enums.TilingType
Implemented usage of enumeration classes: **TextEncodingInternal** and **ImageFormatInternal**
##### **classes Removed:**
Depricated com.aspose.pdf.generator.legacyxmlmodel.enums.TextAlignmentType class was removed.
##### **classes Moved:**
Classes from the package **com.aspose.pdf.generator.legacyxmlmodel.enums** are moved to the package **com.aspose.pdf.generator.legacyxmlmodel**
##### **Classes Internalized:**
com.aspose.pdf.XfdfTags
com.aspose.pdf.generator.legacyxmlmodel.NonClosedShape
com.aspose.pdf.generator.legacyxmlmodel.ComplexShape
com.aspose.pdf.generator.legacyxmlmodel.Circle
com.aspose.pdf.generator.legacyxmlmodel.Curve
com.aspose.pdf.generator.legacyxmlmodel.NonClosedShape
com.aspose.pdf.generator.legacyxmlmodel.Ellipse
com.aspose.pdf.generator.legacyxmlmodel.PolyDashArray
com.aspose.pdf.generator.legacyxmlmodel.PathArea
com.aspose.pdf.generator.legacyxmlmodel.Rectangle
##### **Changes in classes:**
**Changes to classes:
**In **PdfExtractor** class was added method 
public extractText(java.nio.charset.Charset value) 

In **PdfFileEditor** class was added method 
public static void validateAnotations(IDocument doc)

In **BorderInfo** class added new constructors:
` `public BorderInfo(int borderSide)
` `public BorderInfo(int borderSide, GraphInfo borderFormat)
` `public BorderInfo(int borderSide, float borderWidth)
` `public BorderInfo(int borderSide, float borderWidth, Color borderColor)
` `public BorderInfo(int borderSide, Color borderColor)

In **Canvas** class added method 
` `public Object deepClone()

In **Cell** class added methods:
` `public boolean isNoBorder()
` `public void setNoBorder(boolean value)
` `public Object completeClone()

In **DocumentAttachment** class added method 
` `public Object completeClone()

In **FloatingBox** class added method
` `public Object completeClone()

In **FormField** class added method
` `public Object completeClone()

In **Graph** class added methods:
` `public float getRotatingAngle() 
` `public void setRotatingAngle(float value) 
` `public ClippingPath getClipping() 
` `public void setClipping(ClippingPath value) 
` `public Object completeClone()

In **Image** class added constructors and methods:
` `public Image()
` `public Image(Section section)
` `public int getAutoNumber()
` `public void setAutoNumber(int value)
` `public float getImageHeight() 
` `public void setImageHeight(float value) 
` `public float getImageWidth() 
` `public void setImageWidth(float value) 
` `public float getVectorGraphicsRenderingDPI() 
` `public void setVectorGraphicsRenderingDPI(float value)
` `public float getImageScale() 
` `public void setImageScale(float value)
` `public Object completeClone()           

In **ImageInfo** class added fields and methods:

` `public TextInfo TextInfo
` `public String Title
` `public BorderInfo ImageBorder
` `public /**ImageFileType**/int _ImageFileType
` `public InputStream getImageStream()
` `public void setImageStream(InputStream value)
` `public BufferedImage getSystemImage()
` `public void setSystemImage(BufferedImage value)  
` `public /**Byte**/byte[] getMemoryData() 
` `public void setMemoryData(/**Byte**/byte[] value) 
` `public boolean isFixImgWidthSettedInXML() 
` `public void setFixImgWidthSettedInXML(boolean value) 
` `public boolean isFixImgHeightSettedInXML()
` `public void setFixImgHeightSettedInXML(boolean value) 
` `public boolean isAllFramesInNewPage() 
` `public void setAllFramesInNewPage(boolean value)
` `public boolean isStencilMask() 
` `public void setStencilMask(boolean value)
` `public com.aspose.pdf.generator.legacyxmlmodel.Color getBackgroundColor() 
` `public void setBackgroundColor(com.aspose.pdf.generator.legacyxmlmodel.Color value)
` `public java.awt.Color getPatternColor()
` `public void setPatternColor(java.awt.Color value) 

In **Paragraph** class added fields and methods:
` `public float FixedHeight;
` `public float FixedWidth;
` `public /**BookmarkIncludeType**/int getBookmarked()
` `public void setBookmarked(/**BookmarkIncludeType**/int value)
` `public void copyTo(Paragraph par)

In **RadioButton** class added method
` `public Object completeClone()

In **Row** class added method
` `public Object completeClone()

In **Segment** class added method
` `public Object completeClone()

In **Shape** class added method
` `public float getOpacity()
` `public void setOpacity(float value)
` `public float getStrokeOpacity() 
` `public void setStrokeOpacity(float value)  

In **Shapes** class some methods were internalized:
` `void add(Shape shape)
` `void remove(Shape shapeToRemove)
` `void copyTo(Shape[] shapeArray, int index)
` `int indexOf(Shape shape)

In **Table** class added method
` `public /**override**/ Object completeClone()

In **Text** class added method
` `public /**override**/ Object completeClone()

In **XslFoLoadOptions** class added method
` `public String getBasePath() 
` `public void setBasePath(String value) 

In **PdfBookmarkEditor** class added method
` `public Bookmarks extractBookmarks(boolean upperLevel)

In **XslFoLoadOptions** class added method

In **XslFoLoadOptions** class added method

In **XslFoLoadOptions** class added method

In **XslFoLoadOptions** class added method

**All the boolean setter method names that were started from is* was renamed ro set*
**for example:
` `com.aspose.pdf.facades.ReplaceTextStrategy.isRegularExpressionUsed(boolean value) -> com.aspose.pdf.facades.ReplaceTextStrategy.setRegularExpressionUsed(boolean value)
