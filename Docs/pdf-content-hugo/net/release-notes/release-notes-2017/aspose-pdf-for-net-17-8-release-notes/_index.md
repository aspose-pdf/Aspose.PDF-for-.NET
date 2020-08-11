---
title: Aspose.PDF for .NET 17.8 Release Notes
type: docs
weight: 50
url: /net/aspose-pdf-for-net-17-8-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-42309|NullReferenceException on getting Document.pagei.Artifacts collection|Exception|
|PDFNET-42714|XPS to PDF Conversion throws missing root element exception|Exception|
|PDFNET-42969|Argument out of range exception when saving PDF as HTML|Exception|
|PDFNET-42918|Aspose.PDF generates larger files than Aspose.PDF.Generator|Bug|
|PDFNET-42663|Method access error occurs on converting an XPS to PDF|Bug|
|PDFNET-42675|Incorrect color of circles when converting an XPS to PDF|Bug|
|PDFNET-42885|PDF to PPTX - Text is missing in resultant file|Bug|
|PDFNET-40901|PDF to PNG conversion adds extra white space|Bug|
|PDFNET-42549|Failed PDF/A-1b validation after conversion|Bug|
|PDFNET-42544|After saving attachments, collection is empty|Bug|
|PDFNET-42886|DOCX to PDFA different behavior between aspose and adobe reader PRO - Incident|Bug|
|PDFNET-42729|Aspose.PDF generated slides within PowerPoint breaks fonts and formatting|Bug|
|PDFNET-41389|PDF to PDF/A-2a - Resultant file is not compliant|Bug|
|PDFNET-41386|PDF to PDF/A-2a - Resultant file is not compliant|Bug|
|PDFNET-41367|PDF to PDF/A - Resultant file is not compliant|Bug|
|PDFNET-39454|PDF to HTML: characters are being replaced with boxes|Bug|
|PDFNET-42198|PDF to DOC: Text trimmed from top|Bug|
|PDFNET-42349|DropDown value is cropped when form is flatten|Bug|
|PDFNET-42350|DropDown value is rendered incorrectly|Bug|
|PDFNET-43141|Text replacement leads to column breaking (left shift of the word in second column)|Bug|
|PDFNET-41170|HTML to PDF - Field width is not preserved|Bug|
|PDFNET-41628|PDF to TIFF: black blocks in resultant TIFF image|Bug|
|PDFNET-41683|PDF to JPEG - Double space between letters|Bug|
|PDFNET-41845|PDF to BMP - Text appears overlapped in resultant image|Bug|
|PDFNET-42582|Text overlapping occurred when converting PDF to PNG|Bug|
### **Added APIs:**
-----
**Class Aspose.PDF.DocumentFactory**

Constructor Aspose.PDF.DocumentFactory
Method Aspose.PDF.DocumentFactory.CreateDocument(System.IO.Stream,Aspose.PDF.LoadOptions)

**Methods and Properties**

Method Aspose.PDF.EmbeddedFileCollection.Add(System.String,Aspose.PDF.FileSpecification)
Method Aspose.PDF.EmbeddedFileCollection.DeleteByKey(System.String)
Method Aspose.PDF.Image.GetMimeType(System.Drawing.Image)
Property Aspose.PDF.RenderingOptions.ScaleImagesToFitPageWidth
Property Aspose.PDF.Collection.DefaultEntry
