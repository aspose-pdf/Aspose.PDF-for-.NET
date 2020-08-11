---
title: Aspose.PDF for Java 20.1 Release Notes
type: docs
weight: 40
url: /java/aspose-pdf-for-java-20-1-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PDF for Java 20.1.

{{% /alert %}} 
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-37208|[Extracting the text content from stamp annotation](/pdf/java/extract-text-from-stamps/)|New Feature|
|PDFJAVA-37806 |PCL to PDF OutOfMemoryError occurred|Bug|
|PDFJAVA-37808 |PCL to PDF Program hangs keeps running without generating file|Bug|
|PDFJAVA-38822|Exception CrossTableNotFoundException while getting the page|Bug|
|PDFJAVA-39049 |merging XFDF with the PDF template produces all checkboxes unchecked|Bug|
|PDFJAVA-38828|NullPointerException on parsing annotation with 3D content|Bug|
|PDFJAVA-34799|PDF to EPUB - Resultant file is not correct|Bug|
|PDFJAVA-36630 |HTML to PDF having float not working|Bug|
|PDFJAVA-36004|PDF to HTML - Static text appears as Hyperlink|Bug|
|PDFJAVA-36311|PDF to DOC: text line missing|Bug|
|PDFJAVA-37273 |SVG to PDF - the image is being displaced|Bug|
|PDFJAVA-37032|EPUB to PDF - Exception during conversion|Bug|
|PDFJAVA-39025|NullPointerException Since 19.8 version|Bug|
## **Public API and Backwards Incompatible Changes**
**Changed parameter type for methods**

- com.aspose.pdf.Border.setHCornerRadius
- com.aspose.pdf.**Border**.getVCornerRadius
- int -> double

**Added new methods**

- com.aspose.pdf.**Form**.getAutoRecalculate">
- com.aspose.pdf.**Form**.setAutoRecalculate(boolean)">
- com.aspose.pdf.**XImageCollection**.delete(int,int)">
- com.aspose.pdf.**XImageCollection**.delete(String,int)">

**Added New Class**

- com.aspose.pdf.**ImageDeleteAction**"> with fields
  - **None**
  - **ForceDelete**
  - **Check**

**Added default constructor in class**

- com.aspose.pdf.Table
