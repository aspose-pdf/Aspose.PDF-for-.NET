---
title: Create Document
type: docs
weight: 10
url: /net/create-document/
---

Aspose.PDF for .NET API lets you create and read PDF files using C# and VB.NET. The API can be used in a variety of .NET applications including WinForms, ASP.NET, and several others. In this article, we are going to show how to use Aspose.PDF for .NET API to easily generate and read PDF files in .NET applications.
## **How to Create PDF File using C#**
To create a PDF file using C#, the following steps can be used.

1. Create an object of [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class
1. Add a [Page](https://apireference.aspose.com/pdf/net/aspose.pdf/page) object to the [Pages](https://apireference.aspose.com/pdf/net/aspose.pdf/document/properties/pages) collection of the Document object
1. Add [TextFragment](https://apireference.aspose.com/pdf/net/aspose.pdf.text/textfragment) to [Paragraphs](https://apireference.aspose.com/pdf/net/aspose.pdf/page/properties/paragraphs) collection of the page
1. Save the resultant PDF document

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-QuickStart-HelloWorld-1.cs" >}}

In this case, we create a PDF one-page document with A4 page size, portrait orientation. Our page will contain a "Hello, World" in the upper left part of the page.
