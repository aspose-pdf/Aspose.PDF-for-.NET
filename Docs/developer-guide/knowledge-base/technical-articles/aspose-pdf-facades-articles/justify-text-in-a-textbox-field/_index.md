---
title: Justify Text in a Textbox Field
type: docs
weight: 320
url: /net/justify-text-in-a-textbox-field/
---

{{% alert color="primary" %}}

In this article, we’ll show you how to justify text in a textbox field in a PDF file.

{{% /alert %}}
## **Implementation details**
FormEditor|http://www.aspose.com/docs/display/pdfnet/FormEditor+Class] class in [Aspose.Pdf.Facades namespace](https://apireference.aspose.com/pdf/net/aspose.pdf.facades) offers the capability to decorate a PDF form field. Now, if your requirement is to justify the text in a textbox field, you can easily achieve that using **AlignJustified** value of **FormFieldFacade** enumeration and calling the **FormEditor.DecorateField** method. In the below example, first we will fill a Textbox Field using the **FillField** method of **Form** class. After that we will use FormEditor class to justify the Text in the Textbox Field. The following code snippet shows you how to justify text in a Textbox Field.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-JustifyText-JustifyText.cs" >}}

Please note that justified alignment is not supported by PDF that's why text will be aligned left when you input the text in the Textbox Field. But when field is not active text is justified.
