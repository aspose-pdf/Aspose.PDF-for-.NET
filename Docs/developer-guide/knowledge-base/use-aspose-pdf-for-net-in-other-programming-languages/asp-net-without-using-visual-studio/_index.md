---
title: ASP.NET without using Visual Studio
type: docs
weight: 60
url: /net/asp-net-without-using-visual-studio/
---

{{% alert color="primary" %}} 

[Aspose.PDF for .NET](/pdf/net/) can be used to develop ASP.NET pages or applications without using Visual Studio. In this example, we’ll write HTML and the C# or VB.NET code in a single .aspx file; this is commonly known as Instant ASP.NET.

{{% /alert %}} 
##### **Implementation details**
{{% alert color="primary" %}} 

Create a sample web application and copy Aspose.PDF.dll into a directory named "Bin" in your website directory ( *if bin folder does not exist, create one* ). Then create your .aspx page and copy the following code into it. 
This example shows how to use [Aspose.PDF for .NET](/pdf/net/) with inline code in an ASP.NET page in order to create a simple PDF document with some sample text inside it.
{{% /alert %}} 

**C#**

{{< highlight csharp >}}

 <%@ Page Language ="C#" %>

<%@ Import Namespace="System" %>

<%@ Import Namespace="System.IO" %>

<%@ Import Namespace="System.Data" %>

<%@ Import Namespace="Aspose.PDF" %>

<html>

<head>

<title> using Aspose.PDF for .NET with Inline ASP.NET</title>

</head>

<body>

<h3>creation of simple PDF document while using Aspose.PDF for .NET with Inline ASP.NET</h3>

<%

    // set license

    Aspose.PDF.License lic = new Aspose.PDF.License();

    lic.SetLicense("D:\\ASPOSE\\Licences\\Aspose.Total licenses\\Aspose.Total.lic");

    // Instantiate Pdf instance by calling its empty constructor

    Aspose.PDF.Generator.Pdf pdf = new Aspose.PDF.Generator.Pdf();

    // Create a new section in the Pdf object

    Aspose.PDF.Generator.Section pdfsection = new Aspose.PDF.Generator.Section();

    // Add section to Pdf object

    pdf.Sections.Add(pdfsection);

    // Create Text object

    Aspose.PDF.Generator.Text SampleText = new Aspose.PDF.Generator.Text();

    // Add Text Segment to text object

    Aspose.PDF.Generator.Segment seg1 = new Aspose.PDF.Generator.Segment();

    // Assign some content to the segment

    seg1.Content = "HelloWorld using Aspose.PDF for .NET with Inline ASP.NET";

    // Add segment (with red text color) to the paragraph

    SampleText.Segments.Add(seg1);

    // Add Text paragraph to paragraphs collection of a section

    pdfsection.Paragraphs.Add(SampleText);

    // Save the PDF document

    pdf.Save("d:\\pdftest\\HelloWorld_InlineASP.pdf");

%>

</body>

</html>

{{< /highlight >}}
