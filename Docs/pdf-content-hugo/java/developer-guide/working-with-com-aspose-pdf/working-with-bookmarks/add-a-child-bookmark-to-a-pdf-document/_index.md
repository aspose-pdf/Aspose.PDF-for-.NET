---
title: Add a Child Bookmark to a PDF Document
type: docs
weight: 20
url: /java/add-a-child-bookmark-to-a-pdf-document/
---

{{% alert color="primary" %}} 

Bookmarks can be nested, indicating a hierarchical relationship with parent and child bookmarks. This article explains how to add a child bookmark, that is, a second-level bookmark, to a PDF.

{{% /alert %}} 

To add a child bookmark to a PDF, first add a parent bookmark:

1. Open a document.
1. Add a bookmark to the [OutlineItemCollection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/OutlineItemCollection), defining its properties.
1. Add the [OutlineItemCollection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/OutlineItemCollection) to the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's [Outlines](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Outlines) collection.

The child bookmark is created just like the parent bookmark, as explained above, but is added to the parent bookmark's [Outlines](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Outlines) collection.

The following code snippet shows how to add a child bookmark.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-bookmarks-AddChildBookmarkToPDFDocument-.java" >}}
