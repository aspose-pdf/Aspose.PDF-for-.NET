---
title: Convert CGM Image to PDF
type: docs
weight: 10
url: /net/convert-cgm-image-to-pdf/
---

## **Convert CGM Image to PDF**
{{% alert color="primary" %}} 

You can check the quality of Aspose.PDF conversion and view the results online at this link:

[products.aspose.app/pdf/merger/cgm-to-pdf](https://products.aspose.app/pdf/merger/cgm-to-pdf) {{% /alert %}} 

Computer Graphics Metafile (CGM) is a free and open international standard file format for 2D vector graphics, raster graphics, and text defined by ISO/IEC 8632. Aspose.PDF for .NET supports converting CGM files into PDF.

{{% alert color="primary" %}} 
Please note that the development is based on ISO 8632-3 (binary encoding) specifications and the binary CGM files defined in ISO/IEC 8632-3 (CGM Levels 1-2-3-4) are supported. We are sorry to share that the current release of Aspose.PDF for .NET does not support clear-text encoding.
{{% /alert %}} 

### **Supported CGM Commands**
Please look at the list of CGM commands specified below and their level of support in Aspose.PDF for .NET
Legend:
<br> + : supported 
<br> - : unsupported
<br> ! : partially supported
#### **Delimiter Elements: Class 0**

|**Class**|**Element Code**|**Element Name**|**Status**|**Comment**|
| :- | :- | :- | :- | :- |
|0|0|NO OP|+| |
|0|1|BEGIN METAFILE|+| |
|0|2|END METAFILE|+| |
|0|3|BEGIN PICTURE|+| |
|0|4|BEGIN PICTURE BODY|+| |
|0|5|END PICTURE|+| |
|0|6|BEGIN SEGMENT|+| |
|0|7|END SEGMENT|+| |
|0|8|BEGIN FIGURE|+| |
|0|9|END FIGURE|+| |
|0|13|BEGIN PROTECTION REGION|-| |
|0|14|END PROTECTION REGION|-| |
|0|15|BEGIN COMPOUND LINE|-| |
|0|16|END COMPOUND LINE|-| |
|0|17|BEGIN COMPOUND TEXT PATH|-| |
|0|18|END COMPOUND TEXT PATH|-| |
|0|19|BEGIN TILE ARRAY|-| |
|0|20|END TILE ARRAY|-| |
|0|21|BEGIN APPLICATION STRUCTURE|-| |
|0|22|BEGIN APPLICATION STRUCTURE BODY|-| |
|0|23|END APPLICATION STRUCTURE|-| |
#### **Metafile Descriptor Elements: Class 1**

|**Class**|**Element Code**|**Element Name**|**Status**|**Comment**|
| :- | :- | :- | :- | :- |
|1|1|METAFILE VERSION|+| |
|1|2|METAFILE DESCRIPTION|+| |
|1|3|VDC TYPE|+| |
|1|4|INTEGER PRECISION|+| |
|1|5|REAL PRECISION|+| |
|1|6|INDEX PRECISION|+| |
|1|7|COLOUR PRECISION|+| |
|1|8|COLOUR INDEX PRECISION|+| |
|1|9|MAXIMUM COLOUR INDEX|+| |
|1|10|COLOUR VALUE EXTENT|+| |
|1|11|METAFILE ELEMENT LIST|-| |
|1|12|METAFILE DEFAULTS REPLACEMENT|+| |
|1|13|FONT LIST|+| |
|1|14|CHARACTER SET LIST|-| |
|1|15|CHARACTER CODING ANNOUNCER|-| |
|1|16|NAME PRECISION|+| |
|1|17|MAXIMUM VDC EXTENT|+| |
|1|18|SEGMENT PRIORITY EXTENT|-| |
|1|19|COLOUR MODEL|!|Color spaces other than RGB and CMYK are not implemented.|
|1|20|COLOUR CALIBRATION|-| |
|1|21|FONT PROPERTIES|-| |
|1|22|GLYPH MAPPING|-| |
|1|23|SYMBOL LIBRARY LIST|-| |
|1|24|PICTURE DIRECTORY|-| |
#### **Picture Descriptor Elements: Class 2**

|**Class**|**Element Code**|**Element Name**|**Status**|**Comment**|
| :- | :- | :- | :- | :- |
|2|1|SCALING MODE|+| |
|2|2|COLOUR SELECTION MODE|+| |
|2|3|LINE WIDTH SPECIFICATION MODE|+| |
|2|4|MARKER SIZE SPECIFICATION MODE|+| |
|2|5|EDGE WIDTH SPECIFICATION MODE|+| |
|2|6|VDC EXTENT|+| |
|2|7|BACKGROUND COLOUR|+| |
|2|8|DEVICE VIEWPORT|-| |
|2|9|DEVICE VIEWPORT SPECIFICATION MODE|-| |
|2|10|DEVICE VIEWPORT MAPPING|-| |
|2|11|LINE REPRESENTATION|-| |
|2|12|MARKER REPRESENTATION|-| |
|2|13|TEXT REPRESENTATION|-| |
|2|14|FILL REPRESENTATION|-| |
|2|15|EDGE REPRESENTATION|-| |
|2|16|INTERIOR STYLE SPECIFICATION MODE|-| |
|2|17|LINE AND EDGE TYPE DEFINITION|+| |
|2|18|HATCH STYLE DEFINITION|-| |
|2|19|GEOMETRIC PATTERN DEFINITION|-| |
|2|20|APPLICATION STRUCTURE DIRECTORY|-| |
#### **Control Elements: Class 3**

|**Class**|**Element Code**|**Element Name**|**Status**|**Comment**|
| :- | :- | :- | :- | :- |
|3|1|VDC INTEGER PRECISION|+| |
|3|2|VDC REAL PRECISION|+| |
|3|3|AUXILIARY COLOUR|-| |
|3|4|TRANSPARENCY|-| |
|3|5|CLIP RECTANGLE|+| |
|3|6|CLIP INDICATOR|-| |
|3|7|LINE CLIPPING MODE|-| |
|3|8|MARKER CLIPPING MODE|-| |
|3|9|EDGE CLIPPING MODE|-| |
|3|10|NEW REGION|-| |
|3|11|SAVE PRIMITIVE CONTEXT|-| |
|3|12|RESTORE PRIMITIVE CONTEXT|-| |
|3|17|PROTECTION REGION INDICATOR|-| |
|3|18|GENERALIZED TEXT PATH MODE|-| |
|3|19|MITRE LIMIT|+| |
|3|20|TRANSPARENT CELL COLOUR|-| |
#### **Graphical Primitive Elements: Class 4**

|**Class**|**Element Code**|**Element Name**|**Status**|**Comment**|
| :- | :- | :- | :- | :- |
|4|1|POLYLINE|+| |
|4|2|DISJOINT POLYLINE|+| |
|4|3|POLYMARKER|+| |
|4|4|TEXT|+| |
|4|5|RESTRICTED TEXT|+| |
|4|6|APPEND TEXT|+| |
|4|7|POLYGON|+| |
|4|8|POLYGON SET|+| |
|4|9|CELL ARRAY|+| |
|4|10|GENERALIZED DRAWING PRIMITIVE|+| |
|4|11|RECTANGLE|+| |
|4|12|CIRCLE|+| |
|4|13|CIRCULAR ARC 3 POINT|+| |
|4|14|CIRCULAR ARC 3 POINT CLOSE|+| |
|4|15|CIRCULAR ARC CENTRE|+| |
|4|16|CIRCULAR ARC CENTRE CLOSE|+| |
|4|17|ELLIPSE|+| |
|4|18|ELLIPTICAL ARC|+| |
|4|19|ELLIPTICAL ARC CLOSE|+| |
|4|20|CIRCULAR ARC CENTRE REVERSED|-| |
|4|21|CONNECTING EDGE|+| |
|4|22|HYPERBOLIC ARC|-| |
|4|23|PARABOLIC ARC|-| |
|4|24|NON UNIFORM B SPLINE|-| |
|4|25|NON UNIFORM RATIONAL B SPLINE|-| |
|4|26|POLYBEZIER|+| |
|4|27|POLYSYMBOL|-| |
|4|28|BITONAL TILE|-| |
|4|29|TILE|-| |
#### **Attribute Elements: Class 5**

|**Class**|**Element Code**|**Element Name**|**Status**|**Comment**|
| :- | :- | :- | :- | :- |
|5|1|LINE BUNDLE INDEX|+| |
|5|2|LINE TYPE|+| |
|5|3|LINE WIDTH|+| |
|5|4|LINE COLOUR|+|Color spaces other than RGB and CMYK are not implemented.|
|5|5|MARKER BUNDLE INDEX|+| |
|5|6|MARKER TYPE|+| |
|5|7|MARKER SIZE|+| |
|5|8|MARKER COLOUR|+|Color spaces other than RGB and CMYK are not implemented.|
|5|9|TEXT BUNDLE INDEX|+| |
|5|10|TEXT FONT INDEX|+| |
|5|11|TEXT PRECISION|+| |
|5|12|CHARACTER EXPANSION FACTOR|+| |
|5|13|CHARACTER SPACING|+| |
|5|14|TEXT COLOUR|+|Color spaces other than RGB and CMYK are not implemented.|
|5|15|CHARACTER HEIGHT|+| |
|5|16|CHARACTER ORIENTATION|+| |
|5|17|TEXT PATH|+| |
|5|18|TEXT ALIGNMENT|+| |
|5|19|CHARACTER SET INDEX|-| |
|5|20|ALTERNATE CHARACTER SET INDEX|-| |
|5|21|FILL BUNDLE INDEX|+| |
|5|22|INTERIOR STYLE|+| |
|5|23|FILL COLOUR|+|Color spaces other than RGB and CMYK are not implemented.|
|5|24|HATCH INDEX|+| |
|5|25|PATTERN INDEX|+| |
|5|26|EDGE BUNDLE INDEX|+| |
|5|27|EDGE TYPE|+| |
|5|28|EDGE WIDTH|+| |
|5|29|EDGE COLOUR|+| |
|5|30|EDGE VISIBILITY|+| |
|5|31|FILL REFERENCE POINT|+| |
|5|32|PATTERN TABLE|+| |
|5|33|PATTERN SIZE|+| |
|5|34|COLOUR TABLE|+| |
|5|35|ASPECT SOURCE FLAGS|!|Only color values|
|5|36|PICK IDENTIFIER|-| |
|5|37|LINE CAP|+| |
|5|38|LINE JOIN|+| |
|5|39|LINE TYPE CONTINUATION|-| |
|5|40|LINE TYPE INITIAL OFFSET|-| |
|5|41|TEXT SCORE TYPE|-| |
|5|42|RESTRICTED TEXT TYPE|-| |
|5|43|INTERPOLATED INTERIOR|-| |
|5|44|EDGE CAP|+| |
|5|45|EDGE JOIN|+| |
|5|46|EDGE TYPE CONTINUATION|-| |
|5|47|EDGE TYPE INITIAL OFFSET|-| |
|5|48|SYMBOL LIBRARY INDEX|-| |
|5|49|SYMBOL COLOUR|-| |
|5|50|SYMBOL SIZE|-| |
|5|51|SYMBOL ORIENTATION|-| |
#### **Escape Elements: Class 6**

|**Class**|**Element Code**|**Element Name**|**Status**|**Comment**|
| :- | :- | :- | :- | :- |
|6|1|ESCAPE|-| |
#### **External Elements: Class 7**

|**Class**|**Element Code**|**Element Name**|**Status**|**Comment**|
| :- | :- | :- | :- | :- |
|7|1|MESSAGE|-| |
|7|2|APPLICATION DATA|-| |
#### **Segment Elements: Class 8**

|**Class**|**Element Code**|**Element Name**|**Status**|**Comment**|
| :- | :- | :- | :- | :- |
|8|1|COPY SEGMENT|+| |
|8|2|INHERITANCE FILTER|-| |
|8|3|CLIP INHERITANCE|-| |
|8|4|SEGMENT TRANSFORMATION|+| |
|8|5|SEGMENT HIGHLIGHTING|-| |
|8|6|SEGMENT DISPLAY PRIORITY|+| |
|8|7|SEGMENT PICK PRIORITY|-| |
#### **Application Structure Descriptor Elements: Class 9**

|**Class**|**Element Code**|**Element Name**|**Status**|**Comment**|
| :- | :- | :- | :- | :- |
|9|1|APPLICATION STRUCTURE ATTRIBUTE|-| |
Aspose has always been committed to provide robust, easy to use and scalable products and keeping this tradition alive, converting CGM PDF is very easy. The [PdfProducer](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdfproducer) class under [Aspose.PDF.Facades](https://apireference.aspose.com/pdf/net/aspose.pdf.facades)) namespace provides a method named [Producer](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdfproducer/methods/produce) which can be used to convert CGM files into PDF. Please take a look over following code snippet which shows the conversion of CGM file into PDF.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Images-CGMImageToPDF-CGMImageToPDF.cs" >}}

Some CGM files have very large size (width x height) and there are situations when you need to load the CGM file with a specific size and convert it to PDF. In order to accomplish this requirement, use the [CgmImportOptions](https://apireference.aspose.com/net/pdf/aspose.pdf/cgmimportoptions) in the Aspose.PDF namespace which provides the feature to load CGM files with a custom size. Please note that one of the overloaded methods of the [Producer](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdfproducer/methods/produce) class accepts [CgmImportOptions](https://apireference.aspose.com/net/pdf/aspose.pdf/cgmimportoptions) as an argument. The following code snippet explains this behavior.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Images-LargeCGMImageToPDF-LargeCGMImageToPDF.cs" >}}
#### **Known Issues**
{{% alert color="primary" %}} 

- "Restricted Text Command" converted without applying "text path" settings.
- "Clip Rectangle Command" doesn't work properly with text glyphs.

{{% /alert %}} 

Images are often used to clarify or illustrate data and are often shared between colleagues. Sharing images in PDF format is a convenient way to ensure that everyone can view them. To this end, Aspose.PDF for .NET supports converting images to PDF. The following table shows the image formats that Aspose.PDF can convert to PDF.

|**Image File Types**|**Description**|
| :- | :- |
|CCITT|CCITT is a lossless image compression method used in Group 4 fax machines. It is used for black and white images only.|
|GIF|Graphics Interchange Format, a bitmap image format frequently used on the web, uses a lossless compression.|
|JPEG|Joint Photographic Experts Group is a lossy compression method for digital images, developed for use with digital photography.|
|PNG|Portable Network Graphics is an improved, non-patented replacement for GIF and is a popular lossless image compression format used on the web.|
|TIFF|Tagged Image File Format is a file format for storing raster graphics. It is widely used in word processing and digital image manipulation applications.|
|BMP|The bitmap file format is a raster graphics image format used to store digital images. It is created to be device independent.|
|EMF|Enhanced Meta File is a 32-bit version of Microsoft's Windows Meta File format.|
|Exif|Exchangeable Image File format specifies formats for images, sound and other tags used by digital cameras, smartphones and other devices.|
|Icon|ICO files are files that hold icons – pictograms representing actions, for example – for computer interfaces.|
|WMF|Windows Meta File is a device independent image format aimed to take both vector and raster graphics.|
|MemoryBmp|MemoryBmp type|
|Unknown|Unknown file type.|

