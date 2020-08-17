---
title: Concatenate multiple PDF files using MemoryStreams
type: docs
weight: 220
url: /net/concatenate-multiple-pdf-files-using-memorystreams/
---

{{% alert color="primary" %}}

In this article, we’ll show you how to concatenate multiple PDF files using MemoryStreams.

{{% /alert %}}
## **Implementation details**
[PdfFileEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffileeditor) is the class in [Aspose.Pdf.Facades namespace](https://apireference.aspose.com/pdf/net/aspose.pdf.facades) which allows you to concatenate multiple PDF files. You can not only concatenate files using FileStreams but also using MemoryStreams as well. In this article, the process of concatenating the files using MemoryStreams will be explained and then shown using the code snippet.

[Concatenate](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffileeditor/methods/concatenate/index) method of [PdfFileEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffileeditor) class takes the source PDF files and the destination PDF file as parameters. These parameters can be either paths to the PDF files on the disk or they could be MemoryStreams. Now, for this example, we’ll first create two files streams to read the PDF files from the disk. Then we’ll convert these files into byte arrays. These byte arrays of the PDF files will be converted to MemoryStreams. Once we get the MemoryStreams out of PDF files, we’ll be able to pass them on to the concatenate method and merge into a single output file.

The following code snippet shows you how to concatenate multiple PDF files using MemoryStreams:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-ConcatenateMultiplePDFUsingMemoryStream-ConcatenateMultiplePDFUsingMemoryStream.cs" >}}
