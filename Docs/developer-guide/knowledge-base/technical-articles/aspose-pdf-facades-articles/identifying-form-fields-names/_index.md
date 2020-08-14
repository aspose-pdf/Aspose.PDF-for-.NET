---
title: Identifying form fields names
type: docs
weight: 300
url: /net/identifying-form-fields-names/
---

{{% alert color="primary" %}}

[Aspose.PDF for .NET](/pdf/net/) provides the capability to create, edit and fill already created Pdf forms. [Aspose.Pdf.Facades](https://apireference.aspose.com/pdf/net/aspose.pdf.facades) namespace contains [Form](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/form) class, which contains the function named [FillField](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/form/methods/fillfield/index) and it takes two arguments i.e. Field name and field value. So in-order to fill the form fields, you must be aware of the exact form field name.

{{% /alert %}}
## **Implementation details**
We often come across a scenario where we need to fill the form which is created in some tool i.e. Adobe Designer, and we are not sure about the form fields names. So in order to fill the form fields, first we need to read the names of all the Pdf form fields. [Form](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/form) class provides the property named [FieldNames](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/form/properties/fieldnames) which returns the entire field's names and returns null if PDF does not contain any field. However, when using this property, we get the names of the entire field’s in PDF form and we might not be certain that which name corresponds to which field over the form.

As a solution to this problem, we will use the appearance attributes of each field. Form class has a function named [GetFieldFacade](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/form/methods/getfieldfacade) which returns attributes, including location, color, border style, font, list item and so on. To save these values we need to use [FormFieldFacade](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/FormFieldFacade) class, which is used to record visual attributes of the fields. Once we have these attributes we can add a text field beneath every field which would be displaying the field name.

{{% alert color="primary" %}}
At this point, a question arises "how we would determine the location where to add the text field?"
{{% /alert %}}


{{% alert color="primary" %}}

The solution to this problem is Box property in [FormFieldFacade](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/FormFieldFacade) class, which holds the field’s location. We need to save these values to an array of rectangle type and use these values to identify the position where to add the new text fields.

{{% /alert %}}

In [Aspose.Pdf.Facades](https://apireference.aspose.com/pdf/net/aspose.pdf.facades) namespace we have a class named [FormEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/FormEditor) which provides the capability to manipulate PDF forms. Open a pdf form; add a text field beneath every existing form field and save the Pdf form with new name.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-IdentifyFormFields-IdentifyFormFields.cs" >}}
