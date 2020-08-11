---
title: Compression
type: docs
weight: 130
url: /reportingservices/compression/
---

{{% alert color="primary" %}} 

The Reporting Services designer does not support specifying the compression of the output PDF document being generated. However, Aspose.PDF for Reporting Services does. 

{{% /alert %}} 

**Parameter Name**: CompressionLevel
**Date Type**: Integer
**Values supported**: 1 to 9, where 9 is maximum compression. Default value is 6.

**Example**

{{< highlight csharp >}}

 <Render>

...

<Extension Name="APPDF" Type=" Aspose.PDF.ReportingServices.Renderer, Aspose.PDF.ReportingServices">

<Configuration>

<CompressionLevel>9</CompressionLevel>

</Configuration>

</Extension>

</Render>



{{< /highlight >}}
