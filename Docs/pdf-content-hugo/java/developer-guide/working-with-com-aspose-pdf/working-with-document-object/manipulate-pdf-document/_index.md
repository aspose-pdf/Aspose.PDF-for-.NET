---
title: Manipulate PDF Document
type: docs
weight: 50
url: /java/manipulate-pdf-document/
---

## **Converting non searchable PDF to searchable PDF document**
Aspose.PDF for Java provides the feature to create as well as manipulate existing PDF documents. When adding Text elements inside PDF file, the resultant PDF is searchable. However if we are converting an Image containing text to PDF file, the contents inside PDF are not searchable. However as a workaround, we can use OCR over the resultant file, so that it becomes searchable.

This logic specified below recognizes text for PDF images. For recognition you may use [outer OCR supports HOCR standard](http://en.wikipedia.org/wiki/HOCR). For testing purposes, we have used a free [Google tesseract OCR](http://en.wikipedia.org/wiki/Tesseract_%28software%29). Therefore first you need to install [Tesseract-OCR](https://github.com/tesseract-ocr) on your system, and you will have tesseract console application.

Following is complete code to accomplish this requirement.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-DocumentObject-ConvertingNonSearchablePDFToSearchablePDFDocument-ConvertingNonSearchablePDFToSearchablePDFDocument.java" >}}
## **Validate PDF Document for PDF A Standard (A 1A and A 1B)**
To validate a PDF document for PDF/A-1a or PDF/A-1b compatibility, use the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class' [validate(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#validate-java.io.OutputStream-int-) method. This method allows you to specify the name of the file in which the result is to be saved and the required validation type [PdfFormat](https://apireference.aspose.com/java/pdf/com.aspose.pdf/PdfFormat) enumeration: PDF_A_1A or PDF_A_1B.

The output XML format is a custom Aspose format. The XML contains a collection of tags with the name Problem; each tag contains the details of a particular problem. The Problem tag's ObjectID attribute represents the ID of the particular object this problem is related to. The Clause attribute represents a corresponding rule in the PDF specification.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-ValidatePDFDocumentForPDFAStandard-.java" >}}
## **Working with TOC**
### **Add TOC to Existing PDF**
The ListSection class in the aspose.pdf package allows you to create a table of contents when creating a PDF document from scratch. To add headings, which are elements of the TOC, use the [aspose.pdf.Heading](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Heading) class.

To add a TOC to an existing PDF file, use the [Heading](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Heading) class in the com.aspose.pdf package. The com.aspose.pdf package can both create new and manipulate existing PDF files. To add a TOC to an existing PDF, use com.aspose.pdf package.

The following code snippet shows how to create a table of contents inside an existing PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-AddTOCToExistingPDF-.java" >}}
### **Set different TabLeaderType for different TOC Levels**
Aspose.PDF also allows setting different TabLeaderType for different TOC levels. You need to set LineDash property of FormatArray with the appropriate value of TabLeaderType enum as following.

**Java**

{{< highlight java >}}

 String outFile = "TOC.pdf";

com.aspose.pdf.Document doc = new com.aspose.pdf.Document();

Page tocPage = doc.getPages().add();

TocInfo tocInfo = new TocInfo();

//set LeaderType

tocInfo.setLineDash(TabLeaderType.Solid);

TextFragment title = new TextFragment("Table Of Contents");

title.getTextState().setFontSize(30);

tocInfo.setTitle(title);

//Add the list section to the

sections collection of the Pdf document

tocPage.setTocInfo(tocInfo);

//Define the format of the four levels list by setting the left margins

//and

//text format settings of each level

tocInfo.setFormatArrayLength(4);

tocInfo.getFormatArray()[0].getMargin().setLeft(0);

tocInfo.getFormatArray()[0].getMargin().setRight(30);

tocInfo.getFormatArray()[0].setLineDash(TabLeaderType.Dot);

tocInfo.getFormatArray()[0].getTextState().setFontStyle(FontStyles.Bold|FontStyles.Italic);

tocInfo.getFormatArray()[1].getMargin().setLeft(10);

tocInfo.getFormatArray()[1].getMargin().setRight(30);

tocInfo.getFormatArray()[1].setLineDash(TabLeaderType.None);

tocInfo.getFormatArray()[1].getTextState().setFontSize(10);

tocInfo.getFormatArray()[2].getMargin().setLeft(20);

tocInfo.getFormatArray()[2].getMargin().setRight(0);

tocInfo.getFormatArray()[2].getTextState().setFontStyle(FontStyles.Bold);

tocInfo.getFormatArray()[3].setLineDash(TabLeaderType.Solid);

tocInfo.getFormatArray()[3].getMargin().setLeft(30);

tocInfo.getFormatArray()[3].getMargin().setRight(30);

tocInfo.getFormatArray()[3].getTextState().setFontStyle(FontStyles.Bold);

//Create a section in the Pdf document

Page page = doc.getPages().add();

//Add four headings in the section


for (int Level = 1; Level<= 4; Level++)

{ 

com.aspose.pdf.Heading heading2 = new com.aspose.pdf.Heading(Level);

TextSegment segment2 = new TextSegment();

heading2.getSegments().add(segment2);

heading2.setAutoSequence(true);

heading2.setTocPage(tocPage);

segment2.setText("Sample Heading" + Level);

heading2.getTextState().setFont(FontRepository.findFont("Arial UnicodeMS"));



//Add the heading into Table Of Contents. 

heading2.setInList(true); 

page.getParagraphs().add(heading2); 

}

// save the Pdf 

doc.save(outFile);

{{< /highlight >}}
## **Add Layers to PDF File**
Layers can be used in PDF documents in many ways. You might have a multi-lingual file that you want to distribute and want text in each language to appear on different layers, with the background design appearing on a separate layer. You might also create documents with animation that appears on a separate layer. One example could be to add a license agreement to your file, and you don’t want a user to view the content until they agree to the terms of the agreement.

Aspose.PDF for Java supports adding layers to PDF files.

To work with layers in PDF files, use the following API members.

The [Layer](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Layer) class represents a layer and contains the following properties:

- **Name** – the layer's name.
- **Id** – the layer's ID.
- **Contents** – a list of layer operators.

Once the [Layer](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Layer) objects have been defined, add them to the [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) object's Layers collection. The code below shows how to add layers to a PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-AddLayersToPDFFile-.java" >}}
## **Set PDF Expiration**
The PDF expiration feature sets how long a PDF file is valid for. On a particular date, if someone tries to access it, a pop-up is displayed, explaining that the file has expired and that they need a new one.

Aspose.PDF allows you to set expiration when creating and editing PDF files.

The code snippet below shows how to set the expiration date for a PDF file. You need to use JavaScript as files saved by third party components (for example OwnerGuard) cannot be viewed on other workstations without that utility.

The PDF file can be created using PDF OwnerGuard using an existing file with an expiration date. But the new file can be opened only on a workstation that has PDF OwnerGuard installed. Workstations without PDF OwnerGuard will give an ExpirationFeatureError. For example, PDF Reader opens the file if OwnerGuard is installed, but Adobe Acrobat returns an error.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-SetPDFExpiration-.java" >}}
