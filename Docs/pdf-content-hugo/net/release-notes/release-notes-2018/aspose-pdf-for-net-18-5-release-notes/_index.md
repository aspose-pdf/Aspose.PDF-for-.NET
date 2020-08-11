---
title: Aspose.PDF for .NET 18.5 Release Notes
type: docs
weight: 80
url: /net/aspose-pdf-for-net-18-5-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 18.5](https://www.nuget.org/packages/Aspose.Pdf/18.5.0)

{{% /alert %}} 
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-44405|DefaultFontName setting when saving Pdf as Pdf|New Feature|
|PDFNET-44576|Implement functionality to get all fonts from document|New Feature|
|PDFNET-38034|Support HTML tags inside table element|New Feature|
|PDFNET-40200|HtmlFragment Performance issue|Enhancement|
|PDFNET-44492|PDF to PDF/A-3A - resultant PDF is not showing correct version|Bug|
|PDFNET-44418|Import XFDF to PDF - the line element is not being recognized|Bug|
|PDFNET-44415|Problem adding image on layers|Bug|
|PDFNET-44348|Problem with Fonts while Optimizing a PDF|Bug|
|PDFNET-44406|DefaultFontName setting not working when value is changed|Bug|
|PDFNET-44419|Incorrect text color when saving PDF|Bug|
|PDFNET-44383|Evaluation watermark is not visible when saving PDF document|Bug|
|PDFNET-44382|Evaluation watermar is missing when saving LaTeX and PostScript documents|Bug|
|PDFNET-44482|An exception is thrown while accepting TextFragmentAbsorbed object|Bug|
|PDFNET-39635|Unable to search Arabic text using TextFragmentAbsorber|Bug|
|PDFNET-36510|Not all TextFragments are being replaced inside PDF|Bug|
|PDFNET-36518|Not all instances of text are being replaced|Bug|
|PDFNET-36582|Regular expression is not searching second occurrence on same line|Bug|
|PDFNET-44363|Aspose Pdf 18.3 Exception throws when saving password protected signed files|Bug|
|PDFNET-44214|GDI+ Exception when generating PDF with images loaded from HTML file|Bug|
|PDFNET-44165|PDF to PDF/A-1b - the output PDF does not pass compliance test|Bug|
|PDFNET-42837|GDI+ exception when adding Image inside PDF in WPF application|Bug|
|PDFNET-42860|PDF to PDF/A - Conversion process takes too much time|Bug|
|PDFNET-37248|GetNextImage produces black rectangle on the image|Bug|
|PDFNET-44484|The footer content is flipped after adding HtmlFragment|Bug|
|PDFNET-44341|Output PDF - Incorrect rendering of the Header HTML on the second page|Bug|
|PDFNET-44487|FloatingBox columns placed incorrectly when ColumnSpacing property is unset|Bug|
|PDFNET-38438|Formatting issues when placing large HTML contents inside table cell|Bug|
|PDFNET-38861|Using IsInLineParagraph with TextFragment and HtmlFragment|Bug|
|PDFNET-44090|Redacting a PDF throws exception|Bug|
|PDFNET-43949|Field not redacted|Bug|
|PDFNET-44428|The input PDF throws an error on retrieving color type of the Page|Bug|
|PDFNET-44450|An error occurred on removing JavaScript from PDF|Bug|
|PDFNET-44079|PDF To HTML: some text is missing|Bug|
### **Public API changes in Aspose.PDF for .NET 18.5**
### **Added APIs:**
-----
Method Aspose.Pdf.Rectangle.Contains(Aspose.Pdf.Point)
Method Aspose.Pdf.Rectangle.Center
Method Aspose.Pdf.Document.IDocumentFontUtilities.GetAllFonts
Method Aspose.Pdf.Heading.CloneWithSegments
Enumeration member Aspose.Pdf.ImageFileType.Base64
Property Aspose.Pdf.PdfSaveOptions.DefaultFontName
