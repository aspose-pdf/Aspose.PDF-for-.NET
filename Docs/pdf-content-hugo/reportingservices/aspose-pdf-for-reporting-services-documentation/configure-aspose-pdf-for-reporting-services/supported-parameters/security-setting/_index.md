---
title: Security Setting
type: docs
weight: 30
url: /reportingservices/security-setting/
---

{{% alert color="primary" %}} 

Security is an important issue in every aspect of business, from network protection to PDF documents. Documents are made secure for a range of reasons: the author may want to keep the content of the document safe and doesn't want to allow others to change it, for example. 

{{% /alert %}} 

Aspose.PDF for Reporting Services provides features that can be useful for protecting PDF documents. It contains certain properties that allow developers to apply several security measures to PDF documents.

One of these security measures is to password protect the PDF document during encryption. You can also restrict or allow content modification, copying the content, document printing or allowing/disabling form filling. 

These features are currently not supported by SQL Reporting Services but can be implemented using Aspose.PDF for Reporting Services. Just add the corresponding security parameters to the report or report server and you will get secure PDF document with limited privileges.

Currently, the Aspose.PDF for Reporting Services renderer supports following security attributes:

**Parameter Name**: User Password
**Date Type**: String
**Values supported**:

**Parameter Name**: Master Password
**Date Type**: String
**Values supported**:

**Parameter Name**: IsCopyingAllowed
**Date Type**: Boolean
**Values supported**: True, False (default)

**Parameter Name**: IsPrintingAllowed
**Date Type**: Boolean
**Values supported**: True, False (default)

**Parameter Name**: IsContentsModifyingAllowed
**Date Type**: Boolean
**Values supported**: True, False (default)

**Parameter Name**: IsFormFillingAllowed
**Date Type**: Boolean
**Values supported**: True, False (default)

**Example**

{{< highlight csharp >}}

 <Render>

...

<Extension Name="APPDF" Type="Aspose.PDF.ReportingServices.Renderer,Aspose.PDF.ReportingServices">

<Configuration>

< UserPassword >aspose</UserPassword>

< IsCopyingAllowed >False</IsCopyingAllowed>

< IsPrintingAllowed >False</IsPrintingAllowed>

</Configuration>

</Extension>

</Render>



{{< /highlight >}}
