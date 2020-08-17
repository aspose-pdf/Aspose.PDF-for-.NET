---
title: Aspose.PDF for .NET 18.1 Release Notes
type: docs
weight: 120
url: /net/aspose-pdf-for-net-18-1-release-notes/
---

## **Release Notes of Aspose.PDF for .NET 18.1**
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-20110|Postscript to PDF|New Feature|
|PDFNET-33429|Extract Paragraph from PDF|New Feature|
|PDFNET-38512|Support TextBorder property in TextFragment class|New Feature|
|PDFNET-39249|EPS to PDF conversion support|New Feature|
|PDFNET-43776|SubsequentLinesIndent support with page.Paragraphs.Add method |Enhancement|
|PDFNET-43744|Set image path from code while generating PDF from XML|Enhancement|
|PDFNET-37131|Fill Stroke text support|Enhancement|
|PDFNET-38974|PDF to JPEG - Incorrect resultant file|Bug|
|PDFNET-40340|Text replacement issue: Characters are missing in replaced text|Bug|
|PDFNET-40763|PDF to TIFF - Text is garbled in resultant file|Bug|
|PDFNET-41224|PCL to PDF: PCL Line Space sequences do not work|Bug|
|PDFNET-41407|Converting XFA form to standard adds two extra pages|Bug|
|PDFNET-41478|PDF to PNG - Text becomes black boxes|Bug|
|PDFNET-42075|PDF to PDF/A - Text starts appearing overlapped|Bug|
|PDFNET-42272|Hyperlink in HtmlFragment is not working|Bug|
|PDFNET-42311|Loading font from stream throws exception Parsing of table 'GSUB' has failed|Bug|
|PDFNET-42340|PDF to HTML: Saving resultant HTML within project throws ArgumentException|Bug|
|PDFNET-42601|Aspose.Pdf 17.3 Different height of Text and Image objects with same size|Bug|
|PDFNET-42761|HTML to PDF - Formatting issues in resultant file|Bug|
|PDFNET-42832|The exception thrown when trying to add an SVG file into the table cell.|Bug|
|PDFNET-43333|When converting PDF to TIFF the output is filled with blue color.|Bug|
|PDFNET-43349|PDF to JPG - the missing text on the first page|Bug|
|PDFNET-43352|PDF to PDFA - Pages Orientation is changing after conversion|Bug|
|PDFNET-43372|PDF to PNG - Contents are missing in resultant file|Bug|
|PDFNET-43449|PDF to PDFA1B - a null pointer error occurred|Bug|
|PDFNET-43747|PDF to PDF/A-1a - Output does not pass the compliance test|Bug|
|PDFNET-43799|XSLFO to PDF - the link is not working in output PDF file|Bug|
|PDFNET-38820|HTML to PDF conversion: contents are moving off the page|Bug|
|PDFNET-43445|PDF - PDF/A-1 - the characters are overlapping with Sharp printers|Bug|
### **Public API changes in Aspose.PDF for .NET 18.1**
### **Added APIs:**
-----
Method Aspose.Pdf.Facades.Stamp.BindTextState(Aspose.Pdf.Text.TextState)   
Enumeration member Aspose.Pdf.LoadFormat.PS   
Class Aspose.Pdf.PsLoadOptions   
Constructor Aspose.Pdf.PsLoadOptions   
Property Aspose.Pdf.PsLoadOptions.FontsFolders   
Class Aspose.Pdf.Text.MarkupParagraph   
Property Aspose.Pdf.Text.MarkupParagraph.Points   
Property Aspose.Pdf.Text.MarkupParagraph.Fragments   
Property Aspose.Pdf.Text.MarkupParagraph.Lines   
Class Aspose.Pdf.Text.MarkupSection   
Property Aspose.Pdf.Text.MarkupSection.Rectangle   
Property Aspose.Pdf.Text.MarkupSection.Fragments   
Property Aspose.Pdf.Text.MarkupSection.Paragraphs   
Class Aspose.Pdf.Text.PageMarkup   
Property Aspose.Pdf.Text.PageMarkup.Number   
Property Aspose.Pdf.Text.PageMarkup.Rectangle   
Property Aspose.Pdf.Text.PageMarkup.Sections   
Property Aspose.Pdf.Text.PageMarkup.Paragraphs   
Property Aspose.Pdf.Text.PageMarkup.TextFragments   
Class Aspose.Pdf.Text.ParagraphAbsorber   
Constructor Aspose.Pdf.Text.ParagraphAbsorber   
Constructor Aspose.Pdf.Text.ParagraphAbsorber(System.Int32)   
Property Aspose.Pdf.Text.ParagraphAbsorber.PageMarkups   
Property Aspose.Pdf.Text.ParagraphAbsorber.SectionsSearchDepth   
Method Aspose.Pdf.Text.ParagraphAbsorber.Visit(Aspose.Pdf.Document)   
Method Aspose.Pdf.Text.ParagraphAbsorber.Visit(Aspose.Pdf.Page)   
Property Aspose.Pdf.Text.TextFormattingOptions.SubsequentLinesIndent   
Property Aspose.Pdf.Text.TextFragmentState.RenderingMode   
Property Aspose.Pdf.Text.TextFragmentState.StrokingColor   
Property Aspose.Pdf.Text.TextFragmentState.DrawTextRectangleBorder   
Enumeration Aspose.Pdf.Text.TextRenderingMode   
Enumeration member Aspose.Pdf.Text.TextRenderingMode.FillText   
Enumeration member Aspose.Pdf.Text.TextRenderingMode.StrokeText   
Enumeration member Aspose.Pdf.Text.TextRenderingMode.FillThenStrokeText   
Enumeration member Aspose.Pdf.Text.TextRenderingMode.Invisible   
Enumeration member Aspose.Pdf.Text.TextRenderingMode.FillTextAndAddPathToClipping
Enumeration member Aspose.Pdf.Text.TextRenderingMode.StrokeTextAndAddPathToClipping
Enumeration member Aspose.Pdf.Text.TextRenderingMode.FillThenStrokeTextAndAddPathToClipping   
Enumeration member Aspose.Pdf.Text.TextRenderingMode.AddPathToClipping   
Property Aspose.Pdf.Text.TextState.RenderingMode   
Property Aspose.Pdf.Text.TextState.StrokingColor   
Constructor Aspose.Pdf.TextStamp(System.String,Aspose.Pdf.Text.TextState)   
### **Removed APIs:**
-----
Property Aspose.Pdf.HtmlFragment.HtmlLoadOptionsOfInstance
