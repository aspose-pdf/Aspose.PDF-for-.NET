---
title: Aspose.PDF for .NET 18.6 Release Notes
type: docs
weight: 70
url: /net/aspose-pdf-for-net-18-6-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 18.6](https://www.nuget.org/packages/Aspose.Pdf/18.6.0)

{{% /alert %}} 

We have honored to announce June Release of Aspose.PDF for .NET. Bug fixes and new features has been listed in the below table of Improvements and Changes. However, we have also introduced new features as part of work on 508 compliance (WCAG):

- PDF/UA validation feature was added.
- Tagged PDF support was added.

Above listed features are under further development and currently they are available in Aspose.PDF for .NET 18.6, as beta version.
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-44773|Add feature "Extract Highlighted Text from HighlightTextMarkUpAnnotations" to the TextFragmentAbsorber class|New Feature|
|PDFNET-42862|Add support of OTF font when embedding in PDF|New Feature|
|PDFNET-38828|Text Extraction - Spaces are improperly embedded inside words|Bug|
|PDFNET-39178|TableAbsorber throws exception while trying to access any row other than first row of first table or any other table than first|Bug|
|PDFNET-39432|PDF to Image - Some contents are overlapping|Bug|
|PDFNET-40080|PDF to JPEG - Incorrect output|Bug|
|PDFNET-41666|TableAbsorber: incorrect table count in PDF|Bug|
|PDFNET-42492|Text is overlapped when saving particular document as image or HTML|Bug|
|PDFNET-43190|PDF to HTML - Object reference not set to an instance of an object|Bug|
|PDFNET-43259|Conversion HTML to PDF produces incorrect output |Bug|
|PDFNET-43353|PDF to PDFA - Comments are broken in resultant document|Bug|
|PDFNET-43417|Flattening Fields is not flattening the Print button inside PDF|Bug|
|PDFNET-43677|The output is too big after conversion to PDFA_1B format|Bug|
|PDFNET-44078|After conversion PDF-to-PDFA the output contains corrupted diagram|Bug|
|PDFNET-44102|The document loaded from HMTL file looks different then original|Bug|
|PDFNET-44163|PDF to PDF/A-1b - the output PDF does not pass compliance test |Bug|
|PDFNET-44164|PDF to PDF/A-1b - the output PDF does not pass compliance test|Bug|
|PDFNET-44172|PDF to JPG - Blue gradient is darker in the JPG compared to the PPT slide PDF|Bug|
|PDFNET-44173|PDF to JPG - Objects fading to transparent|Bug|
|PDFNET-44174|PDF to JPG - transparent turns to white|Bug|
|PDFNET-44175|PDF to JPG - Objects fading to transparent causes image differences|Bug|
|PDFNET-44176|PDF to JPG - Objects fading to transparent causes image differences|Bug|
|PDFNET-44195|Yellow background not same after converting PDF to PDF/A |Bug|
|PDFNET-44201|JPEG output loses the fade effect on the source document|Bug|
|PDFNET-44202|The document image loses fading to transparent in PDF output|Bug|
|PDFNET-44235|Blank pages added after HTML to PDF rendition|Bug|
|PDFNET-44238|PDF to PDF/A-2b - the chart labels are rotated|Bug|
|PDFNET-44239|PDF to PDF/A-2b - some labels get blurred|Bug|
|PDFNET-44377|Duplicated evaluation watermarks when saving EPUB document|Bug|
|PDFNET-44432|Output image or html is filled with black color |Bug|
|PDFNET-44597|HTML to PDF - exception thrown|Bug|
|PDFNET-44601|Flattening Fields is not flattening the buttons inside PDF|Bug|
|PDFNET-44631|Multi byte characters not displayed in PDF|Bug|
|PDFNET-44670|Header added but footer is missing (HTML->PDF) |Bug|
|PDFNET-44672|The header and the footer exist only on the first page. |Bug|
|PDFNET-44703|Missing table after adding to Footer|Bug|
|PDFNET-44671|PDF to PDF/A-2b|Bug|
|PDFNET-41112|Unable to load OTF Font from a resource stream|Bug|
### **Public API changes in Aspose.PDF for .NET 18.6**
All descendants of Aspose.Pdf.Operator were moved into namespace Aspose.Pdf.Operators. Thus 'new Aspose.Pdf.Operators.GSave()' should be used, instead of 'new Aspose.Pdf.Operator.GSave()'.
### **Added APIs:**
-----
Property Aspose.Pdf.Document.IsPdfUaCompliant
Property Aspose.Pdf.Document.IsPdfTaggedMarked
Property Aspose.Pdf.Document.TaggedPdfContent
Method Aspose.Pdf.Document.RemovePdfUaCompliance
Method Aspose.Pdf.Annotations.TextMarkupAnnotation.GetMarkedText
Method Aspose.Pdf.Annotations.TextMarkupAnnotation.GetMarkedTextFragments
Property Aspose.Pdf.Page.TaggedPdfContent
Enumeration member Aspose.Pdf.PdfFormat.PDF_UA_1
Property Aspose.Pdf.Forms.Form.FlattenSettings.HideButton
Class Aspose.Pdf.TaggedPdf.TaggedPdfChildElements 
Method Aspose.Pdf.TaggedPdf.TaggedPdfChildElements.Add(Aspose.Pdf.TaggedPdf.TaggedPdfElement) 
Class Aspose.Pdf.TaggedPdf.TaggedPdfContent 
Method Aspose.Pdf.TaggedPdf.TaggedPdfContent.Add(Aspose.Pdf.TaggedPdf.TaggedPdfTextElement) 
Class Aspose.Pdf.TaggedPdf.TaggedPdfDocumentElement 
Method Aspose.Pdf.TaggedPdf.TaggedPdfDocumentElement.Add(Aspose.Pdf.Page,Aspose.Pdf.TaggedPdf.TaggedPdfTextElement) 
Class Aspose.Pdf.TaggedPdf.TaggedPdfElement 
Property Aspose.Pdf.TaggedPdf.TaggedPdfElement.Page 
Property Aspose.Pdf.TaggedPdf.TaggedPdfElement.Parent 
Property Aspose.Pdf.TaggedPdf.TaggedPdfElement.ChildElements 
Method Aspose.Pdf.TaggedPdf.TaggedPdfElement.Add(Aspose.Pdf.Page,Aspose.Pdf.TaggedPdf.TaggedPdfElement) 
Class Aspose.Pdf.TaggedPdf.TaggedPdfTextElement 
Method Aspose.Pdf.TaggedPdf.TaggedPdfTextElement.#ctor(Aspose.Pdf.Document,System.String,System.String) 
Property Aspose.Pdf.TaggedPdf.TaggedPdfTextElement.Page 
Property Aspose.Pdf.TaggedPdf.TaggedPdfTextElement.Tag
