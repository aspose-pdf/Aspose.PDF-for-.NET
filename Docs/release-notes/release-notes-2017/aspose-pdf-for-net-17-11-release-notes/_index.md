---
title: Aspose.PDF for .NET 17.11 Release Notes
type: docs
weight: 20
url: /net/aspose-pdf-for-net-17-11-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-42750|Add Tooltip to Text inside PDF file|New Feature|
|PDFNET-38709|VerticalAlignment for FloatingBox contents|New Feature|
|PDFNET-38580|VerticalAlignmentType support Row object|New Feature|
|PDFNET-43056|Add feature to hide the page numbers in table of contents tree|New Feature|
|PDFNET-41118|Searchable PDF issue|Enhancement|
|PDFNET-43366|NullReferenceException occurred on getting form fields|Exception|
|PDFNET-43414|When add an image from embedded resource in WPF, <br>then on Save document, GDI+ exception occurs|Exception|
|PDFNET-43486|Null pointer exception occurs when calling flatten|Exception|
|PDFNET-35792|Storing PDF document into stream is too slow in batch operation|Bug|
|PDFNET-35851|Text Segments from Textfragment Absorbed not in Correct Position|Bug|
|PDFNET-37346|PDF to PNG: text spacing is issue in resultant image|Bug|
|PDFNET-38237|PDF to TIFF - Conversion is taking too much time|Bug|
|PDFNET-38691|PDF to TIFF - Character spacing issue in resultant file |Bug|
|PDFNET-38886|Extracted Signature Images are in Black and White |Bug|
|PDFNET-39562|PDF to PNG: incorrect rendering of text |Bug|
|PDFNET-39671|PDF to PDF/A - huge memory consumption during conversion|Bug|
|PDFNET-40734|PDF to TIFF - Text is garbled in resultant file|Bug|
|PDFNET-40853|Some text from string array is not redacting|Bug|
|PDFNET-41659|Replacing Text Causes Text to Go Offscreen|Bug|
|PDFNET-41810|PDF to PDF/A_1b - Text is garbled in resultant file|Bug|
|PDFNET-42482|Incorrect positioning of characters when saving PDF as HTML|Bug|
|PDFNET-42770|Incorect TextStamp rendering|Bug|
|PDFNET-42785|When PDF converted to PDF_A_1B, a blue color on image is different|Bug|
|PDFNET-42897|PDF to DOCX - Content is missing in the resultant file|Bug|
|PDFNET-42971|Incorrect character position when saving as HTML|Bug|
|PDFNET-43107|Images are not showing when HTML is added through HtmlFragment|Bug|
|PDFNET-43216|PDF to TIFF - API is taking more time than expected|Bug|
|PDFNET-43256|All spaces are removed from the text and all lines ends with "ti"|Bug|
|PDFNET-43620|The accented text has been clipped if placed in the first line of TextFragment text|Bug|
|PDFNET-43340|Not possible to create radio buttons|Bug|
|PDFNET-43419|When adding a footnote to the table cell, it appears two times|Bug|
|PDFNET-43459|Text is missing when saving PDF as HTML|Bug|
|PDFNET-43511|Text Justification as FullJustify is not working in FloatingBox|Bug|
### **Public API changes in Aspose.PDF for .NET 17.11**
### **Added APIs:**
-----
Method Aspose.PDF.Annotations.Annotation.ToImage(System.Drawing.Imaging.ImageFormat)
Class Aspose.PDF.Annotations.HideAction
Constructor Aspose.PDF.Annotations.HideAction(Aspose.PDF.Annotations.Annotation)
Constructor Aspose.PDF.Annotations.HideAction(Aspose.PDF.Annotations.Annotation,System.Boolean)
Constructor Aspose.PDF.Annotations.HideAction(System.String)
Constructor Aspose.PDF.Annotations.HideAction(System.String,System.Boolean)
Constructor Aspose.PDF.Annotations.HideAction(Aspose.PDF.Annotations.Annotation[])
Constructor Aspose.PDF.Annotations.HideAction(Aspose.PDF.Annotations.Annotation[],System.Boolean)
Constructor Aspose.PDF.Annotations.HideAction(System.String[])
Constructor Aspose.PDF.Annotations.HideAction(System.String[],System.Boolean)
Property Aspose.PDF.Annotations.HideAction.IsHidden
Property Aspose.PDF.BaseParagraph.VerticalAlignment
Method Aspose.PDF.Forms.SignatureField.ExtractImage(System.Drawing.Imaging.ImageFormat)
Constructor Aspose.PDF.Text.TextFormattingOptions
Enumeration member Aspose.PDF.Text.TextFormattingOptions.WordWrapMode.Undefined
Property Aspose.PDF.Text.TextFragment.VerticalAlignment
Property Aspose.PDF.TocInfo.IsShowPageNumbers
