---
title: Aspose.PDF for .NET 17.5 Release Notes
type: docs
weight: 80
url: /net/aspose-pdf-for-net-17-5-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-41686|When document is printed, there is no option to print it as grayscale|New Feature|
|PDFNET-35936|Take fully embedded font sets and trim them down to subsets only|New Feature|
|PDFNET-36391|Implement rotation for TextFragment|New Feature|
|PDFNET-41734|Reading image file path from PDF|Enhancement|
|PDFNET-41882|Detect blank page|Enhancement|
|PDFNET-37708|Table rotates to 90 degrees|Enhancement|
|PDFNET-41692|PDF to PDFA: resultant PDFA size is increased even without embedded fonts|Enhancement|
|PDFNET-41609|XFDF line and Polygon annotation with measurements|Enhancement|
|PDFNET-42222|Problem with using Stream as input and XmlResolver|Enhancement|
|PDFNET-42310|Text fragment is not replaced|Bug|
|PDFNET-40798|Exception when trying to extract text from PDF file|Bug|
|PDFNET-40781|KeyNotFoundException on Document.Pages[i](https://saltov.dynabic.com/wiki/pages/createpage.action?spaceKey=Support&title=i&linkCreation=true&fromPageId=19791880) with valid index|Bug|
|PDFNET-40797|NullReferenceException while extracting PDF file|Bug|
|PDFNET-42086|Problem setting "XmpPdfAExtensionValueType|Bug|
|PDFNET-41562|Text being cutoff with Google's Noto Fonts|Bug|
|PDFNET-42555|PDF to PDFA: decrease in quality of transparent images|Bug|
|PDFNET-40924|SVG images not sizing properly in PDF file|Bug|
|PDFNET-38824|Adding image to cell hangs the application|Bug|
|PDFNET-38719|PDF to PNG - Text rendering issue in resultant image|Bug|
|PDFNET-38525|PDF to TIFF - Form data is not appearing on image|Bug|
|PDFNET-41985|Blank pages when rendering specific PDF to HTML|Bug|
|PDFNET-36252|Mulitpage TIFF to PDF conversion cuts off right side of image|Bug|
|PDFNET-40726|PDF to PDFA1a: Background color is missing|Bug|
|PDFNET-42092|LocalHyperlink text with Font Style|Bug|
|PDFNET-41932|API hangs with a Floating box containing a large HtmlFragment|Bug|
|PDFNET-37960|Heading in FloatingBox missing from table of contents|Bug|
|PDFNET-42570|PDF to PDFA some text is messed up|Bug|
|PDFNET-42493|When PDF is converted to PDF_A_1B, output file is still classic PDF.|Bug|
|PDFNET-42280|PDF to PDF/A-1A conversion works incorrectly|Bug|
|PDFNET-36248|Thai Charaters appear to be compacted|Bug|
|PDFNET-42478|When PDF is converted to PDFA, the word in text is messed up.|Bug|
|PDFNET-42449|Table numbers messed up during PDF / PDFA conversion|Bug|
|PDFNET-34814|Monospaced font is not being used when creating PDF file|Bug|
|PDFNET-42473|When specific PDF is converted to PDF_A_1B, output file is still classic PDF|Bug|
|PDFNET-42474|When specific PDF is converted to PDF_A_1B, output file is still classic PDF.|Bug|
|PDFNET-38953|PDF to PDFA1b: output PDFA1b fails compliance verification|Bug|
|PDFNET-36781|PDF to JPEG: some of UNICODE characters rendered incorrectly|Bug|
|PDFNET-38135|Aspose not reading Custom Fonts|Bug|
|PDFNET-38795|PDF to HTML conversion loses the text|Bug|
|PDFNET-40847|Dynamic PDF form flattening issue|Bug|
|PDFNET-40474|PDF to PDF/A - Resultant file is not compliant|Bug|
|PDFNET-40679|PDF to HTML: TOC links are lost in output HTML|Bug|
|PDFNET-40680|PDF to PDF/A - Resultant file is not compliant|Bug|
## **Public API Changes**
#### **Added API's**
Property Aspose.PDF.Annotations.PolyAnnotation.Measure    
Property Aspose.PDF.Document.FontUtilities    
Method Aspose.PDF.Document.BindXml  (System.IO.Stream,System.IO.Stream,System.Xml.XmlReaderSettings)  
Enumeration Aspose.PDF.Document.FontSubsetStrategy  
EnumerationmemberAspose.PDF.Document.FontSubsetStrategy.SubsetEmbeddedFontOnly  
Enumeration member Aspose.PDF.Document.FontSubsetStrategy.SubsetAllFonts  
Interface Aspose.PDF.Document.IDocumentFontUtilities    
MethodAspose.PDF.Document.IDocumentFontUtilities.SubsetFonts  (Aspose.PDF.Document.FontSubsetStrategy)  
Property Aspose.PDF.Facades.PdfViewer.PrintAsGrayscale  
Class Aspose.PDF.IncorrectCMapUsageException  
Constructor Aspose.PDF.IncorrectCMapUsageException(System.String)  
Class Aspose.PDF.Opi  
Constructor Aspose.PDF.Opi(Aspose.PDF.XForm)  
Property Aspose.PDF.Opi.Version  
Property Aspose.PDF.Opi.FileSpecification  
Property Aspose.PDF.Opi.Position  
Class Aspose.PDF.Page.IsBlank(System.Double)  
Class Aspose.PDF.PdfASymbolicFontEncodingStrategy  
Constructor Aspose.PDF.PdfASymbolicFontEncodingStrategy  
MethodAspose.PDF.PdfASymbolicFontEncodingStrategy  (System.Collections.Generic.Queue{Aspose.PDF.PdfASymbolicFontEncodingStrategy.  
MethodAspose.PDF.PdfASymbolicFontEncodingStrategy  (Aspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem.CMapEncodingTableType)  
Property Aspose.PDF.PdfASymbolicFontEncodingStrategy.PreferredCmapEncodingTable
PropertyAspose.PDF.PdfASymbolicFontEncodingStrategy.CmapEncodingTablesPriorityQueue  
Class Aspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem  
Constructor Aspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem  
MethodAspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem.#cto(System.UInt16,System.UInt16)
MethodAspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem.#ctor(Aspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem.CMapEncodingT
Property Aspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem.CMapEncodingTable
Property Aspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem.PlatformID
Property Aspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem.PlatformSpecificID
EnumerationAspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem.CMapEncodingTableType  
EnumerationmemberAspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem.CMapEncodingTableType.WindowsUnicodeTable    
EnumerationmemberAspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem.CMapEncodingTableType.WindowsSymbolicTable    
EnumerationmemberAspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem.CMapEncodingTableType.MacTable    
EnumerationmemberAspose.PDF.PdfASymbolicFontEncodingStrategy.QueueItem.CMapEncodingTableType.UnicodeTable  
Property Aspose.PDF.PdfFormatConversionOptions.SymbolicFontEncodingStrategy  
Method Aspose.PDF.Rectangle.Join(Aspose.PDF.Rectangle)  
Method Aspose.PDF.Text.FileFontSource.Equals(System.Object)  
Method Aspose.PDF.Text.FolderFontSource.Equals(System.Object)  
Property Aspose.PDF.Text.Font.FontName  
Property Aspose.PDF.Text.Font.IsEmbedded  
Property Aspose.PDF.Text.Font.IsSubset  
Property Aspose.PDF.Text.Font.IsAccessible  
Property Aspose.PDF.Text.Font.FontOptions  
Method Aspose.PDF.Text.Font.GetLastFontEmbeddingError  
Method Aspose.PDF.Text.Font.Save(System.IO.Stream)  
Method Aspose.PDF.Text.Font.MeasureString(System.String,System.Single)  
Method Aspose.PDF.Text.MemoryFontSource.Equals(System.Object)  
Method Aspose.PDF.Text.MemoryFontSource.Dispose  
Method Aspose.PDF.Text.SystemFontSource.Equals(System.Object)  
Property Aspose.PDF.Text.TextFragmentState.FormattingOptions  
Property Aspose.PDF.Text.TextFragmentState.Rotation  
Property Aspose.PDF.Text.TextParagraph.Rotation  
Property Aspose.PDF.XForm.Opi  
Property Aspose.PDF.XfaConverter.XfaParserOptions.UriResolver  
Property Aspose.PDF.XfaConverter.XfaParserOptions.PageSize  
Property Aspose.PDF.XfaConverter.XfaParserOptions.Signed  
Property Aspose.PDF.XfaConverter.XfaParserOptions.EmulateRequierdGroups  
Property Aspose.PDF.XfaConverter.XfaParserOptions.BasePath  
#### **Removed API's**
Method Aspose.PDF.Document.#ctor(Aspose.PDF.Generator.Pdf)  
Method Aspose.PDF.Facades.PdfAnnotationEditor.BindPdf(Aspose.PDF.Generator.Pdf)  
Method Aspose.PDF.Facades.PdfBookmarkEditor.BindPdf(Aspose.PDF.Generator.Pdf)  
Method Aspose.PDF.Facades.PdfContentEditor.BindPdf(Aspose.PDF.Generator.Pdf)  
Method Aspose.PDF.Facades.PdfConverter.BindPdf(Aspose.PDF.Generator.Pdf)  
Method Aspose.PDF.Facades.PdfExtractor.BindPdf(Aspose.PDF.Generator.Pdf)  
Method Aspose.PDF.Facades.PdfFileSignature.BindPdf(Aspose.PDF.Generator.Pdf)  
Method Aspose.PDF.Facades.PdfPageEditor.BindPdf(Aspose.PDF.Generator.Pdf)  
Method Aspose.PDF.Facades.PdfXmpMetadata.BindPdf(Aspose.PDF.Generator.Pdf)  
Method Aspose.PDF.Facades.Stamp.BindPdf(Aspose.PDF.Generator.Pdf,System.Int32)  
Class Aspose.PDF.Engine.CommonData.Text.CMaps.IncorrectCMapUsageException  
ConstructorAspose.PDF.Engine.CommonData.Text.CMaps.IncorrectCMapUsageException(System.String)  
