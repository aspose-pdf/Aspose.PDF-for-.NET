---
title: Add Text to a PDF file
type: docs
weight: 10
url: /java/add-text-to-a-pdf-file/
---

## **Add Text to an existing PDF file**
To add text to an existing PDF file:

1. Open the input PDF using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object.
1. Get the particular page to which you want to add the text.
1. Create a TextFragment object with the input text along with other text properties. The TextBuilder object created from that particular page – to which you want to add the text – allow you to add the TextFragment object to the page using the appendText method.
1. Call the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's save method and save the output PDF file.

The following code snippet shows you how to add text in an existing PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Text-AddTextToAnExistingPDFFile-.java" >}}
## **How to add transparent Text in PDF**
A PDF file contains Image, Text, Graph, attachment, Annotations objects and while creating TextFragment, you can set foreground, background color information as well as text formatting. Aspose.PDF for Java supports the feature to add text with Alpha color channel.

The following code snippet shows how to add text with transparent color.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-HowToAddTransparentTextInPDF-.java" >}}
## **Add HTML String using DOM**
The aspose.pdf.generator.text class contains a property called IsHtmlTagSupported which makes it possible to add HTML tags/contents into PDF files. The added content is rendered in native HTML tags instead of appearing as a simple text string. To support a similar feature in the new Document Object Model (DOM) of the Aspose.Pdf namespace, the HtmlFragment class has been introduced.

The [HtmlFragment ](https://apireference.aspose.com/java/pdf/com.aspose.pdf/htmlfragment)instance can be used to specify the HTML contents which should be placed inside the PDF file. Similar to TextFragment, HtmlFragment is a paragraph level object and can be added to the Page object's paragraphs collection. The following code snippets shows the steps to place HTML contents inside PDF file using DOM approach.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-AddHTMLStringUsingDOM-.java" >}}

Following code snippet demonstrate steps how to add HTML ordered lists into document:

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-Text-AddHTMLOrderedListIntoDocuments-AddHTMLOrderedListIntoDocuments.java" >}}

You can also set HTML string formatting using setTextState() method as following:

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-Text-SetHTMLStringFormatting-SetHTMLStringFormatting.java" >}}

In case if you set some text attributes values via html markup and then provide the same values in setTextState() properties they will overwrite html parameters by properties form setTextState() instance. The following code snippets shows described behavior.

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-Text-AddHTMLUsingDOMAndOverwrite-AddHTMLUsingDOMAndOverwrite.java" >}}
## **FootNotes and EndNotes (DOM)**
FootNotes indicate notes in the text of your paper by using consecutive superscript numbers. The actual note is indented and can occur as a footnote at the bottom of the page.

In a footnote referencing system, indicate a reference by:

- putting a small number above the line of type directly following the source material. This number is called a note identifier. It sits slightly above the line of text.
- putting the same number, followed by a citation of your source, at the bottom of the page. Footnoting should be numerical and chronological: the first reference is 1, the second is 2, and so on. The advantage of footnoting is that the reader can simply cast their eyes down the page to discover the source of a reference which interests them.

Please follow the steps specified below to create a FootNote:

- Create a Document instance
- Create a Page object
- Create a TextFragment object
- Create a Note instance and pass it's value to TextFragment.FootNote property
- Add TextFragment to paragraphs collection of page instance
### **Custom line style for FootNote**
The following example demonstrates how to add Footnotes to the bottom of the PDF page and define custom line style.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-FootNotesAndEndNotes-CustomLineStyleForFootNote.java" >}}
### **Customize FootNote label**
By default, the FootNote number is incremental starting from 1. However we may have a requirement to set custom FootNote label. In order to accomplish this requirement, please try using following code snippet

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-FootNotesAndEndNotes-CustomizeFootnoteLabel.java" >}}
### **How to Create EndNotes**
An EndNote is source citation that refers the readers to a specific place at the end of the paper where they can find out the source of the information or words quoted or mentioned in the paper.

When using Endnotes, your quoted or paraphrased sentence or summarized material is followed by a superscript number.

The following example demonstrates how to add an Endnote in PDF page.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-FootNotesAndEndNotes-HowToCreateEndNotes.java" >}}
## **Add Rotated Text inside PDF Document**
Aspose.PDF for Java provides **setRotation()** method in **TextState** Class, which helps specifying different rotation angles of text inside PDF document. In various scenarios, text rotation can be an important requirement and in order to implement this functionality, please check following code snippet:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-pdf-Text-AddRotatedTextInPDF-1.java" >}}
