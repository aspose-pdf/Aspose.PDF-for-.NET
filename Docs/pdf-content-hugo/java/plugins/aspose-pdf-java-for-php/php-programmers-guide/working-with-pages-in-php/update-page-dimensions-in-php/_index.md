---
title: Update Page Dimensions in PHP
type: docs
weight: 90
url: /java/update-page-dimensions-in-php/
---

## **Aspose.PDF - Update Page Dimensions**
To update page Dimensions using **Aspose.PDF Java for PHP**, simply invoke **UpdatePageDimensions** class.

**PHP Code**

{{< highlight php >}}

 # Open the target document

$pdf = new Document($dataDir . 'input1.pdf');

\# get page collection

$page_collection = $pdf->getPages();

\# get particular page

$pdf_page = $page_collection->get_Item(1);

\# set the page size as A4 (11.7 x 8.3 in) and in Aspose.PDF, 1 inch = 72 points

\# so A4 dimensions in points will be (842.4, 597.6)

$pdf_page->setPageSize(597.6,842.4);

\# save the newly generated PDF file

$pdf->save($dataDir . "output.pdf");

print "Dimensions updated successfully!" . PHP_EOL;


{{< /highlight >}}
## **Download Running Code**
Download **Update Page Dimensions (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithPages/UpdatePageDimensions.php)
