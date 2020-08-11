---
title: Changes Required when Migrating from Aspose.Pdf.Kit
type: docs
weight: 20
url: /net/changes-required-when-migrating-from-aspose-pdf-kit/
---

{{% alert color="primary" %}} 

When migrating from legacy Aspose.PDF.Kit to Aspose.PDF 6.x, you need to make only a few changes in your existing code. This article will provide you the list of those changes and all the related details. 

{{% /alert %}} 
#### **Working with Annotations**

{{% alert color="primary" %}} 
In the new version, you’ll not be able to use Annotation class while modifying existing annotations; instead, you’ll have to use specific class for a particular annotation type. You can find these classes in  Aspose.PDF.InteractiveFeatures.Annotations namespace.
Please see the following code snippet to understand the changes and see how the new code will look like. 
{{% /alert %}} 
**C#**

{{< highlight csharp >}}

 //open document

PdfAnnotationEditor annotationEditor = new PdfAnnotationEditor();

annotationEditor.BindPdf("input.pdf");

//create annotation

FreeTextAnnotation annotation = new FreeTextAnnotation();

annotation.Modified = DateTime.Now;

annotation.Contents = "Contents...";

annotation.Subject = "Subject";

annotation.Color = Color.Green;

//modify annotation

annotationEditor.ModifyAnnotations(1, 1, annotation);

//save updated PDF file

annotationEditor.Save("output.pdf");



{{< /highlight >}}
#### **Working with Attachments**

{{% alert color="primary" %}}
Previously, GetAttachNames returned ArrayList object, but in new version it returns IList object. You need to cast it to ArrayList object by yourself to make your existing code work. You can see the example below.
{{% /alert %}} 
**C#**

{{< highlight csharp >}}

 //open document

PdfExtractor pdfExtractor = new PdfExtractor();

pdfExtractor.BindPdf("input.pdf");

//extract attachments

pdfExtractor.ExtractAttachment();

//get attachment names

ArrayList attachmentNames = (ArrayList) pdfExtractor.GetAttachNames();

foreach (string attachmentName in attachmentNames)

Console.WriteLine("Name : {0}", attachmentName);



{{< /highlight >}}
#### **Working with Replace Text**
{{% alert color="primary" %}} 

If you want to replace text in the PDF file and also want to set the text properties then you’ll have to use TextState class instead of TextProperties. TextState class provides more options while setting text properties. You can also set the font using Font class as shown in the following example.

{{% /alert %}} 

**C#**

{{< highlight csharp >}}

 //create PdfContentEditor object to edit text

PdfContentEditor editor = new PdfContentEditor();

editor.BindPdf("input.pdf");

// Create font and mark it to be embedded

Aspose.PDF.Text.Font font = FontRepository.FindFont("Courier New");

font.IsEmbedded = true;

//create textState object

TextState textState = new TextState();

textState.Font = font;

textState.FontSize = 17;

textState.FontStyle = FontStyles.Bold | FontStyles.Italic;

textState.ForegroundColor = System.Drawing.Color.Red;

//change text with specified font

editor.ReplaceText("hello world", 1, "hi world", textState);

//save document

editor.Save("output.pdf");



{{< /highlight >}}


#### **Form field naming**

{{% alert color="primary" %}} 
Aspose.PDF.Facades work with only full field names in contrast with old Aspose.PDF.Kit which allowed access to field by partial name. This was made to avoid field names ambiguity and confusion with fields with duplicated partial names. If you need to access particular field by partial name, you may try using Form.FieldNames property which contains full names of form fields. (Iterate through FieldNames array and select field whose name is ended with partial name ... etc)
{{% /alert %}} 