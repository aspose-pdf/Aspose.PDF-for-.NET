---
title: Extract PDF pages
type: docs
weight: 40
url: /net/extract-pdf-pages/
---

## **Extract PDF Pages between Two Numbers Using File Paths**
**Extract** method of **PdfFileEditor** class allows you to extract specified range of pages from a PDF file. This overload allows you to extract pages while manipulating the PDF files from the disk. This overload requires following parameters: intput file path, start page, end page, and output file path. The pages from the start page to end page will be extracted and output will be saved on the disk.The following code snippet shows you how to extract PDF pages between two numbers using file paths.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ExtractPages-ExtractPagesBetweenNumbers-ExtractPagesBetweenNumbers.cs" >}}
## **Extract Array of PDF Pages Using File Paths**
If you do not want to extract a range of pages, rather a set of particular pages, **Extract** method allows you to do that as well. You first need to create an integer array with all the page numbers which need to be extracted. This overload of **Extract** method takes following parameters: input PDF file, integer array of pages to be extracted, and output PDF file. The following code snippet shows you how to extract PDF pages using file paths. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ExtractPages-ExtractArrayOfPages-ExtractArrayOfPages.cs" >}}
## **Extract PDF Pages between Two Numbers Using Streams**
**Extract** method of **PdfFileEditor** class allows you to extract a range of pages using streams. You need to pass the following paramteres to this overload: intput stream, start page, end page, and output stream. The pages specified by the range between start page and end page will be extracted from the intput stream and saved to the output stream.The following code snippet shows you how to extract PDF pages between two numbers using streams.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ExtractPages-ExtractPagesBetweenTwoNumbersUsingStreams-ExtractPagesBetweenTwoNumbersUsingStreams.cs" >}}
## **Extract Array of PDF Pages Using Streams**
An array of pages can be extracted from the PDF stream and saved in the output stream using appropriate overload of **Extract** method. If you do not want to extract a range of pages, rather a set of particular pages, **Extract** method allows you to do that as well. You first need to create an integer array with all the page numbers which need to be extracted. This overload of **Extract** method takes following parameters: input stream, integer array of pages to be extracted and output stream. 
The following code snippet shows you how to extract PDF pages using streams. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-ExtractPages-ExtractArrayOfPagesUsingStreams-ExtractArrayOfPagesUsingStreams.cs" >}}
