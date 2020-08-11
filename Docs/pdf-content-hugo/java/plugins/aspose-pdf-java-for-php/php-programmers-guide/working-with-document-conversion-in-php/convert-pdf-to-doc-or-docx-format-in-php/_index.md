---
title: Convert PDF to DOC or DOCX format in PHP
type: docs
weight: 10
url: /java/convert-pdf-to-doc-or-docx-format-in-php/
---

## **Aspose.PDF - Convert PDF to DOC or DOCX**
To convert PDF document to DOC or DOCX format using **Aspose.PDF Java for PHP**, simply invoke **PdfToDoc** module.

**PHP Code**

{{< highlight php >}}

 # Open the target document

$pdf = new Document($dataDir . 'input1.pdf');

\# Save the concatenated output file (the target document)

$pdf->save($dataDir . "output.doc");

print "Document has been converted successfully";


{{< /highlight >}}
## **Download Running Code**
Download **Convert PDF to DOC or DOCX (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithDocumentConversion/PdfToDoc.php)
