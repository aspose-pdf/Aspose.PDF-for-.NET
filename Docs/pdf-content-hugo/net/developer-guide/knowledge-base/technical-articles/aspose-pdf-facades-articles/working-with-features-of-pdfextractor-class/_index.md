---
title: Working with features of PdfExtractor class
type: docs
weight: 250
url: /net/working-with-features-of-pdfextractor-class/
---

{{% alert color="primary" %}} 

In this article, we’ll look into the details of extracting text, images, and attachments from a PDF file. All of these extraction features are provided at one place, in [PdfExtractor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor) class. We’ll see how to use these features in our code.

{{% /alert %}} 
## **Implementation details**
[PdfExtractor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor) class provides three types of extraction capabilities. These three categories are Text, Images and Attachments. In order to perform extraction under each of these three categories PdfExtractor provide various methods which work together to give you the final output.

For example, in order to extract text you can use three methods i.e. [ExtractText, GetText, HasNextPageText and GetNextPageText](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor/methods/index). Now, in order to start extracting text, first of all, you need to call [ExtractText](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor/methods/extracttext/index) method; this will extract the text from the PDF file and will store it into memory. After that, [GetText](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor/methods/gettext/index) method will take this extracted text and save on to the disk at specified location in a file. [HasNextPageText](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor/methods/hasnextpagetext) helps you loop through each page and check whether the next page has any text or not. If it contains some text then [GetNextPageText](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor/methods/getnextpagetext/index) will help you save the text of an individual page into the file.

When we need to extract images, we can use [ExtractImage, HasNextImage, and GetNextImage](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor/methods/index) methods. Just like text extraction, [ExtractImage](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor/methods/extractimage) method extracts all the images in the memory. After that, [HasNextImage](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor/methods/hasnextimage) checks whether any more images are available or not; if more images are available then [GetNextImage](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor/methods/getnextimage/index) will save the next image in an image file.

The third category under the extraction capabilities of [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) is the attachment extraction. This category provides a set of methods, which not only help extract the attachments but also provides the methods which can give you the attachment related information i.e. [GetAttachmentInfo](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor/methods/getattachmentinfo) and [GetAttachName](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor/methods/getattachnames) methods provide attachment information and attachment name respectively. In order to extract and then get attachments we use **ExtractAttachment** and **GetAttachment** methods. The following code snippet shows you how to use PdfExtractor methods:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-PdfExtractorFeatures-PdfExtractorFeatures.cs" >}}
