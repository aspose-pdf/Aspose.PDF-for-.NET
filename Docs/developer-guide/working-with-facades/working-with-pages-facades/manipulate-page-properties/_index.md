---
title: Manipulate Page Properties
type: docs
weight: 80
url: /net/manipulate-page-properties/
---

## **Get PDF Page Properties from an Existing PDF File**
**PdfPageEditor** allows you work with individual pages of the PDF file. It helps you get the individual page’s properties like different page box sizes, page rotation, page zoom etc. In order to get those properties, you need to create **PdfpageEditor** object and bind input PDF file using **BindPdf** method. After that, you can use different methods to get the page properties like **GetPageRotation**, **GetPages**, **GetPageBoxSize** etc.

The following code snippet shows you how to get PDF page properties from existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ManipulatePageProperties-GetPageProperties-GetPageProperties.cs" >}}
## **Set PDF Page Properties in an Existing PDF File**
In order to set page properties like page rotation, zoom or origin point you need to use **PdfPageEditor** class. This class provides different methods and properties to set these page properties. First of all, you need to create an object of **PdfPageEditor** class and bind input PDF file using **BindPdf** method. After that, you can use these methods and properties to set the page properties. Finally, save the updated PDF file using **Save** method.

The following code snippet shows you how to set PDF page properties in an existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ManipulatePageProperties-SetPageProperties-SetPageProperties.cs" >}}
## **Resize Page Contents of Specific Pages in a PDF file**
**ResizeContents** method of **PdfFileEditor** class allows you to resize the page contents in a PDF file. **ContentsResizeParameters** class is used to specify the parameters to be used to resize the page(s) e.g. margins in percentage or units etc. You can resize all the pages or specify an array of pages to be resized using the ResizeContents method.

The following code snippet shows how to resize the contents of some specific pages of PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ManipulatePageProperties-ResizePageContents-ResizePageContents.cs" >}}
