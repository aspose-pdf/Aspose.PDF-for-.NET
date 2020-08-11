---
title: Aspose.PDF for Java 18.3 Release Notes
type: docs
weight: 100
url: /java/aspose-pdf-for-java-18-3-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 18.3](https://repository.aspose.com/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-pdf/18.3)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-34877|PDF to PDFA2a: Converting PDF, generated from Aspose.Cells, to PDFA2a fails the compliance (Linux)|Bug|
|PDFJAVA-37407|TIFF to PDF - a disordered image is created|Bug|
|PDFJAVA-36775|Text gets disturbed after replacements|Bug|
|PDFJAVA-36628|HTML to PDF - the width of PDF is increased|Bug|
|PDFJAVA-35943|PDF to HTML: Bold text is too heavy in FireFox|Bug|
|PDFJAVA-37529|An exception raises while redacting PDF document.|Bug|
|PDFJAVA-35423|PDF to PPTX - Pie Charts are not appearing properly|Bug|
|PDFJAVA-36289|PDF to HTML: text and lines are misplaced|Bug|
### **Public API changes**
Added new methods:
com.aspose.pdf.**DestinationCollection**.getExplicitDestination(String,boolean)
com.aspose.pdf.**MemoryCleaner**.clearCurrentThreadLocals()
com.aspose.pdf.**TextFragment**.isolateTextSegments(int,int)
com.aspose.pdf.**TextFragmentAbsorber**.getText()
com.aspose.pdf.**TextFragmentAbsorber**.applyForAllFragments(Font)
com.aspose.pdf.**TextFragmentAbsorber**.applyForAllFragments(float)
com.aspose.pdf.**TextFragmentAbsorber**.applyForAllFragments(Font,float)

Renamed the method:
com.aspose.pdf.nameddestinations.**INamedDestinationCollection**.getCount() -> com.aspose.pdf.nameddestinations.**INamedDestinationCollection**.size()
