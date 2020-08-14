---
title: Add Text to a PDF file
type: docs
weight: 10
url: /net/add-text-to-a-pdf-file/
---

## **Add Text in an Existing PDF File**
To add text to an existing PDF file:

1. Open the input PDF using the Document object.
1. Get the particular page to which you want to add the text.
1. Create a TextFragment object with the input text along with other text properties. The **TextBuilder** object created from that particular page – to which you want to add the text – allows you to add the TextFragment object to the page using the AppendText method.
1. Call the Document object's Save method and save the output PDF file.
### **Adding Text**
The following code snippet shows you how to add text in an existing PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddText-AddText.cs" >}}
### **Loading Font from Stream**
The following code snippet shows how to load Font from Stream object when adding text to PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddText-LoadingFontFromStream.cs" >}}
### **Add Text using TextParagraph**
The following code snippet shows you how to add text in PDF document using **TextParagraph** class.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddText-AddTextUsingTextParagraph.cs" >}}
### **Add Hyperlink to TextSegment**
A PDF page may comprise of one or more TextFragment objects, where each TextFragment object can have one or more TextSegment instance. In order to set hyperlink for TextSegment, **Hyperlink** property of TextSegment class can be used while providing the object of **Aspose.Pdf.WebHyperlink** instance. Please try using the following code snippet to accomplish this requirement.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddText-AddHyperlinkToTextSegment.cs" >}}
### **Use OTF Font**
Aspose.PDF for .NET offers the feature to use Custom/TrueType fonts while creating/manipulating PDF file contents so that file contents are displayed using contents other than default system fonts. Starting release of [Aspose.PDF for .NET 10.3.0](https://downloads.aspose.com/pdf/net), we have provided the support for Open Type Fonts.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddText-OTFFont.cs" >}}
## **Add HTML String using DOM**
The Aspose.Pdf.Generator.Text class contains a property called IsHtmlTagSupported which makes it possible to add HTML tags/contents into PDF files. The added content is rendered in native HTML tags instead of appearing as a simple text string. To support a similar feature in the new Document Object Model (DOM) of the Aspose.Pdf namespace, the HtmlFragment class has been introduced.

The [HtmlFragment ](https://apireference.aspose.com/net/pdf/aspose.pdf/htmlfragment)instance can be used to specify the HTML contents which should be placed inside the PDF file. Similar to TextFragment, HtmlFragment is a paragraph level object and can be added to the Page object's paragraphs collection. The following code snippets show the steps to place HTML contents inside PDF file using the DOM approach.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddHTMLUsingDOM-AddHTMLUsingDOM.cs" >}}

Following code snippet demonstrate steps how to add HTML ordered lists into the document:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Text-AddHTMLOrderedListIntoDocuments-AddHTMLOrderedListIntoDocuments.cs" >}}

You can also set HTML string formatting using TextState object as following:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Text-SetHTMLStringFormatting-SetHTMLStringFormatting.cs" >}}

In case if you set some text attributes values via HTML markup and then provide the same values in TextState properties they will overwrite HTML parameters by properties form TextState instance. The following code snippets show described behavior.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Text-AddHTMLUsingDOMAndOverwrite-AddHTMLUsingDOMAndOverwrite.cs" >}}
## **FootNotes and EndNotes (DOM)**
FootNotes indicate notes in the text of your paper by using consecutive superscript numbers. The actual note is indented and can occur as a footnote at the bottom of the page.
### **Adding FootNote**
In a footnote referencing system, indicate a reference by:

- putting a small number above the line of type directly following the source material. This number is called a note identifier. It sits slightly above the line of text.
- putting the same number, followed by a citation of your source, at the bottom of the page. Footnoting should be numerical and chronological: the first reference is 1, the second is 2, and so on. The advantage of footnoting is that the reader can simply cast their eyes down the page to discover the source of a reference that interests them.

Please follow the steps specified below to create a FootNote:

- Create a Document instance
- Create a Page object
- Create a TextFragment object
- Create a Note instance and pass it's value to TextFragment.FootNote property
- Add TextFragment to paragraphs collection of a page instance
### **Custom line style for FootNote**
The following example demonstrates how to add Footnotes to the bottom of the Pdf page and define a custom line style.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-FootAndEndNotes-CustomLineStyleForFootNote.cs" >}}

{{% alert color="primary" %}}

We can set Footnote Label (note identifier) formatting using TextState object as following:

{{< highlight cpp >}}

 TextFragment text = new TextFragment("test text 1");

text.FootNote = new Note("foot note for test text 1");

text.FootNote.Text = "21";

text.FootNote.TextState = new TextState();

text.FootNote.TextState.ForegroundColor = Aspose.Pdf.Color.Blue;

text.FootNote.TextState.FontStyle = FontStyles.Italic;

{{< /highlight >}}

{{% /alert %}}
### **Customize Footnote label**
By default, the FootNote number is incremental starting from 1. However, we may have a requirement to set a custom FootNote label. In order to accomplish this requirement, please try using the following code snippet

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-FootAndEndNotes-CustomizeFootNoteLabel.cs" >}}
### **Adding Image and Table to Footnote**
In earlier release versions, the Footnote support was provided but it was only applicable to TextFragment object. However starting release Aspose.PDF for .NET 10.7.0, you can also add Footnote to other objects inside PDF document such as Table, Cells etc. The following code snippet shows the steps to add Footnote to TextFragment object and then add Image and Table object to paragraphs collection of Footnote section.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-FootAndEndNotes-AddImageAndTable.cs" >}}
### **How to Create EndNotes**
An EndNote is a source citation that refers the readers to a specific place at the end of the paper where they can find out the source of the information or words quoted or mentioned in the paper. When using endnotes, your quoted or paraphrased sentence or summarized material is followed by a superscript number.

The following example demonstrates how to add an Endnote in the Pdf page.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-FootAndEndNotes-CreateEndNotes.cs" >}}
## **Text and Image as InLine Paragraph**
The default layout of the PDF file is flow layout (Top-Left to Bottom-Right). Therefore every new element being added to PDF file is added in the bottom right flow. However, we may have a requirement to display various page elements i.e. Image and Text at the same level (one after another). One approach can be to create a Table instance and add both elements to individual cell objects. However, another approach can be InLine paragraph. By setting **IsInLineParagraph** property of Image and Text as true, these paragraphs will appear as inline to other page elements.

The following code snippet shows you how to add text and Image as InLine paragraphs in PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-TextAndImageAsParagraph-TextAndImageAsParagraph.cs" >}}
## **Specify character Spacing when adding Text**
A text can be added inside paragraphs collection of PDF files using **TextFragment** instance or by using **TextParagraph** object and even you can stamp the text inside PDF by using **TextStamp** class. While adding the text, we may have a requirement to specify character spacing for the text objects. In order to accomplish this requirement, a new property named **CharacterSpacing** property has been introduced. Please take a look at the following approaches to fulfill this requirement.

The following approaches show the steps to specify character spacing when adding text inside a PDF document.
### **Using TextBuilder and TextFragment**
{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-SpecifyCharacterSpacing-UsingTextBuilderAndFragment.cs" >}}
### **Using TextParagraph and TextParagraph**
{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-SpecifyCharacterSpacing-UsingTextBuilderAndParagraph.cs" >}}
### **Using TextStamp**
{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-SpecifyCharacterSpacing-UsingTextStamp.cs" >}}
## **Create Multi-Column PDF document**
In magazines and newspapers, we mostly see that news are displayed in multiple columns on the single pages instead of the books where text paragraphs are mostly printed on the whole pages from left to right position. Many document processing applications like Microsoft Word and Adobe Acrobat Writer allow users to create multiple columns on a single page and then add data to them.

[Aspose.PDF for .NET](/pdf/net/) also offers the feature to create multiple columns inside the pages of PDF documents. In order to create multi-column PDF file, we can make use of Aspose.Pdf.FloatingBox class as it provides ColumnInfo.ColumnCount property to specify the number of columns inside FloatingBox and we can also specify the spacing between columns and columns widths using ColumnInfo.ColumnSpacing and ColumnInfo.ColumnWidths properties accordingly. Please note that FloatingBox is an element inside Document Object Model and it can have obsolete positioning as compared to relative positioning (i.e. Text, Graph, Image, etc).

Column spacing means the space between the columns and the default spacing between the columns is 1.25cm. If the column width is not specified, then [Aspose.PDF for .NET](/pdf/net/) calculates width for each column automatically according to the page size and column spacing.

An example is given below to demonstrate the creation of two columns with Graphs objects (Line) and they are added to paragraphs collection of FloatingBox, which is then added paragraphs collection of Page instance.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-CreateMultiColumnPdf-CreateMultiColumnPdf.cs" >}}
## **Working with custom Tab Stops**
A Tab Stop is a stop point for tabbing. In word processing, each line contains a number of tab stops placed at regular intervals (for example, every half inch). They can be changed, however, as most word processors allow you to set tab stops wherever you want. When you press the Tab key, the cursor or insertion point jumps to the next tab stop, which itself is invisible. Although tab stops do not exist in the text file, the word processor keeps track of them so that it can react correctly to the Tab key.

[Aspose.PDF for .NET](/pdf/net/) allows developers to use custom tab stops in PDF documents. The [Aspose.Pdf.Text.TabStop](https://apireference.aspose.com/pdf/net/aspose.pdf.text/tabstop) class is used to set custom TAB stops in the [TextFragment](https://apireference.aspose.com/net/pdf/aspose.pdf.text/textfragment) class.

[Aspose.PDF for .NET](/pdf/net/) also offers some pre-defined tab leader types as an enumeration named, [TabLeaderType](https://apireference.aspose.com/pdf/net/aspose.pdf.text/tableadertype) whose pre-defined values and their descriptions are given below:

|**Tab Leader Type**|**Description**|
| :- | :- |
|None|No tab leader|
|Solid|Solid tab leader|
|Dash|Dash tab leader|
|Dot|Dot tab leader|

Here is an example of how to set custom TAB stops.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-CustomTabStops-CustomTabStops.cs" >}}
## **How to Add Transparent Text in PDF**
A PDF file contains Image, Text, Graph, attachment, Annotations objects and while creating TextFragment, you can set foreground, background-color information as well as text formatting. Aspose.PDF for .NET supports the feature to add text with Alpha color channel. The following code snippet shows how to add text with transparent color.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddTransparentText-AddTransparentText.cs" >}}
## **Specify LineSpacing for Fonts**
Every font has an abstract square, whose height is the intended distance between lines of type in the same type size. This square is called the em square and it is the design grid on which the glyph outlines are defined. Many letters of input font have points that are placed out of font's em square bounds, so in order to display the font correctly, usage of special setting is needed. The object TextFragment has a set of text formatting options which are accessible via properties TextState.FormattingOptions. Last property of this path is property of type [Aspose.Pdf.Text.TextFormattingOptions](https://apireference.aspose.com/net/pdf/aspose.pdf.text/textformattingoptions/). This class has a an enumeration [LineSpacingMode ](https://apireference.aspose.com/net/pdf/aspose.pdf.text.textformattingoptions/linespacingmode/)which is designed for specific fonts e.g input font "HPSimplified.ttf". Also class Aspose.Pdf.Text.TextFormattingOptions has a property [LineSpacing ](https://apireference.aspose.com/net/pdf/aspose.pdf.text/textformattingoptions/properties/linespacing)of type LineSpacingMode. You just need to set LineSpacing into LineSpacingMode.FullSize. The code snippet to get a font displayed correctly, would be like as follows:



{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-SpecifyLineSpacing-1.cs" >}}
## **Get Text Width Dynamically**
Sometimes, it is required to get the text width dynamically. Aspose.PDF for .NET includes two methods for string width measurement. You can invoke the **MeasureString()** method of Aspose.Pdf.Text.Font or Aspose.Pdf.Text.TextState classes (or both). The code snippet below shows how to use this functionality.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Text-GetWidthOfTextDynamically-GetWidthOfTextDynamically.cs" >}}
