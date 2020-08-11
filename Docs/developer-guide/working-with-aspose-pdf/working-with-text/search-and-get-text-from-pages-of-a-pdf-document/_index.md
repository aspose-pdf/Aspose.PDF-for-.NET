---
title: Search and Get Text from Pages of a PDF Document
type: docs
weight: 80
url: /net/search-and-get-text-from-pages-of-a-pdf-document/
---

## **Search and Get Text from All the Pages of PDF Document**
**TextFragmentAbsorber** class allows you to find text, matching a particular phrase, from all the pages of a PDF document. In order to search text from the whole document, you need to call the **Accept** method of **Pages** collection. The **Accept** method takes **TextFragmentAbsorber** object as a parameter, which returns a collection of **TextFragment** objects. You can loop through all the fragments and get their properties like **Text**, **Position** ( **XIndent**, **YIndent** ), **FontName**, **FontSize**, **IsAccessible**, **IsEmbedded**, **IsSubset**, **ForegroundColor** **, etc. 
The following code snippet shows you how to search for text from all the pages.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-SearchAndGetTextAll-SearchAndGetTextAll.cs" >}}

In case you need to search text inside any particular PDF page, please specify the page number from pages collection of Document instance and call Accept method against that page (as shown in code line below).

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-ReplaceTextPage-SearchInsideText.cs" >}}
## **Search and Get Text Segments from All Pages of PDF Document**
In order to search text segments from all the pages, you first need to get the **TextFragment** objects from the document. **TextFragmentAbsorber** allows you to find text, matching a particular phrase, from all the pages of a PDF document. In order to search text from the whole document, you need to call the **Accept** method of **Pages** collection. The **Accept** method takes **TextFragmentAbsorber** object as a parameter, which returns a collection of **TextFragment** objects. 
Once the **TextFragmentCollection** is fetched from the document, you need to loop through this collection and get **TextSegmentCollection** of each **TextFragment** object. After that, you can get all the properties of the individual **TextSegment** object. 
The following code snippet shows you how to search text segments from all the pages.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-SearchAndGetTextPage-SearchAndGetTextPage.cs" >}}

In order to search and get TextSegments from a particular page of PDF, you need to specify the particular page index when calling **Accept(..)** method. Please take a look at the following code lines.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-SearchTextSegmentsPage-textFragmentAbsorber.cs" >}}
## **Search and Get Text from all pages using Regular Expression**
**TextFragmentAbsorber** helps you search and retrieve text, from all the pages, based on a regular expression. First, you need to pass a regular expression to **TextFragmentAbsorber** constructor as the phrase. After that, you have to set the **TextSearchOptions** property of the **TextFragmentAbsorber** object. This property requires **TextSearchOptions** object and you need to pass **true** as a parameter to its constructor while creating new objects. As you want to retrieve matching text from all the pages, you need to call **Accept** method of **Pages** collection. **TextFragmentAbsorber** returns a **TextFragmentCollection** containing all the fragments matching the criteria specified by the regular expression. The following code snippet shows you how to search and get text from all the pages based on a regular expression.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-SearchRegularExpression-SearchRegularExpression.cs" >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-TextSegments-TextSegments.cs" >}}
## **Search Text based on Regex and Add Hyperlink**
If you want to add hyperlink over a text phrase based on regular expression, first find all the phrases matching that particular regular expression using TextFragmentAbsorber and add hyperlink over these phrases.

To find a phrase and add hyperlink over it:

1. Pass the regular expression as a parameter to the TextFragmentAbsorber constructor.
1. Create a TextSearchOptions object which specifies whether the regular expression is used or not.
1. Get the matching phrases into TextFragments.
1. Loop through the matches to get their rectangular dimensions, change the foreground color to blue (optional - to make it appear like a hyperlink and create a link using the PdfContentEditor class' CreateWebLink(..) method.
1. Save the updated PDF using Save method of Document object.

The following code snippet shows you how to search text inside a PDF file using a regular expression and adding hyperlinks over the matches.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-SearchTextAndAddHyperlink-SearchTextAndAddHyperlink.cs" >}}
## **Search and Draw Rectangle around each TextFragment**
Aspose.PDF for .NET supports the feature to search and get the coordinates of each character or text fragments. So in order to be certain about the coordinates being returned for each character, we may consider highlighting (adding rectangle) around each character.

In case of a text paragraph, you may consider using some regular expression to determine the paragraph break and draw a rectangle around it. Please take a look at the following code snippet. The following code snippet gets coordinates of each character and creates a rectangle around each character.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-SearchTextAndDrawRectangle-SearchTextAndDrawRectangle.cs" >}}
## **Highlight each character in PDF document**
{{% alert color="primary" %}} 

You can try searching for text in a document using Aspose.PDF and get the results online at this link:

[products.aspose.app/pdf/search](https://products.aspose.app/pdf/search) {{% /alert %}} 

Aspose.PDF for .NET supports the feature to search and get the coordinates of each character or text fragments. So in order to be certain about the coordinates being returned for each character, we may consider highlighting (adding rectangle) around each character. The following code snippet gets coordinates of each character and creates a rectangle around each character.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-HighlightCharacterInPDF-HighlightCharacterInPDF.cs" >}}
## **Add and Search Hidden Text**
Sometimes we want to add hidden text in a PDF document and then search hidden text and use its position for post-processing. For your convenience, Aspose.PDF for .NET provides these abilities. You can add hidden text during document generation. Also, you can find hidden text using TextFragmentAbsorber. To add hidden text ,set TextState.Invisible to 'true' for the added text. TextFragmentAbsorber finds all text that matches the pattern (if specified). It is the default behavior that can't be changed. In order to verify if the found text is actually invisible, the TextState.Invisible property can be used. The code snippet below shows how to use this feature. 

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Text-AddAndSearchHiddenText-AddAndSearchHiddenText.cs" >}}
## **Searching Text With .NET Regex**
Aspose.PDF for .NET provides the ability to search documents using the standard .NET Regex option. The TextFragmentAbsorber can be used for this purpose as shown in the code sample below.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Text-SearchTextWithDotNetRegex-SearchTextWithDotNetRegex.cs" >}}
