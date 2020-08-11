---
title: Aspose.PDF for Java 19.11 Release Notes
type: docs
weight: 20
url: /java/aspose-pdf-for-java-19-11-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PDF for Java 19.11.

{{% /alert %}} 
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-37568|` `Support for WCAG 2.0 compliance|New Feature|
|PDFJAVA-38671    |PDF to TIFF - Diagrams are missing in output TIFF images|Bug|
|PDFJAVA-38968|Null pointer getting Image Raw Parameters|Bug|
|PDFJAVA-38906|Problem detecting blank pages|Bug|
|PDFJAVA-38931|Problem converting PDF to PDF/A|Bug|
|PDFJAVA-39012|Incorrect TextFragment.getSegments() behavior after TextFragmentAbsorber|Bug|
|PDFJAVA-39011|NullReferenceException on reading Artifact.getText()|Bug|
|PDFJAVA-38403|License is not set while converting Image To PDF|Bug|
|PDFJAVA-38959|Exception when loading Ps|Bug|
|PDFJAVA-38992   |Aspose.PDF 19.10: Exception when saving PDF|Bug|
|PDFJAVA-38452|HTML to PDF - Requested font type subsetting is not supported (Linux)|Bug|
|PDFJAVA-36828|Long string replace does not format correctly|Bug|
## **Public API and Backwards Incompatible Changes**
AdditionalMarginWidthInPoints methods are deprecated, please use field PageMarginIfAny instead.
com.aspose.pdf.**HtmlSaveOptions**.getAdditionalMarginWidthInPoints()
com.aspose.pdf.**HtmlSaveOptions**.setAdditionalMarginWidthInPoints(int)

**Added fields** 
com.aspose.pdf.**HtmlSaveOptions**.PageMarginIfAny
com.aspose.pdf.**HtmlSaveOptions**.LettersPositioningMethod
com.aspose.pdf.**SaveOptions**.MarginInfo

**Added classes**

com.aspose.pdf.**IPageSetOptions** 
com.aspose.pdf.**IPipelineOptions**

**Added Methods** 
com.aspose.pdf.**HtmlSaveOptions**.getExplicitListOfSavedPages()
com.aspose.pdf.**HtmlSaveOptions**.setExplicitListOfSavedPages(int[])
com.aspose.pdf.**HtmlSaveOptions**.getBatchSize()
com.aspose.pdf.**HtmlSaveOptions**.setBatchSize(int)
com.aspose.pdf.**TextFragmentState**.getFontStyle()
com.aspose.pdf.**TextState**.getFontStyle()
com.aspose.pdf.**TocInfo**.getPageNumbersPrefix()
com.aspose.pdf.**TocInfo**.setPageNumbersPrefix(String)
com.aspose.pdf.**XpsLoadOptions**.getBatchSize()
com.aspose.pdf.**XpsLoadOptions**.setBatchSize(int)
com.aspose.pdf.**XpsSaveOptions**.getBatchSize()
com.aspose.pdf.**XpsSaveOptions**.setBatchSize(int)

**Removed methods** 
com.aspose.pdf.**HtmlSaveOptions**.getProcessingBatchSize
com.aspose.pdf.**HtmlSaveOptions**.setProcessingBatchSize(int)
com.aspose.pdf.**Table**.setMcName(String)
com.aspose.pdf.**Table**.getMcId()
com.aspose.pdf.**Table**.setMcId(int)

**Removed fields** 
com.aspose.pdf.**HtmlSaveOptions**.LettersPositioningMethod
com.aspose.pdf.**HtmlSaveOptions**.ExplicitListOfSavedPages
