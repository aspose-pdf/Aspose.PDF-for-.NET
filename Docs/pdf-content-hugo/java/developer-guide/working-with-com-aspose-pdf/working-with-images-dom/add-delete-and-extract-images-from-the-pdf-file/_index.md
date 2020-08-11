---
title: Add, Delete and Extract Images from the PDF file
type: docs
weight: 10
url: /java/add-delete-and-extract-images-from-the-pdf-file/
---

## **Add Image to Existing PDF File**
Every PDF page object contains the [getResources()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#getResources--) and [getContents()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#getContents--) methods. Resources can be images and forms, for example, while content is represented by a set of PDF operators. Each operator has its own name and argument. This example use operators to add an image to a PDF file.

To add an image to an existing PDF file:

1. Create a [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object and open the input PDF document.
1. Get the page you want to add an image to.
1. Add the image into the page's [getResources()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#getResources--) collection.
1. Use operators to place the image on the page:
   1. Use the GSave operator to save the current graphical state.
   1. Use the ConcatenateMatrix operator to specify where the image is to be placed.
   1. Use the Do operator to draw the image on the page.
   1. Finally, use the GRestore operator to save the updated graphical state.
1. Save the file.

The following code snippet shows how to add image to a PDF document.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-images-AddImageToExistingPDFFile-AddImageToExistingPDFFile.java" >}}
### **Adding image from BufferedImage into PDF**
Starting release of [Aspose.PDF for Java 9.5.0](http://www.aspose.com/community/files/72/java-components/aspose.pdf-for-java/entry576058.aspx), we have introduced the support to add image from BufferedImage instance to PDF document. In order to support this requirement, a method is implemented: [XImageCollection](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/XImageCollection).add(BufferedImage image);

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-images-AddImageToExistingPDFFile-AddingImageFromBufferedImageIntoPDF.java" >}}


You can use any InputStream and not just only FileInputStream object to add image. So when using java.io.ByteArrayInputStream object, you do not need to store any files over system:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Images-AddImageToExistingPDFFile-Info.java" >}}
## **Delete Images from the PDF File**
To delete an image from a PDF file, simply use the Images collection's delete(..) method.

The Images collection can be found in a page's [Resources](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Resources) collection, and you get a given [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) from the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's Pages collection.

1. Create [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object and open the input PDF file.
1. Delete the image.
1. Save the file.

The following code snippet shows how.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-images-DeleteImagesFromThePDFFile-.java" >}}
## **Extract Images from the PDF File**
Each page holds a [Resources](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Resources) collection, and this, in turn, holds the Images collection, were all images in a page are kept. The [XImage](https://apireference.aspose.com/java/pdf/com.aspose.pdf/XImage) object gets a given image in the Images collection.

To extract and image from a page:

1. Get the image from the Images collection using the image index.
1. Use the [XImage](https://apireference.aspose.com/java/pdf/com.aspose.pdf/XImage) object's save(..) method to save the extracted image.

The following code snippet shows you how to extract images from the PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-images-ExtractImagesFromThePDFFile-.java" >}}
## **Replace Image in an Existing PDF File**
The Images collection's replace(..) method allows you to replace an image in a PDF file. The Images collection can be found in a page's [Resources](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Resources) collection.

To replace an image, open the PDF file using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object. Once the image is replaced, save the updated PDF file using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's save(..) method.

The following code snippet shows how to replace an image in a PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-images-ReplaceImageInExistingPDFFile-.java" >}}
## **Delete Image from PDF Resources found by ImagePlacementAbsorber**
To delete an image from a PDF file, you can simply use the Images collection's delete(..) method. However, to delete image from the PDF resources found by [ImagePlacementAbsorber](https://apireference.aspose.com/java/pdf/com.aspose.pdf/ImagePlacementAbsorber), use the com.aspose.pdf.[XImage](https://apireference.aspose.com/java/pdf/com.aspose.pdf/XImage).delete() method.

The following approach gets images from a PDF file and tries to delete them. Please note that an exception might be generated while removing image from PDF files.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-images-DeleteImageFromPDFResourcesFoundByImagePlacementAbsorber-.java" >}}
## **Support for DICOM Images**
Aspose.PDF for .NET supports functionality to add [DICOM](https://wiki.fileformat.com/image/dicom/) images to PDF documents. The following code snippet shows how to use this functionality.

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-Images-AddImage-AddDicomImage.java" >}}
