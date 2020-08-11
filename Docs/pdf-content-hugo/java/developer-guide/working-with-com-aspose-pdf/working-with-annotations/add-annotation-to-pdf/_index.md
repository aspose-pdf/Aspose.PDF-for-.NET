---
title: Add Annotation to PDF
type: docs
weight: 10
url: /java/add-annotation-to-pdf/
---

1 [Add Text Annotation](#AddAnnotationtoPDF-AddTextAnnotation)

2 [Invisible Annotation](#AddAnnotationtoPDF-InvisibleAnnotation)

3 [Add Watermark Annotation](#AddAnnotationtoPDF-AddWatermarkAnnotation)
## **Add Text Annotation**
{{% alert color="primary" %}} 

Annotations are held in a [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) object's Annotations collection. Each page has its own Annotations collection. To add an annotation to a page, use the add() method of that page's Annotations collection.

{{% /alert %}} 

To add an annotation:

1. Open the input PDF.
1. Create the annotation you want to add.
1. Add the annotation to Annotations collection of the page you want to add it to.

The following code snippet shows how to add an annotation to a PDF page.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-annotations-AddAnnotationToPDF-AddAnnotationToPDF.java" >}}

Cross, circle and star values are also added to the com.aspose.pdf.TextIcon enumeration.

- **Cross** - cross icon.
- **Circle** - circle icon.
- **Star** - star icon.
## **Invisible Annotation**
Sometimes, it is necessary to create a watermark that isn't visible in the document when viewing it but should be visible when the document is printed. Use annotation flags for this purpose. The following code snippet shows how to accomplish this requirement.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-annotations-AddAnnotationToPDF-InvisibleAnnotation.java" >}}
## **Add Watermark Annotation**
You can add Watermark Text using WatermarkAnnotation at specific position of PDF page, opacity of Watermark can also controlled by using opacity property. Please check following code snippet to add WatermarkAnnotation.

**Java**

{{< highlight java >}}

 //Load a Document

com.aspose.pdf.Document doc = new com.aspose.pdf.Document(myDir+"HelloWorld.pdf");

//Load Page object to add Annotation

Page page = doc.getPages().get_Item(1);

//Create Annotation

WatermarkAnnotation wa = new WatermarkAnnotation(page, new com.aspose.pdf.Rectangle(100, 500, 400, 600));

//Add annotation into Annotation collection of Page

page.getAnnotations().add(wa);

//Create TextState for Font settings

com.aspose.pdf.TextState ts = new com.aspose.pdf.TextState();

ts.setForegroundColor(com.aspose.pdf.Color.getBlue());

ts.setFont(FontRepository.findFont("Times New Roman"));

ts.setFontSize(32);

//Set opacity level of Annotation Text

wa.setOpacity(0.1);

//Add Text in Annotation

wa.setTextAndState(new String[] { "HELLO", "Line 1", "Line 2" }, ts);

//Save the Document

doc.save(myDir+"Output.pdf");

{{< /highlight >}}
