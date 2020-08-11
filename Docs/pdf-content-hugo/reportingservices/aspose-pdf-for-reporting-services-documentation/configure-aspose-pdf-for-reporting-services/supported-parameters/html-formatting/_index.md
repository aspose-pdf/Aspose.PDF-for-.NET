---
title: HTML Formatting
type: docs
weight: 20
url: /reportingservices/html-formatting/
---

{{% alert color="primary" %}} 

Sometimes you might wish to export text in textboxes with formatting. Unfortunately, Reporting Services does not support this. However, you still can implement it using Aspose.PDF for Reporting Services. Just enable a special mode in which all text in textboxes is treated as HTML and put the necessary HTML tags to format the text in the output document. For example, to have normal, bold and italic text in the same textbox, enter the following textbox value:

Some of this text is <b>bold</b> and other text is <i>italic</i>.

When exported, the text will look like as some of this text is **bold** and other text is *italic*.

Please note that this approach has some limitations

{{% /alert %}} 

The formatting isn’t visible in design time (in Report Builder, Report Manager etc). Instead, you will see the HTML text as is.

The Aspose.PDF for Reporting Services rendering extension can understand and properly format HTML code in textboxes. The default PDF renderer of RS does not so.

**Parameter Name**: IsHtmlTagSupported
**Date Type**: Boolean
**Values supported**: True, False (default) 

**Example**

{{< highlight csharp >}}

 <Render>

...

<Extension Name="APPDF" Type=" Aspose.PDF.ReportingServices.Renderer,Aspose.PDF.ReportingServices ">

<Configuration>

<IsHtmlTagSupported >True</IsHtmlTagSupported>

</Configuration>

</Extension>

</Render>



{{< /highlight >}}

If you want to set this parameter in Report Designer, the data type should be 'Boolean'. 

Currently Aspose.PDF for Reporting Services does not support all HTML tags. 
