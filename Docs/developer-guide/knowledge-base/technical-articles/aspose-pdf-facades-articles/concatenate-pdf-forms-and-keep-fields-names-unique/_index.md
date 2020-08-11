---
title: Concatenate PDF Forms and keep fields names unique
type: docs
weight: 90
url: /net/concatenate-pdf-forms-and-keep-fields-names-unique/
---

## **Implementation details**
[PdfFileEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffileeditor) class in [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) offers the capability to concatenate the PDF files. Now, if the Pdf files which are to be concatenated have form fields with similar field names, Aspose.PDF provides the feature to keep the fields in the resultant Pdf file as unique and also you can specify the suffix to make the field names unique. [KeepFieldsUnique](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffileeditor/properties/keepfieldsunique) property of [PdfFileEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffileeditor) as true will make field names unique when Pdf forms are concatenated. Also, [UniqueSuffix](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffileeditor/properties/uniquesuffix) property of PdfFileEditor can be used to specify the user defined format of the suffix which is added to field name to make it unique when forms are concatenated. This string must contain %NUM% substring which will be replaced with numbers in the resultant file.

Please see the following simple code snippet to achieve this functionality.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-ConcatenatePDFForms-ConcatenatePDFForms.cs" >}}
