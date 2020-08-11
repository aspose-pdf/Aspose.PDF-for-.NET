---
title: Split PDF pages
type: docs
weight: 90
url: /net/split-pdf-pages/
---

## **Split PDF Pages from First Using File Paths**
**SplitFromFirst** method of **PdfFileEditor** class allows you to split the PDF file starting from the first page and ending at the specified page number. If you want to manipulate the PDF files from the disk, you can pass the file paths of the intput and output PDF files to this method. The following code snippet shows you how to split PDF pages from first using file paths.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-SplitPages-SplitPagesUsingPaths-SplitPagesUsingPaths.cs" >}}
## **Split PDF Pages from First Using File Streams**
**SplitFromFirst** method of **PdfFileEditor** class allows you to split the PDF file starting from the first page and ending at the specified page number. If you want to manipulate the PDF files from the streams, you can pass the input and output PDF streams to this method. The following code snippet shows you how to split PDF pages from first using file streams.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-SplitPages-SplitPagesUsingStreams-SplitPagesUsingStreams.cs" >}}
## **Split PDF Pages to Bulk Using File Paths**
**SplitToBulks** method of **PdfFileEditor** class allows you to split the PDF file into multiple sets of pages. In this example, we require two sets of pages (1, 2) and (5, 6). If you want to access the PDF file from the disk, you need to pass the input PDF as file path. This method returns an array of MemoryStream. You can loop through this array and save the individual sets of pages as separate files. The following code snippet shows you how to split PDF pages to bulk using file paths.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-SplitPages-SplitPagesToBulkUsingPaths-SplitPagesToBulkUsingPaths.cs" >}}
## **Split PDF Pages to Bulk Using Streams**
**SplitToBulks** method of **PdfFileEditor** class allows you to split the PDF file into multiple sets of pages. In this example, we require two sets of pages (1, 2) and (5, 6). You can pass a stream to this method instead of accessing the file from the disk. This method returns an array of MemoryStream. You can loop through this array and save the individual sets of pages as separate files. The following code snippet shows you how to split PDF pages to bulk using streams.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-SplitPages-SplitPagesToBulkUsingStreams-SplitPagesToBulkUsingStreams.cs" >}}
## **Split PDF Pages to End Using File Paths**
**SplitToEnd** method of **PdfFileEditor** class allows you to split the PDF from the specified page number to the end of the PDF file and save it as a new PDF. In order to do this, using file paths, you need to pass input and output file paths and the page number from where the split needs to be started. The output PDF will be saved to the disk. The following code snippet shows you how to split PDF pages to end using file paths. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-SplitPages-SplitPagesToEndUsingPaths-SplitPagesToEndUsingPaths.cs" >}}
## **Split PDF Pages to End Using Streams**
**SplitToEnd** method of **PdfFileEditor** class allows you to split the PDF from the specified page number to the end of the PDF file and save it as a new PDF. In order to do this, using streams, you need to pass input and output streams and the page number from where the split needs to be started. The output PDF will be saved to the output stream. The following code snippet shows you how to split PDF pages to end using streams. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-SplitPages-SplitPagesToEndUsingStreams-SplitPagesToEndUsingStreams.cs" >}}
## **Split PDF to Individual Pages Using File Paths**
{{% alert color="primary" %}} 

You can try to split PDF document and view the results online at this link:

[products.aspose.app/pdf/splitter](https://products.aspose.app/pdf/splitter) {{% /alert %}} 

In order to split PDF file to individual pages, you need to pass the PDF as file path to the **SplitToPages** method. This method will return an array of MemoryStream containing individual pages of the PDF file. You can loop through this array of MemoryStream and save individual pages as individual PDF files on the disk. The following code snippet shows you how to split PDF to individual pages using file paths.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-SplitPages-SplitToIndividualPagesUsingPaths-SplitToIndividualPagesUsingPaths.cs" >}}
## **Split PDF to Individual Pages Using Streams**
In order to split PDF file to individual pages, you need to pass the PDF as stream to the **SplitToPages** method. This method will return an array of MemoryStream containing individual pages of the PDF file. You can loop through this array of MemoryStream and save individual pages as individual PDF files on the disk, or you can keep these individual pages in the memory stream for later use in your application. The following code snippet shows you how to split PDF to individual pages using streams.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-SplitPages-SplitToIndividualPagesUsingStreams-SplitToIndividualPagesUsingStreams.cs" >}}
