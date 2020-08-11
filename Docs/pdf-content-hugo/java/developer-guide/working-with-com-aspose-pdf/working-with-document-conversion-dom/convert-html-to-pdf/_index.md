---
title: Convert HTML to PDF
type: docs
weight: 20
url: /java/convert-html-to-pdf/
---

## **Convert HTML file to PDF format**
Aspose.PDF for Java provides the capability to convert HTML pages to PDF format. The [HtmlLoadOptions](https://apireference.aspose.com/java/pdf/com.aspose.pdf/HtmlLoadOptions) class supports the feature to load HTML contents and then save the output in PDF format.

To convert an HTML file to PDF:

1. Instantiate an [HtmlLoadOptions](https://apireference.aspose.com/java/pdf/com.aspose.pdf/HtmlLoadOptions) object and pass the base path/URL argument that serves as a form of the database when converting HTML to PDF.
1. Load the HTML file into the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class constructor along with the [HtmlLoadOptions](https://apireference.aspose.com/java/pdf/com.aspose.pdf/HtmlLoadOptions) argument.
1. Save the output PDF file using the save(..) method.

The basePath argument provides the basic image path; the <img> tag's src property provides the relative path. The final path of the image in the output is basePath concatenated with the <img> tag's src in the HTML source.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertHTMLToPDFFormat-ConvertHTMLFileToPDF.java" >}}
## **Setting to Not Pull Down Remote Resources During Conversion**
When converting an HTML file that contains links to external resources (such as style sheets, JavaScript, and images), the conversion engine tries to pull the resources from remote servers. There are times when it's more appropriate to either load any remote resources or specify a proxy server.

The ResourceLoadingStrategy object can perform different actions with remote resources at its discretion. The following code shows how to ignore resources at specific addresses.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertHTMLToPDFFormat-SettingToNotPullDownRemoteResourcesDuringConversion.java" >}}
## **Rendering Content to Single Page**
Aspose.PDF for Java provides the ability to render all contents on a single page while converting HTML files to PDF format. For example, if you have some HTML content in which output size is greater than one page, you can use the option for rendering output data into a single PDF page. For using this option, **HtmlLoadOptions** class was extended by **IsRenderToSinglePage** flag. The code snippet below shows how to use this functionality.

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-DocumentConversion-ConvertHTMLToPDFFormat-RenderContentToSamePage.java" >}}
## **Render HTML with SVG Data**
Aspose.PDF for Java provides the ability to convert HTML page to PDF document. Since HTML allows adding SVG graphic element as a tag in the page, Aspose.PDF also supports the conversion of such data into the resultant PDF file. The following code snippet shows how to convert HTML files with SVG graphic tags to Tagged PDF Documents.

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-DocumentConversion-ConvertHTMLToPDFFormat-RenderHTMLwithSVGData.java" >}}
