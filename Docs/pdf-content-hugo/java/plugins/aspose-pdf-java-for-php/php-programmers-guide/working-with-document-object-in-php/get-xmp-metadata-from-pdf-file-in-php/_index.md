---
title: Get XMP Metadata from PDF File in PHP
type: docs
weight: 50
url: /java/get-xmp-metadata-from-pdf-file-in-php/
---

## **Aspose.PDF - Get XMP Metadata**
To get XMP Metadata from Pdf document using **Aspose.PDF Java for PHP**, simply invoke **GetXMPMetadata** class.

**PHP Code**

{{< highlight php >}}

 # Open a pdf document.

$doc = new Document($dataDir . "input1.pdf");

\# Get properties

print "xmp:CreateDate: " + $doc->getMetadata()->get_Item("xmp:CreateDate") . PHP_EOL;

print "xmp:Nickname: " + $doc->getMetadata()->get_Item("xmp:Nickname") . PHP_EOL;

print "xmp:CustomProperty: " + $doc->getMetadata()->get_Item("xmp:CustomProperty") . PHP_EOL;


{{< /highlight >}}
## **Download Running Code**
Download **Get XMP Metadata (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithDocumentObject/GetXMPMetadata.php)
