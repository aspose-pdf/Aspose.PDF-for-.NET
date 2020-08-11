---
title: Aspose.PDF for Java 18.5 Release Notes
type: docs
weight: 80
url: /java/aspose-pdf-for-java-18-5-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 18.5](https://repository.aspose.com/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-pdf/18.5)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-37766|DefaultFontName setting when saving Pdf as Pdf|Feature|
|PDFJAVA-37767|Implement functionality to get all fonts from document|Feature|
|PDFJAVA-37678|NullPointerException when saving PDF as HTML|Bug|
|PDFJAVA-37705|Aspose.Pdf 18.4 throws exception "Incomplete private key - missing CRT." when signing document with .pfx file|Bug|
|PDFJAVA-33941|PDF to HTML: Extra space is being rendered with commos|Bug|
|PDFJAVA-34720|Text goes beyond the page after replacing|Bug|
|PDFJAVA-34535|PDF to HTML - Hyperlinks are removed in resultant file|Bug|
### **Public API Changes**
Added new methods:
com.aspose.pdf.**ArtifactCollection**.isReadOnly()
com.aspose.pdf.**ArtifactCollection**.addItem(Artifact)
com.aspose.pdf.**ArtifactCollection**.clear()
com.aspose.pdf.**ArtifactCollection**.containsItem(Artifact)
com.aspose.pdf.**ArtifactCollection**.copyToTArray(Artifact[],int)
com.aspose.pdf.**ArtifactCollection**.removeItem(Artifact)
com.aspose.pdf.**ArtifactCollection**.contains(Artifact)
com.aspose.pdf.**ArtifactCollection**.remove(Artifact)
com.aspose.pdf.Document.**IDocumentFontUtilities**.getAllFonts
com.aspose.pdf.**Heading**.cloneWithSegments()
com.aspose.pdf.**MemoryCleaner**.clearStaticInstances()
com.aspose.pdf.**PdfSaveOptions**.getDefaultFontName()
com.aspose.pdf.**PdfSaveOptions**.setDefaultFontName(String)
com.aspose.pdf.**Rectangle**.contains(Point)
com.aspose.pdf.**Rectangle**.center()
com.aspose.pdf.**TextFragment**.cloneWithSegments()

Renamed method:
com.aspose.pdf.**IDocument**.getPdfaFormat() -> com.aspose.pdf.IDocument.getPdfFormat()

Added new constructor for the class com.aspose.pdf.text.**SimpleFontSubstitution**:
public SimpleFontSubstitution(String originalFontName, String substitutionFontName, boolean isForcedBySaveOption)

Added new fiels in the class com.aspose.pdf.**ImageFileType**:
public static final int Base64 = 3;

Added new fiels in the class com.aspose.pdf.**PdfFormat**:
public static final int PDF_UA_1 = 13;
changed field values:
public static final int PDF_X_1A = 13; -> public static final int PDF_X_1A = 14;
public static final int PDF_X_3 = 14; -> public static final int PDF_X_3 = 15;
