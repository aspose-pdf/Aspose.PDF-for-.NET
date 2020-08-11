---
title: Aspose.PDF for .NET 11.8.0 Release Notes
type: docs
weight: 60
url: /net/aspose-pdf-for-net-11-8-0-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNEWNET-37115|PDF to PDF/A - Replace missing Font with alternative Font|Enhancement|
|PDFNEWNET-40563|Unable to add page to PDF file|Exception|
|PDFNEWNET-40552|PDF to PDF/A - Exception during conversion|Exception|
|PDFNEWNET-40275|PDF to PDF/A - Exception during conversion|Exception|
|PDFNEWNET-38460|Exception while converting XFA pdf to a standard PDF|Exception|
|PDFNEWNET-36244|NullReferenceException during XFA to Standard Acro form conversion|Exception|
|PDFNEWNET-40694|API throws NullReference Exception on loading PDF document|Exception|
|PDFNEWNET-40566|Large PDF to PDFA throws OutOfMemory Exception|Exception|
|PDFNEWNET-40229|NullReferenceException while redacting second occurrence of text on same page|Exception|
|PDFNEWNET-39277|InvalidCastException when trying to convert PDF 1.3 document with Aspose.PDF 10.7|Exception|
|PDFNEWNET-40792|API throws System Exception upon loading PDF document in 11.6.0|Exception|
|PDFNEWNET-40791|API throws System Exception upon loading PDF document in 11.6.0|Exception|
|PDFNEWNET-40790|API throws System Exception upon loading PDF document in 11.6.0|Exception|
|PDFNEWNET-40789|API throws System Exception upon loading PDF document in 11.6.0|Exception|
|PDFNEWNET-40362|PDF to PDFA problem with transparent images after conversion|Bug|
|PDFNEWNET-40772|EPUB to PDF conversion throws the operation not supported error|Bug|
|PDFNEWNET-40686|Regression: Document fonts changed on save|Bug|
|PDFNEWNET-40677|Flatten method results a corrupt PDF with 11.5.0|Bug|
|PDFNEWNET-38420|PDF to Doc: Redundant characters before and after bullet items|Bug|
|PDFNEWNET-40581|XSL-FO to PDF - Resultant file has formatting issues|Bug|
|PDFNEWNET-35275|Issue in converting PDF to HTML|Bug|
|PDFNEWNET-40862|PDF to PDF/A - Issue with images|Bug|
|PDFNEWNET-40528|PDF to PDFA conversion duplicates background image|Bug|
|PDFNEWNET-40405|HTML to PDF - Page contents are overlapping each-other|Bug|
|PDFNEWNET-40363|Saving Nested table hangs on save()|Bug|
|PDFNEWNET-38952|PCL to PDF: incorrect output is generated|Bug|
|PDFNEWNET-40682|PDF to PDF/A - Contents are overlapping in resultant file|Bug|
|PDFNEWNET-40532|PDF to PDF/A_3b - Image changes position and size gets increased|Bug|
|PDFNEWNET-40361|PDF to PDFA - Characters overlap in resultant file|Bug|
|PDFNEWNET-39443|PDF to PDF/A - Unable to access conversion log information saved in Stream|Bug|
|PDFNEWNET-38831|Intellisense is not working for package from NuGet repository|Bug|
|PDFNET-41025|Concatenating more than 38 occurrences of same PDF, corrupts output|Bug|
|PDFNEWNET-40636|PDF to PDFA: text is corrupted in resultant PDF|Bug|
|PDFNEWNET-40629|Incorrect destination page of TOC entries|Bug|
|PDFNEWNET-40432|PDF to PDFA1b: resultant document is not PDFA1b compliant|Bug|
|PDFNEWNET-40403|TOC on multiple page loses some contents|Bug|
|PDFNEWNET-40392|PDF to PDFA: text is overlapping in the resultant PDFA document|Bug|
|PDFNEWNET-40343|PDF to HTML: RemoveEmptyAreasOnTopAndBottom property is not working as expected|Bug|
|PDFNEWNET-40248|PDF to JPEG conversion: first page is rendered into black image|Bug|
|PDFNEWNET-40081|PDF to PDFA3b: compliance failure due to Annotation not set to print|Bug|
|PDFNEWNET-39965|HTML to PDF: Circle in HTML is rendering as rounded corner rectangle|Bug|
|PDFNEWNET-39669|PDF to PDFA: background of an area changes to black|Bug|
|PDFNEWNET-39561|API stalls forever while editing PDF form|Bug|
|PDFNEWNET-39415|PDF to HTML: text is missing in resultant HTML|Bug|
|PDFNEWNET-39374|HTML to PDF stalls forever|Bug|
|PDFNEWNET-39326|PDF to HTML: incorrect conversion of text|Bug|
|PDFNEWNET-38917|PDF to XPS:"h" letter is being replaced with "e"|Bug|
|PDFNEWNET-38885|Text space missing when converting a pdf file to pdfa|Bug|
|PDFNEWNET-38337|A large header overlaps to body text|Bug|
|PDFNEWNET-38335|HTML to PDF: Adding HtmlFragment in Header is mirrored to bottom of page|Bug|
|PDFNEWNET-35720|PDF to XPS: Chinese characters are not being rendered correctly|Bug|
|PDFNEWNET-40816|IsKeptWithNext is not working if next paragraph is a table|Bug|
|PDFNEWNET-40700|PDF to PDF/A - Text formatting is lost and contents are missing|Bug|
|PDFNEWNET-40698|PDF to PDF/A - Image starts appearing on top of page title|Bug|
|PDFNEWNET-40497|PDF to PDF/A - Background becomes black|Bug|
|PDFNEWNET-40323|PDF to PDF/A_3a - Resultant file is not PDF/A compliant|Bug|
|PDFNEWNET-39951|XFA to Standard form: Font size and style are incorrect|Bug|
|PDFNEWNET-39722|PDF to HTML - Wrong background image|Bug|
|PDFNEWNET-38827|EPUB to Image: Output image is empty|Bug|
|PDFNEWNET-38129|PCL to PDF: multiple pages are overlapping in output PDF|Bug|
#### **Public API and Backward Incompatible Changes**
We have introduced following API changes in this release and the major change includes movement of all classes/enumerations from **Aspose.PDF.Text.TextOptions.** namespace to **Aspose.PDF.Text.**

