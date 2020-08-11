---
title: Identify if image inside PDF is Colored or Black and White
type: docs
weight: 60
url: /java/identify-if-image-inside-pdf-is-colored-or-black-and-white/
---

{{% alert color="primary" %}} 

Different type of compression can be applied over images to reduce their size. The type of compression being applied over image depends upon the ColorSpace of source image i.e. if image is Color (RGB), then apply JPEG2000 compression, and if it is Black & White, then JBIG2/JBIG2000 compression should be applied. Therefore identifying each image type and using an appropriate type of compression will create best/optimized output.

{{% /alert %}} 

A PDF file may contain Text, Image, Graph, Attachment, Annotation, etc elements and if the source PDF file contains images, we can determine image Color space and apply appropriate compression for the image to reduce PDF file size.

The following code snippet shows the steps to Identify if the image inside PDF is Colored or Black & White.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-images-IdentifyIfImageInsidePDFIsColoredOrBlackAndWhite-.java" >}}
