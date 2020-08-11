---
title: Aspose.PDF for JasperReports 19.5
type: docs
weight: 10
url: /jasperreports/aspose-pdf-for-jasperreports-19-5/
---



{{% alert color="primary" %}} 

This page contains release notes for Aspose.PDF for JasperReports 19.5

{{% /alert %}}
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJR-33202|Adaptation Aspose.PDF for JasperReports for FIPS 186-4 standard|New Feature|
|PDFJR-33193|Support PDFsecurity|Enhancement|
|PDFJR-33201|Update the JasperReports with Aspose.PDF version 19.4|Enhancement|
|PDFJR-33200|Synchronize with latest JasperReports version|Enhancement|
|PDFJR-22870|Text margin information is not being honored|Bug|
|PDFJR-29115|Add topic in Documentation on how to apply Security Restrictions|Bug|
### **Public API Changes for version 19.5**
#### **Support PDF security**
Support PDF security configuration.

**usage:**

{{< highlight java >}}

 {

        JasperReport jasperReport = JasperCompileManager

                .compileReport(TESTDATA + "data.jr3.7/text.pdf/FontsTest.jrxml");

        HashMap<String, Object> params = new HashMap<String, Object>();

        params.put(JRParameter.REPORT_LOCALE, Locale.US);

        params.put(JRParameter.REPORT_TIME_ZONE, TimeZone.getTimeZone("GMT"));

        JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport,

                params, new JREmptyDataSource(10));

        JrPdfExporter exporter = new JrPdfExporter();

        SimplePdfExporterConfiguration configuration = new SimplePdfExporterConfiguration();

        configuration.setPermissions(PdfExporterParameter.ALLOW_COPY | PdfExporterParameter.ALLOW_PRINTING);

        configuration.setUserPassword("test1");

        configuration.setOwnerPassword("test2");

        configuration.setEncrypted(true);

        exporter.setConfiguration(configuration);

        exporter.setExporterInput(new SimpleExporterInput(jasperPrint));

        String fileName = TESTOUT + "jr_ALLOW_COPY_&_ALLOW_PRINTING_pass.pdf";


        exporter.setExporterOutput(new SimpleOutputStreamExporterOutput(fileName));


        JrPdfExportParametersBean exportParameters = new JrPdfExportParametersBean();

        exportParameters.setSecuredMode(false);

        HashMap fontMap = new HashMap();

        fontMap.put("SansSerif", "Arial");

        fontMap.put("serif", "Times New Roman");

        fontMap.put("monospaced", "Courier");

        fontMap.put("Aharoni", "Arial");

        exportParameters.setFontsMap(fontMap);

        exporter.setFontsMap(exportParameters.getFontsMap());

        exportParameters.setLicenseFile(TESTDATA + "license/Aspose.PDF.JasperReports.lic");

        exporter.exportReport();

        assertTrue(new File(fileName).exists());

}

{{< /highlight >}}
