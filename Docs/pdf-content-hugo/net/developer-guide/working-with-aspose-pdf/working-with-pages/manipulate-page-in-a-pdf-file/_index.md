---
title: Manipulate Page in a PDF File
type: docs
weight: 30
url: /net/manipulate-page-in-a-pdf-file/
---

Aspose.PDF for .NET API provides full flexibility to work with pages in a PDF document using C# or any other .NET language. It maintains all the pages of a PDF document in [PageCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/pagecollection) that can be used to work with PDG pages. Using the API, you can:

- Insert pages into a PDF
- Delete pages from a PDF
- Change page size of a PDF
- Rotate pages in a PDF
- Split PDF Pages into one or multiple PDF
## **Insert Page in a PDF File**
Aspose.PDF for .NET lets you insert a page to a PDF document at any location in the file as well as add pages to the end of a PDF file. This section shows how to add pages to a PDF without Acrobat Reader. 
### **Insert Page in a PDF File at Desired Location**
This topic explains how to insert a page in a PDF document using C#. The new page is inserted as an empty page at the specified index. To insert an empty page in a PDF file:

1. Create a [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class object with the input PDF file.
1. Call the [PageCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/pagecollection) collection's [Add](https://apireference.aspose.com/net/pdf/aspose.pdf.pagecollection/add/methods/1) method, without any parameters.
1. Save the output PDF using the [Save](https://apireference.aspose.com/net/pdf/aspose.pdf.document/save/methods/4) method.

The following code snippet shows you how to insert a page in a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-InsertEmptyPage-InsertEmptyPage.cs" >}}
### **Insert an Empty Page at the End of a PDF File**
Sometimes, you want to ensure that a document ends on an empty page. This topic explains how to insert an empty page at the end of the PDF document. To insert an empty page at the end of a PDF file:

1. Create a [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class object with the input PDF file.
1. Call the [PageCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/pagecollection) collection's [Add](https://apireference.aspose.com/net/pdf/aspose.pdf.pagecollection/add/methods/1) method, without any parameters.
1. Save the output PDF using the [Save](https://apireference.aspose.com/net/pdf/aspose.pdf.document/save/methods/4) method.

The following code snippet shows you how to insert an empty page at the end of a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-InsertEmptyPageAtEnd-InsertEmptyPageAtEnd.cs" >}}
## **Delete a Page from PDF File**
You can delete pages from a PDF file using Aspose.PDF for .NET. To delete a particular page from the [PageCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/pagecollection) collection:

1. Call the [Delete](https://apireference.aspose.com/net/pdf/aspose.pdf/pagecollection/methods/delete) method and specify the page's index
1. Call the [Save](https://apireference.aspose.com/net/pdf/aspose.pdf.document/save/methods/4) method to save the updated PDF file

The following code snippet shows how to delete a particular page from the PDF file using C#.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-DeleteParticularPage-DeleteParticularPage.cs" >}}
## **Change PDF Page Size**
Aspose.PDF for .NET lets you change PDF page size with simple lines of code in your .NET applications. This topic explains how to update/change the page dimensions (size) of an existing PDF file.

The [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) class contains the SetPageSize(...) method which lets you set the page size. The code snippet below updates page dimensions in a few easy steps:

1. Load the source PDF file.
1. Get the pages into the [PageCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/pagecollection) object.
1. Get a given page.
1. Call the SetPageSize(..) method to update its dimensions.
1. Call the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class' Save(..) method to generate the PDF file with updated page dimensions.

{{% alert color="primary" %}} 

Please note that the height and width properties use points as basic unit, where 1 inch = 72 points and 1 cm = 1/2.54 inch = 0.3937 inch = 28.3 points.

{{% /alert %}} 

The following code snippet shows how to change the PDF page dimensions to A4 size.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-UpdateDimensions-UpdateDimensions.cs" >}}
### **Get PDF Page Size**
You can read PDF page size of an existing PDF file using Aspose.PDF for .NET. The following code sample shows how to read PDF page dimensions using C#.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-GetDimensions-GetDimensions.cs" >}}
## **Add Image as Page Background**
Background images can be used to add a watermark, or other subtle design, to documents. In Aspose.PDF for .NET, each PDF document is a collection of pages and each page contains a collection of artifacts. The [BackgroundArtifact](https://apireference.aspose.com/net/pdf/aspose.pdf/backgroundartifact) class can be used to add a background image to a page object. The following code snippet shows how to add a background image to PDF pages using the BackgroundArtifact object.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-ImageAsBackground-ImageAsBackground.cs" >}}
## **Change Page Orientation**
This topic describes how to update or change the page orientation of pages in an existing PDF file.

From Aspose.PDF for .NET 9.6.0 release, we have added great new features like changing the page orientation from landscape to portrait and vice versa. To change the page orientation, set the page’s MediaBox using the following code snippet. You can also change page orientation by setting rotation angle using Rotate() method.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-ChangeOrientation-ChangeOrientation.cs" >}}
### **Fitting the Page Content to the New Page Orientation**
Please note that when using the above code snippet, some of the document’s content might be cut because the page height is decreased. To avoid this, increase width proportionally and leave the height intact. Example of calculations:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-FitPageContents-FitPageContents.cs" >}}

Besides the above approach, consider using the PdfPageEditor facade which can apply zoom to the page contents).

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-ZoomToPageContents-ZoomToPageContents.cs" >}}
## **Split PDF to Individual Files**
This topic shows how to split PDF pages into individual PDF files in your .NET applications. To split PDF pages into single page PDF files using C#, the following steps can be followed:

1. Loop through the pages of PDF document through the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's [PageCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/pagecollection) collection
1. For each iteration, create a new Document object and add the individual [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) object into the empty document
1. Save the new PDF using [Save](https://apireference.aspose.com/net/pdf/aspose.pdf.document/save/methods/4) method

The following C# code snippet shows you how to split PDF pages into individual PDF files.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-SplitToPages-SplitToPages.cs" >}}
