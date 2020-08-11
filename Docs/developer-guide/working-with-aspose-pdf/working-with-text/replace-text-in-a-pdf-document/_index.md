---
title: Replace Text in a PDF Document
type: docs
weight: 60
url: /net/replace-text-in-a-pdf-document/
---

## **Replace Text in all pages of PDF document**


{{% alert color="primary" %}} 

You can try to find in replace the text in the document using Aspose.PDF and get the results online at this link:

[products.aspose.app/pdf/redaction](https://products.aspose.app/pdf/redaction) {{% /alert %}} 

In order to replace text in all the pages of a PDF document, you first need to use **TextFragmentAbsorber** to find the particular phrase you want to replace. After that, you need to go through all the **TextFragments** to replace the text and change any other attributes. Once you have done that, you only need to save the output PDF using the **Save** method of the **Document** object. 
The following code snippet shows you how to replace text in all pages of PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-ReplaceTextAll-ReplaceTextAll.cs" >}}
## **Replace Text in particular page region**
In order to replace text in a particular page region, first, we need to instantiate **TextFragmentAbsorber** object, specify page region using **TextSearchOptions.Rectangle** property and then iterate through all the **TextFragments** to replace the text. Once these operations are completed, we only need to save the output PDF using the **Save** method of the **Document** object. 
The following code snippet shows you how to replace text in all pages of PDF document.

{{< highlight java >}}

 // load PDF file

Aspose.PDF.Document pdf  = new Aspose.PDF.Document("c:/pdftest/programaticallyproducedpdf.pdf");

// instantiate TextFragment Absorber object

Aspose.PDF.Text.TextFragmentAbsorber TextFragmentAbsorberAddress = new Aspose.PDF.Text.TextFragmentAbsorber();

// search text within page bound

TextFragmentAbsorberAddress.TextSearchOptions.LimitToPageBounds = true;

// specify the page region for TextSearch Options

TextFragmentAbsorberAddress.TextSearchOptions.Rectangle = new Aspose.PDF.Rectangle(100, 100, 200, 200);

// search text from first page of PDF file

pdf.Pages[1].Accept(TextFragmentAbsorberAddress);

// iterate through individual TextFragment

foreach( Aspose.PDF.Text.TextFragment tf in TextFragmentAbsorberAddress.TextFragments)

{

    // update text to blank characters

    tf.Text = "";

}

    // save updated PDF file after text replace

pdf.Save("c:/pdftest/TextUpdated.pdf");

{{< /highlight >}}
## **Replace Text Based on a Regular Expression**
If you want to replace some phrases based on regular expression, you first need to find all the phrases matching that particular regular expression using **TextFragmentAbsorber**. You will have to pass the regular expression as a parameter to the **TextFragmentAbsorber** constructor. You also need to create **TextSearchOptions** object which specifies whether the regular expression is being used or not. Once you get the matching phrases in **TextFragments**, you need to loop through all of them and update as required. Finally, you need to save the updated PDF using the **Save** method of the **Document** object. The following code snippet shows you how to replace text based on a regular expression.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-ReplaceTextonRegularExpression-ReplaceTextonRegularExpression.cs" >}}
## **Replace Only First Occurrence of the Phrase**
Replacing the first or particular occurrence of a phrase is quite much similar replacing all the occurrences of the text. The only difference is that in order to replace first or some other particular occurrence, you need to specify the index of that phrase. You first need to use **TextFragmentAbsorber** to find the particular phrase you want to replace. After that, you need to get particular **TextFragment** using the index, replace the text and change any other attributes. If you want to replace first occurrence , you can specify index as 1. Once you have done that, you only need to save the output PDF using the **Save** method of the **Document** object. The following code snippet shows you how to replace only the first occurrence of the phrase.
## **Replace fonts in existing PDF file**
Aspose.PDF for .NET supports the capability to replace text in PDF document. However, sometimes you have a requirement to only replace the font being used inside PDF document. So instead of replacing the text, only font being used is replaced. One of the overloads of **TextFragmentAbsorber** constructor accepts **TextEditOptions** object as an argument and we can use **RemoveUnusedFonts** value from **TextEditOptions.FontReplace** enumeration to accomplish our requirements. The following code snippet shows how to replace the font inside PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-ReplaceFonts-ReplaceFonts.cs" >}}
## **Text Replacement should automatically re-arrange Page Contents**
Aspose.PDF for .NET supports the feature to search and replace text inside the PDF file. However recently some customers encountered issues during text replace when particular TextFragment is replaced with smaller contents and some extra spaces are displayed in resultant PDF or in case the TextFragment is replaced with some longer string, then words overlap existing page contents. So the requirement was to introduce a mechanism that once the text inside a PDF document is replaced, the contents should be re-arranged.

In order to cater above-stated scenarios, Aspose.PDF for .NET has been enhanced so that no such issues appear when replacing text inside PDF file. The following code snippet shows how to replace text inside PDF file and the page contents should be re-arranged automatically.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-RearrangeContentsUsingTextReplacement-RearrangeContentsUsingTextReplacement.cs" >}}
## **Rendering Replaceable Symbols during PDF creation**
Replaceable symbols are special symbols in a text string that can be replaced with corresponding content at run time. Replaceable symbols currently support by new Document Object Model of Aspose.PDF namespace are **$P**, **$p**, **\n**, **\r**. The **$p** and **$P** are used to deal with the page numbering at run time. $p is replaced with the number of the page where the current Paragraph class is in. $P is replaced with the total number of pages in the document.
When adding TextFragment to the paragraphs collection of PDF documents, it does not support line feed inside the text. However in order to add text with a line feed, please use TextFragment with TextParagraph:

- use "\r\n" or Environment.NewLine in TextFragment instead of single "\n";
- create a TextParagraph object. It will add text with line splitting;
- add the TextFragment with TextParagraph.AppendLine;
- add the TextParagraph with TextBuilder.AppendParagraph.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-RenderingReplaceableSymbols-RenderingReplaceableSymbols.cs" >}}
### **Replaceable symbols in Header/Footer area**
Replaceable symbols can also be placed inside the Header/Footer section of PDF file. Please take a look over the following code snippet for details on how to add replaceable symbol in the footer section.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-ReplaceableSymbolsInHeaderFooter-ReplaceableSymbolsInHeaderFooter.cs" >}}
## **Remove Unused Fonts from PDF File**
Aspose.PDF for .NET supports the feature to embed fonts while creating a PDF document, as well as the capability to embed fonts in existing PDF files. From Aspose.PDF for .NET 7.3.0, it also lets you remove duplicate or unused fonts from PDF documents.

To replace fonts, use the following approach:

1. Call the [TextFragmentAbsorber](https://apireference.aspose.com/net/pdf/aspose.pdf.text/textfragmentabsorber) class.
1. Call the TextFragmentAbsorber class' TextEditOptions.FontReplace.RemoveUnusedFonts parameter. (This removes fonts that have become unused during font replacement).
1. Set font individually for each text fragment.

The following code snippet replaces font for all text fragments of all document pages and removes unused fonts.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-RemoveUnusedFonts-RemoveUnusedFonts.cs" >}}
## **Remove All Text from PDF Document**
### **Remove All Text using Operators**
In some text operation, you need to remove all text from PDF document and for that, you need to set found text as empty string value usually. The point is that changing the text for multitude text fragments invokes a number of checking and text position adjustment operations. They are essential in the text editing scenarios. The difficulty is that you cannot determine how many text fragments will be removed in the scenario where they are processed in a loop.

Therefore, we recommend using another approach for the scenario of removing **all** text from PDF pages. Please consider the following code snippet that works very fast.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-RemoveAllText-1.cs" >}}
### **Remove All Text using TextFragmentAbsober**
From Aspose.PDF for .NET 18.7 version, TextFragmentAbsorber.RemoveAllText() method has been implemented. You can remove text from a particular page as well as from the whole PDF document using this method. In specific scenarios where text removal from PDF is the main requirement, this new function works quite efficiently and fast. Following code snippet shows how to remove text from a PDF document using this method: 

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-RemoveAllTextFromPDF-1.cs" >}}

