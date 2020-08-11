---
title: Extract Text from PDF
type: docs
weight: 20
url: /java/extract-text-from-pdf/
---

## **Extract Text From All the Pages of a PDF Document**
One of the most common tasks that developers need to perform is to extract text from a PDF document. In this example, Aspose.PDF is used to extract text from all pages in a PDF document.

To extract all text in a PDF:

1. Create a TextAbsorber object.
1. Open the PDF using the [Document](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Document) class.
1. Call the [Pages](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/PageCollection) collection's [accept(..)](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/pagecollection/methods/accept\(com.aspose.pdf.ImagePlacementAbsorber\)/) method.
   The TextAbsorber class absorbs the text from the document and returns it in the Text property.

The following code snippet shows how to extract text from a PDF.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-ExtractTextFromAllThePagesOfPDFDocument-.java" >}}


To extract text from a specific page, specify the page using its index against the [accept(..)](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/pagecollection/methods/accept\(com.aspose.pdf.ImagePlacementAbsorber\)/) method:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Text-ExtractTextFromAllThePagesOfPDFDocument-Info1.java" >}}


If the heap memory is limited, then please try cleaning the Aspose caches. Try using the following method.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Text-ExtractTextFromAllThePagesOfPDFDocument-Info2.java" >}}


## **Extract Text from PDF using TextDevice**
TextDevice class allows you to extract text from a particular page of a PDF file. In order to do that, you need to create a [Document](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Document) object, so that you can access the particular page of the PDF file. You also need to create an object of TextDevice class. This class provides a method named process(..), which allows you to extract the text from a particular page. In the following example, we have selected the first page to extract the text and have saved the output in a Text file.
### **Extract text from particular page**
The following code snippet shows you how to extract text from a particular page using a text device.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-ExtractTextFromPDFUsingTextDevice-ExtractTextFromParticularPage.java" >}}


### **Extract text from all pages of PDF**
The following code snippet shows you how to iterate through all the pages of PDF file and extract the text into a text file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-ExtractTextFromPDFUsingTextDevice-ExtractTextFromAllPagesOfPDF.java" >}}


## **Extract Text from an particular page region**
TextAbsorber class provides the capability to extract text from a particular/all pages of a PDF document. This class returns the extracted text using the getText() method. However, if we have the requirement to extract text from a particular page region, we can use [Rectangle](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Rectangle) property of TextSearchOptions. The setRectangle(..) method takes Rectangle object as an argument and while using this method, we can specify the region of the page from which we need to extract the text.

The [accept(..)](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/pagecollection/methods/accept\(com.aspose.pdf.ImagePlacementAbsorber\)/) method of a page is called to extract the text. Create objects of [Document](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Document) and TextAbsorber classes. Call [accept(..)](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/pagecollection/methods/accept\(com.aspose.pdf.ImagePlacementAbsorber\)/) method on the individual page of [Document](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Document) object. The Index is the particular page number from where text needs to be extracted. You can get text from the getText() method of the TextAbsorber class.

The following code snippet shows you how to extract text from an individual page.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-ExtractTextFromAnParticularPageRegion-.java" >}}
## **Extract text based on columns**
A PDF file may comprise of Text, Image, Annotations, Attachments, Graphs etc elements and Aspose.PDF for Java offers the feature to Add as well as manipulate all of these elements. This API is remarkable when comes to Text addition and extraction from PDF document and we may come across a scenario where a PDF document is comprised of more than one columns (multi-column) PDF document and we need to extract the page contents while honoring the same layout, then Aspose.PDF for Java is the right choice to accomplish this requirement. One approach is to reduce the font size of contents inside the PDF document and then perform text extraction. The following code snippet can be used to fulfill this requirement.

The following code snippet shows the steps to reduce text size and then try extracting text from PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-ExtractTextBasedOnColumns-ExtractTextBasedOnColumns.java" >}}
### **Second approach - Using setScaleFactor(..) method**
In this new release, we also have introduced several improvements in TextAbsorber and in the internal text formatting mechanism. So now during the text extraction using ‘Pure’ mode, you may call setScaleFactor(..) method and it can be another approach to extract text from multi-column PDF document besides the above-stated approach. This scale factor may be set to adjust the grid which is used for the internal text formatting mechanism during text extraction. Specifying the ScaleFactor values between 1 and 0.1 (including 0.1) has the same effect as font reducing.

Specifying the ScaleFactor values between 0.1 and -0.1 is treated as zero value, but it makes the algorithm to calculate scale factor needed during extracting text automatically. The calculation is based on average glyph width of the most popular font on the page, but we cannot guarantee that in extracted text no string of column reaches the start of the next column. Please note that if ScaleFactor value is not specified, the default value of 1.0 will be used. It means no scaling will be carried out. If the specified ScaleFactor value is more than 10 or less than -0.1, the default value of 1.0 will be used.

We propose the usage of auto-scaling (ScaleFactor = 0) when processing a large number of PDF files for text content extraction. Or manually set redundant reducing of grid width ( about ScaleFactor = 0.5). However, you must not determine whether scaling is necessary for concrete documents or not. If You set redundant reducing of grid width for the document (that doesn't need in it), the extracted text content will remain fully adequate. Please take a look over the following code snippet.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-text-ExtractTextBasedOnColumns-UsingSetScaleFactorMethod.java" >}}


Please note that there is no direct correspondence between the new ScaleFactor and the old coefficient of manually font reducing. However, by default algorithm takes into account the value of font size that has already reduced due to some internal reasons. For example, reducing font size from 10 to 7 has the same effect as setting the scale factor to 5/8 (= 0.625).
## **Extract Rotated Text and Rotation Angle of Text Characters**
In case a PDF has rotated text inside and you need to extract it as well as determine the rotation angle of a text character, you can use functionality like in following code snippet.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-pdf-Text-ExtractRotatedText.java" >}}
