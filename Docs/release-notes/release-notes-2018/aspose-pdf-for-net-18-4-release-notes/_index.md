---
title: Aspose.PDF for .NET 18.4 Release Notes
type: docs
weight: 90
url: /net/aspose-pdf-for-net-18-4-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 18.4](https://www.nuget.org/packages/Aspose.Pdf/18.4.0)

{{% /alert %}} 
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-37251|Determine the line break scenario|New Feature|
|PDFNET-44339|Text shadow indent is different when saving as HTML|Enhancement|
|PDFNET-40048|Update TextFragment clone procedure for segments formatting support|Enhancement|
|PDFNET-34399|Text is aligned to left instead of being aligned to right (Convert Hebrew PDF to HTML)|Bug|
|PDFNET-36415|Text position issue: API returns LLX and URX values same for vertical text.|Bug|
|PDFNET-36416|Text position issue: API returns incorrect position values (LLX,LLY,URX,URY)|Bug|
|PDFNET-36436|Drawing box around text content is not correct|Bug|
|PDFNET-37471|When using htmlOptions.FixedLayout = false, images/svg files are missing.|Bug|
|PDFNET-38015|PDF to HTML: text formatting issue|Bug|
|PDFNET-40092|PDF to PDFA2a: Converting PDF, generated from Aspose.Cells, to PDFA2a fails the compliance|Bug|
|PDFNET-40270|Text is not auto wrapped to subsequent lines when reaching right page margin|Bug|
|PDFNET-41998|PDF to Excel: special characters ">, <" encoding issue|Bug|
|PDFNET-42420|When specific PDF is converted to DOCX, System.ArgumentException occurs|Bug|
|PDFNET-43024|Content is missing when saving PDF as HTML|Bug|
|PDFNET-43225|PDF to XLS export produces an invalid XML|Bug|
|PDFNET-43237|Some images omitted while converting PDF document to HTML output|Bug|
|PDFNET-43702|RedactArea corrupts the PDF if with SetLicense method|Bug|
|PDFNET-44015|NullReferenceException while generating jpg image|Bug|
|PDFNET-44105|An exception raises while loading document from HTML file|Bug|
|PDFNET-44157|PDF to image - Aspose.Pdf export shows error in Docker|Bug|
|PDFNET-44184|Latex fragments consume too much memory|Bug|
|PDFNET-44223|TOC heading is missing when adding HtmlFragment|Bug|
|PDFNET-44225|TOC headings get mixed when generating PDF output.|Bug|
|PDFNET-44226|An exception raises while saving PDF with TOC headings|Bug|
|PDFNET-44286|HTML import - fails to import the document|Bug|
|PDFNET-44362|Link with external url in pdf document is not rendered as hyperlink when saving page by page|Bug|
|PDFNET-44367|StackOverflow error occurs when retrieving content|Bug|
|PDFNET-44409|In some headings a part of the text is formatted with noticeable smaller font size.|Bug|
|PDFNET-44410|Unexpected headings appear in the generated output PDF|Bug|
|PDFNET-44411|The heading is missing in the generated PDF output|Bug|
|PDFNET-40160|TextFragmentAbsorber out of memory issue |Bug|
|PDFEXTNET-40111|An exception raises while loading document from HTML file|Bug|
### **Public API changes in Aspose.PDF for .NET 18.4**
### **Added APIs:**
-----
Property Aspose.Pdf.HtmlLoadOptions.HtmlMediaType  
Enumeration Aspose.Pdf.HtmlMediaType  
Enumeration member Aspose.Pdf.HtmlMediaType.Print  
Enumeration member Aspose.Pdf.HtmlMediaType.Screen  
Method Aspose.Pdf.Page.GetNotifications  
Property Aspose.Pdf.Text.MarkupParagraph.Text  
Method Aspose.Pdf.Text.TextFragmentAbsorber.Reset  
