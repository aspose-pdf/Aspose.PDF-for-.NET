<?xml version="1.0" encoding="utf-8" ?> 
  <xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"> 
   <xsl:template match="text()" />
    <xsl:template match="/Contents">
     <Pdf xmlns="Aspose.Pdf"> 
      <Section>
              <Text ID="Text1">
                         <Segment><xsl:value-of select="Content"/></Segment>
         </Text> 
      </Section> 
     </Pdf> 
    </xsl:template> 
  </xsl:stylesheet>