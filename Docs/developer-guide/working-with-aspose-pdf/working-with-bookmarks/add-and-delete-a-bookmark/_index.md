---
title: Add and Delete a Bookmark
type: docs
weight: 10
url: /net/add-and-delete-a-bookmark/
---

## **Add a Bookmark to a PDF Document**
Bookmarks are held in the Document object's [OutlineItemCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlineitemcollection) collection, itself in the [OutlineCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlinecollection) collection.

To add a bookmark to a PDF:

1. Open a PDF document using [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object.
1. Create a bookmark and define its properties.
1. Add the OutlineItemCollection collection to the Outlines collection.

The following code snippet shows you how to add a bookmark in a PDF document.
#### **C#**
{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Bookmarks-AddBookmark-AddBookmark.cs" >}}
## **Add a Child Bookmark to the PDF Document**
Bookmarks can be nested, indicating a hierarchical relationship with parent and child bookmarks. This article explains how to add a child bookmark, that is, a second-level bookmark, to a PDF.

To add a child bookmark to a PDF file, first add a parent bookmark:

1. Open a document.
1. Add a bookmark to the [OutlineItemCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlineitemcollection), defining its properties.
1. Add the OutlineItemCollection to the Document object's [OutlineCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlinecollection) collection.

The child bookmark is created just like the parent bookmark, explained above, but is added to the parent bookmark's Outlines collection

The following code snippets show how to add child bookmark to a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Bookmarks-AddChildBookmark-AddChildBookmark.cs" >}}
## **Delete all Bookmarks from a PDF Document**
All bookmarks in a PDF are held in the [OutlineCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlinecollection) collection. This article explains how to delete all bookmarks from a PDF file.

To delete all bookmarks from a PDF file:

1. Call the [OutlineCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlinecollection) collection's Delete method.
1. Save the modified file using the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's [Save](https://apireference.aspose.com/net/pdf/aspose.pdf.document/save/methods/4) method.

The following code snippets show how to delete all bookmarks from a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Bookmarks-DeleteAllBookmarks-DeleteAllBookmarks.cs" >}}
## **Delete a Particular Bookmark from a PDF Document**
[Delete All Attachments from PDF document]() showed how to delete all attachments from a PDF file. It is also possible to only remove specific attachments.

To delete a particular bookmark from a PDF file:

1. Pass the bookmark's title as parameter to the [OutlineCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlinecollection) collection's Delete method.
1. Then save the updated file with the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object [Save](https://apireference.aspose.com/net/pdf/aspose.pdf.document/save/methods/4) method.

The [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class' provides the [OutlineCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlinecollection) collection. The Delete} method removes any bookmark with the title passed to the method.

The following code snippets show how to delete a particular bookmark from the PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Bookmarks-DeleteParticularBookmark-DeleteParticularBookmark.cs" >}}
