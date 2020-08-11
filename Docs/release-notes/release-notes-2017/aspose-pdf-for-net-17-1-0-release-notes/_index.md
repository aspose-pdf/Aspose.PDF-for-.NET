---
title: Aspose.PDF for .NET 17.1.0 Release Notes
type: docs
weight: 120
url: /net/aspose-pdf-for-net-17-1-0-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-41573|Referencing XObjects for multiple times|New Feature|
|PDFNET-41880|Add a row containing some text at the end of page if table is broken in two pages|New Feature|
|PDFNET-41881|Set different TabLeaderType for different TOC Level|New Feature|
|PDFNET-41767|Multiple reference to same image|Enhancement|
|PDFNEWNET-40023|Adding text inside a shape|Enhancement|
|PDFNEWNET-40707|Add text inside Rectangle object|Enhancement|
|PDFNET-41892|Alignment of radio button text and checkbox text is not proper|Bug|
|PDFNET-41735|doc.Pages[1].Resources.Images.Names and doc.Pages[1].Resources.Images[0]<br>Name returns different names for same image.|Bug|
|PDFNET-41848|Jumbling words when converting Pdf to Html with UseZOrder = true|Bug|
|PDFNET-42032|Pdf file is not compilant with PDF/A-1a format (transparency and missing objects)|Bug|
|PDFNET-42031|Pdf file is not compilant with PDF/A-1a format (transparency)|Bug|
|PDFNEWNET-38235|PDF to HTML - Links are converted into plain text|Bug|
|PDFNEWNET-39140|PDF to HTML- Text Selection flickers|Bug|
|PDFNEWNET-40684|PDF to HTML - Missing characters and invalid format of resultant file|Bug|
|PDFNEWNET-40683|PDF to HTML - Missing characters and invalid format of resultant file|Bug|
|PDFNET-41589|Load single image instance for multiple times|Bug|
|PDFNET-41506|Stamp text alignment issue|Bug|
|PDFNET-41891|When PDF is converted to DOCX, the text formatting changes.|Bug|
|PDFNEWNET-36321|XFA form conversion failure|Bug|
|PDFNET-41809|PDF to PDF/A - Formatting issues in resultant file|Bug|
|PDFNET-41717|PDF to PDFA: transparent background is being rendered as black|Bug|
|PDFNEWNET-39398|PDF to PDF/A - Resultant file is not correct|Bug|
|PDFNET-41899|PDF to PPTX - Text on first page is absent|Bug|
|PDFNET-41404|HTML/PDF to PPTX conversion issue|Bug|
|PDFNET-41654|HTML to PPTX: Missing white Text form HTML to PPTX|Bug|
|PDFNET-41906|Text position of TextFragment|Bug|
|PDFNET-41992|PDF to PDFA: compliance fails (soft mask in image)|Bug|
|PDFNEWNET-40717|PDF to JPEG - Some characters rendered wrongly|Bug|
### **Public API changes**
**Added API's:**

Property Aspose.PDF.Drawing.Shape.Text
Property Aspose.PDF.HtmlSaveOptions.DisableImageSelection
Property Aspose.PDF.LevelFormat.LineDash
Property Aspose.PDF.Table.BreakText
Property Aspose.PDF.TextStamp.MaxRowWidth
Method Aspose.PDF.XImage.IsTheSameObject(Aspose.PDF.XImage)
Method Aspose.PDF.XImage.GetNameInCollection
Method Aspose.PDF.XImageCollection.Add(Aspose.PDF.XImage)
Method Aspose.PDF.XImageCollection.GetImageName(Aspose.PDF.XImage)
