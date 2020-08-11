---
title: Aspose.PDF for .NET 19.7 Release Notes
type: docs
weight: 60
url: /net/aspose-pdf-for-net-19-7-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 19.7](https://www.nuget.org/packages/Aspose.Pdf/19.7.0)

{{% /alert %}} 
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-41866|HTML to PDF - Render all contents in single page|New Feature|
|PDFNET-42229|Support to add Latex script in PDF|New Feature|
|PDFNET-41160|PDF to PDFA: saving log to stream with Transparency mask parameter|Enhancement|
|PDFNET-35627|HTML to PDF: Rendering HTML with svg|Enhancement|
|PDFNET-45561|Option for excluding font resources when saving PDF as HTML|Enhancement|
|PDFNET-40757|PDF to PDFA converts invalid PDFA document|Bug|
|PDFNET-40760|PDF to PDFA conversion results incorrect PDFA1b|Bug|
|PDFNET-41536|FloatingBox doesn't respect dimensions with HTMLFragments and multiple columns|Bug|
|PDFNET-41575|Text Extraction: API should throw some meaningful exception in evaluation mode|Bug|
|PDFNET-41580|TextFragmentAbsorber replacing text results in incorrect placement|Bug|
|PDFNET-41737|Accessing Page properties throws NullReference Exception|Bug|
|PDFNET-42051|PDF to Image- ContextSwitchDeadlock during conversion|Bug|
|PDFNET-42134|SVG image is not dislaying in the table cell|Bug|
|PDFNET-42175|Output difference between Adobe and Aspose XFDF Merge|Bug|
|PDFNET-42397|PDF to JPEG Conversion generates blank image|Bug|
|PDFNET-42488|Letters missing when PDF document is converted to XPS.|Bug|
|PDFNET-42491|PDF to HTML - local links are not preserved|Bug|
|PDFNET-42876|Exception is thrown when saving PCL as PDF|Bug|
|PDFNET-42935|PowerPoint Conversion Spacing Issues|Bug|
|PDFNET-43348|Prevent embedding fonts while saving into HTML|Bug|
|PDFNET-43452|Font parameters in APS, css styles and visual representation differ on Win7 adn Win10|Bug|
|PDFNET-43839|Value does not fall within the expected range exception when saving PDF as HTML|Bug|
|PDFNET-44377|Duplicated evaluation watermarks when saving EPUB document|Bug|
|PDFNET-44970|When PDF is printed, then barcode gets blurred and cannot be scanned.|Bug|
|PDFNET-45079|Problem with GraphInfo.IsDoubled Property|Bug|
|PDFNET-45195|Problem converting image to PDF|Bug|
|PDFNET-45253|Aspose.Pdf 18.8: HTML output file is not rendered properly in Edge|Bug|
|PDFNET-45256|Low quality chart rendering during PDF to PPTX|Bug|
|PDFNET-45260|Unable to extract custom XMP Values from PDF|Bug|
|PDFNET-45262|Problem with signature visibility|Bug|
|PDFNET-45650|PDF to HTML - output HTML is not rendering correctly in MS Edge|Bug|
|PDFNET-45884|Saving Pdf document as HTML throws an exception|Bug|
|PDFNET-46076|NullReferenceException while converting page to image|Bug|
|PDFNET-46102|Facades.Form.GetFieldType() method is throwing unhandled exception|Bug|
|PDFNET-46132|Blue box is missing when saving as image or HTML|Bug|
|PDFNET-46235|Conversion to HTML - tags are not in order|Bug|
|PDFNET-46255|Endless loop while saving PDF output|Bug|
|PDFNET-46293|PageIndex property of form fields is always zero|Bug|
|PDFNET-46296|Out of memory in pdf to html conversion|Bug|
|PDFNET-46320|The highlight is overlapping across different columns in PPTX output|Bug|
|PDFNET-46321|The text highlights are too much extended in the output PPTX|Bug|
|PDFNET-46375|PCL to PDF - ArgumentOutOfRangeException: Capacity must be positive.|Bug|
|PDFNET-46390|Chinese font gets garbled after changing link color|Bug|
|PDFNET-46391|The bookmark count isn't properly retrieved|Bug|
|PDFNET-46424|CR and EOL characters inserted when extracting text with TextAbsorber|Bug|
|PDFNET-46455|HTML to PDF - System.Argument.Exception|Bug|
|PDFNET-46509|Tables are not parsed in Markdown to PDF converter|Bug|
|PDFNET-46072|All form fields are showing the same PageIndex|Bug|
|PDFNET-45722|Exception when converting XFA Dynamic form to Standard On Linux|Bug|
|PDFNET-46337|Problem changing page size|Bug|
|PDFNET-45063|Problem with TextFragmentAbsorber in AWS|Bug|
|PDFNET-38232|PDF to HTML - Wrong text color in the resultant file|Bug|
|PDFNET-45566|PDFUA: HTML to PDF converter work with errors|Bug|
|PDFNET-37412|Signing PDF using the X509Certificate2 instead PFX file|Bug|
|PDFNET-36337|Signing with certificate from the certificate store|Bug|
|PDFNET-45533|An exception is thrown when loading PCL document|Bug|
### **Public API changes in Aspose.PDF for .NET 19.7**
-----
### **Added APIs:**
Property Aspose.Pdf.Text.TextEditOptions.ReplacementFont
Enumeration member Aspose.Pdf.Text.TextEditOptions.NoCharacterAction.UseCustomReplacementFont
Property Aspose.Pdf.PptxSaveOptions.ImageResolution
Property Aspose.Pdf.HtmlSaveOptions.ProcessingBatchSize
Property Aspose.Pdf.HtmlSaveOptions.SimpleTextboxModeGrouping
Property Aspose.Pdf.HtmlSaveOptions.ExcludeFontNameList
Property Aspose.Pdf.HtmlLoadOptions.IsEmbedFonts
Method Aspose.Pdf.Document.Convert(System.IO.Stream,Aspose.Pdf.PdfFormat,Aspose.Pdf.ConvertErrorAction,Aspose.Pdf.ConvertTransparencyAction)
Enumeration member Aspose.Pdf.Facades.FieldType.Numeric
Enumeration member Aspose.Pdf.Facades.FieldType.DateTime
Method Aspose.Pdf.XmpValue.ToStructure
Method Aspose.Pdf.XmpValue.ToField
Method Aspose.Pdf.XmpValue.ToNamedValue
Method Aspose.Pdf.XmpValue.ToNamedValues
Property Aspose.Pdf.Forms.Form.SignaturesExist
Property Aspose.Pdf.Forms.Form.SignaturesAppendOnly
Class Aspose.Pdf.XmpField
Property Aspose.Pdf.XmpField.Empty
Property Aspose.Pdf.XmpField.Lang
Property Aspose.Pdf.XmpField.Prefix
Property Aspose.Pdf.XmpField.NamespaceUri
Property Aspose.Pdf.XmpField.LocalName
Property Aspose.Pdf.XmpField.Name
Property Aspose.Pdf.XmpField.Value
Property Aspose.Pdf.XmpField.FieldType
Property Aspose.Pdf.XmpField.IsEmpty
Method Aspose.Pdf.XmpField.ToStructure
Method Aspose.Pdf.XmpField.ToArray
Enumeration Aspose.Pdf.XmpFieldType
Enumeration member Aspose.Pdf.XmpFieldType.Struct
Enumeration member Aspose.Pdf.XmpFieldType.Array
Enumeration member Aspose.Pdf.XmpFieldType.Property
Enumeration member Aspose.Pdf.XmpFieldType.Packet
Enumeration member Aspose.Pdf.XmpFieldType.Unknown
