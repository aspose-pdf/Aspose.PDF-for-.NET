---
title: Aspose.PDF for Android via Java 19.12 Release Notes
type: docs
weight: 10
url: /java/aspose-pdf-for-android-via-java-19-12-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PDF for Android via Java 19.12.

{{% /alert %}} 
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFANDROID-588|PDF to DOC support|New Feature|
|PDFANDROID-569|PDF to PPTX support|New Feature|
|PDFANDROID-562|Out of memory exception while saving PDF with an image|Enhancement|
|PDFANDROID-19|Facades: BindPdf() method is missing in Form class|Enhancement|
|PDFANDROID-598|Implementation Redaction Annotation|Enhancement|
|PDFANDROID-593|Exception on getModDate()|Bug|
|PDFANDROID-594|NullPointerException while extracting text|Bug|
|PDFANDROID-595|Multiline parsing of pdf through TextFragmentAbsorber with regex not working|Bug|
|PDFANDROID-596 |Merging PDF Documents - issue with radio buttons in output|Bug|
## **Public API and Backward Incompatible Changes**
### **PDF to PPTX Support**
{{< highlight java >}}

 Document doc = new Document(inFile);

PptxSaveOptions saveOptions = new PptxSaveOptions();

doc.save(outFileName, saveOptions);

{{< /highlight >}}
### **PDF to DOC Support**
{{< highlight java >}}

 Document doc = new Document(inFile);

DocSaveOptions docsave = new DocSaveOptions();

docsave.setMode(DocSaveOptions.RecognitionMode.Textbox);

doc.save(outFile, docsave);

{{< /highlight >}}
### **Changes in class com.aspose.pdf.AnnotationSelector**
**Added Method**

- com.aspose.pdf.AnnotationSelector.visit(RedactionAnnotation)
### **Changes in class com.aspose.pdf.DocSaveOptions**
**Added Constructor**

- com.aspose.pdf.DocSaveOptions.#ctor()

**Added Methods**

- com.aspose.pdf.DocSaveOptions.getMaxDistanceBetweenTextLines
- com.aspose.pdf.DocSaveOptions.setMaxDistanceBetweenTextLines(float)
- com.aspose.pdf.DocSaveOptions.setFormat(int)
- com.aspose.pdf.DocSaveOptions.getFormat
- com.aspose.pdf.DocSaveOptions.setImageResolutionY(int)
- com.aspose.pdf.DocSaveOptions.getImageResolutionY
- com.aspose.pdf.DocSaveOptions.setImageResolutionX(int)
- com.aspose.pdf.DocSaveOptions.getImageResolutionX
- com.aspose.pdf.DocSaveOptions.setAddReturnToLineEnd(boolean)
- com.aspose.pdf.DocSaveOptions.isAddReturnToLineEnd
- com.aspose.pdf.DocSaveOptions.isRecognizeBullets

**Added Fields**

- com.aspose.pdf.DocSaveOptions.RecognitionMode.Textbox
- com.aspose.pdf.DocSaveOptions.RecognitionMode
- com.aspose.pdf.DocSaveOptions.CustomProgressHandler
### **Added new class class com.aspose.pdf.exceptions.FontNotFoundException**
**Constructors**

- com.aspose.pdf.exceptions.FontNotFoundException.#ctor(String)
### **Changes in class com.aspose.pdf.facades.Form**
**Added Constructors**

- com.aspose.pdf.facades.Form.#ctor
- com.aspose.pdf.facades.Form.#ctor(IDocument)
- com.aspose.pdf.facades.Form.#ctor(IDocument,OutputStream)
- com.aspose.pdf.facades.Form.#ctor(IDocument,String)
- com.aspose.pdf.facades.Form.#ctor(InputStream)
- com.aspose.pdf.facades.Form.#ctor(InputStream,OutputStream)
- com.aspose.pdf.facades.Form.#ctor(InputStream,String)
- com.aspose.pdf.facades.Form.#ctor(String)
- com.aspose.pdf.facades.Form.#ctor(String,OutputStream)
- com.aspose.pdf.facades.Form.#ctor(String,String)

**Added Methods**

