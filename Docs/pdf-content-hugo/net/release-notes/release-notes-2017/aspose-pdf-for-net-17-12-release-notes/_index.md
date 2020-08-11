---
title: Aspose.PDF for .NET 17.12 Release Notes
type: docs
weight: 10
url: /net/aspose-pdf-for-net-17-12-release-notes/
---

## **Release Notes of Aspose.PDF for .NET 17.12**
As per regular monthly update process of all APIs being offered by Aspose, we are honored to announce the December Release of Aspose.PDF for .NET. In this release we have added support for .NET Standard 2.0 and made improvements to the API. A complete list of improvements and changes in the API, is as follows:
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|**PDFNET-40993**|**Support for .NET Core**|**New Feature**|
|PDFNET-43759|Implement LaTeX fragment embedding|New Feature|
|PDFNET-41246|Support to add text with Gradient Fill|New Feature|
|PDFNET-38710|HorizontalAlignment for FloatingBox contents|New Feature|
|PDFNET-43056|Add feature to hide the page numbers in table of contents tree|New Feature|
|PDFNET-42444|Use SVG image with StampAnnotation object|Enhancement|
|PDFNET-43520|Text absorber retrieves the garbled text|Bug|
|PDFNET-38924|PDF to TIF conversion loses the text|Bug|
|PDFNET-36944|PDF generated with Document class is greater in size as compared to Pdf class|Bug|
|PDFNET-43125|#$TAB is not working in new DOM based XML|Bug|
|PDFNET-43742|Alignment attribute in XML takes enum value instead of string|Bug|
|PDFNET-43109|Cannot embed font in the PDF with embedability Preview/Print|Bug|
|PDFNET-42339|Alignment of radio button is not proper|Bug|
|PDFNET-43615|CustomResourceSavingStrategy delegate is not called when saving as HTML|Bug|
|PDFNET-43673|Regression bug during PDF-to-HTML conversion in versions 17.10 and 17.11|Bug|
|PDFNET-40588|PDF to EPUB: resultant epub document missing image|Bug|
|PDFNET-42946|Method Delete of ActionCollection class doesn't work|Bug|
|PDFNET-42871|Pdf printing problem|Bug|
|PDFNET-43651|The numbering formatting issue in the PDF form output.|Bug|
|PDFNET-42561|Combine Files - Bookmarks not working|Bug|
|PDFNET-40855|Text replacement malformed the PDF contents|Bug|
|PDFNET-37872|PDF to JPEG - Missing text in output JPEG|Bug|
|PDFNET-39298|PDF to PNG - invisible objects become visible|Bug|
|PDFNET-43065|Some images have replaced by a blue rectangle|Bug|
|PDFNET-40274|Issue in adding SVG image in Page Header|Bug|
|PDFNET-43480|Named destinations are lost when processing bookmarks|Bug|
|PDFNET-33517|Print Works Incorrectly|Bug|
|PDFNET-43498|PDF to Excel - Escaping XML reserved characters|Bug|
|PDFNET-38484|Long text replacement moves text off the page|Bug|
|PDFNET-40793|PDF to PNG - Resultant image is missing contents|Bug|
|PDFNET-43613|PDF to PPTX - Highlighted text do not appear properly in resultant file|Bug|
|PDFNET-42510|PDF to HTML - Text appears as image|Bug|
|PDFNET-42595|PDF to HTML - Text changes its position|Bug|
|PDFNET-43463|PDF to HTML - the additional characters are added|Bug|
|PDFNET-42573|Changing Foreground color of Text removes the image from the PDF|Bug|
|PDFNET-34368|TextState Foreground does not work|Bug|
|PDFNET-36215|Setting BackgroudColor property of text Fragment hides the text |Bug|
|PDFNET-39021|Text replacement loses some characters in replaced text|Bug|
|PDFNET-39601|Text overlaps when replacing file contents|Bug|
|PDFNET-43657|Burmese language character are cut from above ages when adding in PDF|Bug|
|PDFNET-38149|Text Extraction issue: RTL text is rendered as LTR|Bug|
|PDFNET-37834|PDF to TIFF: conversion loses data|Bug|
|PDFNET-42762|HTML to PDF - Problem converting PDF file|Bug|
|PDFNET-38837|Incorrect Annotation type being returned|Bug|
|PDFNET-43518|Bookmarks are lost after merging PDF documents|Bug|
|PDFNET-43598|Exception when trying to set border for RadioButtonField|Bug|
|PDFNET-43347|Cannot add formatted HTML text in all PDF pages|Bug|
|PDFNET-40755|Aspose.Pdf recognize Incorrect font name|Bug|
|PDFNET-41738|PDF to HTML: text shifted to left side|Bug|
|PDFNET-41794|PDF to DOC: text line missing|Bug|
|PDFNET-41510|PDF to Doc: Text in the word document are wrapped one on another|Bug|
|PDFNET-40505|PDF to XPS: colored images changes to greyscale|Bug|
### **Public API changes in Aspose.PDF for .NET 17.12**
### **Added APIs:**
-----
Property Aspose.Pdf.Annotations.Annotation.Actions
Class Aspose.Pdf.Annotations.PdfActionCollection
Property Aspose.Pdf.Annotations.PdfActionCollection.Count
Property Aspose.Pdf.Annotations.PdfActionCollection.Item(System.Int32)
Method Aspose.Pdf.Annotations.PdfActionCollection.Delete(System.Int32)
Method Aspose.Pdf.Annotations.PdfActionCollection.Add(Aspose.Pdf.Annotations.PdfAction)
Method Aspose.Pdf.Annotations.PdfActionCollection.GetEnumerator
Class Aspose.Pdf.FormattedFragment
Method Aspose.Pdf.FormattedFragment.GetMatrix(System.Double,System.Double,Aspose.Pdf.PageInfo)
Method Aspose.Pdf.FormattedFragment.GetMatrixOperator(System.Double,System.Double,Aspose.Pdf.PageInfo)
Method Aspose.Pdf.FormattedFragment.CopyFields(Aspose.Pdf.FormattedFragment)
Property Aspose.Pdf.HtmlFragment.HtmlLoadOptions
Class Aspose.Pdf.LatexFragment
Constructor Aspose.Pdf.LatexFragment(System.String)
Constructor Aspose.Pdf.LatexFragment(System.String,System.Boolean)
Property Aspose.Pdf.LatexFragment.LatexLoadOptionsOfInstance
Method Aspose.Pdf.LatexFragment.Clone
Method Aspose.Pdf.Matrix.Skew(System.Double,System.Double)
Property Aspose.Pdf.Text.Font.DecodedFontName
Property Aspose.Pdf.Text.TextAbsorber.HasErrors
Property Aspose.Pdf.Text.TextAbsorber.Errors
Class Aspose.Pdf.Text.TextExtractionError
Property Aspose.Pdf.Text.TextExtractionError.Summary
Property Aspose.Pdf.Text.TextExtractionError.Description
Property Aspose.Pdf.Text.TextExtractionError.Location
Property Aspose.Pdf.Text.TextExtractionError.FontKey
Property Aspose.Pdf.Text.TextExtractionError.FontName
Property Aspose.Pdf.Text.TextExtractionError.ExtractedText
Method Aspose.Pdf.Text.TextExtractionError.ToString
Class Aspose.Pdf.Text.TextExtractionErrorLocation
Property Aspose.Pdf.Text.TextExtractionErrorLocation.Path
Property Aspose.Pdf.Text.TextExtractionErrorLocation.PageNumber
Property Aspose.Pdf.Text.TextExtractionErrorLocation.ObjectType
Property Aspose.Pdf.Text.TextExtractionErrorLocation.FormKey
Property Aspose.Pdf.Text.TextExtractionErrorLocation.OperatorIndex
Property Aspose.Pdf.Text.TextExtractionErrorLocation.OperatorString
Property Aspose.Pdf.Text.TextExtractionErrorLocation.FontUsedKey
Property Aspose.Pdf.Text.TextExtractionErrorLocation.TextStartPoint
Method Aspose.Pdf.Text.TextExtractionErrorLocation.ToString
Property Aspose.Pdf.Text.TextFragmentAbsorber.HasErrors
Property Aspose.Pdf.Text.TextFragmentAbsorber.Errors
Property Aspose.Pdf.Text.TextReplaceOptions.AdjustmentNewLineSpacing
Property Aspose.Pdf.Text.TextSearchOptions.LogTextExtractionErrors
### **Removed APIs:**
-----
Property Aspose.Pdf.HtmlFragment.HtmlLoadOptionsOfInstance

