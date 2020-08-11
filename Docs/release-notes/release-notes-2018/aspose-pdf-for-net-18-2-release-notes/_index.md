---
title: Aspose.PDF for .NET 18.2 Release Notes
type: docs
weight: 110
url: /net/aspose-pdf-for-net-18-2-release-notes/
---

## **Release Notes of Aspose.PDF for .NET 18.2**
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-40515|Adding support for repeating columns in Aspose.Pdf.Table|New Feature|
|PDFNET-44065|Support for DSA while signing|New Feature|
|PDFNET-42833|Get rotation angle of Text Character|New Feature|
|PDFNET-40240|Get text rotate angle information|New Feature|
|PDFNET-37189|Creating NamedDestination in existing PDF|Enhancement|
|PDFNET-38589|Support of Text RotatingAngle property in new generator|Enhancement|
|PDFNET-43695|An exception("A generic error occurred in GDI+.") <br>raises when the image data is passed in byte[] format |Bug|
|PDFNET-42801|Performance issue on printing a PDF document|Bug|
|PDFNET-41071|How to set default font name in PDF to HTML|Bug|
|PDFNET-38589|Support of Text RotatingAngle property in new generator|Bug|
|PDFNET-43940|Aspose.PDF 17.12: Opening particular XPS cause null reference exception|Bug|
|PDFNET-38799|PDF to HTML: conversion loses background color |Bug|
|PDFNET-43853|The text with characters spacing not recognized by TextFragmentAbsorber Regex |Bug|
|PDFNET-36779|PDF to PDFA conversions fails |Bug|
|PDFNET-43255|Aspose.PDF 17.08 Incorrect digital signing with DSA certificate |Bug|
|PDFNET-42602|Unable to normalise secured pdf |Bug|
|PDFNET-43415|Encrypt and Sign PDF|Bug|
|PDFNET-40127|PDF security issues - signing an encrypted PDF document |Bug|
|PDFNET-43762|Pdf/a conversion creates subsections in Xref table |Bug|
|PDFNET-41678|Signature becomes corrupted when signing the PDF file|Bug|
|PDFNET-44032|Sign a password protected PDF file|Bug|
|PDFNET-38480|Signature is corrupted when added to Encrypted PDF file|Bug|
|PDFNET-43892|Pdf generation fails with HTMLFragment content|Bug|
|PDFNET-44074|Document.GetObjectById() returns null|Bug|
|PDFNET-43955|PDF to JPG - Output images are not correct|Bug|
|PDFNET-43232|Some text at the top of the page is corrupted after conversion to HTML|Bug|
|PDFNET-44017|Heading appears twice in TOC |Bug|
|PDFNET-43836|Generated PDF output do not pass 'Report PDF syntax issues' check.|Bug|
|PDFNET-44087|Could not load file or assembly 'Aspose.JavaScript, Version=17.4.0.0 |Bug|
|PDFNET-42972|Incorrect characters when saving as HTML or image|Bug|
|PDFNET-38501|PDF to PDF/A - Exception during conversion |Bug|
|PDFNET-43772|Font is not embedded correctly|Bug|
|PDFNET-41155|PDF to PDFA: Vertical text renders in different order|Bug|
|PDFNET-39213|PDF to HTML: Some Chinese characters are not rendered correctly|Bug|
### **Public API changes in Aspose.PDF for .NET 18.2**
### **Added APIs:**
-----
Constructor Aspose.Pdf.Annotations.GoToAction(Aspose.Pdf.Document,System.String)
Constructor Aspose.Pdf.Annotations.NamedDestination(Aspose.Pdf.Document,System.String)
Property Aspose.Pdf.Document.NamedDestinations
Property Aspose.Pdf.HtmlSaveOptions.DefaultFontName
Interface Aspose.Pdf.INamedDestinationCollection
Property Aspose.Pdf.INamedDestinationCollection.ItemSystem.String
Property Aspose.Pdf.INamedDestinationCollection.Count
Property Aspose.Pdf.INamedDestinationCollection.Names
Method Aspose.Pdf.INamedDestinationCollection.Remove(System.String)
Method Aspose.Pdf.INamedDestinationCollection.Add(System.String,Aspose.Pdf.Annotations.IAppointment)
Class Aspose.Pdf.NamedDestinationCollection
Property Aspose.Pdf.NamedDestinationCollection.ItemSystem.String
Property Aspose.Pdf.NamedDestinationCollection.Count
Property Aspose.Pdf.NamedDestinationCollection.Names
Method Aspose.Pdf.NamedDestinationCollection.Remove(System.String)
Method Aspose.Pdf.NamedDestinationCollection.Add(System.String,Aspose.Pdf.Annotations.IAppointment)
Property Aspose.Pdf.PdfFormatConversionOptions.NotAccessibleFonts
Property Aspose.Pdf.RenderingOptions.MaxFontsCacheSize
Property Aspose.Pdf.RenderingOptions.MaxSymbolsCacheSize
Property Aspose.Pdf.Table.RepeatingColumnsCount
