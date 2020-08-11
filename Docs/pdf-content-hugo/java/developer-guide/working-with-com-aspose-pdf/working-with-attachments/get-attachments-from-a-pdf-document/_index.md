---
title: Get Attachments from a PDF Document
type: docs
weight: 20
url: /java/get-attachments-from-a-pdf-document/
---

{{% alert color="primary" %}} 

The [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's EmbeddedFiles collection contains all a file's attachments. Each element of this collection represents a [FileSpecification](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileSpecification) object.

{{% /alert %}} 
#### **Extract Particular Attachment from PDF File**
To get an individual attachment from the EmbeddedFiles collection, use its index value. The index represents the specific number (in the collection) of the file to be fetched. This way, you get a [FileSpecification](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileSpecification) object. Once the object is available, retrieve either all the file's properties or the file itself.

The following code snippet shows you how to get an individual attachment from the PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-attachments-GetAttachmentsFromPDFDocument-.java" >}}
