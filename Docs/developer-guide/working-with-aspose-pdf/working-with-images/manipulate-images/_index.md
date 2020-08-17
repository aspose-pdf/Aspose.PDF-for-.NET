---
title: Manipulate Images
type: docs
weight: 40
url: /net/manipulate-images/
---

## **Add Image to Existing PDF File**
Every PDF page contains Resources and Contents properties. Resources can be images and forms for example, while content is represented by a set of PDF operators. Each operator has its name and argument. This example uses operators to add anh image to a PDF file.

To add an image to an existing PDF file:

1. Create a Document object and open the input PDF document.
1. Get the page you want to add an image to.
1. Add the image into the page’s Resources collection.
1. Use operators to place the image on the page:
   1. Use the GSave operator to save the current graphical state.
   1. Use ConcatenateMatrix operator to specify where the image is to be placed.
   1. Use the Do operator to draw the image on the page.
   1. Finally, use GRestore operator to save the updated graphical state.
1. Save the file.

The following code snippet shows how to add the image in a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Images-AddImage-AddImage.cs" >}}

{{% alert color="primary" %}}

By default, the JPEG quality is set to 100%. To apply better compression and quality, use the following overloads:

- the Replace method overload is added into the XImageCollection class:
  public void Replace(int index, Stream stream, int quality)
- The Add method overload is added into the XImageCollection class:
  public void Add(Stream stream, int quality)

{{% /alert %}}
## **Add Reference of a single Image multiple times in a PDF Document**
Sometimes we have a requirement to use same image multiple times in a PDF document. Adding a new instance increases the resultant PDF document. We have added a new method XImageCollection.Add(XImage) in Aspose.PDF for .NET 17.1.0. This method allows to add reference to the same PDF object as original image that optimize the PDF Document size.

**C#**

{{< highlight java >}}

 Aspose.PDF.Rectangle imageRectangle = new Aspose.PDF.Rectangle(0, 0, 30, 15);

using (Aspose.PDF.Document document = new Aspose.PDF.Document("input.pdf"))

{

    using (var imageStream = File.Open("icon.png", FileMode.Open))

    {

        XImage image = null;

        foreach (Page page in document.Pages)

        {

            WatermarkAnnotation annotation = new WatermarkAnnotation(page, page.Rect);

            XForm form = annotation.Appearance["N"];

            form.BBox = page.Rect;

            string name;

            if (image == null)

            {

                name = form.Resources.Images.Add(imageStream);

                image = form.Resources.Images[name];

            }

            else

            {

                name = form.Resources.Images.Add(image);

            }

            form.Contents.Add(new Operator.GSave());

            form.Contents.Add(new Operator.ConcatenateMatrix(new Aspose.PDF.Matrix(imageRectangle.Width, 0, 0, imageRectangle.Height, 0, 0)));

            form.Contents.Add(new Operator.Do(name));

            form.Contents.Add(new Operator.GRestore());

            page.Annotations.Add(annotation, false);

            imageRectangle = new Aspose.PDF.Rectangle(0, 0, imageRectangle.Width * 1.01, imageRectangle.Height * 1.01);

        }

    }

    document.Save("output.pdf");

}


{{< /highlight >}}
## **Delete Images from a PDF File**
To delete an image from a PDF file:

1. Create a Document object and open the input PDF file.
1. Get the Page that holds the image from the Document object’s Pages collection.
1. Images are held in the Images collection, found in the page's Resources collection.
1. Delete an image with the Images collection's Delete method.
1. Saved the output like using the Document object's Save method.

