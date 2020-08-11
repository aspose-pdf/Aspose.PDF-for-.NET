---
title: Get All Annotations from Page in a PDF
type: docs
weight: 60
url: /java/get-all-annotations-from-page-in-a-pdf/
---

{{% alert color="primary" %}} 

Aspose.Cells allows you to get annotations from an entire document, or from a given page.

{{% /alert %}} 

To get all annotations from a page in a PDF document, loop through a [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) object's AnnotationCollection collection.

The following code snippet shows you how to get all the annotations of a page.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-annotations-GetAllAnnotationsFromPageInPDF-.java" >}}

Please note that to get all the annotations from the whole PDF, you have to loop through the document's [PageCollection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/PageCollection) collection before looping through the Annotations collection for each page. You can get each annotation of the collection in a base annotation type called MarkupAnnotation and then show its properties.
