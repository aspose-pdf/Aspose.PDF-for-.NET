---
title: Convert PDF to DOC and DOCX
type: docs
weight: 70
url: /java/convert-pdf-to-doc-and-docx/
---

Aspose.PDF for Java can create PDF documents from scratch and is a great toolkit for updating, editing and manipulating existing PDF documents. An important feature is the ability to convert pages and entire PDF documents to images. Another popular feature is PDF to Microsoft Word DOC conversion, which makes the content easy to manipulate. (Most users can't edit PDF documents but can easily work with tables, text, and images in Microsoft Word.)
## **Saving to DOC**
To make things simple and understandable, Aspose.PDF for Java provides a two-line code for transforming a source PDF file into a DOC file. To accomplish this, use SaveFormat and the value .doc which enables you to save the source file to Microsoft Word format.

The following code snippet shows the process of converting a PDF file into DOC format.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertPDFToDOCOrDOCXFormat-SavingToDoc.java" >}}
## **Saving to DOCX**
The DocFormat enumeration also provides the option to choose DOCX as the output format for Word documents. To render the source PDF file to DOCX format, use the code snippet specified below. 

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertPDFToDOCOrDOCXFormat-SavingToDOCX.java" >}}
## **Using the DocSaveOptions Class**
The DocSaveOptions class provides numerous properties that improve the process of converting PDF files to DOC format. Among these properties, Mode enables you to specify the recognition mode for PDF content. You can specify any value from the RecognitionMode enumeration for this property. Each of these values has specific benefits and limitations:

- Textbox mode is fast and good for preserving a PDF file's original look, but the editability of the resulting document could be limited. Every visually grouped block of text in the original PDF is converted into a textbox in the output document. This achieves a maximal resemblance to the original so the output document looks good, but it consists entirely of textboxes and it could make editing in Microsoft Word hard.
- Flow is full recognition mode, where the engine performs grouping and multi-level analysis to restore the original document as per the author's intent while producing an easily editable document. The limitation is that the output document might look different from the original.
- The RelativeHorizontalProximity property can be used to control the relative proximity between textual elements and means that distance is normed by the font size. Larger fonts may have bigger distances between syllables and still be considered a single whole. It is specified as a percentage of the font size, for example, 1 = 100%. This means that two characters of 12pt that are placed 12 pt apart are proximal.
- RecognitionBullets is used to switch on bullet recognition during conversion.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertPDFToDOCOrDOCXFormat-UsingTheDocSaveOptionsClass.java" >}}
