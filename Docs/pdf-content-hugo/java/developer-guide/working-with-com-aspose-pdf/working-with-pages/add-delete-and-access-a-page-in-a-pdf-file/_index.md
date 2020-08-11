---
title: Add, Delete and Access a Page in a PDF File
type: docs
weight: 10
url: /java/add-delete-and-access-a-page-in-a-pdf-file/
---

## **Insert an Empty Page into a PDF File**
This article explains how to insert a blank page into a document, either at a specific location, or at the end of the document.

The Pages collection's insert method allows you to insert an empty page into a PDF document. You need to pass the location you want to insert the blank page to to the insert method.

To insert a blank page:

1. Create a [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object with the PDF file you want to add the page to.
1. Call the Pages collection's insert method of this [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object.
1. Save the output PDF using the save method.

The following code snippet shows how to insert an empty page into a PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-pages-InsertAnEmptyPageIntoPDFFile-.java" >}}


To insert an empty page at the end of the PDF file, simply call the Pages collection' add method, without any parameters.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Pages-InsertAnEmptyPageIntoPDFFile-Info.java" >}}


## **Get a Particular Page in a PDF File**
Aspose.PDF allows you to [split a PDF into individual pages](/pdf/java/split-pdf-file-into-individual-pages-html/) and save them as PDF files. Getting a specified page in a PDF file and saving it as a new PDF is a very similar operation: open the source document, access the page, create a new document and add the page to this.

The [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's Pages collection returns the pages in the PDF file. To get a particular page from this collection:

1. Specify the page index using the Pages collection's get_Item() method.
1. Create a new [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object.
1. Add the [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) object to the new document's Pages collection.
1. Save the output using the save method.

The following code snippet shows how to get a page from a PDF file and save it as a new file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-pages-GetParticularPageInPDFFile-.java" >}}
## **Delete a Particular Page from the PDF File**
To delete a page from the Pages collection, simply call the delete() method and specify the index of the particular page you want to delete. Then call the save method to save the updated PDF file.

The following code snippet shows you how to delete a page from a PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-pages-DeleteParticularPageFromThePDFFile-.java" >}}
