---
title: Justify FullJustify Text Alignment
type: docs
weight: 40
url: /reportingservices/justify-fulljustify-text-alignment/
---

{{% alert color="primary" %}} 

Report builder does not support the capability to specify text alignment for textbox “Justify” and “FullJustify”. With Aspose.PDF for Reporting Services, you can do that easily by adding custom properties.

{{% /alert %}} 

**Custom Property Name** : TextAlignment
**Custom Property Type** : String
**Custom Property Values** : Justify, FullJustify

In report the code should be like the following:

**Example**

{{< highlight csharp >}}

 <Textbox Name="textbox1">

<value> AsposePdf4RS </value>

  <CustomProperties>

   <CustomProperty>

     <Name>Aspose.TextAlignment</Name>

     <Value>Justify</Value>

   </CustomProperty>

  </CustomProperties>

</Textbox>



{{< /highlight >}}
