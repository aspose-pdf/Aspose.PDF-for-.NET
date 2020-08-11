---
title: Get, Update and Expand a Bookmark
type: docs
weight: 20
url: /net/get-update-and-expand-a-bookmark/
---

## **Get Bookmarks from a PDF Document**
The [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's [OutlineCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlinecollection) collection contains all a PDF file's bookmarks. This article explains how to get bookmarks from a PDF file, and how to get which page a particular bookmark is on.

To get the bookmarks, loop through the [OutlineCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlinecollection) collection and get each bookmark in the [OutlineItemCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlineitemcollection). The [OutlineItemCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlineitemcollection) provides access to all the bookmark's attributes. The following code snippet shows you how to get bookmarks from the PDF file.



{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Bookmarks-GetBookmarks-GetBookmarks.cs" >}}
### **Getting a Bookmark's Page Number**
Once you have [added a bookmark](/pdf/net/add-and-delete-a-bookmark-html/) you can find out what page it is on by getting the destination PageNumber associated with the Bookmark object.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Bookmarks-GetBookmarkPageNumber-GetBookmarkPageNumber.cs" >}}
## **Get Child Bookmarks from a PDF Document**
Bookmarks can be organized in a hierarchical structure, with parents and children. To get all bookmarks, loop through the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's [Outlines](https://apireference.aspose.com/net/pdf/aspose.pdf/outlines) collections. However, to get child bookmarks as well, also loop through all the bookmarks in each [OutlineItemCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlineitemcollection) object obtained in the first loop. The following code snippets show how to get child bookmarks from a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Bookmarks-GetChildBookmarks-GetChildBookmarks.cs" >}}
## **Update Bookmarks in a PDF Document**
To update a bookmark in a PDF file, first, get the particular bookmark from the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's [OutlineColletion](https://apireference.aspose.com/net/pdf/aspose.pdf/outlinecollection) collection by specifying the bookmark's index. Once you have retrieved the bookmark into OutlineItemCollection object, you can update its properties and then save the updated PDF file using the [Save](https://apireference.aspose.com/net/pdf/aspose.pdf.document/save/methods/4) method. The following code snippets show how to update bookmarks in a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Bookmarks-UpdateBookmarks-UpdateBookmarks.cs" >}}
## **Update Child Bookmarks in a PDF Document**
To update a child bookmark:

1. Retrieve the child bookmark you want to update from the PDF file by first getting the parent bookmark and then the child bookmark using appropriate index values.
1. Save the updated PDF file using the [Save](https://apireference.aspose.com/net/pdf/aspose.pdf.document/save/methods/4) method.

{{% alert color="primary" %}} 

Get a bookmark from the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's [OutlineCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlinecollection) collection by specifying the bookmark's index, and then get the child bookmark by specifying the index od this parent bookmark.

{{% /alert %}} 

The following code snippet shows you how to update child bookmarks in a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Bookmarks-UpdateChildBookmarks-UpdateChildBookmarks.cs" >}}
## **Inherit zoom while editing Bookmarks**
The default zoom action when clicking a bookmark (that was generated using Aspose) is to fit the page width. However, we can edit specific bookmark actions using Acrobat, and set the zoom to "Inherit Zoom". This way, no matter how the user is currently viewing the document, clicking a bookmark will not change how they're viewing." So the requirement is to programmatically Inherit zoom while editing Bookmarks.

In order to specify inherit zoom, you should use 0 value as according to PDF specifications **A null value for any of the parameters left, top, or zoom specifies that the current value of that parameter shall be retained unchanged**. A zoom value of 0 has the same meaning as a null value. The following code snippets show how to update bookmarks in a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Bookmarks-InheritZoom-InheritZoom.cs" >}}
## **Expanded Bookmarks when viewing document**
Bookmarks are held in the Document object's [OutlineItemCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlineitemcollection) collection, itself in the [OutlineCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/outlinecollection) collection. However, we may have a requirement to have all the bookmarks expanded when viewing the PDF file.

In order to accomplish this requirement, we can set open status for each outline/bookmark item as Open. The following code snippet shows you how to set the open status for each bookmark as expanded in a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Bookmarks-ExpandBookmarks-ExpandBookmarks.cs" >}}
