---
title: Aspose.PDF .NET 2.9.0.0 New Release Release Notes
type: docs
weight: 340
url: /net/aspose-pdf-net-2-9-0-0-new-release-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF .Net 2.9.0.0 New Release](http://www.aspose.com/downloads/pdf/net/new-releases/aspose.pdf-.net-2.9.0.0-new-release/)

{{% /alert %}} 

In this release:

New features supported:1) Justification for multi-segment text is supported.2) Double line border is supported.3) Keeping several paragraphs together is supported. A new property Paragraph.IsKeptWithNext is added which indicates whether current paragraph remains in the same page along with next paragraph.4) Page count is supported. A new property Pdf.PageCount is added.5) Converting aspx page into PDF is supported. The BindHTML method can be used to bind aspx too. You can also use the following code to save the current web page into pdf:pdf = new Aspose.PDF.Pdf();   string surl=this.Request.Url.ToString();   WebClient webClient = new WebClient();    byte myDataBuffer = webClient.DownloadData(surl);    MemoryStream  postStream=new MemoryStream (myDataBuffer);    pdf.BindHTML(postStream);    pdf.Save(@"c:\test.pdf")

\6) HTML2PDF is improved.    Image in web or local disk is supported.   List with or without number is supported.   Nested table and rowspan is supported.   Common tags such as br, hr, h1~h6, etc. are supported.7) PNG image support is improved. 8) Underline support is improved.

Main bugs fixed:1) Floating box bugs;2) RowSpan bugs;3) Adjusting table width automatically bug;4) UNC path bug;5) Row height bug.
