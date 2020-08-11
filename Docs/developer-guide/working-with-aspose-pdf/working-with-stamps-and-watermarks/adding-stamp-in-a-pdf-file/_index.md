---
title: Adding Stamp in a PDF file
type: docs
weight: 10
url: /net/adding-stamp-in-a-pdf-file/
---

## **Adding Image Stamp in PDF File**
{{% alert color="primary" %}} 

You can check how to add a stamp using Aspose.PDF and get the results online at this link:

[products.aspose.app/pdf/watermark](https://products.aspose.app/pdf/watermark) {{% /alert %}} 

You can use the ImageStamp class to add an image stamp to a PDF file. The ImageStamp class provides the properties necessary for creating an image-based stamp, such as height, width, opacity and so on.

To add an image stamp:

1. Create a Document object and an ImageStamp object using required properties.
1. Call the Page class' AddStamp method to add the stamp to the PDF.

The following code snippet shows how to add image stamp in the PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-AddImageStamp-AddImageStamp.cs" >}}
### **Control Image Quality when Adding a Stamp**
When adding an image as a stamp object, you can control the quality of the image. The Quality property of the ImageStamp class is used for this purpose. It indicates the quality of image in percents (valid values are 0..100).

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-AddImageStamp-ControlImageQuality.cs" >}}
## **Adding PDF Page Stamp in the PDF File**
You can use **PdfPageStamp** class to add a PDF page as stamp in a PDF file. **PdfPageStamp** class provides properties necessary to create a PDF page based stamp. You can pass a particular page of any PDF file to the constructor of **PdfPageStamp** class. In order to add page based stamp, you need to create a **Document** object and a **PdfPageStamp** object using required properties. After that, you can call **AddStamp** method of the **Page** to add the stamp in the PDF. The following code snippet shows you how to add PDF page stamp in a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-AddPDFPageStamp-PDFPageStamp.cs" >}}
## **Add Page Number Stamp in a PDF File**
You can use **PageNumber** **Stamp** class to add a page number stamp in a PDF file. **PageNumber** **Stamp** class provides properties necessary to create a page number based stamp like format, margins, alignments, starting number etc. In order to add page number stamp, you need to create a **Document** object and a **PageNumber** **Stamp** object using required properties. After that, you can call **AddStamp** method of the **Page** to add the stamp in the PDF. You can also set the font attributes of the page number stamp. The following code snippet shows you how to add page numbers in a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-PageNumberStamps-PageNumberStamps.cs" >}}
## **Adding Date-Time Stamp in PDF**
You can use **TextStamp** class to add a text stamp in a PDF file. **TextStamp** class provides properties necessary to create a text based stamp like font size, font style, and font color etc. In order to add text stamp, you need to create a **Document** object and a **TextStamp** object using required properties. After that, you can call **AddStamp** method of the **Page** to add the stamp in the PDF. 
The following code snippet shows you how to add text stamp in the PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-AddDateTimeStamp-AddDateTimeStamp.cs" >}}
## **Adding Text Stamp in the PDF File**
You can use **TextStamp** class to add a text stamp in a PDF file. **TextStamp** class provides properties necessary to create a text based stamp like font size, font style, and font color etc. In order to add text stamp, you need to create a **Document** object and a **TextStamp** object using required properties. After that, you can call **AddStamp** method of the **Page** to add the stamp in the PDF. 
The following code snippet shows you how to add text stamp in the PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-AddTextStamp-AddTextStamp.cs" >}}
## **Define alignment for TextStamp object**
Adding watermarks to PDF documents is one of the frequent demanded features and Aspose.PDF for .NET is fully capable of adding Image as well as Text watermarks. We have a class named TextStamp which provides the feature to add text stamps over the PDF file. Recently there has been a requirement to support the feature to specify the alignment of text when using TextStamp object. So in order to fulfill this requirement, we have introduced **TextAlignment** property in [TextStamp](http://www.aspose.com/api/net/pdf/aspose.pdf/textstamp) class. Using this property, we can specify the Horizontal text alignment.

The following code snippets shows an example on how to load an existing PDF document and add TextStamp over it.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-DefineAlignment-DefineAlignment.cs" >}}
## **Fill Stroke Text as Stamp in PDF File**
We have implemented setting of rendering mode for text adding and editing scenarios. To render stroke text please create TextState object and set RenderingMode to TextRenderingMode.StrokeText and also select color for StrokingColor property. Later, bind TextState to the stamp using BindTextState() method.

Following code snippet demonstrates adding Fill Stroke Text:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-FillStrokeText-1.cs" >}}
## **Add Image Stamp as Background in Floating Box**
Aspose.PDF API lets you add image stamp as background in a floating box. The BackgroundImage property of FloatingBox class can be used to set the background image stamp for a floating box as shown in following code sample.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Stamps-Watermarks-AddImageStamp-AddImageStampAsBackgroundInFloatingBox.cs" >}}
