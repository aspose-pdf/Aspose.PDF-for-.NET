---
title: Extract Text from PDF
type: docs
weight: 40
url: /net/extract-text-from-pdf/
---

## **Extract Text From All the Pages of a PDF Document**
Extracting text from a PDF document is a common requirement. In this example, you’ll see how Aspose.PDF for .NET allows extracting text from all the pages of a PDF document. You need to create an object of the **TextAbsorber** class. After that, open the PDF using **Document** class and call the **Accept** method of the **Pages** collection. The **TextAbsorber** class absorbs the text from the document and returns in **Text** property. The following code snippet shows you how to extract text from all pages of PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-ExtractTextAll-ExtractTextAll.cs" >}}

Call the **Accept** method on a particular page of the Document object. The Index is the particular page number from where text needs to be extracted.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-ExtractTextPage-ExtractTextPage.cs" >}}
## **Extract Text from Pages using Text Device**
You can use the **TextDevice** class to extract text from a PDF file. TextDevice uses TextAbsorber in its implementation, thus, in fact, they do the same thing but TextDevice just implemented to unify the "Device" approach to extract anything from the page ImageDevice, PageDevice, etc. TextAbsorber may extract text from Page, entire PDF or XForm, this TextAbsorber is more universal
### **Extract text from all pages**
The following steps and code snippet shows you how to extract text from a PDF using the text device.

1. Create an object of Document class with input PDF file specified
1. Create an object of TextDevice class
1. Use object of TextExtractOptions class to specify extraction options
1. Use the Process method of TextDevice class to convert contents to the text
1. Save the text to the output file

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-ExtractTextUsingTextDevice-ExtractTextUsingTextDevice.cs" >}}
## **Extract Text from a particular page region**
**TextAbsorber** class provides the capability to extract text from a particular or all pages of a PDF document. This class returns the extracted text in the **Text** property. However, if we have the requirement to extract text from a particular page region, we can use the **Rectangle** property of **TextSearchOptions.** The Rectangle property takes a Rectangle object as a value and using this property, we can specify the region of the page from which we need to extract the text.

The **Accept** method of a page is called to extract the text. Create objects of **Document** and **TextAbsorber** classes. Call **Accept** method on the individual page, as **Page**Index, of the **Document** object. The **Index** is the particular page number from where text needs to be extracted. You can get text from the **Text** property of the **TextAbsorber** class. The following code snippet shows you how to extract text from an individual page.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-ExtractTextFromPageRegion-ExtractTextFromPageRegion.cs" >}}
## **Extract text based on columns**
A PDF file may comprise of Text, Image, Annotations, Attachments, Graphs, etc elements and Aspose.PDF for .NET offers the feature to Add as well as manipulate all of these elements. This API is remarkable when comes to Text addition and extraction from PDF document and we may come across a scenario where a PDF document is comprised of more than one columns (multi-column) PDF document and we need to extract the page contents while honoring the same layout, then Aspose.PDF for .NET is the right choice to accomplish this requirement. One approach is to reduce the font size of contents inside the PDF document and then perform text extraction. The following code snippet shows the steps to reduce text size and then try extracting text from PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-ExtractColumnsText-ExtractColumnsText.cs" >}}
### **Second approach - Using ScaleFactor**
In this new release, we also have introduced several improvements in TextAbsorber and in the internal text formatting mechanism. So now during the text extraction using ‘Pure’ mode, you may specify the ScaleFactor option and it can be another approach to extract text from a multi-column PDF document besides the above-stated approach. This scale factor may be set to adjust the grid which is used for the internal text formatting mechanism during text extraction. Specifying the ScaleFactor values between 1 and 0.1 (including 0.1) has the same effect as font reduction.

Specifying the ScaleFactor values between 0.1 and -0.1 is treated as zero value, but it makes the algorithm to calculate scale factor needed during extracting text automatically. The calculation is based on average glyph width of the most popular font on the page, but we cannot guarantee that in extracted text no string of column reaches the start of the next column. Please note that if ScaleFactor value is not specified, the default value of 1.0 will be used. It means no scaling will be carried out. If the specified ScaleFactor value is more than 10 or less than -0.1, the default value of 1.0 will be used.

We propose the usage of auto-scaling (ScaleFactor = 0) when processing a large number of PDF files for text content extraction. Or manually set redundant reducing of grid width ( about ScaleFactor = 0.5). However, you must not determine whether scaling is necessary for concrete documents or not. If You set redundant reducing of grid width for the document (that doesn't need in it), the extracted text content will remain fully adequate. Please take a look at the following code snippet.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-ExtractColumnsText-UsingScaleFactor.cs" >}}

{{% alert color="primary" %}} 

Please note that there is no direct correspondence between the new ScaleFactor and the old coefficient of manually font reducing. However, by default algorithm takes into account the value of font size that has already reduced due to some internal reasons. For example, reducing font size from 10 to 7 has the same effect as setting a scale factor to 5/8 (= 0.625).

{{% /alert %}} 
## **Extract Highlighted Text from PDF Document**
In various scenarios of text extraction from a PDF document, you can come up with a requirement to extract only highlighted text from PDF document. In order to implement the functionality, we have added TextMarkupAnnotation.GetMarkedText() and TextMarkupAnnotation.GetMarkedTextFragments() methods in API. You can extract highlighted text from PDF document by filtering TextMarkupAnnotation and using the mentioned methods. The following code snippet shows how you can extract highlighted text from PDF document. 

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-ExtractHighlightedText-1.cs" >}}
## **Access Text Fragment and Segment Elements from XML**
Sometimes we need access to TextFragement or TextSegment items when processing PDF documents generated from XML. Aspose.PDF for .NET provides access to such items by name. The code snippet below shows how to use this functionality.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Text-AccessTextFragementAndTextSegmentElementsFromXMLFile-AccessTextFragementAndTextSegmentElementsFromXMLFile.cs" >}}

