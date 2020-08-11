---
title: Exploring features of PdfFileEditor class
type: docs
weight: 40
url: /net/exploring-features-of-pdffileeditor-class/
---

{{% alert color="primary" %}} 

When we talk about editing and manipulating an existing PDF file s, Aspose.Pdf.Facades namespace in Aspose.PDF for .Net provides number of features for that matter. Manipulating pages of a PDF file is an important part of this component; PdfFileEditor class serves the purpose in this regard. This article explores the features provided by this class and explains the purpose of its methods.

{{% /alert %}} 
## **Explanation**
PdfFileEditor class contains the methods which help manipulate individual pages; this class doesn’t edit or manipulate the contents of a page. You can insert a new page, delete existing page, split the pages or you can specify imposition of the pages using PdfFileEditor.

The features provided by this class can be divided into three main categories i.e. File Editing, PDF Imposition, and Splitting. We’re going to discuss these sections in detail below:
## **File Editing**
The features which we can include in this section are Insert, Append, Delete, Concatenate and Extract. You can insert a new page at a specified location using Insert method, or append the pages at the end of the file. You can also delete any number of pages from the file using Delete method, by specifying an integer array containing the numbers of pages to be deleted. Concatenate method helps you to join pages from multiple PDF files. You can extract any number of pages using Extract method, and save these pages into another PDF file or memory stream.
## **PDF Imposition**
Imposition is the process of arranging pages correctly prior to printing. PdfFileEditor provides two methods for this purpose i.e. MakeBooklet and MakeNUp. MakeBooklet method helps to arrange pages so that it’ll be easy to fold or bind them after printing, however, MakeNUp method allows to print multiple pages on one page of the PDF file.
## **Splitting**
Splitting feature allows you to divide an existing PDF file into different parts. You can either split the front part of the PDF file or the rear part. As PdfFileEditor provides a variety of method for splitting purposes, you can also split a file into individual pages or many sets of multiple pages.

You can find samples of the above mentioned methods in the code snippet given below:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-PdfFileEditorFeatures-PdfFileEditorFeatures.cs" >}}
## **Conclusion**

{{% alert color="primary" %}} 

In this article we have seen how we can edit and manipulate the pages without changing the content s of the pages while using PdfFileEditor class. If you use the features effectively it’ll help you a lot.

{{% /alert %}} 