---
title: Append PDF files
type: docs
weight: 10
url: /net/append-pdf-files/
---

## **Append PDF Files Using File Paths**
You can append pages of one PDF file to the end of the other PDF file. In order to do that, you need to use **Append** method of **PdfFileEditor** class. One of the overloads of **Append** method allows you to append the PDF file using file paths. You need to pass the input PDF, port file, and output file as file paths. You also need to specify the start and end pages which need to be appended. The pages will be retrieved from port file and appended to the input file. The merged file will be saved as output file. The following code snippet shows you how to append PDF files using file paths. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-Append-AppendFiles-AppendFiles.cs" >}}
## **Append Array of PDF Files Using File Paths**
**PdfFileEditor** class allows you to append pages from multiple PDF files to an input file using **Append** method as well. For example, you have two port files, each with 6 pages, and you want to port first 7 pages to the end of the input PDF file. You can create an array of port files and specify the range as start and end page parameters. In this case, the range would be 1 to 7. This means, six pages will be appened from the first file, while one page from the second file. Finally, the output file will be saved as merged file. The following code snippet shows you how to append array of PDF files using file paths. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-Append-AppendArrayOfFiles-AppendArrayOfFiles.cs" >}}
## **Append PDF Files Using Streams**
PDF pages can also be appended to another PDF using streams. In order to do that, you need to use **Append** method of **PdfFileEditor** class. One of the overloads of **Append** method allows you to append the PDF file using streams. You need to pass the input PDF, port file, and output file as streams. You also need to specify the start and end pages which need to be appended. The pages will be retrieved from port file and appended to the input file. The merged file will be saved as output stream. The following code snippet shows you append PDF files using streams. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-Append-AppendFilesUsingStreams-AppendFilesUsingStreams.cs" >}}
## **Append Array Of PDF Files Using Streams**
An array of PDF files can be appened to the input PDF using streams. **PdfFileEditor** class allows you to append pages from multiple PDF streams to an input file stream using **Append** method. For example, you have two port files, each with 6 pages, and you want to port first 7 pages to the end of the input PDF file. You can create an array of port files and specify the range as start and end page parameters. In this case, the range would be 1 to 7. This means, six pages will be appened from the first file, while one page from the second file. Finally, the output file will be saved as merged stream. The following code snippet shows you how to append array of PDF files using streams. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Pages-Append-AppendArrayOfFilesUsingStream-AppendArrayOfFilesUsingStream.cs" >}}
