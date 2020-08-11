---
title: Aspose.PDF for .NET 11.6.0 Release Notes
type: docs
weight: 80
url: /net/aspose-pdf-for-net-11-6-0-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNEWNET-37116|PDF to TIFF - Use algorithm such as Bradley during conversion|Enhancement|
|PDFNEWNET-37650|Page number format in existing PDF|Enhancement|
|PDFNEWNET-40079|PDF to XPS - OutOfMemory Exception during conversion|Exception|
|PDFNEWNET-36942|ArgumentException when converting XFA to Standard Acro Form|Exception|
|PDFNEWNET-36890|XSL-FO to PDF - IndexOutOfRangeException is occurring|Exception|
|PDFNEWNET-38240|Extracting text throws OutofMemory exception|Exception|
|PDFNEWNET-37651|XFA Form to Standard Form conversion throws NullReferenceException|Exception|
|PDFNEWNET-39112|HTML to PDF: NullReferenceException|Exception|
|PDFNEWNET-36947|XSL-FO to PDF: InvalidOperationException|Exception|
|PDFNEWNET-40419|RedactionAnnotation working in 11.2.0 but throws NullReference Exception with 11.4.0|Exception|
|PDFNEWNET-40394|Redacting text in 11.4.0 throws NullRefrenceException|Exception|
|PDFNEWNET-40054|Html to PDF: conversion throws ArgumentNullException|Exception|
|PDFNEWNET-40623|Adding PDF pages throws NullReferenceException in 11.5.0|Exception|
|PDFNEWNET-40622|Add method of PageCollection object throws NullReference Exception in 11.5.0|Exception|
|PDFNEWNET-40600|API throws NullReferenceException on AddStamp() method in 11.5.0|Exception|
|PDFNEWNET-40591|Document.Pages.Add() method throws NullReference Exception in 11.5.0|Exception|
|PDFNEWNET-39479|HTML to PDF: InvalidCastException: Unable to cast object|Exception|
|PDFNEWNET-40620|Extraction of pages is not working in 11.5.0|Bug|
|PDFNEWNET-40612|Footnote text overlaps page body text in 11.5.0|Bug|
|PDFNEWNET-40589|Heading.TextState.ForegroundColor not working in 10.9.0 and higher versions|Bug|
|PDFNEWNET-40580|Open and Save PDF document lose the the page contents in resultant PDF|Bug|
|PDFNEWNET-40543|Footer text replacement issues in Aspose.PDF for .NET 11.4.1 hotfix|Bug|
|PDFNEWNET-37726|PDF to JPEG - improve conversion performance|Bug|
|PDFNEWNET-36809|High memory consumption when extracting Text from PDF|Bug|
|PDFNEWNET-40264|Performance concern: Horizontal alignment issue|Bug|
|PDFNEWNET-40430|XFA to standard PDF - Missing contents and formatting issues|Bug|
|PDFNEWNET-40118|PDF to PDFA1a: a circle turns into square in resultant PDFA1a|Bug|
|PDFNEWNET-38922|PDF to IMAGE: text is being rendered incorrectly|Bug|
|PDFNEWNET-33186|PDFA1A Read Out Issue|Bug|
|PDFNEWNET-40511|Image to PDF - Images are not rendering to subsequent pages|Bug|
|PDFNEWNET-39576|HTML to PDF - Image object is not being rendered in output file|Bug|
|PDFNEWNET-38626|PDF to TIFF - Data is lost in resultant image|Bug|
|PDFNEWNET-37897|PDF is not being converted to PDF/A_1a format|Bug|
|PDFNEWNET-34867|HTML to PDF: Text is garbled in output file|Bug|
|PDFNEWNET-34719|Support XFA to TIFF conversion|Bug|
|PDFNEWNET-33670|XPS converted from PDF is Improperly formatted|Bug|
|PDFNEWNET-40665|Long Footnote reference label renders incorrectly|Bug|
|PDFNEWNET-40664|Footnote text overlaps inline image|Bug|
|PDFNEWNET-40585|Large footnote text overlaps footer text in dual column layout PDF|Bug|
|PDFNEWNET-40582|Setting CellBorders increases the table width than the Table.ColumnWidths|Bug|
|PDFNEWNET-40577|$p of $P not populating on every page|Bug|
|PDFNEWNET-40434|PDF to PDFA1b: resultant document fails PDFA compliance with PreFlight|Bug|
|PDFNEWNET-40420|Redacting multiple text on a line add unwanted text at the bottom of the page|Bug|
|PDFNEWNET-40412|FormattedText does not return TextWidth for Japanese characters|Bug|
|PDFNEWNET-40408|PDF to TIFF conversion loses some text|Bug|
|PDFNEWNET-40398|Redaction: Aspose.PDF for .Net 11 removes visual page from document|Bug|
|PDFNEWNET-40279|Link annotation position(rect) issue|Bug|
|PDFNEWNET-40227|PDF to PDFA3b: text is being overlapped|Bug|
|PDFNEWNET-39568|PDF to PDFA losing data|Bug|
|PDFNEWNET-39374|HTML to PDF stalls forever|Bug|
|PDFNEWNET-38736|PDF to PDFA conversion changed logo background color|Bug|
|PDFNEWNET-38253|PDF to TIFF: form field data is lost|Bug|
|PDFNEWNET-40481|Multiple HtmlFragments inside table cell|Bug|
|PDFNEWNET-40110|PDF to HTML: characters alignment issues|Bug|
|PDFNEWNET-38506|PDF to PDFA: output PDF has black background|Bug|
|PDFNEWNET-40633|HTML to PDF conversion performance issue|Bug|
#### **Public API and Backward Incompatible Changes**
We have introduced following API changes in this release.

- **Aspose.PDF.Exceptions** namespace has been moved under **Aspose.PDF**.
- **Aspose.PDF.InteractiveFeatures** namespace has been moved under **Aspose.PDF.Annotations.**
- **Aspose.PDF.InteractiveFeatures.Annotations** namespace has been moved under **Aspose.PDF.Annotations.**
- **Aspose.PDF.InteractiveFeatures.Forms** has been moved under **Aspose.PDF.Forms**
- **Aspose.PDF.Engine.Presentation.RgbToDeviceGrayConversionStrategy** class has been moved to **Aspose.PDF.RgbToDeviceGrayConversionStrategy**
- **Aspose.PDF.Engine.Presentation.IColorSpaceConversionStrategy** class has been moved under **Aspose.PDF.IColorSpaceConversionStrategy**
