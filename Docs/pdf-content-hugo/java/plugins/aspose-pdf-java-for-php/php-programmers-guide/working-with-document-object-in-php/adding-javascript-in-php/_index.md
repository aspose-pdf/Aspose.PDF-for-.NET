---
title: Adding JavaScript in PHP
type: docs
weight: 10
url: /java/adding-javascript-in-php/
---

## **Aspose.PDF - Adding JavaScript**
To add JavaScript in Pdf document using **Aspose.PDF Java for PHP**, simply invoke **AddJavaScript** class.

**PHP Code**

{{< highlight php >}}

 # Open a pdf document.

$doc = new Document($dataDir . "input1.pdf");

\# Adding JavaScript at Document Level

\# Instantiate JavascriptAction with desried JavaScript statement

$javaScript = new JavascriptAction("this.print({bUI:true,bSilent:false,bShrinkToFit:true});");

\# Assign JavascriptAction object to desired action of Document

$doc->setOpenAction($javaScript);

\# Adding JavaScript at Page Level

$doc->getPages()->get_Item(2)->getActions()->setOnOpen(new JavascriptAction("app.alert('page 2 is opened')"));

$doc->getPages()->get_Item(2)->getActions()->setOnClose(new JavascriptAction("app.alert('page 2 is closed')"));

\# Save PDF Document

$doc->save($dataDir . "JavaScript-Added.pdf");

print "Added JavaScript Successfully, please check the output file.";

{{< /highlight >}}
## **Download Running Code**
Download **Adding JavaScript (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_PHP/src/Aspose/Pdf/WorkingWithDocumentObject/AddJavascript.php)
