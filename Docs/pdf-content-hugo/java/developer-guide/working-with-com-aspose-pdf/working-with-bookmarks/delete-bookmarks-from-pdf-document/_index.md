---
title: Delete Bookmarks from PDF Document
type: docs
weight: 30
url: /java/delete-bookmarks-from-pdf-document/
---

{{% alert color="primary" %}} 

All bookmarks in a PDF are held in the [OutlineCollection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/OutlineCollection) collection. This article explains how to delete all, or a specific, bookmark from a PDF.

{{% /alert %}} 
### **Delete All Bookmarks**
To delete all bookmarks from a PDF file:

1. Call the [OutlineCollection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/OutlineCollection) collection's [delete(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/OutlineCollection#delete--) method without an argument.
1. Save the modified file using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's save method.

The following code snippet shows how to delete all bookmarks from a PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-bookmarks-DeleteBookmarksFromPDFDocument-DeleteBookmarksFromPDFDocument.java" >}}


### **Delete a Particular Bookmark**
The following code snippet shows how to delete a particular bookmark from PDF document. Simply pass the bookmark's name as an argument to the [delete(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/OutlineCollection#delete--) method to remove only that bookmark.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-bookmarks-DeleteBookmarksFromPDFDocument-DeleteParticularBookmark.java" >}}
