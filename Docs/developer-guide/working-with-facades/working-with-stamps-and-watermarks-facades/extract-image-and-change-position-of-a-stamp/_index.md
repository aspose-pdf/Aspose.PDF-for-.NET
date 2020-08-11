---
title: Extract Image and Change Position of a Stamp
type: docs
weight: 30
url: /net/extract-image-and-change-position-of-a-stamp/
---

## **Extract Image from an Image Stamp**
**PdfContentEditor** class allows you to extract images from a stamp in a PDF file. First, you need to create an object of **PdfContentEditor** class and bind input PDF file using **BindPdf** method. After that, call **GetStamps** method to get array of StampInfo objects from a particular page of PDF file. Then you can get the image from a StampInfo using StampInfo.Image property. Once you get the image, you can save the image or work with different properties of the image. The following code snippet shows you how to extract image from an image stamp.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Stamps-Watermarks-ExtractImageImageStamp-ExtractImageImageStamp.cs" >}}
## **Change Position of a Stamp in a PDF file**
**PdfContentEditor** class allows you to change the position of a stamp in a PDF file. First, you need to create an object of **PdfContentEditor** class and bind input PDF file using **BindPdf** method. After that, call **MoveStamp** method with stamp index and new position on a particular page of PDF file. Then, you can save the updated file using **Save** method. The following code snippet shows you how to move a stamp in a particular page.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Stamps-Watermarks-ChangeStampPosition-ChangeStampPosition.cs" >}}



Also, you can use **MoveStampById** method to move a specific stamp by using StampId.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Stamps-Watermarks-ChangeStampPosition-ChangeStampPositionByID.cs" >}}
