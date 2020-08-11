---
title: Search and Get Text from Pages of a PDF Document
type: docs
weight: 30
url: /java/search-and-get-text-from-pages-of-a-pdf-document/
---

## **Search and Get Text from Pages of PDF Document**
TextFragmentAbsorber allows you to find text, matching a particular phrase, from all pages of a PDF document.

To search text in the whole document, call the [Pages](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) collection's accept() method. The [accept()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextFragmentAbsorber) method takes a TextFragmentAbsorber object as a parameter, which returns a collection of TextFragment objects. Loop through all the fragments to get their properties, for example Text, Position, XIndent, YIndent, FontName, FontSize, IsAccessible, IsEmbedded, IsSubset, ForegroundColor etc.

The following code snippet shows how to search an the entire document and display all matches in a console.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-SearchAndGetTextFromThePagesOfPDFDocument-.java" >}}


To search text on a particular page and get properties associated with it, provide the page index:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Text-SearchAndGetTextFromThePagesOfPDFDocument-Info.java" >}}
## **Search and Get Text Segments from Pages of PDF**
To search text segments on all pages in a document, get a document's TextFragment objects.

TextFragmentAbsorber allows you to find text, matching a particular phrase, from all the pages in a PDF document. To search text in the whole document, call the Pages|http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/PageCollection collection's [accept()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextFragmentAbsorber) method. The [accept()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextFragmentAbsorber) method takes a TextFragmentAbsorber object as a parameter, which returns a collection of TextFragment objects.

{{% alert color="primary" %}} 

When the TextFragmentCollection collection has been fetched from the document, loop through it to get each TextFragment object's TextSegmentCollection collection. After that, you can get the individual TextSegment object's properties.

{{% /alert %}} 

The following code snippet shows how to search text segments on all pages.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-SearchAndGetTextSegmentsFromPagesOfPDF-.java" >}}


To search a specific text segment and get the properties associated, specify the page index for the page you want to search:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Text-SearchAndGetTextSegmentsFromPagesOfPDF-Info.java" >}}
## **Search and Get Text from pages using Regular Expression**
TextFragmentAbsorber helps you search and retrieve text from all pages in a document, based on a regular expression.

To search and get text from a document:

1. Pass the search term as a regular expression to the TextFragmentAbsorber constructor.
1. Set the TextFragmentAbsorber object's TextSearchOptions property.
   This property requires a TextSearchOptions object: pass true to its constructor when creating a new object.
1. To retrieve matching text from all pages, call the Pages|http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/PageCollection collection's [accept()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/TextFragmentAbsorber) method.
   TextFragmentAbsorber returns a TextFragmentCollection containing all the fragments matching the criteria specified by the regular expression.

The following code snippet shows how to search all pages in a document and get text based on a regular expression.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-SearchAndGetTextFromPagesUsingRegularExpression-.java" >}}


To search text on a particular page and get its properties, specify the page index:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Text-SearchAndGetTextFromPagesUsingRegularExpression-Info1.java" >}}


In order to search a string in either upper case or lowercase, you may consider using regular expression.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Text-SearchAndGetTextFromPagesUsingRegularExpression-Info2.java" >}}

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Text-SearchAndGetTextFromPagesUsingRegularExpression-Info3.java" >}}
