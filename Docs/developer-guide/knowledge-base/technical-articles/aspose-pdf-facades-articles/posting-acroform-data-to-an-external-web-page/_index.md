---
title: Posting AcroForm data to an external web page
type: docs
weight: 140
url: /net/posting-acroform-data-to-an-external-web-page/
---

{{% alert color="primary" %}} 

AcroForm is an important type of the PDF document. You can not only create and edit an AcroForm using [Aspose.Pdf.Facades namepsace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace), but also import and export form data to and XML file. Aspose.Pdf.Facades namespace in Aspose.PDF for .NET allows you to implement another feature of AcroForm, which helps you post an AcroForm data to an external web page. This web page then reads the post variables and uses this data for further processing. This feature is useful in the cases when you don’t just want to keep the data in the PDF file, rather you want to send it to your server and then save it in a database etc.

{{% /alert %}} 
## **Implementation details**
In this article, we have tried to create an AcroForm using [Aspose.Pdf.Facades namepsace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace). We have also added a submit button and set its target URL. The following code snippets show you how to create the form and then receive the posted data on the web page.



{{< highlight java >}}

 // Create an instance of FormEditor class and bind input and output pdf files

Aspose.Pdf.Facades.FormEditor editor = new Aspose.Pdf.Facades.FormEditor("input.pdf","output.pdf");

// Create AcroForm fields - I have created only two fields for simplicity

editor.AddField(Aspose.PDF.Facades.FieldType.Text, "firstname", 1, 100, 600, 200, 625);

editor.AddField(Aspose.PDF.Facades.FieldType.Text, "lastname", 1, 100, 550, 200, 575);

// Add a submit button and set target URL

editor.AddSubmitBtn("submitbutton", 1, "Submit", "http://localhost/csharptesting/show.aspx", 100, 450, 150, 475);

// Save output pdf file

editor.Save();



{{< /highlight >}}

{{% alert color="primary" %}} 

Following code snippet shows you how receive the posted values on the target web page. In this example, I have used a page named Show. a spx, and I have added simple one line code on the page load method.

{{% /alert %}} 

{{< highlight java >}}

 // Show the posted values on the target web page

Response.Write("Hello " + Request.Form.Get("firstname") + " " + Request.Form.Get("lastname"));



{{< /highlight >}}
