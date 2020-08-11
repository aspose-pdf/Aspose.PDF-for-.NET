---
title: Rotating stamp about the center point
type: docs
weight: 200
url: /net/rotating-stamp-about-the-center-point/
---

{{% alert color="primary" %}} 

[Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) in [Aspose.PDF for .NET](/pdf/net/home-html/) allows you to add a stamp in an existing PDF file. Sometimes, users do need to rotate the stamp. In this article, we’ll see how to rotate a stamp about its center point.

{{% /alert %}} 
## **Implementation details**
[Stamp](http://www.aspose.com/api/net/pdf/aspose.pdf/stamp) class allows you to add a watermark in a PDF file. You can specify image to be added as a stamp using **BindImage** method. The **SetOrigin** method allows you to set the origin of the added stamp; this origin is the lower-left coordinates of the stamp. You can also set the size of the image using **SetImageSize** method.

Now, we see how the stamp can be rotated about the center of the stamp. [Stamp](http://www.aspose.com/api/net/pdf/aspose.pdf/stamp) class provides a property named **Rotation**. This property sets or gets the rotation from 0 to 360 of stamp content. We can specify any rotation value from 0 to 360. By specifying the rotation value we can rotate the stamp about its center point. If a Stamp is an object of Stamp type then the rotation value can be specified as aStamp.Rotation = 90. In this case the stamp will be rotated at 90 degrees about the center of the stamp content. The following code snippet shows you how to rotate the stamp about the center point:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-RotatingStamp-RotatingStamp.cs" >}}
