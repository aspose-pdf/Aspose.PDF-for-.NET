---
title: Aspose.PDF for Java 19.3 Release Notes
type: docs
weight: 100
url: /java/aspose-pdf-for-java-19-3-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 19.3](https://repository.aspose.com/repo/com/aspose/aspose-pdf/19.3/)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-38453|Add a field to the ScreenAnnotation class that provides access to the annotation resource|New Feature|
|PDFJAVA-38446|NullPointerException occurred while adding text stamp|Bug|
|PDFJAVA-38445|NullPointerException occurred while adding text stamp|Bug|
|PDFJAVA-37369|Sign a password protected PDF file|Bug|
|PDFJAVA-38403|License is not set while converting Image To PDF|Bug|
|PDFJAVA-38155|The footer shifts down and disappear for multiple page|Bug|
### **Public API Changes**
**Added the following methods:** 
com.aspose.pdf.**ExplicitDestination**.toString()
com.aspose.pdf.**FontRepository**.clear()
com.aspose.pdf.**IAppointment**.toString()
com.aspose.pdf.**RenditionAction**.getRendition()
com.aspose.pdf.**RenditionAction**.getRenditionOperation()
com.aspose.pdf.**RenditionAction**.setRenditionOperation(int)
com.aspose.pdf.**RenditionAction**.getJavaScript()
com.aspose.pdf.**RenditionAction**.setJavaScript(String)
com.aspose.pdf.**Signature**.getCustomAppearance()
com.aspose.pdf.**Signature**.setCustomAppearance(SignatureCustomAppearance)
com.aspose.pdf.tagged.logicalstructure.elements.**StructureElement**.getID()
com.aspose.pdf.**OutlineItemCollection**.hasNext()
com.aspose.pdf.**PdfAction**.toString()
com.aspose.pdf.tagged.logicalstructure.elements.**StructureElement**.generateId()
com.aspose.pdf.tagged.logicalstructure.elements.**StructureElement**.setId(String)
com.aspose.pdf.tagged.logicalstructure.elements.**StructureElement**.clearId()
com.aspose.pdf.tagged.logicalstructure.**StructTreeRootElement**.getIDTree()
com.aspose.pdf.**TextFormattingOptions**.getFirstLineIndent()
com.aspose.pdf.**TextFormattingOptions**.setFirstLineIndent(float)
com.aspose.pdf.**TextParagraph**.getFirstLineIndent()
com.aspose.pdf.**TextParagraph**.setFirstLineIndent(float)

**Added the following fields:** 
com.aspose.pdf.taggedpdf.**TaggedPdfExceptionCode**.StructureElement_StructureElementWithIdAlreadyExists
com.aspose.pdf.taggedpdf.**TaggedPdfExceptionCode**.StructureElement_StructureElementIdCanNotBeNullOrEmpty

**Added the following classes:** 
com.aspose.pdf.**MediaClip** 
com.aspose.pdf.**MediaClipData** 
com.aspose.pdf.**MediaClipSection** 
com.aspose.pdf.**MediaRendition** 
com.aspose.pdf.**Rendition** 
com.aspose.pdf.**RenditionOperation** 
com.aspose.pdf.**RenditionType** 
com.aspose.pdf.**SelectorRendition** 
com.aspose.pdf.**SignatureCustomAppearance**
