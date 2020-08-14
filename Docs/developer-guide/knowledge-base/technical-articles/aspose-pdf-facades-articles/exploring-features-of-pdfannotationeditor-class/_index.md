---
title: Exploring features of PdfAnnotationEditor class
type: docs
weight: 210
url: /net/exploring-features-of-pdfannotationeditor-class/
---

{{% alert color="primary" %}}

[Aspose.Pdf.Facades namespace](https://apireference.aspose.com/pdf/net/aspose.pdf.facades) has introduced a new class named [PdfAnnotationEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfannotationeditor). This class is used to manipulate or edit existing annotations in a PDF document. In this article, we’ll focus on this particular class, and explore the features provided by this class.

{{% /alert %}}
## **Implementation details**
We can add annotations of different types using [PdfContentEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfcontenteditor) class, but when it comes to edit the annotations, [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) includes a complete set of methods in a separate class called [PdfAnnotationEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfannotationeditor). We can perform variety of functions on annotations, like Modify, Delete, Import, Export, Flatten, and Extract, using this class.

[ModifyAnnotations](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfannotationeditor/methods/modifyannotations/index) method allows you to change basic attributes of an annotation i.e. Subject, Modified date, Author, Annotation color, and Open flag. You can also set Author directly by using [ModifyAnnotations](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfannotationeditor/methods/modifyannotations/index) method. This class also provides two overloaded methods to delete annotations. The first method called [DeleteAnnotations](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfannotationeditor/methods/deleteannotations/index) deletes all the annotations from a PDF file, while second method allows you to delete all the annotations of a specified type.

Importing and exporting annotations is another set of features provided by [PdfAnnotationEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfannotationeditor) class. You can not only import and export annotations to an XFDF file, but also import annotations from another PDF file as well. This class also helps you extract annotations into an ArrayList.

We can simply say that by providing all the annotation editing related methods in a single class, Aspose.Pdf.Facades have provided a great ease of manipulating annotations. The following code snippet shows you how to use different methods of PdfAnnotationEditor class to manipulate annotations.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-PdfAnnotationEditorFeatures-PdfAnnotationEditorFeatures.cs" >}}
