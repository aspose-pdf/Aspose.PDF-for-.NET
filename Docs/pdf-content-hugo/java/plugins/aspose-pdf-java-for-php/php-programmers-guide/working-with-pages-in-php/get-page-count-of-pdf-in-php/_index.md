---
title: Get Page Count of PDF in PHP
type: docs
weight: 40
url: /java/get-page-count-of-pdf-in-php/
---

## **Aspose.PDF - Get Page Count**
To get page count of Pdf document using **Aspose.PDF Java for PHP**, simply invoke **GetNumberOfPages** class.

**PHP Code**

{{< highlight php >}}

 # Create PDF document

$pdf = new Document($dataDir . 'input1.pdf');

$page_count = $pdf->getPages()->size();

print "Page Count:" . $page_count . PHP_EOL;


{{< /highlight >}}
## **Download Running Code**
Download **Get Page Count (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithPages/GetNumberOfPages.php)
