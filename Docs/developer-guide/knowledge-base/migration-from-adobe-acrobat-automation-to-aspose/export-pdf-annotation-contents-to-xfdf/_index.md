---
title: Export PDF Annotation Contents to XFDF
type: docs
weight: 50
url: /net/export-pdf-annotation-contents-to-xfdf/
---

{{% alert color="primary" %}} 

One of the popular formats for exporting contents and data from the annotations in PDF documents is XFDF. Adobe Acrobat SDK supports exporting annotation contents to XFDF file format. So does Aspose.PDF for .NET. This article shows how to use each approach.

{{% /alert %}} 
### **Adobe Acrobat Automation**
The following code snippet is based on Adobe Acrobat 7.0 SDK.

**C#**

{{< highlight csharp >}}

 String fileName = @"D:\annotation.pdf";

//Create a PDDoc IAC object.

//Since we don't need to launch Acrobat Viewer on the screen, we don't have

//to create Acrobat App object.

Acrobat.CAcroPDDoc pdDoc;

pdDoc = CreateObject("AcroExch.PDDoc");

if(pdDoc = null)

throw new Exception("Failed to create Acrobat PDDoc object.");

// Open the source PDF document

int rc = pdDoc.Open(fileName);

if(rc != -1)// If rc <> -1 Then

throw new Exception("Could not open file :" + fileName);

// Acquire the Acrobat JavaScript Object interface from the PDDoc object

jsObj = pdDoc.GetJSObject;

jsObj.exportAsXFDF(true, false, VariantType.null, @"D:\Bizcardxf2.XFDF", true);

{{< /highlight >}}

Please note that there is an odd requirement when exporting annotations from a PDF file with the Adobe Acrobat SDK. It's been observed that until or unless the document is loaded in Adobe Reader or Acrobat, one cannot export the document's annotations to XFDF.
### **Aspose.PDF for .NET**
The following code snippet shows the steps to export annotations to XFDF format using Aspose.PDF for .NET. The  Aspose.PDF.Facades namespace contains a class named PdfAnnotationEditor which provides the capability to manipulate annotations in an existing PDF document. To export annotations, use the ExportAnnotationsXfdf(..) method.

**C#**

{{< highlight csharp >}}

 //Create PdfAnnotationEditor object

PdfAnnotationEditor AnnotationEditor = new PdfAnnotationEditor();

//Open PDF document

AnnotationEditor.BindPdf("input.pdf");

//Import annotations

FileStream fileStream = new System.IO.FileStream("annotations.xfdf", System.IO.FileMode.Create);

Enum[] annotType = { AnnotationType.FreeText, AnnotationType.Line };

AnnotationEditor.ExportAnnotationsXfdf(fileStream, 1, 5, annotType);

//Save output PDF

AnnotationEditor.Save("output.pdf");

{{< /highlight >}}
