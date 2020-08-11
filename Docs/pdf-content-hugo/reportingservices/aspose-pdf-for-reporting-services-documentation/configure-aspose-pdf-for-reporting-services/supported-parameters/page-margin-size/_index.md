---
title: Page margin size
type: docs
weight: 70
url: /reportingservices/page-margin-size/
---

{{% alert color="primary" %}} 

RS designer does not support the setting of page margin size. Aspose.Pdf for Reporting Services provides four parameters to set the corresponding page margin size, they are:

{{% /alert %}} 

\1)
**Parameter Name**: PageMarginLeft
**Date Type**: Float
**Values supported**:

\2)
**Parameter Name**: PageMarginRight
**Date Type**: Float
**Values supported**:

\3)
**Parameter Name**: PageMarginTop
**Date Type**: Float
**Values supported**:

\4)
**Parameter Name**: PageMarginBottom
**Date Type**: Float
**Values supported**:

**Example**

{{< highlight csharp >}}

 <Render>

...

<Extension Name="APPDF" Type=" Aspose.PDF.ReportingServices.Renderer,Aspose.PDF.ReportingServices">

<Configuration>

<PageMarginLeft >50</PageMarginLeft>

 <PageMarginRight >50</PageMarginRight>

 <PageMarginTop >50</PageMarginTop>

 <PageMarginBottom >50</PageMarginBottom>

</Configuration>

</Extension>

</Render>



{{< /highlight >}}
