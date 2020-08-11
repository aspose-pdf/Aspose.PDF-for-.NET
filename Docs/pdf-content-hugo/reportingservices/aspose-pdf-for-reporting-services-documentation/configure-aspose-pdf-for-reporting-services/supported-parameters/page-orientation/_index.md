---
title: Page Orientation
type: docs
weight: 10
url: /reportingservices/page-orientation/
---

{{% alert color="primary" %}} 

Report Definition Language does not allow you to specify page orientation in the report explicitly. With Aspose.PDF for Reporting Services you can easily instruct the exporter to produce PDF documents with landscape page orientation. 

{{% /alert %}} 

The default orientation is portrait.

**Parameter Name**: IsLandscape
**Date Type**: Boolean
**Values supported**: True, False (default)

**Example**

{{< highlight csharp >}}

 <Render>

...

<Extension Name="APPDF" Type=" Aspose.PDF.ReportingServices.Renderer,Aspose.PDF.ReportingServices ">

<Configuration>

< IsLandscape >True</IsLandscape>

</Configuration>

</Extension>

</Render>



{{< /highlight >}}
