---
title: Aspose.PDF for .NET 18.8 Release Notes
type: docs
weight: 50
url: /net/aspose-pdf-for-net-18-8-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 18.8](http://nuget.org/packages/Aspose.Pdf/18.8.0)

{{% /alert %}} 
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-45057|Add Replace image feature in ImagePlacementAbsorber|New Feature|
|PDFNET-44639|PDF/UA: Validate Headings|New Feature|
|PDFNET-44640|PDF/UA: Validate Tables|New Feature|
|PDFNET-44641|PDF/UA: Validate Lists|New Feature|
|PDFNET-44642|PDF/UA: Validate Notes and References|New Feature|
|PDFNET-45069|PDF/UA: Writing correct file name attribute to validation log file|New Feature|
|PDFNET-44955|PDF/UA: Add Warning and Manual check levels to validation log|New Feature|
|PDFNET-44462|Track word wrapping / line breaking in scenarios of editing documents.|Enhancement|
|PDFNET-44823|PDF to PPTX - the low quality of image|Enhancement|
|PDFNET-42857|PDF to PPTX - Too many text boxes in resultant file|Bug|
|PDFNET-45110|Text fragments are not matched by the regex.|Bug|
|PDFNET-43922|Text overlaps after replace operation and doubles|Bug|
|PDFNET-40692|Text overlaps after replace operation|Bug|
|PDFNET-44936|When saving document as image first page is filled with black color|Bug|
|PDFNET-44756|Error and missing image in PDF after inserting BW image|Bug|
|PDFNET-44029|JPEG to PDF: Inserted image is invisible|Bug|
|PDFNET-44177|PDF to JPG - Logo is missing|Bug|
|PDFNET-45061|PDF to TIFF - incorrect output|Bug|
|PDFNET-42590|SVG images are not sizing properly|Bug|
|PDFNET-44834|PDF to TIFF - NullReferenceException|Bug|
|PDFNET-44877|When PDF is saved as TIF, a NullReferenceException occurs|Bug|
|PDFNET-42748|SVG image is not visible when adding in table|Bug|
|PDFNET-44983|Problem rendering Chinese text|Bug|
|PDFNET-44986|After conversion PDF-to-PDFA the output is not compliant|Bug|
|PDFNET-44976|Some items are missing in TOC.|Bug|
|PDFNET-39285|PDF to PDF/A_2b - Resultant file is not complaint|Bug|
|PDFNET-39284|PDF to PDF/A_1b - Resultant file is not complaint|Bug|
|PDFNET-42527|PDF to PDFA Conversion process hangs up|Bug|
|PDFNET-42528|PDF to PDFA Conversion process hangs up|Bug|
|PDFNET-43336|NullReferenceException occurs when trying to add <br>attachment to a pdf file that does not contain attachments|Bug|
|PDFNET-44611|All pages have null value.|Bug|
|PDFNET-44941|The image isn't shown while loading PDF from HTML file.|Bug|
|PDFNET-41857|PDF to PDF/A - Resultant file is not compliant|Bug|
|PDFNET-44255|Text strikeout works incorrect in some scenarios of use multiline text fragments.|Bug|
|PDFNET-37869|TextFragmentAbsrober throws exception:Index and <br>length must refer to a location within the string|Bug|
### **Public API changes in Aspose.PDF for .NET 18.8**


{{% alert color="primary" %}} 

FontSubsetStrategy enumeration has been moved under Aspose.Pdf namespace.
{{% /alert %}} 

-----
### **Added APIs:**
Method Aspose.Pdf.ImagePlacement.Replace(System.IO.Stream)

Property Aspose.Pdf.PptxSaveOptions.RecognizeTextColumns

Method Aspose.Pdf.XImage.ToStream
