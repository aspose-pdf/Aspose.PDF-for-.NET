---
title: Add and Delete Images
type: docs
weight: 10
url: /net/add-and-delete-images/
---

## **Delete Images from a Particular Page of PDF (Facades)**
In order to delete the images from a particular page, you need to call **DeleteImage** method with **pageNumber** and **index** parameter. The **index** parameter represents an array of integers – the indexes of the images to be deleted. First of all, you need to create an object of **PdfContentEditor** class and then call the **DeleteImage** method. After that, you can save the updated PDF file using **Save** method. The following code snippet shows you how to delete images from a particular page of PDF.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Images-DeleteImagesPage-DeleteImagesPage.cs" >}}
## **Delete All the Images from a PDF File (Facades)**
All the images can be deleted from a PDF file using **DeleteImage** method of the **PdfContentEditor** . You only need to create an object of **PdfContentEditor** and bind the input PDF file using **BindPdf** method. After that, call the **DeleteImage** method – the overload without any parametes – to delete all the images, and then save the updated PDF file using **Save** method. The following code snippet shows you how to delete all the images from a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Images-DeleteAllImages-DeleteAllImages.cs" >}}
## **Add Image in an Existing PDF File (Facades)**
You can use **AddImage** method of the **PdfFileMend** class. The **AddImage** method requires the image to be added, the page number at which the image needs to be added and the coordinate information. After that, save the updated PDF file using **Close** method. The following code snippet shows you how to add image in an existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Images-AddImage-AddImage.cs" >}}
