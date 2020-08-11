---
title: Add PDF Page Stamp
type: docs
weight: 10
url: /net/add-pdf-page-stamp/
---

## **Add PDF Page Stamp on All Pages in a PDF File**
**PdfFileStamp** class allows you to add PDF page stamp on all the pages of a PDF file. In order to add PDF page stamp, you first need to create objects of **PdfFileStamp** and **Stamp** classes. You also need to create the PDF page stamp using **Bind** **Pdf** method of **Stamp** class. You can set other attributes like origin, rotation, background etc. using **Stamp** object as well. Then you can add the stamp in the PDF file using **AddStamp** method of **PdfFileStamp** class. Finally, save the output PDF file using **Close** method of **PdfFileStamp** class. The following code snippet shows you how to add PDF page stamp on all pages in a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Stamps-Watermarks-AddPageStampAll-AddPageStampAll.cs" >}}
## **Add PDF Page Stamp on Particular Pages in a PDF File**
**PdfFileStamp** class allows you to add PDF page stamp on particular pages of a PDF file. In order to add PDF page stamp, you first need to create objects of **PdfFileStamp** and **Stamp** classes. You also need to create the PDF page stamp using **Bind** **Pdf** method of **Stamp** class. You can set other attributes like origin, rotation, background etc. using **Stamp** object as well. As you want to add PDF page stamp on particular pages of the PDF file, you also need to set the **Pages** property of the **Stamp** class. This property requires an integer array containing numbers of the pages on which you want to add the stamp. Then you can add the stamp in the PDF file using **AddStamp** method of **PdfFileStamp** class. Finally, save the output PDF file using **Close** method of **PdfFileStamp** class. The following code snippet shows you how to add PDF page stamp on particular pages in a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Stamps-Watermarks-AddPageStampPage-AddPageStampPage.cs" >}}
## **Add Page Number in a PDF File**
**PdfFileStamp** class allows you to add page numbers in a PDF file. In order to add page numbers, you first need to create object of **PdfFileStamp** class. If you want to show page number like “Page X of N” while X being the current page number and N the total number of pages in the PDF file then you first need to get the page count using **NumberOfpages** property of **PdfFileInfo** class. In order to get the current page number you can use **#** sign in your text anywhere you like. You can format the page number text using **FormattedText** class. If you want to start the page numbering from a specific number then you can set **StartingNumber** property. Once you’re ready to add page number in the file, you need to call **AddPageNumber** method of **PdfFileStamp** class. Finally, save the output PDF file using **Close** method of **PdfFileStamp** class. The following code snippet shows you how to add page number in a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Stamps-Watermarks-AddPageNumber-AddPageNumber.cs" >}}
### **Custom Numbering style**
The PdfFileStamp class offers the feature to add Page Number information as stamp object inside PDF document. Prior to this release, the class only supported 1,2,3,4 as page numbering style. However, there has been a requirement from some customers to use custom numbering style when placing page number stamp inside PDF document. In order to accomplish this requirement, **NumberingStyle** property has been introduced, which accepts the values from **NumberingStyle** enumeration. Specified below are values offered in this enumeration.

- LettersLowercase
- LettersUppercase
- NumeralsArabic
- NumeralsRomanLowercase
- NumeralsRomanUppercase



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Stamps-Watermarks-AddPageNumber-CustomNumberStyle.cs" >}}
