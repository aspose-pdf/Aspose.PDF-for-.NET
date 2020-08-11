---
title: Install to Visual Studio Report Designer
type: docs
weight: 20
url: /reportingservices/install-to-visual-studio-report-designer/
---

{{% alert color="primary" %}} 

You may want to add Aspose.PDF rendering extension directly to the Visual Studio 2005 or 2008 Report Designer (Business Intelligence Development Studio). This will enable you to export your reports to PDF documents right in design time, without the need to upload the reports to Report Server first.

{{% /alert %}} 

**To do so, please follow these steps (applies to** **Visual Studio** **2008):**

**Step 1.** Open the C:\Program Files\Microsoft Visual Studio 8\Common7\IDE\PrivateAssemblies folder.

**Step 2.** Copy Aspose.PDF.ReportingServices.dll to that folder.

**Step 3.** Register Aspose.PDF for Reporting Services as a rendering extension. To do this, locate RSReportDesigner.config in the folder, open it and add the following lines into the <Render> element:

**Example**

{{< highlight csharp >}}

 <Render>

...

<!--Start here.-->

<Extension Name="APPDF" Type="Aspose.PDF.ReportingServices.Renderer,Aspose.PDF.ReportingServices"/>

</Render>



{{< /highlight >}}

**Step 4.** Give Aspose.PDF for Reporting Services permissions to execute. To do this, locate RSPreviewPolicy.config in the folder, open it and add the following as the last item in the second to outer <CodeGroup> element (which should be <CodeGroup class="FirstMatchCodeGroup" version="1" PermissionSetName="Execution" Description="This code group grants MyComputer code Execution permission.">):

**Example**

{{< highlight csharp >}}

 <CodeGroup>

...

<CodeGroup>

...

<!--Start here.-->

<CodeGroup class="UnionCodeGroup" version="1" PermissionSetName="FullTrust"

Name="Aspose.PDF_for_Reporting_Services" Description="This code group grants full trust to the AP4SSRS assembly.">

<IMembershipCondition class="StrongNameMembershipCondition" version="1" PublicKeyBlob="00240000048000009400000006020000002400005253413100040000010001000734cc24bfcebd7aa8c6e2bf8af5c2b95c7a7e6092abb60d68a7d9efde285cf7dce7f354b44cf3064e8ad85bddfe405ad1e51855d9a1367c15cb34529988feeee0c3279caecdb6dfd7f94c5364d2bd282c4f93493d56d33df36f97da8fd71bb7dc4b0e7f1428b926291cdea7cec1085aa9cc0f6771e4fc2f5772603eee3afaaa" />

</CodeGroup>

<!--End here. -->

</CodeGroup>

</CodeGroup>



{{< /highlight >}}

**Step 5.** Reload Visual Studio.
