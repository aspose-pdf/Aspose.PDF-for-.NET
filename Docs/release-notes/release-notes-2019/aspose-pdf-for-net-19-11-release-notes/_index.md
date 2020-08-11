---
title: Aspose.PDF for .NET 19.11 Release Notes
type: docs
weight: 20
url: /net/aspose-pdf-for-net-19-11-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PDF for .NET 19.11.

{{% /alert %}} 
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-46942|[Center align output HTML](/pdf/net/convert-pdf-file-into-html-format/#convertpdffileintohtmlformat-centeralignoutputhtmlcontents)|New Feature|
|PDFNET-47190 |Add ability to set leftMargin, rightMargin for HTML page in Extensions|New Feature|
|PDFNET-46640 |Batch processing for XPS.|Enhancement|
|PDFNET-45366 |Implement Getter for  TextFragment.TextState.FontStyle|Enhancement|
|PDFNET-42824|Customize page numbering while adding a TOC|Enhancement|
|PDFNET-36446|HTML to PDF - an exception is being generated|Bug|
|PDFNET-37303|ePUB to PDF - NullReferenceException is occurring during conversion|Bug|
|PDFNET-39372|PDF to PDF/A - NullReferenceException during conversion|Bug|
|PDFNET-39972|HTML to PDF - Exception while loading the document |Bug|
|PDFNET-40007|HTML to PDF - Exception during conversion|Bug|
|PDFNET-40043|HTML to PDF - Exception during conversion|Bug|
|PDFNET-40615|PDF to PDFA1B: compliance failure due to transparency in the document|Bug|
|PDFNET-42263|PCL to PDF Conversion throws System.NullReferenceException Exception|Bug|
|PDFNET-42904|Long string replace does not format correctly|Bug|
|PDFNET-43095|Rotation of the TextFragment is not correct|Bug|
|PDFNET-43096|Rotation of the Characters is not correct in CharInfo |Bug|
|PDFNET-45031|NullReferenceException occurs when getting value of Aspose.Pdf.Artifact.Text|Bug|
|PDFNET-45219|PDF to HTML results in problem with local hyperlinks|Bug|
|PDFNET-45231|Incorrect annotation text rendering with right horizontal alignment|Bug|
|PDFNET-46143|Saving one page into HTML takes too long|Bug|
|PDFNET-45988|Incomplete text with colspan|Bug|
|PDFNET-46800|BrokenObject in PDF file |Bug|
|PDFNET-46931|HtmlFragment.IsKeptWithNext not working|Bug|
|PDFNET-47020|Error loading  MHT file|Bug|
|PDFNET-47073|Issue on converting MHT to PDF_A_2U|Bug|
|PDFNET-47085|PDF to XLSX: Font size is incorrect|Bug|
|PDFNET-47099|NullReferenceException on reading Artifact.Text|Bug|
|PDFNET-47103|Incorrect TextFragment.Segments behavior after TextFragmentAbsorber|Bug|
|PDFNET-47167|Get hyperlinks from PDF in 'CropBox' coordinate system|Bug|
### **Public API changes in Aspose.PDF for .NET 19.11**
-----
See the list of any changes made to the public API such as added, renamed, removed or deprecated members as well as any non-backward compatible change made to Aspose.PDF for .NET. If you have concerns about any change listed, please raise it on the [Aspose.PDF support forum](https://forum.aspose.com/c/pdf).
### **Added APIs**
- Class Aspose.Pdf.Sanitization.SanitizationException
- Constructor Aspose.Pdf.Sanitization.SanitizationException
- Constructor Aspose.Pdf.Sanitization.SanitizationException(System.String)
- Constructor Aspose.Pdf.Sanitization.SanitizationException(System.String,System.Exception)
- Constructor Aspose.Pdf.Sanitization.SanitizationException(System.Exception)
- Property Aspose.Pdf.HtmlSaveOptions.PageMarginIfAny
- Class Aspose.Pdf.SaveOptions.MarginInfo
- Constructor Aspose.Pdf.SaveOptions.MarginInfo
- Constructor Aspose.Pdf.SaveOptions.MarginInfo(Aspose.Pdf.SaveOptions.MarginPartStyle)
- Property Aspose.Pdf.SaveOptions.MarginInfo.TopMarginIfAny
- Property Aspose.Pdf.SaveOptions.MarginInfo.RightMarginIfAny
- Property Aspose.Pdf.SaveOptions.MarginInfo.BottomMarginIfAny
- Property Aspose.Pdf.SaveOptions.MarginInfo.LeftMarginIfAny
- Class Aspose.Pdf.SaveOptions.MarginPartStyle
- Constructor Aspose.Pdf.SaveOptions.MarginPartStyle(System.Int32)
- Constructor Aspose.Pdf.SaveOptions.MarginPartStyle(System.Boolean)
- Property Aspose.Pdf.SaveOptions.MarginPartStyle.IsAuto
- Property Aspose.Pdf.SaveOptions.MarginPartStyle.ValueInPoints
- Property Aspose.Pdf.HtmlSaveOptions.BatchSize
- Class Aspose.Pdf.IPageSetOptions
- Property Aspose.Pdf.IPageSetOptions.ExplicitListOfSavedPages
- Class Aspose.Pdf.IPipelineOptions
- Property Aspose.Pdf.IPipelineOptions.BatchSize
- Property Aspose.Pdf.XpsLoadOptions.BatchSize
- Property Aspose.Pdf.XpsSaveOptions.BatchSize
### **Removed APIs**
- Property Aspose.Pdf.HtmlSaveOptions.ProcessingBatchSize (renamed to Property Aspose.Pdf.HtmlSaveOptions.BatchSize)
