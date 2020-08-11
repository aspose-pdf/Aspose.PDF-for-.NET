---
title: Replace Text in a PDF Document
type: docs
weight: 40
url: /java/replace-text-in-a-pdf-document/
---

## **Replace Text in Pages of a PDF Document**
### **Replacing Text**
To replace text on all pages in a PDF document using [Aspose.PDF for Java](https://products.aspose.com/pdf/java):

1. First use TextFragmentAbsorber to find the particular phrase to be replaced.
1. Then, go through all TextFragments to replace the text and change any other attributes.
1. Finally, save the output PDF using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's save method.
### **Replace Text on All Pages**
The following code snippet shows how to replace text on all pages of PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-ReplaceTextInPagesOfPDFDocument-ReplaceTextOnAllPages.java" >}}
### **Replace Text Using a Regular Expression**
The following code snippet shows how to replace text based on a regular expression.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Text-ReplaceTextInPagesOfPDFDocument-ReplaceTextUsingRegularExpression.java" >}}
### **Use Non-English (Japanese) Font When Replacing Text**
The following code snippet shows how to replace text with Japanese characters. Please note that to add Japanese text, you need to use a font which supports Japanese characters (for example MSGothic).

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-ReplaceTextInPagesOfPDFDocument-UseNonEnglishFontWhenReplacingText.java" >}}
### **Search text strings and remove the contents between them**
The feature to search text strings and remove the contents between them has become available since the release of Aspose.PDF for Java 4.2.1. Please try using the following code snippet to accomplish your requirement..

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-ReplaceTextInPagesOfPDFDocument-SearchTextStringsAndRemoveTheContentsBetweenThem.java" >}}

To search a text and replace it on a single page, specify the page index for the page you want:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Text-ReplaceTextInPagesOfPDFDocument-Info.java" >}}
## **Replace only first occurrence of the Phrase**
Replacing the first or particular occurrence of a phrase is quite much similar replacing all the occurrences of the text. The only difference is that in order to replace first or some other particular occurrence, you need to specify the index of that phrase. You first need to use **TextFragmentAbsorber** to find the particular phrase you want to replace. After that, you need to get particular **TextFragment** using index, replace the text and change any other attributes. If you want to replace first occurrence, you can specify index as 1. Once you have done that, you only need to save the output PDF using **save(..)** method of the [**Document**](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object.

The following code snippet shows you how to replace only first occurrence of the phrase on all pages of PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-ReplaceOnlyFirstOccurrenceOfThePhrase-.java" >}}

In case you need to replace the first occurrence of phrase on first/particular page of document, please specify the page index. Please try using the following code line.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Text-ReplaceOnlyFirstOccurrenceOfThePhrase-Info.java" >}}
## **Find and Replace Text by its Location**
To replace text in pages of a PDF document using [Aspose.PDF for Java](https://products.aspose.com/pdf/java) :

1. First use TextFragmentAbsorber to find the particular phrase to replace.
1. Go through all the TextFragments to replace the text and change any other attributes.
1. Save the output PDF using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's save method.
### **Find and Replace Text in PDF Document**
The following code snippet shows how to find and replace text based on its location. The code below finds the text **© Adobe Systems Incorp** which is placed in area (0,0,200,200). It replaces the character **o** in the word **Adobe** with **z** since it is in the range of (0, 0, 120, 200). It then prints the result to the console.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-FindAndReplaceTextByItsLocation-.java" >}}
## **Text Replacement should automatically re-arrange Page contents**
Aspose.PDF for Java supports the feature to search and replace text inside the PDF file. However recently some customers encountered issues during text replace when particular TextFragment is replaced with smaller contents and some extra spaces are displayed in resultant PDF or in case the TextFragment is replaced with some longer string, then words overlap existing page contents. So the requirement has been to introduce a mechanism that once the text inside a PDF document is replaced, the contents should be re-arranged.

In order to cater above stated scenarios, Aspose.PDF for Java has been enhanced so that no such issues appear when replacing text inside PDF file. The following code snippet shows how to replace text inside PDF file and the page contents should be re-arranged automatically.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-TextReplacementShouldAutomaticallyRearrangePageContents-.java" >}}


You also can specify the **ReplaceAdjustment.WholeWordsHyphenation** option to wrap text on the next or current line if the current line becomes too long or short after replacement:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Text-TextReplacementShouldAutomaticallyRearrangePageContents-Info.java" >}}
## **Replace fonts in existing PDF file**
Aspose.PDF for Java supports the capability to replace text in PDF document. However, sometimes you have a requirement to only replace the font being used inside PDF document. So instead of replacing the text, only font being used is replaced. One of the overloads of **TextFragmentAbsorber** constructor accepts **TextEditOptions** object as an argument and we can use **RemoveUnusedFonts** value from **TextEditOptions.FontReplace** enumeration to accomplish our requirements.
The following code snippet shows how to replace font inside PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-ReplaceFontsInExistingPDFFile-.java" >}}
