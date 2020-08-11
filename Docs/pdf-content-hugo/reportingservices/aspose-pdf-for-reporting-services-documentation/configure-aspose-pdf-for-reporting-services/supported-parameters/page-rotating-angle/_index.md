---
title: Page Rotating Angle
type: docs
weight: 120
url: /reportingservices/page-rotating-angle/
---

{{% alert color="primary" %}} 

Gets or sets the number of degrees by which the page should be rotated clockwise when displayed or printed.

{{% /alert %}} 

**Parameter Name**: PageRotatingAngle
**Date Type**: Integer
**Values supported**: The value must be a multiple of 90. Default value is 0.

**Example**

{{< highlight csharp >}}

 <Render>

...

<Extension Name="APPDF" Type="Aspose.PDF.ReportingServices.Renderer,Aspose.PDF.ReportingServices">

<Configuration>

        <PageRotatingAngle>180</PageRotatingAngle>

</Configuration>

</Extension>

</Render>



{{< /highlight >}}
