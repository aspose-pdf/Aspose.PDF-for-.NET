---
title: Convert PDF to HTML format
type: docs
weight: 60
url: /java/convert-pdf-to-html-format/
---

## **PDF to HTML - Specify Images Folder**
Aspose.PDF for Java provides many features for converting various file formats to PDF documents and converting PDF files into various output formats. This article discusses how to convert a PDF file into HTML format and save the images from the PDF file in a particular folder.

PDF to HTML conversion is one of Aspose.PDF's most popular features because it makes it possible to view the content of PDF files on various platforms without using a PDF document viewer. The output HTML accords with to WWW standards and can easily be displayed in all web browsers. Using this feature, the PDF files can be viewed over hand held devices because you do not need to install any PDF viewing application but can use a simple web browser.

By default, when converting a PDF file to HTML, the images in the PDF are saved in a separate folder created in same directory that the output HTML is created. But sometimes, it is necessary to specify a different folder for saving images to when generating HTML files. To accomplish this, we introduced the [saveOptions](https://apireference.aspose.com/java/pdf/com.aspose.pdf/SaveOptions).SpecialFolderForAllImages property. It is used to specify the target folder for storing images.

The following code snippet shows how to specify a folder to store images in during PDF to HTML conversion.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-PDFToHTMLSpecifyImagesFolder-.java" >}}
## **PDF to HTML - Avoid Saving Images in SVG Format**
The default output format for saving images when converting from PDF to HTML is SVG. During conversion, some images from PDF are transformed into SVG vector images. This could be slow. Instead, the images could be transformed into PNG. To allow this, Aspose.PDF has the option to use SVG for vectors or to create PNGs.

In order to completely remove the rendering of images as SVG format when converting PDF files to HTML format, please try using the following code snippet.

**Public API Changes** 
Aspose.PDF for Java has a new member of the [HtmlSaveOptions](https://apireference.aspose.com/java/pdf/com.aspose.pdf/HtmlSaveOptions).RasterImagesSavingModes enumeration:
[HtmlSaveOptions](https://apireference.aspose.com/java/pdf/com.aspose.pdf/HtmlSaveOptions).RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground
It allows you to completely avoid converting images to SVG in output HTML files.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-PDFToHTMLAvoidSavingImagesInSVGFormat-.java" >}}
## **PDF to HTML - Single HTML with All Resources Embedded**
PDF to HTML conversion is one of the most powerful features of Aspose.PDF for Java as it allows the production of high fidelity HTML documents. During conversion, all the resources (fonts, images and CSS) from the PDF file are saved in a separate folder in the same directory as the output HTML. However, we were asked to provide a feature for converting a PDF file to HTML format and generate a single HTML file with all resources embedded.

The implementation of this feature is in accordance with the [data URI scheme](http://en.wikipedia.org/wiki/Data_URI_scheme). The [HtmlSaveOptions](https://apireference.aspose.com/java/pdf/com.aspose.pdf/HtmlSaveOptions).PartsEmbeddingModes enumeration's EmbedAllIntoHtml value makes it possible. The following code snippet shows how to use it.

To only embed CSS in the output HTML, and not all resources, use the [HtmlSaveOptions](https://apireference.aspose.com/java/pdf/com.aspose.pdf/HtmlSaveOptions).PartsEmbeddingModes enumeration's EmbedCssOnly value.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-PDFToHTMLSingleHTMLWithAllResourcesEmbedded-.java" >}}
## **PDF to HTML - Exclude Font Resources**
If you intend to exclude all or some font resources during the conversion of PDF to HTML, Aspose.PDF for Java API lets you achieve this with the help of HtmlSaveOptions class. The API offers two options for this purpose.

1. htmlOptions.FontSavingMode = HTmlSaveOptions.FontSavingModes.DontSave - to prevent exporting all the fonts
1. htmlOptions.ExcludeFontNameList = (new String[] { "ArialMT", "SymbolMT" }); - is for prevent exporting specific fonts (font names to be specified without hash)

In order to convert PDF to HTML excluding font resources, use the following steps:

1. Define a new object of HtmlSaveOptions class
1. Define and set the font names to be prevented from exporting in HtmlSaveOptions.ExcludeFontNameList
1. Conver the PDF to HTML using the save method

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-DocumentConversion-PDFtoHTMLExcludeFontResources-PDFtoHTMLExcludeFontResourcesWithAdditionalOptions.java" >}}
## **PDF to HTML - All resource embedded in a single resultant stream**
During PDF to HTML conversion, fonts, images and CSS files containing style information for the PDF contents are generated. These resources are necessary to maintain the formatting of the output HTML file. However, there might be a scenario where you want to load a PDF file Stream object and do not need to store or save the resource files on the system or local drive. This can be the case if you do not have permissions for saving intermediate resource files or do not want to save the resources on the system and simply need to perform the conversion on the fly (and the file needs to be viewed once and is not required for later processing).

The following code snippet can be used to save all parts of result HTML-set of files into streams instance. The point is: supply a non-existing path to the output HTML file and implement custom processing of all resources (HTML markup, CSS, images and fonts). This code is supposed to be put in simple console application.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-PDFToHTMLAllResourceEmbeddedInSingleResultantStream-.java" >}}
## **PDF to HTML - Splitting Output to Multi-page HTML**
Aspose.PDF for Java supports the feature to convert PDF documents to various output formats including HTML. However when converting large PDF files (comprised of multiple pages), you may have a requirement to save individual PDF page to separate HTML file.

When converting large PDF file with several pages to HTML format, the output appears as a single HTML page. It can end up being very long. To control page size, it is possible to split the output into several pages during PDF to HTML conversion. Please try using the following code snippet.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-PDFToHTMLSplittingOutputToMultipageHTML-.java" >}}
## **PDF to HTML - Render PDF data layers as a separate HTML Layer Element**
A PDF document can contain different data layers and we received requirements to render each layer separately in HTML Layer element during PDF to HTML conversion. We can use ConvertMarkedContentToLayers property to control the layers rendering in PDF to HTML conversion as following:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-DocumentConversion-PDFToHTMLRenderPDFDataLayersAsSeparateHTMLLayerElement-.java" >}}
