---
title: Changing Color Space of a PDF Document
type: docs
weight: 20
url: /java/changing-color-space-of-a-pdf-document/
---

{{% alert color="primary" %}} 

Aspose.PDF for Java 9.0.0 supports changing a PDF document's color space. It is possible to change RGB color to CMYK and vice versa.

{{% /alert %}} 

The following methods have been implemented in the [Operator](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Operator) class to allow you to change the color space. Use it to change some specific RGB/CMYK colors to the CMYK/RGB color space, keeping the remaining PDF document as it is.

**Public API Changes** 
The following methods are implemented:

- com.aspose.pdf.Operator.SetRGBColorStroke.getCMYKColor(new double[3], new double[4])
- com.aspose.pdf.Operator.SetRGBColor.getCMYKColor(new double[3], new double[4])
- com.aspose.pdf.Operator.SetCMYKColorStroke.getRGBColor(new double[4], new double[3])
- com.aspose.pdf.Operator.SetCMYKColor.getRGBColor(new double[4], new double[3])

The following code snippet demonstrates how to change color space using Aspose.PDF for Java.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-miscellaneous-ChangingColorSpaceOfPDFDocument-.java" >}}
