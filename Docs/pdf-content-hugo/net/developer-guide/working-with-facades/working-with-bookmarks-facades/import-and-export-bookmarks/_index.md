---
title: Import and Export Bookmarks
type: docs
weight: 20
url: /net/import-and-export-bookmarks/
---

## **Import Bookmarks from XML to an Existing PDF File**
**ImportBookmarksWithXml** method allows you to import bookmarks into a PDF file from an XML file. In order to import the bookmarks, you need to create **PdfBookmarkEditor** object and bind the PDF file using **BindPdf** method. After that, you need to call **ImportBookmarksWithXml** method. Finally, save the updated PDF file using **Save** method. The following code snippet shows you how to import bookmarks from an XML file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Bookmarks-ImportFromXML-ImportFromXML.cs" >}}
## **Export Bookmarks to XML from an Existing PDF File**
The ExportBookmarksToXml method allows you to export bookmarks from a PDF file to an XML file.

To export bookmarks:

1. Create a PdfBookmarkEditor object and bind the PDF file using the BindPdf method.
1. Call the ExportBookmarksToXml method.
1. Save the updated PDF file using the Save method.

The following code snippet shows you how to export bookmarks to an XML file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Bookmarks-ExportToXML-ExportToXML.cs" >}}
