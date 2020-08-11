---
title: Aspose.Pdf for Java 11.8.0 Release Notes
type: docs
weight: 60
url: /java/aspose-pdf-for-java-11-8-0-release-notes/
---

### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|PDFNEWJAVA-35092 |PDF to HTML - Contents missing and wrong background color |Bug |
|PDFNEWJAVA-35637 |PDF to PDF/A - Image starts appearing on top of page title |Bug |
|PDFNEWJAVA-33957 |Error opening readonly PDF |Bug |
|PDFNEWJAVA-34629 |PDF to Doc: Redundant tab character before a last bullet item |Bug |
|PDFNEWJAVA-34757 |PDF to Doc: Redundant characters after bullet items |Bug |
|PDFNEWJAVA-35835 |setKeptWithNext is not working as expected |Bug |
|PDFNEWJAVA-35582 |PDF to PDF/A_3a - Resultant file is not PDF/A compliant |Bug |
|PDFNEWJAVA-35634 |PDF to PDF/A - Text formatting is lost and contents are missing |Bug |
|PDFNEWJAVA-35635 |PDF to PDF/A - Logo orientation is changed and background information is lost |Bug |
|PDFNEWJAVA-35636 |PDF to PDF/A - Background becomes black |Bug |
|PDFNEWJAVA-35699 |PDF to PDFA conversion duplicates background image |Bug |
|PDFNEWJAVA-35852 |PDF to PDF/A - Issue with images |Bug |
|PDFNEWJAVA-35817 |PdfPrinterSettings crash on iSeries (Java) |Bug |
|PDFNEWJAVA-34262 |Concatenation: Bookmarks are not being copied to Merged Document |Bug |
|PDFJAVA-35884 |PDF to PDF/A - Resultant file is not Tagged |Bug |
### **Public API Changes**
Changes in class **com.aspose.pdf.XFA:** 
added method:

- public HashMap<String, String> getFieldsWithTextValuesMap()

Changes in class **com.aspose.pdf.PdfFormatConversionOptions:** 
added methods:

- public boolean isLowMemoryMode()
- public void setLowMemoryMode(boolean value)

Changes in class **com.aspose.pdf.FontSubstitution:** 
added method:

- public FontDefinition getSubstitutionFontDefinition()
