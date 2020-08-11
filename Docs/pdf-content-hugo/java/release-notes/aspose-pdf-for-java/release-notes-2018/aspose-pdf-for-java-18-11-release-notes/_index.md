---
title: Aspose.PDF for Java 18.11 Release Notes
type: docs
weight: 20
url: /java/aspose-pdf-for-java-18-11-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 18.11](https://repository.aspose.com/repo/com/aspose/aspose-pdf/18.11/)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-38063|Long time to extract text|Enhancement|
|PDFJAVA-37886|Slow PDF to PPTX conversion|Enhancement|
|PDFJAVA-37942|PDF to image test - "OutOfMemory Java heap space" exception while processing the second file in set (-Xmx is 1500m)|Bug|
|PDFJAVA-37680|PDF to PPTX export - index out of bound error occurred|Bug|
|PDFJAVA-38115|Failed to load PS document|Bug|
|PDFJAVA-38114|Aspose.Pdf does not work with Java 7|Bug|
|PDFJAVA-38062|OutOfMemoryException occurred while optimizing the PDF|Bug|
|PDFJAVA-38122|Failed to load TEX document|Bug|
|PDFJAVA-38121|OOME occurs while generating images|Bug|
|PDFJAVA-37799|java.lang.ArrayIndexOutOfBoundsException Exception occurred while extracting text|Bug|
|PDFJAVA-38109|TIFF to PDF - Dark Colors are converted as black in output|Bug|
|PDFJAVA-37706|Cannot extract table and its data using TableAbsorber|Bug|
|PDFJAVA-37053|SVG turned out to be black and white while adding into table|Bug|
### **Public API Changes**
com.aspose.pdf.**Document**.**OptimizationOptions** marked as Deprecated

Removed:
com.aspose.pdf.Document.OptimizationOptions.getLinkDuplcateStreams()
com.aspose.pdf.Document.OptimizationOptions.setLinkDuplcateStreams(boolean)
com.aspose.pdf.Document.OptimizationOptions.getAllowReusePageContent()
com.aspose.pdf.Document.OptimizationOptions.setAllowReusePageContent(boolean)
com.aspose.pdf.Document.OptimizationOptions.getRemoveUnusedStreams()
com.aspose.pdf.Document.OptimizationOptions.setRemoveUnusedStreams(boolean)
com.aspose.pdf.Document.OptimizationOptions.getRemoveUnusedObjects()
com.aspose.pdf.Document.OptimizationOptions.setRemoveUnusedObjects(boolean)
com.aspose.pdf.Document.OptimizationOptions.isCompressImages()
com.aspose.pdf.Document.OptimizationOptions.setCompressImages(boolean)
com.aspose.pdf.Document.OptimizationOptions.isResizeImages()
com.aspose.pdf.Document.OptimizationOptions.setResizeImages(boolean)
com.aspose.pdf.Document.OptimizationOptions.getImageQuality()
com.aspose.pdf.Document.OptimizationOptions.setImageQuality(int)
com.aspose.pdf.Document.OptimizationOptions.getMaxResoultion()
com.aspose.pdf.Document.OptimizationOptions.setMaxResoultion(int)
com.aspose.pdf.Document.OptimizationOptions.isUnembedFonts()
com.aspose.pdf.Document.OptimizationOptions.setUnembedFonts(boolean)
com.aspose.pdf.Document.OptimizationOptions.isRemovePrivateInfo()
com.aspose.pdf.Document.OptimizationOptions.setRemovePrivateInfo(boolean)
Please use Aspose.Pdf.Optimization.OptimizationOptions instead.
Added new class:
com.aspose.pdf.optimization.**ImageCompressionOptions** 
com.aspose.pdf.optimization.ImageCompressionOptions.getCompressImages()
com.aspose.pdf.optimization.ImageCompressionOptions.setCompressImages(boolean)
com.aspose.pdf.optimization.ImageCompressionOptions.getResizeImages()
com.aspose.pdf.optimization.ImageCompressionOptions.setResizeImages(boolean)
com.aspose.pdf.optimization.ImageCompressionOptions.getImageQuality()
com.aspose.pdf.optimization.ImageCompressionOptions.setImageQuality(int)
com.aspose.pdf.optimization.ImageCompressionOptions.getMaxResolution()
com.aspose.pdf.optimization.ImageCompressionOptions.setMaxResolution(int)
com.aspose.pdf.optimization.ImageCompressionOptions.getVersion()
com.aspose.pdf.optimization.ImageCompressionOptions.setVersion(int)
T:com.aspose.pdf.optimization.ImageCompressionVersion
F:com.aspose.pdf.optimization.ImageCompressionVersion.Standard
F:com.aspose.pdf.optimization.ImageCompressionVersion.Fast
F:com.aspose.pdf.optimization.ImageCompressionVersion.Mixed

Added new class:
com.aspose.pdf.exceptions.**TaggedPdfException**()

Added new methods:
com.aspose.pdf.**TextFragmentAbsorber**.removeAllText(Page,Rectangle)
com.aspose.pdf.**TextFragment**.setHyperlink(Hyperlink)
com.aspose.pdf.**TextFragment**.setMarkedContentProperties(String,int)
com.aspose.pdf.**PdfFormatConversionOptions**.addNotAccessibleFont(String)
