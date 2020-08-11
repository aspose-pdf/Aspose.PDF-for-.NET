---
title: Aspose.PDF for Java 19.10 Release Notes
type: docs
weight: 30
url: /java/aspose-pdf-for-java-19-10-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PDF for Java 19.10.

{{% /alert %}} 
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-33163|Converting [Searchable PDF to XPS](/pdf/java/convert-pdf-to-other-formats/#convertpdftootherformats-keeptextselectableinoutputxps) (Keeping Text Selectable in resultant XPS) |New Feature|
|PDFJAVA-34842|Support PDF/UA format|New Feature|
|PDFJAVA-38309 |Hide the [spanned cell border](/pdf/java/add-table-in-existing-pdf-document/#addtableinexistingpdfdocument-hidespannedcellborders) if broken to another row Enhancements|New Feature|
|PDFJAVA-38884 |Set export value of Checkbox|Enhancement|
|PDFJAVA-38943|Footers are missing after adding headers/footers to a document with mixed orientation|Enhancement|
|PDFJAVA-38410|PDF to DOCX - Text is shifted upwards|Bug|
|PDFJAVA-38411|PDF to DOCX - Text is shifted to left|Bug|
|PDFJAVA-38916|Exception on getModDate()|Bug|
|PDFJAVA-38823|Initializing the licence takes 3-4 minutes|Bug|
|PDFJAVA-38824|The java pdf license in Google Append Engine (GAE Flex) is very slow|Bug|
|PDFJAVA-38361|Exception when saving PCL into HTML|Bug|
|PDFJAVA-38437 |The text substitution doesn't work correctly.|Bug|
|PDFJAVA-38338|The contact field in the signature rectangle is missing|Bug|
|PDFJAVA-38736 |HTML to PDF no longer supports images embedded in HTML|Bug|
|PDFJAVA-36865 |Memory consumption issues when|Bug|
|PDFJAVA-37810 |The HTML fragment looks different regarding the original HTML file|Bug|
|PDFJAVA-37909 |Merging PDF Documents - issue with radio buttons in output|Bug|
|PDFJAVA-38911|IllegalStateException while extracting text|Bug|
|PDFJAVA-38739|ArrayIndexOutOfBoundsException during PDF to DOCX|Bug|
|PDFJAVA-38398|The margins are not preserved in DOCX output|Bug|
|PDFJAVA-38740|Very slow license loading|Bug|
## **Public API and Backward Incompatible Changes**
Removed Methods

- com.aspose.pdf.HtmlLoadOptions.isPdfUaConverting()
- com.aspose.pdf.HtmlLoadOptions.setPdfUaConverting(boolean)

New Methods

- com.aspose.pdf.License.isInternalFIPSSecurity()
- com.aspose.pdf.License.setInternalFIPSSecurity(boolean)
- com.aspose.pdf.MhtLoadOptions.getPageInfo()
- com.aspose.pdf.RenderingOptions.getOptimizeDimensions()
- com.aspose.pdf.RenderingOptions.setOptimizeDimensions(boolean)

New constructors for class TextFragmentAbsorber

- com.aspose.pdf.TextFragmentAbsorber:TextFragmentAbsorber(java.util.regex.Pattern)
- TextFragmentAbsorber(java.util.regex.Pattern,TextSearchOptions)
- TextFragmentAbsorber(java.util.regex.Pattern,TextEditOptions)

Added new option in class com.aspose.pdf.SvgSaveOptions

- public boolean ScaleToPixels = true;
