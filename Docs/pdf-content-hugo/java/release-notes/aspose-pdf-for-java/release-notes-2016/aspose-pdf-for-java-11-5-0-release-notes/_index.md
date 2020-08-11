---
title: Aspose.Pdf for Java 11.5.0 Release Notes
type: docs
weight: 90
url: /java/aspose-pdf-for-java-11-5-0-release-notes/
---

### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|PDFNEWJAVA-34296 |Get warnings for font substitution |New Feature |
|PDFNEWJAVA-35794 |Implement EMF device |New Feature|
|PDFNEWJAVA-35689 |HTML to PDF - escape HTML tags and special characters|New Feature |
|PDFNEWJAVA-35503 |Use default font when specific font from document is missing over system |Enhancement |
|PDFNEWJAVA-33308 |FO float to PDF |Enhancement |
|PDFNEWJAVA-34454 |PDF to HTML: NullPointerException|Exception |
|PDFNEWJAVA-35359 |PDF to PDFA: conversion of scanned PDF to PDFA throws ArrayIndexOutOfBoundsException |Exception |
|PDFNEWJAVA-34454 |PDF to HTML: NullPointerException |Exception |
|PDFNEWJAVA-35687 |Performance issue while importing XML in PDF form |Bug |
|PDFNEWJAVA-35685 |PDF to PDFA conversion issue(Linux) |Bug |
|PDFNEWJAVA-35434 |HTML to PDF conversion on UNIX results in "Too many open files" issue |Bug |
|PDFNEWJAVA-35395 |Non-Searchable to Searchable PDF conversion issue |Bug |
|PDFNEWJAVA-35389 |Locking all threads on Solaris server |Bug |
|PDFNEWJAVA-35645 |PDF to PDF/A_2b - Resultant file is not compliant |Bug |
|PDFNEWJAVA-35599 |Creating searchable PDF using TesseractOCR via JNA |Bug |
|PDFNEWJAVA-35431 |Searchable PDF overlay issue with Aspose.PDF and Tesseract |Bug |
|PDFNEWJAVA-35101 |PDF to HTML - Background watermark text appears on top of Heading |Bug |
|PDFNEWJAVA-35425 |PDF to HTML: characters alignment issues |Bug |
|PDFNEWJAVA-34823 |PDF to HTML: Text is being positioned incorrect in header part of HTML |Bug |
|PDFNEWJAVA-35387 |Not all fields become flattened in DOM aproach |Bug |
|PDFNEWJAVA-35495 |PDF to HTML: text is missing in resultant HTML |Bug |
|PDFNEWJAVA-34380 |Error when using API in trial over Windows 8.1 |Bug |
|PDFNEWJAVA-35492 |PDF to HTML - Text misplaced after converting to html |Bug |
|PDFNEWJAVA-35300 |Html to PDF conversion is making the url lowercase |Bug |
|PDFNEWJAVA-34901 |EPUB to Image: Output image is empty |Bug |
|PDFNEWJAVA-34662 |PDF to HTML: Some symbols are not rendered in Chrome browser |Bug |
### **Public API Changes**
**Added new com.aspose.pdf.PdfEvent class with methods:**

- public final void add(T delegate)
- public final void remove(T delegate)
- public final void clear()
- public boolean isEmpty()
- public final void assign(T delegate)

**Added new com.aspose.pdf.ImageFilterType enum class with values:**

- public static final int Jpeg2000 = 0;
- public static final int Jpeg = 1;

**Changes in class com.aspose.pdf.BaseParagraph:** 
*moved:*

- public boolean isFootNoteParagraph()
- public void setFootNoteParagraph(boolean value)

**Changes in class com.aspose.pdf.Heading:** 
*changed method:*

- public void setUserLabel(String value) -> public void setUserLabel(TextSegment value)

**Changes in class com.aspose.pdf.EpubLoadOptions:** 
*added field:*

- PageSizeAdjustmentModes */int PageSizeAdjustmentMode

**Changes in class com.aspose.pdf.CompositingParameters:** 
*added constructor:*

- public CompositingParameters(/* BlendMode **/int blendMode, /** ImageFilterType */int filterType)
  *added method:*
- public /* ImageFilterType */int getFilterType()

**Changes in class com.aspose.pdf.Field:** 
*added methods:*

- public int getTabOrder()
- public void setTabOrder(int value)

**Changes in class com.aspose.pdf.Font:** 
*added methods:*

- public boolean doesFontContainAllCharacters(String value)

**Changes in class com.aspose.pdf.HtmlSaveOptions:** 
*added field:*

- public /* FontEncodingRules */byte FontEncodingStrategy;

**Changes in class com.aspose.pdf.Resources:** 
*added method:*

- public FontCollection getFonts(boolean createIfAbsent)
