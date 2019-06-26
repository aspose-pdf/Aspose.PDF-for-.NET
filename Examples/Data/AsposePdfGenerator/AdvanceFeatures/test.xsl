<?xml version="1.0" encoding="utf-8" ?> 
  <xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"> 
   <xsl:template match="/"> 
       <Pdf xmlns="Aspose.Pdf"> 
         <Section> 
                 <Header> 
                         <xsl:copy-of select="document('header.xml')"/> 
                 </Header> 
                 <xsl:copy-of select="document('content.xml')"/> 
         </Section> 
       </Pdf> 
   </xsl:template> 
 </xsl:stylesheet>