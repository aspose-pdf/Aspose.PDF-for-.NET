---
title: Aspose.PDF for .NET 18.11 Release Notes
type: docs
weight: 20
url: /net/aspose-pdf-for-net-18-11-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 18.11](https://www.nuget.org/packages/Aspose.Pdf/18.11.0)

{{% /alert %}} 
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-45582|PDFUA: Add taggedPdfTextBlockelement|New Feature|
|PDFNET-45584|PDFUA: Add text block named element|New Feature|
|PDFNET-45547|Improve OptimizeResources performance|Enhancement|
|PDFNET-35495|HTML to PDF - ArgumentNullException is occurring|Bug|
|PDFNET-37575|PDF to TIFF - ArgumentException is being generated|Bug|
|PDFNET-37817|HTML to PDF - Formatting issues in resultant file|Bug|
|PDFNET-38032|HTML to PDF: Table background-color style is not working|Bug|
|PDFNET-38075|PDF to Execl: cells data merges to a single cell in output|Bug|
|PDFNET-38349|PDF to TIFF: output image missing text|Bug|
|PDFNET-38426|PDF to XLS - Error appears when viewing resultant file|Bug|
|PDFNET-38527|When using Custom font, SuperScript is not being honored|Bug|
|PDFNET-38595|Incorrect Character width and X coordinate information|Bug|
|PDFNET-38689|PDF to EXCEL results in a corrupt file|Bug|
|PDFNET-38744|Not all characters are resized in PDF field|Bug|
|PDFNET-38848|Hyperlink Alignment issue|Bug|
|PDFNET-38892|TextState properties are not being applied in HeaderFooter|Bug|
|PDFNET-39270|PDF to PDF/A - NullReferenceException during PDF/A conversion|Bug|
|PDFNET-39347|TIFF to PDF - OutOfMemoryException during conversion|Bug|
|PDFNET-42133|Adding svg into table cell from disk API throws ArgumentException|Bug|
|PDFNET-42220|Which TIFF versions Aspose.Pdf for .NET supports|Bug|
|PDFNET-42536|PDF printing takes several minutes|Bug|
|PDFNET-42642|Exception when trying to add SVG image stream to PDF|Bug|
|PDFNET-43026|Black background is appearing while adding SVG into PDF|Bug|
|PDFNET-43150|PDF to TIFF - Text of lighter color is missing in output image|Bug|
|PDFNET-43330|SVG turned out to be black and white while adding into table|Bug|
|PDFNET-43863|JPG to PDF - output document failed to open in Adobe Reader|Bug|
|PDFNET-44167|PDF to PDF/A-1b - the output PDF does not pass compliance test|Bug|
|PDFNET-44344|HtmlFragment moves content to next page|Bug|
|PDFNET-44349|Cannot add local hyperlink to the text of table cell|Bug|
|PDFNET-45022|Cannot extract table and its data using TableAbsorber|Bug|
|PDFNET-45291|IsBlank property true when page is not blank|Bug|
|PDFNET-45349|PDF to PPTX - System.InvalidOperationException Exception occurred|Bug|
|PDFNET-45360|Preflight log contains fonts related problems|Bug|
|PDFNET-45407|Highlight Annotation hides/redacts the text after merging annotations|Bug|
|PDFNET-45470|Slow processing of document|Bug|
|PDFNET-45478|Setting Cell.ColSpan to 4 leads to invalid render of graphs and text|Bug|
|PDFNET-45488|NullReferenceException when validating or converting a PDF/A|Bug|
|PDFNET-45497|The text extraction takes much time|Bug|
|PDFNET-45534|PDFA output contains more than one XREF subsection|Bug|
|PDFNET-45558|Document is not PDF/A compatible after conversion|Bug|
|PDFNET-45338|Output document isn't PDFA_2A compliant|Bug|
|PDFNET-45101|Implement functionality to support fonts and text for PDF/UA format|Bug|
### **Public API changes in Aspose.PDF for .NET 18.11**
-----
### **Added APIs:**
Class Aspose.Pdf.Optimization.ImageCompressionOptions
Constructor Aspose.Pdf.Optimization.ImageCompressionOptions
Property Aspose.Pdf.Optimization.ImageCompressionOptions.CompressImages (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Optimization.ImageCompressionOptions.ResizeImages (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Optimization.ImageCompressionOptions.ImageQuality (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Optimization.ImageCompressionOptions.MaxResolution (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Optimization.ImageCompressionOptions.Version
Enumeration Aspose.Pdf.Optimization.ImageCompressionVersion
Enumeration member Aspose.Pdf.Optimization.ImageCompressionVersion.Standard
Enumeration member Aspose.Pdf.Optimization.ImageCompressionVersion.Fast
Enumeration member Aspose.Pdf.Optimization.ImageCompressionVersion.Mixed
Class Aspose.Pdf.Optimization.OptimizationOptions
Constructor Aspose.Pdf.Optimization.OptimizationOptions.#ctor
Property Aspose.Pdf.Optimization.OptimizationOptions.LinkDuplcateStreams (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Optimization.OptimizationOptions.AllowReusePageContent (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Optimization.OptimizationOptions.RemoveUnusedStreams (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Optimization.OptimizationOptions.RemoveUnusedObjects (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Optimization.OptimizationOptions.ImageCompressionOptions (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Optimization.OptimizationOptions.CompressImages
Property Aspose.Pdf.Optimization.OptimizationOptions.ResizeImages (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Optimization.OptimizationOptions.ImageQuality (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Optimization.OptimizationOptions.MaxResoultion (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Optimization.OptimizationOptions.UnembedFonts (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Optimization.OptimizationOptions.RemovePrivateInfo (moved from Aspose.Pdf.Document.OptimizationOptions)
Method Aspose.Pdf.Optimization.OptimizationOptions.All (moved from Aspose.Pdf.Document.OptimizationOptions)
Property Aspose.Pdf.Text.TextFragment.Hyperlink
Method Aspose.Pdf.Text.TextFragmentAbsorber.RemoveAllText(Aspose.Pdf.Page,Aspose.Pdf.Rectangle)
Class Aspose.Pdf.TaggedPdf.TaggedPdfBlockLevelTextElement 
Method Aspose.Pdf.TaggedPdf.TaggedPdfBlockLevelTextElement.#ctor(Aspose.Pdf.Document,System.String,System.String,Aspose.Pdf.Text.TextState) 
Method Aspose.Pdf.TaggedPdf.TaggedPdfContent.Add(Aspose.Pdf.TaggedPdf.TaggedPdfBlockLevelTextElement) 
Method Aspose.Pdf.TaggedPdf.TaggedPdfDocumentElement.Add(Aspose.Pdf.Page,Aspose.Pdf.TaggedPdf.TaggedPdfBlockLevelTextElement) 
Property Aspose.Pdf.TaggedPdf.TaggedPdfElement.MCID 
Property Aspose.Pdf.TaggedPdf.TaggedPdfElement.Tag 
Class Aspose.Pdf.TaggedPdf.TaggedPdfH1Element 
Constructor Aspose.Pdf.TaggedPdf.TaggedPdfH1Element.#ctor(Aspose.Pdf.Document,System.String,Aspose.Pdf.Text.TextState) 
Class Aspose.Pdf.TaggedPdf.TaggedPdfH2Element 
Constructor Aspose.Pdf.TaggedPdf.TaggedPdfH2Element.#ctor(Aspose.Pdf.Document,System.String,Aspose.Pdf.Text.TextState) 
Class Aspose.Pdf.TaggedPdf.TaggedPdfH3Element 
Constructor Aspose.Pdf.TaggedPdf.TaggedPdfH3Element.#ctor(Aspose.Pdf.Document,System.String,Aspose.Pdf.Text.TextState) 
Class Aspose.Pdf.TaggedPdf.TaggedPdfH4Element 
Constructor Aspose.Pdf.TaggedPdf.TaggedPdfH4Element.#ctor(Aspose.Pdf.Document,System.String,Aspose.Pdf.Text.TextState) 
Class Aspose.Pdf.TaggedPdf.TaggedPdfH5Element 
Constructor Aspose.Pdf.TaggedPdf.TaggedPdfH5Element.#ctor(Aspose.Pdf.Document,System.String,Aspose.Pdf.Text.TextState) 
Class Aspose.Pdf.TaggedPdf.TaggedPdfH6Element 
Constructor Aspose.Pdf.TaggedPdf.TaggedPdfH6Element.#ctor(Aspose.Pdf.Document,System.String,Aspose.Pdf.Text.TextState) 
Class Aspose.Pdf.TaggedPdf.TaggedPdfPElement 
Constructor Aspose.Pdf.TaggedPdf.TaggedPdfPElement.#ctor(Aspose.Pdf.Document,System.String,Aspose.Pdf.Text.TextState)
### **Removed APIs:**
Aspose.Pdf.Document.OptimizationOptions was moved into Aspose.Pdf.Optimization namespace. 

{{% alert color="primary" %}} 

But Aspose.Pdf.Document.OptimizationOptions class was kept for backward compatibility.

{{% /alert %}} 