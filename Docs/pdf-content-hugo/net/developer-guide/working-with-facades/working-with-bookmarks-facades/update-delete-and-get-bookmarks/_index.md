---
title: Update, Delete and Get Bookmarks
type: docs
weight: 30
url: /net/update-delete-and-get-bookmarks/
---

## **Update an Existing Bookmark in the PDF File**
In order to update an existing bookmark in a PDF file, you need to use **ModifyBookmarks** method. This method takes two arguments: source title (the title of the bookmark to modify), destination title (the title to be replaced). You need to create an object of **PdfBookmarkEditor** class and bind input PDF file using **BindPdf** method. After that, you need to call **ModifyBookmark** method, and then save the updated PDF using **Save** method. The following code snippet shows you how to modify an existing bookmark in a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Bookmarks-UpdateBookmark-UpdateBookmark.cs" >}}
## **Delete All Bookmarks from the PDF File**
You can delete all the bookmarks from the PDF file using **DeleteBookmarks** method without any parameters. First of all, you need to create an object of **PdfBookmarkEditor** class and bind the input PDF file using **BindPdf** method. After that, you need to call the **DeleteBookmarks** method and then save the updated PDF file using **Save** method. The following code snippet shows you how to delete all the bookmarks from the PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Bookmarks-DeleteAllBookmarks-DeleteAllBookmarks.cs" >}}
## **Delete a Particular Bookmark from a PDF File**
In order to delete a particular bookmark, you need to call **DeleteBookmarks** method with string (title) parameter. The **title** here represents the bookmark to be deleted from the PDF. Create an object of **PdfBookmarkEditor** class and bind input PDF file using **BindPdf** method. After that, call **DeleteBookmarks** method and then save the updated PDF file using **Save** method. The following code snippet shows you how to delete a particular bookmark from a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Bookmarks-DeleteABookmark-DeleteABookmark.cs" >}}
## **Get Bookmarks from the PDF Document Facades**
The **PdfBookmarkEditor** class provides the feature to manipulate Bookmarks in existing PDF file. It provides various properties to get/set information regarding bookmarks. The following code snippet shows how to get information related to each bookmark in PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Bookmarks-GetFromPDF-GetFromPDF.cs" >}}
## **Extract Bookmarks from an Existing PDF File**
**ExtractBookmarks** method allows you to extract bookmarks from a PDF file. In order to extract the bookmarks, you need to create **PdfBookmarkEditor** object and bind the PDF file using **BindPdf** method. After that, you need to call **ExtractBookmarks** method. The **ExtractBookmarks** method returns **Bookmarks** object. You can then loop through these bookmarks and get individual **Bookmark** objects. Finally, save the updated PDF file using **Save** method. The following code snippet shows you how to export bookmarks to an XML file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Bookmarks-ExtractBookmarks-ExtractBookmarks.cs" >}}
