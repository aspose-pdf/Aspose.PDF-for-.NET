---
title: Aspose.PDF for Java 19.2 Release Notes
type: docs
weight: 110
url: /java/aspose-pdf-for-java-19-2-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 19.2](https://repository.aspose.com/repo/com/aspose/aspose-pdf/19.2/)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-38332|Use addLocalFontPath and setLocalFontPaths at Global level  |Enhancement|
|PDFJAVA-38244|Create tagged element for footnotes|Bug|
|PDFJAVA-38255|HTML to PDF - Thread lock occurs during execution|Bug|
|PDFJAVA-38382|PDF to PPTX: Implement image comparison for visual tests|Bug|
|PDFJAVA-38354|PDF to XLSX: Create a new API|Bug|
### **Public API Changes**
#### **Added new classes:**
com.aspose.pdf.ExternalSignature

com.aspose.pdf.tagged.logicalstructure.AttributeKey

com.aspose.pdf.tagged.logicalstructure.AttributeName

com.aspose.pdf.tagged.logicalstructure.elements.StructureAttribute

com.aspose.pdf.taggedpdf.TaggedPdfInlineTextElement
#### **Added new methods:**
com.aspose.pdf.FontRepository.isThreadStaticConfigEnabled
com.aspose.pdf.FontRepository.setThreadStaticConfigEnabled(boolean)
com.aspose.pdf.HtmlLoadOptions.isPdfUaConverting
com.aspose.pdf.HtmlLoadOptions.setPdfUaConverting(boolean)
com.aspose.pdf.LatexLoadOptions.getUseTempFile
com.aspose.pdf.LatexLoadOptions.setUseTempFile(boolean)
com.aspose.pdf.MovieAnnotation.getPoster
com.aspose.pdf.MovieAnnotation.getPoster
com.aspose.pdf.MovieAnnotation.setPoster(boolean)
com.aspose.pdf.MovieAnnotation.getRotate
com.aspose.pdf.MovieAnnotation.setRotate(int)
com.aspose.pdf.tagged.logicalstructure.AttributeOwnerStandard.getOwner
com.aspose.pdf.tagged.logicalstructure.elements.IllustrationElement.setImage(String,double)
com.aspose.pdf.tagged.logicalstructure.elements.IllustrationElement.setImage(String,double,double)
com.aspose.pdf.tagged.logicalstructure.StructureAttributeCollection.createAttributes(AttributeOwnerStandard)
com.aspose.pdf.tagged.logicalstructure.StructureAttributes.getOwner
com.aspose.pdf.tagged.logicalstructure.StructureAttributes.getAttribute(AttributeKey)
com.aspose.pdf.tagged.logicalstructure.StructureAttributes.setAttribute(StructureAttribute)
com.aspose.pdf.taggedpdf.TaggedPdfBlockLevelTextElement.#ctor(IDocument,String,String,TextState,boolean)
com.aspose.pdf.taggedpdf.TaggedPdfElement.setPage(Page)
com.aspose.pdf.taggedpdf.TaggedPdfH1Element.#ctor(Document,String,TextState,boolean)
com.aspose.pdf.taggedpdf.TaggedPdfH2Element.#ctor(Document,String,TextState,boolean)
com.aspose.pdf.taggedpdf.TaggedPdfH3Element.#ctor(Document,String,TextState,boolean)
com.aspose.pdf.taggedpdf.TaggedPdfH4Element.#ctor(Document,String,TextState,boolean)
com.aspose.pdf.taggedpdf.TaggedPdfH5Element.#ctor(Document,String,TextState,boolean)
com.aspose.pdf.taggedpdf.TaggedPdfH6Element.#ctor(Document,String,TextState,boolean)
#### **Added feilds:**
com.aspose.pdf.taggedpdf.TaggedPdfContent.isConverting
com.aspose.pdf.taggedpdf.TaggedPdfExceptionCode.StructureAttribute_AttributeCollectionIsAbsent
com.aspose.pdf.taggedpdf.TaggedPdfExceptionCode.StructureAttribute_AttributeOwnerMustBe
com.aspose.pdf.taggedpdf.TaggedPdfExceptionCode.StructureAttribute_DoesntAllowValue
com.aspose.pdf.taggedpdf.TaggedPdfExceptionCode.StructureAttribute_ArrayMustContainXElements
com.aspose.pdf.taggedpdf.TaggedPdfExceptionCode.StructureAttribute_ValueWasNotInitialized
#### **Removed methods:**
com.aspose.pdf.Form.copyTo(Array,int)
com.aspose.pdf.Page.getTaggedPdfContent
com.aspose.pdf.tagged.logicalstructure.StructureAttributes.updateNumber(String,double)
com.aspose.pdf.tagged.logicalstructure.StructureAttributes.updateString(String,String)
com.aspose.pdf.tagged.logicalstructure.StructureAttributes.updateRectangle(String,Rectangle)
#### **Changed method's parameters:**
class com.aspose.pdf.AppearanceDictionary:copyTo(Array,int) -> copyTo(XForm[],int)
class com.aspose.pdf.tagged.helpers.StructureElementUtil:setImageToMCRElement(StructureElement,String) -> setImageToMCRElement(StructureElement,String,Double[],Double[],Double[])
#### **Added new exception class:**
com.aspose.pdf.exceptions.NotImplementedException
com.aspose.pdf.exceptions.TaggedException
#### **Extract class:**
com.aspose.pdf.UnifiedSaveOptions.ProgressEventType -> com.aspose.pdf.ProgressEventType
#### **Changes in Class StructureTextState:**
##### **Removed methods:**
initDefault
##### **Removed fields:**
Font
FontSize
FontStyle
ForegroundColor
MarginInfo
##### **Added methods:**
getFont
setFont(Font)
getFontSize
setFontSize(Float)
getFontStyle
setFontStyle(Integer)
getForegroundColor
setForegroundColor(Color)
getBackgroundColor
setBackgroundColor(Color)
getStrikeOut
setStrikeOut(Boolean)
getSuperscript
setSuperscript(Boolean)
#### **Methods moved from Class Document to Class FontRepository:**
addLocalFontPath
getLocalFontPaths
setLocalFontPaths
restoreLocalFontPath
