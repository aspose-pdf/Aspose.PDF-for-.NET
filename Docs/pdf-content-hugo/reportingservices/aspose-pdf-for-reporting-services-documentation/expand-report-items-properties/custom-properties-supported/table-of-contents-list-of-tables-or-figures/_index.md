---
title: Table of Contents List of Tables or Figures
type: docs
weight: 10
url: /reportingservices/table-of-contents-list-of-tables-or-figures/
---

{{% alert color="primary" %}} 

Report Designer does not support adding table of contents for report documents. With Aspose.PDF for Reporting Services you can easily instruct the PDF render to produce PDF documents with Table of Contents, List of Tables or Figures. You should do as the following steps:

{{% /alert %}} 

**1-** Make sure that Aspose.PDF.ListSectionStyle.xml file exists in <Instance>/bin, where < Instance> is the directory of Report Server. If the file does not exist, please create and edit it as the following code, and copy it to <Instance>/bin.
##### **Table of Contents**
**Example**

{{< highlight csharp >}}

 <ListSection ListType="TableOfContents">

	<Title Alignment="Center">

            <Segment IsTrueTypeFontBold="true" FontSize="30">TableOfContents</Segment>

	</Title>

	<ListLevelFormat Level="1" LeftMargin="0">

            <TextInfo IsTrueTypeFontBold="true" IsTrueTypeFontItalic="true"></TextInfo>

	</ListLevelFormat>

	<ListLevelFormat Level="2" LeftMargin="10">

            <TextInfo IsUnderline="true" FontSize="10"></TextInfo>

	</ListLevelFormat>

	<ListLevelFormat Level="3" LeftMargin="20">

            <TextInfo IsTrueTypeFontBold="true"></TextInfo>

	</ListLevelFormat>

	<ListLevelFormat Level="4" LeftMargin="30">

            <TextInfo IsTrueTypeFontBold="true"></TextInfo>

	</ListLevelFormat>

</ListSection>



{{< /highlight >}}
##### **List of Tables**
**Example**

{{< highlight csharp >}}

 <ListSection ListType="ListOfTables">

	<Title>

            <Segment IsTrueTypeFontBold="true" FontSize="30">ListOfTables</Segment>

	</Title>

</ListSection>



{{< /highlight >}}
##### **List of Figures**
**Example**

{{< highlight csharp >}}

 <ListSection ListType="ListOfFigures">

	<Title>

            <Segment IsTrueTypeFontBold="true" FontSize="30">ListOfFigures</Segment>

	</Title>

</ListSection>



{{< /highlight >}}

**2-** Add report parameter 'IsListSectionSupported' and set the value to be True as the chapter 'List Section'.
**3-** Add custom property for your report item you want to be listed in Table of Contents, List of Tables or Figures.

Please refer to '[List Section](/pages/createpage.action?spaceKey=pdfnet&title=Manipulating+List+of+Contents)' for further details, as specified in Aspose.PDF for .NET documentation.

**Custom Property Name** :IsInList
**Property Value** :Boolean
**Custom Property Value** : True or False

{{% alert color="primary" %}} 

Which means that the current report item could be listed by index in the tables of contents, list of tables or figures.

{{% /alert %}} 

**Custom Property Name** : Title
**Custom Property Type** : String

Which means the title displayed in the table of contents, list of tables or figures.

**Custom Property Name** : ListLevel
**Custom Property Type** : Integer

{{% alert color="primary" %}} 

Which means the level of listed items displayed in the table of contents.

{{% /alert %}}
