---
title: Printing PDF Document
type: docs
weight: 30
url: /net/printing-pdf-document/
---

{{% alert color="primary" %}} 

This article explains how to migrate from [Adobe Acrobat Automation](/pdf/net/printing-pdf-document/) to [Aspose.PDF for .NET](/pdf/net/printing-pdf-document/) to print a PDF file.

Adobe Acrobat Automation allows you to perform various tasks on PDF files in your code. Aspose.PDF for .NET also provides the functionality to perform PDF manipulation programmatically. However, Aspose.PDF for .NET is easy to use compared to Adobe Acrobat Automation. Aspose.PDF for .NET is built using managed code and can be installed and deployed as a single .NET assembly: Adobe Acrobat Automation is based upon COM components that have to be registered on the machine they’re being used on. Please note that Aspose.PDF for .NET is fully supported on 32-bit and 64-bit machines and it is also quite fast compared to Adobe Acrobat Automation.

We have selected a simple example to help you understand migration from Adobe Acrobat Automation to [Aspose.PDF for .NET](/pdf/net/). This example shows how to print a PDF file using both methods.

{{% /alert %}} 
### **Adobe Acrobat Automation**
The following code snippet shows you how to print a PDF file using Adobe Acrobat Automation.

**C#**

{{< highlight csharp >}}

 //create AcroPDF object

AcroPDFLib.AcroPDF pdf = new AcroPDFLib.AcroPDF();

//set source PDF file

pdf.src = @"c:\input.pdf";

//print all pages

pdf.printAll();



{{< /highlight >}}
### **Aspose.PDF for .NET**
This article shows how easy it is to migrate from Adobe Acrobat Automation to Aspose.PDF for .NET. As well as having all the PDF manipulation features in one place, in the form of a single assembly, we can get all the benefits of the .NET technology, instead of getting into the old COM paradigm.

The following code snippet shows how to print a PDF file using the Aspose.PDF.Facades namespace.

**C#**

{{< highlight csharp >}}

 //Create PdfViewer object

PdfViewer viewer = new PdfViewer();

//Open input PDF file

viewer.BindPdf(@"c:\input.pdf");

//Print PDF document

viewer.PrintDocument();

//Close PDF file

viewer.Close();



{{< /highlight >}}
