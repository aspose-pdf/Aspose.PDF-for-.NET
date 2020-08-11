---
title: Add and Delete Bookmarks
type: docs
weight: 10
url: /cpp/add-and-delete-bookmarks/
---

## **Add Bookmark**
PdfBookmarkEditor class allows you to add bookmarks inside PDF document. CreateBookmarkOfPage method offered by this class, enables you to create bookmark, which will target to the specified page number. Following code snippet demonstrates this feature of the Aspose.PDF for C++ API:



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Bookmarks-CreateBookmark-1.cpp" >}}
## **Add Child Bookmark in existing document**
You can add child bookmarks in an existing PDF file using **PdfBookmarkEditor** class. In order to add child bookmarks, you need to create **Bookmarks** and*Bookmark* objects. You can add individual **Bookmark** objects into **Bookmarks** object. You also need to create a **Bookmark** object and set its **ChildItem** property to **Bookmarks** object. You then need to pass this **Bookmark** object with **ChildItem** to the **CreateBookmarks** method. Finally, you need to save the updated PDF using **Save**method of the **PdfBookmarkEditor** class. The following code snippet shows you how to add child bookmarks in an existing PDF file.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Bookmarks-CreateChildBookmark-1.cpp" >}}
## **Delete All Bookmarks from PDF file**
You can delete all the bookmarks from the PDF file using **DeleteBookmarks** method without any parameters. First of all, you need to create an object of **PdfBookmarkEditor** class and bind the input PDF file using **BindPdf** method. After that, you need to call the **DeleteBookmarks** method and then save the updated PDF file using **Save** method. The following code snippet shows you how to delete all the bookmarks from the PDF file.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Bookmarks-DeleteAllBookmarks-1.cpp" >}}
## **Delete a Particular Bookmark from a PDF File**
In order to delete a particular bookmark, you need to call **DeleteBookmarks** method with string (title) parameter. The **title** here represents the bookmark to be deleted from the PDF. Create an object of **PdfBookmarkEditor** class and bind input PDF file using **BindPdf** method. After that, call **DeleteBookmarks** method and then save the updated PDF file using **Save** method. The following code snippet shows you how to delete a particular bookmark from a PDF file.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Bookmarks-DeleteBookmark-1.cpp" >}}
