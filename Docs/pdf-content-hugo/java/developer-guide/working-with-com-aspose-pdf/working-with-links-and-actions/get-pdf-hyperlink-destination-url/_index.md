---
title: Get PDF Hyperlink Destination - URL
type: docs
weight: 30
url: /java/get-pdf-hyperlink-destination-url/
---

{{% alert color="primary" %}} 

Links are represented as annotations in a PDF file and they can be added, updated or deleted. Aspose.PDF for Java also supports getting the destination (URL) of hyperlink in a PDF file.

{{% /alert %}} 

To get a link's URL:

1. Create a [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object.
1. Get the [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) you want to extract links from.
1. Use the AnnotationSelector class to extract all the LinkAnnotation objects from the specified page.
1. Pass the AnnotationSelector object to [accept(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#accept-com.aspose.pdf.ImagePlacementAbsorber-) method of [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) instance.
1. Get all the selected link annotations into an List object using the AnnotationSelector object's getSelected(..) method.
1. Finally extract the LinkAnnotation as GoToURIAction.

The following code snippet shows how to get hyperlink destinations (URL) from a PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-linksandactions-GetPDFHyperlinkDestination-.java" >}}
