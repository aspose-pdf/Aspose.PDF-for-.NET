---
title: Row Across Pages
type: docs
weight: 40
url: /reportingservices/row-across-pages/
---

{{% alert color="primary" %}} 

For the list and rectangle elements of reporting services, every row of list or rectangle has the fixed row height. The default PDF renderer can not break the row down if the row crosses pages and the exported PDF documents usually have much more blank area at the bottom of every page. With Aspose.Pdf for Reporting Services you can easily instruct the exporter to produce PDF documents without blank area.

{{% /alert %}} 

**Parameter Name**: IsRowBrokenForFixedHeight
**Date Type**: Boolean
**Values supported**: True, False (default)

**Example**

{{< highlight csharp >}}

 <Render>

...

<Extension Name="APPDF" Type=" Aspose.PDF.ReportingServices.Renderer,Aspose.PDF.ReportingServices">

<Configuration>

< IsRowBrokenForFixedHeight >True</IsRowBrokenForFixedHeight>

</Configuration>

</Extension>

</Render>



{{< /highlight >}}
