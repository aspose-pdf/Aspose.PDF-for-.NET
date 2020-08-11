---
title: Add HTML String using DOM in PHP
type: docs
weight: 10
url: /java/add-html-string-using-dom-in-php/
---

## **Aspose.PDF - Add HTML**
To add HTML string in Pdf document using **Aspose.PDF Java for PHP**, simply invoke **AddHtml** module.

**PHP Code**

{{< highlight php >}}

 # Instantiate Document object

$doc = new Document();

\# Add a page to pages collection of PDF file

$page = $doc->getPages()->add();

\# Instantiate HtmlFragment with HTML contents

$title = new HtmlFragment("<fontsize=10><b><i>Table</i></b></fontsize>");

\# set MarginInfo for margin details

$margin = new MarginInfo();

$margin->setBottom(10);

$margin->setTop(200);

\# Set margin information

$title->setMargin($margin);

\# Add HTML Fragment to paragraphs collection of page

$page->getParagraphs()->add($title);

\# Save PDF file

$doc->save($dataDir . "html.output.pdf");

print "HTML added successfully" . PHP_EOL;


{{< /highlight >}}
## **Download Running Code**
Download **Add HTML (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithText/AddHtml.php)
