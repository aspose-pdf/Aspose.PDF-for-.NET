---
title: PDF_A Conformance
type: docs
weight: 100
url: /reportingservices/pdf_a-conformance/
---

{{% alert color="primary" %}} 

Please visit the following link to get some introduction about PDF Conformance from '[How to Create PDF/A-1 with Aspose.PDF](/pages/createpage.action?spaceKey=pdfnet&title=How+to+++Create+PDF+A+1+with+Aspose.PDF)'.

{{% /alert %}} 

If you want to support creation of PDF/A, please add report parameter as the following:

**Parameter Name**: PdfConformance
**Date Type**: String
**Values supported**: PdfA1A, PdfA1B 

**Example**

{{< highlight csharp >}}

 <Render>

...

<Extension Name="APPDF" Type=" Aspose.PDF.ReportingServices.Renderer, Aspose.PDF.ReportingServices">

<Configuration>

<PdfConformance>PdfA1A</PdfConformance>

</Configuration>

</Extension>

</Render>



{{< /highlight >}}
