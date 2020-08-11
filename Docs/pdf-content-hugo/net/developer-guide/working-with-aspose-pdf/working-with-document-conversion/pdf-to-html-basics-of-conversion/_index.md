---
title: PDF to HTML - Basics of Conversion
type: docs
weight: 100
url: /net/pdf-to-html-basics-of-conversion/
---

## **PDF to HTML - Basics of Conversion**
Aspose.PDF for .NET provides many features for converting various file formats into PDF documents and converting PDF files into various output formats. This article discusses how to convert a PDF file into HTML. Aspose.PDF for .NET provides the capability to [convert HTML files into PDF format using the InLineHtml approach](). We have had many requests for functionality that converts a PDF file into HTML format and have provided this feature. Please note that this feature also supports XHTML 1.0.
### **Convert PDF to HTML**
{{% alert color="primary" %}} 

You can check the quality of Aspose.PDF conversion and view the results online at this link:

[products.aspose.app/pdf/conversion/pdf-to-html](https://products.aspose.app/pdf/conversion/pdf-to-html) {{% /alert %}} 

Aspose.PDF for .NET provides a two-line code for transforming a source PDF file to HTML. The [SaveFormat](https://apireference.aspose.com/net/pdf/aspose.pdf/saveformat) enumeration contains the value **.Html** which lets you save the source file to HTML. The following code snippet shows the process of converting a PDF file into HTML.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTML-PDFToHTML.cs" >}}
### **Splitting Output to Multi-page HTML**
When converting large PDF file with several pages to HTML format, the output appears as a single HTML page. It can end up being very long. To control page size, it is possible to split the output into several pages during PDF to HTML conversion. Please try using the following code snippet.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTML-MultiPageHTML.cs" >}}
### **Specify Folder for Storing SVG Files**
During PDF to HTML conversion, it is possible to specify the folder that SVG images should be saved to. Use the HtmlSaveOption class' SpecialFolderForSvgImages property to specify a special SVG image directory. This property gets or sets the path to the directory to which SVG images must be saved to when encountered during conversion. If the parameter is empty or null, then any SVG files are saved together with other image files.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTML-SaveSVGFiles.cs" >}}
### **Compressing SVG Images During Conversion**
To compress SVG images during PDF to HTML conversion, please try using the following code:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTML-CompressSVGImages.cs" >}}
### **Specifying the Images Folder**
We can also specify the folder that images will be saved to during PDF to HTML conversion:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTML-SpecifyingImageFolder.cs" >}}
### **Create Subsequent Files with Body Contents Only**
Recently, we were asked to introduce a feature where PDF files are converted to HTML and the user can get only the contents of the <body> tag for each page. This would produce one file with CSS, <html>, <head> details and all pages in other files just with <body> contents.

To meet this requirement, a new property, HtmlMarkupGenerationMode, was introduced to the HtmlSaveOptions class.

With the following simple code snippet, you can split the output HTML into pages. In the output pages, all HTML objects must go exactly where they go now (fonts processing and output, CSS creation and output, images creation and output), except that the output HTML will contain contents currently placed inside the <body></body> tags (now "body" tags will be omitted). However, when using this approach, the link to the CSS is the responsibility of your code, because things like <link rel="stylesheet" type="text/css" href="35951_7_Csses\css_style.css" /> will be stripped out. For this purpose, you may read the CSS via File.ReadAllText() and send it via AJAX to to a web page where it will be applied by jQuery.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTML-CreateSubsequentFiles.cs" >}}
### **Transparent Text rendering**
In case the source/input PDF file contains transparent texts shadowed by foreground images, then there might be text rendering issues. So in order to cater such scenarios, SaveShadowedTextsAsTransparentTexts and SaveTransparentTexts properties can be used.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTML-TransparentTextRendering.cs" >}}
### **PDF document layers rendering**
We can render PDF document layers in separate layer type element during PDF to HTML conversion:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTML-LayersRendering.cs" >}}
