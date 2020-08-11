---
title: Aspose.PDF for .NET 18.9 Release Notes
type: docs
weight: 40
url: /net/aspose-pdf-for-net-18-9-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 18.9](https://www.nuget.org/packages/Aspose.Pdf/18.9.0)

{{% /alert %}} 
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-38535|Support of PDF to XLSX|New Feature|
|PDFNET-44643|PDF/UA: Validate Optional Content|New Feature|
|PDFNET-44644|PDF/UA: Validate Embedded Files|New Feature|
|PDFNET-44645|PDF/UA: Validate Acroform Fields (Digital Signatures)|New Feature|
|PDFNET-44646|PDF/UA: Validate Non-Interactive Forms and XFA|New Feature|
|PDFNET-44647|PDF/UA: Validate Security|New Feature|
|PDFNET-44648|PDF/UA: Validate Navigation|New Feature|
|PDFNET-44649|PDF/UA: Validate Annotations|New Feature|
|PDFNET-28514|Identify paragraphs that runs over multiple columns while extracting text|Enhancement|
|PDFNET-44617|Support Stream for loading PCL document|Enhancement|
|PDFNET-37635|Implement an option to suppress any text adjustment after replace.|Enhancement|
|PDFNET-41490|Implement Rectangle property for HtmlFragment object|Enhancement|
|PDFNET-45248|PDF/UA. Make validation/convertation log more informative|Enhancement|
|PDFNET-37896|PDF file is not properly being converted to PDF/A_1a format|Bug|
|PDFNET-39643|PDF to TIFF: resultant image is garbled|Bug|
|PDFNET-40423|PDF to TIF conversion results a blank image|Bug|
|PDFNET-40567|PDF to TIFF: some contents are lost in resultant image|Bug|
|PDFNET-41134|PDF to TIFF: text is missing in resultant image|Bug|
|PDFNET-41445|PDF to TIF: resultant Multipage TIF image is blank after first page|Bug|
|PDFNET-41847|PDF to TIFF - Resultant image is corrupted|Bug|
|PDFNET-42520|Word document been cut off when print.|Bug|
|PDFNET-42532|PDF to PDFA Conversion process hangs up|Bug|
|PDFNET-42533|PDF to PDFA Conversion process hangs up|Bug|
|PDFNET-43033|PDF to TIFF - The output file is empty.|Bug|
|PDFNET-43252|PDF to TIFF - an empty TIFF is generated|Bug|
|PDFNET-43636|The performance degradation while converting PDF to PDFA_1A|Bug|
|PDFNET-43821|Problem with using ReplaceAdjustment.WholeWordsHyphenation option|Bug|
|PDFNET-44007|Images are missing when saving as image or HTML|Bug|
|PDFNET-44081|PDF to PPTX - the highlighted color of text is not being removed|Bug|
|PDFNET-44206|Aspose.Pdf 18.2: Exception when trying to open particular XPS|Bug|
|PDFNET-44227|Black background added on fields when flattening|Bug|
|PDFNET-44690|PDF to XPS - the redaction and additional blank pages are being added|Bug|
|PDFNET-44783|The method RedactArea throws an exception.|Bug|
|PDFNET-44825|An exception raises while flattening the document|Bug|
|PDFNET-44842|Text is shifted over while replacing the text|Bug|
|PDFNET-44892|PostScript to PDF - Program hangs at document loading|Bug|
|PDFNET-44930|HTML to PDF - incorrect page size|Bug|
|PDFNET-44966|A generic error occurred in GDI+ when saving PDF as HTML|Bug|
|PDFNET-44987|After adding new paragraph to page, saving of PDF document throws System.Exception - Cannot instantiate Artifact class|Bug|
|PDFNET-45017|Rotation doesn't work for EPUB|Bug|
|PDFNET-45042|Incorrect rendering of PDF document to HTML|Bug|
|PDFNET-45043|The conversion PDF to PDFA_1A hangs.|Bug|
|PDFNET-45086|The exception raises while applying the text stamp|Bug|
|PDFNET-45096|Some columns are missing when using the repeating columns feature|Bug|
|PDFNET-45098|The repeating columns behave inconsistently when spanned|Bug|
|PDFNET-45109|Input string was not in correct format exception when CSS URL contains curly bracket|Bug|
|PDFNET-45128|When TIFF image is inserted to PDF, then the picture is rotated.|Bug|
|PDFNET-45147|PDF file is not properly being converted to PDF/A_1b format|Bug|
|PDFNET-45191|An inconsistent text content in TextFragment collection|Bug|
|PDFNET-45228|An execution hangs when HtmlFragment is inserted|Bug|
|PDFNET-45295|PDF to XPS - the redaction and additional blank pages are being added|Bug|
### **Public API changes in Aspose.PDF for .NET 18.9**
-----
### **Added APIs:**
Property Aspose.Pdf.ExcelSaveOptions.Format                                  
Enumeration Aspose.Pdf.ExcelSaveOptions.ExcelFormat                             
Enumeration member Aspose.Pdf.ExcelSaveOptions.ExcelFormat.XMLSpreadSheet2003          
Enumeration member Aspose.Pdf.ExcelSaveOptions.ExcelFormat.XLSX                        
Property Aspose.Pdf.HtmlFragment.Rectangle                                   
Property Aspose.Pdf.Matrix.Data                                              
Enumeration member Aspose.Pdf.Text.TextReplaceOptions.ReplaceAdjustment.ShiftRestOfLine
Property Aspose.Pdf.Text.PageMarkup.IsMulticolumnParagraphsAllowed
