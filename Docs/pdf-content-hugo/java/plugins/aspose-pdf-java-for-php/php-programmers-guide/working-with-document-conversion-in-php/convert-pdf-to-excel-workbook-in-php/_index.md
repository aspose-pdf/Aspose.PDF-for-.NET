---
title: Convert PDF to Excel Workbook in PHP
type: docs
weight: 20
url: /java/convert-pdf-to-excel-workbook-in-php/
---

## **Aspose.PDF - Convert PDF to Excel Workbook**
To convert PDF document to Excel Workbook using **Aspose.PDF Java for PHP**, simply invoke **PdfToExcel** module.

**PHP Code**

{{< highlight php >}}

 # Open the target document

$pdf = new Document($dataDir . 'input1.pdf');

\# Instantiate ExcelSave Option object

$excelsave = new ExcelSaveOptions();

\# Save the output to XLS format

$pdf->save($dataDir . "Converted_Excel.xls", $excelsave);

print "Document has been converted successfully" . PHP_EOL;


{{< /highlight >}}
## **Download Running Code**
Download **Convert PDF to Excel Workbook (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithDocumentConversion/PdfToExcel.php)
