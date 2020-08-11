---
title: Aspose.PDF for .NET 19.4 Release Notes
type: docs
weight: 90
url: /net/aspose-pdf-for-net-19-4-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 19.4](https://www.nuget.org/packages/Aspose.Pdf/19.4.0)

{{% /alert %}} 

**Improvements and Changes** 

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-43446|Use of Latex script to add mathematical expressions/formulas in the table cell.|New Feature|
|PDFNET-40626|Suppress Location and Reason two rows from signature block|New Feature|
|PDFNET-42001|Change language in digital sign text|New Feature|
|PDFNET-46035 |TaggedPDF: Support Link Structure Element for Tagged PDF|New Feature|
|PDFNET-46144|TaggedPDF: Implement possibility to add structure element into element which contains text|New Feature|
|PDFNET-46040|Tagging each image in existing PDF for accessibility|New Feature|
|PDFNET-41411|Question about JavascriptStripper working|Enhancement|
|PDFNET-43286|Title of Annotation gets renamed after concatenation|Enhancement|
|PDFNET-44884|Repeat HtmlFragment with RepeatingRowsCount property|Enhancement|
|PDFNET-46163|PDF/UA: Recognize validate error: "'StructParent' entry missing in annotation"|Enhancement|
|PDFNET-46164|PDF/UA: Recognize validate error: "'StructParents' key missing in page"|Enhancement|
|PDFNET-46165|PDF/UA: Recognize validate error: "Entry for given 'StructParents' not found"|Enhancement|
|PDFNET-46149|Hybrid cross-reference table is not saved correctly|Enhancement|
|PDFNET-46105|Hang and OutOfMemory exception when saving PDF|Bug|
|PDFNET-45574|HTML fragment omits the font size setting|Bug|
|PDFNET-44943|The imported HTML fragment isn't the same as the original HTML file|Bug|
|PDFNET-46147|The text fragment is improperly aligned after the text replacement|Bug|
|PDFNET-42529|PDF to PDFA Conversion process hangs up|Bug|
|PDFNET-46107|HTML to PDF - Inline anchor tags are not working in output PDF|Bug|
|PDFNET-45898|Highlighted and Underlined Text is not being replaced correctly|Bug|
|PDFNET-46154|Facades.Form.ImportFdf - Multiline TextBoxField value is reversed when text is Hebrew|Bug|
|PDFNET-45285|PDF to SVG conversion: Few resulting SVG files are incorrect|Bug|
|PDFNET-42481|Print Dialogue not opening in FireFox|Bug|
|PDFNET-45025|Reason and Location values are not displayed on digital signatures|Bug|
|PDFNET-30668|Aspose HTML to PDF (Textfield borders shown in resultant Pdf)|Bug|
|PDFNET-40313|Exception when trying to get Signature information inside PDF|Bug|
|PDFNET-39668|PDF to PDF/A - Resultant file is not PDF/A_1b compliant|Bug|
|PDFNET-36417 |When replacing text, underline remains in PDF file|Bug|
|PDFNET-40709|Setting existing textfragment to invisible makes the rest of the text in page invisible|Bug|
|PDFNET-40068|Text is incorrectly being extracted|Bug|
|PDFNET-40485|Exception when trying to extract text from first page of PDF|Bug|
|PDFNET-44143|Invalid output signed PDF|Bug|
|PDFNET-41451|Removing Signature throws NullReference Exception|Bug|
|PDFNET-40375|HTML to PDF conversion throws InvalidOperationException|Bug|
|PDFNET-40345|PDF to PDFA conversion results into an empty PDFA document|Bug|
|PDFNET-39493|PDF to PDFA: Text is being rendered as squares|Bug|
|PDFNET-39220|PDF to PDFA conversion hangs the process|Bug|
|PDFNET-38941|Unable to extract text in LinkAnnotation rectangle|Bug|
|PDFNET-40903|API throws exception during text extraction from a multi language document|Bug|
|PDFNET-45916|Removing last outline in OutlineCollection throws Invalid index exception|Bug|
|PDFNET-44031|` `Incorrect output when saving XPS as HTML|Bug|
|PDFNET-44146|Missing characters when saving PDF as HTML|Bug|
|PDFNET-46179|Some headings are missing in the output PDF|Bug|
|PDFNET-38151|Converting Searchable PDF to XPS (Keeping Text Selectable in resultant XPS)|Bug|
|PDFNET-42213|Issue with arabic language when printing from XPS to PDF|Bug|
|PDFNET-43915|PDF to XPS: Blank XPS is generated from PDF with an image|Bug|
|PDFNET-43538|Exception when loading LaTex in multithread|Bug|
|PDFNET-45964|Save and load LaTex document issues|Bug|
|PDFNET-41675|PDF to XPS - Watermark in resultant file is too dim|Bug|
### **Public API changes in Aspose.PDF for .NET 19.4**
-----
### **Added APIs:**
- Enumeration member Aspose.Pdf.Annotations.PredefinedAction.Print
- Class Aspose.Pdf.LogicalStructure.AnnotationElement
- Property Aspose.Pdf.LogicalStructure.AnnotationElement.AlternateDescriptions
- Method Aspose.Pdf.LogicalStructure.Element.FindElements<T>(System.Boolean)
- Property Aspose.Pdf.LogicalStructure.LinkElement.Hyperlink
- Property Aspose.Pdf.LogicalStructure.LinkElement.StructureTextState
- Method Aspose.Pdf.LogicalStructure.LinkElement.SetText(System.String)
- Method Aspose.Pdf.LogicalStructure.StructureElement.<br/>ChangeParentElement(Aspose.Pdf.LogicalStructure.StructureElement)
- Property Aspose.Pdf.OutlineCollection.VisibleCount
- Property Aspose.Pdf.OutlineItemCollection.VisibleCount
- Property Aspose.Pdf.Text.TextSearchOptions.SearchForTextRelatedGraphics
- Property Aspose.Pdf.XpsSaveOptions.SaveTransparentTexts
### **Removed APIs:**
- Property Aspose.Pdf.Document.IsPdfTaggedMarked

