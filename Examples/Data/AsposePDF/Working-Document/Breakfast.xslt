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