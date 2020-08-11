---
title: Changing field appearance and attributes
type: docs
weight: 150
url: /net/changing-field-appearance-and-attributes/
---

{{% alert color="primary" %}} 

[FormEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/FormEditor) class of [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace) allows you to not only change the look and feel of the form field, but also the behavior of the field. In this article, we will see how we can use FormEditor class to change the field appearance, field attributes, and the field limit as well.

{{% /alert %}} 
## **Implementation details**
[SetFieldAppearance](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/formeditor/methods/setfieldappearance) method is used to the change the appearance of a form field. It takes AnnotationFlag as a parameter. **AnnotationFlag** is an enumeration which has different members like Hidden or NoRotate etc.

[SetFieldAttributes](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/formeditor/methods/setfieldattribute) method is used to change the attribute of a form field. A parameter passed to this method is **PropertyFlag** enumeration which contains members like ReadOnly or Required etc.

[FormEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/FormEditor) class also provides a method to set the field limit. It tells the field that how much characters it can be filled with. The bellow code snippet shows you how all of these methods can be used.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-ChangingFieldAppearance-ChangingFieldAppearance.cs" >}}
