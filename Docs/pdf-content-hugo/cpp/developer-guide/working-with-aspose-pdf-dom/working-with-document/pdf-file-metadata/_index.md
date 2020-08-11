---
title: PDF File Metadata
type: docs
weight: 20
url: /cpp/pdf-file-metadata/
---

## **Get/Set PDF File Information**
In order to get file specific information of a PDF file, you first need to call the **get_Info()** of Document class. Once the DocumentInfo object is retrieved, you can get the values of the individual properties. Furthermore, you can also set the properties by using respective methods of DocumentInfo class. Following code snippet demonstrate, how to get/set PDF File information using Aspose.PDF for C++:

{{% alert color="primary" %}} 

Please note that you cannot set values against the **Application** and **Producer** fields, because Aspose Ltd. and Aspose.PDF for C++ x.x.x will be displayed against these fields.

{{% /alert %}} 

{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Document-GetSetInfo-GetSetInfo.cpp" >}}
## **Get/Set XMP Metadata from PDF File**
Aspose.PDF for C++ allows you to access a PDF file's XMP metadata as well as set it. To get/set a PDF file's metadata:

1. Create a Document object and open the input PDF file.
1. Get/Set the file's metadata using respective methods.

The following code snippet shows you how to get/set metadata from the PDF file.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Document-GetSetMetadata-GetSetMetadata.cpp" >}}
