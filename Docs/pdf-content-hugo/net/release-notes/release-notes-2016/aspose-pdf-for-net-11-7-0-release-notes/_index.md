---
title: Aspose.PDF for .NET 11.7.0 Release Notes
type: docs
weight: 70
url: /net/aspose-pdf-for-net-11-7-0-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNEWNET-39503|Support DashLengthInBlack and DashLengthInWhite properties in DOM|New Feature|
|PDFNEWNET-39504|Support AutoFitToWindow property in ColumnAdjustmentType enumeration for DOM|New Feature|
|PDFNEWNET-37674|PDF to HTML - PDF document layers are not present in output HTML|New Feature|
|PDFNEWNET-39228|auto-grow feature in EPUB to PDF conversion|New Feature|
|PDFNEWNET-38207|XPS to PDF conversion slow performance issue|Enhancement|
|PDFNEWNET-36540|Image Inserted to PDF is blur|Enhancement|
|PDFNEWNET-40667|HTML to PDF conversion throws InvalidOperation Exception|Exception|
|PDFNEWNET-39640|XFA to Static - ArgumentException: Value does not fall within the expected range|Exception|
|PDFNEWNET-40708|PDF to HTML: extra white lines on background - regression|Bug|
|PDFNEWNET-40239|PDF to PDFA2b: Text overlapping and spacing issue|Bug|
|PDFNEWNET-40668|Regression: Adding text in existing PDF document results embedded font error|Bug|
|PDFNEWNET-38884|HTML to PDF - Performance improvement required|Bug|
|PDFNEWNET-39739|PDF to HTML: some text is missing in resultant HTML|Bug|
|PDFNEWNET-40637|Objects cannot be added to PDF pages after ProcessParagraph() call|Bug|
|PDFNEWNET-39472|PDF to HTML - Special characters like accents, umlauts and circumflex are displayed incorrectly|Bug|
|PDFNEWNET-39384|PDF to HTML - Text issues when rendering resultant HTML|Bug|
|PDFNEWNET-38968|XPS to PDF - Resultant file is 6X times larger|Bug|
|PDFNEWNET-40756|PDF to PDFA conversion produces incorrect PDFA file|Bug|
|PDFNEWNET-40540|Text Replacement removes formatting|Bug|
|PDFNEWNET-40395|Using OTF fonts with HtmlFragment|Bug|
|PDFNEWNET-40360|Unknown character in content stream|Bug|
|PDFNEWNET-40358|ColSpan bug with Table.Broken property|Bug|
|PDFNEWNET-40269|PDF to PDFA1b: incorrect PDF is generated|Bug|
|PDFNEWNET-40093|Formatting TextSegment within Heading object|Bug|
|PDFNEWNET-39975|Flattening issue with overlapping fields|Bug|
|PDFNEWNET-39757|TextFragment and Image alignment issue in Footer|Bug|
|PDFNEWNET-39394|PDF to HTML conversion text rendering issue|Bug|
|PDFNEWNET-37842|PDF to HTML: space between words lost|Bug|
|PDFNEWNET-39346|Unable to access ttf fonts for xfa forms|Bug|
|PDFNEWNET-40153|PDF to PDF/A - Output file is blank|Bug|
|PDFNEWNET-39973|HTML to PDF results into incorrect output|Bug|
|PDFNEWNET-39554|HTML to PDF: image is missing in resultant PDF document|Bug|
|PDFNEWNET-39299|HTML to PDF: centered image is rendered incorrectly|Bug|
|PDFNEWNET-39199|Append Html - Page Format Changes|Bug|
|PDFNEWNET-38592|PDF to HTML - Lines width issues|Bug|
|PDFNEWNET-40584|PDF to PDF/A - Resultant file is not compliant|Bug|
|PDFNEWNET-40027|PDF to PDFA3a conversion fails compliance test|Bug|
|PDFNEWNET-40324|PDF to PDF/A_3a - Resultant file is not PDF/A compliant|Bug|
|PDFNEWNET-38972|Font Export : Hinting info is lost|Bug|
#### **Public API and Backward Incompatible Changes**
We have introduced following API changes in this release.
## **Added APIs:**
- Method: Aspose.PDF.Annotations.XYZExplicitDestination.CreateDestination(Aspose.PDF.Page,System.Double,System.Double,System.Double,System.Boolean)
- Method: Aspose.PDF.Annotations.XYZExplicitDestination.CreateDestinationToUpperLeftCorner(Aspose.PDF.Page,System.Double)
- Method: Aspose.PDF.Annotations.XYZExplicitDestination.CreateDestinationToUpperLeftCorner(Aspose.PDF.Page)
- Method: Aspose.PDF.ColumnAdjustment.AutoFitToWindow
- Method: Aspose.PDF.Document.Convert(Aspose.PDF.PdfFormatConversionOptions)
- Method: Aspose.PDF.Document.Validate(Aspose.PDF.PdfFormatConversionOptions)
- Method: Aspose.PDF.Forms.TextBoxField.GetYOffset(System.Double,System.Double,System.Double,System.Double,System.Double)
- Method: Aspose.PDF.Forms.TextBoxField.GetVerticalOffset(System.Int32,System.Single,System.Double@)
- Property: Aspose.PDF.HtmlSaveOptions.UseZOrder
- Property: Aspose.PDF.HtmlSaveOptions.ConvertMarkedContentToLayers
- Property: Aspose.PDF.HtmlSaveOptions.MinimalLineWidth
- Property: Aspose.PDF.HtmlSaveOptions.PreventGlyphsGrouping
- Property: Aspose.PDF.LaTeXSaveOptions.PagesCount

