---
title: Delete All Attachments from PDF
type: docs
weight: 30
url: /java/delete-all-attachments-from-pdf/
---

{{% alert color="primary" %}} 

As well as [adding attachments](/pdf/java/add-attachment-to-pdf-html/), Aspose.Cells can remove attachments from PDF files.

{{% /alert %}} 

A PDF document's attachments are held in the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's EmbeddedFiles collection.

To delete all attachments associated with a PDF file:

1. Call the EmbeddedFiles collection's delete(..) method.
1. Save the updated file using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's save method.

The following code snippet shows how to delete all the attachments from a PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-attachments-DeleteAllAttachmentsFromPDF-.java" >}}
