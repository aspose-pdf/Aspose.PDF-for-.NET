---
title: Manipulate PDF Document
type: docs
weight: 30
url: /net/manipulate-pdf-document/
---

## **Validate PDF Document for PDF A Standard (A 1A and A 1B)**
To validate a PDF document for PDF/A-1a or PDF/A-1b compatibility, use the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class Validate method. This method allows you to specify the name of the file in which the result is to be saved and the required validation type [PdfFormat](https://apireference.aspose.com/net/pdf/aspose.pdf/pdfformat) enumeration : PDF_A_1A or PDF_A_1B.

{{% alert color="primary" %}}

The output XML format is custom Aspose format. The XML contains a collection of tags with the name Problem; each tag contains the details of a particular problem. The Problem tag's ObjectID attribute represents the ID of the particular object this problem is related to. The Clause attribute represents a corresponding rule in the PDF specification.

{{% /alert %}}

The following code snippet shows you how to validate PDF document for PDF/A-1A.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-ValidatePDFAStandard-ValidatePDFAStandard.cs" >}}

The following code snippet shows you how to validate PDF document for PDF/A-1b.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-ValidatePDFABStandard-ValidatePDFABStandard.cs" >}}

{{% alert color="primary" %}}

Aspose.PDF for .NET can be used to determine if the loaded document is a valid PDF and also [if its encrypted or not](https://docs.aspose.com/pdf/net/set-privileges-encrypt-and-decrypt-pdf-file/). In order to further extend the capabilities of Document class, **IsPdfaCompliant** property is added to determine if the input file is PDF/A compliant and a property named **PdfaFormat** to identify the PDF/A format are introduced.

{{% /alert %}}

## **Working with TOC**
### **Add TOC to Existing PDF**
Aspose.PDF API allows you to add a table of content either when creating a PDF, or to an existing file. The ListSection class in the Aspose.Pdf.Generator namespace allows you to create a table of contents when creating a PDF from scratch. To add headings, which are elements of the TOC, use the Aspose.Pdf.Generator.Heading class.

To add a TOC to an existing PDF file, use the Heading class in the Aspose.Pdf namespace. The Aspose.Pdf namespace can both create new and manipulate existing PDF files. To add a TOC to an existing PDF, use the Aspose.Pdf namespace. The following code snippet shows how to create a table of contents inside an existing PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-AddTOC-AddTOC.cs" >}}
### **Set different TabLeaderType for different TOC Levels**
Aspose.PDF also allows setting different TabLeaderType for different TOC levels. You need to set LineDash property of FormatArray with the appropriate value of TabLeaderType enum as following.

**C#**

{{< highlight java >}}

 string outFile = "TOC.pdf";

Aspose.Pdf.Document doc = new Aspose.Pdf.Document();

Page tocPage = doc.Pages.Add();

TocInfo tocInfo = new TocInfo();

//set LeaderType

tocInfo.LineDash = TabLeaderType.Solid;

TextFragment title = new TextFragment("Table Of Contents");

title.TextState.FontSize = 30;

tocInfo.Title = title;

//Add the list section to the sections collection of the Pdf document

tocPage.TocInfo = tocInfo;

//Define the format of the four levels list by setting the left margins

//and

//text format settings of each level

tocInfo.FormatArrayLength = 4;

tocInfo.FormatArray[0].Margin.Left = 0;

tocInfo.FormatArray[0].Margin.Right = 30;

tocInfo.FormatArray[0].LineDash = TabLeaderType.Dot;

tocInfo.FormatArray[0].TextState.FontStyle = FontStyles.Bold | FontStyles.Italic;

tocInfo.FormatArray[1].Margin.Left = 10;

tocInfo.FormatArray[1].Margin.Right = 30;

tocInfo.FormatArray[1].LineDash = TabLeaderType.None;

tocInfo.FormatArray[1].TextState.FontSize = 10;

tocInfo.FormatArray[2].Margin.Left = 20;

tocInfo.FormatArray[2].Margin.Right = 30;

tocInfo.FormatArray[2].TextState.FontStyle = FontStyles.Bold;

tocInfo.FormatArray[3].LineDash = TabLeaderType.Solid;

tocInfo.FormatArray[3].Margin.Left = 30;

tocInfo.FormatArray[3].Margin.Right = 30;

tocInfo.FormatArray[3].TextState.FontStyle = FontStyles.Bold;

//Create a section in the Pdf document

Page page = doc.Pages.Add();

//Add four headings in the section

for (int Level = 1; Level <= 4; Level++)

{

    Aspose.Pdf.Heading heading2 = new Aspose.Pdf.Heading(Level);

    TextSegment segment2 = new TextSegment();

    heading2.Segments.Add(segment2);

    heading2.IsAutoSequence = true;

    heading2.TocPage = tocPage;

    segment2.Text = "Sample Heading" + Level;

    heading2.TextState.Font = FontRepository.FindFont("Arial Unicode MS");

    //Add the heading into Table Of Contents.

    heading2.IsInList = true;

    page.Paragraphs.Add(heading2);

}

// save the Pdf

doc.Save(outFile);

{{< /highlight >}}
### **Hide Page Numbers in TOC**
In case if you do not want to display page numbers, along with the headings in TOC, you can use [IsShowPageNumbers](https://apireference.aspose.com/net/pdf/aspose.pdf/tocinfo/properties/isshowpagenumbers) property of [TOCInfo](https://apireference.aspose.com/net/pdf/aspose.pdf/tocinfo/) Class as false. Please check following code snippet to hide page numbers in the table of contents:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-HidePageNumbersInTOC-1.cs" >}}
### **Customize Page Numbers while adding TOC**
It is common to customize the page numbering in the TOC while adding TOC in a PDF document. For example, we may need to add some prefix before page number like P1, P2, P3 and so on. In such a case, Aspose.PDF for .NET provides PageNumbersPrefix property of TocInfo class that can be used to customize page numbers as shown in the following code sample.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-CustomizePageNumbesWhileAddingTOC-CustomizePageNumbesWhileAddingTOC.cs" >}}

## **How to set PDF expiry date**
We apply access privileges on PDF files so that a certain group of users can access particular features/objects of PDF documents. In order to restrict the PDF file access, we usually apply encryption and we may have a requirement to set PDF file expiration, so that the user accessing/viewing the document gets a valid prompt regarding PDF file expiry.

In order to accomplish the above stated requirement, we can use **JavascriptAction** object. Please take a look over the following code snippet.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-SetExpiryDate-SetExpiryDate.cs" >}}
## **Determine Progress of PDF File Generation**
A customer asked us to add a feature that allows developers to determine the progress of PDF file generation. Here's the response to that request.

The [DocSaveOptions](https://apireference.aspose.com/net/pdf/aspose.pdf/docsaveoptions) class CustomerProgressHandler allows you to determine how PDF generation is going. The handler has the following types:

- DocSaveOptions.ConversionProgessEventHandler
- DocSaveOptions.ProgressEventHandlerInfo
- DocSaveOptions.ProgressEventType)

The code snippets below shows how to use CustomerProgressHandler.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-DetermineProgress-DetermineProgress.cs" >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-DetermineProgress-ShowProgressOnConsole.cs" >}}
