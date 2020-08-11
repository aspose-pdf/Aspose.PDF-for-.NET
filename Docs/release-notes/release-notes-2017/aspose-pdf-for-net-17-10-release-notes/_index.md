---
title: Aspose.PDF for .NET 17.10 Release Notes
type: docs
weight: 30
url: /net/aspose-pdf-for-net-17-10-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-38067|Support DICOM image to PDF|New Feature|
|PDFNET-35297|To set Print Dialog Presets properties of a PDF document|New Feature|
|PDFNET-38544|Support Vertical Alignment property for Row instance|New Feature|
|PDFNET-43057|Add image inside PDF - Output is different as compared to old Generator|Enhancement|
|PDFNET-42433|PDF to SVG content gets shrinked|Bug|
|PDFNET-40060|PDF to SVG: incorrect Character spacing|Bug|
|PDFNET-41870|API does not accept password in foreign language|Bug|
|PDFNET-42928|Using CallBackGetHocr results with blank image|Bug|
|PDFNET-37329|SVG to PDF: incorrect output with errors|Bug|
|PDFNET-35992|PDF to PDFA1b conformance issue|Bug|
|PDFNET-38517|PDF to Image: image is not being rendered properly|Bug|
|PDFNET-42537|Text not getting displayed in browser when saving PDF document to HTML|Bug|
|PDFNET-38591|PDF to HTML - space between text increased|Bug|
|PDFNET-42745|Incorrect position of parenthesis when saving as HTML|Bug|
|PDFNET-41176|PDF to HTML: hidden characters are visible|Bug|
|PDFNET-41140|PDF to HTML: chart lines are darker|Bug|
|PDFNET-39490|Text Replace - Underline property does not work in text replace functional|Bug|
|PDFNET-39639|Remove text underline in a PDF document|Bug|
|PDFNET-42086|Problem setting XmpPdfAExtensionValueType|Bug|
### **Public API changes in Aspose.PDF for .NET 17.10**
### **Added APIs:**
-----
Property Aspose.PDF.Document.Duplex
Constant Aspose.PDF.Facades.ViewerPreference.Simplex
Constant Aspose.PDF.Facades.ViewerPreference.DuplexFlipShortEdge
Constant Aspose.PDF.Facades.ViewerPreference.DuplexFlipLongEdge
Property Aspose.PDF.Image.IsApplyResolution
Enumeration field Aspose.PDF.ImageFileType.Dicom
Enumeration Aspose.PDF.PrintDuplex
Enumeration member Aspose.PDF.PrintDuplex.Simplex
Enumeration member Aspose.PDF.PrintDuplex.DuplexFlipShortEdge
Enumeration member Aspose.PDF.PrintDuplex.DuplexFlipLongEdge
Property Aspose.PDF.Row.VerticalAlignment
Property Aspose.PDF.Text.TextEditOptions.ToAttemptGetUnderlineFromSource
