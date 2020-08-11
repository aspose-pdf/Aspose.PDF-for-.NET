---
title: Aspose.PDF for Java 18.12 Release Notes
type: docs
weight: 10
url: /java/aspose-pdf-for-java-18-12-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 18.12](https://repository.aspose.com/repo/com/aspose/aspose-pdf/18.12/)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-37958|Test compatibility with JDK 10|Enhancement|
|PDFJAVA-38080|Aspose.PDF compatibility with JDK 11|Enhancement|
|PDFJAVA-38102|NullPointerException while extracting text|Bug|
|PDFJAVA-38107|BadPaddingException while setting a license |Bug|
|PDFJAVA-35163|PCL to PDF - Resultant file is not correct|Bug|
|PDFJAVA-38241|The bold style configuration for some fonts isn't accepted.|Bug|
|PDFJAVA-38186|java.lang.ClassCastException while saving PDF|Bug|
### **Public API Changes**
**Added new classes:**

com.aspose.pdf.exceptions.PdfArgumentException
com.aspose.pdf.optimization.ImageEncoding
com.aspose.pdf.optimization.OptimizationOptions
com.aspose.pdf.tagged.ITaggedContent
com.aspose.pdf.tagged.logicalstructure.AttributeOwnerStandard
com.aspose.pdf.tagged.logicalstructure.ElementList
com.aspose.pdf.tagged.logicalstructure.elements.bls.BLSElement
com.aspose.pdf.tagged.logicalstructure.elements.bls.BLSTextElement
com.aspose.pdf.tagged.logicalstructure.elements.bls.HeaderElement
com.aspose.pdf.tagged.logicalstructure.elements.bls.ListChildElement
com.aspose.pdf.tagged.logicalstructure.elements.bls.ListElement
com.aspose.pdf.tagged.logicalstructure.elements.bls.ListLblElement

**Added new field** 
com.aspose.pdf.ImageFilterType.Flate

**Added new methods:** 
com.aspose.pdf.optimization.ImageCompressionOptions.getEncoding()
com.aspose.pdf.optimization.ImageCompressionOptions.setEncoding(int)
com.aspose.pdf.Page.getBackgroundImage()
com.aspose.pdf.Page.setBackgroundImage(com.aspose.pdf.Image)

**Renamed class:** 
com.aspose.pdf.exceptions.TaggedPdfException -> com.aspose.pdf.exceptions.TaggedException

**Renamed package:** 
com.aspose.pdf.taggedpdf -> com.aspose.pdf.tagged