Class: Aspose.PDF.Matrix

- Method: Aspose.PDF.Matrix.#ctor
- Method: Aspose.PDF.Matrix.#ctor(System.Double[])
- Method: Aspose.PDF.Matrix.#ctor(Aspose.PDF.Matrix)
- Method: Aspose.PDF.Matrix.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)
- Property: Aspose.PDF.Matrix.A
- Property: Aspose.PDF.Matrix.B
- Property: Aspose.PDF.Matrix.C
- Property: Aspose.PDF.Matrix.D
- Property: Aspose.PDF.Matrix.E
- Property: Aspose.PDF.Matrix.F
- Method: Aspose.PDF.Matrix.ToString
- Method: Aspose.PDF.Matrix.Equals(System.Object)
- Method: Aspose.PDF.Matrix.Rotation(System.Double)
- Method: Aspose.PDF.Matrix.GetAngle(Aspose.PDF.Rotation)
- Method: Aspose.PDF.Matrix.Multiply(Aspose.PDF.Matrix)
- Method: Aspose.PDF.Matrix.Add(Aspose.PDF.Matrix)
- Method: Aspose.PDF.Matrix.Transform(Aspose.PDF.Point)
- Method: Aspose.PDF.Matrix.Transform(Aspose.PDF.Rectangle)
- Method: Aspose.PDF.Matrix.Reverse
- Method: Aspose.PDF.Matrix.GetHashCode
- Method: Aspose.PDF.Operator.ConcatenateMatrix.#ctor(Aspose.PDF.Matrix)
- Method: Aspose.PDF.Operator.SetTextMatrix.#ctor(Aspose.PDF.Matrix)

Class: Aspose.PDF.PageMode

- Function: Aspose.PDF.PageMode.UseNone
- Function: Aspose.PDF.PageMode.UseOutlines
- Function: Aspose.PDF.PageMode.UseThumbs
- Function: Aspose.PDF.PageMode.FullScreen
- Function: Aspose.PDF.PageMode.UseOC
- Function: Aspose.PDF.PageMode.UseAttachments

Class: Aspose.PDF.PdfFormatConversionOptions

