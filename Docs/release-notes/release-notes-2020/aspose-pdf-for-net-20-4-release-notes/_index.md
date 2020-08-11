---
title: Aspose.PDF for .NET 20.4 Release Notes
type: docs
weight: 90
url: /net/aspose-pdf-for-net-20-4-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PDF for .NET 20.4.

{{% /alert %}} 
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-47847|Add the ability to use an image file stream as the background of a table cell|Enhancement|
|PDFNET-41517|TextFragment Rectangle must be rotated 90° when used as TextAbsorber Rectangle|Bug|
|PDFNET-43320|PDF to DOCX - Resultant file cannot be opened in Microsoft Words Online|Bug|
|PDFNET-45324|ArgumentOutOfRangeException with TextFragmentAbsorber|Bug|
|PDFNET-45718|System.IndexOutOfRangeException Exception occurred while extracting text|Bug|
|PDFNET-46550|PDF to PDF/A - Field not found error occurs|Bug|
|PDFNET-47305|PDF to PPTX, the fonts overlap and the conversion effect is not very good|Bug|
|PDFNET-47462|Characters are missing when saving PDF into HTML|Bug|
|PDFNET-47694|Vertical lines instead of spaces when viewing output HTML in IE|Bug|
|PDFNET-47695|Boxes instead of spaces when copying text from a browser|Bug|
|PDFNET-47712|Discrepancies in the output PDF|Bug|
|PDFNET-47713|Incorrect page ordering in the output file|Bug|
|PDFNET-47714|Text missing and duplication in the output file.|Bug|
|PDFNET-47743|The text is hidden when saving PDF as HTML|Bug|
|PDFNET-47845|System.NullReferenceException while Flattening|Bug|
|PDFNET-46414|HTML to PDF - Table is missing in output PDF|Bug|
|PDFNET-47878|Exception on converting HTML to PDF|Bug|
|PDFNET-44330|NullReference exception on flattening fields|Bug|
## **Public API and Backward Incompatible Changes**
### **Added APIs**
- Property Aspose.Pdf.Cell.BackgroundImage
### **Removed APIs**
- Class Aspose.Pdf.LatexLoadOptions is renamed to Aspose.Pdf.TeXLoadOptions (Aspose.Pdf.LatexLoadOptions is declared obsolete)
- Class Aspose.Pdf.LaTeXSaveOptions is renamed to Aspose.Pdf.TeXSaveOptions (Aspose.Pdf.LaTeXSaveOptions is declared obsolete)
- Class Aspose.Pdf.LatexFragment    is renamed to Aspose.Pdf.TeXFragment (Aspose.Pdf.LatexFragment is declared obsolete)
