---
title: Aspose.Pdf for Java 17.7 Release Notes
type: docs
weight: 60
url: /java/aspose-pdf-for-java-17-7-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-34031|Get hyperlink associated with image file|New Feature|
|PDFJAVA-34729|PDF to DOC: the lines on a first page are shifted|Bug|
|PDFJAVA-34817|PDF to HTML: Chinese characters are not rendered correctly|Bug|
|PDFJAVA-34867|PDF to HTML - Contents overlap table border|Bug|
|PDFJAVA-34965|PDF to HTML - Images colors are lost in resultant file|Bug|
|PDFJAVA-35177|PDF to HTML: characters are being replaced with boxes|Bug|
|PDFJAVA-36110|PDF_A_1B validation result is incorrect|Bug|
|PDFJAVA-36444|PDF to DOC: Text trimmed from top|Bug|
|PDFJAVA-36537|PDF to PPTX superscript texts are not aligned properly|Bug|
|PDFJAVA-36538|PDF to PPTX - side notes are missing from the power point|Bug|
|PDFJAVA-36539|PDF to PPTX: letters shifted to a new line|Bug|
|PDFJAVA-36540|PDF to PPTX: the word has split and part of it is in a new line|Bug|
|PDFJAVA-36569|PDF to PPTX - Tabular data alignment issues|Bug|
|PDFJAVA-36528|Flatten Calculated Fields displays 0|Bug|
|PDFJAVA-36529|Flatten Calculated Fields lost their formatting|Bug|
|PDFJAVA-36699|After flattenAllFields() method is used, an output file converts 60% to 0.6%|Bug|
|PDFJAVA-36734|PDF to PDFA Conversion Error|Bug|
|PDFJAVA-36824|PDF to HTML - Image Colors are lost in resultant file|Bug|
|PDFJAVA-36826|PDF to HTML - Image Colors are lost in resultant file|Bug|
|PDFJAVA-36854|PDF to PDF/A: Compliant error: Text cannot be mapped to Unicode|Bug|
|PDFJAVA-36895|Include HTML file(s) in API Package with link to online sites|Bug|
|PDFJAVA-36781|HTML to PDF - Exception when converting on Oracle Linux 6.5|Bug|
|PDFJAVA-36738|Load HTML shows an error in Headless Mode|Bug|
|PDFJAVA-36737|HTML to PDF conversion shows an error in Headless Mode|Bug|
|PDFJAVA-35997|HTML to PDF - Field width is not preserved|Bug|
### **Public API Changes in Aspose.PDF for Java 17.7**


Added new class **com.aspose.pdf.FontEmbeddingOptions** with the following methods:

public FontEmbeddingOptions()
public boolean getUseDefaultSubstitution()
public void setUseDefaultSubstitution(boolean value)

Changes in class **com.aspose.pdf.Page**:

Added method:
public byte[] convertToPNGMemoryStream()

Changes in class **com.aspose.pdf.PdfFormatConversionOptions**:

Added method:
public FontEmbeddingOptions getFontEmbeddingOptions()

Changes in class **com.aspose.pdf.Table**:

Renamed method:
public double getWidth_() -> public double getWidth()

Changes in class **com.aspose.pdf.TextEncodingInternal**:

Added method:
public String getString(byte[] value)

Changes in class **com.aspose.pdf.TextSegment**:

Added method:
public int getEndCharIndex()
