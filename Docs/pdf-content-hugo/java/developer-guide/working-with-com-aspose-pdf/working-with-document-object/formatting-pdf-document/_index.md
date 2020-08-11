---
title: Formatting PDF Document
type: docs
weight: 30
url: /java/formatting-pdf-document/
---

## **Get Document Window and Page Display Properties**
This topic helps you understand how to get the properties of the document window, viewer application, and how pages are displayed.

To set these different properties, open the PDF file using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class. You can now get the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's methods, such as

- [IsCenterWindow](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#isCenterWindow--) – Center the document window on screen. Default: false.
- [SetDirection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setDirection-int-) – Reading order. This determines how pages are laid out when displayed side by side. Default: left to right.
- [isDisplayDocTitle](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#isDisplayDocTitle--) – Display the document title in the document window title bar. Default: false (the title is displayed).
- [setHideMenuBar](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setHideMenubar-boolean-) – Hide or display the document window's menu bar. Default: false (menu bar is displayed).
- [setHideToolBar](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setHideToolBar-boolean-) – Hide or display the document window's toolbar. Default: false (toolbar is displayed).
- [setHideWindowUI](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setHideWindowUI-boolean-) – Hide or display document window elements like scroll bars. Default: false (UI elements are displayed).
- [setNonFullScreenPageMode](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setNonFullScreenPageMode-int-) – How the document is displayed when it is not displayed in full-page mode.
- [setPageLayout](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setPageLayout-int-) – The page layout.
- [setPageMode](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setPageMode-int-) – How the document is displayed when first opened. The options are show thumbnails, full-screen, show attachment panel.

The following code snippet shows you how to get the properties using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-GetDocumentWindowAndPageDisplayProperties-.java" >}}
## **Set Document Window and Page Display Properties**
This topic explains how to set the properties of the document window, viewer application and page display.

To set these different properties:

1. Open the PDF file using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class.
1. Set the Document object's properties.
1. Save the updated PDF file using the **save** method.

Properties available are:

- [setCenterWindow](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setCenterWindow-boolean-)
- [setDirection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setDirection-int-)
- [setDisplayDocTitle](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setDisplayDocTitle-boolean-)
- [setFitWindow](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setFitWindow-boolean-)
- [setHideMenuBar](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setHideMenubar-boolean-)
- [setHideToolBar](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setHideToolBar-boolean-)
- [setHideWindowUI](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setHideWindowUI-boolean-)
- [setNonFullScreenPageMode](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setNonFullScreenPageMode-int-)
- [setPageLayout](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setPageLayout-int-)
- [setPageMode](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#setPageMode-int-)

The following code snippet shows you how to set the properties using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-SetDocumentWindowAndPageDisplayProperties-.java" >}}
## **Embedding Fonts in an Existing PDF File**
PDF readers support [a core of 14 fonts](http://en.wikipedia.org/wiki/Portable_Document_Format#Fonts) so that documents can be displayed the same way regardless of the platform the document is displayed on. When a PDF contains a font that is outside the core fonts, embed the font to avoid font substitution.

Aspose.PDF for Java supports font embedding in existing PDF documents. You can embed a complete font or a subset. To embed the font:

1. Open an existing PDF file using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class.
1. Use the [com.aspose.pdf.Font](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Font) class to embed the font.
   1. The setEmbedded(true) method embeds the full font.
   1. The pageFont.isSubset(true) method embeds a subset of the font.

A font subset embeds only the characters that are used and is useful where fonts are used for short sentences or slogans, for example where a corporate font is used for a logo, but not for the body text. Using a subset reduces the file size of the output PDF.

However, if a custom font is used for the body text, embed it in its entirety.

The following code snippet shows how to embed a font in a PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-EmbeddingFontsInExistingPDFFile-.java" >}}
## **Embedding Fonts while creating PDF**
If you need to use any font other than the 14 core fonts supported by Adobe Reader, then you must embed the font description while generating a PDF file. If font information is not embedded, Adobe Reader will take it from the Operating System if it’s installed over the system, or it will construct a substitute font according to the font descriptor in the PDF. Please note that embedded font must be installed on the host machine i.e. in case of the following code ‘Univers Condensed’ font is installed over the system.

We use the property setEmbedded of [Font](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Font) class to embed the font information into PDF file. Setting the value of this property to ‘true’ will embed the complete font file into the PDF, knowing the fact that it will increase the PDF file size. Following is the code snippet that can be used to embed the font information into PDF.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-EmbeddingFontsWhileCreatingPDF-.java" >}}
## **Set Default Font Name while Saving PDF**
When a PDF document contains fonts, which are not available in the document itself and on the device, API replaces these fonts with the default font. When a font is available (is installed on the device or is embedded into the document), output PDF should have the same font (should not be replaced with default font). The value of the default font should contain the name of the font (not the path to the font files). We have implemented a feature to set default font name while saving a document as PDF. Following code snippet can be used to set default font:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-pdf-DocumentObject-SetDefaultFont.java" >}}
## **Get All Fonts from PDF Document**
In case you want to get all fonts from a PDF document, you can use **Document.getFontUtilities().getAllFonts()** method provided in **Document** class. Please check following code snippet in order to get all fonts from an existing PDF document:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-pdf-DocumentObject-GetAllFonts.java" >}}
## **Trim White Space around Page**
A PDF file is comprised of text, images, graphics and various other objects. To remove or trim the white space around a PDF page, set the [CropBox](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#setCropBox-com.aspose.pdf.Rectangle-) and [MediaBox](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#setMediaBox-com.aspose.pdf.Rectangle-) for that particular page. To determine the correct value of the [CropBox](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#setCropBox-com.aspose.pdf.Rectangle-) and [MediaBox](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#setMediaBox-com.aspose.pdf.Rectangle-) coordinates, first you need to identify the position of objects on the page.

The graphics primitives boundary detection is not a reliable approach. It is highly probable that some objects can't be found in facades and provide the API to get their rectangle. So it is recommend to get page contents boundary and set Page [CropBox](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/page/methods/setCropBox\(com.aspose.pdf.Rectangle\)/) and [MediaBox](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#setMediaBox-com.aspose.pdf.Rectangle-) to trim white space around the page. You can either render the PDF page to an image and then determine the margins or you can also use [calculateContentBBox](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#calculateContentBBox--) method of [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) class to calculate rectangle containing page contents without visible margins.

The following code snippet shows how to trim white space around a page using [calculateContentBBox](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page#calculateContentBBox--)

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-TrimWhiteSpaceAroundPage-.java" >}}
## **Get-Set Zoom Factor of PDF File**
Sometimes, you want to set or get the zoom factor of a PDF document. You can easily accomplish this requirement with Aspose.PDF.

The [GoToAction](https://apireference.aspose.com/java/pdf/com.aspose.pdf/GoToAction) object allows you to get the zoom value associated with a PDF file. Similarly, it can be used to set a file's Zoom factor.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-GetSetZoomFactorOfPDFFile-GetSetZoomFactorOfPDFFile.java" >}}



The following code snippet shows how to get the Zoom factor of a PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-GetSetZoomFactorOfPDFFile-GetZoomFactor.java" >}}
