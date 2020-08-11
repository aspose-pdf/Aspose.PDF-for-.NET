---
title: Concatenate PDF Files
type: docs
weight: 30
url: /java/concatenate-pdf-files/
---

{{% alert color="primary" %}} 

Concatenating two files, that is, adding one to the end of another, involves opening both files and passing the pages of one to the target document.

{{% /alert %}} 

To concatenate two PDF files:

1. Create two [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) objects, one for each input file.
   The document you want to add a file to will be called the target document. The file that will be added is called the source document.
1. Call the Pages collection's Add method on the target [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object.
1. Pass the Pages collection of the source [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object to the target document's Pages collection's add method.
1. Save the target PDF file with the save method.

The following code snippet shows how to concatenate PDF files.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-pages-ConcatenatePDFFiles-.java" >}}



