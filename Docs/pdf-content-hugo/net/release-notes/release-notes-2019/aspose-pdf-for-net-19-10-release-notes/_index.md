---
title: Aspose.PDF for .NET 19.10 Release Notes
type: docs
weight: 30
url: /net/aspose-pdf-for-net-19-10-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for Aspose.PDF for .NET 19.10.

{{% /alert %}} 
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-42386|[.NET Regex object](/pdf/net/search-and-get-text-from-pages-of-a-pdf-document/#searchandgettextfrompagesofapdfdocument-searchingtextwith-netregex) instead of string in TextFragmentAbsorber|New Feature|
|PDFNET-46423|Support for .NET Core 3.0|New Feature|
|PDFNET-46246|Default font to be used when font is missing for PCL|Enhancement|
|PDFNET-46265|The tables are not properly aligned in the output XLSX|Bug|
|PDFNET-46957|PDF to SVG - Change the resultant image for 72 DPI settings|Bug|
|PDFNET-46999|Fix default value of PdfFormat to avoid confusion|Bug|
|PDFNET-43010|Replacing Text disturbs Position of Other Text|Bug|
|PDFNET-42939|System.ArgumentException Exception occurs while extracting text|Bug|
|PDFNET-46962|Highlighting Property of Annotation is not working|Bug|
|PDFNET-46936|After rendition from HTML the output gets headers on the fourth and sixth page|Bug|
|PDFNET-46930|Conversion to HTML throws System.IndexOutOfRangeException|Bug|
|PDFNET-43473|PDF to PDF/A-1b - the output PDF does not pass validation|Bug|
|PDFNET-42708|Black boxes are generated on replacing text in PDF|Bug|
|PDFNET-39106|PDF to TIFF - Form field values are missing over resultant image|Bug|
|PDFNET-38843|Application hangs when opening PDF document|Bug|
|PDFNET-39318|Image to PDF - Exception when trying to place image inside PDF file|Bug|
|PDFNET-40524|HTML to PDF/A_3b - Text is garbled in resultant file|Bug|
|PDFNET-40388|PDF to PDF/A - Resultant file is not compliant|Bug|
|PDFNET-40638|PDF to PDF/A3b - Resultant file is not compliant.|Bug|
|PDFNET-39256|API throws InvalidCasException upon saving PDF document|Bug|
|PDFNET-38871|PDF is throwing NullReferenceException|Bug|
|PDFNET-39452|PDF to SVG: resultant SVG documents are wrong|Bug|
|PDFNET-39411|InvalidCastException error message on ExtractAnnotations|Bug|
|PDFNET-39573|PdfFileInfo throws CrossTableNotFoundException|Bug|
|PDFNET-38920|Loading PDF file API throws Cross-reference table exception|Bug|
|PDFNET-39061 |Loading a PDF document API throws Cross-reference table exception|Bug|
|PDFNET-38047 |HTML to PDF: Thorws XMLException|Bug|
|PDFNET-40934|HTML to PDF: formatting is incorrect|Bug|
|PDFNET-38333|HTML to PDF: difference in table widths|Bug|
|PDFNET-46746|Non-compliant PDF/A-2u output|Bug|
|PDFNET-46897|Non-compliant PDF/A-1b output|Bug|
|PDFNET-46313|PDF to DOCX - Text is shifted upwards|Bug|
|PDFNET-45210 |Merging PDF Documents - issue with radio buttons in output|Bug|
|PDFNET-45500 |Unable to load PCL document on Windows Server 2016|Bug|
|PDFNET-45641 |Wrong rendering of the PCL file|Bug|
|PDFNET-46932 |Formatting is lost after conversion from MHT|Bug|
|PDFNET-46393|PDF to TIFF - Lines are missing when the resolution is less than 300 dpi|Bug|
|PDFNET-46997|Aspose.Pdf 19.9: Saving particular PDF to DOCX produces output that doesn't look good on some MAC machines|Bug|
|PDFNET-45837|The output XLSX file isn't the same as source PDF|Bug|
|PDFNET-46314|PDF to DOCX - Text is shifted to left|Bug|
### **Public API changes in Aspose.PDF for .NET 19.10**
-----
See the list of any changes made to the public API such as added, renamed, removed or deprecated members as well as any non-backward compatible change made to Aspose.PDF for .NET. If you have concerns about any change listed, please raise it on the [Aspose.PDF support forum](https://forum.aspose.com/c/pdf).
### **Added APIs**
Following new APIs were added.

- Property Aspose.Pdf.MhtLoadOptions.PageInfo                                                                                
- Constructor Aspose.Pdf.Text.TextFragmentAbsorber(System.Text.RegularExpressions.Regex)                                  
- Constructor Aspose.Pdf.Text.TextFragmentAbsorber(System.Text.RegularExpressions.Regex,Aspose.Pdf.Text.TextSearchOptions)
- Constructor Aspose.Pdf.Text.TextFragmentAbsorber(System.Text.RegularExpressions.Regex,Aspose.Pdf.Text.TextEditOptions) 
- Property SvgSaveOptions.ScaleToPixel
- Property Aspose.Pdf.ExcelSaveOptions.ConversionEngine              
- Enumeration Aspose.Pdf.ExcelSaveOptions.ConversionEngines
- Enumeration member Aspose.Pdf.ExcelSaveOptions.ConversionEngines.LegacyEngine
- Enumeration member Aspose.Pdf.ExcelSaveOptions.ConversionEngines.NewEngine
- Property Aspose.Pdf.RenderingOptions.OptimizeDimensions
### **Removed APIs**
- Property Aspose.Pdf.HtmlLoadOptions.isPdfUaConverting
