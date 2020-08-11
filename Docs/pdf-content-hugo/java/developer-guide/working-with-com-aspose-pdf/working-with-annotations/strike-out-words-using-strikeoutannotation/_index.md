---
title: Strike Out Words using StrikeOutAnnotation
type: docs
weight: 40
url: /java/strike-out-words-using-strikeoutannotation/
---

{{% alert color="primary" %}} 

Aspose.PDF for Java allows you to add, delete and update annotations in PDF documents. One of the classes allows you to strike out annotations too. This is useful when you want to strike out one or more text fragments in a document.

{{% /alert %}} 

Annotations are held in a [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) object's AnnotationCollection collection. A class named StrikeOutAnnotation can be used to add strike out annotations to a PDF document.

To strike out a certain TextFragment:

1. Search for a TextFragment in the PDF file.
1. Get the TextFragment object's coordinates.
1. Use the coordinates to instantiate a StrikeOutAnnotation object.

The following code snippet shows how to search for a particular TextFragment and add a StrikeOutAnnotation to that object.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-annotations-StrikeOutWordsUsingStrikeOutAnnotation-.java" >}}


A TextFragment may contain one or more segments, so work with internal segments to.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Annotations-StrikeOutWordsUsingStrikeOutAnnotation-Info.java" >}}
