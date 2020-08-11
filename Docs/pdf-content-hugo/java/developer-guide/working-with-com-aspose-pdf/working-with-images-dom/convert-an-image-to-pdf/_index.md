---
title: Convert an Image to PDF
type: docs
weight: 70
url: /java/convert-an-image-to-pdf/
---

{{% alert color="primary" %}} 

Images are often used to clarify or illustrate data and are often shared between colleagues. Sharing images in PDF format is a convenient way to ensure that everyone can view them. To this end, Aspose.PDF for Java supports converting images to PDF.

{{% /alert %}} 

The following table shows the image formats that Aspose.PDF can convert to PDF.

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
### **Aspose.PDF Image Approach**
A PDF document comprises pages and each page contains one or more paragraph objects. A paragraph can be a text, image, table, floating box, graph, heading, form field or an attachment. To convert an image file into PDF format, enclose it in a paragraph.

It is possible to convert images at a physical location on the local hard drive, found at a web URL or in a Stream instance. To add an image:

1. Create an object of the [com.aspose.pdf.Image](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Image) class.
1. Add the image to a Paragraphs collection of page instance.
1. Specify the path or source of Image.
   1. If an image is at a location on the hard drive, specify the path location using the [Image.setFile(...)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Image#setFile-java.lang.String-) method.
1. If an image is placed in a FileInputStream, pass the object holding the image to the Image.setImageStream(...) method.

The following code snippet shows how to load an image object, set the page margin, place the image on page and save the output as PDF.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Images-ConvertAnImageToPDF-PdfImageApproach.java" >}}
### **Add image from BufferedImage**
Aspose.PDF for Java also offers the feature to load image from Stream instance where an image can be loaded to **BufferedImage** object and can be placed inside paragraphs collection of Pdf file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-images-ConvertAnImageToPDF-AddImageFromBufferedImage.java" >}}
