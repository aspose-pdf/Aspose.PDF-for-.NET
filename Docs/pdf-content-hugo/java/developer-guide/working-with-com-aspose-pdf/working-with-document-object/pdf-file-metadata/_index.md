---
title: PDF File Metadata
type: docs
weight: 20
url: /java/pdf-file-metadata/
---

## **Get PDF File Information**
To get file-specific information about a PDF file, first get the [DocumentInfo](https://apireference.aspose.com/java/pdf/com.aspose.pdf/DocumentInfo) object using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class' [getInfo()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#getInfo--). Once the [DocumentInfo](https://apireference.aspose.com/java/pdf/com.aspose.pdf/DocumentInfo) object is retrieved, you can get the values of the individual properties.

The following code snippet shows you how to set PDF file information.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-GetPDFFileInformation-.java" >}}
## **Set PDF File Information**
Aspose.PDF for Java allows you to set file-specific information for a PDF, information like author, creation date, subject, and title.

To set this information:

1. Create a [DocumentInfo](https://apireference.aspose.com/java/pdf/com.aspose.pdf/DocumentInfo) object.
1. Set the values of the properties.
1. Save the updated document using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class' [save()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#save-com.aspose.ms.System.IO.FileStream-) method.

{{% alert color="primary" %}} 

Please note that you cannot set values against the **Producer** and **Creator** fields, because Aspose.PDF for Java x.x.x will be displayed against these fields.

{{% /alert %}} 

The following code snippet shows you how to set PDF file information.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-SetPDFFileInformation-.java" >}}

Get XMP Metadata from PDF File

Aspose.PDF for Java allows you to access a PDF file's XMP metadata.

To get a PDF file's metadata,

1. Create a [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object and open the input PDF file.
1. Use the [getMetadata()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#getMetadata--) property to get the metadata.

The following code snippet shows you how to get metadata from the PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-GetXMPMetadataFromPDFFile-.java" >}}
## **Remove Metadata from PDF**
Aspose.PDF for Java allows you to add, update, and remove metadata from PDF documents.

To remove metadata:

1. Create a [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object.
1. Check if the particular property exists in the PDF file.
1. If it exists, use the removeItem(..) method to remove it.
1. Save the updated document using the Document object's [Save](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#save-com.aspose.ms.System.IO.FileStream-) method.

The following code snippet shows you how to remove metadata from a PDF file.

You cannot remove the pdf:Producer, xmp:ModifyDate, xmp:CreatorTool, or xmp:MetadataDate properties as they are required. All other properties can easily be removed.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-RemoveMetadataFromPDF-.java" >}}






