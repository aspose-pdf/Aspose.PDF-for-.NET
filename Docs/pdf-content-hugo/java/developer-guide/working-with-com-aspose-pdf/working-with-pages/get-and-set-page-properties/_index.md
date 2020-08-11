---
title: Get and Set Page Properties
type: docs
weight: 20
url: /java/get-and-set-page-properties/
---

## **Get Page Count of PDF**
When working with documents, you often want to know how many pages they contain. With Aspose.PDF this takes no more than one line of code.
### **Get page count with saving PDF**
To get the number of pages in a PDF file:

1. Open the PDF file using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class.
1. Then use the Pages collection's size() method to get the total number of pages in the document.

The following code snippet shows how to get the number of pages in a PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-pages-GetPageCountOfPDF-.java" >}}
### **Get page count without saving PDF**
Unless the PDF file is saved and all the elements are actually placed inside the PDF file, we cannot get the page count for particular document (because we cannot be certain about the number of pages in which all the elements will be accommodated). However starting with release Aspose.PDF for Java 10.1.0, we have introduced a method named [**processParagraphs(...)**](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#processParagraphs--) which provides the feature to get page count for PDF document, without saving the file. So we can get page count information on the fly. Please try using following code snippet to accomplish this requirement.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Pages-GetPageCountOfPDF-GetPageCountWithoutSavingPDF.java" >}}


## **Get Page Properties**
Each page in a PDF file have a number of properties, such as the width, height, bleed-, crop- and trimbox. Aspose.PDF allows you to access these properties.
### **Understanding Page Properties: the Difference between Artbox, BleedBox, CropBox, MediaBox, TrimBox and Rect property**
- **Media box**: The media box is the largest page box. It corresponds to the page size (for example A4, A5, US Letter etc.) selected when the document was printed to PostScript or PDF. In other words, the media box determines the physical size of the media on which the PDF document is displayed or printed.
- **Bleed box**: If the document has bleed, the PDF will also have a bleed box. Bleed is the amount of color (or artwork) that extends beyond the edge of a page. It is used to make sure that when the document is printed and cut to size (“trimmed”), ink will go all the way to the edge of the page. Even if the page is mistrimmed - cut slightly off the trim marks - no white edges will appear on the page.
- **Trim box**: The trim box indicates the final size of a document after printing and trimming.
- **Art box**: The art box is the box drawn around the actual contents of the pages in your documents. This page box is used when importing PDF documents in other applications.
- **Crop box**: The crop box is the “page” size at which your PDF document is displayed in Adobe Acrobat. In normal view, only the contents of the crop box are displayed in Adobe Acrobat.
  For detailed descriptions of these properties, read the Adobe.Pdf specification, particularly 10.10.1 Page Boundaries.
- **Page.Rect**: the intersection (common visible rectangle) of the MediaBox and DropBox. The picture below illustrates these properties.

|![todo:image_alt_text](http://i.imgur.com/utLaWOZ.png)|
| :- |
### **Accessing Page Properties**
The [Page](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Page) class provides all the methods related to a particular PDF page. All the pages in PDF files are contained by the Document object's Pages collection. You can access an individual Page object using its Index value, or loop through the collection with a for loop and get all the pages. Once an individual page is accessed, you can get its properties.

The following code snippet shows how to get page properties.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-pages-GetPageProperties-.java" >}}
## **Determine Page Color**
The [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) class provides the properties related to a particular page in a PDF document, including what type of colour - RGB, black and white, grayscale or undefined - the page uses.

All the pages of the PDF files are contained by the [PageCollection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/PageCollection) collection. The [ColorType](https://apireference.aspose.com/java/pdf/com.aspose.pdf/ColorType) property specifies the color of elements on page. To get or determine the color information for particular PDF page, use the [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) class object's [ColorType](https://apireference.aspose.com/java/pdf/com.aspose.pdf/ColorType) property.

The following code snippet shows how to iterate through individual page of PDF file to get color information.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-pages-DeterminePageColor-.java" >}}
## **Change Page Orientation**
This article describes how to update or change the page orientation of pages in an existing PDF file.

Aspose.PDF for Java has feature to change the page orientation from landscape to portrait and vice versa. To change the page orientation, set the page’s [MediaBox](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#setMediaBox-com.aspose.pdf.Rectangle-) using the following code snippet.

You can also change page orientation by setting rotation angle using Rotate() method.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-pages-ChangePageOrientation-ChangePageOrientation.java" >}}
### **Fitting the Page Content to the New Page Orientation**
Please note that when using the above code snippet, some of the document’s content might be cut because the page height is decreased. To avoid this, increase width proportionally and leave the height intact. Example of calculations:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-pages-ChangePageOrientation-FittingThePageContentToNewPageOrientation.java" >}}
### **Zoom to the Page Contents**
Besides the above approach, consider using the PdfPageEditor facade which can apply a zoom to the page contents.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Pages-ChangePageOrientation-Info.java" >}}
## **Update Page Dimensions**
This article explains how to update/change the page dimensions (size) of an existing PDF file.

The [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) object contains the setPageSize(...) method which lets you set the page size and dimensions.

The code snippet below updates page dimensions in a few easy steps:

1. Load a source PDF file.
1. Get the pages into the [PageCollection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/PageCollection) object.
1. Get a given page.
1. Call the [setPageSize(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#setPageSize-double-double-) method to update the page dimensions.
1. Call the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class' save(..) method to generate a PDF with updated page dimensions.

The following code snippet shows how to change the PDF page dimensions to A4 size.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-pages-UpdatePageDimensions-.java" >}}
