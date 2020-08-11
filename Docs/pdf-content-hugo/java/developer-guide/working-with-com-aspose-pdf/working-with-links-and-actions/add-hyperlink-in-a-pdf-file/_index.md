---
title: Add Hyperlink in a PDF file
type: docs
weight: 10
url: /java/add-hyperlink-in-a-pdf-file/
---

{{% alert color="primary" %}} 

It is possible to add hyperlinks to PDF file, either to allow readers to navigate to another part of the PDF, or to external content.

{{% /alert %}} 

In order to add web hyperlinks to PDF documents:

1. Create a [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class object.
1. Get the [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) instance to which you want to add the link.
1. Create a LinkAnnotation class object using the Page and [Rectangle](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Rectangle) objects.
   The rectangle object is used to specify the location on the page where the link should be added.
1. Set the Action property to the GoToURIAction object which specifies the location of the remote URI.
1. To display a hyperlink text, add a text string on a location similar to where the LinkAnnotation object is placed.
1. To add a free text:
   1. Instantiate an FreeTextAnnotation object. It also accepts [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) and Rectangle objects as argument, so it is possible to provide same values as specified against the LinkAnnotation constructor.
   1. Using the FreeTextAnnotation object's Contents property, specify the string that should be displayed in the output PDF.
   1. Optionally, set the border width of both the LinkAnnotation and FreeTextAnnotation objects to 0 so that they do not appear in the PDF document.
1. Once the LinkAnnotation and FreeTextAnnotation objects have been defined, add these links to the [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) object's Annotations collection.
1. Finally, save the updated PDF using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's save method.

The following code snippet shows you how to add a hyperlink to a PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-linksandactions-AddHyperlinkInPDFFile-.java" >}}
