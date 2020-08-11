---
title: Integration with JasperReports
type: docs
weight: 20
url: /jasperreports/integration-with-jasperreports/
---

{{% alert color="primary" %}} 

To use Aspose.PDF for JasperReports in your application, copy **aspose.pdf.jasperreports.jar** from the \lib folder in the **Aspose.PDF.JasperReports.zip** to the JasperReports\lib directory, or to a library folder of your application. After that, you can access the exporters programmatically. 

{{% /alert %}} 

The following example shows the typical code needed to export a report to PDF format using Aspose.PDF for JasperReports. More examples can be found in the demo reports included in the product download.

{{< highlight csharp >}}



   import com.aspose.pdf.jr3_7_0.jasperreports.*;

   com.aspose.pdf.jr3_7_0.jasperreports.JrPdfExporter exporter = new com.aspose.pdf. jr3_7_0.jasperreports.JrPdfExporter();



   File sourceFile = new File(fileName);

   JasperPrint jasperPrint = (JasperPrint)JRLoader.loadObject(sourceFile);

   exporter.setParameter(JRExporterParameter.JASPER_PRINT, jasperPrint);



   File destFile = new File(sourceFile.getParent(), jasperPrint.getName() + ".pdf");

   exporter.setParameter(JRExporterParameter.OUTPUT_FILE_NAME, destFile.toString());



   exporter.exportReport(); 



{{< /highlight >}}

The above code snippet has been tested with JasperReports 3.5.2. If using JasperReports 3.1.0, please try using import com.aspose.pdf.jr3_1_0.jasperreports.; and replace the product version in the rest of the code as well. 
