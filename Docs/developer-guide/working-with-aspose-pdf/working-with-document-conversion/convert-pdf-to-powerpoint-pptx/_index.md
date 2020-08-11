---
title: Convert PDF to PowerPoint PPTX
type: docs
weight: 100
url: /net/convert-pdf-to-powerpoint-pptx/
---

We have an API named [Aspose.Slides](https://products.aspose.com/slides/net) which offers the feature to create as well as manipulate [PPT](https://wiki.fileformat.com/specification/presentation/ppt/)/[PPTX](https://wiki.fileformat.com/specification/presentation/pptx/) presentations. This API also provides the feature to convert PPT/PPTX files to PDF format. Recently we received requirements from many of our customers to support the capability of PDF transformation to PPTX format. Starting release of [Aspose.PDF for .NET 10.3.0](https://downloads.aspose.com/pdf/net), we have introduced a feature to transform PDF documents to PPTX format. During this conversion, the individual pages of the PDF file are converted to separate slides in the PPTX file.

During PDF to PPTX conversion, the text is rendered as Text where you can select/update it. Please note that in order to convert PDF files to PPTX format, Aspose.PDF provides a class named [PptxSaveOptions](https://apireference.aspose.com/net/pdf/aspose.pdf/pptxsaveoptions). An object of the PptxSaveOptions class is passed as a second argument to the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document).Save(..) method. The following code snippet shows the process for converting PDF files into PPTX format.
## **PDF to PPTX using .NET**
In order to convert PDF to PPTX, use the following code steps.

1. Create an instance of [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class
1. Create an instance of [PptxSaveOptions](https://apireference.aspose.com/net/pdf/aspose.pdf/pptxsaveoptions) class
1. Use the Save method of the Document object to save the PDF as PPTX

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToPPT-PDFToPPT.cs" >}}
### **Convert PDF to PPTX with Slides as Images**
{{% alert color="primary" %}} 

You can check the quality of Aspose.PDF conversion and view the results online at this link:

[products.aspose.app/pdf/conversion/pdf-to-pptx](https://products.aspose.app/pdf/conversion/pdf-to-pptx) {{% /alert %}} 

In case if you need to convert a searchable PDF to PPTX as images instead of selectable text, Aspose.PDF provides such a feature via [Aspose.Pdf.PptxSaveOptions](https://apireference.aspose.com/net/pdf/aspose.pdf/pptxsaveoptions) class. To achieve this, set property [***SlidesAsImages***](https://apireference.aspose.com/net/pdf/aspose.pdf/pptxsaveoptions/properties/slidesasimages) of **PptxSaveOptios** class to 'true' as shown in the following code sample.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToPPT-PDFtoPPTXWithSlidesAsImages.cs" >}}
## **Progress Detail of PPTX Conversion**
Aspose.PDF for .NET lets you track the progress of PDF to PPTX conversion. The Aspose.Pdf.PptxSaveOptions class provides [CustomProgressHandler](https://apireference.aspose.com/net/pdf/aspose.pdf/pptxsaveoptions/properties/customprogresshandler) property that can be specified to a custom method for tracking the progress of conversion as shown in the following code sample.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToPPT-PDFtoPTTXWithProgressTracking.cs" >}}

Following is the custom method for displaying progress conversion.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToPPT-ShowProgressOnConsole.cs" >}}
