---
title: Set FreeTextAnnotation Formatting and Strike Out Words
type: docs
weight: 40
url: /net/set-freetextannotation-formatting-and-strike-out-words/
---

## **Set Formatting of FreeTextAnnotation**
[Add Annotation in an Existing PDF File](/pdf/net/add-2c-delete-and-get-annotation-html/) explained how to add annotations to a file. This topic looks at how to format the text in a free text annotation.

Annotations are contained in a [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) object's [AnnotationCollection](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationcollection) collection. When adding a [FreeTextAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/freetextannotation) to a PDF document, you can specify the formatting information such as font, size, color and so on using the [DefaultAppearance](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/defaultappearance/methods/index) class. It is also possible to specify the formatting information using the TextStyle property. Furthermore, you can update the formatting of any FreeTextAnnotation already in the PDF document.

The [TextStyle](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/textstyle) class supports working with the default style entry. This class allows you to set color, font size and font name:

- The FontName property gets or sets the font name (string).
- The FontSize property gets and sets the default text size (double).
- The System.Drawing.Color property gets and sets the text colour (color).
- The TextAlignment property gets and sets the annotation's text alignment (alignment).

The following code snippet shows how to add a FreeTextAnnotation with specific text formatting.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-SetFreeTextAnnotationFormatting-SetFreeTextAnnotationFormatting.cs" >}}

{{% alert color="primary" %}} 

When you change the contents or text style of a free text annotation, the annotation's appearance is regenerated to reflect changes.

{{% /alert %}} 
## **Strike Out Words using StrikeOutAnnotation**
Aspose.PDF for .NET allows you to add, delete and update annotations in PDF documents. One of the classes allows you to strike out annotations too. This is useful when you want to strike out one or more text fragments in a documect. Annotations are held in a [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) object's [AnnotationCollection](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationcollection) collection. A class named [StrikeOutAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/strikeoutannotation) can be used to add strike out annotations to a PDF document.

To strike out a certain TextFragment:

1. Search for a TextFragment in the PDF file.
1. Get the TextFragment object's coordinates.
1. Use the coordinates to instantiate a StrikeOutAnnotation object.

The following code snippet shows how to search for a particular TextFragment and add a StrikeOutAnnotation to that object.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-StrikeOutWords-StrikeOutWords.cs" >}}
