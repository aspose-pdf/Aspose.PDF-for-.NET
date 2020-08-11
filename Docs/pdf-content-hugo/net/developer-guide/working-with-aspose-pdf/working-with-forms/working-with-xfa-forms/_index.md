---
title: Working with XFA Forms
type: docs
weight: 30
url: /net/working-with-xfa-forms/
---

{{% alert color="primary" %}} 

Dynamic forms are based on an XML specification known as XFA, the “XML Forms Architecture”. It can also convert dynamic XFA form to standard Acroform. The information about the form (as far as PDF is concerned) is very vague – it specifies that fields exist, with properties, and JavaScript events, but does not specify any rendering. The objects of XFA form are drawn at the time loading the document.

{{% /alert %}} 

Aspose.PDF for .NET API lets you work with XFA and XFA Acroform fields in a PDF document. The [Aspose.PDF.Facades.Form](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/form) class provides the capability to deal with static AcroForm and you can get a particular field instance using the Form class' GetFieldFacade(..) method. However, XFA fields cannot be accessed via the Form.GetFieldFacade(..) method. Instead, use Document.Form.XFA to get/set field values and manipulate XFA field template (set field properties).
## **Fill XFA fields**
The following code snippet shows you how to fill fields in XFA form.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-FillXFAFields-FillXFAFields.cs" >}}
## **Get XFA field properties**
To access field properties, first use Document.Form.XFA.Teamplate to access the field template. The following code snippet shows the steps of getting X and Y coordinates of XFA a form field.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-GetXFAProperties-GetXFAProperties.cs" >}}
## **Convert Dynamic XFA Form to Standard AcroForm**
Try online

You can check the quality of Aspose.PDF conversion and view the results online at this link:

[products.aspose.app/pdf/xfa/acroform](https://products.aspose.app/pdf/xfa/acroform)

Dynamic forms are based on an XML specification known as XFA, the “XML Forms Architecture”. The information about the form (as far as a PDF is concerned) is very vague – it specifies that fields exist, with properties, and JavaScript events, but does not specify any rendering.

Currently, PDF supports two different methods for integrating data and PDF forms:

- AcroForms (also known as Acrobat forms), introduced and included in the PDF 1.2 format specification.
- Adobe XML Forms Architecture (XFA) forms, introduced in the PDF 1.5 format specification as an optional feature (The XFA specification is not included in the PDF specification, it is only referenced.)

We cannot extract or manipulate pages of XFA Forms, because the form content is generated at runtime (during XFA form viewing) within the application trying to display or render the XFA form. Aspose.PDF has a feature that allows developers to convert XFA forms to standard AcroForms.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-DynamicXFAToAcroForm-DynamicXFAToAcroForm.cs" >}}
