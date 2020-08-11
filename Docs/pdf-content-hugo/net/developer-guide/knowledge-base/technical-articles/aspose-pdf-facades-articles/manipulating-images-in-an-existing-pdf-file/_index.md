---
title: Manipulating Images in an Existing PDF File
type: docs
weight: 260
url: /net/manipulating-images-in-an-existing-pdf-file/
---

{{% alert color="primary" %}} 

Images are an important part of the contents of a PDF document. Manipulating images in an existing PDF file is a common requirement of the people working with PDF files. In this article, we’ll explore how the images can be manipulated, in an existing PDF file, with the help of [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) of [Aspose.PDF for .NET](/pdf/net/home-html/). All the image related operations of [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) have been consolidated in this article.

{{% /alert %}} 
## **Implementation details**
[Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) allows you to add new images in an existing PDF file. You can also replace or remove an existing image. A PDF file can also be converted to images. You can either convert each individual page into a single image or a complete PDF file into one image. It allows you to formats i.e. JPEG, BMP, PNG and TIFF etc. You can extract the images from a PDF file as well. You can use four classes of [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) to implement these operations i.e. [PdfFileMend](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffilemend), [PdfContentEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfcontenteditor), [PdfExtractor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor) and [PdfConverter](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfconverter).
## **Image Operations**
In this section, we’ll have a detailed look into these image operations. We’ll also see the code snippets to show the use of the related classes and methods. First of all, let’s have a look at adding an image in an existing PDF file. We can use **AddImage** method of [PdfFileMend](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffilemend) class to add a new image. Using this method, you can not only specify the page number on which you want to add the image, but also the location of the image can be specified.



{{< highlight java >}}

 // Create PdfFileMend object to add image in the PDF file

PdfFileMend objFileMend = new PdfFileMend("input.pdf", "output.pdf");

// Add image in the PDF file

objFileMend.AddImage("image.jpg", 1, 200, 500, 350, 750);

// Close the PdfFileMend object

objFileMend.Close();

{{< /highlight >}}

In order to replace an existing image, we need to use **ReplaceImage** method of [PdfContentEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfcontenteditor) class. This method needs the new image which is to be added in place of the old image. You are also required to specify the page number and the index of the image which needs to be replaced.

{{< highlight java >}}



// Create PdfContentEditor object to replace existing image

PdfContentEditor objContentEditor = new PdfContentEditor();

// Bind input pdf file

objContentEditor.BindPdf("input.pdf");

// Replace image in the PDF file

objContentEditor.ReplaceImage(1, 1, "newimage.jpg");

// Save output PDF file

objContentEditor.Save("output.pdf");



{{< /highlight >}}

{{% alert color="primary" %}} 

When it comes to removing images, you can use [DeleteImage](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfcontenteditor/methods/deleteimage/index) method either to remove all the images or selected images based on image index. You can specify the page number and an array which represents index of image objects.

{{% /alert %}} 

{{< highlight java >}}

 // Create PdfContentEditor object to delete an image

PdfContentEditor objContentEditor = new PdfContentEditor();

// Bind input pdf file

objContentEditor.BindPdf("input.pdf");

// Delete an image by index

objContentEditor.DeleteImage(1, new int[] { 1 });

// Save output pdf file

objContentEditor.Save("output.pdf");

{{< /highlight >}}

[PdfExtractor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/PdfExtractor) class allows you to extract images from a PDF file. You can use [GetNextImage](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor/methods/getnextimage/index) method to save the images one by one. However, before getting images, you need to extract the images into memory using [ExtractImage](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfextractor/methods/extractimage) method.

{{< highlight java >}}

 // Create PdfExtractor object

PdfExtractor objExtractor = new PdfExtractor();

// Bind input pdf file

objExtractor.BindPdf("input.pdf");

// Extract image with specific mode

objExtractor.ExtractImage(ExtractImageMode.Default);

// Check if images extracted and save them one by one

while (objExtractor.HasNextImage())

   objExtractor.GetNextImage(DateTime.Now.Ticks.ToString() + ".jpg");



{{< /highlight >}}

{{% alert color="primary" %}} 

[Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) allows you to convert individual pages into different image formats as well. You can use [PdfConverter](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/PdfConverter) class to convert the PDF pages into images. You need to use [GetNextImage](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfconverter/methods/getnextimage/index) method of [PdfConverter](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfconverter/) class. However, please remember to call [DoConvert](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/PdfConverter) method to initialize the conversion process.

{{% /alert %}} 

{{< highlight java >}}

 // Create PdfConverter object

PdfConverter objConverter = new PdfConverter();

// Bind input pdf file

objConverter.BindPdf("input.pdf");

// Initialize the converting process

objConverter.DoConvert();

// Check if pages exist and then convert to image one by one

while (objConverter.HasNextImage())

   objConverter.GetNextImage(DateTime.Now.Ticks.ToString() + ".jpg", 

   System.Drawing.Imaging.ImageFormat.Jpeg);

// Close the PdfConverter object

objConverter.Close();



{{< /highlight >}}

[PdfConverter](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfconverter) class also allows you to convert a PDF file into a single TIFF image. [SaveAsTiff](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfconverter/methods/saveastiff/index) method can be used to convert the PDF into TIFF image.

{{< highlight java >}}

 // Create PdfConverter object

PdfConverter objConverter = new PdfConverter();

// Bind input pdf file

objConverter.BindPdf("input.pdf");

// Initialize the converting process

objConverter.DoConvert();

// Save pdf as tiff image

objConverter.SaveAsTIFF("output.tif");

// Close the PdfConverter object

objConverter.Close();



{{< /highlight >}}
## **Conclusion**
{{% alert color="primary" %}} 

In this article, we have explored the possible ways [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) allows you to manipulate the images in an existing PDF file. We can see that how flexible and easy it is to work with images in a PDF file using [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) of [Aspose.PDF for .NET](/pdf/net/home-html/).

{{% /alert %}}
