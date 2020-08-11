---
title: Breakfast Menu Using XML and XSLT
type: docs
weight: 40
url: /net/breakfast-menu-using-xml-and-xslt/
---

## **Breakfast Menu Using XML and XSLT**
Using the [Supported XML Schema](/pdf/net/supported-xml-schema/), you can create PDF using XML and XSLT as per your needs. You can easily create a PDF file using the [BindXML](https://apireference.aspose.com/net/pdf/aspose.pdf.document/bindxml/methods/4) method of Document class. The following sample files and code snippet is used to get a PDF file using XML and XSLT.
### **Input XML File**
{{< highlight java >}}

 <?xml version="1.0" encoding="UTF-8"?>

<breakfast_menu>

<food>

<name>Belgian Waffles</name>

<price>$5.95</price>

<description>Two of our famous Belgian Waffles with plenty of real maple syrup</description>

</food>

<food>

<name>Strawberry Belgian Waffles</name>

<price>$7.95</price>

<description>Light Belgian waffles covered with strawberries and whipped cream</description>

</food>

<food>

<name>Berry-Berry Belgian Waffles</name>

<price>$8.95</price>

<description>Light Belgian waffles covered with an assortment of fresh berries and whipped cream</description>

<calories>900</calories>

</food>

<food>

<name>French Toast</name>

<price>$4.50</price>

<description>Thick slices made from our homemade sourdough bread</description>

</food>

<food>

<name>Homestyle Breakfast</name>

<price>$6.95</price>

<description>Two eggs, bacon or sausage, toast, and our ever-popular hash browns</description>

</food>

</breakfast_menu>


{{< /highlight >}}
### **Input XSLT File**
{{< highlight java >}}

 <?xml version="1.0"

      encoding="utf-8" ?>

<xsl:stylesheet version="1.0"

                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="text()" />

  <xsl:template match="/">

    <Document xmlns="Aspose.Pdf" IsAutoHyphenated="false">

  <PageInfo>

    <DefaultTextState 

    ForegroundColor="#58595B"

    Font = "Helvetica" 

    FontSize="12"

    LineSpacing="4"/>

    <Margin Left="1.8cm" Right="1.6cm" Top="2.0cm" Bottom="2.2cm" />

  </PageInfo>

        <Page>

          <xsl:for-each select="/breakfast_menu/food">

            <TextFragment >

              <TextSegment>

                <TextState 

                    ForegroundColor="#2e8735"

                    Font = "Helvetica-Bold" 

                    FontSize="14"

                  />

                <xsl:value-of select="name"/>

              </TextSegment>

            </TextFragment>

            <Table>

              <Row>

                <Cell ColSpan="70">

                  <TextFragment>

                    <TextSegment>

                      <xsl:value-of select="description"/>

                    </TextSegment> 

                  </TextFragment>

                </Cell>

                <Cell ColSpan="30">

                  <TextFragment>

                    <TextSegment>

                      <xsl:value-of select="price"/>

                    </TextSegment> 

                  </TextFragment>

                </Cell>

              </Row>

            </Table>

          </xsl:for-each>

        </Page>

    </Document>

  </xsl:template>

</xsl:stylesheet>


{{< /highlight >}}
### **Code Snippet**
{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-With-XML-XSLT-BreakfastMenuUsingXmlAndXslt-1.cs" >}}




