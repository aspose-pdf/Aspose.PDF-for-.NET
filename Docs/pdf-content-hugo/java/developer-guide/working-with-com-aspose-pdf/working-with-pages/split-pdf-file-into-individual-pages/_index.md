---
title: Split PDF File into Individual Pages
type: docs
weight: 40
url: /java/split-pdf-file-into-individual-pages/
---

{{% alert color="primary" %}} 

To split a PDF file into single page PDF files, loop through the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's Pages collection. For each iteration, create a new Document object and add the individual [Page](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Page) to the empty document. Then save the new PDF using the save method.

{{% /alert %}} 

The following code snippet shows how to split PDF file to individual pages.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-pages-SplitPDFFileIntoIndividualPages-.java" >}}
