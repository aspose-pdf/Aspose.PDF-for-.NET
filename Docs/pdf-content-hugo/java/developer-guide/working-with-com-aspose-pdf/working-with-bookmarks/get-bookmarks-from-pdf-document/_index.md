---
title: Get Bookmarks from PDF Document
type: docs
weight: 40
url: /java/get-bookmarks-from-pdf-document/
---

{{% alert color="primary" %}} 

The [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's [OutlineItemCollection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/OutlineItemCollection) collection contains all a PDF's bookmarks.

{{% /alert %}} 
### **Getting Bookmarks**
To get the bookmarks, loop through the Outlines collection and get each bookmark in [OutlineItemCollection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/OutlineCollection). The [OutlineItemCollection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/OutlineCollection) provides access to the bookmarks' attributes. The following code snippet shows you how to get bookmarks from the PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-bookmarks-GetBookmarksFromPDFDocument-GettingBookmarks.java" >}}


#### **Getting a Bookmark's Page Number**
Once you have [added a bookmark](/pdf/java/add-a-bookmark-to-a-pdf-document-html/) you can find out what page it is on by getting the destination PageNumber associated with the Bookmark object. The following code snippet is based on com.aspose.pdf.facades package.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Bookmarks-GetBookmarksFromPDFDocument-GettingBookmarksPageNumber.java" >}}
