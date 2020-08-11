---
title: Get PDF File Information in PHP
type: docs
weight: 40
url: /java/get-pdf-file-information-in-php/
---

## **Aspose.PDF - Get PDF File Information**
To Get File Information of Pdf document using **Aspose.PDF Java for PHP**, simply invoke **GetPdfFileInfo** class.

**PHP Code**

{{< highlight php >}}

 # Open a pdf document.

$doc = new Document($dataDir . "input1.pdf");

\# Get document information

$doc_info = $doc->getInfo();

\# Show document information

print "Author:-" . $doc_info->getAuthor();

print "Creation Date:-" . $doc_info->getCreationDate();

print "Keywords:-" . $doc_info->getKeywords();

print "Modify Date:-" . $doc_info->getModDate();

print "Subject:-" . $doc_info->getSubject();

print "Title:-" . $doc_info->getTitle();


{{< /highlight >}}
## **Download Running Code**
Download **Get PDF File Information (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithDocumentObject/GetPdfFileInfo.php)
