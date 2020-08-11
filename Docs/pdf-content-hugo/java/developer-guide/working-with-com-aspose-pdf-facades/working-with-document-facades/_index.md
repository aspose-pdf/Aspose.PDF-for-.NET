---
title: Working with Document - facades
type: docs
weight: 10
url: /java/working-with-document-facades/
---

## **Get PDF file information - facades**
In order to get information specific to PDF file, you need to create an object of [PdfFileInfo](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileInfo) class. After that, you can get values of the individual properties like Subject, Title, Keywords and Creator etc.

The following code snippet shows you how to get PDF file information.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Document-GetPDFFilenformation-.java" >}}
## **Set PDF file information - facades**
[PdfFileInfo](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileInfo) class allows you to set file specific information of a PDF document. You need to create an object of [PdfFileInfo](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileInfo) class and then set different file specific properties like Author, Title, Keyword, and Creator etc. Finally, save the updated PDF file using [saveNewInfo(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileInfo#saveNewInfo-java.io.OutputStream-) method of the [PdfFileInfo](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileInfo) object.

The following code snippet shows you how to set PDF file information.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Document-SetPDFFileInformation-.java" >}}
## **Get XMP Metadata of an existing PDF File - facades**
In order to get XMP metadata from a PDF file, you need to create [PdfXmpMetadata](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfXmpMetadata) object and bind the PDF file using [bindPdf(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/Facade#bindPdf-com.aspose.pdf.IDocument-) method. You can pass specific XMP metadata properties to the [PdfXmpMetadata](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfXmpMetadata) object to get their values.

The following code snippet shows you how to get XMP metadata from a PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Document-GetXMPMetadataOfAnExistingPDFFile-.java" >}}
## **Set XMP Metadata of an existing PDF - facades**
In order to set XMP metadata in a PDF file, you need to create [PdfXmpMetadata](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfXmpMetadata) object and bind the PDF file using [bindPdf(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/Facade#bindPdf-com.aspose.pdf.IDocument-) method. You can use setByDefaultMetadataProperties(..) method of the [PdfXmpMetadata](http://www.aspose.com/api/java/pdf/com.aspose.pdf.facades/classes/PdfXmpMetadata) class to add different properties. Finally, call the [save(...)](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/SaveableFacade#save-java.io.OutputStream-) method of [PdfXmpMetadata](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfXmpMetadata) class.

The following code snippet shows you how to add XMP metadata in a PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Document-SetXMPMetadataOfAnExistingPDF-.java" >}}
## **Set Viewer Preference of an existing PDF File - facades**
The [ViewerPreference](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/ViewerPreference) class represents display modes of PDF files; for example, positioning the document window in the center of the screen, hiding viewer application’s menu bar etc. [changeViewerPreference(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfContentEditor#changeViewerPreference-int-) method in [PdfContentEditor](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfContentEditor) class allows you to change the viewer preference. In order to do that, you need to create an object of [PdfContentEditor](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfContentEditor) class and bind the input PDF file using [bindPdf(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/Facade#bindPdf-com.aspose.pdf.IDocument-) method. Ater that, you can call [changeViewerPreference(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfContentEditor#changeViewerPreference-int-) method to set any preferences. Finally, you have to save the updated PDF file using [save(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/SaveableFacade#save-java.io.OutputStream-) method.

The following code snippet shows you how to change viewer preference in an existing PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Document-SetViewerPreferenceOfAnExistingPDFFile-.java" >}}
## **Adding Javascript actions to existing PDF file**
The [PdfContentEditor](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfContentEditor) class present under com.aspose.pdf.facades package provides the flexibility to add Javascript actions to a PDF file. You can create a link with the serial actions corresponding to execute a menu item in the PDF viewer. This class also provides the feature to create additional actions for document events.

The following sample code shows you how to add Javascript actions in a PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Document-AddingJavascriptActionsToExistingPDFFile-.java" >}}
