---
title: Aspose.PDF for .NET 19.2 Release Notes
type: docs
weight: 110
url: /net/aspose-pdf-for-net-19-2-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 19.2](https://www.nuget.org/packages/Aspose.PDF/19.2.0)

{{% /alert %}} 

**Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-45785|The support for PIV Card based digital signature|New Feature|
|PDFNET-45873|Aspose.PDF digital signature from key store location|New Feature|
|PDFNET-42668 |How to sign a PDF using local certificate store|New Feature|
|PDFNET-38062 |Signing a PDF document from a smart card|New Feature|
|PDFNET-45664 |PDF/UA: Add ability to setup text style for Text Structure Elements|Enhancement|
|PDFNET-45700 |PDF/UA: Develop functionality for Structure Element Attributes|Enhancement|
|PDFNET-45699 |PDF/UA: Support Illustration Elements|Enhancement|
|PDFNET-45720 |An exception raises while loading an HTML file|Bug|
|PDFNET-45889 |Incorrect Y coordinates of characters extracted by API|Bug|
|PDFNET-45893 |Access Tagged Content from Tagged PDF Document|Bug|
|PDFNET-45686 |Document.ProcessParagraphs() takes too long|Bug|
|PDFNET-45891 |DirectoryNotFoundException in AWS Lambda|Bug|
|PDFNET-45881 |DirectoryNotFoundException in Docker Environment|Bug|
|PDFNET-36903 |Sign PDF file with a hardware-based token such as <br/>a USB-based organization certificate from SwissSign|Bug|
|PDFNET-39527 |PDF to PDF/A - Exception during conversion|Bug|
|PDFNET-39747 |PDF to PDF/A - Graphs get corrupted during conversion|Bug|
|PDFNET-34874 |Exception during HTML to PDF conversion|Bug|
|PDFNET-40215 |Text Replace - Text is overlapping at first edited word|Bug|
|PDFNET-40213 |Text line contents are not auto-adjusted after text replace|Bug|
|PDFNET-40214 |Extra space appears after Text Replace|Bug|
|PDFNET-40221 |Exception when using OTF fontt|Bug|
|PDFNET-44777 |SVG to JPG - scrumbled output|Bug|
|PDFNET-44016 |StackOverflow on PDF document text absorption|Bug|
|PDFNET-44091 |StackOverflowException on document loading|Bug|
|PDFNET-21488 |Sign a PDF file with hardware crypto token|Bug|
|PDFNET-42411 |PDF to PPTX: a paragraph with hyperlink renders incorrectly|Bug|
|PDFNET-36714 |Sign PDF with a Certificate stored in the Hardware Security Module(HSM)|Bug|
|PDFNET-40957 |HTML to PDF conversion throws NullReferenceException|Bug|
|PDFNET-41239 |HTML to PDF conversion throws InvalidOperationException|Bug|
|PDFNET-38743 |PDF to PDFA1b compliance issue|Bug|
|PDFNET-40884 |HTML to PDF throws NullReferenceException|Bug|
|PDFNET-41244 |PDF to PDFA: colored text is rendering as black|Bug|
|PDFNET-39361|TableAbsorber extracts complete row data instead of a single cell|Bug|
|PDFNET-45517|IndexOutOfRangeException occurs while extracting text using TextAbsorber|Bug|
|PDFNET-43748|Creates a copy of the file when opening the TEX document|Bug|
|PDFNET-45900|PDF/UA: Document structure is crashed when using TaggedContent property |Bug|
### **Public API changes in Aspose.PDF for .NET 19.2**
-----
### **Added APIs:**
- Class Aspose.Pdf.LogicalStructure.AttributeKey
- Property Aspose.Pdf.LogicalStructure.AttributeKey.Key
- Property Aspose.Pdf.LogicalStructure.AttributeKey.Owner
- Method Aspose.Pdf.LogicalStructure.AttributeKey.ToString
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.Placement
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.WritingMode
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.BackgroundColor
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.BorderColor
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.BorderStyle
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.BorderThickness
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.Padding
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.Color
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.SpaceBefore
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.SpaceAfter
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.StartIndent
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.EndIndent
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.TextIndent
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.TextAlign
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.BBox
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.Width
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.Height
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.BlockAlign
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.InlineAlign
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.TBorderStyle
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.TPadding
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.BaselineShift
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.LineHeight
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.TextDecorationColor
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.TextDecorationThickness
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.TextDecorationType
- Constant Constant Aspose.Pdf.LogicalStructure.AttributeKey.RubyAlign
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.RubyPosition
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.GlyphOrientationVertical
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.ColumnCount
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.ColumnGap
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.ColumnWidths
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.ListNumbering
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.Role
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.Checked
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.Desc
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.RowSpan
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.ColSpan
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.Headers
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.Scope
- Constant Aspose.Pdf.LogicalStructure.AttributeKey.Summary
- Class Aspose.Pdf.LogicalStructure.AttributeName
- Propery AsposPdf.LogicalStructure.AttributeName.Name
- Propery Aspose.Pdf.LogicalStructure.AttributeName.AttributeKey
- Method Aspose.Pdf.LogicalStructure.AttributeName.<br/>FromNameAttributeKey(System.String,Aspose.Pdf.LogicalStructure.AttributeKey)
- Method Aspose.Pdf.LogicalStructure.AttributeName.ToString
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Placement_Block
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Placement_Inline
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Placement_Before
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Placement_Start
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Placement_End
- Constant Aspose.Pdf.LogicalStructure.AttributeName.WritingMode_LrTb
- Constant Aspose.Pdf.LogicalStructure.AttributeName.WritingMode_RlTb
- Constant Aspose.Pdf.LogicalStructure.AttributeName.WritingMode_TbRl
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BorderStyle_None
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BorderStyle_Hidden
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BorderStyle_Dotted
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BorderStyle_Dashed
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BorderStyle_Solid
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BorderStyle_Double
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BorderStyle_Groove
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BorderStyle_Ridge
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BorderStyle_Inset
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BorderStyle_Outset
- Constant Aspose.Pdf.LogicalStructure.AttributeName.TextAlign_Start
- Constant Aspose.Pdf.LogicalStructure.AttributeName.TextAlign_Center
- Constant Aspose.Pdf.LogicalStructure.AttributeName.TextAlign_End
- Constant Aspose.Pdf.LogicalStructure.AttributeName.TextAlign_Justify
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Width_Auto
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Height_Auto
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BlockAlign_Before
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BlockAlign_Middle
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BlockAlign_After
- Constant Aspose.Pdf.LogicalStructure.AttributeName.BlockAlign_Justify
- Constant Aspose.Pdf.LogicalStructure.AttributeName.InlineAlign_Start
- Constant Aspose.Pdf.LogicalStructure.AttributeName.InlineAlign_Center
- Constant Aspose.Pdf.LogicalStructure.AttributeName.InlineAlign_End
- Constant Aspose.Pdf.LogicalStructure.AttributeName.LineHeight_Normal
- Constant Aspose.Pdf.LogicalStructure.AttributeName.LineHeight_Auto
- Constant Aspose.Pdf.LogicalStructure.AttributeName.TextDecorationType_None
- Constant Aspose.Pdf.LogicalStructure.AttributeName.TextDecorationType_Underline
- Constant Aspose.Pdf.LogicalStructure.AttributeName.TextDecorationType_Overline
- Constant Aspose.Pdf.LogicalStructure.AttributeName.TextDecorationType_LineThrough
- Constant Aspose.Pdf.LogicalStructure.AttributeName.RubyAlign_Start
- Constant Aspose.Pdf.LogicalStructure.AttributeName.RubyAlign_Center
- Constant Aspose.Pdf.LogicalStructure.AttributeName.RubyAlign_End
- Constant Aspose.Pdf.LogicalStructure.AttributeName.RubyAlign_Justify
- Constant Aspose.Pdf.LogicalStructure.AttributeName.RubyAlign_Distribute
- Constant Aspose.Pdf.LogicalStructure.AttributeName.RubyPosition_Before
- Constant Aspose.Pdf.LogicalStructure.AttributeName.RubyPosition_After
- Constant Aspose.Pdf.LogicalStructure.AttributeName.RubyPosition_Warichu
- Constant Aspose.Pdf.LogicalStructure.AttributeName.RubyPosition_Inline
- Constant Aspose.Pdf.LogicalStructure.AttributeName.GlyphOrientationVertical_Auto
- Constant Aspose.Pdf.LogicalStructure.AttributeName.ListNumbering_None
- Constant Aspose.Pdf.LogicalStructure.AttributeName.ListNumbering_Disc
- Constant Aspose.Pdf.LogicalStructure.AttributeName.ListNumbering_Circle
- Constant Aspose.Pdf.LogicalStructure.AttributeName.ListNumbering_Square
- Constant Aspose.Pdf.LogicalStructure.AttributeName.ListNumbering_Decimal
- Constant Aspose.Pdf.LogicalStructure.AttributeName.ListNumbering_UpperRoman
- Constant Aspose.Pdf.LogicalStructure.AttributeName.ListNumbering_LowerRoman
- Constant Aspose.Pdf.LogicalStructure.AttributeName.ListNumbering_UpperAlpha
- Constant Aspose.Pdf.LogicalStructure.AttributeName.ListNumbering_LowerAlpha
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Role_rb
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Role_cb
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Role_pb
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Role_tv
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Checked_on
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Checked_off
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Checked_neutral
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Scope_Row
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Scope_Column
- Constant Aspose.Pdf.LogicalStructure.AttributeName.Scope_Both
- Property Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.Owner
- Method Aspose.Pdf.LogicalStructure.IllustrationElement.<br/>SetImage(System.String,System.Double)
- Method Aspose.Pdf.LogicalStructure.IllustrationElement.<br/>SetImage(System.String,System.Double,System.Double)
- Class Aspose.Pdf.LogicalStructure.StructureAttribute
- Method Aspose.Pdf.LogicalStructure.StructureAttribute.<br/>#ctor(Aspose.Pdf.LogicalStructure.AttributeKey)
- Property Aspose.Pdf.LogicalStructure.StructureAttribute.Key
- Property Aspose.Pdf.LogicalStructure.StructureAttribute.IsInitializedValue
- Method Aspose.Pdf.LogicalStructure.StructureAttribute.GetNameValue
- Method Aspose.Pdf.LogicalStructure.StructureAttribute.GetStringValue
- Method Aspose.Pdf.LogicalStructure.StructureAttribute.GetNumberValue
- Method Aspose.Pdf.LogicalStructure.StructureAttribute.GetArrayValue
- Method Aspose.Pdf.LogicalStructure.StructureAttribute.GetArrayNumberValue
- Method Aspose.Pdf.LogicalStructure.StructureAttribute.<br/>SetNameValue(Aspose.Pdf.LogicalStructure.AttributeName)
- Method Aspose.Pdf.LogicalStructure.StructureAttribute.<br/>SetStringValue(System.String)
- Method Aspose.Pdf.LogicalStructure.StructureAttribute.<br/>SetNumberValue(System.Double)
- Method Aspose.Pdf.LogicalStructure.StructureAttribute.<br/>SetArrayValue(Aspose.Pdf.LogicalStructure.AttributeName[])
- Method Aspose.Pdf.LogicalStructure.StructureAttribute.<br/>SetArrayNumberValue(System.Nullable)
- Method Aspose.Pdf.LogicalStructure.StructureAttribute.<br/>SetColorValue(Aspose.Pdf.Color)
- Method Aspose.Pdf.LogicalStructure.StructureAttribute.<br/>SetRectangleValue(Aspose.Pdf.Rectangle)
- Method Aspose.Pdf.LogicalStructure.StructureAttribute<br/>Collection.CreateAttributes(Aspose.Pdf.LogicalStructure.AttributeOwnerStandard)
- Property Aspose.Pdf.LogicalStructure.StructureAttributes.Owner
- Method Aspose.Pdf.LogicalStructure.StructureAttributes.<br/>GetAttribute(Aspose.Pdf.LogicalStructure.AttributeKey)
- Method Aspose.Pdf.LogicalStructure.StructureAttributes.<br/>SetAttribute(Aspose.Pdf.LogicalStructure.StructureAttribute)
- Property Aspose.Pdf.LogicalStructure.StructureTextState.BackgroundColor
- Property Aspose.Pdf.LogicalStructure.StructureTextState.Underline
- Property Aspose.Pdf.LogicalStructure.StructureTextState.StrikeOut
- Property Aspose.Pdf.LogicalStructure.StructureTextState.Superscript
- Property Aspose.Pdf.LogicalStructure.StructureTextState.Subscript
- Property Aspose.Pdf.LogicalStructure.StructureTextState.HorizontalScaling
- Property Aspose.Pdf.LogicalStructure.StructureTextState.LineSpacing
- Property Aspose.Pdf.LogicalStructure.StructureTextState.CharacterSpacing
- Property Aspose.Pdf.LogicalStructure.StructureTextState.WordSpacing
- Property Aspose.Pdf.LogicalStructure.StructureTextState.MarginInfo
- Property Aspose.Pdf.Annotations.MovieAnnotation.Poster
- Property Aspose.Pdf.Annotations.MovieAnnotation.Rotate
- Property Aspose.Pdf.HtmlLoadOptions.isPdfUaConverting
### **Updated APIs:**
- Old Tagged PDF API (Aspose.Pdf.TaggedPdf.*) was replaced with new API (Aspose.Pdf.Tagged)