- com.aspose.pdf.facades.Form.bindPdf(InputStream,String)
- com.aspose.pdf.facades.Form.bindPdf(String,String)
- com.aspose.pdf.facades.Form.close
- com.aspose.pdf.facades.Form.dispose
- com.aspose.pdf.facades.Form.exportFdf(OutputStream)
- com.aspose.pdf.facades.Form.exportXfdf(OutputStream)
- com.aspose.pdf.facades.Form.fillBarcodeField(String,String)
- com.aspose.pdf.facades.Form.fillField(String,boolean)
- com.aspose.pdf.facades.Form.fillField(String,int)
- com.aspose.pdf.facades.Form.fillField(String,String)
- com.aspose.pdf.facades.Form.fillField(String,String,boolean)
- com.aspose.pdf.facades.Form.fillField(String,String[])
- com.aspose.pdf.facades.Form.flattenAllFields
- com.aspose.pdf.facades.Form.flattenField(String)
- com.aspose.pdf.facades.Form.getAttachmentName
- com.aspose.pdf.facades.Form.getButtonOptionCurrentValue(String)
- com.aspose.pdf.facades.Form.getButtonOptionValues(String)
- com.aspose.pdf.facades.Form.getContentDisposition
- com.aspose.pdf.facades.Form.getDestFileName
- com.aspose.pdf.facades.Form.getDestStream
- com.aspose.pdf.facades.Form.getField(String)
- com.aspose.pdf.facades.Form.getFieldFacade(String)
- com.aspose.pdf.facades.Form.getFieldFlag(String)
- com.aspose.pdf.facades.Form.getFieldLimit(String)
- com.aspose.pdf.facades.Form.getFieldNames
- com.aspose.pdf.facades.Form.getFieldType(String)
- com.aspose.pdf.facades.Form.getFormSubmitButtonNames
- com.aspose.pdf.facades.Form.getFullFieldName(String)
- com.aspose.pdf.facades.Form.getImportResult
- com.aspose.pdf.facades.Form.getRichText(String)
- com.aspose.pdf.facades.Form.getSaveOptions
- com.aspose.pdf.facades.Form.getSrcFileName
- com.aspose.pdf.facades.Form.getSrcStream
- com.aspose.pdf.facades.Form.getSubmitFlags(String)
- com.aspose.pdf.facades.Form.importFdf(InputStream)
- com.aspose.pdf.facades.Form.importXfdf(InputStream)
- com.aspose.pdf.facades.Form.importXml(InputStream)
- com.aspose.pdf.facades.Form.importXml(InputStream,boolean)
- com.aspose.pdf.facades.Form.isRequiredField(String)
- com.aspose.pdf.facades.Form.renameField(String,String)
- com.aspose.pdf.facades.Form.save
- com.aspose.pdf.facades.Form.save(OutputStream)
- com.aspose.pdf.facades.Form.save(String)
- com.aspose.pdf.facades.Form.setAttachmentName(String)
- com.aspose.pdf.facades.Form.setContentDisposition(int)
- com.aspose.pdf.facades.Form.setConvertTo(int)
- com.aspose.pdf.facades.Form.setDestFileName(String)
- com.aspose.pdf.facades.Form.setDestStream(OutputStream)
- com.aspose.pdf.facades.Form.setSaveOptions(SaveOptions)
- com.aspose.pdf.facades.Form.setSrcFileName(String)
- com.aspose.pdf.facades.Form.setSrcStream(InputStream)
- com.aspose.pdf.facades.Form.setXfaData(InputStream)

**Added Fields**

- com.aspose.pdf.facades.Form.ImportStatus.Success
- com.aspose.pdf.facades.Form.ImportStatus.FieldNotFound

**Rename Methods**

- com.aspose.pdf.Form.getFields_Rename_Namesake -> com.aspose.pdf.Form.getFields
### **Changes in class com.aspose.pdf.LoadOptions**
**Renamed Methods**

- com.aspose.pdf.LoadOptions.setWarningHandler(IWarningCallback) -> com.aspose.pdf.LoadOptions.setWarningHandler(WarningCallback) 
### **Added new class com.aspose.pdf.PptxSaveOptions**
**Constructors**

- com.aspose.pdf.PptxSaveOptions.#ctor

**Methods**

