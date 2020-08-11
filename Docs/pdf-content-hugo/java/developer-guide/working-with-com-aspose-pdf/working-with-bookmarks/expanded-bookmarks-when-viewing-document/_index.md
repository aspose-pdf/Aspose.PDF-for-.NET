---
title: Expanded Bookmarks when viewing document
type: docs
weight: 70
url: /java/expanded-bookmarks-when-viewing-document/
---

{{% alert color="primary" %}} 

Bookmarks are held in the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's [OutlineItemCollection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/OutlineCollection) collection, itself in the [OutlineItemCollection](https://apireference.aspose.com/java/pdf/com.aspose.pdf/OutlineCollection) collection. However we may have a requirement to have all the bookmarks expanded when viewing the PDF file.

{{% /alert %}} 

In order to accomplish this requirement, we can set open status for each outline/bookmark item as Open. The following code snippet shows you how to set open status for each bookmark as expanded in a PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-bookmarks-ExpandedBookmarksWhenViewingDocument-.java" >}}
