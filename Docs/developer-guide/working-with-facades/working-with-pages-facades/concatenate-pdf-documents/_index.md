---
title: Concatenate PDF documents
type: docs
weight: 20
url: /net/concatenate-pdf-documents/
---

## **Concatenate PDF Files Using File Paths**
**Concatenate** method of **PdfFileEditor** class can be used to concatenate two PDF files. The **Concatenate** method allows you to pass three parameters: first input PDF, second input PDF, and output PDF. The final output PDF contains both the input PDF files. The following code snippet shows you how to concatenate PDF files using file paths. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ConcatenateDocuments-ConcatenateUsingPath-ConcatenateUsingPath.cs" >}}


In some cases, when there are a lot of outlines, users may disable them with setting CopyOutlines to false and improve performance of concatenation.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ConcatenateDocuments-ConcatenateUsingPath-CopyOutline.cs" >}}
## **Concatenate PDF Files with Blank PDF Using File Paths**
One of the overloads of **Concatenate** method allows you to merge two PDF documents into a new PDF document with pages in alternate ways and fill the blank places with blank pages; for example, document 1 has 5 pages ( p1, p2, p3, p4, p5 ) and document 2 has 3 page s ( p1', p2', p3' ). Merging the two PDF document s will produce the outupt document with pages in the following order: p1, p1', p2, p2', p3, p3', p4, blank page, p5, blank page.The following code snippet shows you how to concatenate PDF files with blank PDF using file paths.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ConcatenateDocuments-ConcatenateWithBlankPdf-ConcatenateWithBlankPdf.cs" >}}
## **Concatenate Array of PDF Files Using File Paths**
If you want to concatenate multiple PDF files, you can use the overload of the **Concatenate** method, which allows you to pass an array of PDF files. The final output is saved as a merged file created from all the files in the array.The following code snippet shows you how to concatenate array of PDF files using file paths.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ConcatenateDocuments-ConcatenateArrayOfFilesWithPath-ConcatenateArrayOfFilesWithPath.cs" >}}
### **Render the resultant PDF in Browser window**
When using PdfFileEditor class to concatenate PDF files in web application, there can be a requirement to display the resultant PDF file in web browser, rather than saving it over the system. In order to accomplish this requirement, PdfFileEditor class provides an overloaded Concatenate method which takes HttpResponse object as an argument. Please take a look over the following code snippet to accomplish this requirement.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ConcatenateDocuments-ConcatenateArrayOfFilesWithPath-RenderInBrowser.cs" >}}
### **Ignore corrupted PDF files during concatenation**
Aspose.PDF for .NET supports the feature to ignore Corrupted PDF documents during PDF concatenation process. Please note that following properties/methods are introduced in PdfFileEditor:

1. A new Enumeration **CorruptedFileActions** (StopWithError, ConcatenateIgnoringCorrupted) is added.
1. Property **CorruptedFileAction** of CorruptedFileActions type is added. This property defines behavior of PDfFileEditor.Concatenate and Append functions when some of files to concatenate/append was corrupted.
- If CorruptedFileAction is "**StopWithError**" then process will be stopped and exception thrown or false returned as result of unsuccessful operation (in depend of AllowConcatenateExceptions state)
- If CorruptFileAction is "**ConcatenateIgnoringCorrupted**" then only valid files will be concatenated, so the resultant file will be correct too.
  Information about corrupted files will be collected and accessible in CorruptedItems property.
  No exceptions are thrown in this case (operation is succeeded anyway)
1. **CorruptedItem** class is introduced.
   This class has two properties:
- int Index - index of corrupted file in parameters array
- Exception exception - exception which was encountered for this file to check the reason of failure.
1. CorruptedItem[] CorruptedItems - property which contains information about all corrupted files which were ignored. Please note this array contains information only for corrupted files. If operation was successful, this array will be empty. Corrupted files are not included into resultant files.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ConcatenateDocuments-ConcatenateArrayOfFilesWithPath-CorruptedFiles.cs" >}}
## **Concatenate PDF files using Streams**
PDF files can also be concatenated using streams instead of file paths. In order to do that, you need to create two input streams and one output stream. You need to pass these three parameters to the appropriate overload of the **Concatenate** method. The final concatenated PDF will be saved in the output stream. The following code snippet shows you how to concatenate PDF files using streams. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ConcatenateDocuments-ConcatenateUsingStreams-ConcatenateUsingStreams.cs" >}}
### **Concatenating Tagged PDF files**
In order to concatenate PDF files, a property **CopyLogicalStructure** is added. This property should be set to false in order to turn off logical structure concatenation. The following code snippet shows how to perform concatenation while copying the logical structure:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ConcatenateDocuments-ConcatenateUsingStreams-ConcatenateTaggedFiles.cs" >}}
## **Concatenate PDF Files with Blank PDF Using Streams**
If you’re interested to concatenate PDF files with a blank page using streams then one of the overloads of **Concatenate** method allows you to do just that. This overload merges two PDF documents into a new PDF document with pages in alternate ways and fill the blank places with blank pages; for example, document 1 has 5 pages ( p1, p2, p3, p4, p5 ) and document 2 has 3 page s ( p1', p2', p3' ). Merging the two PDF documents will produce the outupt document with pages in the following order: p1, p1', p2, p2', p3, p3', p4, blank page, p5, blank page .In this case, you need to create four streams: two input streams, one stream with blank PDF page, and one output stream. The input streams will be merged according to the above plan and output will be saved in the output stream. The following code snippet shows you how to concatenate PDF files with blank PDF using streams.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ConcatenateDocuments-ConcatenateBlankPdfUsingStreams-ConcatenateBlankPdfUsingStreams.cs" >}}
## **Concatenate Array of PDF Files Using Streams**
Concatenating an array of PDF files is not limited to only files residing on the disk. You can also concatenate an array of PDF files from streams. If you want to concatenate multiple PDF files, you can use the appropriate overload of the **Concatenate** method. First, you need to create an array of input streams and one stream for output PDF and then call the **Concatenate** method. The output will be saved in the output stream.The following code snippet shows you how to concatenate array of PDF files using streams.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ConcatenateDocuments-ConcatenateArrayOfPdfUsingStreams-ConcatenateArrayOfPdfUsingStreams.cs" >}}
