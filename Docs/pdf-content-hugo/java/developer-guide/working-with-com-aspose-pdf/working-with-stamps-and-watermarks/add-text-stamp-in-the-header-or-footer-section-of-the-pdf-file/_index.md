---
title: Add Text Stamp in the Header or Footer section of the PDF file
type: docs
weight: 20
url: /java/add-text-stamp-in-the-header-or-footer-section-of-the-pdf-file/
---

## **Adding different Headers in one PDF File**
We know that we can add [TextStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextStamp) in the Header/Footer section of the document by using TopMargin or BottomMargin properties, but sometimes we may have the requirement to add multiple headers/footers in a single PDF document. In order to accomplish this requirement, we will create individual [TextStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextStamp) objects (number of objects depends upon the number of Header/Footers required) and will add them to PDF document. We may also specify different formatting information for individual stamp object. In the following example, we have created a [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object and three [TextStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextStamp) objects and then we have used [addStamp(...)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#addStamp-com.aspose.pdf.Stamp-) method of the [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) to add the text in the header section of the PDF.

The following code snippet shows you how to add an image in the footer of a PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-stampsandwatermarks-AddingDifferentHeadersInOnePDFFile-.java" >}}
## **Adding Text in Header or Footer of PDF File**
The [TextStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextStamp) class is used to add text in PDF documents. We can also use the same class to add text in the Header/Footer area of PDF file. The [TextStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextStamp) class provides necessary methods to specify font size, font style, and font color, etc for stamp object. In order to add text in the Header area, first, you need to create a [Document](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Document) object and a [TextStamp](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextStamp) object using the required methods. After that, you can call [addStamp(...)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#addStamp-com.aspose.pdf.Stamp-) method of [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) class to add text in the PDF file.

Please note that when placing text in the Header section, you need to call [setTopMargin(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Stamp#setTopMargin-double-) in such a way that it adjusts the text in the header area of your PDF. Similarly, when placing text in Footer section, you need to call [setBottomMargin(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Stamp#setBottomMargin-double-) in such a way that it adjusts to the text in Footer area.

- When adding a stamp object in the Header section, you also need to set [VerticalAlignment](https://apireference.aspose.com/java/pdf/com.aspose.pdf/VerticalAlignment) to **Top**.
- When adding a stamp object in the Footer section, you also need to set [VerticalAlignment](https://apireference.aspose.com/java/pdf/com.aspose.pdf/VerticalAlignment) to **Bottom**.

The following code snippet shows you how to add text in the header of a PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-stampsandwatermarks-AddingTextInHeaderOrFooterOfPDFFile-.java" >}}