- Method: Aspose.PDF.PdfFormatConversionOptions.#ctor(System.String,Aspose.PDF.PdfFormat,Aspose.PDF.ConvertErrorAction)
- Method: Aspose.PDF.PdfFormatConversionOptions.#ctor(System.String,Aspose.PDF.PdfFormat)
- Method: Aspose.PDF.PdfFormatConversionOptions.#ctor(Aspose.PDF.PdfFormat)
- Method: Aspose.PDF.PdfFormatConversionOptions.#ctor(Aspose.PDF.PdfFormat,Aspose.PDF.ConvertErrorAction)
- Method: Aspose.PDF.PdfFormatConversionOptions.#ctor(System.String,Aspose.PDF.PdfFormat,Aspose.PDF.ConvertErrorAction,Aspose.PDF.ConvertTransparencyAction)
- Method: Aspose.PDF.PdfFormatConversionOptions.#ctor(System.IO.Stream,Aspose.PDF.PdfFormat,Aspose.PDF.ConvertErrorAction)
- Property: Aspose.PDF.PdfFormatConversionOptions.Format
- Property: Aspose.PDF.PdfFormatConversionOptions.LogFileName
- Property: Aspose.PDF.PdfFormatConversionOptions.LogStream
- Property: Aspose.PDF.PdfFormatConversionOptions.ErrorAction
- Property: Aspose.PDF.PdfFormatConversionOptions.TransparencyAction
- Property: Aspose.PDF.PdfFormatConversionOptions.Default
- Property: Aspose.PDF.PdfFormatConversionOptions.AlignText
- Property: Aspose.PDF.PdfFormatConversionOptions.PuaTextProcessingStrategy
- Function: Aspose.PDF.PdfFormatConversionOptions.AlignStrategy

Class: Aspose.PDF.PdfFormatConversionOptions.PuaProcessingStrategy

- Function: Aspose.PDF.PdfFormatConversionOptions.PuaProcessingStrategy.None
- Function: Aspose.PDF.PdfFormatConversionOptions.PuaProcessingStrategy.SurroundPuaTextWithEmptyActualText
- Function: Aspose.PDF.PdfFormatConversionOptions.PuaProcessingStrategy.SubstitutePuaSymbols

Class: Aspose.PDF.PdfFormatConversionOptions.SegmentAlignStrategy

- Function: Aspose.PDF.PdfFormatConversionOptions.SegmentAlignStrategy.None
- Function: Aspose.PDF.PdfFormatConversionOptions.SegmentAlignStrategy.RestoreSegmentBounds
## **Removed APIs:**
Class: Aspose.PDF.DOM.Matrix

- Method: Aspose.PDF.DOM.Matrix.#ctor
- Method: Aspose.PDF.DOM.Matrix.#ctor(System.Double[])
- Method: Aspose.PDF.DOM.Matrix.#ctor(Aspose.PDF.DOM.Matrix)
- Method: Aspose.PDF.DOM.Matrix.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)
- Property: Aspose.PDF.DOM.Matrix.A
- Property: Aspose.PDF.DOM.Matrix.B
- Property: Aspose.PDF.DOM.Matrix.C
- Property: Aspose.PDF.DOM.Matrix.D
- Property: Aspose.PDF.DOM.Matrix.E
- Property: Aspose.PDF.DOM.Matrix.F
- Method: Aspose.PDF.DOM.Matrix.ToString
- Method: Aspose.PDF.DOM.Matrix.Equals(System.Object)
- Method: Aspose.PDF.DOM.Matrix.Rotation(System.Double)
- Method: Aspose.PDF.DOM.Matrix.GetAngle(Aspose.PDF.Rotation)
- Method: Aspose.PDF.DOM.Matrix.Multiply(Aspose.PDF.DOM.Matrix)
- Method: Aspose.PDF.DOM.Matrix.Add(Aspose.PDF.DOM.Matrix)
- Method: Aspose.PDF.DOM.Matrix.Transform(Aspose.PDF.Point)
- Method: Aspose.PDF.DOM.Matrix.Transform(Aspose.PDF.Rectangle)
- Method: Aspose.PDF.DOM.Matrix.Reverse
- Method: Aspose.PDF.DOM.Matrix.GetHashCode

Class: Aspose.PDF.DOM.PageMode

- Function: Aspose.PDF.DOM.PageMode.UseNone
- Function: Aspose.PDF.DOM.PageMode.UseOutlines
- Function: Aspose.PDF.DOM.PageMode.UseThumbs
- Function: Aspose.PDF.DOM.PageMode.FullScreen
- Function: Aspose.PDF.DOM.PageMode.UseOC
- Function: Aspose.PDF.DOM.PageMode.UseAttachments
- Method: Aspose.PDF.Operator.ConcatenateMatrix.#ctor(Aspose.PDF.DOM.Matrix)
- Method: Aspose.PDF.Operator.SetTextMatrix.#ctor(Aspose.PDF.DOM.Matrix)
- Method: Aspose.PDF.XImageCollection.DeleteByIndex(System.Int32)
