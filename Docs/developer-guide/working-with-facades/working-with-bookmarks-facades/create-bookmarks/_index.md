---
title: Create Bookmarks
type: docs
weight: 10
url: /net/create-bookmarks/
---

## **Create Bookmarks of All Pages**
In order to create bookmarks of all the pages, you need to use **CreateBookmarks** method without any parameters . **PdfBookmarEditor** class allows you to create bookmarks of all the pages of a PDF file. First, you need to create an object of **PdfBookmarkEditor** class and bind the input PDF using **BindPdf** method. Then, you have to call **CreateBookmarks** method and save the output PDF file using **Save** method. The following code snippet shows you how to create Bookmarks.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Bookmarks-CreateBookmarksAll-CreateBookmarksAll.cs" >}}
## **Create Bookmarks of All Pages with Properties**
**PdfBookmarEditor** class allows you to create bookmarks of all the pages of a PDF file and specify the properties (Color, Bold, Italic). You can do that with the help of **CreateBookmarks** method. First, you need to create an object of **PdfBookmarkEditor** class and bind the input PDF using **BindPdf** method. Then, you have to call **CreateBookmarks** method and save the output PDF file using **Save** method. The following code snippet shows you how to create bookmarks of all the pages with properties.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Bookmarks-CreateBookmarksPagesProperties-CreateBookmarksPagesProperties.cs" >}}
## **Create Bookmark of a Particular Page**
You can create a bookmark of a particular page in an existing PDF file using **CreateBookmarkOfPage** method. This method takes two arguments: bookmark title and page number. First, you need to create an object of **PdfBookmarkEditor** class and bind input PDF file using **BindPdf** method. Then, you have to call the **CreateBookmarkOfPage** method and save the output PDF file using **Save** method. The following code snippet shows you how to create bookmark of a particular page.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Bookmarks-CreateBookmarkPage-CreateBookmarkPage.cs" >}}
## **Create Bookmarks of a Range of Pages**
**PdfBookmarkEditor** class allows you to create bookmarks of a range of pages. You can use **CreateBookmarkOfpage** method with two parameters: bookmark list (the list of the bookmark titles) and page list (the list of the pages to bookmark). First, you need to create an object of **PdfBookmarkEditor** class and bind the input PDF file using **BindPdf** method. Then, you have to call **CreateBookmarkOfPage** method and save the output PDF using **Save** method. The following code snippet shows you how to create bookmarks of a range of pages.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Bookmarks-CreateBookmarkPageRange-CreateBookmarkPageRange.cs" >}}
## **Add Bookmark in an Existing PDF File**
You can add bookmark in an existing PDF file using **PdfBookmarkEditor** class. In order to create the bookmark, you need to create **Bookmark** object and set the required attributes of the bookmark. After that, you need to pass the **Bookmark** object to the **CreateBookmarks** method of **PdfBookmarkEditor** class. Finally, you need to save the updated PDF file using **Save** method. The following code snippet shows you how to add the bookmark in an existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Bookmarks-AddBookmark-AddBookmark.cs" >}}
## **Add Child Bookmark in an Existing PDF File**
You can add child bookmarks in an existing PDF file using **PdfBookmarkEditor** class. In order to add child bookmarks, you need to create **Bookmarks** and*Bookmark* objects. You can add individual **Bookmark** objects into **Bookmarks** object. You also need to create a **Bookmark** object and set its **ChildItem** property to **Bookmarks** object. You then need to pass this **Bookmark** object with **ChildItem** to the **CreateBookmarks** method. Finally, you need to save the updated PDF using **Save** method of the **PdfBookmarkEditor** class. The following code snippet shows you how to add child bookmarks in an existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Bookmarks-AddChildBookmark-AddChildBookmark.cs" >}}
