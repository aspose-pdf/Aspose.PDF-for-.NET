---
title: Aspose.PDF for .NET 19.1 Release Notes
type: docs
weight: 120
url: /net/aspose-pdf-for-net-19-1-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 19.1](https://www.nuget.org/packages/Aspose.Pdf/19.1.0)

{{% /alert %}} 

**Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-45663|PDF/UA: Support Inline Text Elements|Enhancement|
|PDFNET-45662|PDF/UA: Support Block Text Elements|Enhancement|
|PDFNET-35082|PDF to EMF/WMF conversion|Bug|
|PDFNET-35915|Large Pdf file to Tiff conversion performance issue|Bug|
|PDFNET-37261|PDF to Jpeg conversion consuming a lot time|Bug|
|PDFNET-37732|PDF to Image conversion takes much time|Bug|
|PDFNET-39950|Text replacement results in formatting issue|Bug|
|PDFNET-39994|Line break is not honored during text replace|Bug|
|PDFNET-40020|Persian text search problem|Bug|
|PDFNET-41304|HTML to PDF - Footer content alignment issues|Bug|
|PDFNET-42889|PDF to SVG - Unable to save output in Stream instance|Bug|
|PDFNET-43069|PDF file gets corrupted while locking it.|Bug|
|PDFNET-43514|Aspose.PDF taking long time to convert PDF->Image|Bug|
|PDFNET-43797|StackOverFlowException was occurred while loading the PDF Document.|Bug|
|PDFNET-44183|OOM thrown when ImagePlacement using|Bug|
|PDFNET-44192|Saving to EPUB format is taking too long.|Bug|
|PDFNET-45068|Saving to APS takes too long|Bug|
|PDFNET-45255|PDF to PPTX - multiple text boxes and different text alignments in output PPTX|Bug|
|PDFNET-45276|PDF to HTML - Alignment issues occur when viewing HTML in IE11|Bug|
|PDFNET-45341|Incorrect underline in PDF file|Bug|
|PDFNET-45514|Simultaneously repeated rows and columns produce the incorrect output.|Bug|
|PDFNET-45660|PDF/UA: Using custom tag name for Structure Elements|Bug|
|PDFNET-45694|Flattening a PDF document is not working for a particular document|Bug|
|PDFNET-45721|An exception raises while converting PDF source to PDFA_2A compliant output|Bug|
|PDFNET-45783|Merging multiple documents using PdfFileEditor is taking too much time|Bug|
|PDFNET-45797|PDF/UA. Validator doesn't recognize error "Inconsistent entry found" for Structural parent tree|Bug|
|PDFNET-45798|PDF/UA. Validator recognize structure errors in correct document|Bug|
|PDFNET-45799|PDF/UA. Validator doesn't recognize warning "Inappropriate use Figure structure element"|Bug|
|PDFNET-45814|Incorrect decoding of an Chinese string|Bug|
|PDFNET-45830|PDF to PDF/A - Regression issue - image loading exception|Bug|
|PDFNET-45831|PDF to PDF/A - Regression issue - image loading exception|Bug|
|PDFNET-45840|NullPointerException when calling XImage.Grayscaled|Bug|
### **Public API changes in Aspose.PDF for .NET 19.1**
-----
### **Added APIs:**
Property Aspose.Pdf.ImagePlacementAbsorber.IsReadOnlyMode
Property Aspose.Pdf.LogicalStructure.BLSTextElement.StructureTextState
Property Aspose.Pdf.LogicalStructure.ILSTextElement.StructureTextState
Property Aspose.Pdf.LogicalStructure.ITextElement.StructureTextState
Enumeration Aspose.Pdf.LogicalStructure.StructureTextState
Enumeration member Aspose.Pdf.LogicalStructure.StructureTextState.Font
Enumeration member Aspose.Pdf.LogicalStructure.StructureTextState.FontSize
Enumeration member Aspose.Pdf.LogicalStructure.StructureTextState.FontStyle
Enumeration member Aspose.Pdf.LogicalStructure.StructureTextState.ForegroundColor
Property Aspose.Pdf.LogicalStructure.StructureTypeStandard.Category
Property Aspose.Pdf.Tagged.ITaggedContent.StructureTextState
### **Removed APIs:**
Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.XML_100 renamed to Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.Xml_100
Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.HTML_320 renamed to  Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.Html_320
Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.HTML_401 renamed to Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.Html_401 
Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.OEB_100 renamed to  Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.Oeb_100
Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.RTF_105 renamed to  Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.Rtf_105
Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.CSS_100 renamed to  Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.Css_100
Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.CSS_200 renamed to  Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.Css_200
Property Aspose.Pdf.LogicalStructure.BLSTextElement.TextState renamed to  Aspose.Pdf.LogicalStructure.BLSTextElement.StructureTextState
Property Aspose.Pdf.LogicalStructure.ILSTextElement.TextState renamed to Aspose.Pdf.LogicalStructure.ILSTextElement.StructureTextState
Property Aspose.Pdf.LogicalStructure.ITextElement.TextState renamed to Aspose.Pdf.LogicalStructure.ITextElement.StructureTextState
