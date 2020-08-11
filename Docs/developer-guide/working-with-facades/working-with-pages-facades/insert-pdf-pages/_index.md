---
title: Insert PDF pages
type: docs
weight: 50
url: /net/insert-pdf-pages/
---

## **Insert PDF Pages Between Two Numbers Using File Paths**
A particular range of pages can be inserted from one PDF into another using **Insert** method of **PdfFileEditor** class. In order to do that, you need an input PDF file in which you want to insert the pages, a port file from which the pages need to be taken for insertion, a location where the pages are to be inserted, and a range of pages of the port file which have to be inserted in the input PDF file. This range is specified with start page and end page parameters. Finally, the output PDF file is saved with the specified range of pages inserted in the input file. The following code snippet shows you how to insert PDF pages between two numbers using file streams.

{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-InsertPages-InsertPagesBetweenNumbers-InsertPagesBetweenNumbers.cs" >}}
## **Insert Array of PDF Pages Using File Paths**
If you want to insert some specified pages into another PDF file, then you can use an overload of the **Insert** method which requires an integer array of pages. In this array, you can specify which particular pages you want to insert in the input PDF file. In order to do that, you need an input PDF file in which you want to insert the pages, a port file from which the pages need to be taken for insertion, a location where the pages are to be inserted, and integer array of the pages from port file which have to be inserted in the input PDF file. This array contains a list of particular pages which you’re interested to insert in the input PDF file. Finally, the output PDF file is saved with the specified array of pages inserted in the input file. 
The following code snippet shows you how to insert array of PDF pages using file paths. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-InsertPages-InsertArrayOfPages-InsertArrayOfPages.cs" >}}
## **Insert PDF Pages between Two Numbers Using Streams**
If you want to insert the range of pages using streams, you only need to use the appropriate overload of the **Insert** method of **PdfFileEditor** class. In order to do that, you need an input PDF stream in which you want to insert the pages, a port stream from which the pages need to be taken for insertion, a location where the pages are to be inserted, and a range of pages of the port stream which have to be inserted in the input PDF stream. This range is specified with start page and end page parameters. Finally, the output PDF stream is saved with the specified range of pages inserted in the input stream. The following code snippet shows you how to insert PDF pages between two numbers using streams. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-InsertPages-InsertPagesBetweenNumbersUsingStreams-InsertPagesBetweenNumbersUsingStreams.cs" >}}
## **Insert Array of PDF Pages Using Streams**
You can also insert an array of pages into another PDF file using streams with the helps of appropriate overload of the Insert method which requires an integer array of pages. In this array, you can specify which particular pages you want to insert in the input PDF stream. In order to do that, you need an input PDF stream in which you want to insert the pages, a port stream from which the pages need to be taken for insertion, a location where the pages are to be inserted, and integer array of the pages from port stream which have to be inserted in the input PDF file. This array contains a list of particular pages which you’re interested to insert in the input PDF stream. Finally, the output PDF stream is saved with the specified array of pages inserted in the input file.The following code snippet shows you how to insert array of PDF pages using streams.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-InsertPages-InsertPagesUsingStreams-InsertPagesUsingStreams.cs" >}}
