---
title: Adding Stamp in a PDF file
type: docs
weight: 10
url: /java/adding-stamp-in-a-pdf-file/
---

## **Add Page Number Stamp in a PDF file**
You can use [PageNumberStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/PageNumberStamp) class to add a page number stamp in a PDF document. The [PageNumberStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/PageNumberStamp) class provides methods to create a page number based stamp like format, margins, alignments, starting number etc. In order to add page number stamp, you need to create a [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object and a [PageNumberStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/PageNumberStamp) object with required properties. After that, you can call [addStamp(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#addStamp-com.aspose.pdf.Stamp-) method of the [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) class to add the stamp in PDF file. You can also set the font attributes of the page number stamp.

The following code snippet shows you how to add page numbers in a PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-stampsandwatermarks-AddPageNumberStampInPDF-.java" >}}


## **Add Text Stamp in a PDF file**
Aspose.PDF for Java provides [TextStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextStamp) class to add a text stamp in a PDF file. The [TextStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextStamp) class provides necessary methods to specify font size, font style, and font color etc for stamp object. In order to add text stamp, first you need to create a [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object and a [TextStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextStamp) object using required methods. After that, you may call [addStamp(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#addStamp-com.aspose.pdf.Stamp-) method of the [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) class to add the stamp in the PDF document.

The following code snippet shows you how to add text stamp in the PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-StampsAndWatermarks-AddingTextStampInPDFFile-.java" >}}


In order to add Text stamp on all pages, please iterate through all pages and add call [[addStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#addStamp-com.aspose.pdf.Stamp-)](textStamp) method.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-StampsAndWatermarks-AddingTextStampInPDFFile-InfoClass.java" >}}
### **Define alignment for TextStamp object**
Adding watermarks to PDF documents is one of the frequent demanded features and Aspose.PDF for Java is fully capable of adding Image as well as Text watermarks. The [TextStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextStamp) class provides the feature to add text stamps over the PDF file. Recently there has been a requirement to support the feature to specify the alignment of text when using [TextStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextStamp) object. So in order to fulfill this requirement, we have introduced setTextAlignment(..) method in [TextStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextStamp) class. By using this method, you can specify the Horizontal text alignment.

The following code snippets shows an example on how to load an existing PDF document and add [TextStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextStamp) over it.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-stampsandwatermarks-DefineAlignmentForTextStampObject-.java" >}}

|![todo:image_alt_text](http://i.imgur.com/qfLATYl.png)|
| :- |
|**Figure: Output PDF file displaying stamp alignment feature**|

## **Add Image Stamp in a PDF file**
You can use [ImageStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/ImageStamp) class to add an image as a stamp in PDF document. The [ImageStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/ImageStamp) class provides methods to specify height, width, and opacity etc. In order to add image stamp, first you need to create a [Document](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Document) object and an [ImageStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/ImageStamp) object with required properties. After that, you need to call [addStamp(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#addStamp-com.aspose.pdf.Stamp-) method of the [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) class to add the stamp in the PDF.

The following code snippet shows you how to add image stamp in the PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-stampsandwatermarks-AddingImageStampInPDFFile-.java" >}}
### **Control Image Quality when Adding Image Stamp**
The [ImageStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/ImageStamp) class lets you add an image as a stamp in a PDF document. It also allows you to control the image quality when adding an image as a watermark in a PDF file. To allow this, a method named setQuality(...) has been added to the [ImageStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/ImageStamp) class. A similar method can also be found in the [Stamp](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Stamp) class of the com.aspose.pdf.facades package. Please note that possible values for this method are (0..100).

The following code snippet shows you how to control image quality when adding as stamp in the PDF file.
#### **DOM approach**
{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-stampsandwatermarks-ControlImageQualityWhenAddingImageStamp-DOMApproch.java" >}}


#### **Facades approach**
{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-stampsandwatermarks-ControlImageQualityWhenAddingImageStamp-FacadesApproach.java" >}}


## **Add PDF Page Stamp in a PDF file**
You can use [PdfPageStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/PdfPageStamp) class to add a PDF page as stamp in a PDF file. [PdfPageStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/PdfPageStamp) class provides properties necessary to create a PDF page based stamp. You can pass a particular page of any PDF file to the constructor of [PdfPageStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/PdfPageStamp) class. In order to add page based stamp, you need to create a [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object and a [PdfPageStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/PdfPageStamp) object using required properties. After that, you can call [addStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#addStamp-com.aspose.pdf.Stamp-) method of the [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) to add the stamp in the PDF. The following code snippet shows you how to add PDF page stamp in a PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-stampsandwatermarks-AddingPDFPageStampInThePDFFile-.java" >}}
## **Add Image Stamp as Background in Floating Box**
Aspose.PDF API lets you add image stamp as background in a floating box. The BackgroundImage property of FloatingBox class can be used to set the background image stamp for a floating box as shown in following code sample.



{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-StampsAndWatermarks-AddImageStampAsBackgroundInFloatingBox-AddImageStampAsBackgroundInFloatingBox.java" >}}
