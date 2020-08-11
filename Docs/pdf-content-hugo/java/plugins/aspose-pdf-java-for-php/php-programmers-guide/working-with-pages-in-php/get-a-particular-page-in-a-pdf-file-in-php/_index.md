---
title: Get a Particular Page in a PDF File in PHP
type: docs
weight: 30
url: /java/get-a-particular-page-in-a-pdf-file-in-php/
---

## **Aspose.PDF - Get Page**
To get a Particular Page in a PDF document using **Aspose.PDF Java for Ruby**, simply invoke **GetPage** class.

**Ruby Code**

{{< highlight ruby >}}

 # Open the target document

$pdf = new Document($dataDir . 'input1.pdf');

\# get the page at particular index of Page Collection

$pdf_page = $pdf->getPages()->get_Item(1);

\# create a new Document object

$new_document = new Document();

\# add page to pages collection of new document object

$new_document->getPages()->add($pdf_page);

\# save the newly generated PDF file

$new_document->save($dataDir . "output.pdf");

print "Process completed successfully!";


{{< /highlight >}}
## **Download Running Code**
Download **Get Page (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithPages/GetPage.php)
