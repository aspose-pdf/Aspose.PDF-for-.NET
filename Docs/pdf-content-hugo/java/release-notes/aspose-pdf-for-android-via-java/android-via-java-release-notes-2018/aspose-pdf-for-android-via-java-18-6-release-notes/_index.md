---
title: Aspose.PDF for Android via Java 18.6 Release Notes
type: docs
weight: 10
url: /java/aspose-pdf-for-android-via-java-18-6-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes of [Aspose.PDF for Android via Java 18.6](https://repository.aspose.com/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-pdf/18.6)

{{% /alert %}} 
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFANDROID-511|PDF to PDFA conversion support|New Feature|
|PDFANDROID-520|Creating NamedDestination in existing PDF|New Feature|
|PDFANDROID-509|Add Support for Metered License|New Feature|
|PDFANDROID-516|Add support of Conholdate license|New Feature|
|PDFANDROID-521|PDF to PDF/A - Resultant file is not PDF/A_1b compliant|Bug|
|PDFANDROID-517|Replace packed font with free licence|Bug|
|PDFANDROID-510|Paid License is not being applied|Bug|
|PDFANDROID-518|Incorrect package at project of Aspose.Pdf for Android|Bug|
|PDFANDROID-529|PDF to PDFA 1A add 1B validation errors in metadata|Bug|
|PDFANDROID-507|Cannot get image data from StampAnnotation in an existing PDF|Bug|
## **Public API Changes**
**Changes in class com.aspose.pdf.ActionCollection** 
Added method:
com.aspose.pdf.ActionCollection.copyTo(Object[],int)

**Changes in class com.aspose.pdf.AnnotationType** 
Added fields:
com.aspose.pdf.AnnotationType.Redaction
com.aspose.pdf.AnnotationType.RichMedia
com.aspose.pdf.AnnotationType.Unknown
com.aspose.pdf.AnnotationType.PDF3D

**Changes in class com.aspose.pdf.ActionCollection** 
Added methods:
com.aspose.pdf.AppearanceDictionary.getKeys_
com.aspose.pdf.AppearanceDictionary.getValues_
com.aspose.pdf.AppearanceDictionary.addItem(String,XForm)
com.aspose.pdf.AppearanceDictionary.containsKey(String)
com.aspose.pdf.AppearanceDictionary.removeItemByKey(String)
com.aspose.pdf.AppearanceDictionary.tryGetValue(String,Object[])
com.aspose.pdf.AppearanceDictionary.getValues_Rename_Namesake
com.aspose.pdf.AppearanceDictionary.addItem(KeyValuePair<String, XForm>)
com.aspose.pdf.AppearanceDictionary.containsItem(KeyValuePair<String, XForm>)
com.aspose.pdf.AppearanceDictionary.copyToTArray(KeyValuePair<String, XForm>[],int)
com.aspose.pdf.AppearanceDictionary.removeItem(KeyValuePair<String, XForm>)
com.aspose.pdf.AppearanceDictionary.iterator__Rename_Namesake
Rename methods:
com.aspose.pdf.AppearanceDictionary.removeItem(Object) -> com.aspose.pdf.AppearanceDictionary.removeItemInternal(Object)
com.aspose.pdf.AppearanceDictionary.addItem(Object,Object) - > com.aspose.pdf.AppearanceDictionary.add(Object,Object)
com.aspose.pdf.AppearanceDictionary.iterator -> com.aspose.pdf.AppearanceDictionary.iterator_internal
com.aspose.pdf.AppearanceDictionary.get_Item_internal(Object) -> com.aspose.pdf.AppearanceDictionary.get_Item(String)
com.aspose.pdf.AppearanceDictionary.set_Item(Object,Object) -> com.aspose.pdf.AppearanceDictionary.set(Object,XForm)

**Changes in class com.aspose.pdf.CharInfoCollection** 
Removed method com.aspose.pdf.CharInfoCollection.copyTo(Array,int)

**Changes in class com.aspose.pdf.devices.TiffDevice** 
Added methods:
com.aspose.pdf.devices.TiffDevice.getCropRectangle
com.aspose.pdf.devices.TiffDevice.setCropRectangle(com.aspose.pdf.Rectangle)

**Added new class com.aspose.pdf.DocumentFactory** 
methods:
com.aspose.pdf.DocumentFactory.createDocument(InputStream,LoadOptions)
com.aspose.pdf.DocumentFactory.createDocument
com.aspose.pdf.DocumentFactory.createDocument(InputStream)
com.aspose.pdf.DocumentFactory.createDocument(InputStream,String)
com.aspose.pdf.DocumentFactory.createDocument(String)

**Changes in class com.aspose.pdf.EmbeddedFileCollection** 
Removed methods:
com.aspose.pdf.EmbeddedFileCollection.copyTo(Array,int)
com.aspose.pdf.EmbeddedFileCollection.delete(int)
Added methods:
com.aspose.pdf.EmbeddedFileCollection.add(String,FileSpecification)
com.aspose.pdf.EmbeddedFileCollection.deleteByKey(String)
com.aspose.pdf.EmbeddedFileCollection.delete(String)

**Added new class com.aspose.pdf.exceptions.CorruptContentException** 
constructor:
com.aspose.pdf.exceptions.CorruptContentException.#ctor(String)

**Added new class com.aspose.pdf.exceptions.FontEmbeddingException** 
constructors:
com.aspose.pdf.exceptions.FontEmbeddingException.#ctor(String)
com.aspose.pdf.exceptions.FontEmbeddingException.#ctor(String,Exception)
com.aspose.pdf.exceptions.FontEmbeddingException.#ctor(Exception)

**Added new class com.aspose.pdf.exceptions.IndexOutOfRangeException** 
constructors:
com.aspose.pdf.exceptions.IndexOutOfRangeException.#ctor(Exception)

**Changes in class com.aspose.pdf.exceptions.PdfException** 
Added constructor:
com.aspose.pdf.exceptions.PdfException.#ctor(String,java.lang.Throwable)

**Changes in class com.aspose.pdf.facades.Facade** 
Removed method:
com.aspose.pdf.facades.Facade.bindPdf(Stream)
Added method:
com.aspose.pdf.facades.Facade.bindPdf(String,String)

**Changes in class com.aspose.pdf.facades.PdfExtractor** 
Added methods:
com.aspose.pdf.facades.PdfExtractor.extractText(java.nio.charset.Charset)
com.aspose.pdf.facades.PdfExtractor.extractTextInternal(TextEncodingInternal)
com.aspose.pdf.facades.PdfExtractor.bindPdf(String)
com.aspose.pdf.facades.PdfExtractor.bindPdf(InputStream)
com.aspose.pdf.facades.PdfExtractor.extractMarkedContentAsImages(Page,String)
Change in methods:
com.aspose.pdf.facades.PdfExtractor.getNextImage(String,ImageFormat) -> com.aspose.pdf.facades.PdfExtractor.getNextImage(String,ImageType)
com.aspose.pdf.facades.PdfExtractor.getNextImage(OutputStream,ImageFormat) -> com.aspose.pdf.facades.PdfExtractor.getNextImage(OutputStream,ImageType)

**Changes in class com.aspose.pdf.facades.PdfFileInfo** 
Added method:
com.aspose.pdf.facades.PdfFileInfo.bindPdf(String,String)

**Changes in class com.aspose.pdf.facades.PdfViewer** 
Added method:
com.aspose.pdf.facades.PdfFileInfo.bindPdf(InputStream)

**Changes in class com.aspose.pdf.facades.PdfViewer** 
Added methods:
com.aspose.pdf.FileSpecification.getEncoding
com.aspose.pdf.FileSpecification.setEncoding(int)
com.aspose.pdf.FileSpecification.setParams(FileParams)
com.aspose.pdf.FileSpecification.setMIMEType(String)
com.aspose.pdf.FileSpecification.getUnicodeName
com.aspose.pdf.FileSpecification.setUnicodeName(String)
com.aspose.pdf.FileSpecification.dispose
Rename method:
com.aspose.pdf.FileSpecification.getIncludeContents -> com.aspose.pdf.FileSpecification.isIncludeContents

**Changes in class com.aspose.pdf.IDocument** 
Added methods:
com.aspose.pdf.IDocument.getNamedDestinations
com.aspose.pdf.IDocument.getEmbedStandardFonts
com.aspose.pdf.IDocument.setEmbedStandardFonts(boolean)

**Changes in class com.aspose.pdf.IFontOptions** 
Added methods:
com.aspose.pdf.IFontOptions
com.aspose.pdf.IFontOptions.getNotifyAboutFontEmbeddingError
com.aspose.pdf.IFontOptions.setNotifyAboutFontEmbeddingError(boolean)

**Added new class com.aspose.pdf.ImageFilterType** 
fields:
com.aspose.pdf.ImageFilterType.Jpeg2000
com.aspose.pdf.ImageFilterType.Jpeg

**Changes in class com.aspose.pdf.ImagePlacement** 
Rename method:
com.aspose.pdf.ImagePlacement.save(OutputStream,ImageFormat) -> com.aspose.pdf.ImagePlacement.save(OutputStream,ImageType)

**Changes in class com.aspose.pdf.ImagePlacementCollection** 
Removed methods:
com.aspose.pdf.ImagePlacementCollection.copyTo(Array,int)

**Added new class com.aspose.pdf.ImageType** 
fields:
com.aspose.pdf.ImageType.getBmp
com.aspose.pdf.ImageType.getEmf
com.aspose.pdf.ImageType.getExif
com.aspose.pdf.ImageType.getGif
com.aspose.pdf.ImageType.getJpeg
com.aspose.pdf.ImageType.getIcon
com.aspose.pdf.ImageType.getMemoryBmp
com.aspose.pdf.ImageType.getPng
com.aspose.pdf.ImageType.getTiff
com.aspose.pdf.ImageType.getWmf
methods:
com.aspose.pdf.ImageType.toString(ImageType)
com.aspose.pdf.ImageType.toString
com.aspose.pdf.ImageType.isBitmapType(ImageType)
com.aspose.pdf.ImageType.isMetafileType(ImageType)
com.aspose.pdf.ImageType.isUnknownType(ImageType)
com.aspose.pdf.ImageType.getNames

**Move classes:** 
com.aspose.java.awt.color.ColorSpace -> com.aspose.pdf.java.awt.color.ColorSpace
com.aspose.java.awt.geom.Point2D.Float -> com.aspose.pdf.java.awt.geom.Point2D.Float
com.aspose.java.awt.image.BufferedImage -> com.aspose.pdf.java.awt.image.BufferedImage
com.aspose.java.awt.Color -> com.aspose.pdf.java.awt.Color
com.aspose.java.awt.Rectangle -> com.aspose.pdf.java.awt.Rectangle
com.aspose.javax.imageio.ImageIO -> com.aspose.pdf.javax.imageio.ImageIO

**Added new class com.aspose.pdf.LightingSchemeType** 
fields:
com.aspose.pdf.LightingSchemeType.Artwork
com.aspose.pdf.LightingSchemeType.None
com.aspose.pdf.LightingSchemeType.White
com.aspose.pdf.LightingSchemeType.Day
com.aspose.pdf.LightingSchemeType.Night
com.aspose.pdf.LightingSchemeType.Hard
com.aspose.pdf.LightingSchemeType.Primary
com.aspose.pdf.LightingSchemeType.Red
com.aspose.pdf.LightingSchemeType.Cube
com.aspose.pdf.LightingSchemeType.CAD
com.aspose.pdf.LightingSchemeType.Headlamp

**Added new class com.aspose.pdf.Matrix3D** 
constructors:
com.aspose.pdf.Matrix3D.#ctor
com.aspose.pdf.Matrix3D.#ctor(double[])
com.aspose.pdf.Matrix3D.#ctor(Matrix3D)
methods:
com.aspose.pdf.Matrix3D.getA
com.aspose.pdf.Matrix3D.setA(double)
com.aspose.pdf.Matrix3D.getB
com.aspose.pdf.Matrix3D.setB(double)
com.aspose.pdf.Matrix3D.getC
com.aspose.pdf.Matrix3D.setC(double)
com.aspose.pdf.Matrix3D.getD
com.aspose.pdf.Matrix3D.setD(double)
com.aspose.pdf.Matrix3D.getE
com.aspose.pdf.Matrix3D.setE(double)
com.aspose.pdf.Matrix3D.getF
com.aspose.pdf.Matrix3D.setF(double)
com.aspose.pdf.Matrix3D.getG
com.aspose.pdf.Matrix3D.setG(double)
com.aspose.pdf.Matrix3D.getH
com.aspose.pdf.Matrix3D.setH(double)
com.aspose.pdf.Matrix3D.getI
com.aspose.pdf.Matrix3D.setI(double)
com.aspose.pdf.Matrix3D.getTx
com.aspose.pdf.Matrix3D.setTx(double)
com.aspose.pdf.Matrix3D.getTy
com.aspose.pdf.Matrix3D.setTy(double)
com.aspose.pdf.Matrix3D.getTz
com.aspose.pdf.Matrix3D.setTz(double)
com.aspose.pdf.Matrix3D.toString
com.aspose.pdf.Matrix3D.equals(Object)
com.aspose.pdf.Matrix3D.getAngle(int)
com.aspose.pdf.Matrix3D.add(Matrix3D)
com.aspose.pdf.Matrix3D.hashCode

**Changes in class com.aspose.pdf.MemoryExtender** 
Added methods:
com.aspose.pdf.MemoryExtender.getCallBackPageImage
com.aspose.pdf.MemoryExtender.setCallBackPageImage(CallBackPageImage)
com.aspose.pdf.MemoryExtender.isEnabledMultiPageImageCache
com.aspose.pdf.MemoryExtender.setEnableMultiPageCache(boolean)
com.aspose.pdf.MemoryExtender.CallBackPageImage.invoke(BufferedImage)

**Added new class com.aspose.pdf.Metered** 
constructor:
com.aspose.pdf.Metered.#ctor
methods:
com.aspose.pdf.Metered.setMeteredKey(String,String)
com.aspose.pdf.Metered.getConsumptionQuantity
Added new class com.aspose.pdf.NamedDestination"
constructor:
com.aspose.pdf.NamedDestination.#ctor(Document,String)

**Added new interface com.aspose.pdf.nameddestinations.INamedDestinationCollection** 
methods:
com.aspose.pdf.nameddestinations.INamedDestinationCollection.get_Item(String)
com.aspose.pdf.nameddestinations.INamedDestinationCollection.set_Item(String,IAppointment)
com.aspose.pdf.nameddestinations.INamedDestinationCollection.size
com.aspose.pdf.nameddestinations.INamedDestinationCollection.remove(String)
com.aspose.pdf.nameddestinations.INamedDestinationCollection.add(String,IAppointment)
com.aspose.pdf.nameddestinations.INamedDestinationCollection.getNames

**Added new class com.aspose.pdf.nameddestinations.NamedDestinationCollection** 
methods:
com.aspose.pdf.nameddestinations.NamedDestinationCollection.get_Item(String)
com.aspose.pdf.nameddestinations.NamedDestinationCollection.set_Item(String,IAppointment)
com.aspose.pdf.nameddestinations.NamedDestinationCollection.size
com.aspose.pdf.nameddestinations.NamedDestinationCollection.remove(String)
com.aspose.pdf.nameddestinations.NamedDestinationCollection.add(String,IAppointment)
com.aspose.pdf.nameddestinations.NamedDestinationCollection.getNames

**Changes in class com.aspose.pdf.OptionCollection** 
Removed method com.aspose.pdf.OptionCollection.copyTo(Array,int)

**Changes in class com.aspose.pdf.OutlineCollection** 
Removed method com.aspose.pdf.OutlineCollection.copyTo(Array,int)

**Changes in class com.aspose.pdf.OutlineItemCollection** 
Removed method com.aspose.pdf.OutlineItemCollection.copyTo(Array,int)

**Added new class com.aspose.pdf.PclLoadOptions** 
constructors:
com.aspose.pdf.PclLoadOptions.#ctor
fields:
com.aspose.pdf.PclLoadOptions.

**Added new class com.aspose.pdf.PclLoadOptions** 
fields:
com.aspose.pdf.PclLoadOptions.ConversionEngine
com.aspose.pdf.PclLoadOptions.SupressErrors
com.aspose.pdf.PclLoadOptions.Exceptions
com.aspose.pdf.PclLoadOptions.ConversionEngines
com.aspose.pdf.PclLoadOptions.LegacyEngine
com.aspose.pdf.PclLoadOptions.NewEngine

**Added new class com.aspose.pdf.PDF3DActivation** 
constructors:
com.aspose.pdf.PDF3DActivation.#ctor(Page,Rectangle,PDF3DArtwork)
com.aspose.pdf.PDF3DActivation.#ctor(Page,Rectangle,PDF3DArtwork,int)
methods:
com.aspose.pdf.PDF3DActivation.activeWhenOpen
com.aspose.pdf.PDF3DActivation.activeWhenVisible
com.aspose.pdf.PDF3DActivation.activatedUserOrScriptAction
com.aspose.pdf.PDF3DActivation.getPdf3DArtwork
com.aspose.pdf.PDF3DActivation.getLightingScheme
com.aspose.pdf.PDF3DActivation.setContent(PDF3DContent)
com.aspose.pdf.PDF3DActivation.getRenderMode
com.aspose.pdf.PDF3DActivation.setDefaultViewIndex(int)
com.aspose.pdf.PDF3DActivation.getViewArray
com.aspose.pdf.PDF3DActivation.getAnnotationType
com.aspose.pdf.PDF3DActivation.accept(AnnotationSelector)
com.aspose.pdf.PDF3DActivation.setImagePreview(String)
com.aspose.pdf.PDF3DActivation.setImagePreview(InputStream)
com.aspose.pdf.PDF3DActivation.clearImagePreview
com.aspose.pdf.PDF3DActivation.getImagePreview

**Added new class com.aspose.pdf.PDF3DActivation** 
constructors:
com.aspose.pdf.PDF3DActivation.#ctor(Document,PDF3DContent,PDF3DLightingScheme,PDF3DRenderMode)
com.aspose.pdf.PDF3DActivation.#ctor(Document,PDF3DContent)
methods:
com.aspose.pdf.PDF3DActivation.getLightingScheme
com.aspose.pdf.PDF3DActivation.setLightingScheme(PDF3DLightingScheme)
com.aspose.pdf.PDF3DActivation.getRenderMode
com.aspose.pdf.PDF3DActivation.setRenderMode(PDF3DRenderMode)
com.aspose.pdf.PDF3DActivation.getViewArray
com.aspose.pdf.PDF3DActivation.getViewsList
com.aspose.pdf.PDF3DActivation.getViewsArray

**Added new class com.aspose.pdf.PDF3DContent** 
constructors:
com.aspose.pdf.PDF3DContent.#ctor
com.aspose.pdf.PDF3DContent.#ctor(String)
methods:
com.aspose.pdf.PDF3DContent.getExtension
com.aspose.pdf.PDF3DContent.load(String)
com.aspose.pdf.PDF3DContent.loadAsPRC(String)
com.aspose.pdf.PDF3DContent.loadAsU3D(String)
com.aspose.pdf.PDF3DContent.loadAsPRC(InputStream)
com.aspose.pdf.PDF3DContent.loadAsU3D(InputStream)
com.aspose.pdf.PDF3DContent.loadAsPRC(byte[])
com.aspose.pdf.PDF3DContent.loadAsU3D(byte[])
com.aspose.pdf.PDF3DContent.saveToFile(String)
com.aspose.pdf.PDF3DContent.getAsStream
com.aspose.pdf.PDF3DContent.getAsByteArray

**Added new class com.aspose.pdf.PDF3DCrossSection** 
constructors:
com.aspose.pdf.PDF3DCrossSection.#ctor(Document)
methods:
com.aspose.pdf.PDF3DCrossSection.getCenter
com.aspose.pdf.PDF3DCrossSection.setCenter(Point3D)
com.aspose.pdf.PDF3DCrossSection.getCuttingPlaneOpacity
com.aspose.pdf.PDF3DCrossSection.setCuttingPlaneOpacity(double)
com.aspose.pdf.PDF3DCrossSection.getCuttingPlaneOrientation
com.aspose.pdf.PDF3DCrossSection.setCuttingPlaneOrientation(PDF3DCuttingPlaneOrientation)
com.aspose.pdf.PDF3DCrossSection.getCuttingPlaneColor
com.aspose.pdf.PDF3DCrossSection.setCuttingPlaneColor(Color)
com.aspose.pdf.PDF3DCrossSection.getCuttingPlanesIntersectionColor
com.aspose.pdf.PDF3DCrossSection.setCuttingPlanesIntersectionColor(Color)
com.aspose.pdf.PDF3DCrossSection.getVisibility
com.aspose.pdf.PDF3DCrossSection.setVisibility(boolean)

**Added new class com.aspose.pdf.PDF3DCrossSectionArray** 
constructors:
com.aspose.pdf.PDF3DCrossSectionArray.#ctor(IDocument)
methods:
com.aspose.pdf.PDF3DCrossSectionArray.getCount
com.aspose.pdf.PDF3DCrossSectionArray.add(PDF3DCrossSection)
com.aspose.pdf.PDF3DCrossSectionArray.removeAt(int)
com.aspose.pdf.PDF3DCrossSectionArray.removeAll
com.aspose.pdf.PDF3DCrossSectionArray.get_Item(int)
com.aspose.pdf.PDF3DCrossSectionArray.set_Item(int,PDF3DCrossSection)

**Added new class com.aspose.pdf.PDF3DCuttingPlaneOrientation** 
constructors:
com.aspose.pdf.PDF3DCuttingPlaneOrientation.#ctor
com.aspose.pdf.PDF3DCuttingPlaneOrientation.#ctor(Double,Double,Double)
methods:
com.aspose.pdf.PDF3DCuttingPlaneOrientation.getAngleX
com.aspose.pdf.PDF3DCuttingPlaneOrientation.setAngleX(Double)
com.aspose.pdf.PDF3DCuttingPlaneOrientation.getAngleY
com.aspose.pdf.PDF3DCuttingPlaneOrientation.setAngleY(Double)
com.aspose.pdf.PDF3DCuttingPlaneOrientation.getAngleZ
com.aspose.pdf.PDF3DCuttingPlaneOrientation.setAngleZ(Double)
com.aspose.pdf.PDF3DCuttingPlaneOrientation.toString

**Added new class com.aspose.pdf.PDF3DLightingScheme** 
constructors:
com.aspose.pdf.PDF3DLightingScheme.#ctor(int)
com.aspose.pdf.PDF3DLightingScheme.#ctor(String)
methods:
com.aspose.pdf.PDF3DLightingScheme.getType
com.aspose.pdf.PDF3DLightingScheme.Artwork
com.aspose.pdf.PDF3DLightingScheme.None
com.aspose.pdf.PDF3DLightingScheme.White
com.aspose.pdf.PDF3DLightingScheme.Day
com.aspose.pdf.PDF3DLightingScheme.Night
com.aspose.pdf.PDF3DLightingScheme.Hard
com.aspose.pdf.PDF3DLightingScheme.Primary
com.aspose.pdf.PDF3DLightingScheme.Blue
com.aspose.pdf.PDF3DLightingScheme.Red
com.aspose.pdf.PDF3DLightingScheme.Cube
com.aspose.pdf.PDF3DLightingScheme.CAD
com.aspose.pdf.PDF3DLightingScheme.Headlamp

**Added new class com.aspose.pdf.PDF3DRenderMode** 
constructors:
com.aspose.pdf.PDF3DRenderMode.#ctor(int)
com.aspose.pdf.PDF3DRenderMode.#ctor(String)
methods:
com.aspose.pdf.PDF3DRenderMode.getAuxiliaryColour
com.aspose.pdf.PDF3DRenderMode.setAuxiliaryColour(Color)
com.aspose.pdf.PDF3DRenderMode.getFaceColor
com.aspose.pdf.PDF3DRenderMode.setFaceColor(Color)
com.aspose.pdf.PDF3DRenderMode.getOpacity
com.aspose.pdf.PDF3DRenderMode.setOpacity(double)
com.aspose.pdf.PDF3DRenderMode.setCreaseValue(double)
com.aspose.pdf.PDF3DRenderMode.getCreaseValue
com.aspose.pdf.PDF3DRenderMode.getType
com.aspose.pdf.PDF3DRenderMode.Solid
fields:
com.aspose.pdf.PDF3DRenderMode.SolidWireframe
com.aspose.pdf.PDF3DRenderMode.Transparent
com.aspose.pdf.PDF3DRenderMode.TransparentWareFrame
com.aspose.pdf.PDF3DRenderMode.BoundingBox
com.aspose.pdf.PDF3DRenderMode.TransparentBoundingBox
com.aspose.pdf.PDF3DRenderMode.TransparentBoundingBoxOutline
com.aspose.pdf.PDF3DRenderMode.Wireframe
com.aspose.pdf.PDF3DRenderMode.ShadedWireframe
com.aspose.pdf.PDF3DRenderMode.Vertices
com.aspose.pdf.PDF3DRenderMode.ShadedVertices
com.aspose.pdf.PDF3DRenderMode.Illustration
com.aspose.pdf.PDF3DRenderMode.SolidOutline
com.aspose.pdf.PDF3DRenderMode.ShadedIllustration

**Added new class com.aspose.pdf.PDF3DStream** 
constructors:
com.aspose.pdf.PDF3DStream.#ctor(IDocument,PDF3DArtwork)
methods:
com.aspose.pdf.PDF3DStream.getContent
com.aspose.pdf.PDF3DStream.setContent(PDF3DContent)

**Added new class com.aspose.pdf.PDF3DView** 
constructors:
com.aspose.pdf.PDF3DView.#ctor(IDocument,Matrix3D,double,String)
com.aspose.pdf.PDF3DView.#ctor(IDocument,PDF3DView,String)
methods:
com.aspose.pdf.PDF3DView.getLightingScheme
com.aspose.pdf.PDF3DView.setLightingScheme(PDF3DLightingScheme)
com.aspose.pdf.PDF3DView.getRenderMode
com.aspose.pdf.PDF3DView.setRenderMode(PDF3DRenderMode)
com.aspose.pdf.PDF3DView.getCrossSectionsArray
com.aspose.pdf.PDF3DView.getViewName
com.aspose.pdf.PDF3DView.setViewName(String)
com.aspose.pdf.PDF3DView.getCameraPosition
com.aspose.pdf.PDF3DView.setCameraPosition(Matrix3D)
com.aspose.pdf.PDF3DView.getCameraOrbit
com.aspose.pdf.PDF3DView.setCameraOrbit(double)
com.aspose.pdf.PDF3DView.getBackGroundColor
com.aspose.pdf.PDF3DView.setBackGroundColor(Color)

**Added new class com.aspose.pdf.PDF3DViewArray** 
methods:
com.aspose.pdf.PDF3DViewArray.getCount
com.aspose.pdf.PDF3DViewArray.add(PDF3DView)
com.aspose.pdf.PDF3DViewArray.removeAt(int)
com.aspose.pdf.PDF3DViewArray.removeAll
com.aspose.pdf.PDF3DViewArray.get_Item(int)
com.aspose.pdf.PDF3DViewArray.set_Item(int,PDF3DView)

**Added new class com.aspose.pdf.PdfFormat** 
fields
com.aspose.pdf.PdfFormat.PDF_A_2A
com.aspose.pdf.PdfFormat.PDF_A_3A
com.aspose.pdf.PdfFormat.PDF_A_2B
com.aspose.pdf.PdfFormat.PDF_A_2U
com.aspose.pdf.PdfFormat.PDF_A_3B
com.aspose.pdf.PdfFormat.PDF_A_3U
com.aspose.pdf.PdfFormat.PDF_X_3

**Added new class com.aspose.pdf.PdfFormatConversionOptions** 
constructors:
com.aspose.pdf.PdfFormatConversionOptions.#ctor(String,int,int)
com.aspose.pdf.PdfFormatConversionOptions.#ctor(String,int)
com.aspose.pdf.PdfFormatConversionOptions.#ctor(int)
com.aspose.pdf.PdfFormatConversionOptions.#ctor(int,int)
com.aspose.pdf.PdfFormatConversionOptions.#ctor(String,int,int,int)
com.aspose.pdf.PdfFormatConversionOptions.#ctor(OutputStream,int,int)
methods:
com.aspose.pdf.PdfFormatConversionOptions.isLowMemoryMode
com.aspose.pdf.PdfFormatConversionOptions.setLowMemoryMode(boolean)
com.aspose.pdf.PdfFormatConversionOptions.getFormat
com.aspose.pdf.PdfFormatConversionOptions.setFormat(int)
com.aspose.pdf.PdfFormatConversionOptions.getLogFileName
com.aspose.pdf.PdfFormatConversionOptions.setLogFileName(String)
com.aspose.pdf.PdfFormatConversionOptions.getLogStream
com.aspose.pdf.PdfFormatConversionOptions.setLogStream(OutputStream)
com.aspose.pdf.PdfFormatConversionOptions.getErrorAction
com.aspose.pdf.PdfFormatConversionOptions.setErrorAction(int)
com.aspose.pdf.PdfFormatConversionOptions.getTransparencyAction
com.aspose.pdf.PdfFormatConversionOptions.setTransparencyAction(int)
com.aspose.pdf.PdfFormatConversionOptions.getDefault
com.aspose.pdf.PdfFormatConversionOptions.getNonSpecificationCases
com.aspose.pdf.PdfFormatConversionOptions.getAlignText
com.aspose.pdf.PdfFormatConversionOptions.setAlignText(boolean)
com.aspose.pdf.PdfFormatConversionOptions.getPuaTextProcessingStrategy
com.aspose.pdf.PdfFormatConversionOptions.setPuaTextProcessingStrategy(int)
com.aspose.pdf.PdfFormatConversionOptions.getOptimizeFileSize
com.aspose.pdf.PdfFormatConversionOptions.setOptimizeFileSize(boolean)
com.aspose.pdf.PdfFormatConversionOptions.getExcludeFontsStrategy
com.aspose.pdf.PdfFormatConversionOptions.setExcludeFontsStrategy(byte)
com.aspose.pdf.PdfFormatConversionOptions.getFontEmbeddingOptions
com.aspose.pdf.PdfFormatConversionOptions.getIccProfileFileName
com.aspose.pdf.PdfFormatConversionOptions.setIccProfileFileName(String)
com.aspose.pdf.PdfFormatConversionOptions.getNotAccessibleFonts
fields
com.aspose.pdf.PdfFormatConversionOptions.AlignStrategy

**Added new class com.aspose.pdf.PdfFormatConversionOptions.SegmentAlignStrategy** 
fields:
com.aspose.pdf.PdfFormatConversionOptions.SegmentAlignStrategy.None
com.aspose.pdf.PdfFormatConversionOptions.SegmentAlignStrategy.RestoreSegmentBounds

**Added new class com.aspose.pdf.PdfFormatConversionOptions.PuaProcessingStrategy** 
fields:
com.aspose.pdf.PdfFormatConversionOptions.PuaProcessingStrategy.None
com.aspose.pdf.PdfFormatConversionOptions.PuaProcessingStrategy.SurroundPuaTextWithEmptyActualText
com.aspose.pdf.PdfFormatConversionOptions.PuaProcessingStrategy.SubstitutePuaSymbols

**Added new class com.aspose.pdf.PdfFormatConversionOptions.RemoveFontsStrategy** 
fields:
com.aspose.pdf.PdfFormatConversionOptions.RemoveFontsStrategy.RemoveDuplicatedFonts
com.aspose.pdf.PdfFormatConversionOptions.RemoveFontsStrategy.RemoveSimilarFontsWithDifferentWidths
com.aspose.pdf.PdfFormatConversionOptions.RemoveFontsStrategy.SubsetFonts

**Added new class com.aspose.pdf.PdfFormat** 
fields
com.aspose.pdf.PdfFormat.PDF_A_2A
com.aspose.pdf.PdfFormat.PDF_A_3A
com.aspose.pdf.PdfFormat.PDF_A_2B
com.aspose.pdf.PdfFormat.PDF_A_2U
com.aspose.pdf.PdfFormat.PDF_A_3B
com.aspose.pdf.PdfFormat.PDF_A_3U
com.aspose.pdf.PdfFormat.PDF_X_3

**Added new class com.aspose.pdf.PdfFormatConversionOptions** 
constructors:
com.aspose.pdf.PdfFormatConversionOptions.#ctor(String,int,int)
com.aspose.pdf.PdfFormatConversionOptions.#ctor(String,int)
com.aspose.pdf.PdfFormatConversionOptions.#ctor(int)
com.aspose.pdf.PdfFormatConversionOptions.#ctor(int,int)
com.aspose.pdf.PdfFormatConversionOptions.#ctor(String,int,int,int)
com.aspose.pdf.PdfFormatConversionOptions.#ctor(OutputStream,int,int)
methods:
com.aspose.pdf.PdfFormatConversionOptions.isLowMemoryMode
com.aspose.pdf.PdfFormatConversionOptions.setLowMemoryMode(boolean)
com.aspose.pdf.PdfFormatConversionOptions.getFormat
com.aspose.pdf.PdfFormatConversionOptions.setFormat(int)
com.aspose.pdf.PdfFormatConversionOptions.getLogFileName
com.aspose.pdf.PdfFormatConversionOptions.setLogFileName(String)
com.aspose.pdf.PdfFormatConversionOptions.getLogStream
com.aspose.pdf.PdfFormatConversionOptions.setLogStream(OutputStream)
com.aspose.pdf.PdfFormatConversionOptions.getErrorAction
com.aspose.pdf.PdfFormatConversionOptions.setErrorAction(int)
com.aspose.pdf.PdfFormatConversionOptions.getTransparencyAction
com.aspose.pdf.PdfFormatConversionOptions.setTransparencyAction(int)
com.aspose.pdf.PdfFormatConversionOptions.getDefault
com.aspose.pdf.PdfFormatConversionOptions.getNonSpecificationCases
com.aspose.pdf.PdfFormatConversionOptions.getAlignText
com.aspose.pdf.PdfFormatConversionOptions.setAlignText(boolean)
com.aspose.pdf.PdfFormatConversionOptions.getPuaTextProcessingStrategy
com.aspose.pdf.PdfFormatConversionOptions.setPuaTextProcessingStrategy(int)
com.aspose.pdf.PdfFormatConversionOptions.getOptimizeFileSize
com.aspose.pdf.PdfFormatConversionOptions.setOptimizeFileSize(boolean)
com.aspose.pdf.PdfFormatConversionOptions.getExcludeFontsStrategy
com.aspose.pdf.PdfFormatConversionOptions.setExcludeFontsStrategy(byte)
com.aspose.pdf.PdfFormatConversionOptions.getFontEmbeddingOptions
com.aspose.pdf.PdfFormatConversionOptions.getIccProfileFileName
com.aspose.pdf.PdfFormatConversionOptions.setIccProfileFileName(String)
com.aspose.pdf.PdfFormatConversionOptions.getNotAccessibleFonts
fields
com.aspose.pdf.PdfFormatConversionOptions.AlignStrategy

**Added new class com.aspose.pdf.PdfFormatConversionOptions.SegmentAlignStrategy** 
fields:
com.aspose.pdf.PdfFormatConversionOptions.SegmentAlignStrategy.None
com.aspose.pdf.PdfFormatConversionOptions.SegmentAlignStrategy.RestoreSegmentBounds

**Added new class com.aspose.pdf.PdfFormatConversionOptions.PuaProcessingStrategy** 
fields:
com.aspose.pdf.PdfFormatConversionOptions.PuaProcessingStrategy.None
com.aspose.pdf.PdfFormatConversionOptions.PuaProcessingStrategy.SurroundPuaTextWithEmptyActualText
com.aspose.pdf.PdfFormatConversionOptions.PuaProcessingStrategy.SubstitutePuaSymbols

**Added new class com.aspose.pdf.PdfFormatConversionOptions.RemoveFontsStrategy** 
fields:
com.aspose.pdf.PdfFormatConversionOptions.RemoveFontsStrategy.RemoveDuplicatedFonts
com.aspose.pdf.PdfFormatConversionOptions.RemoveFontsStrategy.RemoveSimilarFontsWithDifferentWidths
com.aspose.pdf.PdfFormatConversionOptions.RemoveFontsStrategy.SubsetFonts

**Added new class com.aspose.pdf.Point3D** 
constructors:
com.aspose.pdf.Point3D.#ctor(double,double,double)
methods:
com.aspose.pdf.Point3D.getX
com.aspose.pdf.Point3D.setX(double)
com.aspose.pdf.Point3D.getY
com.aspose.pdf.Point3D.setY(double)
com.aspose.pdf.Point3D.getZ
com.aspose.pdf.Point3D.setZ(double)
com.aspose.pdf.Point3D.getTrivial

**Added new class com.aspose.pdf.PsLoadOptions** 
constructors:
com.aspose.pdf.PsLoadOptions.#ctor
methods:
com.aspose.pdf.PsLoadOptions.getFontsFolders
com.aspose.pdf.PsLoadOptions.setFontsFolders(String[])

**Added new class com.aspose.pdf.RenderingOptions** 
constructors:
com.aspose.pdf.RenderingOptions.#ctor
methods:
com.aspose.pdf.RenderingOptions.getConvertFontsToUnicodeTTF
com.aspose.pdf.RenderingOptions.setConvertFontsToUnicodeTTF(boolean)
com.aspose.pdf.RenderingOptions.getUseFontHinting
com.aspose.pdf.RenderingOptions.setUseFontHinting(boolean)
com.aspose.pdf.RenderingOptions.getScaleImagesToFitPageWidth
com.aspose.pdf.RenderingOptions.setScaleImagesToFitPageWidth(boolean)
com.aspose.pdf.RenderingOptions.getInterpolationHighQuality
com.aspose.pdf.RenderingOptions.setInterpolationHighQuality(boolean)
com.aspose.pdf.RenderingOptions.getMaxFontsCacheSize
com.aspose.pdf.RenderingOptions.setMaxFontsCacheSize(int)
com.aspose.pdf.RenderingOptions.getMaxSymbolsCacheSize
com.aspose.pdf.RenderingOptions.setMaxSymbolsCacheSize(int)

**Added new class com.aspose.pdf.RenderModeType** 
fields
com.aspose.pdf.RenderModeType.Solid
com.aspose.pdf.RenderModeType.SolidWireframe
com.aspose.pdf.RenderModeType.Transparent
com.aspose.pdf.RenderModeType.TransparentWareFrame
com.aspose.pdf.RenderModeType.BoundingBox
com.aspose.pdf.RenderModeType.TransparentBoundingBox
com.aspose.pdf.RenderModeType.TransparentBoundingBoxOutline
com.aspose.pdf.RenderModeType.Wireframe
com.aspose.pdf.RenderModeType.ShadedWireframe
com.aspose.pdf.RenderModeType.Vertices
com.aspose.pdf.RenderModeType.ShadedVertices
com.aspose.pdf.RenderModeType.Illustration
com.aspose.pdf.RenderModeType.SolidOutline
com.aspose.pdf.RenderModeType.ShadedIllustration

**Added new class com.aspose.pdf.TextEditOptions.LanguageTransformation** 
fields
com.aspose.pdf.TextEditOptions.LanguageTransformation.Default
com.aspose.pdf.TextEditOptions.LanguageTransformation.ExactlyAsISee
com.aspose.pdf.TextEditOptions.LanguageTransformation.None

**Changes in class com.aspose.pdf.XImage** 
Renamed methods
om.aspose.pdf.XImage.save(OutputStream,ImageFormat) -> com.aspose.pdf.XImage.save(OutputStream,ImageType)
com.aspose.pdf.XImage.saveInternal(Stream,ImageFormat,int) -> com.aspose.pdf.XImage.saveInternal(Stream,ImageType,int)
com.aspose.pdf.XImage.save(OutputStream,ImageFormat,int) -> com.aspose.pdf.XImage.save(OutputStream,ImageType,int)

**Changes in class com.aspose.pdf.XYZExplicitDestination** 
Added constructors
com.aspose.pdf.XYZExplicitDestination.#ctor(int,double,double,double)
Added methods
com.aspose.pdf.XYZExplicitDestination.createDestinationToUpperLeftCorner(Page)
com.aspose.pdf.XYZExplicitDestination.createDestination(Page,double,double,double,boolean)
com.aspose.pdf.XYZExplicitDestination.createDestinationToUpperLeftCorner(Page,double)
## **Code Samples for New Features**
**New Features PDFANDROID-511 PDF to PDFA conversion support**

{{< highlight java >}}

 Document doc = new Document(inFile); 

OutputStream logStream = new FileOutputStream("log.xml"); 

doc.convert(logStream, PdfFormat.PDF_A_1A, ConvertErrorAction.Delete); 

doc.save(outFile);

{{< /highlight >}}

**New Features PDFANDROID-520 Creating NamedDestination in existing PDF**

{{< highlight java >}}

 Document doc = new Document(getInputPath("43480.pdf")); 

PdfAction act = doc.getOutlines().getFirst().getAction(); 

NamedDestinationCollection destination = doc.getNamedDestinations(); 

IAppointment app1 = destination.get_Item("bm305"); 

IAppointment app2 = destination.get_Item("added"); 

destination.set_Item("aaa", new XYZExplicitDestination(1, 0, 0, 0.5)); 

String[] k = destination.getNames(); 

LinkAnnotation link = new LinkAnnotation(doc.getPages().get_Item(1), new Rectangle(0, 0, 100, 100));

GoToAction action = new GoToAction(); 

action.setDestination(new NamedDestination(doc, "aaa")); 

link.setAction(action); 

doc.getPages().get_Item(1).getAnnotations().add(link); 

doc.save("output.pdf");

{{< /highlight >}}

**New Features PDFANDROID-509 Add Support for Metered License**

{{< highlight java >}}

 Metered matered = new Metered(); 

matered.setMeteredKey(publicKey, privateKey);

{{< /highlight >}}

**New Features PDFANDROID-516 Add support of Conholdate License**

{{< highlight java >}}

 License lic = new License(); 

lic.setLicense("../License/Conholdate.Total.lic");

{{< /highlight >}}

