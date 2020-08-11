---
title: Working with Text - Facades
type: docs
weight: 10
url: /net/working-with-text-facades/
---

## **Replace Text in an Existing PDF File**
In order to replace text in an existing PDF file, you need to create an object of **PdfContentEditor** class and bind an input PDF file using **BindPdf** method. After that, you need to call **ReplaceText** method. This overload of **ReplaceText** method takes two arguments: source string (the string to replace) and destination string (the string to be replaced). You need to save the updated PDF file using **Save** method of **PdfContentEditor** class. The following code snippet shows you how to replace text in an existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Text-ReplaceText-ReplaceText.cs" >}}
## **Replace Text on a Particular Page in an Existing PDF File (Facades)**
**PdfContentEditor** allows you to replace text on a particular page as well. In order to replace text on a particular page in an existing PDF file, you need to create an object of **PdfContentEditor** class, and bind an input PDF file using **BindPdf** method. After that, you need to call **ReplaceText** method. This overload of **ReplaceText** method takes three arguments: source string (the string to replace), page number (the page at which text needs to be replaced), and destination string (the string to be replaced). You need to save the updated PDF file using **Save** method of **PdfContentEditor** class. The following code snippet shows you how to replace text on a particular page in an existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Text-ReplaceTextPage-ReplaceTextPage.cs" >}}
## **Extract Text from the Whole PDF File (Facades)**
**PdfExtractor** class allows you to extract text from the whole PDF file. You need to create an object of **PdfExtractor** class and bind the input PDF file using **BindPdf** method. **ExtractText** method helps you extract all the text into the memory. However, in order to get the text, you need to use **GetText** method. The following code snippet shows you how to extract text from the whole PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Text-ExtractText-ExtractText.cs" >}}
## **Extract Text from a Range of Pages (Facades)**
You can use **PdfExtractor** class to extract text from a range of pages. First of all, you need to create a **PdfExtractor** object and bind the PDF file. After that, you need to set **StartPage** and **EndPage** properties to specify the range from which the text needs to be extracted. Finally, you need to extract all the text into memory using **ExtractText** method and then get the extracted text using **GetText** method. The following code snippet shows you how to extract text from a range of pages of a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Text-ExtractTextPageRange-ExtractTextPageRange.cs" >}}
## **Extract Text from Individual Pages of a PDF (Facades)**
In order to extract text from individual pages, you can use **PdfExtractor** class. This class provides two methods **HasNextPageText** and **GetNextPageText** which help retrieve the text from individual pages. First, you need to create an object of **PdfExtractor** class and bind the input PDF file. After that, you need to extract the text into memory using **ExtractText** method. Finally, you have to navigate through all the pages using **HasNextPageText** method and get the text of individual pages using **GetNextPageText** method. The following code snippet shows you how to extract text from individual pages of a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Text-ExtractTextPage-ExtractTextPage.cs" >}}
## **Add Text in an Existing PDF File (Facades)**
You can use **AddText** method of the **PdfFileMend** class to add text in an existing PDF file. Before that, you need to create **FormattedText** object, which contains the text and the formatting information. After that, you need to save the updated PDF file using **Close** method. The following code snippet shows you how to add text in the PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Text-AddText-AddText.cs" >}}
