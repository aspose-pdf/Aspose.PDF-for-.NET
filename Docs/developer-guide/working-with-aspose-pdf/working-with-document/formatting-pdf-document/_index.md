---
title: Formatting PDF Document
type: docs
weight: 20
url: /net/formatting-pdf-document/
---

## **Get Document Window and Page Display Properties**
This topic helps you understand how to get properties of the document window, viewer application, and how pages are displayed. To set these properties:

Open the PDF file using the Document class. Now, you can set the Document object's properties, such as

- CenterWindow – Center the document window on the screen. Default: false.
- Direction – Reading order. This determines how pages are laid out when displayed side by side. Default: left to right.
- DisplayDocTitle – Display the document title in the document window title bar. Default: false (the title is displayed).
- HideMenuBar -– Hide or display the document window's menu bar. Default: false (menu bar is displayed).
- HideToolBar -– Hide or display the document window's toolbar. Default: false (toolbar is displayed).
- HideWindowUI -– Hide or display document window elements like scroll bars. Default: false (UI elements are displayed).
- NonFullScreenPageMode -– How the document when it's not displayed in full-page mode.
- PageLayout -– The page layout.
- PageMode -– How the document is displayed when first opened. The options are show thumbnails, full-screen, show attachment panel.

The following code snippet shows you how to get the properties using Document class.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-GetDocumentWindow-GetDocumentWindow.cs" >}}
## **Set Document Window and Page Display Properties**
This topic explains how to set the properties of the document window, viewer application, and page display. To set these different properties:

