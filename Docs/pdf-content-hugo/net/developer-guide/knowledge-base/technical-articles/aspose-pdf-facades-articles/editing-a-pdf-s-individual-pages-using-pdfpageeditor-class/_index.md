---
title: Editing a PDF's individual pages using PdfPageEditor class
type: docs
weight: 60
url: /net/editing-a-pdf-s-individual-pages-using-pdfpageeditor-class/
---

{{% alert color="primary" %}} 

Aspose.Pdf.Facades namespace in [Aspose.PDF for .NET](/pdf/net/home-html/) allows you to manipulate individual pages in a PDF file. This feature helps you work with the page display, alignment, and transition etc. PdfpageEditor class helps to achieve this functionality. In this article, we’ll look into the properties and methods provided by this class and the working of these methods as well.

{{% /alert %}} 
## **Explanation**
[PdfPageEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfpageeditor) class is different from [PdfFileEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdffileeditor) and [PdfContentEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfcontenteditor) class. First we need to understand the difference, and then we’ll be able to better understand the PdfPageEditor class. PdfFileEditor class allows you manipulate all the pages in a file like adding, deleting, or concatenating pages etc, while PdfContentEditor class helps you manipulate the contents of a page i.e. text and other objects etc. Whereas, PdfPageEditor class only works with the individual page itself like rotating, zooming, and aligning a page etc.

We can divide the features provided by this class into three main categories i.e. Transition, Alignment, and Display. We’re going to discuss these categories below:
### **Transition**
This class contains two properties related to transition i.e. [TransitionType](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfpageeditor/properties/transitiontype) and [TransitionDuration](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfpageeditor/properties/transitionduration). TransitionType specifies the transition style to be used when moving to this page from another page during a presentation. TransitionDuration specifies display duration for the pages.
### **Alignment**
PdfPageEditor class supports both horizontal and vertical alignments. It provides two properties to serve the purpose i.e. [Alignment](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfpageeditor/properties/alignment) and [VerticalAlignment](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfpageeditor/properties/VerticalAlignment). Alignment property is used to align the contents horizontally. Alignment property takes a value of AlignmentType, which contains three options i.e. Center, Left, and Right. VerticalAlignment property takes a value of VerticalAlignmentType, which contains three options i.e. Bottom, Center, and Top.
### **Display**
Under display category we can include properties like PageSize, Rotation, Zoom, and DisplayDuration. PageSize property specifies the size of individual page in the file. This property takes PageSize object as an input, which encapsulates predefined page size like A0, A1, A2, A3, A4, A5, A6, B5, Letter, Ledger, and P11x17. Rotation property is used to set the rotation of an individual page. It can take values 0, 90, 180, or 270. Zoom property sets the zoom coefficient for the page, and it takes a float value as an input. This class also provides method to get page size and page rotation of the individual page in the file.

You can find samples of the above mentioned methods in the code snippet given below:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-EditPdfPages-EditPdfPages.cs" >}}
## **Conclusion**
In this article, we have taken a closer look on the [PdfPageEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfpageeditor) class. We have elaborated the properties and methods provided by this class. It makes the manipulation of individual pages in a class a very easy and simple task.