- com.aspose.pdf.PptxSaveOptions.getSlidesAsImages
- com.aspose.pdf.PptxSaveOptions.setSlidesAsImages(boolean)
- com.aspose.pdf.PptxSaveOptions.getImageResolution
- com.aspose.pdf.PptxSaveOptions.setImageResolution(int)
- com.aspose.pdf.PptxSaveOptions.getSeparateImages
- com.aspose.pdf.PptxSaveOptions.setSeparateImages(boolean)
- com.aspose.pdf.PptxSaveOptions.isOptimizeTextBoxes
- com.aspose.pdf.PptxSaveOptions.setOptimizeTextBoxes(boolean)
### **Added new class com.aspose.pdf.ProgressEventType**
**Fields**

- com.aspose.pdf.ProgressEventType.TotalProgress
- com.aspose.pdf.ProgressEventType.SourcePageAnalized
- com.aspose.pdf.ProgressEventType.ResultPageCreated
- com.aspose.pdf.ProgressEventType.ResultPageSaved
### **Changes in class com.aspose.pdf.LoadOptions**
**Added Methods**

- com.aspose.pdf.Rectangle.contains(Point)
- com.aspose.pdf.Rectangle.center
- ### **Added new class com.aspose.pdf.RedactionAnnotation**
**Constructors**

- com.aspose.pdf.RedactionAnnotation.#ctor(IDocument)
- com.aspose.pdf.RedactionAnnotation.#ctor(Page,Rectangle)

**Methods**

- com.aspose.pdf.RedactionAnnotation.accept(AnnotationSelector)
- com.aspose.pdf.RedactionAnnotation.getQuadPoint
- com.aspose.pdf.RedactionAnnotation.setQuadPoint(Point[])
- com.aspose.pdf.RedactionAnnotation.getFillColor
- com.aspose.pdf.RedactionAnnotation.setFillColor(Color)
- com.aspose.pdf.RedactionAnnotation.getBorderColor
- com.aspose.pdf.RedactionAnnotation.setBorderColor(Color)
- com.aspose.pdf.RedactionAnnotation.getOverlayText
- com.aspose.pdf.RedactionAnnotation.setOverlayText(String)
- com.aspose.pdf.RedactionAnnotation.isRepeat
- com.aspose.pdf.RedactionAnnotation.setRepeat(boolean)
- com.aspose.pdf.RedactionAnnotation.getTextAlignment
- com.aspose.pdf.RedactionAnnotation.setTextAlignment(int)
- com.aspose.pdf.RedactionAnnotation.flatten
- com.aspose.pdf.RedactionAnnotation.redact
- com.aspose.pdf.RedactionAnnotation.redactExact
### **Changes in class com.aspose.pdf.RenderingOptions**
**Added Methods**

- com.aspose.pdf.RenderingOptions.getOptimizeDimensions
- com.aspose.pdf.RenderingOptions.setOptimizeDimensions(boolean)
- com.aspose.pdf.RenderingOptions.getDefaultFontName
- com.aspose.pdf.RenderingOptions.setDefaultFontName(String)
- ### **Added new class com.aspose.pdf.TextRenderingMode**
**Fields**

- com.aspose.pdf.TextRenderingMode.FillText
- com.aspose.pdf.TextRenderingMode.StrokeText
- com.aspose.pdf.TextRenderingMode.FillThenStrokeText
- com.aspose.pdf.TextRenderingMode.Invisible
- com.aspose.pdf.TextRenderingMode.FillTextAndAddPathToClipping
- com.aspose.pdf.TextRenderingMode.StrokeTextAndAddPathToClipping
- com.aspose.pdf.TextRenderingMode.FillThenStrokeTextAndAddPathToClipping
- com.aspose.pdf.TextRenderingMode.AddPathToClipping
### **Changes in class com.aspose.pdf.TextSearchOptions**
**Added Methods**

- com.aspose.pdf.TextSearchOptions.setDotallMode(boolean)
- com.aspose.pdf.TextSearchOptions.isDotallMode
- com.aspose.pdf.TextSearchOptions.getLogTextExtractionErrors
- com.aspose.pdf.TextSearchOptions.setLogTextExtractionErrors(boolean)
- com.aspose.pdf.TextSearchOptions.getSearchForTextRelatedGraphics
- com.aspose.pdf.TextSearchOptions.setSearchForTextRelatedGraphics(boolean)
