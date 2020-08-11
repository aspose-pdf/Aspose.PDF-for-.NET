---
title: Aspose.PDF for Java 20.4 Release Notes
type: docs
weight: 10
url: /java/aspose-pdf-for-java-20-4-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PDF for Java 20.4.

{{% /alert %}} 
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-39349|Add the ability to use an image file as the background of a table cell|Enhancement|
|PDFJAVA-35652|PDF to Excel: table cell data is rendered in two rows|Bug|
|PDFJAVA-38622|Text wrap does not work with Japanese characters|Bug|
|PDFJAVA-38594|IllegalStateException with TextFragmentAbsorber|Bug|
## **Public API and Backwards Incompatible Changes**
#### **Enhancement - PDFJAVA-39349 Add the ability to use an image file as the background of a table cell**
#### **Example Usage**
{{< highlight java >}}

 Document doc = new Document();

Page page = doc.getPages().add();

Table tab1 = new Table();

page.getParagraphs().add(tab1);

tab1.setColumnWidths("400");

//Set default cell border using BorderInfo object

tab1.setDefaultCellBorder(new BorderInfo(BorderSide.All, 0.1F));

//Set table border using another customized BorderInfo object

tab1.setBorder(new BorderInfo(BorderSide.All, 1F));

Row row1 = tab1.getRows().add();

row1.setFixedRowHeight(60);

Cell cell = row1.getCells().add();

Image image = new Image();

image.setFile("image.jpg");

cell.setBackgroundImage(image);

doc.save("out.pdf");

{{< /highlight >}}

**Removed Internal Fields**

- com.aspose.pdf.Annotation._disableUpdateAppearance

**Deprecated Methods**

- com.aspose.pdf.Cell.getBackgroundImageFile()
- com.aspose.pdf.**Cell**.setBackgroundImageFile(String)

**New Methods**

- com.aspose.pdf.**Cell**.getBackgroundImage()
- com.aspose.pdf.**Cell**.setBackgroundImage(Image)

**Removed Fields**

- com.aspose.pdf.DocSaveOptions.CustomProgressHandler
- com.aspose.pdf.EpubLoadOptions.PageSizeAdjustmentMode
- com.aspose.pdf.EpubLoadOptions.MarginsAreaUsageMode

**New Methods**

- com.aspose.pdf.DocSaveOptions.getCustomProgressHandler()
- com.aspose.pdf.DocSaveOptions.setCustomProgressHandler(ConversionProgressEventHandler)
- com.aspose.pdf.EpubLoadOptions.getPageSizeAdjustmentMode()
- com.aspose.pdf.EpubLoadOptions.setPageSizeAdjustmentMode(int)
- com.aspose.pdf.EpubLoadOptions.getMarginsAreaUsageMode()
- com.aspose.pdf.EpubLoadOptions.setMarginsAreaUsageMode(int)
- com.aspose.pdf.TextParagraph.getHyphenSymbol()
- com.aspose.pdf.TextParagraph.setHyphenSymbol(String)

**Changes in Method Parameters**

- com.aspose.pdf.Document.optimizeResources(Document.OptimizationOptions) **->** com.aspose.pdf.Document.optimizeResources(com.aspose.pdf.optimization.OptimizationOptions)

**Deprecated Classes**

- com.aspose.pdf.LatexFragment
- com.aspose.pdf.LatexLoadOptions
- com.aspose.pdf.LaTeXSaveOptions

**New Classes**

- com.aspose.pdf.TeXFragment
- com.aspose.pdf.TeXLoadOptions
- com.aspose.pdf.TeXSaveOptions
