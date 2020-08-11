---
title: Add, Delete and Get Annotation - Facades
type: docs
weight: 10
url: /cpp/add-delete-and-get-annotation-facades/
---

## **Add Annotation in an existing PDF file using PdfContentEditor**
**PdfContentEditor** allows you to add different types of annotations in an existing PDF file. You can use the respective method of **PdfContentEditor** class to add a particular type of annotation in an existing PDF document. For example, in the following code snippets, we have used **CreateText(...)** and **CreateFreeText(...)** methods, to add comments and free text annotation in the existing PDF respectively. You need to do the following steps, in order to add annotations using **PdfContentEditor** class:

- Create an object of Facades::PdfContentEditor.
- Use **BindPdf(...)** method to load an existing PDF.
- Call respective method to create annotation. e.g **CreateText(...),CreateFreeText(...), etc.**
- Save the PDF document by using the **Save(...)** method.
### **Add Comments to Existing PDF Document**
The following code snippet shows you how to add a comment in an existing PDF file.

{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Annotations-AddAnnotation-AddAnnotation.cpp" >}}
## **Delete All Annotations from an existing PDF**
Aspose.PDF for C++ has also provided the **PdfAnnotationEditor** class, which enables you to delete all annotations from a PDF document. In order to delete all annotations from the existing PDF, you need to create an object of the **PdfAnnotationEditor** class and open the existing document. After that, you can use the **DeleteAnnotations(...)** method of the PdfAnnotationEditor class to delete the annotations. Following code snippet shows you the usage of PdfAnnotationEditor to serve the purpose:



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Annotations-DeleteAllAnnotations-1.cpp" >}}
## **Delete All Annotations by Specified Type**
You can use **PdfAnnotationEditor** class to delete all the annotations, by a specified annotation type, from the existing PDF file. In order to do that you need to create a **PdfAnnotationEditor** object and bind input PDF file using the **BindPdf** method. After that, call **DeleteAnnotations** method, with the string parameter, to delete all the annotations from the file; the string parameter represents the annotation type to be deleted. Finally, use the **Save** method to save the updated PDF file. The following code snippet shows you how to delete all annotations by specified annotation type.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Annotations-DeleteParticularAnnotation-1.cpp" >}}
## **Update/Modify Annotations in an Existing PDF File**
In order to update modify an annotation in a PDF document, you can use the **ModifyAnnotations(...)** method of the **PdfAnnotationEditor** class which takes an Annotation object along with the start and end index of annotations. The following code snippet will demonstrate the usage of **ModifyAnnotations(...)** method:

{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Annotations-ModifyAnnotations-1.cpp" >}}
## **Import Annotations from XFDF into PDF File**
**ImportAnnotationFromXfdf** method of **PdfAnnotationEditor** class, allows you to import annotations to a PDF file. In order to import annotations, you need to create a **PdfAnnotationEditor** object and bind PDF file using the **BindPdf** method. After that, you need to create an enumeration of annotation types that you want to import to PDF file. You can then use the **ImportAnnotationFromXfdf** method to import the annotations. And finally, save the updated PDF file using the **Save** method of the **PdfAnnotationEditor** object. The following code snippet shows you how to import annotations from the XFDF file.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Annotations-ImportAnnotations-1.cpp" >}}
## **Export Annotations from PDF File to XFDF**
The **ExportAnnotationXfdf** method allows you to export annotations from a PDF file. In order to export annotations, you need to create a **PdfAnnotationEditor** object and bind PDF file using the **BindPdf** method. After that, you need to create an enumeration of annotation types that you want to export from PDF file. You can then use the **ExportAnnotationXfdf** method to import the annotations. And finally, save the updated PDF file using the **Save** method of the **PdfAnnotationEditor** object. The following code snippet shows you how to export annotations to the XFDF file.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Annotations-ExportAnnotations-1.cpp" >}}
## **Extract Annotations from an Existing PDF File**
**ExtractAnnotations** method allows you to extract annotations from a PDF file. In order to extract annotations, you need to create a **PdfAnnotationEditor** object and bind PDF file using the **BindPdf** method. After that, you need to create an enumeration of annotation types that you want to extract from PDF files. You can then use the **Extract** **Annotations** method to extract the annotations to an ArrayPtr. After that, you can loop through this list and get individual annotations. And finally, save the updated PDF file using the **Save** method of the **PdfAnnotationEditor** object. The following code snippet shows you how to extract annotations from PDF files.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Annotations-ExtractAnnotations-1.cpp" >}}
