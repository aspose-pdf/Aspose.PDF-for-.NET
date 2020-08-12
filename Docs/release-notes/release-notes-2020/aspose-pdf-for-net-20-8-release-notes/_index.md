---
title: Aspose.PDF for .NET 20.8 Release Notes
type: docs
weight: 50
url: /net/aspose-pdf-for-net-20-8-release-notes/
---

{{% alert color="primary" %}}

This page contains release notes information for Aspose.PDF for .NET 20.8.

{{% /alert %}}
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-48346|	PDF/X-1A standard inquiry|Enhancement|
|PDFNET-34710|	HTML to PDF: Formatting issues during conversion|	Bug|
|PDFNET-36227|HTMl to PDF - Formatting issues in resultant PDF|	Bug|
|PDFNET-36432|	HTML to PDF: process hangs|	Bug|
|PDFNET-39095|	HTML to PDF - Incorrect contents rendering|	Bug|
|PDFNET-41072|	How to set default font name in PDF to Image conversion	1|Bug|
|PDFNET-45141|	IndexOutOfRangeException with ParagraphAbsorber|	Bug|
|PDFNET-46594|	PDF to TIFF - Text is overlapped in output (Regression)|	Bug|
|PDFNET-47250|	Conversion from HTML to PDF never ends|	Bug|
|PDFNET-47655|	Convert PDF to PDF/A - Object reference error occurs|	Bug|
|PDFNET-47780|	Print-preview issues of the output HTML in Chrome|	Bug|
|PDFNET-47873|	Webpage to PDF - broken hyperlinks|	Bug|
|PDFNET-48177|	JpegDevice.Process throws ArgumentOutOfRangeException|Bug|
|PDFNET-48189|	Missing links in the table of contents|	Bug|
|PDFNET-48243|	Aspose.Pdf 20.5.0: TextState.Underline property does not change|	Bug|
|PDFNET-48402|	PDF to XLSX conversion never ends	|Bug|
|PDFNET-48428|	PDF file not properly converted HTML	|Bug|
|PDFNET-48432|	On extracting pages the code throws the NullReferenceException|	Bug|
|PDFNET-48433|	On extracting pages the code throws the NullPointException|	Bug|
|PDFNET-48447|	System.ArgumentException occurs while merging PDF documents|	Bug|
|PDFNET-48456|	On extracting pages the code throws the "Invalid key path: must contain at most two parts separated with" exception|	Bug|
|PDFNET-48460|	OutOfMemoryException in pdf to html conversion|	Bug|
|PDFNET-48472|	Exception in loading SVG|	Bug|
|PDFNET-48473|	SVG not properly converted to PDF|	Bug|
|PDFNET-48476|	On conversion to HTML "Value does not fall within the expected range." exception is thrown|	Bug|
|PDFNET-48479|	Loading of the PDF never ends|	Bug|
|PDFNET-48480|	Exception on converting HTML to PDF	|Bug|
|PDFNET-48499|	PDF to XLSX: Files are corrupted|	Bug|
|PDFNET-48523|	API is taking long time while saving the document at Save() method|Bug|
|PDFNET-48525|	Incorrect Cell borders with Colspan and wide tables	|Bug|
|PDFNET-48551|	PDF to PDF/A - Output document is not valid [Regression]|	Bug|
|PDFNET-48569|	NullReferenceException is thrown when calling Document.Form.Flatten()|	Bug|
|PDFNET-48572| API is taking long time while saving the document at Save() method|Bug|
|PDFNET-48554| Abnormalities while generating PDF/X-1a documents|Bug|

## Public API and Backward Incompatible Changes ##

### Added APIs ###
 * Member Aspose.Pdf.PdfFormat.PDF_X_1A_2001           
 * Method Aspose.Pdf.XForm.GetResources(System.Boolean)
 * Method Aspose.Pdf.XForm.GetResources

### Changed APIs ###
Default values were changed in ExcelSaveOptions for the following properties:
 * ConversionEngines: NewEngine (instead of LegacyEngine)
 * ExcelFormat: XLSX (instead of XMLSpreadSheet2003)
 * InsertBlankColumnAtFirst:= false (instead of true)
