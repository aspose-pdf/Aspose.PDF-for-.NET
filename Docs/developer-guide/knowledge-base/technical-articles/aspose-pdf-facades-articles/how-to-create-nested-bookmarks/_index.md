---
title: How to create Nested Bookmarks
type: docs
weight: 160
url: /net/how-to-create-nested-bookmarks/
---

{{% alert color="primary" %}} 

Bookmarks give you the option to keep track/link to specific page inside the PDF document. [PdfContentEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/PdfContentEditor) class in [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) provides a feature which allows you to create your own bookmark in a sophisticated yet intuitive way within an existing PDF file, at a given page or all pages.

{{% /alert %}} 
## **Implementation details**
Other than the creation of simple bookmarks, sometimes you have a requirement to create a bookmark in the form of chapters where you nest the individual bookmarks inside of the chapter bookmarks so that when you click on the + sign for a chapter you would see the pages inside when the bookmarks expands, as shown in the picture below . 

![todo:image_alt_text](how-to-create-nested-bookmarks_1.png)



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-CreateNestedBookmarks-CreateNestedBookmarks.cs" >}}
