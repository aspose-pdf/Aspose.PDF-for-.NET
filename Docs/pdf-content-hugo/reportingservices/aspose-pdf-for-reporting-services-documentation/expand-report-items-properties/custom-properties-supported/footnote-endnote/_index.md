---
title: Footnote Endnote
type: docs
weight: 30
url: /reportingservices/footnote-endnote/
---

{{% alert color="primary" %}} 

Report builder cannot set the footnote or endnote for textboxes. With Aspose.PDF for Reporting Services, you can do that easily by adding custom properties.

{{% /alert %}} 

Footnote
**Custom Property** **Name**: Footnote
**Custom Property Value**: *the* *value* *should* *be* *a* *string*

Endnote
**Custom Property** **Name**: Endnote
**Custom Property Value**: *the* *value* *should* *be* *a* *string*

For example, the content of some Textbox in the current report is 'AsposePdf4RS', you want to describe the phrase ‘AsposePdf4RS’ in detail with the style of footnote, which content is "An optional PDF renderer for SSRS from Aspose Cop".

In SSRS2005, the code should be like the following:

**Example**

{{< highlight csharp >}}

 <Textbox Name="textbox1">

	......

    <Style>

      ......

</style>

<value> AsposePdf4RS </value>

    <CustomProperties>

      <CustomProperty>

        <Name>Footnote</Name>

        <Value> An optional PDF renderer for SSRS from Aspose Cop. </Value>

      </CustomProperty>

    </CustomProperties>

</Textbox>



{{< /highlight >}}

In SSRS2008, the code should be like the following:  

**Example**

{{< highlight csharp >}}

 <Textbox Name="Textbox1">

...

<Paragraphs>

	 <Paragraph>

	     <TextRuns>

	         <TextRun>

		 ......

		 <Value> AsposePdf4RS </Value>

		 <Style>

		   ......

		 </Style>

                    <CustomProperties>

                 <CustomProperty>

        	<Name>Footnote</Name>

        	<Value> An optional PDF renderer for SSRS from Aspose Cop. </Value>

      	    </CustomProperty>

   	</CustomProperties>

	         </TextRun>

	     </TextRuns>

</Paragraph>

</Paragraphs>

</Textbox>



{{< /highlight >}}
