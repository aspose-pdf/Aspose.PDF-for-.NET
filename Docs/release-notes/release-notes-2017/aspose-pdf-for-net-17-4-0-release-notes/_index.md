---
title: Aspose.PDF for .NET 17.4.0 Release Notes
type: docs
weight: 90
url: /net/aspose-pdf-for-net-17-4-0-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-41726|The flattened file from XFA form cannot be opened in Chrome or Firefox.|Enhancement|
|PDFNET-41871|Create separate local links for duplicate text|Enhancement|
|PDFNET-42307|NullReferenceException is thrown when trying to get artifact text|Exception|
|PDFNET-42308|ArgumentException is thrown when trying to get artifact text|Exception|
|PDFNET-38546|Exception when trying to load PDF document|Exception|
|PDFNET-37717|Exception when trying to get signature names|Exception|
|PDFNET-40863|Exception thrown when trying to get the names of the fields in a form|Exception|
|PDFNET-40776|PDF to PDFA conversion performance issue|Bug|
|PDFNET-42200|Failed to validate PDF_X_3 and PDF_X_1A|Bug|
|PDFNET-42332|Stamp looks incorrect when size and rotate angle are set|Bug|
|PDFNET-42415|Convert Web Page to PDF - bad layout|Bug|
|PDFNET-42355|When PDF is converted to PDF_A_1B, the text looks different|Bug|
|PDFNET-42271|For Helvetica and Courier fonts, page number in the TOC entry is missing|Bug|
|PDFNET-42388|When PDF is converted to DOCX, the text is missing.(converted to image)|Bug|
|PDFNET-40912|Images not rendered to next page|Bug|
|PDFNET-40140|PDF to PDFA1b conversion results in-compliant PDFA document|Bug|
## **Public API Changes**
#### **Added API's**
Exception Aspose.PDF.FontEmbeddingException
Constructor Aspose.PDF.FontEmbeddingException(System.String)
Constructor Aspose.PDF.FontEmbeddingException(System.String,System.Exception)
Constructor Aspose.PDF.FontEmbeddingException(System.Exception)
Interface Aspose.PDF.Text.IFontOptions
Property Aspose.PDF.Text.IFontOptions.NotifyAboutFontEmbeddingError
Property Aspose.PDF.UnifiedSaveOptions.ExtractOcrSublayerOnly
