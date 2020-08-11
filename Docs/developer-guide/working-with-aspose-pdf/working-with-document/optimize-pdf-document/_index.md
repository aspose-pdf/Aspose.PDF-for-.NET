---
title: Optimize PDF Document
type: docs
weight: 40
url: /net/optimize-pdf-document/
---

## **Optimize PDF Document**
A PDF document may sometimes contain additional data. Reducing the size of a PDF file will help you optimize network transfer and storage. This is especially handy for publishing on web pages, sharing on social networks, sending by e-mail, or archiving in storage. We can use several techniques to optimize PDF:

- Optimize page content for online browsing
- Shrink or compress all images
- Enable reusing page content
- Merge duplicate streams
- Unembed fonts
- Remove unused objects 
- Remove flattening form fields 
- Remove or flatten annotations
## **Optimize PDF Document for the Web**
Optimization, or linearization for Web, refers to the process of making a PDF file suitable for online browsing using a web browser. To optimize a file for web display:

1. Open the input document in an [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object.
1. Use the [Optimize](https://apireference.aspose.com/net/pdf/aspose.pdf/document/methods/optimize) method.
1. Save the optimized document using the [Save](https://apireference.aspose.com/net/pdf/aspose.pdf/document/methods/save) method.

The following code snippet shows how to optimize a PDF document for the web.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-OptimizeDocument-OptimizeDocument.cs" >}}
## **Optimize PDF File Size**
The [OptimizeResources()](https://apireference.aspose.com/net/pdf/aspose.pdf/document/methods/optimizeresources) method allows you to reduce the document size by weeding out the unnecessary information. By default, this method works as follows:

- Resources that are not used on the document pages are removed 
- Equal resources are joined into one object
- Unused objects are deleted

The snippet below is an example. Note, though, that this method cannot guarantee document shrinking.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-ShrinkDocuments-ShrinkDocuments.cs" >}}
## **Optimization Strategy Management**
We can also customize the optimization strategy. Currently, the [OptimizeResources()](https://apireference.aspose.com/net/pdf/aspose.pdf.document/optimizeresources/methods/1) method uses 5 techniques. These techniques can be applied using the OptimizeResources() method with the [OptimizationOptions](https://apireference.aspose.com/net/pdf/aspose.pdf.optimization/optimizationoptions) parameter.
### **Shrinking or Compressing All Images**
We have two ways to work with images: reduce image quality and/or change their resolution. In any case, **ImageCompressionOptions** should be applied. In the following example, we shrink images by reducing **ImageQuality** to 50.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Images-ShrinkImages-ShrinkImages.cs" >}}

Another way is to resize the images with a lower resolution. In this case, we should set ResizeImages to true and MaxResolution to the appropriate value.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Images-ResizeImages-ResizeImages.cs" >}}

Another important issue is the execution time. But again, we can manage this setting too. Currently, we can use two algorithms - Standard and Fast. To control the execution time we should set a [Version](https://apireference.aspose.com/net/pdf/aspose.pdf.optimization/imagecompressionoptions/properties/version) property. The following snippet demonstrates the Fast algorithm:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Images-FastShrinkImages-FastShrinkImages.cs" >}}
### **Removing Unused Objects**
A PDF document sometimes contains the PDF objects that are not referenced from any other object in the document. This may happen, for example, when a page is removed from the document page tree but the page object itself isn't removed. Removing these objects doesn't make the document invalid but rather shrinks it.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-RemoveUnusedObjects-RemoveUnusedObjects.cs" >}}
### **Removing Unused Streams**
Sometimes the document contains the unused resource streams. These streams are not "unused objects" because they are referenced from a page resource dictionary. Thus, they are not removed with a "remove unused objects" method. But these streams are never used with the page contents. This may happen in cases when an image has been removed from the page but not from the page resources. Also, this situation often occurs when pages are extracted from the document and document pages have "common" resources, that is, the same Resources object. Page contents are analyzed in order to determine if a resource stream is used or not. Unused streams are removed. It sometimes decreases the document size. The use of this technique is similar to the previous step:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-RemoveUnusedStreams-RemoveUnusedStreams.cs" >}}
### **Linking Duplicate Streams**
Some documents can contain several identical resource streams (like images, for instance). This may happen, say when a document is concatenated with itself. The output document contains two independent copies of the same resource stream. We analyze all resource streams and compare them. If streams are duplicated, they are merged, that is, only one copy is left. The references are changed appropriately, and the copies of the object are removed. In some cases, it helps to decrease the document size.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-LinkDuplicateStreams-LinkDuplicateStreams.cs" >}}

Additionally, we can use [AllowReusePageContent](https://apireference.aspose.com/net/pdf/aspose.pdf.optimization/optimizationoptions/properties/allowreusepagecontent) settings. If this property is set to true, the page content will be reused when optimizing the document for identical pages.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-AllowResusePageContent-AllowResusePageContent.cs" >}}
## **Unembedding Fonts**
If the document uses embedded fonts, it means that all font data is stored in the document. The advantage is that the document is viewable regardless of whether the font is installed on the user's machine or not. But embedding fonts makes the document larger. The unembed fonts method removes all embedded fonts. Thus, the document size decreases but the document itself may become unreadable if the correct font is not installed.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-UnembedFonts-UnembedFonts.cs" >}}

The optimization resources apply these methods to the document. If any of these methods are applied, the document size will most probably decrease. If none of these methods is applied, the document size will not change which is obvious.
## **Additional Ways to Reduce the PDF Document Size**
### **Removing or Flattening Annotations**
Annotations can be deleted when they are unnecessary. When they are needed but do not require additional editing, they can be flattened. Both of these techniques will reduce the file size.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-FlattenAnnotation-FlattenAnnotation.cs" >}}
### **Removing Form Fields**
If the PDF document contains AcroForms, we can try to reduce the file size by flattening form fields.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Forms-FlattenForms-FlattenForms.cs" >}}
### **Convert a PDF from RGB colorspace to grayscale**
A PDF file comprises Text, Image, Attachment, Annotations, Graphs, and other objects. You may come across a requirement to convert a PDF from RGB colorspace to grayscale so that it would be faster while printing those PDF files. Also, when the file is converted to grayscale, the document size is reduced too, but it can just as well cause a decrease in the document quality. This feature is currently supported by the Pre-Flight feature of Adobe Acrobat, but when talking about Office automation, Aspose.PDF is an ultimate solution to provide such leverages for document manipulations. In order to accomplish this requirement, the following code snippet can be used.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-ConvertFromRGBToGrayscale-ConvertFromRGBToGrayscale.cs" >}}
