---
title: Convert PDF File into HTML Format
type: docs
weight: 50
url: /net/convert-pdf-file-into-html-format/
---

## **PDF to HTML - Save Images in Raster Format**
{{% alert color="primary" %}} 

You can check the quality of Aspose.PDF conversion and view the results online at this link:

[products.aspose.app/pdf/conversion/pdf-to-html](https://products.aspose.app/pdf/conversion/pdf-to-html) {{% /alert %}} 

The default output format for saving images when converting from PDF to HTML, is SVG. It is possible to over-ride the default and instead save images to a raster format. This article shows how.
Aspose.PDF for .NET provides great conversion options and can convert PDF files to DOC, DOCX, image, HTML and various other formats. During the PDF to HTML conversion process, images in the PDF are saved with SVG compression by default. You can save them in raster format (PNG or JPEG) to reduce the image size.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-SaveImages-SaveImages.cs" >}}
## **PDF to HTML - Split CSS to Pages**
When converting PDF files to HTML, a CSS file containing formatting information is created. Aspose.PDF for .NET also offers the feature to split the output HTML into pages and you can also split the CSS into multiple pages.

The HtmlSaveOptions class has a property named SplitIntoPages which supports the feature to split the output HTML file to pages when generating it. One of our customers wanted to split the CSS file based on individual pages instead of generating a single CSS file. To accomplish this, we introduced a new flag, SplitCssIntoPages to the HtmlSaveOptions class. When the value of this property is set to true, the converter splits the outout CSS into parts/pages based on individual HTML pages created. The following code snippet shows how to use the flag.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-SplitCSSToPages-SplitCSSToPages.cs" >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-SplitCSSToPages-SplitCSSToPagesHelpers.cs" >}}
### **CssSavingInfo.HtmlPageNumber has been Renamed CssSavingInfo.CssNumber**
Instances of HtmlSaveOptions.CssSavingInfo are usually used in custom implementations of HtmlSaveOptions.CssSavingStrategy when it's necessary to implement custom saving of CSS files generated during PDF to HTML conversion. It contains any parameters and content of the saved CSS.

Prior to version 9.0.0 CssSavingInfo.HtmlPageNumber was used in the public API. It was introduced when the number of saved CSS files and HTML pages was always equal. Now, the internal logic of the converter has been changed: it's possible to have a different number of HTML pages and saved CSS files. For internal reasons this parameter can contain only the number of CSS, not the number of parent HTML page. To reflect this, it was renamed CssSavingInfo.CssNumber.

In essence it's just an informational parameter that can be used to get the ordinal of the currently saved CSS-file.
### **Public API Changes**
CssSavingInfo.**HtmlPageNumber** has been renamed CssSavingInfo.**CssNumber**.
## **PDF to HTML - Save Fonts as WOFF or TTF**
Aspose.PDF for .NET offers the feature to convert HTML files to PDF format and transforming PDF files to HTML. During PDF to HTML conversion, the TrueType fonts used in the PDF can be [saved on the file system](/pdf/net/convert-pdf-file-into-html-format-html/). To ensure maximum browser compatibility, it's possible to embed [several font types](/pdf/net/convert-pdf-file-into-html-format-html/).
### **Generating TIFF or WOFF Fonts**
From Aspose.PDF for .NET 8.8.0, it is possible to either save fonts in TTF (TrueType Format) or WOFF (Web Open Font Format) formats. To accomplish this requirement, the HtmlSaveOptions.FontSavingModes enumerator and HtmlSaveOptions.FontSavingMode conversion option have been added. The following code snippet lets you save fonts as TTF when converting PDF files to HTML format.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-SaveFonts-SaveFonts.cs" >}}

To save fonts in WOFF format, use the following code:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-SaveFonts-WOFFFormat.cs" >}}
### **Generate 3 Sets of Fonts**
Prior to the release of Aspose.PDF for .NET 9.3.0, the API supported saving fonts either as WOFF or TTF. This meant that fonts could not be loaded in Internet Explorer 6 through 8, so documents didn't look right when viewed in these browsers. Also for mobile browsers, the TTF fonts were required for maximum compatibility. The solution was to generate 3 sets of fonts, to ensure maximum browser compatibility, and then reference all fonts in the CSS as shown below. The following format is similar to the one described [here](http://css-tricks.com/snippets/css/using-font-face/).

