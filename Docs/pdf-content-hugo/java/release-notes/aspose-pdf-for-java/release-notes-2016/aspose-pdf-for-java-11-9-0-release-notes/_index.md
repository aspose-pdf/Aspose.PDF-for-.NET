---
title: Aspose.Pdf for Java 11.9.0 Release Notes
type: docs
weight: 50
url: /java/aspose-pdf-for-java-11-9-0-release-notes/
---

### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|PDFJAVA-35961 |Indentation is missing in TOC |Enhancement |
|PDFJAVA-36018 |Changing image dpi in PDF document distort the image |Enhancement |
|PDFNEWJAVA-34615 |PDF to PDF/A - Some images appear as black in resultant file |Bug |
|PDFNEWJAVA-35826 |PDF to PDF/A - Resultant file is not PDF/A_1a compliant |Bug |
|PDFNEWJAVA-35647 |XFA to standard PDF - Contents are missing |Bug |
|PDFNEWJAVA-35787 |PDF to PDF/A - Exception during conversion |Bug |
|PDFNEWJAVA-35299 |PDF to PNG: incorrect background of some elements |Bug |
|PDFNEWJAVA-35419 |Unable to read metadata |Bug |
|PDFNEWJAVA-35437 |PDF to PNG: Blue background instead of violet |Bug |
|PDFNEWJAVA-34211 |Nullpointer Exception on some Linux Systems when validating PDF/A |Bug |
|PDFNEWJAVA-35278 |HTML to PDF: Incorrect TextArea's font size in Linux |Bug |
|PDFNEWJAVA-34995 |PDF to HTML with embedded resources loses the image |Bug |
|PDFJAVA-36053 |License Error: The signature is invalid |Bug |
### **Public API Changes**
- Added default constructor public Color() to the **class com.aspose.pdf.Color**:
- The class **com.aspose.pdf.Paragraphs** becomes implemented **Iterable<BaseParagraph>**
- Conversions from Epub format and from/to Latex format are temporarily disabled till the next release.
- The legacy engine (package aspose.pdf.*) is moved from the build to another jar file (aspose.pdf.legacy-11.9.0.jar) with deleting all the methods bind with it.
- **License** and **AssemblyConstants** classes for the legacy jar were moved into the package: **com.aspose.pdf.legacy** 
  All the other classes from the package aspose.pdf.* were not changed.

Deleted public void **bindPdf**(aspose.pdf.Pdf pdf) method from following classes:

- com.aspose.pdf.facades.**Facade**;
- com.aspose.pdf.facades.**PdfAnnotationEditor**;
- com.aspose.pdf.facades.**PdfBookmarkEditor**;
- com.aspose.pdf.facades.**PdfContentEditor**;
- com.aspose.pdf.facades.**PdfConverter**;
- com.aspose.pdf.facades.**PdfExtractor**;
- com.aspose.pdf.facades.**PdfFileSignature**;
- com.aspose.pdf.facades.**PdfPageEditor**;
- com.aspose.pdf.facades.**PdfXmpMetadata**;

Changes in class **com.aspose.pdf.facades.Stamp**

- deleted method: public void bindPdf (aspose.pdf.Pdf pdf, int pageNumber)

"LegacyEngine is not supported now"

- Using **com.aspose.pdf.LoadFormat.XML** throws the exception **ApplicationException** with the text:
  This constant will be completely deleted in the next release.

Changes in class **com.aspose.pdf.Document**:

- deleted constuctor: public Document(aspose.pdf.Pdf pdf)

Changes in class **com.aspose.pdf.Document.OptimizationOptions:**

added methods:

- public int getMaximumImageDimension()
- public void setMaximumImageDimension(int dimension)
- public int getResolution()
- public void setResolution(int dpi)

Changes in class **com.aspose.pdf.DocumentWeb**:

- deleted constructor:**public DocumentWeb(aspose.pdf.Pdf pdf)**

Changes in class **com.aspose.pdf.Annotation**:

- deleted method:public Page getPage()
  com.aspose.pdf.Paragraphs
