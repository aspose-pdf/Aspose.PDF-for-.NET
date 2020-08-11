---
title: Aspose.PDF for Java 19.5 Release Notes
type: docs
weight: 80
url: /java/aspose-pdf-for-java-19-5-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 19.5](https://repository.aspose.com/repo/com/aspose/aspose-pdf/19.5/)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-38366|Is Aspose.PDF FIPS 186-4 compliant|Enhancement|
|PDFJAVA-38541|The imported HTML content isn't properly wrapped in PDF output|Bug|
|PDFJAVA-38475|Multiline parsing of PDF through TextFragmentAbsorber with regex not working|Bug|
|PDFJAVA-38460|API is taking long time to convert HTML into PDF when images are from external URL|Bug|
|PDFJAVA-38457|License is not working in Azure VM|Bug|
|PDFJAVA-36436|An issue with aspose-pdf when running inside a web container|Bug|
|PDFJAVA-36957|PDF to PPTX - Different images in the document gets merged into a single image in the output file|Bug|
|PDFJAVA-37912|Exception while converting HTML to PDF|Bug|
|PDFJAVA-37833|Problem rendering HTML to PDF|Bug|
|PDFJAVA-37774|NullPointerException during HTML to PDF conversion|Bug|
|PDFJAVA-36341|PDF optimization generates an exception|Bug|
|PDFJAVA-36001|TIF to PDF: resultant PDF is empty|Bug|
|PDFJAVA-36473|PDF to PDFA: Resultant PDFA does not pass PDFA conformance|Bug|
### **Public API Changes**
**Renamed methods:** 

` `com.aspose.pdf.Document.getHideToolBar() -> com.aspose.pdf.Document.isHideToolBar()
com.aspose.pdf.Document.getHideMenubar() -> com.aspose.pdf.Document.isHideMenubar()
com.aspose.pdf.Document.getHideWindowUI() -> com.aspose.pdf.Document.isHideWindowUI()
com.aspose.pdf.Document.getFitWindow() -> com.aspose.pdf.Document.isFitWindow()
com.aspose.pdf.Document.getCenterWindow() -> com.aspose.pdf.Document.isCenterWindow()
com.aspose.pdf.Document.getDisplayDocTitle() -> com.aspose.pdf.Document.isDisplayDocTitle()

**Added new methods:** 

com.aspose.pdf.HtmlFragment.isBreakWords()
com.aspose.pdf.HtmlFragment.setBreakWords(boolean)

com.aspose.pdf.tagged.ITaggedContent.createTableTHeadElement()
com.aspose.pdf.tagged.ITaggedContent.createTableTBodyElement()
com.aspose.pdf.tagged.ITaggedContent.createTableTFootElement()
com.aspose.pdf.tagged.ITaggedContent.createTableTRElement()
com.aspose.pdf.tagged.ITaggedContent.createTableTHElement()
com.aspose.pdf.tagged.ITaggedContent.createTableTDElement()

com.aspose.pdf.tagged.logicalstructure.elements.bls.TableElement.createTHead()
com.aspose.pdf.tagged.logicalstructure.elements.bls.TableElement.createTBody()
com.aspose.pdf.tagged.logicalstructure.elements.bls.TableElement.createTFoot()

com.aspose.pdf.tagged.logicalstructure.elements.bls.TableTRElement.createTH()
com.aspose.pdf.tagged.logicalstructure.elements.bls.TableTRElement.createTD()

com.aspose.pdf.tagged.TaggedContent.createTableTHeadElement()
com.aspose.pdf.tagged.TaggedContent.createTableTBodyElement()
com.aspose.pdf.tagged.TaggedContent.createTableTFootElement()
com.aspose.pdf.tagged.TaggedContent.createTableTRElement()
com.aspose.pdf.tagged.TaggedContent.createTableTHElement()
com.aspose.pdf.tagged.TaggedContent.createTableTDElement()

com.aspose.pdf.TextFragmentState.getBackgroundColor()

com.aspose.pdf.TextSearchOptions.setDotallMode(boolean)
com.aspose.pdf.TextSearchOptions.isDotallMode()

com.aspose.pdf.XmpPdfAExtensionSchema.getProperty(String)

**Added new class:**

com.aspose.pdf.tagged.logicalstructure.elements.bls.TableRowCollectionElement

**Obsoleted:**

Please use TextSearchOptions.get/setSearchForTextRelatedGraphics instead those:
com.aspose.pdf.TextEditOptions.getToAttemptGetUnderlineFromSource
com.aspose.pdf.TextEditOptions.setToAttemptGetUnderlineFromSource(boolean)
