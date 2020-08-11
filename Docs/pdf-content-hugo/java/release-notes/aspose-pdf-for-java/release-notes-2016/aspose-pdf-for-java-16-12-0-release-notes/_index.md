---
title: Aspose.Pdf for Java 16.12.0 Release Notes
type: docs
weight: 10
url: /java/aspose-pdf-for-java-16-12-0-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNEWJAVA-34602|Support PDF/A_2U format|New Feature|
|PDFNEWJAVA-33928|Rendering a particular section of PDF document to Image|New Feature|
|PDFNEWJAVA-34779|PDF to PDF/A - resultant file size gets 17 times of the original PDF size|Bug|
|PDFNEWJAVA-34660|Text replace changes text Alignment to Left Aligned|Bug|
|PDFJAVA-36288|Missing methods in HtmlSaveOptions.HtmlPageMarkupSavingInfo|Bug|
|PDFJAVA-36182|PDF to JPEG: incorrect text characters rendering|Bug|
|PDFJAVA-36340|CallBack approach to load ResourceLoadingStrategy is showing errors|Bug|
|PDFJAVA-36178|PDF to DOCX - Right indent is not being honored|Bug|
|PDFJAVA-36180|PDF to DOCX: Paragraph indent values are not retained|Bug|
|PDFJAVA-36281|XPS to PDF - conversion process takes too much time|Bug|
|PDFJAVA-36102|PDF to PDF/A - Highlight box hides the image in PDF|Bug|
|PDFJAVA-36256|PDF to PPTX - Line spacing is lost|Bug|
|PDFJAVA-36324|Annotation Modified date set to 12:00 AM instead provided date|Bug|
|PDFJAVA-36002|PDF to PDF/A - Resultant file is not compliant|Bug|
|PDFJAVA-36291|Chinese Locale throws ExceptionInInitializerError exception|Bug|
|PDFNEWJAVA-34972|flatten() method throws NPE|Bug|
### **Public API Changes in Aspose.PDF for Java 16.11.0**
Changes in class **com.aspose.pdf.Annotation:** 
Added method:

com.aspose.pdf.Annotation.getRectangle(boolean)

Changes in class c**om.aspose.pdf.ImageDevice** and all the child classes(BmpDevice, EmfDevice, GifDevice, JpegDevice, PngDevice) recieved the methods:
Added methods:

com.aspose.pdf.devices.ImageDevice.getCropRectangle()
com.aspose.pdf.devices.ImageDevice.setCropRectangle(com.aspose.pdf.Rectangle)

Changes in class **com.aspose.pdf.TiffDevice:** 
Added methods:

com.aspose.pdf.devices.TiffDevice.getCropRectangle()
com.aspose.pdf.devices.TiffDevice.setCropRectangle(com.aspose.pdf.Rectangle)

Changes in class **com.aspose.pdf.DocSaveOptions:** 
Added methods:

com.aspose.pdf.DocSaveOptions.getMaxDistanceBetweenTextLines()
com.aspose.pdf.DocSaveOptions.setMaxDistanceBetweenTextLines(float)

Changes in class **com.aspose.pdf.Document.OptimizationOptions:** 
Added method:

com.aspose.pdf.Document.OptimizationOptions.isResizeImages()
com.aspose.pdf.Document.OptimizationOptions.setResizeImages(boolean)
com.aspose.pdf.Document.OptimizationOptions.getMaxResoultion()
com.aspose.pdf.Document.OptimizationOptions.setMaxResoultion(int)
com.aspose.pdf.Document.OptimizationOptions.isRemovePrivateInfo()
com.aspose.pdf.Document.OptimizationOptions.setRemovePrivateInfo(boolean)

Changes in class **com.aspose.pdf.FontCollection:** 
Added method:

com.aspose.pdf.FontCollection.add(Font)

Changes in class **com.aspose.pdf.LatexLoadOptions:** 
Added methods:

com.aspose.pdf.LatexLoadOptions.getResourceLoadingCallback()
com.aspose.pdf.LatexLoadOptions.setResourceLoadingCallback(IResourceLoadingCallback)

Changes in class **com.aspose.pdf.PageCollection:** 
Added methods:

com.aspose.pdf.PageCollection.add(java.util.List<Page>)
com.aspose.pdf.PageCollection.insert(int,Iterable<Page>)

Changes in class **com.aspose.pdf.PdfFormat:** 
Added fields:

com.aspose.pdf.PdfFormat.PDF_A_2U
com.aspose.pdf.PdfFormat.PDF_A_3U

Changes in class **com.aspose.pdf.PdfFormatConversionOptions:** 
Added methods:

com.aspose.pdf.PdfFormatConversionOptions.getOptimizeFileSize()
com.aspose.pdf.PdfFormatConversionOptions.setOptimizeFileSize(boolean)
com.aspose.pdf.PdfFormatConversionOptions.getExcludeFontsStrategy()
com.aspose.pdf.PdfFormatConversionOptions.setExcludeFontsStrategy(byte)

Implemented the following class: **com.aspose.pdf.PdfFormatConversionOptions.RemoveFontsStrategy** 
Added fields:

com.aspose.pdf.PdfFormatConversionOptions.RemoveFontsStrategy.RemoveDuplicatedFonts
com.aspose.pdf.PdfFormatConversionOptions.RemoveFontsStrategy.RemoveSimilarFontsWithDifferentWidths
com.aspose.pdf.PdfFormatConversionOptions.RemoveFontsStrategy.SubsetFonts

Changes in class **com.aspose.pdf.WarningInfo:** 
Changes constructor: public WarningInfo(WarningType type, String message) -> public WarningInfo(/* WarningType */int type, String message)

The enum class **com.aspose.pdf.WarningType** has been reorganized:
Added fields: 

com.aspose.pdf.WarningType.SourceFileCorruption
com.aspose.pdf.WarningType.DataLoss
com.aspose.pdf.WarningType.MajorFormattingLoss
com.aspose.pdf.WarningType.MinorFormattingLoss
com.aspose.pdf.WarningType.CompatibilityIssue
com.aspose.pdf.WarningType.InvalidInputStreamType
com.aspose.pdf.WarningType.UnexpectedContent
Removed old namesake fields.
