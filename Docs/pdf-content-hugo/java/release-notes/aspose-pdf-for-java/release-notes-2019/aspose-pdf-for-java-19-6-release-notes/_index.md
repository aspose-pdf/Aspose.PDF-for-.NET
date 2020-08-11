---
title: Aspose.PDF for Java 19.6 Release Notes
type: docs
weight: 70
url: /java/aspose-pdf-for-java-19-6-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 19.6](https://repository.aspose.com/repo/com/aspose/aspose-pdf/19.6/)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-37121|Use of Latex script to add mathematical expressions/formulas in the table cell|Feature|
|PDFJAVA-38431|The text fragment is improperly aligned after the text replacement|Bug|
|PDFJAVA-38607 |Aspose.PDF Java - PdfFileEditor leaking file handles during concatenation|Bug|
|PDFJAVA-38627|Retain TextSegmentCollection after clearing text of TextFragment|Bug|
|PDFJAVA-38313|Critical Performance Issue|Bug|
|PDFJAVA-38579|Some digits missing when the pdf file is converted to an image|Bug|
|PDFJAVA-38384|Table with Checkboxes leads to Nullpointer at the page break|Bug|
|PDFJAVA-38389|OutOfMemory exception when saving PDF|Bug|
|PDFJAVA-37192|HTML to PDF - some elements are absent when using Linux|Bug|
|PDFJAVA-38587|PDF to PPTX: Fix issues with nested getters and setters when compiling to Java|Bug|
|PDFJAVA-37283|HTML to PDF: Hung up after migration to new version of Aspose.HTML|Bug|
|PDFJAVA-37501|NullPointerException if add LatexFragment in Linux|Bug|
|PDFJAVA-37274|SVG to PDF - the gradient color of the shape is changed to the solid color|Bug|
|PDFJAVA-38363|Error message when saving PCL file|Bug|
|PDFJAVA-38107|BadPaddingException while setting a license|Bug|
### **Public API Changes**
**Renamed methods:** 

com.aspose.pdf.facades.PdfAnnotationEditor.**importAnnotationFromXfdf**(String) ->> com.aspose.pdf.facades.PdfAnnotationEditor.**importAnnotationsFromXfdf**(String)
com.aspose.pdf.facades.PdfAnnotationEditor.**importAnnotationFromXfdf**(InputStream,int[]) ->> com.aspose.pdf.facades.PdfAnnotationEditor.**importAnnotationsFromXfdf**(InputStream,int[])
com.aspose.pdf.facades.PdfAnnotationEditor.**importAnnotationFromXfdf**(InputStream) ->> com.aspose.pdf.facades.PdfAnnotationEditor.**importAnnotationsFromXfdf**(InputStream)

**Added new methods:**

com.aspose.pdf.**CheckboxField**.deepClone()
com.aspose.pdf.**EpubLoadOptions**.setMargin(MarginInfo)
com.aspose.pdf.facades.**PdfAnnotationEditor**.exportAnnotationsToXfdf(java.io.OutputStream)
com.aspose.pdf.**FreeTextAnnotation**.getCallout()
com.aspose.pdf.**FreeTextAnnotation**.setCallout(Point[])
com.aspose.pdf.**Image**.convertToJpeg(InputStream)
com.aspose.pdf.**Image**.#ctor
com.aspose.pdf.**PdfFormatConversionOptions**.getTransparencyResolution()
com.aspose.pdf.**PdfFormatConversionOptions**.setTransparencyResolution(int)
com.aspose.pdf.**RenderingOptions**.getDefaultFontName()
com.aspose.pdf.**RenderingOptions**.setDefaultFontName(String)
com.aspose.pdf.**Table**.setMcName(String)
com.aspose.pdf.**Table**.getMcId()
com.aspose.pdf.**Table**.setMcId(int)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getTable()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getBackgroundColor()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setBackgroundColor(Color)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getBorder()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setBorder(BorderInfo)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getAlignment()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setAlignment(int)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getCornerStyle()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setCornerStyle(int)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getBroken()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setBroken(int)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getColumnAdjustment()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setColumnAdjustment(int)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getColumnWidths()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setColumnWidths(String)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getDefaultCellBorder()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setDefaultCellBorder(BorderInfo)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getDefaultCellPadding()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setDefaultCellPadding(MarginInfo)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getDefaultCellTextState()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setDefaultCellTextState(TextState)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getDefaultColumnWidth()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setDefaultColumnWidth(String)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.isBroken()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setBroken(boolean)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.isBordersIncluded()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setBordersIncluded(boolean)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getLeft()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setLeft(float)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getTop()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setTop(float)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getRepeatingColumnsCount()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setRepeatingColumnsCount(int)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getRepeatingRowsCount()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setRepeatingRowsCount(int)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.getRepeatingRowsStyle()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableElement**.setRepeatingRowsStyle(TextState)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.getBackgroundColor()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.setBackgroundColor(Color)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.getBorder()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.setBorder(BorderInfo)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.getDefaultCellBorder()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.setDefaultCellBorder(BorderInfo)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.getMinRowHeight()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.setMinRowHeight(double)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.getFixedRowHeight()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.setFixedRowHeight(double)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.isInNewPage()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.setInNewPage(boolean)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.isRowBroken()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.setRowBroken(boolean)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.getDefaultCellTextState()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.setDefaultCellTextState(TextState)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.getDefaultCellPadding()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.setDefaultCellPadding(MarginInfo)
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.getVerticalAlignment()
com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableTRElement**.setVerticalAlignment(int)
com.aspose.pdf.tagged.logicalstructure.elements.**StructureElement**.getDefaultAttributeOwner()
com.aspose.pdf.tagged.logicalstructure.elements.**StructureElement**.getS()
com.aspose.pdf.tagged.logicalstructure.**StructureAttributes**.hasAttribute(AttributeKey)
com.aspose.pdf.tagged.**TaggedContext**.getNextMCID()
com.aspose.pdf.tagged.**TaggedContext**.pageRegisterTableElement(Page,TableElement)
com.aspose.pdf.**TextSegment**.setTextSuppressedUpdate(String)
com.aspose.pdf.**TextState**.setFontSizeSuppressedUpdate(float)
com.aspose.pdf.**TextState**.setFontSuppressedUpdate(Font)

**Added new class:**

com.aspose.pdf.tagged.logicalstructure.elements.bls.**TableCellElement**
