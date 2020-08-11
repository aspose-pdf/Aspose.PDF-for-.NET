---
title: Public API Changes in Aspose.PDF for Java 9.3.1
type: docs
weight: 60
url: /java/public-api-changes-in-aspose-pdf-for-java-9-3-1/
---

{{% alert color="primary" %}} 

This page lists the public API changes introduced in *Aspose.PDF for Java 9.3.1. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.PDF for Java which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

{{% /alert %}} 
#### **Following methods have been internalized:**
com.aspose.pdf.DocumentInfo.setCreator(String)
com.aspose.pdf.DocumentInfo.setProducer(String)
com.aspose.pdf.FileParams.getEngineDict()
#### **Following deprecated constants have been internalized, need to use static getters instead:**
com.aspose.pdf.ImageFormatInternal.Bmp
com.aspose.pdf.ImageFormatInternal.Emf
com.aspose.pdf.ImageFormatInternal.Exif
com.aspose.pdf.ImageFormatInternal.Gif
com.aspose.pdf.ImageFormatInternal.Jpeg
com.aspose.pdf.ImageFormatInternal.Icon
com.aspose.pdf.ImageFormatInternal.MemoryBmp
com.aspose.pdf.ImageFormatInternal.Png
com.aspose.pdf.ImageFormatInternal.Tiff
com.aspose.pdf.ImageFormatInternal.Wmf
com.aspose.pdf.TextEncodingInternal.ASCII
com.aspose.pdf.TextEncodingInternal.BigEndianUnicode
com.aspose.pdf.TextEncodingInternal.Default
com.aspose.pdf.TextEncodingInternal.Unicode
com.aspose.pdf.TextEncodingInternal.UTF32
com.aspose.pdf.TextEncodingInternal.UTF32BE
com.aspose.pdf.TextEncodingInternal.UTF7
com.aspose.pdf.TextEncodingInternal.UTF8
com.aspose.pdf.TextEncodingInternal.UTF8Unmarked
#### **Following field is added:**
public static Rectangle com.aspose.pdf.Rectangle.getEmpty() - returns Empty rectangle
