---
title: Get Attachment Information
type: docs
weight: 40
url: /java/get-attachment-information/
---

{{% alert color="primary" %}} 

As mentioned in [Get Attachments from a PDF Document](/pdf/java/get-attachments-from-a-pdf-document-html/), attachment information is held in the [FileSpecification](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileSpecification) object, gathered with other attachments in the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's EmbeddedFiles collection.

The [FileSpecification](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileSpecification) object provides methods that get information about the attachment, for example:

- getName() – gets the file name.
- [getDescription()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileSpecification#getDescription--) – gets the file description.
- getMIMEType() – gets the file's MIME type.
- getParams() – information about the file parameters, for example CheckSum, CreationDate, ModDate and Size.

To get these parameters, first make sure that the getParams() method does not return null.

{{% /alert %}} 

Either loop through all of the attachments in the EmbeddedFiles collection using for loop, or get an individual attachment by specifying its index value. The following code snippet shows how to get information about a specific attachment.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-attachments-GetAttachmentInformation-.java" >}}
