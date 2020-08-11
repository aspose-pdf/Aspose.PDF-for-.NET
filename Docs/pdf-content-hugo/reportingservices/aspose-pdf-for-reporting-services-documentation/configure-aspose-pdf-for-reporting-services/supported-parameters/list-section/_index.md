---
title: List Section
type: docs
weight: 110
url: /reportingservices/list-section/
---

{{% alert color="primary" %}} 

You can get some introduction about List Section from [here](http://www.aspose.com/documentation/.net-components/aspose.pdf-for-.net/manipulating-list-of-contents.html).

{{% /alert %}} 

If you want to support creation of List Section, such as Table of Contents, List of Tables and so on, please add report parameter as the following:

**Parameter Name**: IsListSectionSupported
**Date Type**: Boolean
**Values supported**: True, False(default)

**Example**

{{< highlight csharp >}}

 <Render>

...

<Extension Name="APPDF" Type="Aspose.PDF.ReportingServices.Renderer,Aspose.PDF.ReportingServices">

<Configuration>

<IsListSectionSupported>True</IsListSectionSupported>

</Configuration>

</Extension>

</Render>



{{< /highlight >}}
