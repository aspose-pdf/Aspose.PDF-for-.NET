---
title: Aspose.PDF for .NET 18.12 Release Notes
type: docs
weight: 10
url: /net/aspose-pdf-for-net-18-12-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 18.12](https://www.nuget.org/packages/Aspose.Pdf/18.12.0)

{{% /alert %}} 
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-44637|PDF/UA: Validate Text|New Feature|
|PDFNET-45657|PDF/UA: Create ITaggedContent interface for work with Tagged PDF documents|New Feature|
|PDFNET-45658|PDF/UA: Create Factory of Structure Elements|New Feature|
|PDFNET-45659|PDF/UA: Add ability to manage Logical Tree of Elements|New Feature|
|PDFNET-45661|PDF/UA: Ability setup Language and Title for Tagged PDF document|New Feature|
|PDFNET-45624|Aspose.Pdf.Generator.PrintController is missing|New Feature|
|PDFNET-45696|Tagged PDF - Support for setting language field in tag tab of object properties|New Feature|
|PDFNET-45630|Add support of FlateDecode for storing new images into XImageCollection|Enhancement|
|PDFNET-45766|Introduce option in Optimization to store images with FlateDecode compression|Enhancement|
|PDFNET-45598|PDF to HTML: Descriptive exception message when non existing default font is set|Enhancement|
|PDFNET-44369|PDF optimization - cannot change DCTDecode compression|Bug|
|PDFNET-35479|PDF to PNG conversion takes longer time|Bug|
|PDFNET-45600|TextAbsorber returns incorrect result|Bug|
|PDFNET-45365|ArgumentOutOfRangeException with TextFragmentAbsorber|Bug|
|PDFNET-38776|Problem rendering different TextStates on Same Line in Table Cell|Bug|
|PDFNET-39105|Issue on TextFragment.Margin with justify|Bug|
|PDFNET-38307|Text Extraction - Text being extracted in weird manner. Columns merge and scrambled|Bug|
|PDFNET-44028|Tiff to PDF: System.ArgumentException: Parameter is not valid.|Bug|
|PDFNET-44839|The image output contains the inconsistent spacing between dots|Bug|
|PDFNET-45651|JPG to PDF - an internal error occurred|Bug|
|PDFNET-37424|PDF to TIFF - OutOfMemoryException during conversion|Bug|
|PDFNET-39431|PDF to JPEG - Dotted background is substituted with the white one|Bug|
|PDFNET-34451|Performance Issue: Converting PDF to PNG|Bug|
|PDFNET-45573|The text in html fragment isn't properly wrapped|Bug|
|PDFNET-45528|Form fields get invisible|Bug|
|PDFNET-45244|NullReferenceException when saving PDF file|Bug|
|PDFNET-45654|The footer shifts down and disappear for multiple page|Bug|
|PDFNET-45466|ArgumentOutOfRangeException with IsLowMemoryMode|Bug|
|PDFNET-45520|System Hangs while processing PDF document with HtmlFragment|Bug|
|PDFNET-44808|PDF to PDF/A 1B - artifacts appear in the converted image|Bug|
|PDFNET-45672|PDF to PDF/UA - Change the tag of this structure element|Bug|
|PDFNET-38307|Text Extraction - Text being extracted in weird manner. Columns merge and scrambled|Bug|
|PDFNET-39534|Extracting table data throws ArgumentOutOfRangeException|Bug|
|PDFNET-39377|TableAbsorber throws InvalidOperationException|Bug|
### **Public API changes in Aspose.PDF for .NET 18.12**
-----
### **Added APIs:**
Property Aspose.Pdf.Document.TaggedContent
Enumeration member Aspose.Pdf.ImageFilterType.Flate
Property Aspose.Pdf.Optimization.ImageCompressionOptions.Encoding
Enumeration Aspose.Pdf.Optimization.ImageEncoding
Enumeration member Aspose.Pdf.Optimization.ImageEncoding.Unchanged
Enumeration member Aspose.Pdf.Optimization.ImageEncoding.Jpeg
Enumeration member Aspose.Pdf.Optimization.ImageEncoding.Flate
Enumeration member Aspose.Pdf.Optimization.ImageEncoding.Jpeg2000
Property Aspose.Pdf.Optimization.OptimizationOptions.ImageEncoding
Property Aspose.Pdf.Page.BackgroundImage
Interface Aspose.Pdf.Tagged.ITaggedContent
Property Aspose.Pdf.Tagged.ITaggedContent.StructTreeRootElement
Property Aspose.Pdf.Tagged.ITaggedContent.RootElement
Method Aspose.Pdf.Tagged.ITaggedContent.SetLanguage(System.String)
Method Aspose.Pdf.Tagged.ITaggedContent.SetTitle(System.String)
Method Aspose.Pdf.Tagged.ITaggedContent.CreatePartElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateArtElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateSectElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateDivElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateBlockQuoteElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateCaptionElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateTOCElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateTOCIElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateIndexElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateNonStructElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreatePrivateElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateParagraphElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateHeaderElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateHeaderElement(System.Int32)
Method Aspose.Pdf.Tagged.ITaggedContent.CreateListElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateTableElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateSpanElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateQuoteElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateNoteElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateReferenceElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateBibEntryElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateCodeElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateLinkElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateAnnotElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateRubyElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateWarichuElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateFigureElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateFormulaElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateFormElement
Class Aspose.Pdf.Tagged.TaggedException
Constructor Aspose.Pdf.Tagged.TaggedException
Class Aspose.Pdf.LogicalStructure.AnnotElement
Class Aspose.Pdf.LogicalStructure.ArtElement
Class Aspose.Pdf.LogicalStructure.AttributeOwnerStandard
Method Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.ToString
Constant Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.Layout
Constant Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.List
Constant Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.PrintField
Constant Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.Table
Constant Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.XML_100
Constant Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.HTML_320
Constant Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.HTML_401
Constant Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.OEB_100
Constant Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.RTF_105
Constant Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.CSS_100
Constant Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.CSS_200
Class Aspose.Pdf.LogicalStructure.BLSElement
Class Aspose.Pdf.LogicalStructure.BLSTextElement
Property Aspose.Pdf.LogicalStructure.BLSTextElement.TextState
Method Aspose.Pdf.LogicalStructure.BLSTextElement.SetText(System.String)
Aspose.Pdf.LogicalStructure.BibEntryElement
Class Aspose.Pdf.LogicalStructure.BlockQuoteElement
Class Aspose.Pdf.LogicalStructure.CaptionElement
Class Aspose.Pdf.LogicalStructure.CodeElement
Class Aspose.Pdf.LogicalStructure.DivElement
Class Aspose.Pdf.LogicalStructure.DocumentElement
Class Aspose.Pdf.LogicalStructure.Element
Property Aspose.Pdf.LogicalStructure.Element.ParentElement
Property Aspose.Pdf.LogicalStructure.Element.ChildElements
Method Aspose.Pdf.LogicalStructure.Element.AppendChild(Aspose.Pdf.LogicalStructure.Element)
Method Aspose.Pdf.LogicalStructure.Element.ToString
Class Aspose.Pdf.LogicalStructure.ElementList
Property Aspose.Pdf.LogicalStructure.ElementList.Count
Indexer Aspose.Pdf.LogicalStructure.ElementList.ElementOf(System.Int32)
Method Aspose.Pdf.LogicalStructure.ElementList.Item(System.Int32)
Method Aspose.Pdf.LogicalStructure.ElementList.GetEnumerator
Class Aspose.Pdf.LogicalStructure.FigureElement
Property Aspose.Pdf.LogicalStructure.FormElement
Property Aspose.Pdf.LogicalStructure.FormulaElement
Property Aspose.Pdf.LogicalStructure.GroupingElement
Property Aspose.Pdf.LogicalStructure.HeaderElement
Class Aspose.Pdf.LogicalStructure.ILSElement
Class Aspose.Pdf.LogicalStructure.ILSTextElement
Property Aspose.Pdf.LogicalStructure.ILSTextElement.TextState
Method Aspose.Pdf.LogicalStructure.ILSTextElement.SetText(System.String)
Interface Aspose.Pdf.LogicalStructure.ITextElement
Property Aspose.Pdf.LogicalStructure.ITextElement.TextState
Method Aspose.Pdf.LogicalStructure.ITextElement.SetText(System.String)
Class Aspose.Pdf.LogicalStructure.IllustrationElement
Method Aspose.Pdf.LogicalStructure.IllustrationElement.SetImage(System.String)
Class Aspose.Pdf.LogicalStructure.IndexElement
Class Aspose.Pdf.LogicalStructure.LinkElement
Class Aspose.Pdf.LogicalStructure.ListChildElement
Class Aspose.Pdf.LogicalStructure.ListElement
Class Aspose.Pdf.LogicalStructure.ListLBodyElement
Class Aspose.Pdf.LogicalStructure.ListLIElement
Class Aspose.Pdf.LogicalStructure.ListLblElement
Class Aspose.Pdf.LogicalStructure.MCRElement
Property Aspose.Pdf.LogicalStructure.MCRElement.ImageSrc
Property Aspose.Pdf.LogicalStructure.MCRElement.Content
Property Aspose.Pdf.LogicalStructure.MCRElement.MCID
Method Aspose.Pdf.LogicalStructure.MCRElement.ToString
Class Aspose.Pdf.LogicalStructure.NonStructElement
Class Aspose.Pdf.LogicalStructure.NoteElement
Class Aspose.Pdf.LogicalStructure.OBJRElement
Method Aspose.Pdf.LogicalStructure.OBJRElement.ToString
Class Aspose.Pdf.LogicalStructure.ParagraphElement
Class Aspose.Pdf.LogicalStructure.PartElement
Class Aspose.Pdf.LogicalStructure.PrivateElement
Class Aspose.Pdf.LogicalStructure.QuoteElement
Class Aspose.Pdf.LogicalStructure.ReferenceElement
Class Aspose.Pdf.LogicalStructure.RubyChildElement
Class Aspose.Pdf.LogicalStructure.RubyElement
Class Aspose.Pdf.LogicalStructure.RubyRBElement
Class Aspose.Pdf.LogicalStructure.RubyRPElement
Class Aspose.Pdf.LogicalStructure.RubyRTElement
Class Aspose.Pdf.LogicalStructure.SectElement
Class Aspose.Pdf.LogicalStructure.SpanElement
Class Aspose.Pdf.LogicalStructure.StructTreeRootElement
Class Aspose.Pdf.LogicalStructure.StructureAttributeCollection
Method Aspose.Pdf.LogicalStructure.StructureAttributeCollection.GetAttributes(Aspose.Pdf.LogicalStructure.AttributeOwnerStandard)
Class Aspose.Pdf.LogicalStructure.StructureAttributes
Method Aspose.Pdf.LogicalStructure.StructureAttributes.UpdateRectangle(System.String,Aspose.Pdf.Rectangle)
Method Aspose.Pdf.LogicalStructure.StructureAttributes.UpdateNumber(System.String,System.Double)
Method Aspose.Pdf.LogicalStructure.StructureAttributes.UpdateString(System.String,System.String)
Class Aspose.Pdf.LogicalStructure.StructureElement
Property Aspose.Pdf.LogicalStructure.StructureElement.Attributes
Property Aspose.Pdf.LogicalStructure.StructureElement.StructureType
Property Aspose.Pdf.LogicalStructure.StructureElement.Title
Property Aspose.Pdf.LogicalStructure.StructureElement.Language
Property Aspose.Pdf.LogicalStructure.StructureElement.AlternativeText
Property Aspose.Pdf.LogicalStructure.StructureElement.ExpansionText
Property Aspose.Pdf.LogicalStructure.StructureElement.ActualText
Method Aspose.Pdf.LogicalStructure.StructureElement.SetTag(System.String)
Method Aspose.Pdf.LogicalStructure.StructureElement.ToString
Class Aspose.Pdf.LogicalStructure.StructureTypeCategory
Method Aspose.Pdf.LogicalStructure.StructureTypeCategory.ToString
Constant Aspose.Pdf.LogicalStructure.StructureTypeCategory.GroupingElements
Constant Aspose.Pdf.LogicalStructure.StructureTypeCategory.BLSEs
Constant Aspose.Pdf.LogicalStructure.StructureTypeCategory.ILSEs
Constant Aspose.Pdf.LogicalStructure.StructureTypeCategory.IllustrationElements
Class Aspose.Pdf.LogicalStructure.StructureTypeStandard
Property Aspose.Pdf.LogicalStructure.StructureTypeStandard.Tag
Method Aspose.Pdf.LogicalStructure.StructureTypeStandard.ToString
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Document
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Part
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Art
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Sect
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Div
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.BlockQuote
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Caption
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.TOC
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.TOCI
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Index
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.NonStruct
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Private
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.P
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.H
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.H1
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.H2
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.H3
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.H4
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.H5
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.H6
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.L
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.LI
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Lbl
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.LBody
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Table
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.THead
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.TBody
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.TFoot
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.TR
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.TH
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.TD
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Span
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Quote
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Note
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Reference
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.BibEntry
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Code
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Link
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Annot
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Ruby
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.RB
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.RT
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.RP
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Warichu
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.WT
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.WP
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Figure
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Formula
Constant Aspose.Pdf.LogicalStructure.StructureTypeStandard.Form
Class Aspose.Pdf.LogicalStructure.TOCElement
Class Aspose.Pdf.LogicalStructure.TOCIElement
Class Aspose.Pdf.LogicalStructure.TableChildElement
Class Aspose.Pdf.LogicalStructure.TableElement
Class Aspose.Pdf.LogicalStructure.TableTBodyElement
Class Aspose.Pdf.LogicalStructure.TableTDElement
Class Aspose.Pdf.LogicalStructure.TableTFootElement
Class Aspose.Pdf.LogicalStructure.TableTHElement
Class Aspose.Pdf.LogicalStructure.TableTHeadElement
Class Aspose.Pdf.LogicalStructure.TableTRElement
Class Aspose.Pdf.LogicalStructure.WarichuChildElement
Class Aspose.Pdf.LogicalStructure.WarichuElement
Class Aspose.Pdf.LogicalStructure.WarichuWPElement
Class Aspose.Pdf.LogicalStructure.WarichuWTElement
Class Aspose.Pdf.PrintController
Constructor Aspose.Pdf.PrintController
Property Aspose.Pdf.PrintController.FileName
Method Aspose.Pdf.PrintController.OnStartPage(System.Drawing.Printing.PrintDocument,System.Drawing.Printing.PrintPageEventArgs)
Method Aspose.Pdf.PrintController.OnStartPrint(System.Drawing.Printing.PrintDocument,System.Drawing.Printing.PrintEventArgs)
Method Aspose.Pdf.PrintController.OnEndPage(System.Drawing.Printing.PrintDocument,System.Drawing.Printing.PrintPageEventArgs)
Method Aspose.Pdf.PrintController.OnEndPrint(System.Drawing.Printing.PrintDocument,System.Drawing.Printing.PrintEventArgs)
Method Aspose.Pdf.PrintController.Dispose
Method Aspose.Pdf.LogicalStructure.AttributeOwnerStandard.op_Explicit(System.String)~Aspose.Pdf.LogicalStructure.AttributeOwnerStandard
Method Aspose.Pdf.LogicalStructure.StructureTypeCategory.op_Explicit(System.String)~Aspose.Pdf.LogicalStructure.StructureTypeCategory  
Method Aspose.Pdf.LogicalStructure.StructureTypeStandard.op_Explicit(System.String)~Aspose.Pdf.LogicalStructure.StructureTypeStandard  
