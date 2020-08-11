---
title: Aspose.PDF for Java 19.12 Release Notes
type: docs
weight: 10
url: /java/aspose-pdf-for-java-19-12-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PDF for Java 19.12.

{{% /alert %}} 
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-38667|Hyperlinks and cross-references support on converting PDF to DOCX|New Feature|
|PDFJAVA-38483|Support [DICOM image to PDF](/pdf/java/add-delete-and-extract-images-from-the-pdf-file/#add-deleteandextractimagesfromthepdffile-supportfordicomimages)|New Feature|
|PDFJAVA-39017|Set [Font Size of Overlay Text](/pdf/java/redact-certain-page-region-with-redactionannotation/#redactcertainpageregionwithredactionannotation-redactpageregionwithredactionannotation) in Redaction Annotation|New Feature|
|PDFJAVA-39063|Add [Font subsets optimization](/pdf/java/optimize-pdf-document/#optimizepdfdocument-removeunnecessaryobjects) method|Enhancement|
|PDFJAVA-38960|Exception when loading Latex|Bug|
|PDFJAVA-36774|When PDF is converted to Word document, a hyperlink is lost|Bug|
|PDFJAVA-38942|PDF to HTML long conversion time|Bug|
|PDFJAVA-39049|Merging XFDF with the PDF template produces all checkboxes unchecked|Bug|
|PDFJAVA-34853|PDF to HTML: Table is not being rendered incorrectly|Bug|
|PDFJAVA-34865|PDF to HTML - Text is not properly being rendered (character overwrite)|Bug|
|PDFJAVA-35744|PDF to PDFA throws OutOfMemory Exception|Bug|
|PDFJAVA-34325|XPS to PDF: Issues with Glyphs in output PDF file|Bug|
## **Public API and Backward Incompatible Changes**
**Setting Font Size of Overlay Text in Redaction Annotation**

{{< highlight java >}}

 Document doc = new Document("HelloWorld.pdf");

Rectangle rect = new Rectangle(200, 500, 300, 600);

RedactionAnnotation annot = new RedactionAnnotation(doc.getPages().get_Item(1), rect);

annot.setFillColor(Color.getBlack());

annot.setBorderColor(Color.getYellow());

annot.setColor(Color.getBlue());

annot.setFontSize(20);

annot.setOverlayText("REDACTED");

annot.setTextAlignment(HorizontalAlignment.Center);

annot.setRepeat(true);

doc.getPages().get_Item(1).getAnnotations().add(annot);

doc.save("Redaction_out.pdf");

{{< /highlight >}}

**Adding Font Subsets Optimization Method**

{{< highlight java >}}

 Document pdfDocument = new Document("source.pdf");

OptimizationOptions opt = new OptimizationOptions();

opt.setAllowReusePageContent(true);

opt.setLinkDuplcateStreams(true);

opt.setRemoveUnusedObjects(true);

opt.setRemoveUnusedStreams(true);

opt.setSubsetFonts(true);

pdfDocument.optimizeResources(opt);

pdfDocument.save("result.pdf");

{{< /highlight >}}

**New Methods Added**

- com.aspose.pdf.optimization.OptimizationOptions.[getSubsetFonts()](https://apireference.aspose.com/java/pdf/com.aspose.pdf.optimization/OptimizationOptions#getSubsetFonts--)
- com.aspose.pdf.optimization.OptimizationOptions.[setSubsetFonts(boolean)](https://apireference.aspose.com/java/pdf/com.aspose.pdf.optimization/OptimizationOptions#setSubsetFonts-boolean-)
- com.aspose.pdf.RedactionAnnotation.[setFontSize(int)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/RedactionAnnotation#setFontSize-int-)