{{< highlight java >}}

 @font-face {

	font-family:"WBULFR+Arial-BoldMT";

	src:url("fa507958-0001-0000-0000-000000000000.eot");

	src:url("fa507958-0001-0000-0000-000000000000.eot?#iefix") format("embedded-opentype"),

	url("fa507958-0001-0000-0000-000000000000.woff") format("woff"),

	url("fa507958-0001-0000-0000-000000000000.ttf") format("truetype");

}

{{< /highlight >}}

To accomplish this requirement, the SaveInAllFormats font saving mode was introduced to the HtmlSaveOptions.FontSavingModes enumeration. The following code snippet demonstrates how to generate 3 sets of fonts.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-SaveFonts-ThreeSetFonts.cs" >}}
## **PDF to HTML - Specify Prefix for Image**
When converting PDFs to HTML, it is possible to specify a prefix for image files. Images are created with the name **img_01** (increased by one for each new image). The following code snippet demonstrates how to specify the prefix for image files.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-SpecifyPrefixForImages-SpecifyPrefixForImages.cs" >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-SpecifyPrefixForImages-SpecifyPrefixForImagesHelper.cs" >}}
## **PDF to HTML - Set Prefix for URLs of SVG Files**
During PDF to HTML conversion, the images inside the PDF file are saved to SVG. The images are created in a folder that contain the HTML page resources and are referenced from that same folder. Some of our customers have asked to add a prefix for URLs in the SVG files that Aspose.PDF generate when convertinig PDF to HTML.

Prior to [Aspose.PDF for .NET 8.9.0](http://www.aspose.com/community/files/51/.net-components/aspose.pdf-for-.net/entry525304.aspx), when converting the PDF file to HTML format, images were referenced in the following manner:

{{< highlight java >}}

 <image x="0" y="0" xlink:href="img_01.png" temp_href="img_01.png" width="1351" height="2135" />

{{< /highlight >}}

In later versions, the URL for image can be specified:

{{< highlight java >}}

 <image x="0" y="0" xlink:href="http://localhost:255/img_01.png" temp_href="http://localhost:255/img_01.png" width="1351" height="2135" />

{{< /highlight >}}

- The **ImageParentTypes** enumeration has been added to the [HtmlSaveOptions](https://apireference.aspose.com/net/pdf/aspose.pdf/htmlsaveoptions) class.
- The **ParentType** property was added into the HtmlSaveOptions.HtmlImageSavingInfo class

The above stated requirement can be achieved with custom image saving strategy, as specified below.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-PrefixForURLs-PrefixForURLs.cs" >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-PrefixForURLs-PrefixForURLsHelper.cs" >}}
## **PDF to HTML - Set URL Prefix for Fonts in style.css**
Aspose.PDF for .NET offers the feature to convert HTML files to PDF and transforming PDF files to HTML. During PDF to HTML conversion, the TrueType fonts used in the PDF are saved on the file system.

Prior to [Aspose.PDF for .NET 8.9.0](http://www.aspose.com/community/files/51/.net-components/aspose.pdf-for-.net/entry525304.aspx), developers were unable to set a URL prefix for fonts in the style.css file:

{{< highlight java >}}

 @font-face {

font-family:"CMBRVA+Ebrima,Bold";

src:url("d724b65b-0001-0000-0000-000000000000.ttf");

}

{{< /highlight >}}

Some wanted to set the prefix for fonts:

{{< highlight java >}}

 @font-face {

font-family:"CMBRVA+Ebrima,Bold";

src:url("http://localhost:255/document-viewer/GetFont/01.ttf");

}

{{< /highlight >}}

It is now possible to set a custom URL for fonts using custom resource saving strategies.

You can also set a prefix for font names and make the names shorter

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-PrefixForFonts-PrefixForFonts.cs" >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-PrefixForFonts-PrefixForFontsHelper.cs" >}}
## **PDF to HTML - Prefix CSS Class Names in style.css**
When converting PDF files to HTML format, Aspose.PDF creates a CSS file that contains formatting information. Aspose.PDF for .NET offers the feature to split the HTML into pages, so you can also split the CSS into multiple pages. This feature also provides the capability to prefix CSS class names in the style.css file.

We were asked to for a feature that would make it possible to prefix CSS class names in the style.css file.

{{% alert color="primary" %}} 

