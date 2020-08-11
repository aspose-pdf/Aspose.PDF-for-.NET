---
title: Aspose.PDF for .NET 12.0.0 Release Notes
type: docs
weight: 40
url: /net/aspose-pdf-for-net-12-0-0-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNEWNET-37490|PatternColorSpace support in new Generator|New Feature|
|PDFNET-41130|Gradient color support in new Generator|Enhancement|
|PDFNEWNET-38915|PDF to DOC: Set default ImageResolutions to 300 dpi|Enhancement|
|PDFNEWNET-40788|TableAbsorber throws ArgumentOutOfRangeException for page without table|Exception|
|PDFNEWNET-40787|TableAbsorber throws InvalidOperationException for page with one table|Exception|
|PDFNEWNET-40735|Text replacement throws ArgumentOutOfRangeException|Exception|
|PDFNEWNET-40640|PDF to HTML conversion throws ArgumentEception unhandled|Exception|
|PDFNEWNET-40525|PDF to HTML: Exception issue when converting document to html after cleanup|Exception|
|PDFNET-41207|TableAbsorber throws InvalidOperation Exception|Exception|
|PDFNET-41279|Tex to HTML - InvalidOperationException during conversion|Bug|
|PDFNEWNET-39139|PDF to TIFF: consumes a lot of memory|Bug|
|PDFNEWNET-40725|PDF to PDFA1a conversion results in-compliant PDFA document|Bug|
|PDFNET-41276|PDF to XPS conversion loses the background image|Bug|
|PDFNET-41091|PDF to PDFA converts highlight annotation into black rectangle|Bug|
|PDFNEWNET-30629|Issue in conversion from SVG to PDF|Bug|
|PDFNEWNET-39443|PDF to PDF/A - Unable to access conversion log information saved in Stream|Bug|
|PDFNEWNET-38221|PDF to PDF/A - Black background appears|Bug|
|PDFNEWNET-36778|HTML to PDF - Formatting issues in resultant PDF|Bug|
|PDFNET-41105|PDF to PDF/A - Contents are rotated at 90 degree in resultant file|Bug|
|PDFNET-41055|PDF to PDFA_1b: Page contents are missing/redacted|Bug|
|PDFNET-41054|PDF to PDFA: Page contents are missing/redacted|Bug|
|PDFNET-41030|PDF to PDF/A - Formatting issues in resultant file|Bug|
|PDFNET-40968|GetColor method of SetCMYKColorStroke operator is not implemented|Bug|
|PDFNET-40920|PDF to PDF/A - Error when viewing resultant file|Bug|
|PDFNEWNET-40845|PDFA compliance issue|Bug|
|PDFNEWNET-40754|ImagePlacementAbsorber can not define correct position and size of images in XForm|Bug|
|PDFNEWNET-40666|Inline image not rendered correctly when layout is right aligned|Bug|
|PDFNEWNET-40449|PDF to HTML: some characters are missing in resultant HTML|Bug|
|PDFNEWNET-40448|PDF to PNG: some characters are missing in resultant PNG|Bug|
|PDFNEWNET-35778|PCL to PDF: formatting lost issue|Bug|
|PDFNET-41208|Adding Graph line into PDF document hangs system forever|Bug|
|PDFNET-41026|PDF to PDFA: checkboxes are rendered as black boxes|Bug|
|PDFNEWNET-39290|PDF to HTML - Some characters are not properly rendering|Bug|
|PDFNET-41264|PDF to JPEG: contents are missing in resultant image|Bug|
|PDFNEWNET-40772|EPUB to PDF conversion throws the operation not supported error|Bug|
### **Public API changes**
### **Added APIs:**
- MethodAspose.PDF.Annotations.AnnotationSelector.Visit(Aspose.PDF.Annotations.WatermarkAnnotation)  
- Class Aspose.PDF.Annotations.FixedPrint  
- Property Aspose.PDF.Annotations.FixedPrint.Matrix  
- Property Aspose.PDF.Annotations.FixedPrint.HorizontalTranslation  
- Property Aspose.PDF.Annotations.FixedPrint.VerticalTranslation  
- Class Aspose.PDF.Annotations.WatermarkAnnotation  
- ConstructorAspose.PDF.Annotations.WatermarkAnnotation.#ctor(Aspose.PDF.Page,Aspose.PDF.Rectangle)  
- Property Aspose.PDF.Annotations.WatermarkAnnotation.FixedPrint  
- Property Aspose.PDF.Annotations.WatermarkAnnotation.AnnotationType  
- MethodAspose.PDF.Annotations.WatermarkAnnotation.SetText  (Aspose.PDF.Facades.FormattedText)  
- MethodAspose.PDF.Annotations.WatermarkAnnotation.SetTextAndState(System.String[],Aspose.PDF.Text.TextState)  
- MethodAspose.PDF.Annotations.WatermarkAnnotation.Accept(Aspose.PDF.Annotations.AnnotationSelector)  
- Property Aspose.PDF.Artifact.IsBackground  
- MethodAspose.PDF.Artifact.SetTextAndState  (System.String,Aspose.PDF.Text.TextState)  
- MethodAspose.PDF.Artifact.SetLinesAndState(System.String[],Aspose.PDF.Text.TextState)  
- Property Aspose.PDF.Color.PatternColorSpace  
- Class Aspose.PDF.Drawing.GradientAxialShading  
- Constructor Aspose.PDF.Drawing.GradientAxialShading.#ctor  
- Constructor Aspose.PDF.Drawing.GradientAxialShading.#ctor  (Aspose.PDF.Color,Aspose.PDF.Color)  
- Property Aspose.PDF.Drawing.GradientAxialShading.Start  
- Property Aspose.PDF.Drawing.GradientAxialShading.End  
- Property Aspose.PDF.Drawing.GradientAxialShading.StartColor  
- Property Aspose.PDF.Drawing.GradientAxialShading.EndColor  
- Class Aspose.PDF.Drawing.PatternColorSpace  
- Constructor Aspose.PDF.Drawing.PatternColorSpace.#ctor  
- Class Aspose.PDF.Engine.CommonData.Text.CMaps.IncorrectCMapUsageException  
- Method Aspose.PDF.Rectangle.IsIntersect(Aspose.PDF.Rectangle)  
