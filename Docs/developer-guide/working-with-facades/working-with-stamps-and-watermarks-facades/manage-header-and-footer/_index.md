---
title: Manage Header and Footer
type: docs
weight: 40
url: /net/manage-header-and-footer/
---

## **Add Header in a PDF File**
**PdfFileStamp** class allows you to add header in a PDF file. In order to add header, you first need to create object of **PdfFileStamp** class. You can format the header text using **FormattedText** class. Once you’re ready to add header in the file, you need to call **Add** **Header** method of **PdfFileStamp** class. You also need to specify at least the top margin in the **AddHeader** method. Finally, save the output PDF file using **Close** method of **PdfFileStamp** class. The following code snippet shows you how to add header in a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Stamps-Watermarks-AddHeader-AddHeader.cs" >}}
## **Add Footer in a PDF File**
**PdfFileStamp** class allows you to add footer in a PDF file. In order to add footer, you first need to create object of **PdfFileStamp** class. You can format the footer text using **FormattedText** class. Once you’re ready to add footer in the file, you need to call **Add** **Footer** method of **PdfFileStamp** class. You also need to specify at least the bottom margin in the **AddFooter** method. Finally, save the output PDF file using **Close** method of **PdfFileStamp** class. The following code snippet shows you how to add footer in a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Stamps-Watermarks-AddFooter-AddFooter.cs" >}}
## **Add Image in Header of an Existing PDF File**
**PdfFileStamp** class allows you to add image in the header of a PDF file. In order to add image in header, you first need to create object of **PdfFileStamp** class. After that, you need to call **Add** **Header** method of **PdfFileStamp** class. You can pass the image to the **AddHeader** method. Finally, save the output PDF file using **Close** method of **PdfFileStamp** class. The following code snippet shows you how to add image in header of PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Stamps-Watermarks-AddImageHeader-AddImageHeader.cs" >}}
## **Add Image in Footer of an Existing PDF File**
**PdfFileStamp** class allows you to add image in the footer of a PDF file. In order to add image in footer, you first need to create object of **PdfFileStamp** class. After that, you need to call **Add** **Footer** method of **PdfFileStamp** class. You can pass the image to the **Add** **Footer** method. Finally, save the output PDF file using **Close** method of **PdfFileStamp** class. The following code snippet shows you how to add image in the footer of PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Stamps-Watermarks-AddImageFooter-AddImageFooter.cs" >}}
