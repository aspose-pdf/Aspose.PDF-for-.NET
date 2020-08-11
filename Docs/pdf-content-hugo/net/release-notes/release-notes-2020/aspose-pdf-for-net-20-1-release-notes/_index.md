---
title: Aspose.PDF for .NET 20.1 Release Notes
type: docs
weight: 50
url: /net/aspose-pdf-for-net-20-1-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PDF for .NET 20.1.

{{% /alert %}} 
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-42062 |HTML to PDF: inline SVG image is not rendering|Enhancement|
|PDFNET-47419 |Clarification required on Image Delete Mechanism in the API|Enhancement|
|PDFNET-43638 |Extracting the text content from stamp annotation|Enhancement|
|PDFNET-33628 |Unknown image type : Jpeg exception is occurring when trying to add 8 BPP JPG to PDF|Bug|
|PDFNET-34282 |OutOfMemoryException is occurring during HTML to PDF conversion|Bug|
|PDFNET-35760 |HTML to PDF- contents are appearing twice|Bug|
|PDFNET-36509 |HTML to PDF - Formatting issues in resultant file|Bug|
|PDFNET-37123 |HTML to PDF - ArgumentNullException is occurring|Bug|
|PDFNET-37213 |HTML to PDF - Anchor tag is not being honored|Bug|
|PDFNET-37505 |PDF to HML - NullReferenceException during conversion|Bug|
|PDFNET-37697 |HTML to PDF - Resultant file is blank|Bug|
|PDFNET-38093 |HTML to PDF: Tables are incorrectly rendered|Bug|
|PDFNET-38202 |Html to PDF conversion throws OutOfMemoryException|Bug|
|PDFNET-38482 |HTML to PDF conversion throws IndexOutOfRangeException|Bug|
|PDFNET-39625 |PDF to Image conversion throws NullReferenceException|Bug|
|PDFNET-39941 |SVG to PDF:Base 64 image is not rendering in resultant PDF|Bug|
|PDFNET-40480 |PDF to PNG: conversion throws NullReferenceException|Bug|
|PDFNET-40508 |HTML to PDF - Exception during conversion|Bug|
|PDFNET-40604 |PDF to PDFA throws OutOfMemoryException|Bug|
|PDFNET-40728 |Specific page extraction throws NullReference Exception|Bug|
|PDFNET-42110 |Unable to convert page to HTML and save it to stream.|Bug|
|PDFNET-44264 |NullReference exception on flattening annotation|Bug|
|PDFNET-44934 |PCL to PDF - Program hangs keeps running without generating file|Bug|
|PDFNET-44958 |Colspan Column Text is being duplicated in case of wide table|Bug|
|PDFNET-44982 |XmlException on PDF to HTML|Bug|
|PDFNET-45575 |API is taking more time to fill form fields|Bug|
|PDFNET-45928 |An exception occurs when reading a document with redaction annotation and popup annotation|Bug|
|PDFNET-46564 |System.NullReferenceException occured after Hocr conversion in save method|Bug|
|PDFNET-46890 |An issue with conversion PDF into HTML with missing font|Bug|
|PDFNET-46933 |Exception CrossTableNotFoundException while getting the page|Bug|
|PDFNET-46938 |NullReferenceException on parsing annotation with 3D content|Bug|
|PDFNET-47091 |Problem converting PDF to HTML|Bug|
|PDFNET-47181 |PDF to DOC font are saved incorrectly|Bug|
|PDFNET-47193 |PDF to HTML gives incorrect characters|Bug|
|PDFNET-47231 |HTML to PDF links issue|Bug|
|PDFNET-47246 |Exception when accessing page annotations of PDF document with 3D object|Bug|
|PDFNET-47340 |Import from XFDF issue|Bug|
|PDFNET-47342 |Exception when opening LaTeX file|Bug|
|PDFNET-47353 |Exception when saving PDF into HTML|Bug|
|PDFNET-47355 |PDF to DOC - StackOverFlow Exception occurs|Bug|
|PDFNET-47378 |NullPointerException Since 19.8 version|Bug|
|PDFNET-47439 |Unable to cast object exception when opening PCL file|Bug|
|PDFNET-47444 |TOC pages order backward|Bug|
|PDFNET-43324|Cannot add hyperlink to Non-keyboard special characters|Bug|
|PDFNET-43289 |PDF to XLS - Problem During Load|Bug|
## **Public API and Backward Incompatible Changes**
**Added APIs**

- Enumeration Aspose.Pdf.ImageDeleteAction
- Enumeration member Aspose.Pdf.ImageDeleteAction.None
- Enumeration member Aspose.Pdf.ImageDeleteAction.ForceDelete
- Enumeration member Aspose.Pdf.ImageDeleteAction.Check
- Method Aspose.Pdf.XImageCollection.Delete(System.Int32,Aspose.Pdf.ImageDeleteAction)
- Method Aspose.Pdf.XImageCollection.Delete(System.String,Aspose.Pdf.ImageDeleteAction)
- Property Aspose.Pdf.Form.AutoRecalculate
