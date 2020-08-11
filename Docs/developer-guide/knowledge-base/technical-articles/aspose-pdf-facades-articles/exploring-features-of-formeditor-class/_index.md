---
title: Exploring features of FormEditor class
type: docs
weight: 230
url: /net/exploring-features-of-formeditor-class/
---

{{% alert color="primary" %}} 

PDF documents sometimes contain interactive form, which are known as AcroForm. It is just like a form used in the web pages. These forms contain different types of controls i.e. Text boxes, Check boxes, and Buttons etc. A developer working with PDF files might sometimes have to edit these forms. In this article, we’ll look into the details how [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) enables us to do that.

{{% /alert %}} 
## **Implementation details**
Developers can use [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) not only to add new forms and form fields in a PDF document, but also allow you to edit existing fields. The scope of this article is limited to the features of [Aspose.PDF for .NET](/pdf/net/) which deal with the form editing.

[FormEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/formeditor) is the class which contains most of the methods and properties which allow the developers to edit form fields. You can not only add new fields, but also remove existing fields, move one field to another position, change field name, or attributes etc. The list of the features provided by this class is quite comprehensive, and it is very easy to work with the form fields using this class.

These methods can be divided into two main categories, one of which is used to manipulate the fields, and the other is used to set the new attributes of these fields. The methods which we can group under first category include AddField, AddListItem, RemoveListItem, CopyInnerField, CopyOuterField, DelListItem, MoveField, RemoveField, and RenameField etc. In the second category of the methods SetFieldAlignment, SetFieldAppearance, SetFieldAttribute, SetFieldLimit, SetFieldScript can be included. The following code snippet shows you some of the methods of FormEditor class in working:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-FormEditorFeatures-FormEditorFeatures.cs" >}}
