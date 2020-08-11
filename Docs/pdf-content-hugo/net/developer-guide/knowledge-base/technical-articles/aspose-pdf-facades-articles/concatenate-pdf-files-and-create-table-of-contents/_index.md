---
title: Concatenate PDF files and create Table Of Contents
type: docs
weight: 310
url: /net/concatenate-pdf-files-and-create-table-of-contents/
---

The [PdfFileEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/PdfFileEditor) present under Aspose.Pdf.Facades namespace provides the capability to Concatenate/Merge PDF documents to generate a single output file. Sometime we have a requirement to merge individual PDF files and then create a Table Of Contents pointing to individual documents. So in order to fulllfil this requirement, we will first concatenate the PDF files and then add links towards the pages in merged document.
## **Concatenate PDF files**
Please take a look over following code snippet for information on how to merge the PDF files.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-ConcatenatePdfFilesAndCreateTOC-ConcatenatePdfFilesAndCreateTOC.cs" >}}
## **Insert blank page**
Once the PDF files have been merged, we can insert a blank page at the beginning of document on which can can create Table Of contents. In order to accomplish this requirement, we can load the merged file into **Document** object and we need to call Page.Insert(...) method to insert a blank page.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-ConcatenatePdfFilesAndCreateTOC-InsertBlankPage.cs" >}}
## **Add Text Stamps**
In order to create a Table of Contents, we need to add Text stamps on first page using [PdfFileStamp](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/PdfFileStamp) and [Stamp](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/Stamp) objects. Stamp class provides **BindLogo(..)** method to add [FormattedText](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/FormattedText) and we can also specify the location to add these text stamps using **SetOrigin(..)** method. In this article, we are concatenating two PDF files, so we need to create two text stamp objects pointing to these individual documents.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-ConcatenatePdfFilesAndCreateTOC-AddTextStamps.cs" >}}
## **Create local links**
Now we need to add links towards the pages inside the concatenated file. In order to accomplish this requirement, we can use **CreateLocalLink(..)** method of [PdfContentEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/PdfContentEditor) class. In following code snippet, we have passed Transparent as 4th argument so that the rectangle around link is not visible.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-ConcatenatePdfFilesAndCreateTOC-CreateLocalLinks.cs" >}}
## **Complete code**


{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-ConcatenatePdfFilesAndCreateTOC-CompletedCode.cs" >}}

{{% alert color="primary" %}} 

You may download the sample documents from following links

- [Input1.pdf](attachments/7116811/7307380.pdf)
- [Input2.pdf](attachments/7116811/7307381.pdf)
- [Concatenated_Table_Of_Contents.pdf](attachments/7116811/7307382.pdf)

{{% /alert %}}
