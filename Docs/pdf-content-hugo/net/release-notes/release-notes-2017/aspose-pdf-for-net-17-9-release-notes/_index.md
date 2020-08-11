---
title: Aspose.PDF for .NET 17.9 Release Notes
type: docs
weight: 40
url: /net/aspose-pdf-for-net-17-9-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-43094|PDF to PPTX - Different images in document gets merged into single image in output file|Enhancement|
|PDFNET-43200|Implement the ability to extract password protected documents via Aspose.PDF.GroupProcessor|Enhancement|
|PDFNET-43199|Implement CreateExtractor method overload that accepts a document Stream|Enhancement|
|PDFNET-42286|PDF to PPTX: render text data as image|Enhancement|
|PDFNET-43158|Provide overloads for document factory methods|Enhancement|
|PDFNET-43057|Add image inside PDF - Output is different as compared to old generator|Enhancement|
|PDFNET-42964|NullReferenceException when working with artifacts|Exception|
|PDFNET-43164|Custom font breaks upon PDF to PDF/A conversion |Bug|
|PDFNET-38996|PDF to JPGE conversion loses text|Bug|
|PDFNET-39457|PDF to Image characters show up as squares|Bug|
|PDFNET-42201|PDF to PDFA conversion changes the display order of objects|Bug|
|PDFNET-42339|Alignment of radio button is not proper|Bug|
|PDFNET-42676|PDF to PDF/A - compliance error: Real value out of range|Bug|
|PDFNET-42933|Line-height (spacing between lines) is not being honored for RichTextBoxField|Bug|
|PDFNET-38505|Invalid xref table in resultant file|Bug|
|PDFNET-42907|On stamping an image in the PDF- the image is being displaced and rotated|Bug|
|PDFNET-42934|Hanging on Save|Bug|
|PDFNET-42568|Blank page when saving PDF as HTML|Bug|
|PDFNET-38236|PDF to TIFF - Garbled characters in resultant file|Bug|
|PDFNET-35749|Anit-aliasing issue in PdfConverter|Bug|
|PDFNET-42646|Out of memory exception when saving PDF as image in Windows 7|Exception|
|PDFNET-42785|When PDF converted to PDF_A_1B, a blue color on image is different|Bug|
|PDFNET-42890|PDF output corrupted after editing|Bug|
|PDFNET-43064|Cannot extract all text items from a PDF|Bug|
|PDFNET-35721|PDF to DOC conversion issue|Bug|
|PDFNET-42006|PDF to PPTX: white text is missing in resultant PPTX|Bug|
|PDFNET-38683|PDF to PPTX - Layout issues in resultant file|Bug|
|PDFNET-38623|PDF to PPTX: All images on a PDF page are being rendered as a single image in PPTX slide|Bug|
### **Added APIs:**
-----
Method Aspose.PDF.Document.Check(System.Boolean)
Method Aspose.PDF.DocumentFactory.CreateDocument
Method Aspose.PDF.DocumentFactory.CreateDocument(System.IO.Stream)
Method Aspose.PDF.DocumentFactory.CreateDocument(System.IO.Stream,System.String)
Method Aspose.PDF.DocumentFactory.CreateDocument(System.String)
Method Aspose.PDF.GroupProcessor.Creators.PdfTypeObjectCreator.CreateExtractor(System.IO.Stream,System.Int32,System.Boolean)
Method Aspose.PDF.GroupProcessor.Creators.PdfTypeObjectCreator.CreateExtractor(System.String,System.String,System.Int32,System.Boolean)
Method Aspose.PDF.GroupProcessor.Creators.PdfTypeObjectCreator.CreateExtractor(System.IO.Stream,System.String,System.Int32,System.Boolean)
Property Aspose.PDF.HtmlSaveOptions.ImageResolution
Property Aspose.PDF.PdfFormatConversionOptions.IccProfileFileName
Property Aspose.PDF.PptxSaveOptions.SlidesAsImages
Property Aspose.PDF.PptxSaveOptions.SeparateImages
Property Aspose.PDF.RenderingOptions.InterpolationHighQuality
### **Removed APIs**
Property Aspose.PDF.Table.ParentTable
