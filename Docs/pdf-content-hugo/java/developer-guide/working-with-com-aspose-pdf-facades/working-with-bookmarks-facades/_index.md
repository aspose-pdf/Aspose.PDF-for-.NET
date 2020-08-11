---
title: Working with Bookmarks - facades
type: docs
weight: 70
url: /java/working-with-bookmarks-facades/
---

## **Create Bookmarks of All Pages (facades)**
{{% alert color="primary" %}} 

In order to create bookmarks of all the pages, you need to use createBookmarks method without any parameters . PdfBookmarEditor class allows you to create bookmarks of all the pages of a PDF file. First, you need to create an object of PdfBookmarkEditor class and bind the input PDF using bindPdf method. Then, you have to call createBookmarks method and save the output PDF file using save method.

{{% /alert %}} 

The following code snippet shows you:



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Bookmarks-CreateBookmarksOfAllPages-.java" >}}
## **Create Bookmarks of All Pages with Properties (facades)**
PdfBookmarEditor class allows you to create bookmarks of all the pages of a PDF file and specify the properties (Color, Bold, Italic). You can do that with the help of createBookmarks method. First, you need to create an object of PdfBookmarkEditor class and bind the input PDF using bindPdf method. Then, you have to call createBookmarks method and save the output PDF file using save method.

The following code snippet shows you how to create bookmarks of all the pages with properties.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Bookmarks-CreateBookmarksOfAllPagesWithProperties-.java" >}}
## **Export Bookmarks to XML from an Existing PDF File (facades)**
{{% alert color="primary" %}} 

The exportBookmarksToXml method allows you to export bookmarks from a PDF file to an XML file.

{{% /alert %}} 

To export bookmarks:

1. Create a PdfBookmarkEditor object and bind the PDF file using the bindPdf method.
1. Call the exportBookmarksToXml method.

The following code snippet shows you how to export bookmarks to an XML file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Bookmarks-ExportBookmarksToXMLFromAnExistingPDFFile-ToExportBookmarks.java" >}}



From Aspose.PDF for Java 9.0.0, the PdfBookmarkEditor class implements the exportBookmarksToXML and importBookmarksWithXML methods with Stream arguments. As a result, extracted bookmarks can be saved to a stream object.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Bookmarks-ExportBookmarksToXMLFromAnExistingPDFFile-ExportBookmarksToXML.java" >}}
## **Import Bookmarks from XML to an Existing PDF File (facades)**
The importBookmarksWithXml method allows you to import bookmarks into a PDF file from an XML file.

To import bookmarks:

1. Create a PdfBookmarkEditor object and bind the PDF file using the bindPdf method.
1. Call the importBookmarksWithXml method.
1. Save the updated PDF file using the save method.

The following code snippet shows how to import bookmarks from an XML file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Bookmarks-ImportBookmarksFromXMLToAnExistingPDFFile-ToImportBookmarks.java" >}}



From Aspose.PDF for Java 9.0.0, the PdfBookmarkEditor class implements the exportBookmarksToXML and importBookmarksWithXML methods with Stream arguments. As a result, extracted bookmarks can be imported from a stream object.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Bookmarks-ImportBookmarksFromXMLToAnExistingPDFFile-ImportBookmarksWithXML.java" >}}
