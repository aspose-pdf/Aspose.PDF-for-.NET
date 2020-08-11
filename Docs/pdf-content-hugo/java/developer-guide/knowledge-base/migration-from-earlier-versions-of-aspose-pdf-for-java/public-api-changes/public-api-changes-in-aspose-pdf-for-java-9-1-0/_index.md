---
title: Public API Changes in Aspose.PDF for Java 9.1.0
type: docs
weight: 40
url: /java/public-api-changes-in-aspose-pdf-for-java-9-1-0/
---

{{% alert color="primary" %}} 

This page lists the public API changes introduced in Aspose.PDF for Java 9.1.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.PDF for Java which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

{{% /alert %}} 
#### **Moved**
com.aspose.pdf.Text.FontSourceCollection moved to com.aspose.pdf.FontSourceCollection}
#### **Added the following classes:**
- BaseOperatorCollection
- DocMDPAccessPermissions
- DocMDPSignature
- LightweightOperatorCollection
- OcspSettings
- PclConverter
- PclSaveOptions
- TextParagraphAbsorber
- TextParagraphCollection
- TimestampSettings
- UnifiedSaveOptions
##### **Changed class names:**
MhtToPdfConverter -> MhtConverter
XpsToPdfConverter -> XpsConverter
##### **In class SaveFormat, field is renamed:**
SaveFormat.None -> SaveFormat.Pdf
##### **In class XForm, method is renamed:**
public Rectangle getRectangle_Rename_Namesake () ->
public Rectangle getRectangle()
##### **In PdfFileEditor class, following methods are added:**
public boolean getCopyLogicalStructure()
public void setCopyLogicalStructure(boolean value)
##### **In PdfFileSignature class, following methods are added:**
public boolean isCertified()
public int getAccessPermissions()
public void certify(int page, String SigReason, String SigContact, String SigLocation, boolean visible, java.awt.Rectangle annotRect, DocMDPSignature docMdpSignature)
##### **In Stamp class, following methods are added:**
public int getQuality()
public void setQuality(int value)
##### **In Document class, following methods are added:**
public Copier getDefaultCopier()
public Object getCatalogValue(String key)
##### **In Annotation class, following methods are added:**
public static boolean getUseFontSubset()
public static void setUseFontSubset(boolean value)
public void setColor_Rename_Namesake(Color value)
##### **In BaseParagraph class, following methods are added:**
public boolean isInNewPage()
public void isInNewPage(boolean value)
##### **In DocSaveOptions class changes:**
DocSaveOptions extends SaveOptions -> DocSaveOptions extends UnifiedSaveOptions

- added field:

public ConversionProgressEventHandler CustomProgressHandler
##### **In HtmlConverter class, following methods are renamed:**
saveReferencedHtml (..)->saveOneHtmlPageMarkup (..)
##### **In HtmlSaveOptions class changes:**
HtmlSaveOptions extends SaveOptions -> HtmlSaveOptions extends UnifiedSaveOptions

- added field:
  public ConversionProgressEventHandler CustomProgressHandler
- added internal classes:

public static class HtmlPageMarkupSavingInfo
public static final class HtmlMarkupGenerationModes
##### **In ImageStamp class, following methods added:**
public int getQuality()
public void setQuality(int value)
##### **Signature class, following methods are added:**
public TimestampSettings getTimestampSettings()
public void setTimestampSettings(TimestampSettings value)
##### **MobiXmlSaveOptions class changes:**
MobiXmlSaveOptions extends SaveOptions -> MobiXmlSaveOptions extends UnifiedSaveOptions
##### **OperatorCollection class changes:**
public final class OperatorCollection implements ICollection -> public class OperatorCollection extends BaseOperatorCollection implements ICollection
##### **PdfFormat class was added the next element:**
public static final int PDF_X_3 = 10;
##### **TextBuilder class changes:**
public TextBuilder(Page page, OperatorCollection operatorCollection) -> public TextBuilder(Page page, BaseOperatorCollection operatorCollection)
##### **Watermark class changes:**
public Watermark(com.aspose.ms.System.Drawing.Image image) -> public Watermark(BufferedImage nativeImage)
added constructor: public Watermark(BufferedImage nativeImage, Rectangle rect)
added method: public BufferedImage getImage()
##### **XImageCollection class changes:**
added method: public void add(InputStream image, int quality)
##### **XpsSaveOptions class changes:**
XpsSaveOptions extends SaveOptions -> XpsSaveOptions extends UnifiedSaveOptions
