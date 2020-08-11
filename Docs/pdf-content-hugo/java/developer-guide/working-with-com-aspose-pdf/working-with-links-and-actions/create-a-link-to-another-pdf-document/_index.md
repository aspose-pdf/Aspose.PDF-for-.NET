---
title: Create a Link to Another PDF Document
type: docs
weight: 40
url: /java/create-a-link-to-another-pdf-document/
---

Aspose.PDF for Java allows you to add a link to an external PDF file so that you can link several documents together.

To create a PDF document link:

1. First create a [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class object.
1. Then, get the particular [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) you want to add the link to.
1. Create a **LinkAnnotation** object using the [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) and [Rectangle](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Rectangle) objects.
1. Set the link attributes using the **LinkAnnotation** object.
1. Call **setAction(..)** method and pass **GoToRemoteAction** object.
1. While creating the **GoToRemoteAction** object, specify the PDF file that should launch, as well as the page number it should open on.
1. Add the link to **Annotations** collection of [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) object.
1. Save the updated PDF using the Save method of [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object.

The following code snippet shows how to create PDF document link in a PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-LinksAndActions-CreateALinkToAnotherPDFDocument-.java" >}}