- Class **Aspose.PDF.Text.TextOptions.TextEditOptions** was moved to **Aspose.PDF.Text.TextEditOptions**
- Class **Aspose.PDF.Text.TextOptions.TextEditOptions.FontReplace** was moved to **Aspose.PDF.Text.TextEditOptions.FontReplace**
- Class **Aspose.PDF.Text.TextOptions.TextEditOptions.LanguageTransformation** was moved to **Aspose.PDF.Text.TextEditOptions.LanguageTransformation**
- Class **Aspose.PDF.Text.TextOptions.TextEditOptions.NoCharacterAction** was moved to **Aspose.PDF.Text.TextEditOptions.NoCharacterAction**
- Class **Aspose.PDF.Text.TextOptions.TextExtractionOptions** was moved to **Aspose.PDF.Text.TextExtractionOptions**
- Class **Aspose.PDF.Text.TextOptions.TextFormattingOptions** was moved to **Aspose.PDF.Text.TextFormattingOptions**
- Class **Aspose.PDF.Text.TextOptions.TextFormattingOptions.WordWrapMode** was moved to **Aspose.PDF.Text.TextFormattingOptions.WordWrapMode**
- Class **Aspose.PDF.Text.TextOptions.TextOptions** was moved to **Aspose.PDF.Text.TextOptions**
- Class **Aspose.PDF.Text.TextOptions.TextReplaceOptions** was moved to **Aspose.PDF.Text.TextReplaceOptions**
- Class **Aspose.PDF.Text.TextOptions.TextReplaceOptions.ReplaceAdjustment** was moved to **Aspose.PDF.Text.TextReplaceOptions.ReplaceAdjustment**
- Class **Aspose.PDF.Text.TextOptions.TextReplaceOptions.Scope** was moved to **Aspose.PDF.Text.TextReplaceOptions.Scope**
- Class **Aspose.PDF.Text.TextOptions.TextSearchOptions** was moved to **Aspose.PDF.Text.TextSearchOptions**
