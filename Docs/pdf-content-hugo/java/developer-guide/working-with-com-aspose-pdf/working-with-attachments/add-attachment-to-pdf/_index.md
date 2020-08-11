---
title: Add Attachment to PDF
type: docs
weight: 10
url: /java/add-attachment-to-pdf/
---

{{% alert color="primary" %}} 

Attachments can contain a wide variety of information and can be of a variety of file types. This article explains how to add an attachment to a PDF file.

{{% /alert %}} 

To add an attachment to a PDF document:

1. Create a [FileSpecification](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileSpecification) object that contains the file you want to attach, and file description.
1. Add the [FileSpecification](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileSpecification) object to a [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's [EmbeddedFiles](https://apireference.aspose.com/java/pdf/com.aspose.pdf/EmbeddedFileCollection) collection using the [add(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileSpecification) method.
   The [EmbeddedFiles](https://apireference.aspose.com/java/pdf/com.aspose.pdf/EmbeddedFileCollection) collection contains all the attachments added to a PDF file.

The following code snippet shows how to add an attachment to a PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-attachments-AddAttachmentToPDF-.java" >}}
