---
title: Working with Headings
type: docs
weight: 130
url: /net/working-with-headings/
---

## **Apply Numbering Style in Heading**
Headings are the important parts of any document. Writers always try to make headings more prominent and meaningful to its readers. If there are more than one headings in a document, a writer has several options to organize these headings. One of the most common approach to organize headings is to write headings in Numbering Style.

[Aspose.PDF for .NET](/pdf/net/) offers many pre-defined numbering styles. These pre-defined numbering styles are stored in an enumeration, NumberingStyle. The pre-defined values of NumberingStyle enumeration and their descriptions are given below:

|**Heading Types**|**Description**|
| :- | :- |
|NumeralsArabic|Arab type,for example, 1,1.1,...|
|NumeralsRomanUppercase|Roman upper type, for example, I,I.II, ...|
|NumeralsRomanLowercase|Roman lower type, for example, i,i.ii, ...|
|LettersUppercase|English upper type, for example, A,A.B, ...|
|LettersLowercase|English lower type, for example, a,a.b, ...|
The **Style** property of **Aspose.PDF.Heading** class is used to set the numbering styles of the headings.

The following figure shows the effect of different numbering styles:

![todo:image_alt_text](http://www.aspose.com/docs/download/attachments/426672417/Apply+Numbering+Style-001.png?version=1&modificationDate=1447505105073)

|**Figure: Pre-defined numbering styles**|
| :- |
The source code, to obtain the output shown in the above figure, is given below in the example.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Headings-ApplyNumberStyle-ApplyNumberStyle.cs" >}}