Instead of **.stl_06 {}** 
it should be **.gDV__ .stl_06 {**

{{% /alert %}} 

To accomplish this requirement, the HtmlSaveOptions.CssClassNamesPrefix field has been introduced.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-PrefixCSSClassNames-PrefixCSSClassNames.cs" >}}
## **PDF to HTML - Add a Prefix to Import Directives**
Aspose.PDF for .NET supports the feature to convert PDF files to HTML format. During the conversion process, formatting information is saved in the style.css file. The style.css file is referenced in the output HTML file.

We were asked to add a prefix to import directives like this @import 'style1p1.css'; in the style.css file. For example:

{{< highlight java >}}

 @import 'http://localhost:24661/document-viewer/GetResourceForHtmlHandler? documentPath=Deutschland201207Arbeit.pdf&resourcePath=style1p1.css&fileNameOnly=false';

{{< /highlight >}}

The code below shows how to perform this task.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-PrefixToImportDirectives-PrefixToImportDirectives.cs" >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-PrefixToImportDirectives-PrefixToImportDirectivesHelper.cs" >}}


After executing of the above code, open the style.css file and ensure that it starts with CSS-import directives and contains something like the below (the exact paths will differ if you can change them in the code snippet when running on your machine):

{{< highlight java >}}

 @import 'file://F:/ExternalTestsData/36435_1_files/style_page_1_part_1.css';

@import 'file://F:/ExternalTestsData/36435_1_files/style_page_1_part_2.css';

@import 'file://F:/ExternalTestsData/36435_1_files/style_page_1_part_3.css';

@import 'file://F:/ExternalTestsData/36435_1_files/style_page_1_part_4.css';

@import 'file://F:/ExternalTestsData/36435_1_files/style_page_1_part_5.css';

@import 'file://F:/ExternalTestsData/36435_1_files/style_page_1_part_6.css';

@import 'file://F:/ExternalTestsData/36435_1_files/style_page_1_part_7.css';

@import 'file://F:/ExternalTestsData/36435_1_files/style_page_1_part_8.css';

{{< /highlight >}}
## **PDF to HTML - Save Output to a Stream Object**
Aspose.PDF for .NET 9.0.0 introduced a feature for converting PDF files to HTML format and save the output in a Stream object.

Please notice that using a stream as a target leads to some natural limitations required by the instance of the HtmlSaveOptions class that must be supplied for such conversion:

- Because it's necessary to explicitly process external parts (like CSS, images, fonts) in custom code, an instance of HtmlSaveOptions with explicitly set custom strategies should be supplied:
  - HtmlSaveOptions.CustomResourceSavingStrategy
  - HtmlSaveOptions.CustomCssSavingStrategy
  - HtmlSaveOptions.CustomStrategyOfCssUrlCreation
- Setting HtmlSaveOptions.SplitCssIntoPages, and HtmlSaveOptions.SplitIntoPages does not make sense in this case and must be set to false (the default values).

If saving the output to stream is necessary, please use something similar to the following code. (The snippet is meant to be placed inside a simple console application.) Remember that saving linked external parts (fonts, CSS, and images) and supplying correct URLS and URL-templates to be used during output generation, are the responsibility of the custom code. Feel free to use this snippet as a basis for writing your own implementation.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-OutPutToStream-OutPutToStreamHelper.cs" >}}
### **Save output HTML to a single stream with embedded resources**
If it is required to embed all resources (CSS, Fonts, Images) into a single HTML stream, you may use following code sample. It tunes conversion in such way that all output forced to be embedded into result HTML without external files, and then result HTML is written into some stream with code of custom strategy of saving of HTML.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-OutPutToStream-OutPutToStream.cs" >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-OutPutToStream-SavingToStream.cs" >}}
## **PDF to HTML - Progress Detail of Conversion**
If the source PDF file is quite large, then during conversion process, you might want to measure/determine the progress of the conversion progress. This information can be useful when you need to show some status to the end user regarding conversion process.

Add progress events or be able to pass in a callback function which gets updated with progress details, when generating all resource types in order to allow progress updates be returned so that we can let a customer know how much processing of resources is performed / how many pages are processed.

{{% alert color="primary" %}} 

**Public API Changes** 
Aspose.PDF for .NET 9.1.0 introduced the property CustomProgressHandler in HtmlSaveOptions.
That release also added the following types used in that handler:
HtmlSaveOptions.ConversionProgessEventHandler
HtmlSaveOptions.ProgressEventHandlerInfo
HtmlSaveOptions.ProgressEventType

{{% /alert %}} 

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-ProgressDetails-ProgressDetails.cs" >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-ProgressDetails-ProgressDetailsHelper.cs" >}}
## **PDF to HTML - Avoid Saving Images in SVG Format**
The default output format for saving images when converting from PDF to HTML is SVG. During conversion, some images from PDF are transformed into SVG vector images. This could be slow. Instead, the images could be transformed into PNG. To allow this, Aspose.PDF has the option to use SVG for vectors or to create PNGs. In order to completely remove the rendering of images as SVG format when converting PDF files to HTML format, please try using the following code snippet.

