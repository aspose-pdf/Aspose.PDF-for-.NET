---
title: Aspose.Pdf for Java 16.11.0 Release Notes
type: docs
weight: 20
url: /java/aspose-pdf-for-java-16-11-0-release-notes/
---

### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|PDFNEWJAVA-33745 |Checking the status of Concatenation |New Feature |
|PDFJAVA-36251 |PDF to Latex: Add languages packages by demand only |New Feature |
|PDFNEWJAVA-34524 |NullPointerException while creating PrinterSettings object in Linux |Exception |
|PDFJAVA-36185 |PDF to PDFA conversion is throwing EmptyValue Exception in multi-thread Java application |Exception |
|PDFNEWJAVA-34367 |PDF to PNG - Blurry resultant image |Bug |
|PDFNEWJAVA-35164 |Issue with PageCollection insert method |Bug |
|PDFNEWJAVA-35304 |Arabic text is not being center aligned in a table cell |Bug |
|PDFNEWJAVA-35404 |Adobe Reader shows error when placing Image inside Table cell |Bug |
|PDFNEWJAVA-35508 |Fonts replacement issue |Bug |
|PDFNEWJAVA-35663 |Support of Aspose.PDF for Java on IBM i (Iseries or As/400) |Bug |
|PDFJAVA-35924 |PDF to DOCX: footnote is not rendering as a single paragraph |Bug |
|PDFJAVA-35940 |Invisible text on the right from the redactArea becomes visible |Bug |
|PDFJAVA-36054 |Not all contents are appearing in PDF document |Bug |
|PDFJAVA-36057 |PDF to DOCX: Russian text is being added in resultant DOCX |Bug |
|PDFJAVA-36058 |PDF to DOCX: Saving as resultant DOCX grows in size exponentially |Bug |
|PDFJAVA-36094 |Exception when loading Font from FileStream |Bug |
|PDFJAVA-36147 |Image squished instead of moving to next page |Bug |
|PDFJAVA-36186 |KeptWithNext feature is causing content to disappear |Bug |
|PDFJAVA-36213 |When PDF is saved as DOCX, the AsposeTimeoutError occurs. |Bug |
|PDFJAVA-36217 |Substitute font with open type font |Bug |
|PDFJAVA-36224 |Specify page range information for PdfPrintRange.Selection |Bug |
|PDFJAVA-36277 |PDF to PDF/A - Resultant file is not compliant |Bug |
|PDFJAVA-36294 |PDF to PPT - Spacing between words is removed |Bug |
### **Public API Changes in Aspose.PDF for Java 16.11.0**
Added the following exception classes:
**com.aspose.pdf.exceptions.IndexOutOfRangeException**

Changes in class **com.aspose.pdf.DocSaveOptions:** 
Removed unused methods:

`   `public boolean isUseEmbeddedTrueTypeFonts()
`   `public void setUseEmbeddedTrueTypeFonts(boolean)

Changes in class **com.aspose.pdf.Document:** 
Added methods:

`   `public boolean isAbsentFontTryToSubstitute()
`   `public void setAbsentFontTryToSubstitute(boolean substitute)

Changes in class **com.aspose.pdf.facades.PdfFileEditor** 
Added abstract class

`   `public static abstract class **ConcatenationProgressHandler**

with abstract method

`   `public abstract void invoke(ProgressEventHandlerInfo eventInfo);
Added class **ProgressEventHandlerInfo** with the following fields:
`   `public int EventType;
`   `public int DocumentNumber;
`   `public int Value;
`   `public int MaxValue;

Added enum class **ProgressEventType** with the following values:

`   `public static final int PageConcatenated = 0;
`   `public static final int BlankPage = 1;
`   `public static final int DocumentEmbeddedFiles = 3;
`   `public static final int DocumentForms = 4;
`   `public static final int DocumentOutlines = 5;
`   `public static final int DocumentJavaScript = 6;
`   `public static final int DocumentLogicalStructure = 7;
`   `public static final int AllPagesCopied = 8;
`   `public static final int DocumentConcated = 9;
`   `public static final int TotalPercentage = 10;

Changes in class **com.aspose.pdf.Font:** 
Added method:

`   `public double measureString(String str, float fontSize)

Changes in class **com.aspose.pdf.TextFragmentState:** 
Added method:

`   `public double measureString(String str)

Changes in class **com.aspose.pdf.TextState:** 
Added method:

`   `public double measureString(String str)

Changes in class **com.aspose.pdf.ImagePlacement:** 
Added method:

`   `public Matrix getMatrix()

Changes in class **com.aspose.pdf.printing.PdfPrinterSettings:** 
Added methods:

`   `public void setSelectedPages(int[] pagesList)
`   `public int[] getSelectedPages()** 
