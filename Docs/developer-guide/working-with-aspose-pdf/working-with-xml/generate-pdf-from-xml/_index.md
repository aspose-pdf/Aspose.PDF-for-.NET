---
title: Generate PDF from XML
type: docs
weight: 20
url: /net/generate-pdf-from-xml/
---

## **Convert XML file to PDF**
Aspose.PDF for .NET provides the opportunity to convert an XML file into PDF document requiring that the input XML file must follow the [Aspose.PDF for .NET Schema](https://github.com/aspose-pdf/Aspose.PDF-for-.NET/tree/master/Artifacts).
### **Access TextFragement and TextSegment elements from XML file**
BindXML() method offers the feature to load XML file contents and Document.save() method can be used to save the output in PDF format. However during conversion, we can also access individual elements inside XML and use XML as template. The following code snippet shows the steps to access TextSegments from XML file.

**XML**

{{< highlight html >}}

 <?xml version="1.0" encoding="utf-8" ?>

<Document xmlns="Aspose.Pdf">

  <Page id="mainSection">

    <TextFragment>

      <TextSegment id="boldHtml">segment1</TextSegment>

    </TextFragment>

    <TextFragment>

      <TextSegment id="strongHtml">segment2</TextSegment>

    </TextFragment>

  </Page>

</Document>

{{< /highlight >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-XMLToPDF-XMLToPDF.cs" >}}
### **Add HtmlFragment element in XML file**
As HTML contains tags similar to XML, so when you write HTML inside any XML tag, the parser treats it as XML markups and they simply cannot be recognized as XML tags. The issue can be overcome by using "CDATA" Section in XML. The CDATA Section contains text which is not parsed by the parser or in other words, it is not treated as XML markups. Following sample XML template shows how to add HtmlFragment inside XML markups by using CDATA.

**XML**

{{< highlight html >}}

 <?xml version="1.0" encoding="utf-8" ?>

<Document xmlns="Aspose.Pdf">

  <Page id="mainSection">

    <HtmlFragment>

      <![CDATA[

        <font style="font-family:Tahoma; font-size:40px;">This is Html String.</font>

        ]]>

    </HtmlFragment>

  </Page>

</Document>

{{< /highlight >}}
### **Set Image Path While Converting XML to PDF**
Following XML template contains an <Image> tag in it with an ID "testImg". In case you want to set image path from your code, you can access Image element from XML template during conversion process and set path to your desired address for image.

**XML**

{{< highlight html >}}

 <?xml version="1.0" encoding="utf-8" ?>

<Document xmlns="Aspose.Pdf">

 <Page id="mainSection">

 	<PageInfo IsLandscape="true">

 		<Margin Left="20" Right="20" Top="10" Bottom="30" />

 	</PageInfo>

 	<Header>

 		<Margin Top="20" />

 		<Table ColumnAdjustment="AutoFitToWindow">

 			<Row>

 				<Cell Alignment="1">

 					<Image File="logo.png" Id = "testImg"></Image>

 				</Cell>

 				<Cell Alignment="3">

 					<TextFragment>

 						<TextSegment>Page $p / $P</TextSegment>

 					</TextFragment>

 				</Cell>

 			</Row>

 		</Table>

 	</Header>

 	<Table ColumnAdjustment="AutoFitToWindow" ColumnWidths="8 10">

 	<DefaultCellPadding Top="0" Left="0" Right="0" Bottom="0" />

 	<Margin Top="15" />

 	<Row>

 		<Cell Alignment="1">

 		<!--Logo-->

 			<TextFragment>

 				<TextSegment> Request ID</TextSegment>

 				<TextState FontSize="14" ForegroundColor="#0e4f9c" FontStyle="1" /> 

 			</TextFragment>

 			<TextFragment>

 				<TextSegment></TextSegment>

 			</TextFragment>

 			<TextFragment>

 				<TextSegment id="boldtext">Some Bold Text</TextSegment>

 				<TextState FontSize="14" FontStyle="1"></TextState>

 			</TextFragment>

 		</Cell>

 	</Row>

 	</Table>

 </Page>

</Document>

{{< /highlight >}}

Code to set image path in XML template is as follows:



{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-XMLToPDFSetImagePath-1.cs" >}}