**Public API Changes** 
Aspose.PDF for .NET 9.1.0 introduced a new member of the HtmlSaveOptions.RasterImagesSavingModes enumeration:
HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground
It allows you to completely avoid converting images to SVG in output HTML files.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-AvoidSavingImages-AvoidSavingImages.cs" >}}
## **PDF to HTML - Save HTML, CSS, Image, and Font Resources in Stream Object**
During PDF to HTML conversion, fonts, images and CSS files containing style information for the PDF contents are generated. These resources are necessary to maintain the formatting of the output HTML file. However, there might be a scenario where you want to load a PDF file Stream object and do not need to store or save the resource files on the system or local drive. The can be the case if you do not have permissions for saving intermediate resource files or do not want to save the resources on the system and simply need to perform the conversion on the fly (and the file needs to be viewed once and is not required for later processing).

The following code snippet can be used to save all parts of result HTML-set of files into streams without saving them to disk. The point is: supply a non-existing path to the output HTML file and implement custom processing of all resources (HTML markup, CSS, images and fonts). This code is supposed to be put in simple console application.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-SaveHTMLImageCSS-SaveHTMLImageCSS.cs" >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-SaveHTMLImageCSS-SaveHTMLImageCSSHelper.cs" >}}
## **PDF to HTML - Single HTML with All Resources Embedded**
PDF to HTML conversion is one of the most powerful features of Aspose.PDF for Java as it allows the production of high fidelity HTML documents. During conversion, all the resources (fonts, images and CSS) from PDF file are saved in a separate folder in same directory that the output HTML is created. However, we were asked to provide a feature for converting a PDF file to HTML format and generate a single HTML file with all resources embedded. The implementation of this feature is in accordance with [data URI scheme](http://en.wikipedia.org/wiki/Data_URI_scheme). To accomplish it, the value EmbedAllIntoHtml was added to the HtmlSaveOptions.PartsEmbeddingModes enumeration. The following code snippet shows how to use it.

{{% alert color="primary" %}} 

To only embed CSS in the output HTML, and not all resources, use the EmbedCssOnly value of the HtmlSaveOptions.PartsEmbeddingModes enumeration.

{{% /alert %}} 

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-SingleHTML-SingleHTML.cs" >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-SetOutputFileDimensions-SetOutputFileDimensions.cs" >}}
## **PDF to HTML - Set Output File Dimensions**
When converting a PDF file to HTML format, the output file is saved with the same dimensions as the input PDF document. However, sometimes, you need to generate output HTML with specific dimensions. Use the Aspose.PDF.Facades.PdfPageEditor and HtmlSaveOptions classes to fulfill this requirement.

The PdfPageEditor class in the Aspose.PDF.Facades namespace provides the feature to update or manipulate pages in a PDF document. It also offers the feature to set or update page dimensions of an input PDF file. To set specific dimensions when converting to HTML:

1. Load the source PDF document into the PdfPageEditor object.
1. Update the page dimensions.
1. Render the output to HTML format using the HtmlSaveOptions class.

The following code snippet shows the steps to convert PDF file HTML format and specify dimensions for the output file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTMLFormat-SetOutputFileDimensions-SetOutputFileDimensions.cs" >}}
## **PDF to HTML - Exclude Font Resources**
Aspose.PDF for .NET offers the feature to convert HTML files to PDF format and transforming PDF files to HTML. When converting PDFs to HTML, it is possible to specify options that will allow preventing exporting fonts resources. For these feature **HtmlSaveOptions** class was extended with two properties:

- **HtmlSaveOptions.FontSavingModes.DontSave** - is to prevent exporting all the fonts
- **ExcludeFontNameList** - is for prevent exporting specific fonts(please specify font names without hash)

The current property provided as a list of strings. The code snippet below shows how to use this functionality.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTML-ExcludeFontResources.cs" >}}
## **PDF to HTML  with Full Content Width**
During conversion of PDF to HTML, there may arise a need of setting content width to 100% in output HTML whereas HTML content is left-aligned. The FlowLayoutParagraphFullWidth property of HtmlSaveOptions class lets you achieve this as shown in the following code sample.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTML-CreatingHtmlWithFullContentWidth.cs" >}}
## **Center Align Output HTML Contents**
In case you want to center align the contents of output HTML, you can use the *PageMarginIfAny* to set margin of each side of HTML page as shown in the following code sample.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToHTML-CenterAlignText.cs" >}}
