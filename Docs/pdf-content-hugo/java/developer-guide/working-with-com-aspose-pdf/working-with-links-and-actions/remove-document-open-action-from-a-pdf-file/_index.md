---
title: Remove Document Open Action from a PDF file
type: docs
weight: 20
url: /java/remove-document-open-action-from-a-pdf-file/
---

{{% alert color="primary" %}} 

When concatenating several documents, and one or more has an GoTo action set, you probably want to remove them. For example, if combining two document and the second one has a GoTo action that takes you to the second page, the output document will open on the second page of the second document instead of the first page of the combined document. To avoid this behavior, remove the open action command.

{{% /alert %}} 

To remove an open action:

1. Set the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's OpenAction property to null.
1. Save the updated PDF using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's Save method.

The following code snippet shows how to remove a document open action from the PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-linksandactions-RemoveDocumentOpenActionFromPDFFile-.java" >}}
