---
title: PageSize
type: docs
weight: 60
url: /reportingservices/pagesize/
---

{{% alert color="primary" %}} 

The RS designer does not support setting different page size such as A4, B5, Letter and so on. With Aspose.PDF for Reporting Services, however, you can. 

{{% /alert %}} 

**Parameter Name**: PageSize
**Date Type**: String
**Values supported**: A0, A1, A2, A3, A4, A5, A6, B5, Letter, Legal, Ledger, P11x17

**Example**

{{< highlight csharp >}}

 <Render>

...

<Extension Name="APPDF" Type=" Aspose.PDF.ReportingServices.Renderer, Aspose.PDF.ReportingServices">

<Configuration>

<PageSize >A4</PageSize>

</Configuration>

</Extension>

</Render>



{{< /highlight >}}
