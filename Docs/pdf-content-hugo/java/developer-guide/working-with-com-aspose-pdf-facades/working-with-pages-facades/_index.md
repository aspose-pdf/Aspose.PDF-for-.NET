---
title: Working with Pages - facades
type: docs
weight: 100
url: /java/working-with-pages-facades/
---

## **Resize PDF page contents**
{{% alert color="primary" %}} 

the [**PdfFileEditor**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileEditor) class provides the feature to Concatenate, Insert, Append, makeBooklet, makeNUp, Extract, SplittoBulk and other PDF file manipulation features including re-size page contents..

{{% /alert %}} 

The following code snippet shows the steps to Resize page contents to new dimensions.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Document-ResizePDFPageContents-.java" >}}
## **Resize Page Contents of Specific Pages in a PDF file (facades)**
ResizeContents method of [**PdfFileEditor**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileEditor) class allows you to resize the page contents in a PDF file. ContentsResizeParameters class is used to specify the parameters to be used to resize the page(s) e.g. margins in percentage or units etc. You can resize all the pages or specify an array of pages to be resized using the ResizeContents method.

The following code snippet shows how to resize the contents of some specific pages of PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Pages-ResizePageContentsOfSpecificPagesInAPDFFile-.java" >}}
## **Concatenate PDF documents**
### **Concatenate PDF Files Using File Paths (Facades)**
{{% alert color="primary" %}} 

concatenate method of [**PdfFileEditor**](http://www.aspose.com/api/java/pdf/com.aspose.pdf.facades/classes/PdfFileEditor) class can be used to concatenate two PDF files. The concatenate method allows you to pass three parameters: first input PDF, second input PDF, and output PDF. The final output PDF contains both the input PDF files.

{{% /alert %}} 

The following code snippet shows you how to concatenate PDF files using file paths.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Pages-ConcatenatePDFFilesUsingFilePaths-.java" >}}



In some cases, when there are a lot of outlines, users may disable them with setting **CopyOutlines** to false and improve performance of concatenation.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Pages-ConcatenatePDFFilesUsingFilePaths-SettingCopyOutlines.java" >}}
### **Concatenate Array of PDF Files Using File Paths (Facades)**
If you want to concatenate multiple PDF files, you can use the overload of the concatenate method, which allows you to pass an array of PDF files path. The final output is saved as a merged file created from all the files in the array.

The following code snippet shows you how to concatenate array of PDF files using file paths.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Pages-ConcatenateArrayOfPDFFilesUsingFilePaths-.java" >}}
### **Concatenate Array of PDF Files Using Streams (Facades)**
{{% alert color="primary" %}} 

Concatenating an array of PDF files is not limited to only files residing on the disk. You can also concatenate an array of PDF files from streams. If you want to concatenate multiple PDF files, you can use the appropriate overload of the Concatenate method. First, you need to create an array of input streams and one stream for output PDF and then call the Concatenate method. The output will be saved in the output stream.

{{% /alert %}} 

The following code snippet shows you how to concatenate array of PDF files using streams.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Pages-ConcatenateArrayOfPDFFilesUsingStreams-.java" >}}
