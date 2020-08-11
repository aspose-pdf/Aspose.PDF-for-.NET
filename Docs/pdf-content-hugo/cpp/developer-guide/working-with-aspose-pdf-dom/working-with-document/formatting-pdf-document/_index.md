---
title: Formatting PDF Document
type: docs
weight: 10
url: /cpp/formatting-pdf-document/
---

## **Get/Set Document Window and Page Display Properties**
This topic helps you understand how to get/set properties of the document window, viewer application, and how pages pages are displayed. In order to get these properties:

Open the PDF file using the Document class. Now, you can select the Document object's properties, such as

- CenterWindow – Center the document window on screen. Default: false.
- Direction – Reading order. This determines how pages are laid out when displayed side by side. Default: left to right.
- DisplayDocTitle – Display the document title in the document window title bar. Default: false (the title is displayed).
- HideMenuBar -– Hide or display the document window's menu bar. Default: false (menu bar is displayed).
- HideToolBar -– Hide or display the document window's toolbar. Default: false (toolbar is displayed).
- HideWindowUI -– Hide or display document window elements like scroll bars. Default: false (UI elements are displayed).
- NonFullScreenPageMode -– How the document when its not displayed in full-page mode.
- PageLayout -– The page layout.
- PageMode -– How the document is displayed when first opened. The options are show thumbnails, full-screen, show attachment panel.

In order to set the properties of the document window, viewer application and page display:

1. Open the PDF file using the Document class.
1. Set the Document object's properties.
1. Save the updated PDF file using the Save method.

Properties available are:

- CenterWindow
- Direction
- DisplayDocTitle
- FitWindow
- HideMenuBar
- HideToolBar
- HideWindowUI
- NonFullScreenPageMode
- PageLayout
- PageMode

Each is used and described in the code below. The following code snippet shows you how to get/set the properties using the Document class.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Document-GetSetDocWindowProperties-GetSetDocWindowProperties.cpp" >}}
## **Embedding Fonts while creating PDF**
If you need to use any font other than the 14 core fonts supported by Adobe Reader, than you must embed the font description while generating PDF file. If font information is not embedded, Adobe Reader will take it from the Operating System if it’s installed over the system, or it will construct a substitute font according to the font descriptor in the PDF.

{{% alert color="primary" %}} 

Please note the embedded font must be installed on host machine i.e. in case of following code ‘Universe Condensed’ font is installed over the system.

{{% /alert %}} 

We use the method set_IsEmbedded of Font class to embed the font information into PDF file. Setting the value of this property to ‘True’ will embed the complete font file into the PDF, knowing the fact that it will increase the PDF file size. Following is the code snippet that can be used to embed the font information into PDF. To embed the full font, use the Font class' set_IsEmbedded() method, whereas in order to use a subset of the font, use the set_IsSubset() method.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Document-EmbedFont-EmbedFont.cpp" >}}

A font subset embeds only the characters that are used and is useful where fonts are used for short sentences or slogans, for example where a corporate font is used for a logo, but not for the body text. Using a subset reduces the file size of the output PDF.

However if a custom font is used for the body text, embed it in its entirety.
## **Set Zoom Factor of PDF File**
Sometimes, you want to set PDF document's zoom factor. With Aspose.PDF for C++, you can set the value of zoom factor by **set_OpenAction(...)** method of Document class.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Document-SetZoomFactor-SetZoomFactor.cpp" >}}
## **Set Particular Page to Display when Document is opened**
Sometimes, you want to display a particular page of a PDF file when it is opened in any PDF Viewer. Aspose.PDF for C++ allows you to specify page inside PDF document, which will be displayed when PDF is opened. Following code snippet shows you, how to create a document which displays full second page when opened.





{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Document-CreateDoc-CreateDoc.cpp" >}}
