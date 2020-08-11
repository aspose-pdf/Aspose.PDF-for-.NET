---
title: How to create Hello world PDF document
type: docs
weight: 10
url: /net/how-to-create-hello-world-pdf-document/
---

{{% alert color="primary" %}} 

A new [Aspose.PDF for .NET API](/pdf/net/) has been released and now this single product supports the capability to generate PDF documents from scratch, edit existing PDF documents even at document object level. 

{{% /alert %}} 
##### **Support for Legacy code**
In order to use the legacy code developed with Aspose.PDF for .NET versions earlier to 6.x, you need to make some minor changes in your code and the code will work as earlier. All the classes that were present in old Aspose.PDF for .NET API are now present under Aspose.PDF.Generator namespace. Please take a look over the following simple code snippet for creating a Hello world PDF document in legacy Aspose.PDF API and follow the steps describing how to migrate to new merged API. 
##### **Legacy Aspose.PDF for .NET approach**
**C#**

{{< highlight csharp >}}

 //Instantiate PDF instance by calling empty constructor

Aspose.PDF.License pdflic = new Aspose.PDF.License();

//Specify the license file path

pdflic.SetLicense(@"D:\\Licenses\ Aspose.Total.Product.Family.lic");

//Instantiate PDF instance by calling empty constructor

Pdf pdf1 = new Pdf();

//Create a section in the pdf document

Section sec1 = pdf1.Sections.Add();

//add a sample text paragraph to paragraphs collection of section object

sec1.Paragraphs.Add(new Text("Hello World"));

// Save the resultant PDF document

pdf1.Save("D:/pdftest/HelloWorld.pdf");



{{< /highlight >}}
##### **New Aspose.PDF for .NET 6.x approach**
**C#**

{{< highlight csharp >}}

 //Instantiate PDF instance by calling empty constructor

Aspose.PDF.License pdflic = new Aspose.PDF.License();

//Specify the license file path

pdflic.SetLicense(@"D:\\Licenses\ Aspose.Total.Product.Family.lic");

//Instantiate PDF instance by calling empty constructor

Aspose.PDF.Generator.Pdf pdf1 = new Aspose.PDF.Generator.Pdf();

//Create a section in the pdf document

Aspose.PDF.Generator.Section sec1 = pdf1.Sections.Add();

//add a sample text paragraph to paragraphs collection of section object

sec1.Paragraphs.Add(new Aspose.PDF.Generator.Text("Hello World"));

// Save the resultant PDF document

pdf1.Save("D:/pdftest/HelloWorld.pdf");



{{< /highlight >}}
