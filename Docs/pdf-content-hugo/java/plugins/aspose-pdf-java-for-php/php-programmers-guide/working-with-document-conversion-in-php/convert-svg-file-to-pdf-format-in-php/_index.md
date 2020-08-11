---
title: Convert SVG file to PDF format in PHP
type: docs
weight: 40
url: /java/convert-svg-file-to-pdf-format-in-php/
---

## **Aspose.PDF - Convert SVG to PDF**
To convert SVG file to PDF format using **Aspose.PDF Java for PHP**, simply invoke **SvgToPdf** module.

**PHP Code**

{{< highlight php >}}

 # Instantiate LoadOption object using SVG load option

$options = new SvgLoadOptions();

\# Create document object

$pdf = new Document($dataDir . 'Example.svg', $options);

\# Save the output to XLS format

$pdf->save($dataDir . "SVG.pdf");

print "Document has been converted successfully";


{{< /highlight >}}
## **Download Running Code**
Download **Convert SVG to PDF (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithDocumentConversion/SvgToPdf.php)
