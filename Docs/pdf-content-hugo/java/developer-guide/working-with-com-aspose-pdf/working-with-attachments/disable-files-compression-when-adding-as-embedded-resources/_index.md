---
title: Disable Files Compression when Adding as Embedded Resources
type: docs
weight: 50
url: /java/disable-files-compression-when-adding-as-embedded-resources/
---

{{% alert color="primary" %}} 

The [FileSpecification](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileSpecification) class allows developers to add attachments to PDF documents. By default, attachments are compressed. We have updated the API to allow developers to disable compression when adding files as embedded resource. This gives developers more control over how files are processed.

{{% /alert %}} 



To allow developers to control file compression the [setEncoding(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileSpecification#setEncoding-int-) method has been added to the [FileSpecification](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileSpecification) class. This property determines which encoding will be used for file compression. The method accepts a value from the [FileEncoding](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileEncoding) enumerator. The possible values are [FileEncoding](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileEncoding).None and [FileEncoding](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileEncoding).Zip.

If Encoding is set to [FileEncoding](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileEncoding).None, then attachment is not compressed. The default encoding is [FileEncoding](https://apireference.aspose.com/java/pdf/com.aspose.pdf/FileEncoding).Zip.

The following code snippet shows how to add an attachment to a PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-attachments-DisableFilesCompressionWhenAddingAsEmbeddedResources-.java" >}}
