---
title: Performance Improvement during PDF to TIFF Conversion
type: docs
weight: 290
url: /net/performance-improvement-during-pdf-to-tiff-conversion/
---

{{% alert color="primary" %}} 

[Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) in [Aspose.PDF for .NET](/pdf/net/home-html/) allows you to convert PDF files to TIFF images. Sometimes users have to face performance issues while converting PDF to TIFF format. This article explains in detail the cause of the low performance and suggests the approach to gain optimal performance.

{{% /alert %}} 
## **Implementation details**
The default color depth while converting PDF to TIFF format is 32 bpp (bits per pixel). It is possible to specify other color depths using **ColorDepth Enumeration** as shown in the following code snippet:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-PDFToTIFFConversion-PDFToTIFFConversion.cs" >}}



The process of re-coloring an image by assigning a color-reduced palette is termed as [Quantization](http://en.wikipedia.org/wiki/Quantization_%28image_processing%29) . The process of color quantization reduces the number of colors used in an image. Unfortunately, some functionality which is present in GDI+ (Windows Graphics Driver Interface) is simply absent from the standard .NET Framework. The SaveAsTIFF method realizes quantization to 1 bpp, 4 bpp and 8 bpp using managed C# code, and therefore it is not optimal.

We have added a special interface named IIndexBitmapConverter. This interface has been provided to support customized quantization algorithms. Users can implement their own realization of this interface; for example, algorithms based on unmanaged code. As an example, we have realized this interface on the base of unmanaged code that uses Windows API:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-PDFToTIFFConversion-IIndexBitmapConverter.cs" >}}

The use of Windows API or unmanaged realization with other languages like C or assembly, or special graphics libraries can substantially increase speed of quantization algorithms. For example, our benchmark with WinAPIIndexBitmapConverter class shown above gives the following results:

|**Color Depth**|**Performance Improvement**|
| :- | :- |
|1 bpp|3.5 times|
|4 bpp|5 times|
|8 bpp|8 times|
## **Overload methods of SaveAsTIFF**
We have introduced the following two overloads of SaveAsTIFF method to support new interface:

public void SaveAsTIFF(Stream,int,int,TiffSettings,IIndexBitmapConverter); 
public void SaveAsTIFF(string,int,int,TiffSettings,IIndexBitmapConverter);
## **Implementation steps**
The following code snippet shows you how to use this new approach:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-PDFToTIFFConversion-NewApproach.cs" >}}
## **Conclusion**
{{% alert color="primary" %}} 

The use of new mechanism to realize your own implementation of the IIndexBitmapConverter interface can provide you a lot more flexibility and help improve the overall performance of PDF to TIFF conversion.

{{% /alert %}}
