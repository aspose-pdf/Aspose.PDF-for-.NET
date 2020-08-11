---
title: Set PDF Expiration in PHP
type: docs
weight: 80
url: /java/set-pdf-expiration-in-php/
---

## **Aspose.PDF - Set PDF Expiration**
To set expiration of  Pdf document using **Aspose.PDF Java for PHP**, simply invoke **SetExpiration** class.

**PHP Code**

{{< highlight php >}}

 # Open a pdf document.

$doc = new Document($dataDir . "input1.pdf");

$javascript = new JavascriptAction(

        "var year=2014;

    var month=4;

    today = new Date();

    today = new Date(today.getFullYear(), today.getMonth());

    expiry = new Date(year, month);

    if (today.getTime() > expiry.getTime())

    app.alert('The file is expired. You need a new one.');");

$doc->setOpenAction($javascript);

\# save update document with new information

$doc->save($dataDir . "set_expiration.pdf");

print "Update document information, please check output file." . PHP_EOL;


{{< /highlight >}}
## **Download Running Code**
Download **Set PDF Expiration (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithDocumentObject/SetExpiration.php)
