---
title: Text Formatting inside PDF
type: docs
weight: 20
url: /net/text-formatting-inside-pdf/
---

## **Add Line Indent**
Aspose.PDF for .NET offers SubsequentLinesIndent property into TextFormattingOptions class. Which can be used to specify line indent in PDF generation scenarios with TextFragment and Paragraphs collection. Please use the following code snippet to use the property:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddSubsequentLinesIndent-1.cs" >}}
## **Add Text Border**
The following code snippet shows, how to add a border to a text using TextBuilder and setting DrawTextRectangleBorder property of TextState:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddTextBorder-1.cs" >}}
## **Add Underline Text**
The following code snippet shows you how to add Underline text while creating a new PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddText-AddUnderlineText.cs" >}}
## **Adding a Border Around Added Text**
You have control over the look and feel of the text you add. The example below shows how to add a border around a piece of text that you have added by drawing a rectangle around it. Find out more about the [PdfContentEditor](https://apireference.aspose.com/pdf/net/aspose.pdf.facades/pdfcontenteditor) class.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddText-AddingBorderAroundAddedText.cs" >}}
## **Adding NewLine feed**
TextFragment doesn't support line feed inside the text. However in order to add text with line feed, please use TextFragment with TextParagraph:

- use "\r\n" or Environment.NewLine in TextFragment instead of single "\n";
- create TextParagraph object. It will add text with line splitting;
- add the TextFragment with TextParagraph.AppendLine;
- add the TextParagraph with TextBuilder.AppendParagraph.

Please use below code snippet.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddText-AddNewLineFeed.cs" >}}
## **Adding StrikeOut Text**
The TextState class provides the capabilities to set formatting for TextFragments being placed inside PDF document. You can use this class to set text formatting as Bold, Italic, Underline and starting this release, the API has provided the capabilities to mark text formatting as Strikeout. Please try using the following code snippet to add TextFragment with Strikeout formatting.

Please use complete code snippet:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddText-AddStrikeOutText.cs" >}}
## **Apply Gradient Shading to the Text**
Text formatting has been further enhanced in the API for text editing scenarios and now you can add text with pattern colorspace inside PDF document. Aspose.Pdf.Color Class has further been enhanced by introducing new property of PatternColorSpace, which can be used to specify shading colors for the text. This new property adds different Gradient Shading to the text e.g. Axial Shading, Radial (Type 3) Shading as shown in the following code snippet:



{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddTextWithShadingColors-1.cs" >}}

{{% alert color="primary" %}}

In order to apply a Radial Gradient, you can set 'PatternColorSpace' property equal to 'Aspose.Pdf.Drawing.GradientRadialShading(startingColor, endingColor)' in the above code snippet.

{{% /alert %}}
## **Text Alignment for Floating Box Contents**


Aspose.PDF supports setting text alignment for contents inside a Floating Box element. The alignment properties of Aspose.Pdf.FloatingBox instance can be used to achieve this as shown in the following code sample.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Text-TextAlignmentForFloatingBoxContents-TextAlignmentForFloatingBoxContents.cs" >}}
