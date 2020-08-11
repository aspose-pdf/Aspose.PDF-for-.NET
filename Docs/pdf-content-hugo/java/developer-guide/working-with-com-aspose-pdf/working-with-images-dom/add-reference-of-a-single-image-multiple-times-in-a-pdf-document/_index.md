---
title: Add Reference of a single Image multiple times in a PDF Document
type: docs
weight: 80
url: /java/add-reference-of-a-single-image-multiple-times-in-a-pdf-document/
---

Sometimes we have a requirement to use same image multiple times in a PDF document. Adding a new instance increases the resultant PDF document. We have added a new method XImageCollection.add(XImage) that supports Ximage object to add in the Images Collection. This method allows to add reference to the same PDF object as original image that optimize the PDF Document size.

**Java**

{{< highlight java >}}

 com.aspose.pdf.Rectangle imageRectangle = new com.aspose.pdf.Rectangle(0, 0, 30, 15);

//Load image into stream

java.io.FileInputStream imageStream = new java.io.FileInputStream(new java.io.File("icon.png"));

//Open a document

Document pdfDocument = new Document("input.pdf");

XImage image = null;

for (int pageCount = 1; pageCount <= pdfDocument.getPages().size(); pageCount++)

{

WatermarkAnnotation annotation = new WatermarkAnnotation(pdfDocument.getPages().get_Item(pageCount), pdfDocument.getPages().get_Item(pageCount).getRect());

XForm form = annotation.getAppearance().get_Item("N");

form.setBBox(pdfDocument.getPages().get_Item(pageCount).getRect());

String name;

if (image == null)

{

name = form.getResources().getImages().add(imageStream);

image = form.getResources().getImages().get_Item(name);

}

else

{

name = form.getResources().getImages().add(image);

}

form.getContents().add(new Operator.GSave());

form.getContents().add(new Operator.ConcatenateMatrix(new com.aspose.pdf.Matrix(imageRectangle.getWidth(),0, 0, imageRectangle.getHeight(), 0, 0)));

form.getContents().add(new Operator.Do(name));

form.getContents().add(new

Operator.GRestore());

pdfDocument.getPages().get_Item(pageCount).getAnnotations().add(annotation,false);

imageRectangle = new com.aspose.pdf.Rectangle(0, 0, imageRectangle.getWidth() * 1.01, imageRectangle.getHeight() * 1.01);

}

//Save the new PDF

pdfDocument.save("Updated_document.pdf");

//Close image stream

imageStream.close();

{{< /highlight >}}
