---
title: PDF File Metadata
type: docs
weight: 50
url: /net/pdf-file-metadata/
---

## **Get PDF File Information**
In order to get file specific information of a PDF file, you first need to get the [DocumentInfo](https://apireference.aspose.com/net/pdf/aspose.pdf/documentinfo) object using [Info](https://apireference.aspose.com/net/pdf/aspose.pdf/document/properties/info) property of the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object. Once the [DocumentInfo](https://apireference.aspose.com/net/pdf/aspose.pdf/documentinfo) object is retrieved, you can get the values of the individual properties. The following code snippet shows you how to get PDF file information.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-GetFileInfo-GetFileInfo.cs" >}}
## **Set PDF File Information**
Aspose.PDF for .NET allows you to set file-specific information for a PDF, information like author, creation date, subject, and title. To set this information:

1. Create a [DocumentInfo](https://apireference.aspose.com/net/pdf/aspose.pdf/documentinfo) object.
1. Set the values of the properties.
1. Save the updated document using the Document class' Save method.

{{% alert color="primary" %}} 

Please note that you cannot set values against the **Application** and **Producer** fields, because Aspose Ltd. and Aspose.PDF for .NET x.x.x will be displayed against these fields.

{{% /alert %}} 

The following code snippet shows you how to set PDF file information.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-SetFileInfo-SetFileInfo.cs" >}}
## **Get XMP Metadata from PDF File**
Aspose.PDF allows you to access a PDF file's XMP metadata. To get a PDF file's metadata:

1. Create a [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object and open the input PDF file.
1. Get the file's metadata using the [Metadata](https://apireference.aspose.com/net/pdf/aspose.pdf/document/properties/metadata) property.

The following code snippet shows you how to get metadata from the PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-GetXMPMetadata-GetXMPMetadata.cs" >}}
## **Set XMP Metadata in a PDF File**
Aspose.PDF allows you to set metadata in a PDF file. To set metadata:

1. Create a [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object.
1. Set metadata values using the [Metadata](https://apireference.aspose.com/net/pdf/aspose.pdf/document/properties/metadata) property.
1. Save the updated document using the [Save](https://apireference.aspose.com/net/pdf/aspose.pdf/document/methods/save) method of the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object.

The following code snippet shows you how to set metadata in a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-SetXMPMetadata-SetXMPMetadata.cs" >}}
### **Insert Metadata with Prefix**
Some developers need to create a new metadata namespace with a prefix. The following code snippet shows how to insert metadata with prefix.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-SetXMPMetadata-SetPrefixMetadata.cs" >}}
