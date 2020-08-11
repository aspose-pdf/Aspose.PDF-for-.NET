---
title: Convert PDF to SVG Format in PHP
type: docs
weight: 30
url: /java/convert-pdf-to-svg-format-in-php/
---

## **Aspose.PDF - Convert PDF to SVG**
To convert PDF to SVG format using **Aspose.PDF Java for PHP**, simply invoke **PdfToSvg** module.

**PHP Code**

{{< highlight php >}}

 # Open the target document

$pdf = new Document($dataDir . 'input1.pdf');

\# instantiate an object of SvgSaveOptions

$save_options = new SvgSaveOptions();

\# do not compress SVG image to Zip archive

$save_options->CompressOutputToZipArchive = false;

\# Save the output to XLS format

$pdf->save($dataDir . "Output.svg", $save_options);

print "Document has been converted successfully" . PHP_EOL;


{{< /highlight >}}
## **Download Running Code**
Download **Convert PDF to SVG Format (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithDocumentConversion/PdfToSvg.php)
