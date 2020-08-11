---
title: ASP - JScript via COM Interop
type: docs
weight: 40
url: /net/asp-jscript-via-com-interop/
---

{{% alert color="primary" %}} 

This is a simple ASP application that shows you how to add simple text string to PDF file using [Aspose.PDF for .NET](/pdf/net/home-html/) and JScript via COM Interop. 

{{% /alert %}} 
##### **Code Snippet**
**JScript**

{{< highlight csharp >}}

 <%@ LANGUAGE = JScript %>

<html>

<head>

<title> using Aspose.PDF for .NET in classical ASP sample</title>

</head>

<body>

<h3>creation of sample PDF document while using Aspose.PDF for .NET with classical ASP and JScript</h3>

<%

// set license

var lic = Server.CreateObject("Aspose.PDF.License");

lic.SetLicense("D:\\ASPOSE\\Licences\\Aspose.Total licenses\\Aspose.Total.lic");

// Instantiate Pdf instance by calling its empty constructor

var pdf = Server.CreateObject("Aspose.PDF.Generator.Pdf");

// Create a new section in the Pdf object

var pdfsection = Server.CreateObject("Aspose.PDF.Generator.Section");

// Add section to Pdf object

pdf.Sections.Add(pdfsection);

// Create Text object

var SampleText = Server.CreateObject("Aspose.PDF.Generator.Text");

// Add Text Segment to text object

var seg1 = Server.CreateObject("Aspose.PDF.Generator.Segment");

// Assign some content to the segment

seg1.Content = "HelloWorld using ASP and JScript";

// Add segment (with red text color) to the paragraph

SampleText.Segments.Add(seg1);

// Add Text paragraph to paragraphs collection of a section

pdfsection.Paragraphs.Add(SampleText);

// Save the PDF document

pdf.Save("d:\\pdftest\\HelloWorldinASP.pdf");

%>

</body>

</html>



{{< /highlight >}}
