---
title: Aspose.PDF for .NET 19.6 Release Notes
type: docs
weight: 70
url: /net/aspose-pdf-for-net-19-6-release-notes/
---





{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 19.6](https://www.nuget.org/packages/Aspose.Pdf/19.6.0)

{{% /alert %}} 

**Improvements and Changes** 

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-46224|Implement Markdown to PDF converter|New Feature|
|PDFNET-26512|Provide support for creating and editing accessible PDF files|New Feature|
|PDFNET-46301|PDF/UA: Implement Table support in Tagged PDF|New Feature|
|PDFNET-45738|Improve exception description|Enhancement|
|PDFNET-46206|Add support of default font name feature when saving PDF into image|Enhancement|
|PDFNET-46413|Add the ability to set up styles for Table structure elements|Enhancement|
|PDFNET-46496|Implement Callout property for Free Text annotation|Enhancement|
|PDFNET-46437|The font color has been changed to white in HTML output|Bug|
|PDFNET-45701|An exception raises while saving the document|Bug|
|PDFNET-46254|The repeated text occurs when inserting an HTML fragment.|Bug|
|PDFNET-43524|PDF to JPG - Output image is blue|Bug|
|PDFNET-46230|Allocated RAM does not get free during subsequent calls of the method|Bug|
|PDFNET-46171|The position is incorrect on some text segments|Bug|
|PDFNET-46299|Boxes appear around text when the document is flattened|Bug|
|PDFNET-45553|Problem with FreeTextCallout annotation|Bug|
|PDFNET-46186|Table with Checkboxes leads to Nullpointer at a page break|Bug|
|PDFNET-34290|HTML to PDF Conversion: Formatting issue|Bug|
|PDFNET-33659|Using BindHTML to convert HTML to PDF results in bad formatting|Bug|
|PDFNET-34967|HTML to PDF: formatting issues in the resultant file|Bug|
|PDFNET-34966|HTML to PDF: Conversion hangs|Bug|
|PDFNET-45731|OutOfMemory exception when loading large HTML file|Bug|
|PDFNET-36874|HTML to PDF: NullReferenceException issue|Bug|
|PDFNET-39101|HTML to PDF throws ArgumentNullException|Bug|
|PDFNET-38673|HTML to PDF throws "." exception|Bug|
|PDFNET-39637|HTML to PDF conversion hangs forever|Bug|
|PDFNET-41785|TextFragmentAbsorber: regex fails to match a word boundary|Bug|
|PDFNET-43761|SVG to PDF - ArgumentException: Rectangle cannot have a width or height equal to 0|Bug|
|PDFNET-44011|Incorrect pages count for EPUB documents|Bug|
|PDFNET-46222|The text stamp is wrongly treated as a part of the<br/> text paragraph during post-replace adjustment.|Bug|
### **Public API changes in Aspose.PDF for .NET 19.6**
-----
### **Added APIs:**
- P:Aspose.Pdf.Annotations.FreeTextAnnotation.Callout
- Method Aspose.Pdf.Document.ExportAnnotationsToXfdf(System.IO.Stream)
- Method Aspose.Pdf.Document.ImportAnnotationsFromXfdf(System.IO.Stream)
- Method Aspose.Pdf.Facades.PdfAnnotationEditor.ImportAnnotationsFromXfdf(System.String)
- Method Aspose.Pdf.Facades.PdfAnnotationEditor.ImportAnnotationsFromXfdf(System.IO.Stream)
- Method Aspose.Pdf.Facades.PdfAnnotationEditor.ExportAnnotationsToXfdf(System.IO.Stream)
- Method Aspose.Pdf.Forms.CheckboxField.Clone
- Enumeration member Aspose.Pdf.HtmlSaveOptions.FontSavingModes.DontSave
- Enumeration member Aspose.Pdf.LoadFormat.MD
- Property Aspose.Pdf.LogicalStructure.StructureElement.DefaultAttributeOwner
- Class Aspose.Pdf.LogicalStructure.TableCellElement
- Property Aspose.Pdf.LogicalStructure.TableCellElement.BackgroundColor
- Property Aspose.Pdf.LogicalStructure.TableCellElement.Border
- Property Aspose.Pdf.LogicalStructure.TableCellElement.IsNoBorder
- Property Aspose.Pdf.LogicalStructure.TableCellElement.Margin
- Property Aspose.Pdf.LogicalStructure.TableCellElement.Alignment
- Property Aspose.Pdf.LogicalStructure.TableCellElement.DefaultCellTextState
- Property Aspose.Pdf.LogicalStructure.TableCellElement.IsWordWrapped
- Property Aspose.Pdf.LogicalStructure.TableCellElement.VerticalAlignment
- Property Aspose.Pdf.LogicalStructure.TableCellElement.ColSpan
- Property Aspose.Pdf.LogicalStructure.TableCellElement.RowSpan
- Property Aspose.Pdf.LogicalStructure.TableCellElement.StructureTextState
- Method Aspose.Pdf.LogicalStructure.TableCellElement.SetText(System.String)
- Property Aspose.Pdf.LogicalStructure.TableElement.BackgroundColor
- Property Aspose.Pdf.LogicalStructure.TableElement.Border
- Property Aspose.Pdf.LogicalStructure.TableElement.Alignment
- Property Aspose.Pdf.LogicalStructure.TableElement.CornerStyle
- Property Aspose.Pdf.LogicalStructure.TableElement.Broken
- Property Aspose.Pdf.LogicalStructure.TableElement.ColumnAdjustment
- Property Aspose.Pdf.LogicalStructure.TableElement.ColumnWidths
- Property Aspose.Pdf.LogicalStructure.TableElement.DefaultCellBorder
- Property Aspose.Pdf.LogicalStructure.TableElement.DefaultCellPadding
- Property Aspose.Pdf.LogicalStructure.TableElement.DefaultCellTextState
- Property Aspose.Pdf.LogicalStructure.TableElement.DefaultColumnWidth
- Property Aspose.Pdf.LogicalStructure.TableElement.IsBroken
- Property Aspose.Pdf.LogicalStructure.TableElement.IsBordersIncluded
- Property Aspose.Pdf.LogicalStructure.TableElement.Left
- Property Aspose.Pdf.LogicalStructure.TableElement.Top
- Property Aspose.Pdf.LogicalStructure.TableElement.RepeatingColumnsCount
- Property Aspose.Pdf.LogicalStructure.TableElement.RepeatingRowsCount
- Property Aspose.Pdf.LogicalStructure.TableElement.RepeatingRowsStyle
- Property Aspose.Pdf.LogicalStructure.TableTRElement.BackgroundColor
- Property Aspose.Pdf.LogicalStructure.TableTRElement.Border
- Property Aspose.Pdf.LogicalStructure.TableTRElement.DefaultCellBorder
- Property Aspose.Pdf.LogicalStructure.TableTRElement.MinRowHeight
- Property Aspose.Pdf.LogicalStructure.TableTRElement.FixedRowHeight
- Property Aspose.Pdf.LogicalStructure.TableTRElement.IsInNewPage
- Property Aspose.Pdf.LogicalStructure.TableTRElement.IsRowBroken
- Property Aspose.Pdf.LogicalStructure.TableTRElement.DefaultCellTextState
- Property Aspose.Pdf.LogicalStructure.TableTRElement.DefaultCellPaddingd
- Property Aspose.Pdf.LogicalStructure.TableTRElement.VerticalAlignment
- Property Aspose.Pdf.RenderingOptions.DefaultFontName
- Class Aspose.Pdf.MdLoadOptions
