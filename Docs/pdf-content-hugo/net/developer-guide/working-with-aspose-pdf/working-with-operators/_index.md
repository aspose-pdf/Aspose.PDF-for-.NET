---
title: Working with Operators
type: docs
weight: 80
url: /net/working-with-operators/
---

## **Introduction to the PDF Operators and Their Usage**
An operator is a PDF keyword specifying some action that shall be performed, such as painting a graphical shape on the page. An operator keyword is distinguished from a named object by the absence of an initial solidus character (2Fh). Operators are meaningful only inside the content stream.

A content stream is a PDF stream object whose data consists of instructions describing the graphical elements to be painted on a page. More details about PDF operators can be found in the [PDF specification](http://www.adobe.com/devnet/pdf/pdf_reference.html).
### **Implementation Details**
This topic explains how to use operators with Aspose.PDF. The selected example adds an image into a PDF file to illustrate the concept. To add an image in a PDF file, different operators are needed. This example uses [GSave](https://apireference.aspose.com/net/pdf/aspose.pdf.ioperatorselector/visit/methods/28), [ConcatenateMatrix](https://apireference.aspose.com/net/pdf/aspose.pdf.ioperatorselector/visit/methods/10), [Do](https://apireference.aspose.com/net/pdf/aspose.pdf.ioperatorselector/visit/methods/14), and [GRestore](https://apireference.aspose.com/net/pdf/aspose.pdf.ioperatorselector/visit/methods/26).

- The **GSave** operator saves the PDF's current graphical state.
- The **ConcatenateMatrix** (concatenate matrix) operator is used to define how an image should be placed on the PDF page.
- The **Do** operator draws the image on the page.
- The **GRestore** operator restores the graphical state.

To add an image into a PDF file:

1. Create a [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object and open the input PDF document.
1. Get the particular page the image is going to be added to.
1. Add the image into the page’s Resources collection.
1. Use the operators to place the image on the page:
   1. First, use the GSave operator to save the current graphical state.
   1. Then use the ConcatenateMatrix operator to specify where the image is to be placed.
   1. Use the Do operator to draw the image on the page.
1. Finally, use GRestore operator to save the updated graphical state.

The following code snippet shows how to use PDF operators.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Operators-PDFOperators-PDFOperators.cs" >}}
## **Draw XForm on Page using Operators**
This topic demonstrates how to use the GSave/GRestore operators, the ContatenateMatrix operator to position an xForm and the Do operator to draw an xForm on a page.

The code below wraps a PDF file's existing contents with the GSave/GRestore operator pair. This approach helps get the initial graphics state at the and of the existing contents. Without this approach, undesirable transformations might remain at the end of the existing operator chain.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Operators-DrawXFormOnPage-DrawXFormOnPage.cs" >}}
## **Remove Graphics Objects using Operator Classes**
The operator classes provide great features for PDF manipulation. When a PDF file contains graphics that cannot be removed using the [PdfContentEditor](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdfcontenteditor) class' DeleteImage(..) method, the operator classes can be used to remove them instead.

The following code snippet shows how to remove graphics. Please note that if the PDF file contains text labels for the graphics, they might persist in the PDF file, using this approach. Therefore search the graphic operators for an alternate method to delete such images.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Operators-RemoveGraphicsObjects-RemoveGraphicsObjects.cs" >}}
