---
title: Concatenate PDF Files in PHP
type: docs
weight: 10
url: /java/concatenate-pdf-files-in-php/
---

## **Aspose.PDF - Concatenate PDF Files**
To concatenate PDF files using **Aspose.PDF Java for PHP**, simply invoke **ConcatenatePdfFiles** class.

**PHP Code**

{{< highlight php >}}

 # Open the target document

$pdf1 = new Document($dataDir . 'input1.pdf');

\# Open the source document

$pdf2 = new Document($dataDir . 'input2.pdf');

\# Add the pages of the source document to the target document

$pdf1->getPages()->add($pdf2->getPages());

\# Save the concatenated output file (the target document)

$pdf1->save($dataDir . "Concatenate_output.pdf");

print "New document has been saved, please check the output file" . PHP_EOL;


{{< /highlight >}}
## **Download Running Code**
Download **Concatenate PDF Files (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithPages/ConcatenatePdfFiles.php)
