---
title: Create a Hello World PDF Document through XML and XSLT
type: docs
weight: 30
url: /net/create-a-hello-world-pdf-document-through-xml-and-xslt/
---

## **Create a Hello World PDF Document through XML and XSLT**
Sometimes you may have existing XML files that contain application data and you want to generate PDF report using these files. You can use XSLT to transform your existing XML document to Aspose.Pdf's compatible XML document and then generate PDF file. There are 3 steps to generate PDF using XML and XSLT.

Please follow these steps to convert an XML file into a PDF document using XSLT:

- Create an instance of [PDF](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class that represents a PDF document 
- If you have purchased a license then you should also embed the code to use that license with the help of [License](https://apireference.aspose.com/net/pdf/aspose.pdf/license) class in [Aspose.Pdf](https://apireference.aspose.com/net/pdf/aspose.pdf/) namespace 
- Bind the input XML and XSLT files to the instance of [PDF](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class by calling its [BindXML](https://apireference.aspose.com/net/pdf/aspose.pdf.document/bindxml/methods/4) method 
- [Save](https://apireference.aspose.com/net/pdf/aspose.pdf.document/save/methods/4) the bound XML with [PDF](https://apireference.aspose.com/net/pdf/aspose.pdf/document) instance as a PDF document 
### **Input XML File**
{{< highlight java >}}

 <?xml version="1.0" encoding="utf-8" ?>

<Contents>

  <Content>Hello World!</Content>

</Contents>

{{< /highlight >}}
### **Input XSLT File**
{{< highlight java >}}

 <?xml version="1.0" encoding="utf-8" ?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

    <xsl:template match="text()"/>

    <xsl:template match="/Contents">

    <html>

      <Document xmlns="Aspose.Pdf" IsAutoHyphenated="false">

        <PageInfo>

          <DefaultTextState

                            Font = "Helvetica" FontSize="8" LineSpacing="4"/>

          <Margin Left="5cm" Right="5cm" Top="3cm" Bottom="15cm" />

        </PageInfo>

        <Page id="mainSection">

          <TextFragment>

            <TextSegment>

              <xsl:value-of select="Content"/>

            </TextSegment>

          </TextFragment>

        </Page>

      </Document>

    </html>

</xsl:template>

</xsl:stylesheet>

{{< /highlight >}}
### **Code Snippet**
{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-HelloWorldPDFUsingXmlAndXslt-HelloWorldPDFUsingXmlAndXslt.cs" >}}



