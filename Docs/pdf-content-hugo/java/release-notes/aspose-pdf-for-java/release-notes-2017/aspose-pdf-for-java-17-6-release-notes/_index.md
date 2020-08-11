---
title: Aspose.Pdf for Java 17.6 Release Notes
type: docs
weight: 70
url: /java/aspose-pdf-for-java-17-6-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-34858|Get height of table in existing PDF file|New Feature|
|PDFJAVA-36326|LineAnnotation and PolyLineAnnotation measurement recalculation upon resize|Bug|
|PDFJAVA-36469|Not able to create bulleted list in heading|Bug|
|PDFJAVA-36709|When PDF is converted to PDF_A_1B, output file is still classic PDF|Bug|
|PDFJAVA-34305|Hindi text replacement results into incorrect text|Bug|
|PDFJAVA-35749|PDF to PDF/A - StringIndexOutOfBoundsException during conversion|Bug|
|PDFJAVA-35750|PDF to PDF/A - StringIndexOutOfBoundsException during conversion|Bug|
|PDFJAVA-35751|PDF to PDF/A - StringIndexOutOfBoundsException during conversion|Bug|
|PDFJAVA-35752|PDF to PDF/A - StringIndexOutOfBoundsException during conversion|Bug|
|PDFJAVA-35753|PDF to PDF/A - StringIndexOutOfBoundsException during conversion|Bug|
|PDFJAVA-35759|PDF to PDF/A - StringIndexOutOfBoundsException during conversion|Bug|
|PDFJAVA-35756|PDF to PDF/A - StringIndexOutOfBoundsException during conversion|Bug|
|PDFJAVA-35755|PDF to PDF/A - StringIndexOutOfBoundsException during conversion|Bug|
|PDFJAVA-35754|PDF to PDF/A - StringIndexOutOfBoundsException during conversion|Bug|
|PDFJAVA-35757|PDF to PDF/A - StringIndexOutOfBoundsException during conversion|Bug|
|PDFJAVA-35758|PDF to PDF/A - StringIndexOutOfBoundsException during conversion|Bug|
|PDFJAVA-35970|Default padding for HtmlFragment in Table cell|Bug|
|PDFJAVA-35275|PDF to DOCX - Formatting issues in resultant file|Bug|
|PDFJAVA-36668|HTML to PDF - Ambiguous match found|Bug|
|PDFJAVA-34412|PCL to PDF: Some text is absent|Bug|
### **Public API Changes in Aspose.PDF for Java 17.6**


Added new class com.aspose.pdf.**ToUnicodeProcessingRules** with the following methods:

public ToUnicodeProcessingRules()
public ToUnicodeProcessingRules(boolean removeSpaces)
public ToUnicodeProcessingRules(boolean removeSpaces, boolean mapNonLinkedUnicodesOnSpace)
public boolean getRemoveSpacesFromCMapNames()
public void setRemoveSpacesFromCMapNames(boolean value)
public boolean getMapNonLinkedSymbolsOnSpace()
public void setMapNonLinkedSymbolsOnSpace(boolean value)

Changes in class com.aspose.pdf.**PdfFormatConversionOptions**:

Added methods:
public ToUnicodeProcessingRules getUnicodeProcessingRules()
public void setUnicodeProcessingRules(ToUnicodeProcessingRules value)

Added new enum class com.aspose.pdf.TextFormattingOptions.**LineSpacingMode** with the following constants:

public static final int FontSize = 0;
public static final int FullSize = 1;

Changes in class com.aspose.pdf.**TextFormattingOptions**:

Added methods:
public /* LineSpacingMode */int getLineSpacing()
public void setLineSpacing(/* LineSpacingMode */int value)
