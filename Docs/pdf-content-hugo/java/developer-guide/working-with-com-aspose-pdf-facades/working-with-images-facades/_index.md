---
title: Working with Images - facades
type: docs
weight: 40
url: /java/working-with-images-facades/
---

## **Convert PDF Pages to Different Image Formats (Facades)**
In order to convert PDF pages to different image formats, you need to create [PdfConverter](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfConverter) object and open the PDF file using bindPdf method. After that, you need to call doConvert method for initialization tasks. Then, you can loop through all the pages using hasNextImage and getNextImage methods. The getNextImage method allows you to create image of a particular page. You also need to pass ImageType to this method in order to create an image of specific type i.e. JPEG, GIF or PNG etc. Finally, call the close method of the [PdfConverter](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfConverter) class. 
The following code snippet shows you how to convert PDF pages to images.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Images-ConvertPDFPagesToDifferentImageFormats-.java" >}}
## **Convert particular page region to Image format**
We know that [PdfConverter](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfConverter) class offers doConvert(..) method which provides the capability to convert the whole PDF pages into Image format. However sometimes there is a requirement to convert particular page region into Image format, so in order to fulfill this requirement, we may consider using movePosition(..) method of [PdfPageEditor](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfPageEditor) class which provides the capability to move the origin from (0, 0) to the specified point. The origin is left-bottom and the unit is point.

We are also aware that [PdfPageEditor](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfPageEditor) class also contains methods which provide the capability to loop through all the pages using hasNextImage(..) and getNextImage(..) methods. The getNextImage(..) method allows you to create image of a particular page. You also need to pass ImageFormat to this method in order to create an image of specific type i.e. JPEG, GIF or PNG etc. Finally, call the Close method of the [PdfConverter](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfConverter) class.

{{% alert color="primary" %}} 

1 inch = 72 points and 1 cm = 1/2.54 inch = 0.3937 inch = 28.3 points.

{{% /alert %}} 

The following code snippet shows you how to convert PDF pages to images.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Images-ConvertParticularPageRegionToImageFormat-.java" >}}
## **Extract Images from the Whole PDF to Files (facades)**
[PdfExtractor](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfExtractor) class allows you to extract images from a PDF file. First off, you need to create an object of [PdfExtractor](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfExtractor#extractImage--) class and bind input PDF file using bindPdf method. After that, call [extractImage](http://www.aspose.com/api/java/pdf/com.aspose.pdf.facades/classes/pdfextractor/methods/extractImage\(\)/) method to extract all the images into memory. Once the images are extracted, you can get those images with the help of hasNextImage and getNextImage methods. You need to loop through all the extracted images using a while loop. In order to save the images to disk, you can call the overload of the getNextImage method which takes file path as argument. The following code snippet shows you how to extract images from the whole PDF to files.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Images-ExtractImagesFromTheWholePDFToFiles-.java" >}}
## **Extract Chart objects from PDF document (facades)**
The PDF allow to group page content into elements named as **Marked Content**. Adobe Acrobat shows them as "containers". The Chart objects are placed in such objects. We have introduced a new method extractMarkedContentAsImages() in PdfExtractor class to extract these object. This method render every **Marked Content** into a separate image. Please note all the charts are not fully placed into one container. Because of this some charts will be saved into separate images by parts.

Please note that the correct grouping of content into containers is the responsibility of a PDF document designer. If you want to get charts with header or other objects you should either edit/create the PDF document where whole chart is placed in one container.

**Java**

{{< highlight java >}}

 //Open document

Document document = new Document("sample.pdf");

//instantiate PdfExtractor

PdfExtractor pdfExtractor = new PdfExtractor();

//Extract Chart objects as image in a folder

pdfExtractor.extractMarkedContentAsImages(document.getPages().get_Item(1), "C:/Temp/Charts_page_1");

document.close();

{{< /highlight >}}


## **Replace Image in an Existing PDF File (facades)**
[PdfContentEditor](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfContentEditor#replaceText-java.lang.String-int-java.lang.String-) class allows you to replace image in an existing PDF file. The [replaceImage](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfContentEditor#replaceImage-int-int-java.lang.String-) method helps you achieve this goal. You need to create an object of [PdfContentEditor](http://www.aspose.com/api/java/pdf/com.aspose.pdf.facades/classes/PdfContentEditor) class and bind the input PDF file using bindPdf method. After that, you need to call [replaceImage](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfContentEditor#replaceImage-int-int-java.lang.String-) method with three parameters: a page number, index of the image to replace, and path of the image to be replaced. 
The following code snippet shows you how to replace an image in an existing PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Images-ReplaceImageInAnExistingPDFFile-.java" >}}
