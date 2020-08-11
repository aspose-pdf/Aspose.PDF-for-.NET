---
title: Working with Annotations - facades
type: docs
weight: 90
url: /java/working-with-annotations-facades/
---

## **Add Annotation in an Existing PDF File (facades)**
{{% alert color="primary" %}} 

[**PdfContentEditor**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfContentEditor) allows you to add annotations of different types in an existing PDF file. You can use the respective method to add a particular annotation. For example, in the following code snippet, we have used [**createFreeText**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfContentEditor#createFreeText-java.awt.Rectangle-java.lang.String-int-) method to add FreeText type annotation. Any type of annotations can be added to the PDF file in the same way. First of all, you need to create an object of type [**PdfContentEditor**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfContentEditor) and bind input PDF file using bindPdf method. Secondly, you have to create a Rectangle object to specify the area of the annotation. After that, you can call [**createFreeText**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfContentEditor#createFreeText-java.awt.Rectangle-java.lang.String-int-) method to add FreeText annotation, and then use save method to save the updated PDF file.

{{% /alert %}} 
### **Add FreeText Annotation**
The following code snippet shows you how to add an annotation in a PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Annotations-AddAnnotationInAnExistingPDFFile-.java" >}}
## **Delete All Annotations by Specified Type (facades)**
You can use [**PdfAnnotationEditor**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfAnnotationEditor) class to delete all the annotations, by a specified annotation type, from the existing PDF file. In order to do that you need to create a [**PdfAnnotationEditor**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfAnnotationEditor) object and bind input PDF file using bindPdf method. After that, call [**deleteAnnotations**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfAnnotationEditor#deleteAnnotation-java.lang.String-) method, with the string parameter, to delete all the annotations from the file; the string parameter represents the annotation type to be deleted. Finally, use save method to save the updated PDF file.

The following code snippet shows you how to delete all annotations by specified annotation type.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Annotations-DeleteAllAnnotationsBySpecifiedType-.java" >}}
## **Export Annotations from PDF File to XFDF (facades)**
{{% alert color="primary" %}} 

The exportAnnotationXfdf method allows you to export annotations from a PDF file. In order to export annotations, you need to create [**PdfAnnotationEditor**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfAnnotationEditor) object and bind PDF file using bindPdf method. After that, you need to create an int[] array of annotation types which you want to export from PDF file. You can then use exportAnnotationXfdf method to import the annotations. And finally, close the objects.

{{% /alert %}} 

The following code snippet shows you how to export annotations to XFDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-Annotations-ExportAnnotationsFromPDFFileToXFDF-.java" >}}
