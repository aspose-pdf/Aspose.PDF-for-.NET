---
title: Apply Numbering Style in Heading
type: docs
weight: 10
url: /java/apply-numbering-style-in-heading/
---

{{% alert color="primary" %}} 

Headings are the important parts of any document. Writers always try to make headings more prominent and meaningful to its readers. If there are more than one headings in a document, a writer has several options to organize these headings. One of the most common approach to organize headings is to write headings in Numbering Style.

{{% /alert %}} 

Aspose.PDF for Java offers many pre-defined numbering styles. These pre-defined numbering styles are stored in an enumeration, NumberingStyle. The pre-defined values of NumberingStyle enumeration and their descriptions are given below:

|**Heading Types**|**Description**|
| :- | :- |
|NumeralsArabic|Arab type,for example, 1,1.1,...|
|NumeralsRomanUppercase|Roman upper type, for example, I,I.II, ...|
|NumeralsRomanLowercase|Roman lower type, for example, i,i.ii, ...|
|LettersUppercase|English upper type, for example, A,A.B, ...|
|LettersLowercase|English lower type, for example, a,a.b, ...|
The [setStyle](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/heading/methods/setStyle\(int\)/) property of [com.aspose.pdf.Heading](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Heading) class is used to set the numbering styles of the headings.

The following figure shows the effect of different numbering styles:

![todo:image_alt_text](http://www.aspose.com/docs/download/attachments/426672417/Apply+Numbering+Style-001.png?version=1&modificationDate=1447505105073)

|**Figure: Pre-defined numbering styles**|
| :- |
The source code, to obtain the output shown in the above figure, is given below in the example.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-headings-ApplyNumberingStyleInHeading-.java" >}}
