---
title: Remove Metadata from PDF in PHP
type: docs
weight: 70
url: /java/remove-metadata-from-pdf-in-php/
---

## **Aspose.PDF - Remove Metadata**
To remove Metadata from Pdf document using **Aspose.PDF Java for PHP**, simply invoke **RemoveMetadata** class.

**PHP Code**

{{< highlight php >}}

 # Open a pdf document.

$doc = new Document($dataDir . "input1.pdf");

if (preg_match('/pdfaid:part/',$doc->getMetadata())) {

    $doc->getMetadata()->removeItem("pdfaid:part");

}

if (preg_match('/dc:format/',$doc->getMetadata())) {

    $doc->getMetadata()->removeItem("dc:format");

}

\# save update document with new information

$doc->save($dataDir . "Remove_Metadata.pdf");

print "Removed metadata successfully, please check output file." . PHP_EOL;


{{< /highlight >}}
## **Download Running Code**
Download **Remove Metadata (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithDocumentObject/RemoveMetadata.php)
