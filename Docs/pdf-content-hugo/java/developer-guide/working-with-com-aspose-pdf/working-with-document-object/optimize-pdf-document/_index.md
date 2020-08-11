---
title: Optimize PDF Document
type: docs
weight: 40
url: /java/optimize-pdf-document/
---

## **Optimize PDF Document for the Web**
Optimization or linearization refers to the process of making a PDF file suitable for online browsing using a web browser. Aspose.PDF supports this process.

To optimize a PDF for web display:

1. Open the input document in a [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object.
1. Use the [optimize()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#optimize--) method.
1. Save the optimized document using the save(..) method.

The following code snippet shows how to optimize a PDF document for the web.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-DocumentObject-OptimizePDFDocumentForWeb-.java" >}}
## **Optimize PDF File Size**
This topic explains the steps to optimize/reduce the PDF file size. Aspose.PDF API provides the OptimizationOptions class that gives the flexibility to optimize output PDF by removing unnecessary objects and compressing PDF files having images. Both these options are elaborated in the following sections.
### **Remove Unnecessary Objects**
We can optimize the size of PDF documents by removing duplicate and unused objects. The following code snippet shows how.

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-DocumentObject-OptimizePDFFileSize-removeUnnecessaryObjects.java" >}}
### **Compressing PDF with Images**
If the source PDF file contains images, consider compressing the images and setting their quality. In order to enable image compression, pass true as an argument to the setCompressImages(..) method. All the images in a document will be re-compressed. The compression is defined by the setImageQuality(..) method, which is the value of the quality in percent. 100% is unchanged quality and image size. To decrease image size, pass an argument of less than 100 to the setImageQuality(..) method.

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-DocumentObject-OptimizePDFFileSize-compressingPDFWithImages.java" >}}
### **Release Fonts**
A text-based PDF file can be further optimized by releasing, or un-embedding, embedded fonts. The UnembedFonts(..) method in the OptimizationOptions class is used for this purpose. If true is passed as an argument to this method, any fonts in the PDF file are released and no longer embedded.

{{< highlight java >}}

 opt.setUnembedFonts(true);

{{< /highlight >}}
#### **Information About the optimizeResources() method**
The [optimizeResources()](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#optimizeResources--) method allows you to decrease the document size by eliminating unnecessary information. But this method does not guarantee that a document will shrink.

An instance of OptimizationOptions is passed as an argument to OptimizeResources() method.

Available optimization methods are:

- **Remove unused objects** 
  Sometimes PDF document contains PDF objects which are not referenced from any other object in the document. This may happen for example when a page is removed from the document page tree but the page object itself isn't removed. Removing these objects doesn't make document invalid but shrinks it.
- **Remove unused streams** 
  Sometimes a document contains unused resource streams. These streams are not "unused objects" because they are referenced from a page's resource dictionary. Thus they are not eliminated by the "remove unused objects" method. But these streams are never used by the page contents. This may happen in cases where an image has been removed from the page but not from the page resources. Also, this situation often occurs when pages are extracted from the document and document pages have "common" resources, that is, the same Resources object. Page contents are analyzed in order to determine if a resource stream is used or not. Unused streams are removed. Sometimes this decreases the document size.
- **Link duplicate streams** 
  Sometimes a document contains several identical resource streams (for example images). This may happen for example when a document is concatenated with itself. The output document contains two independent copies of the same resource stream. We analyze all resource streams and compare them. If streams are duplicated they are merged, that is, only one copy is left, references are changed appropriately and copies of the object are removed. Sometimes this decreases the document size.
- **Compress images** 
  Change the compression level of JPEG images to decrease the size of images. But this also makes the image quality worse.
- **Unembed fonts** 
  If the document uses embedded fonts it means that all font data is placed in the document. The advantage is that the document is viewable regardless of whether the font is installed on the user's machine or not. But embedding fonts makes the document larger. The unembed fonts method removes all embedded fonts. This decreases the document size but the document may become unreadable if the correct font is not installed.

The optimization resources apply these methods to the document. If any of these methods apply, the document size will probably decrease. If none of these methods apply, the document size will not change.
## **Convert a PDF from RGB colorspace to Grayscale**
A PDF file is comprised of Text, Image, Attachment, Annotations, Graphs and other objects. You may come across a requirement to convert a PDF from RGB colorspace to Grayscale so that it would be faster while printing those PDF files. Also when the file is converted to Grayscale, the size of the document is also reduced but with this change, the quality of the document may drop. Currently, this feature is supported by the Pre-Flight feature of Adobe Acrobat, but when talking about Office automation, Aspose.PDF is an ultimate solution to provide such leverages for document manipulation.

In order to accomplish this requirement, the following code snippet can be used.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-ConvertPDFFromRGBColorspaceToGrayscale-.java" >}}
