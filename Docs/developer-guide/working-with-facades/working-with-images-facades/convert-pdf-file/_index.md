---
title: Convert PDF File
type: docs
weight: 20
url: /net/convert-pdf-file/
---

## **Convert PDF Pages to Different Image Formats (Facades)**
In order to convert PDF pages to different image formats, you need to create **PdfConverter** object and open the PDF file using **BindPdf** method. After that, you need to call **DoConvert** method for initialization tasks. Then, you can loop through all the pages using **HasNextImage** and **GetNextImage** methods. The **GetNextImage** method allows you to create image of a particular page. You also need to pass ImageFormat to this method in order to create an image of specific type i.e. JPEG, GIF or PNG etc. Finally, call the **Close** method of the **PdfConverter** class. The following code snippet shows you how to convert PDF pages to images.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Images-ConvertPDFPages-ConvertPDFPages.cs" >}}
## **Convert PDF File to Single TIFF Image (Facades)**
In order to convert PDF pages to single TIFF image format, you need to create **PdfConverter** object and open the PDF file using **BindPdf** method. After that, you need to call **DoConvert** method for initialization tasks. Then, you can use **SaveAsTIFF** method to save the PDF file as a single TIFF image. Finally, call the **Close** method of the **PdfConverter** class. The following code snippet shows you how to convert PDF pages to single TIFF image.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Images-ConvertToTIFF-ConvertToTIFF.cs" >}}
## **Convert PDF File to Single TIFF Image using Settings (Facades)**
In order to convert PDF pages to single TIFF image format, you need to create **PdfConverter** object and open the PDF file using **BindPdf** method. After that, you need to call **DoConvert** method for initialization tasks. Then, you can use **SaveAsTIFF** method to save the PDF file as a single TIFF image.

You can also specify certain settings to produce a TIFF image according to your requirement. You can set the resolution of the output image using **Resolution** property of the **PdfConverter** class. You need to set this property before **BindPdf** method. You can also specify other settings using **TiffSettings** class and then pass this object to the **SaveAsTiff** method. Finally, call the **Close** method of the **PdfConverter** class. The following code snippet shows you how to convert PDF pages to single TIFF image using Settings.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Images-ConvertToTIFFSettings-ConvertToTIFFSettings.cs" >}}

{{% alert color="primary" %}} 

If your requirement is to save the resultant TIFF file to a specific page size, you can use the overloaded **SaveAsTIFF** method of **PdfConverter** with **Aspose.Pdf.Facades.PageSize** parameter. Different predefined page sizes are available as per your need e.g. A4, A3, Letter etc.

{{% /alert %}} 
## **Convert particular page region to Image format**
We know that **PdfConverter** class offers **DoConvert** method which provides the capability to convert the whole PDF pages into Image format. However sometimes there is a requirement to convert particular page region into Image format, so in order to fulfill this requirement, we may consider using **MovePosition(..)** method of **PdfPageEditor** class which provides the capability to move the origin from (0, 0) to the specified point. The origin is left-bottom and the unit is point.

We are also aware that **PdfConverter** class also contains methods which provide the capability to loop through all the pages using **HasNextImage** and **GetNextImage** methods. The **GetNextImage** method allows you to create image of a particular page. You also need to pass ImageFormat to this method in order to create an image of specific type i.e. JPEG, GIF or PNG etc. Finally, call the **Close** method of the **PdfConverter** class.
{{% alert color="primary" %}} 
1 inch = 72 points and 1 cm = 1/2.54 inch = 0.3937 inch = 28.3 points.
{{% /alert %}} 
The following code snippet shows you how to convert PDF pages to images.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Images-ConvertPageRegion-ConvertPageRegion.cs" >}}



