---
title: Aspose.PDF for .NET 18.7 Release Notes
type: docs
weight: 60
url: /net/aspose-pdf-for-net-18-7-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 18.7](http://nuget.org/packages/Aspose.Pdf/18.7.0)

{{% /alert %}} 
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-37868|Remove all text from PDF file|New Feature|
|PDFNET-34403|Feature Request to Replace a Table using PdfContentEditor (as we have ReplaceText method)|New Feature|
|PDFNET-44635|PDF/UA: Validate Tagged of Real Content|New Feature|
|PDFNET-44636|PDF/UA: Validate Artifacts|New Feature|
|PDFNET-44863|PDF/UA: Recognize Natural Language|New Feature|
|PDFNET-44953|PDF/UA: Support Graphics Operators in Content Sequence Classes|New Feature|
|PDFNET-44638|PDF/UA: Validate Graphics|New Feature|
|PDFNET-44894|PDF/UA:Add support images in tagged content|New Feature|
|PDFNET-45035|PDF/UA:Add bounding box for images|New Feature|
|PDFNET-45036|PDF/UA:Add suporting image attributes|New Feature|
|PDFNET-44522|XML to PDF - the type Cell does not exists|Enhancement|
|PDFNET-43758|Implement using of Shading Colors for text editing scenarios|Enhancement|
|PDFNET-44923|Implement Radial (Type 3) Shadings|Enhancement|
|PDFNET-44847|Headings are missing in the output document.|Bug|
|PDFNET-43316|Incorrect retrieval of the rectangle coordinate LLX|Bug|
|PDFNET-36690|TextFragmentAbsorber does not replace flatten form text|Bug|
|PDFNET-37394|Text replace issue: long text is not being break to next line|Bug|
|PDFNET-39524|PDF to PDF/A_2a (A_2b) - Resultant file is not compliant|Bug|
|PDFNET-44169|PDF to PDF/A-1b - the output PDF does not pass compliance test|Bug|
|PDFNET-44577|Document is not PDF/A-3A compatible after conversion (CMYK used but output intent is not CMYK)|Bug|
|PDFNET-40082|PDF to PDFA3b: compliance failure due to LZW compression and CYMK color|Bug|
|PDFNET-44271|Turquoise image generated from PDF|Bug|
|PDFNET-44361|The repeating column header has been overwritten when generating PDF output.|Bug|
|PDFNET-44802|Some repeating columns are missing.|Bug|
|PDFNET-44803|The text in the repeating column is cut off.|Bug|
|PDFNET-44921|The conversion to PDFA_2A produces a XREF table with subsections|Bug|
|PDFNET-41329|PDF to PDFA1b: compliance verification issue - Integer value out of range(too high)|Bug|
|PDFNET-44075|PDF to PDF/A-1b - Output does not pass the compliance test|Bug|
|PDFNET-44076|PDF to PDF/A - missing text|Bug|
|PDFNET-44631|Multi byte characters not displayed in PDF|Bug|
|PDFNET-43883|PDF to PDF/A-1b problem|Bug|
|PDFNET-38751|PDF to PDFA2b/PDFA3b: Converting PDF, generated from Aspose.Cells, to PDFA2b and PDFA3b fails the compliance|Bug|
|PDFNET-43396|PDF to JPG - the square boxes are created in place of Chinese characters|Bug|
|PDFNET-41122|PDF to DOC - Page number is missing|Bug|
|PDFNET-37806|PDF to PDFA1b: stamp loses its transparency|Bug|
|PDFNET-37667|Text is not being extracted correctly.|Bug|
|PDFNET-44006|Getting Garbage Characters after setting Font property 'IsEmbedded=true'|Bug|
|PDFNET-36968|Searching/replacing of text with character spacing is not supported|Bug|
### **Public API changes in Aspose.PDF for .NET 18.7**
### **Added APIs:**
-----
Class Aspose.Pdf.Drawing.GradientRadialShading
Constructor Aspose.Pdf.Drawing.GradientRadialShading
Constructor Aspose.Pdf.Drawing.GradientRadialShading(Aspose.Pdf.Color,Aspose.Pdf.Color)
Property Aspose.Pdf.Drawing.GradientRadialShading.Start
Property Aspose.Pdf.Drawing.GradientRadialShading.End
Property Aspose.Pdf.Drawing.GradientRadialShading.StartingRadius
Property Aspose.Pdf.Drawing.GradientRadialShading.EndingRadius
Property Aspose.Pdf.Drawing.GradientRadialShading.StartColor
Property Aspose.Pdf.Drawing.GradientRadialShading.EndColor
Method Aspose.Pdf.TaggedPdf.TaggedPdfContent.Add(Aspose.Pdf.TaggedPdf.TaggedPdfFigureElement)
Method Aspose.Pdf.TaggedPdf.TaggedPdfDocumentElement.Add(Aspose.Pdf.Page,Aspose.Pdf.TaggedPdf.TaggedPdfFigureElement)
Class Aspose.Pdf.TaggedPdf.TaggedPdfFigureElement
Constructor Aspose.Pdf.TaggedPdf.TaggedPdfFigureElement(Aspose.Pdf.Document,Aspose.Pdf.Image,Aspose.Pdf.Rectangle)
Property Aspose.Pdf.TaggedPdf.TaggedPdfFigureElement.Page
Property Aspose.Pdf.TaggedPdf.TaggedPdfFigureElement.Tag
Constructor Aspose.Pdf.TaggedPdf.TaggedPdfTextElement(Aspose.Pdf.Document,System.String,System.String,Aspose.Pdf.Text.TextState)
Method Aspose.Pdf.TaggedPdf.TaggedPdfContent.Add(Aspose.Pdf.TaggedPdf.TaggedPdfFigureElement)
Method Aspose.Pdf.TaggedPdf.TaggedPdfDocumentElement.Add(Aspose.Pdf.Page,Aspose.Pdf.TaggedPdf.TaggedPdfFigureElement)
Class Aspose.Pdf.TaggedPdf.TaggedPdfFigureElement
Constructor Aspose.Pdf.TaggedPdf.TaggedPdfFigureElement(Aspose.Pdf.Document,Aspose.Pdf.Image,Aspose.Pdf.Rectangle)
Property Aspose.Pdf.TaggedPdf.TaggedPdfFigureElement.Page
Property Aspose.Pdf.TaggedPdf.TaggedPdfFigureElement.Tag
Constructor Aspose.Pdf.TaggedPdf.TaggedPdfTextElement(Aspose.Pdf.Document,System.String,System.String,Aspose.Pdf.Text.TextState)
Method Aspose.Pdf.Text.TableAbsorber.Remove(Aspose.Pdf.Text.AbsorbedTable)
Method Aspose.Pdf.Text.TableAbsorber.Replace(Aspose.Pdf.Page,Aspose.Pdf.Text.AbsorbedTable,Aspose.Pdf.Table)
Method Aspose.Pdf.Text.TextFragmentAbsorber.RemoveAllText(Aspose.Pdf.Page)
Method Aspose.Pdf.Text.TextFragmentAbsorber.RemoveAllText(Aspose.Pdf.Document)
### **Removed APIs:**
-----
TabAlignmentType was moved into Aspose.Pdf.Text namespace.
TabLeaderType was moved into Aspose.Pdf.Text namespace.
