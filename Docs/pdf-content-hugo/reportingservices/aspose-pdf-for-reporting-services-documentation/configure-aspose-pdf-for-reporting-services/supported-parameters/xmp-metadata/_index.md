---
title: XMP Metadata
type: docs
weight: 80
url: /reportingservices/xmp-metadata/
---

{{% alert color="primary" %}} 

The RS designer does not support embedding XMP data. Aspose.PDF for Reporting Services provides four parameters for setting XMP Metadata, listed below.

{{% /alert %}} 

**Parameter Name**: CreationDate
**Date Type**: String
**Values supported**:

**Parameter Name**: ModifyDate
**Date Type**: String
**Values supported**:

**Parameter Name**: MetaDataDate
**Date Type**: String
**Values supported**:

**Parameter Name**: CreatorTool
**Date Type**: String
**Values supported**:

**Example**

{{< highlight csharp >}}

 <Render>

...

<Extension Name="APPDF" Type=" Aspose.PDF.ReportingServices.Renderer, Aspose.PDF.ReportingServices">

<Configuration>

<CreationDate >2007-12-10</CreationDate>

<ModifyDate >2008-1-12</ModifyDate>

<MetaDataDate >2008-3-7</MetaDataDate>

<CreatorTool >Aspose.PDF for Reporting Services</CreatorTool>

</Configuration>

</Extension>

</Render>



{{< /highlight >}}




## **PDF Creator information**
- Please note that you cannot set values against the **Application** and **Producer** fields, because Aspose Ltd. and Aspose.PDF for Reporting Services x.x.x will be displayed against these fields. 
