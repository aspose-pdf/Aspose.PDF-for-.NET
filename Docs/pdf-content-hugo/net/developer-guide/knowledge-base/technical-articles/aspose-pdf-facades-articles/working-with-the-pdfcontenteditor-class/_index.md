---
title: Working with the PdfContentEditor class
type: docs
weight: 280
url: /net/working-with-the-pdfcontenteditor-class/
---

{{% alert color="primary" %}} 

This article will help you view the [PdfContentEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/PdfContentEditor) class in a broader sense. After reading this article, you’ll be able to have a better idea that what kinds of features are supported in this class. It’ll also point you to the right direction regarding the usage of this class.

{{% /alert %}} 
## **Implementation details**
[PdfContentEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/PdfContentEditor) class allows you to manipulate variety of contents. It helps you create different annotations; twenty four annotation types are supported in [Aspose.Pdf.Facades namespace](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Facades+namespace). We’ll show you a simple example to help you understand how the variety of annotations can be added in a PDF file.



{{< highlight java >}}

 // Create PdfContentEditor class

PdfContentEditor editor = new PdfContentEditor();

// Create rectangle object

System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(100, 100, 20, 20);

// Bind input PDF file

editor.BindPdf("input.pdf");

// Create any annotation - in this case Text Annotation

editor.CreateText(rectangle, "Welcome to Aspose", "You are welcome to Aspose!", true, "Key", 2);

// Save output

editor.Save("output.pdf");



{{< /highlight >}}
## **Working with Viewer preferences**
It also allows you to change and get viewer preferences as shown in the code snippet given below:



{{< highlight java >}}

 // Create PdfContentEditor object

PdfContentEditor editor = new PdfContentEditor();

// Bind input PDF file

editor.BindPdf("input.pdf");

// Change Viewer Preferences

editor.ChangeViewerPreference(ViewerPreference.HideMenubar);

// Get viewer preference

int preferenceValue = editor.GetViewerPreference();

// Save output PDF file

editor.Save("output.pdf");



{{< /highlight >}}
## **Working with JavaScript**
You can also set the document level JavaScript as shown below.



{{< highlight java >}}

 // Create PdfContentEditor object to add additional document actions

PdfContentEditor editor = new PdfContentEditor();

// Open input PDF file

editor.BindPdf("input.pdf");

// Set script for additional action

editor.AddDocumentAdditionalAction(PdfContentEditor.DocumentOpen, "app.alert('Welcome to Aspose.');");

// Save output PDF file

editor.Save("output.pdf");



{{< /highlight >}}
## **Replace text and Images inside PDF**
This class also helps you replace text and images.



{{< highlight java >}}

 // Create PdfContentEditor object

PdfContentEditor editor = new PdfContentEditor();

// Bind input PDF file

editor.BindPdf("input.pdf");

// Replace text

editor.ReplaceText("source string", "destination string");

// Replace image

editor.ReplaceImage(1, 1, "test.jpg");

// Save output PDF file

editor.Save("output.pdf");



{{< /highlight >}}
## **Deleting images**
You can also delete either all the images or the images on particular index at a particular page.



{{< highlight java >}}

 // Create PdfContentEditor object

PdfContentEditor editor = new PdfContentEditor();

// Bind input PDF file

editor.BindPdf("input.pdf");

// Delete particular images

editor.DeleteImage(1, new int[] { 1, 4 });

// or - delete all images

editor.DeleteImage();

// Save output PDF file

editor.Save("output.pdf");



{{< /highlight >}}
## **Adding attachments**
Document attachments can also be added in a PDF file as shown in the following code snippet.



{{< highlight java >}}

 // Create PdfContentEditor object

PdfContentEditor editor = new PdfContentEditor();

// Bind input PDF file

editor.BindPdf("input.pdf");

// Add document attachment

editor.AddDocumentAttachment("sample.ppt", "Adding Powerpoint Presentation as attachment");

// Save output PDF file

editor.Save("output.pdf");



{{< /highlight >}}
