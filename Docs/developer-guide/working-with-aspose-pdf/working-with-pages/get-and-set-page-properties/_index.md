---
title: Get and Set Page Properties
type: docs
weight: 20
url: /net/get-and-set-page-properties/
---

Aspose.PDF for .NET lets you read and set properties of pages in a PDF file in your .NET applications. This section shows how to get the number of pages in a PDF file, get information about PDF page properties such as color and set page properties. The examples given are in C# but you can use any .NET language such as VB.NET to achieve the same.
## **Get Number of Pages in a PDF File**
When working with documents, you often want to know how many pages they contain. With Aspose.PDF this takes no more than two lines of code.

To get the number of pages in a PDF file:

1. Open the PDF file using the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class.
1. Then use the [PageCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/pagecollection) collection's Count property (from the Document object) to get the total number of pages in the document.

The following code snippet shows how to get the number of pages of a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-GetNumberofPages-GetNumberofPages.cs" >}}
### **Get page count without saving the document**
Sometimes we generate the PDF files on the fly and during PDF file creation, we may come across the requirement (creating Table Of Contents etc.) to get page count of PDF file without saving the file over system or stream. So in order to cater to this requirement, a method **ProcessParagraphs(...)** has been introduced in Document class. Please take a look over the following code snippet which shows the steps to get page count without saving the document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-GetPageCount-GetPageCount.cs" >}}
## **Get Page Properties**
Each page in a PDF file has a number of properties, such as the width, height, bleed-, crop- and trimbox. Aspose.PDF allows you to access these properties.
### **Understanding Page Properties: the Difference between Artbox, BleedBox, CropBox, MediaBox, TrimBox and Rect property**
- **Media box**: The media box is the largest page box. It corresponds to the page size (for example A4, A5, US Letter, etc.) selected when the document was printed to PostScript or PDF. In other words, the media box determines the physical size of the media on which the PDF document is displayed or printed.
- **Bleed box**: If the document has bleed, the PDF will also have a bleed box. Bleed is the amount of color (or artwork) that extends beyond the edge of a page. It is used to make sure that when the document is printed and cut to size (“trimmed”), the ink will go all the way to the edge of the page. Even if the page is mistrimmed - cut slightly off the trim marks - no white edges will appear on the page.
- **Trim box**: The trim box indicates the final size of a document after printing and trimming.
- **Art box**: The art box is the box drawn around the actual contents of the pages in your documents. This page box is used when importing PDF documents in other applications.
- **Crop box**: The crop box is the “page” size at which your PDF document is displayed in Adobe Acrobat. In normal view, only the contents of the crop box are displayed in Adobe Acrobat.
  For detailed descriptions of these properties, read the Adobe.Pdf specification, particularly 10.10.1 Page Boundaries.
- **Page.Rect**: the intersection (commonly visible rectangle) of the MediaBox and DropBox. The picture below illustrates these properties.

For further details, please visit [this page](http://www.enfocus.com/manuals/ReferenceGuide/PP/10/enUS/en-us/concept/c_aa1095731.html).
### **Accessing Page Properties**
The [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) class provides all the properties related to a particular PDF page. All the pages of the PDF files are contained in the of the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's [PageCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/pagecollection) collection.

From there, it is possible to access either individual Page objects using their index, or loop through the collection, using a foreach loop, to get all pages. Once an individual page is accessed, we can get its properties. The following code snippet shows how to get page properties.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-GetProperties-GetProperties.cs" >}}
## **Get a Particular Page of the PDF File**
Aspose.PDF allows you to [split a PDF into individual pages](/pdf/net/manipulate-page-in-a-pdf-file/) and save them as PDF files. Getting a specified page in a PDF file and saving it as a new PDF is a very similar operation: open the source document, access the page, create a new document and add the page to this.

The [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's [PageCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/pagecollection) holds the pages in the PDF file. To get a particular page from this collection:

1. Specify the page index using the Pages property.
1. Create a new [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object.
1. Add the [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) object to the new [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object.
1. Save the output using [Save](https://apireference.aspose.com/net/pdf/aspose.pdf.document/save/methods/4) method.

The following code snippet shows how to get a particular page from a PDF file and save it as a new file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-GetParticularPage-GetParticularPage.cs" >}}
## **Determine Page Color**
The [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) class provides the properties related to a particular page in a PDF document, including what type of colour - RGB, black and white, grayscale or undefined - the page uses.

All the pages of the PDF files are contained by the [PageCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/pagecollection) collection. The ColorType property specifies the color of elements on page. To get or determine the color information for particular PDF page, use the [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) object's ColorType property. The following code snippet shows how to iterate through individual page of PDF file to get color information.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Pages-DeterminePageColor-DeterminePageColor.cs" >}}
