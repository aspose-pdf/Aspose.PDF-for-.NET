---
title: Add TOC to Existing PDF in PHP
type: docs
weight: 20
url: /java/add-toc-to-existing-pdf-in-php/
---

## **Aspose.PDF - Add TOC**
To add TOC in Pdf document using **Aspose.PDF Java for PHP**, simply invoke **AddToc** class.

**PHP Code**

{{< highlight php >}}

 # Open a pdf document.

$doc = new Document($dataDir . "input1.pdf");

\# Get access to first page of PDF file

$toc_page = $doc->getPages()->insert(1);

\# Create object to represent TOC information

$toc_info = new TocInfo();

$title = new TextFragment("Table Of Contents");

$title->getTextState()->setFontSize(20);

#title.getTextState().setFontStyle(Rjb::import('com.aspose.pdf.FontStyles.Bold'))

\# Set the title for TOC

$toc_info->setTitle($title);

$toc_page->setTocInfo($toc_info);

\# Create string objects which will be used as TOC elements

$titles = array("First page", "Second page");

$i = 0;

while ($i < 2){

    # Create Heading object

    $heading2 = new Heading(1);

    $segment2 = new TextSegment();

    $heading2->setTocPage($toc_page);

    $heading2->getSegments()->add($segment2);

    # Specify the destination page for heading object

    $heading2->setDestinationPage($doc->getPages()->get_Item($i + 2));

    # Destination page

    $heading2->setTop($doc->getPages()->get_Item($i + 2)->getRect()->getHeight());

    # Destination coordinate

    $segment2->setText($titles[$i]);

    # Add heading to page containing TOC

    $toc_page->getParagraphs()->add($heading2);

    $i +=1;

}

\# Save PDF Document

$doc->save($dataDir . "TOC.pdf");

print "Added TOC Successfully, please check the output file.";


{{< /highlight >}}
## **Download Running Code**
Download **Add TOC (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithDocumentObject/AddToc.php)
