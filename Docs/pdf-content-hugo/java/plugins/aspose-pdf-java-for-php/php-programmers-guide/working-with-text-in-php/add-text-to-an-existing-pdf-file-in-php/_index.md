---
title: Add Text to an existing PDF file in PHP
type: docs
weight: 20
url: /java/add-text-to-an-existing-pdf-file-in-php/
---

## **Aspose.PDF - Add Text**
To add Text string in Pdf document using **Aspose.PDF Java for PHP**, simply invoke **AddText** module.

**PHP Code**

{{< highlight php >}}

 # Instantiate Document object

$doc = new Document($dataDir . 'input1.pdf');

\# get particular page

$pdf_page = $doc->getPages()->get_Item(1);

\# create text fragment

$text_fragment = new TextFragment("main text");

$text_fragment->setPosition(new Position(100, 600));


$font_repository = new FontRepository();

$color = new Color();

\# set text properties

$text_fragment->getTextState()->setFont($font_repository->findFont("Verdana"));

$text_fragment->getTextState()->setFontSize(14);

\# create TextBuilder object

$text_builder = new TextBuilder($pdf_page);

\# append the text fragment to the PDF page

$text_builder->appendText($text_fragment);

\# Save PDF file

$doc->save($dataDir . "Text_Added.pdf");

print "Text added successfully" . PHP_EOL;


{{< /highlight >}}
## **Download Running Code**
Download **Add Text (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithText/AddText.php)