The following code snippet shows how to delete an image from a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Images-DeleteImages-DeleteImages.cs" >}}
## **Extract Images from the PDF File**
Images are held in each page's [Resources](https://apireference.aspose.com/net/pdf/aspose.pdf/resources) collection's [Images](https://apireference.aspose.com/net/pdf/aspose.pdf/resources/properties/images) collection. To extract a particular page, then get the image from the Images collection using the particular index of the image.

The image's index returns an [XImage](https://apireference.aspose.com/net/pdf/aspose.pdf/ximage) object. This object provides a Save method which can be used to save the extracted image. The following code snippet shows how to extract images from a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Images-ExtractImages-ExtractImages.cs" >}}
## **Get the Resolution and Dimensions of Embedded Images**
This topic explains how to use the operator classes in the Aspose.PDF namespace which provide the capability to get resolution and dimension information about images without having to extract them.

There are different ways of achieving this. This article explains how to use an `arraylist` and [image placement classes](https://apireference.aspose.com/net/pdf/aspose.pdf/imageplacement).
### **Getting Image Information without Extracting the Images**
Aspose.PDF for .NET lets you [extract images from a PDF file](/pdf/net/manipulate-images/). Once the images are extracted, we can get information about the image's dimensions and resolution. However, there are scenarios where we do not want to extract the images to get this information. When this is the case, we can still using Aspose.PDF for .NET to get the information.

1. First, load the source PDF file (with images).
1. Then create an ArrayList object to hold the names of any images in the document.
1. Get the images using the Page.Resources.Images property.
1. Create a stack object to hold the image's graphics state and use it to keep track of different image states.
1. Create a ConcatenateMatrix object which defines current transformation. It also supports scaling, rotating, and skewing any content. It concatenates the new matrix with previous one. Please note that we cannot define the transformation from scratch but only modify the existing transformation.
1. Because we can modify the matrix with ConcatenateMatrix, we may also need to revert back to the original image state. Use GSave and GRestore operators.
   These operators are paired so they should be called together. For example, if you do some graphics work with complex transformations and finally return transformations back to initial state, the approach will be something like this:

{{< highlight csharp >}}

 // Draw some text

GSave

ConcatenateMatrix  // rotate contents after the operator

// Some graphics work

ConcatenateMatrix // scale (with previous rotation) contents after the operator

// Some other graphics work

GRestore

// Draw some text

{{< /highlight >}}



As a result, text is drawn in regular form but some transformations are performed between the text operators. In order to display the image or to draw form objects and images, we need to use the Do operator.

We also have a class named [XImage](https://apireference.aspose.com/net/pdf/aspose.pdf/ximage) which provides two properties,l Width and Height, which can be used to get image dimensions.

1. Perform some calculations to compute the image resolution.
1. Display the information in a Command Prompt along with the image name.

The following code snippet shows you how to get an image's dimensions and resolution without extracting the image from the PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Images-ImageInformation-ImageInformation.cs" >}}


### **Working with Image Placement**
With the release of Aspose.PDF for .NET 7.0.0, we introduced classes called [ImagePlacement](https://apireference.aspose.com/net/pdf/aspose.pdf/imageplacement), [ImagePlacementAbsorber](https://apireference.aspose.com/net/pdf/aspose.pdf/imageplacementabsorber) and [ImagePlacementCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/imageplacementcollection) which provide similar capability as [the classes described above](/pdf/net/manipulate-images/) to get an image's resolution and position in a PDF document.

- **ImagePlacementAbsorber** performs image usage search as the ImagePlacement objects collection.
- **ImagePlacement** provides the members Resolution and Rectangle that return actual image placement values.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Images-ImagePlacements-ImagePlacements.cs" >}}
## **Search and Get Images from PDF Document**
The [ImagePlacementAbsorber](https://apireference.aspose.com/net/pdf/aspose.pdf/imageplacementabsorber) allows you to search among images on all pages in a PDF document.

To search a whole document for images:

1. Call the [Pages](https://apireference.aspose.com/net/pdf/aspose.pdf/pagecollection) collection's Accept method.
   The Accept method takes an [ImagePlacementAbsorber](https://apireference.aspose.com/net/pdf/aspose.pdf/imageplacementabsorber) object as a parameter. This returns a collection of [ImagePlacement](https://apireference.aspose.com/net/pdf/aspose.pdf/imageplacement) objects.
1. Loop through the ImagePlacements objects and get their properties (Image, dimensions, resolution and so on).

The following code snippet shows how to search a document for all its images.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Images-SearchAndGetImages-SearchAndGetImages.cs" >}}

To get an image from an individual page, use the following code:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Images-ImagePlacements-ExtractImageFromIndividualPage.cs" >}}
## **Identify if image inside PDF is Colored or Black & White**
Different type of compression can be applied over images to reduce their size. The type of compression being applied over image depends upon the ColorSpace of source image i.e. if image is Color (RGB), then apply JPEG2000 compression, and if it is Black & White, then JBIG2/JBIG2000 compression should be applied. Therefore identifying each image type and using an appropriate type of compression will create best/optimized output.

A PDF file may contain Text, Image, Graph, Attachment, Annotation etc elements and if the source PDF file contains images, we can determine image Color space and apply appropriate compression for image to reduce PDF file size. The following code snippet shows the steps to Identify if image inside PDF is Colored or Black & White.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Images-IdentifyImages-IdentifyImages.cs" >}}
## **Replace Image in Existing PDF File**
The Images collection's Replace method allows you to replace an image in an existing PDF file.

The Images collection can be found in a page's **Resources** collection. To replace an image:

1. Open the PDF file using the **Document** object.
1. Replaced the , save the updated PDF file using Save method of the Document object.

The following code snippet shows you how to replace an image in a PDF file.



{{< highlight java >}}

 // Open document

Document pdfDocument = new Document("input.pdf");

// Replace a particular image

pdfDocument.Pages[1].Resources.Images.Replace(1, new FileStream("lovely.jpg", FileMode.Open));

// Save updated PDF file

pdfDocument.Save("output.pdf");



{{< /highlight >}}
### **Control Image Quality**
It is possible to control the quality of an image that's being added to a PDF file. Use the overloaded Replace method in the XImageCollection class: public void Replace(int index, Stream stream, int quality)

The following code snippet demonstrates how to convert all the document images into JPEGs that use 80% quality for compression.

{{< highlight java >}}

 Aspose.PDF.Document pdfDocument = new Aspose.PDF.Document(inFile);

foreach (Aspose.PDF.Page page in pdfDocument.Pages)

{

    int idx = 1;

    foreach (Aspose.PDF.XImage image in page.Resources.Images)

    {

        using (MemoryStream imageStream = new MemoryStream())

        {

            image.Save(imageStream, System.Drawing.Imaging.ImageFormat.Jpeg);

            page.Resources.Images.Replace(idx, imageStream, 80);

            idx = idx + 1;

        }

    }

}

// pdfDocument.OptimizeResources();

pdfDocument.Save(outFile);

{{< /highlight >}}
## **Set Image Size**
It is possible to set the size of an image that's being added to a PDF file. In order to set size, you can use **FixWidth** and **FixHeight** properties of Aspose.Pdf.Image Class. The following code snippet demonstrates how to set the size of an image:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Images-SetImageSize-SetImageSize.cs" >}}
## **Set Default Font Name**
Aspose.PDF for .NET API allows you to set a default font name when a font is not available in the document. You can use **DefaultFontName** property of **RenderingOptions** class to set the default font name. In case DefaultFontName is set to null the Times New Roman font will be used. The following code snippet shows how to set a default font name when saving PDF into an image:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-DocumentConversion-SetDefaultFontName-1.cs" >}}
## **Support for DICOM Images**
Aspose.PDF for .NET supports functionality to add DICOM images to PDF documents. The following code snippet shows how to use this functionality.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Images-AddImage-AddDicomImage.cs" >}}
