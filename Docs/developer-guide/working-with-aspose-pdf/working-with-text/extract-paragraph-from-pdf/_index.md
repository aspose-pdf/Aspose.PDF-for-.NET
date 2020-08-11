---
title: Extract Paragraph from PDF
type: docs
weight: 50
url: /net/extract-paragraph-from-pdf/
---

## **Extract Text from PDF document in Paragraphs form**
We can get text from a PDF document by searching a particular text (using "plain text" or "regular expressions") from a single page or whole document, or we can get the complete text of a single page, range of pages or complete document. However, in some cases, you require to extract paragraphs from a PDF document or text in the form of Paragraphs. We have implemented functionality for searching sections and paragraphs in the text of PDF document pages. We have introduced ParagraphAbsorber Class (like TextFragmentAbsorber and TextAbsorber), which can be used to extract paragraphs from PDF documents. There are two following ways in which you can use ParagraphAbsorber:

**1- By drawing the border of sections and paragraphs of text on PDF page:**



{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-ExtractParagraphsByDrawingBorder-1.cs" >}}

**2- By iterating through paragraphs collection and get the text of them:**



{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-ExtractParagraphs-1.cs" >}}

