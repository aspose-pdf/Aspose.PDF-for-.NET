---
title: Aspose.Pdf for JasperReports 1.6.0
type: docs
weight: 10
url: /jasperreports/aspose-pdf-for-jasperreports-1-6-0/
---

**Public API Changes for Aspose.PDF for JasperReports 1.6.0**

- All internal classes and packages were moved into the package **com.aspose.pdf.jrinternal.*** to avoid conflicts with other libraries. 
- Very old versions of JasperReports are not supported now. The baseline version is **JasperReports 5.6.0, which was released on 2014-08-04.** 
- **com.aspose.pdf.License** has been moved into **com.aspose.pdf.jr.License** 
- Packages are not binding with the jasper version anymore. The main package from now is **com.aspose.pdf.jr.*** 
- We have implement **new pdf engine** with lot of improvements to increase the quality of conversion. 
- Styled text is processing now.
  If textElement has **markup="styled"** - the style tegs inside this element will be applied for the text.
  For example:

{{< highlight java >}}

 <textElement markup="styled">

<style size="32">StyledText</style>

<style isBold="true">StyledText</style>

<style isItalic="true">StyledText</style>

<style isUnderline="true">StyledText</style>

<style isStrikeThrough="true">StyledText</style>

<style forecolor="red">StyledText</style>

<style backcolor="blue" forecolor="white" isBold="true">StyledText</style>

<style isBold="true" isItalic="true" isUnderline="true">StyledText</style>

<font size="12">StyledText</font>

<font color="red">StyledText</font>

<font face="DejaVu Serif">StyledText</font>

<b>StyledText</b>

<i>StyledText</i>

<u>StyledText</u>

<sup>StyledText</sup>

<sub>StyledText</sub>

</textElement>

{{< /highlight >}}

- The aditional field (**PdfFormatType**) has been added to **com.aspose.pdf.jr.jasperreports.JrPdfExportParametersBean** class:
  Additional methods:
  ` `-public void setPdfFormatType(String pdfFormat)
  ` `-public int getPdfFormatType()
  `  `in the xml been we can configure the pdf format type using the one of the values from the class com.aspose.pdf.jr.PdfFormatType:

{{< highlight java >}}

  <bean id="pdfAPExportParameters">

 <property name="PdfFormatType" value="PDF_A_3A"/>

 <property name="PdfAMode" value="true"/>

 </bean>

{{< /highlight >}}

- Additional methods were added for the class: **com.aspose.pdf.jr.SavingFormatType** 
  -public static String getNameByValue(int value)
  -public static int getValueByName(String name)
- Additional values have been implemented in the class **com.aspose.pdf.jr.SavingFormatType** 
  -public static final int XML = 4; //implemented conversion into pdf->xml
  -public static final int TEX = 5; //implemented conversion into pdf->tex
- Additional methods were added for the class: **com.aspose.pdf.jr.PdfFormatType** 
  -public static String getNameByValue(int value)
  -public static int getValueByName(String name)  
