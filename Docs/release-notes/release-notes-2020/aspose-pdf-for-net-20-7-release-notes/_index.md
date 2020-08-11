---
title: Aspose.PDF for .NET 20.7 Release Notes
type: docs
weight: 60
url: /net/aspose-pdf-for-net-20-7-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PDF for .NET 20.7.

{{% /alert %}} 
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-48474|PDF to CSV conversion support|New Feature|
|PDFNET-48396|Change XImage.Name results corrupted PDF document|Enhancement|
|PDFNET-41385|TextSegment formatting issues|Bug|
|PDFNET-44283|Exception while creating JPEG image|Bug|
|PDFNET-45406|Aspose.PDF makes PDFA file 30 times bigger than Adobe does|Bug|
|PDFNET-47029|TextSegments are ignoring specified styles when using a line break|Bug|
|PDFNET-47223|PDF to HTML-OutOfMemoryException occurs while converting|Bug|
|PDFNET-47443|Collection was modified; enumeration operation may not execute|Bug|
|PDFNET-47877|High memory consumption on generating PDF document|Bug|
|PDFNET-47879|High CPU usage during PDF generation|Bug|
|PDFNET-47927|InvalidCastException on Annotation.get_Modified()|Bug|
|PDFNET-48011|Exception on converting PDF into DOC|Bug|
|PDFNET-48040|PDF to PDF/A-2b conversion|Bug|
|PDFNET-48098|Exception on converting PDF to PPTX|Bug|
|PDFNET-48107|Exception on converting HTML text into PDF|Bug|
|PDFNET-48156|PDF to HTML-RemoveEmptyAreasOnTopAndBottom property  is not making <br/> any difference when set true or false|Bug|
|PDFNET-48232|Concatenate PDF files - System.ArgumentException|Bug|
|PDFNET-48343|Hyperlink in HTML fragment is not working [Regression]|Bug|
|PDFNET-48368|Reading the large set of random data (masked as PDF document) lead to <br/> hangs on Aspose.PDF|Bug|
|PDFNET-48372|TextFragment overrides TextSegment.FontStlye when page breakline is used|Bug|
|PDFNET-48384|Conversion to DOCX on the docker throws the NullReferenceException|Bug|
|PDFNET-48386|API is taking long time while concatenating large PDF files|Bug|
|PDFNET-48409|On conversion to HTML additional chars appear|Bug|
|PDFNET-48438|After extracting pages some content is missing|Bug|
|PDFNET-48439|After extracting pages some content is missing|Bug|
|PDFNET-48440|After extracting pages some content is missing|Bug|
|PDFNET-48441|After extracting pages some content is missing|Bug|
|PDFNET-48442|After extracting pages some content is missing|Bug|
|PDFNET-48475|After extracting pages some content is missing|Bug|
## **Public API and Backward Incompatible Changes**
### **Added APIs**
- Enumeration Aspose.Pdf.ConvertSoftMaskAction
- Enumeration member Aspose.Pdf.ConvertSoftMaskAction.Default
- Enumeration member Aspose.Pdf.ConvertSoftMaskAction.ConvertToStencilMask
- Enumeration member Aspose.Pdf.ImageDeleteAction.KeepContents
- Property Aspose.Pdf.PdfFormatConversionOptions.ConvertSoftMaskAction
- Method Aspose.Pdf.XImage.Rename(System.String)
- Enumeration member Aspose.Pdf.ExcelSaveOptions.ExcelFormat.CSV