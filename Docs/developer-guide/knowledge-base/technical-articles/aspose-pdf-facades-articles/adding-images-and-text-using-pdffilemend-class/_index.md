---
title: Adding Images and Text using PdfFileMend class
type: docs
weight: 240
url: /net/adding-images-and-text-using-pdffilemend-class/
---

{{% alert color="primary" %}} 

Adding images and text in an existing PDF file is a common requirement and [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) fulfills this requirement very well. It provides a class [PdfFileMend](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffilemend) which allows you to add images and text in the PDF file. This article looks into the details of these features and shows you an example in the code snippet section.

{{% /alert %}} 
## **Implementation details**
[PdfFileMend](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffilemend) class can help you add images and text in an existing PDF document, at a specified location. It provides two methods with the names [AddImage](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffilemend/methods/addimage/index) and [AddText](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffilemend/methods/addtext/index). [AddImage](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffilemend/methods/addimage/index) method allows you to add images of type JPG, GIF, PNG, and BMP. [AddText](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffilemend/methods/addtext/index) method takes an argument of type [FormattedText](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/formattedtext) class and adds it in the existing PDF file. The images and text can be added in a rectangle region specified by the coordinates of lower left and upper right points. While adding images you can specify either image file path or a stream of an image file. In order to specify the page number at which the image or text needs to be added, both of these methods provide an argument of page number. So, you can not only add the images and text at the specified location but also on a specified page as well. The following code snippet shows you how to use AddImage and AddText methods:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-AddTextImagesUsingPdfFileMend-AddTextImagesUsingPdfFileMend.cs" >}}
