---
title: Converting an XML to FDF format
type: docs
weight: 330
url: /net/converting-an-xml-to-fdf-format/
---

{{% alert color="primary" %}} 

The [Aspose.Pdf.Facades](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) namespace in [Aspose.PDF for .NET](/pdf/net/) supports AcroForms very well. It also supports importing and exporting form data to different file formats like FDF, XFDF, and XML. However, sometimes a developer need to convert one format to another. In this article, we’ll look into the feature which allows us to convert an FDF format into XML.

{{% /alert %}} 
## **Details**
FDF stands for Forms Data Format, and an FDF file contains the form values in a key/value pair. We also know that XML file contains the values as tags. Where, mostly the key is represented as the tag name and value is represented as the value within that tag. Now, [Aspose.Pdf.Facades](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) provides the flexibility to convert an XML file format into FDF format.

Use the [FormDataConverter](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/FormDataConverter) class for this purpose. This class provides different methods for converting one data format into another. This article shows how to use one method, ConvertXmlToFdf(..), which takes an FDF file as an input or source stream and saves it into XML format. The following code snippet shows how to convert an FDF file into an XML file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-XMLToPdf-XMLToPdf.cs" >}}
