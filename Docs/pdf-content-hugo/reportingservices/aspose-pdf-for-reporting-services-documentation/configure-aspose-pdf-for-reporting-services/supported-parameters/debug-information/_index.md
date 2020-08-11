---
title: Debug Information
type: docs
weight: 90
url: /reportingservices/debug-information/
---

{{% alert color="primary" %}} 

It is unavoidable that there is something wrong with the rendering or rendered result. For some reasons such as secrecy or privacy, we could not get the data source used in the user’s report, so could not reproduce the error in the report. To make the communication between customers and developers easier and smoother, we add this parameter. If you meet problems when rendering your report with Aspose.PDF for Reporting Services, please set this report parameter, then you will get the rendered document with the format of XML. After that, please post the XML file for us in the product forum.

{{% /alert %}} 

**Parameter Name**: SavingXmlFormat
**Date Type**: Boolean
**Values supported**: True, False (default)

**Example**

{{< highlight csharp >}}

 <Render>

...

<Extension Name="APPDF" Type=" Aspose.PDF.ReportingServices.Renderer,Aspose.PDF.ReportingServices">

<Configuration>

<SavingXmlFormat > True </SavingXmlFormat>

</Configuration>

</Extension>

</Render>



{{< /highlight >}}
