---
title: Working with Extensible Metadata Platform - XMP
type: docs
weight: 50
url: /net/working-with-extensible-metadata-platform-xmp/
---

{{% alert color="primary" %}} 

The Extensible Metadata Platform (XMP) is a standard created by Adobe Systems Inc. This standard was developed to process and store standardized and proprietary metadata. This metadata can be embedded into different file formats, but in this article we’ll focus only on PDF file format. We’ll see how we can embed Meta data in a PDF file using Aspose.Pdf.Facades namespace in Aspose.PDF for .NET. We’ll use **PdfXmpMetadata** class to manipulate XMP in the PDF document.

{{% /alert %}} 
## **Background**
A PDF file goes through many stages during its life time. We create a PDF document and then pass it on to other people or departments for further processing. However, during this process we need to keep track of different aspects of the changes made. XMP serves this purpose of keeping track of the changes or other information about the data in the file.
## **Explanation**
In order to manipulate XMP using Aspose.Pdf.Facades, we will use [PdfXmpMetadata](http://www.aspose.com/docs/display/pdfnet/PdfXmpMetadata+Class) class. We will use this class to manipulate predefined Meta data properties.[PdfXmpMetadata](http://www.aspose.com/docs/display/pdfnet/PdfXmpMetadata+Class) class adds these properties to a PDF file. It also helps to open and save PDF files in which we’re adding Meta data. So, using [PdfXmpMetadata](http://www.aspose.com/docs/display/pdfnet/PdfXmpMetadata+Class) class, we can easily manipulate XMP in a PDF file. 
Following code snippet will help you understand how to use **PdfXmpMetadata** class to work with XMP:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-ExtensibleMetadataPlatform-ExtensibleMetadataPlatform.cs" >}}
## **Conclusion**

{{% alert color="primary" %}} 
In this article, we have seen how we can work with XMP using Aspose.Pdf.Facades. [PdfXmpMetadata](http://www.aspose.com/docs/display/pdfnet/PdfXmpMetadata+Class), used in this article, makes it very easy for the user to manipulate metadata in a PDF document. If [PdfXmpMetadata](http://www.aspose.com/docs/display/pdfnet/PdfXmpMetadata+Class) class is used properly, it’ll be very easy to incorporate intelligence in the PDF files, and bringing semantic web a little bit closer to realization.
{{% /alert %}} 