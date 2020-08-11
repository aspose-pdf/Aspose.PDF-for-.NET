---
title: Optimize PDF Document for the Web in PHP
type: docs
weight: 60
url: /java/optimize-pdf-document-for-the-web-in-php/
---

## **Aspose.PDF - Optimize PDF for Web**
To optimize PDF document for the web using **Aspose.PDF Java for PHP**, simply invoke **optimize_web** method of  **Optimize** class.

**PHP Code**

{{< highlight php >}}

 public static function optimize_web($dataDir=null)

{

    # Open a pdf document.

    $doc = new Document($dataDir . "input1.pdf");

    # Optimize for web

    $doc->optimize();

    #Save output document

    $doc->save($dataDir . "Optimized_Web.pdf");

    print "Optimized PDF for the Web, please check output file." . PHP_EOL;

}   


{{< /highlight >}}
## **Download Running Code**
Download **Optimize PDF for Web (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithDocumentObject/Optimize.php)