1. Open the PDF file using the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class.
1. Set the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's properties.
1. Save the updated PDF file using the [Save](https://apireference.aspose.com/net/pdf/aspose.pdf/document/methods/save) method.

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

Each is used and described in the code below. The following code snippet shows you how to set the properties using the Document class.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-SetDocumentWindow-SetDocumentWindow.cs" >}}
## **Embedding Fonts in an existing PDF file**
PDF readers support [a core of 14 fonts](http://en.wikipedia.org/wiki/Portable_Document_Format#Text) so that documents can be displayed the same way regardless of the platform the document is displayed on. When a PDF contains a font that is not one of the 14 core fonts, embed the font to the PDF file to avoid font substitution.

Aspose.PDF for .NET supports font embedding in existing PDF files. You can embed a complete font or a subset of the font. To embed the font, open the PDF file using the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class. Then use the [Aspose.Pdf.Text.Font](https://apireference.aspose.com/net/pdf/aspose.pdf.text/) class to embed the font into the PDF file. To embed the full font, use the Font class' IsEmbeded property; to use a subset of the font, use the IsSubset property.

{{% alert color="primary" %}} 

A font subset embeds only the characters that are used and is useful where fonts are used for short sentences or slogans, for example where a corporate font is used for a logo, but not for the body text. Using a subset reduces the file size of the output PDF. However, if a custom font is used for the body text, embed it in its entirety.

{{% /alert %}} 

The following code snippet shows how to embed a font in a PDF file.
### **Embedding Standard Type 1 Fonts**
Some PDF documents have fonts from a special Adobe font set. Fonts from this set are called "Standard Type 1 Fonts". This set includes 14 fonts and embedding this type of fonts requires using of special flags i.e [Aspose.Pdf.Document.EmbedStandardFonts](https://apireference.aspose.com/net/pdf/aspose.pdf/document/properties/embedstandardfonts). Following is the code snippet which can be used to get a document with all fonts embedded including Standard Type 1 Fonts:



{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-EmbedStandardType1Fonts-1.cs" >}}
## **Embedding Fonts while creating PDF**
If you need to use any font other than the 14 core fonts supported by Adobe Reader, you must embed the font description while generating the Pdf file. If font information is not embedded, Adobe Reader will take it from the Operating System if it’s installed over the system, or it will construct a substitute font according to the font descriptor in the Pdf.

{{% alert color="primary" %}} 

Please note the embedded font must be installed on the host machine i.e. in case of the following code ‘Univers Condensed’ font is installed over the system.

{{% /alert %}} 

We use the property IsEmbedded of Font class to embed the font information into Pdf file. Setting the value of this property to ‘True’ will embed the complete font file into the Pdf, knowing the fact that it will increase the Pdf file size. Following is the code snippet that can be used to embed the font information into Pdf.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-EmbedFontWhileDocCreation-EmbedFontWhileDocCreation.cs" >}}
## **Set Default Font Name while Saving PDF**
When a PDF document contains fonts, which are not available in the document itself and on the device, API replaces these fonts with the default font. When font is available (is installed on the device or is embedded into the document), output PDF should have the same font (should not be replaced with default font). The value of the default font should contain the name of the font (not the path to the font files). We have implemented a feature to set default font name while saving a document as PDF. Following code snippet can be used to set default font:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-SetDefaultFont-1.cs" >}}
## **Get All Fonts from PDF Document**
In case you want to get all fonts from a PDF document, you can use **FontUtilities.GetAllFonts()** method provided in **Document** class. Please check following code snippet in order to get all fonts from an existing PDF document:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-GetAllFonts-1.cs" >}}
## **Get Warnings for Font Substitution**
Aspose.PDF for .NET provides methods to get notifications about font substitution for handling font substitution cases. The code snippets below show how to use corresponding functionality.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-GetWarningsForFontSubstitution-GetWarningsForFontSubstitution.cs" >}}

` `The **OnFontSubstitution** method is as listed below.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-GetWarningsForFontSubstitution-OnFontSubstitution.cs" >}}
## **Improve Fonts Embedding using FontSubsetStrategy**
The feature to embed the fonts as a subset can be accomplished by using the IsSubset property, but sometimes you want to reduce a fully embedded font set to only subsets that are used in the document. Aspose.Pdf.Document has property FontUtilities which includes method SubsetFonts(FontSubsetStrategy subsetStrategy). In the method SubsetFonts(), the parameter subsetStrategy helps to tune the subset strategy. FontSubsetStrategy supports two following variants of font subsetting.

- SubsetAllFonts - This will subset all fonts, used in a document.
- SubsetEmbeddedFontsOnly - This will subset only those fonts which are fully embedded into the document.

Following code snippet shows how to set FontSubsetStrategy:



{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-EmbedFontsUsingSubsetStrategy-EmbedFontsUsingSubsetStrategy.cs" >}}


## **Get-Set Zoom Factor of PDF File**
Sometimes, you want to determine what a PDF document's current zoom factor is. With Aspose.Pdf, you can find out the current value as well as set one.

The [GoToAction](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/gotoaction) class' Destination property allows you to get the zoom value associated with a PDF file. Similarly, it can be used to set a file's zoom factor.
### **Set Zoom factor**
The following code snippet shows how to set the zoom factor of a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-SetZoomFactor-SetZoomFactor.cs" >}}
### **Get Zoom Factor**
The following code snippet shows how to get a PDF file's zoom factor.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-GetZoomFactor-GetZoomFactor.cs" >}}

{{% alert color="primary" %}} 

Please note that before you try to get the zoom value of PDF file, ensure that zoom factor is assigned to PDF file, else you will get an exception.

{{% /alert %}} 
## **Trim Whitespace Around a Page**
A PDF file is comprised of text, images, graphics and various other objects. To remove or trim the white space around a PDF page, set the CropBox for that particular page. To determine the correct value of the CropBox coordinates, first you need to identify the position of objects on the page.

The graphics primitives boundary detection is not a reliable approach. It is highly probable that some objects can't be found in facades and provide the API to get their rectangle. A better, reliable approach is to render the PDF page to an image and then determine the margins. The following code snippets show how to:

1. Render a PDF page to PNG,
1. determine the objects' location, and
1. use those same values to set a CropBox for PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-TrimWhiteSpace-TrimWhiteSpace.cs" >}}
## **Setting Print Dialog Preset Properties**
Aspoose.PDF allows setting the Print Dialog Preset properties of a PDF document. It allows you to change the DuplexMode property for a PDF document which is set to simplex by default. This can be achieved using two different methodologies as shown below.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-SetPropertiesForPrintDialog-SetPresetPropertiesForPrintDialog.cs" >}}
### **Setting Print Dialog Preset Properties using PDF Content Editor**
{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-SetPropertiesForPrintDialog-SetPrintDlgPropertiesUsingPdfContentEditor.cs" >}}
