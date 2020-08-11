---
title: Set PDF File Information in PHP
type: docs
weight: 90
url: /java/set-pdf-file-information-in-php/
---

## **Aspose.PDF - Set PDF File Information**
To update Pdf document information using **Aspose.PDF Java for PHP**, simply invoke **SetPdfFileInfo** class.

**PHP Code**

{{< highlight php >}}

 # Open a pdf document.

$doc = new Document($dataDir . "input1.pdf");

\# Get document information

$doc_info = $doc->getInfo();

$doc_info->setAuthor("Aspose.PDF for java");

$doc_info->setCreationDate(new Date());

$doc_info->setKeywords("Aspose.PDF, DOM, API");

$doc_info->setModDate(new Date());

$doc_info->setSubject("PDF Information");

$doc_info->setTitle("Setting PDF Document Information");

\# save update document with new information

$doc->save($dataDir . "Updated_Information.pdf");

print "Update document information, please check output file.";


{{< /highlight >}}
## **Download Running Code**
Download **Set PDF File Information (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithDocumentObject/SetPdfFileInfo.php)
