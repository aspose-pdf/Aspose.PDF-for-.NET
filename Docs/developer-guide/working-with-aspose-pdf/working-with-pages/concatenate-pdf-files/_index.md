---
title: Concatenate PDF Files
type: docs
weight: 10
url: /net/concatenate-pdf-files/
---

This article shows how to merge multiple PDF files into a single PDF document using Aspose.PDF for .NET. The example is written in C# but the API can be used in other .NET programming languages as well such as VB.NET. PDF files are merged such that the first one is joined at the end of the other document. 
## **Merge PDF Files using C#**


{{% alert color="primary" %}} 

You can merge PDF files using Aspose.PDF and get the results online at this link:

[products.aspose.app/pdf/merger](https://products.aspose.app/pdf/merger) {{% /alert %}} 

To concatenate two PDF files:

1. Create two [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) objects, each containing one of the input PDF files.
1. Then call the [PageCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/pagecollection) collection's Add method for the Document object you want to add the other PDF file to.
1. Pass the PageCollection collection of the second Document object to the first PageCollection collection's Add method.
1. Finally, save the output PDF file using the [Save](https://apireference.aspose.com/net/pdf/aspose.pdf.document/save/methods/4) method.

The following code snippet shows how to concatenate PDF files.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-ConcatenatePdfFiles-ConcatenatePdfFiles.cs" >}}
