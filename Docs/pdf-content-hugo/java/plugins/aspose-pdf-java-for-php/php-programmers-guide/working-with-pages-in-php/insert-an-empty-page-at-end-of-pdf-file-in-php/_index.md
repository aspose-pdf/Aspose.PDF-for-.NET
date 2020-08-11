---
title: Insert an Empty Page at End of PDF File in PHP
type: docs
weight: 60
url: /java/insert-an-empty-page-at-end-of-pdf-file-in-php/
---

## **Aspose.PDF - Insert an Empty Page at End of PDF File**
To Insert an Empty Page at the end of PDF document using **Aspose.PDF Java for PHP**, simply invoke **InsertEmptyPageAtEndOfFile** class.

**PHP Code**

{{< highlight php >}}

 # Open the target document

$pdf = new Document($dataDir . 'input1.pdf');

\# insert a empty page in a PDF

$pdf->getPages()->add();

\# Save the concatenated output file (the target document)

$pdf->save($dataDir . "output.pdf");

print "Empty page added successfully!" . PHP_EOL;

{{< /highlight >}}
## **Download Running Code**
Download **Insert an Empty Page at End of PDF File (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithPages/InsertEmptyPageAtEndOfFile.php)
