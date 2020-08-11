---
title: Get a Particular Annotation from a PDF
type: docs
weight: 50
url: /java/get-a-particular-annotation-from-a-pdf/
---

{{% alert color="primary" %}} 

[Get All Annotations from Page in a PDF](/pdf/java/get-all-annotations-from-page-in-a-pdf-html/) explained how to get all annotations on a page, or in an entire document. This article explains how to get just one annotation.

{{% /alert %}} 

Annotations are associated with individual pages and stored in a [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) object's AnnotationCollection collection. To get a specific annotation, specify its index. This returns an Annotation object that needs to be cast to a particular annotation type, for example TextAnnotation.

The following code snippet shows how to get a particular annotation and its properties.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-annotations-GetParticularAnnotationFromPDF-.java" >}}
