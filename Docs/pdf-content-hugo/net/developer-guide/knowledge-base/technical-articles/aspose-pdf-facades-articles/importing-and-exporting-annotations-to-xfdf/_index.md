---
title: Importing and Exporting Annotations to XFDF
type: docs
weight: 190
url: /net/importing-and-exporting-annotations-to-xfdf/
---

{{% alert color="primary" %}} 

XFDF stand for XML Forms Data Format. It is an XML based file format. This file format is used to represent form data or annotations contained in a PDF form. XFDF can be used for many different purposes, but in our case, it can be used to either send or receive form data or annotations to other computers or servers etc, or it can be used to archive the form data or annotations. In this article, we will see how [Aspose.Pdf.Facades](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) has taken this concept into consideration and how we can import and export annotations data to XFDF file.

{{% /alert %}} 
## **Importing and Exporting Annotations to XFDF**
[Aspose.PDF for .NET](/pdf/net/home-html/) is a feature rich component when it comes to editing the PDF documents. As we know XFDF is an important aspect of PDF forms manipulation, [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) in [Aspose.PDF for .NET](/pdf/net/home-html/) has considered this very well, and have provided methods to import and export annotations data to XFDF files.

[PDFAnnotationEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfannotationeditor) class contains two methods to work with import and export of annotations to XFDF file. [ExportAnnotationsXfdf](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfannotationeditor/methods/exportannotationsxfdf/index) method provides the functionality to export annotations from a PDF document to XFDF file, while [ImportAnnotationFromXfdf](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/pdfannotationeditor/methods/importannotationfromxfdf/index) method allows you to import annotations from an existing XFDF file. In order to import or export annotations we need to specify the annotation types. We can specify these types in the form of an enumeration and then pass this enumeration as an argument to any of these methods. This way, the annotations of the specified types will only be imported or exported to an XFDF file.

The following code snippet shows you how to import or export annotations to an XFDF file:
### **Export Annotations**


{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-AnnotationsExport-AnnotationsExport.cs" >}}
### **Import Annotations**


{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-AnnotationsImport-AnnotationsImport.cs" >}}
