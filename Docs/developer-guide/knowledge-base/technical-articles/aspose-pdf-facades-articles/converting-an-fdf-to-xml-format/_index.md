---
title: Converting an FDF to XML format
type: docs
weight: 180
url: /net/converting-an-fdf-to-xml-format/
---

{{% alert color="primary" %}}

The [Aspose.Pdf.Facades](https://apireference.aspose.com/pdf/net/aspose.pdf.facades) namespace in [Aspose.PDF for .NET](/pdf/net/) supports AcroForms very well. It also supports importing and exporting form data to different file formats like FDF, XFDF, and XML. However, sometimes developers might need to convert one format into another one. This article looks at the feature that converts FDF into XML.

{{% /alert %}}
## **Details**
FDF stands for Forms Data Format, and an FDF file contains the form values in a key/value pair. We also know that XML file contains the values as tags. Where, mostly the key is represented as the tag name and value is represented as the value within that tag. Now, [Aspose.Pdf.Facades](https://apireference.aspose.com/pdf/net/aspose.pdf.facades) provides us the flexibility to convert an FDF file format into an XML format.

We can use [FormDataConverter](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/formdataconverter) class for this purpose. This class provides us different method to convert one data format into another format. In this article, we will just use one method named [ConvertFdfToXml](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/formdataconverter/methods/convertfdftoxml). This method takes FDF file as an input or source stream and saves it into XML format.

The following code snippet shows you how to convert an FDF file into an XML file:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-ConvertPdfToXML-ConvertPdfToXML.cs" >}}
