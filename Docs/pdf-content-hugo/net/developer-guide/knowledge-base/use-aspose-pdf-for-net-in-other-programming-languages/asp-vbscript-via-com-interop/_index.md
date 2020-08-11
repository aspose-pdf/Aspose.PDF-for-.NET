---
title: ASP - VBScript via COM Interop
type: docs
weight: 30
url: /net/asp-vbscript-via-com-interop/
---

##### **Prerequisites Please check the article named Use Aspose.pdf for .NET via COM Interop.**
##### **Hello World!**
This is a simple ASP application that shows you how to create a PDF file with sample text using [Aspose.PDF for .NET](/pdf/net/home-html/) and VBScript via COM Interop.

**VBScript**

{{< highlight csharp >}}

 <%@ LANGUAGE = VBScript %>

<% Option Explicit %>

<html>

<head>

<title> using Aspose.PDF for .NET in classical ASP sample</title>

</head>

<body>

<h3>creation of sample PDF document while using Aspose.PDF for .NET with classical ASP and VBScript</h3>

<%

'set license

Dim lic

Set lic = CreateObject("Aspose.PDF.License")

lic.SetLicense("D:\ASPOSE\Licences\Aspose.Total licenses\Aspose.Total.lic")

'Instantiate Pdf instance by calling its empty constructor

Dim pdf

Set pdf = CreateObject("Aspose.PDF.Generator.Pdf")

'Create a new section in the Pdf object

Dim pdfsection

Set pdfsection = CreateObject("Aspose.PDF.Generator.Section")

'Add section to Pdf object

pdf.Sections.Add(pdfsection)

' Create Text object

Dim SampleText

Set SampleText = CreateObject("Aspose.PDF.Generator.Text")

'Add Text Segment to text object

Dim seg1

Set seg1 = CreateObject("Aspose.PDF.Generator.Segment")

'Assign some content to the segment

seg1.Content = "HelloWorld using ASP and VBScript"

'Add segment (with red text color) to the paragraph

SampleText.Segments.Add(seg1)

' Add Text paragraph to paragraphs collection of a section

pdfsection.Paragraphs.Add(SampleText)

' Save the PDF document

pdf.Save("d:\pdftest\HelloWorldinASP.pdf")

%>

</body>

</html>



{{< /highlight >}}
##### **Extracting Text**
This VBScript sample extracts text from an existing PDF document via COM Interop.

Error rendering macro 'code' : Invalid value specified for parameter lang
