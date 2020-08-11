---
title: Working with JasperReports
type: docs
weight: 10
url: /jasperreports/working-with-jasperreports/
---

{{% alert color="primary" %}} 

Aspose.Words for JasperReports is available for free, time unlimited evaluation from the download page. The evaluation and licensed versions of the product is the same download.

When you are happy with the evaluation version, [purchase a license](http://www.aspose.com/purchase/default.aspx). Make sure you understand and agree to the license terms.

{{% /alert %}} 

The license is available for download from the order page after the order was paid. The license is a clear text, digitally signed XML file. The license contains information such as the client name, the purchased product and the type of the license. Do not modify the content of the license file: it invalidates the license.

There are several ways to activate a license:

- [Call setLicense](/pdf/jasperreports/working-with-jasperreports-html/).
- [Set an exporter parameter in the code](/pdf/jasperreports/working-with-jasperreports-html/).
- [Set an exporter parameter in **applicationContext.xml**](/pdf/jasperreports/working-with-jasperserver-html/).

The first two are used with JasperReports, the last with JasperServer.
#### **Call setLicense**
This method is used with JasperReports. 

1. Download the license to your computer and copy it to the appropriate folder (for example your application's folder or JasperReports\lib).
1. Add the following code to your project: 

{{< highlight csharp >}}



import com.aspose.pdf.jr3_7_0.jasperreports.*;



try

{  

   // create a stream object containing the license file

   FileInputStream fstream = new FileInputStream("C:\\Aspose.PDF.JasperReports.lic");



   // Set the license through the stream object

   License license = new License();

   license.setLicense(fstream);

}

catch(Exception ex)

{

   System.out.println(ex.toString());

}

{{< /highlight >}}
#### **Set the licenseFile Exporter Parameter in the Code**
{{% alert color="primary" %}} 

This method is used with JasperReports. 

{{% /alert %}} 

1. Download the license to your computer and copy it to the appropriate folder (for example your application’s folder or JasperReports\lib).
1. Add the following code to your project: 

{{< highlight csharp >}}

 import com.aspose.pdf.jr3_7_0.jasperreports.*;



com.aspose.pdf.jr3_7_0.jasperreports.JrPdfExporter exporter = new com.aspose.pdf.jr3_7_0.jasperreports.JrPdfExporter();

exporter.setParameter(PdfExporterParameter.LICENSE, "Aspose.PDF.JasperReports.lic");

exporter.exportReport();

{{< /highlight >}}
