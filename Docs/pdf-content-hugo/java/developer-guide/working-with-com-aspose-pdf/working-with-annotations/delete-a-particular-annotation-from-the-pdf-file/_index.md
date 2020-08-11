---
title: Delete a Particular Annotation from the PDF File
type: docs
weight: 70
url: /java/delete-a-particular-annotation-from-the-pdf-file/
---

{{% alert color="primary" %}} 

[Delete All Annotations from a Page of a PDF File](/pdf/java/delete-all-annotations-from-a-page-of-a-pdf-file-html/) showed how to remove all annotations from a page. But what if you only want to remove one? Aspose.PDF allows you to do this too. This article explains how.

{{% /alert %}} 

To delete a particular annotation from a PDF, call the AnnotationCollection collection's delete(..) method. This collection belongs to the [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) object. The delete(..) method requires the index of the annotation you want to delete. Then, save the update PDF file.

The following code snippet shows how to delete a particular annotation.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-annotations-DeleteParticularAnnotationFromThePDFFile-.java" >}}
