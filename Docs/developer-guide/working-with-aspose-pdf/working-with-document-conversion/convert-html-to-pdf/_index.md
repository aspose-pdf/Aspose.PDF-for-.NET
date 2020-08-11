---
title: Convert HTML to PDF
type: docs
weight: 20
url: /net/convert-html-to-pdf/
---

Aspose.PDF for .NET lets you convert HTML pages to PDF format with the ability of "Resource Loading Callback" during conversion. This ability can be useful when loading external resources inside cloud services without access to local file system.
## **HTML to PDF Conversion in C#**
To accomplish this feature, the CustomLoaderOfExternalResources property was added to the HtmlSaveOptions object. The following code snippet replaces pictures referenced in the HTML with a predefined picture.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-HTMLToPDF-HTMLToPDF.cs" >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-HTMLToPDF-HTMLToPDFHelper.cs" >}}
## **Provide credentials during HTML to PDF conversion**
Sometimes we need to perform the conversion of HTML files which require authentication and access privileges, so that only authentic users can fetch the page contents. It also includes the scenario where some resources/data referenced inside HTML are fetched from some external server which requires authentication and in order to cater to this requirement, the **ExternalResourcesCredentials** property is added to **HtmlLoadOptions** class. Following code snippet shows the steps to pass credentials to request HTML & its respective resources while converting HTML file to PDF conversion.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-ProvideCredentialsDuringHTMLToPDF-ProvideCredentialsDuringHTMLToPDF.cs" >}}
## **Convert Web Page to PDF**
The **HtmlLoadOptions** option offers the feature to load HTML contents and parse the HTML tags accordingly so that they are rendered respectively inside the resultant PDF. In order to convert Web page contents to PDF format, we can first fetch the HTML page contents using **WebRequest** instance, create **StreamReader** object and read page contents. Finally, pass the contents to the Document object and render the output in PDF format.

When converting a web page hosted on a webserver to PDF:

1. Read the contents of the page using an HttpWebRequest object.
1. Pass the content to a StreamReader object.
1. Create an instance of MemoryStream.
1. Instantiate the HtmlLoadOptions object while passing the web page URL.
1. Initialize a Document object while passing the stream object.
1. Optionally, set the page orientation to Landscape so that more content can be accommodated on the page.

{{% alert color="primary" %}} 

The following feature is under development and might produce undesirable results for complex scenarios. If you face any problem, please report the issue in [Aspose.PDF product free support forum](https://forum.aspose.com/c/pdf)[.](http://www.aspose.com/community/forums/aspose.pdf-product-family/20/showforum.aspx)

{{% /alert %}} 

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-WebPageToPDF-WebPageToPDF.cs" >}}
## **Render all Content in Single Page**
Aspose.PDF for .NET provides the ability to render all contents on a single page while converting HTML file to PDF format. For example, if you have some HTML content which output size is greater than one page, you can use option for rendering output data into a single PDF page. For using this option **HtmlLoadOptions** class was extended by **IsRenderToSinglePage** flag. The code snippet below shows how to use this functionality.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-DocumentConversion-HTMLToPDF-RenderContentToSamePage.cs" >}}
## **Render HTML with SVG Data**
Aspose.PDF for .NET provides ability to convert HTML page to PDF document. Since HTML allows adding SVG graphic element as a tag in the page, Aspose.PDF also supports conversion of such data into the resultant PDF file. The following code snippet shows how to convert HTML files with SVG graphic tags to Tagged PDF Documents.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-DocumentConversion-HTMLToPDF-RenderHTMLwithSVGData.cs" >}}
