---
title: Aspose.PDF for .NET 11.9.0 Release Notes
type: docs
weight: 50
url: /net/aspose-pdf-for-net-11-9-0-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNEWNET-35887|XFA form to Standard form type conversion issue|Bug|
|PDFNEWNET-40321|Formatting issues while filling XFA form|Bug|
|PDFNEWNET-39978|HTML to PDF - Style display: table-cell is not supported|Bug|
|PDFNEWNET-34614|HTML to PDF Loosing css attribute|Bug|
|PDFNEWNET-40281|PDF to DOCX: resultant DOCX with different page orientation is printed as portrait only|Bug|
|PDFNEWNET-40280|PDF to DOCX: extra space between text|Bug|
|PDFNEWNET-36083|XML to PDF: Tab stop issue|Bug|
|PDFNET-40916|Colors rendering difference in New Generator and Old Generator|Bug|
|PDFNET-41169|PDF to PDFA: Font style is incorrect|Bug|
|PDFNEWNET-37899|PDF to PDF/A - Some images appear as black in resultant file|Bug|
|PDFNET-41067|HTML to PDF: Image split across the pages|Bug|
|PDFNEWNET-40910|PDF to HTML - Missing character in resultant html|Bug|
|PDFNEWNET-40869|PDF To PPTX - Conversion is removing whitepsaces between words|Bug|
|PDFNET-41210|Content remain in portrait mode even when page is set to Landscape mode|Bug|
|PDFNEWNET-40804|Exception when trying to save font from PDF file|Bug|
|PDFNET-41039|PDF to PDF/A - Resultant file is not compliant|Bug|
|PDFNEWNET-40846|PDF/A compliance check fails|Bug|
### **Public API changes**
### **Added APIs:**
- Interface Aspose.PDF.GroupProcessor.IDocumentPageTextExtractor
- Property Aspose.PDF.GroupProcessor.IDocumentPageTextExtractor.PageCount
- Method Aspose.PDF.GroupProcessor.IDocumentPageTextExtractor.ExtractPageText(System.Int32)
- Interface Aspose.PDF.GroupProcessor.IDocumentTextExtractor
- Method Aspose.PDF.GroupProcessor.IDocumentTextExtractor.ExtractAllText
- Interface Aspose.PDF.GroupProcessor.IPdfTypeExtractor
- Property Aspose.PDF.GroupProcessor.IPdfTypeExtractor.PageCount
- Property Aspose.PDF.GroupProcessor.IPdfTypeExtractor.Version
- Property Aspose.PDF.GroupProcessor.IPdfTypeExtractor.IsFastExtractionUsed
- Method Aspose.PDF.GroupProcessor.IPdfTypeExtractor.ExtractAllText
- Method Aspose.PDF.GroupProcessor.IPdfTypeExtractor.ExtractPageText(System.Int32)
- Method Aspose.PDF.GroupProcessor.IPdfTypeExtractor.Dispose
### **Removed APIs:**
- Interface Aspose.PDF.GroupProcessor.Interfaces.IDocumentPageTextExtractor
- Property Aspose.PDF.GroupProcessor.Interfaces.IDocumentPageTextExtractor.PageCount  
MethodAspose.PDF.GroupProcessor.Interfaces.IDocumentPageTextExtractor.ExtractPageText(System.Int32)  
- Interface Aspose.PDF.GroupProcessor.Interfaces.IDocumentTextExtractor
- Method Aspose.PDF.GroupProcessor.Interfaces.IDocumentTextExtractor.ExtractAllText
- Interface Aspose.PDF.GroupProcessor.Interfaces.IPdfTypeExtractor
- Property Aspose.PDF.GroupProcessor.Interfaces.IPdfTypeExtractor.PageCount
- Property Aspose.PDF.GroupProcessor.Interfaces.IPdfTypeExtractor.Version
- Property Aspose.PDF.GroupProcessor.Interfaces.IPdfTypeExtractor.IsFastExtractionUsed
- Method Aspose.PDF.GroupProcessor.Interfaces.IPdfTypeExtractor.ExtractAllText
- Method Aspose.PDF.GroupProcessor.Interfaces.IPdfTypeExtractor.ExtractPageText(System.Int32)
- Method Aspose.PDF.GroupProcessor.Interfaces.IPdfTypeExtractor.Dispose

{{% alert color="primary" %}} 

The basic change is removal of **Interfaces** namespace.

{{% /alert %}}
