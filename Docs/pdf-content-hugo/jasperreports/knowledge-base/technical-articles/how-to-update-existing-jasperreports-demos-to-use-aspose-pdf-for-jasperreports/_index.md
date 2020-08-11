---
title: How to - Update existing JasperReports demos to use Aspose.Pdf for JasperReports
type: docs
weight: 20
url: /jasperreports/how-to-update-existing-jasperreports-demos-to-use-aspose-pdf-for-jasperreports/
---

{{% alert color="primary" %}} 

Aspose.PDF for JasperReports includes a number of demo projects to help you get started exporting reports to PDF. These demos are based on standard JasperReports demos that have been modified to demonstrate how to use new exporters. This tutorial, goes through the steps required to update the existing JasperReports demos to use Aspose.PDF for JasperReports. 

{{% /alert %}} 
### **Updating Demos to use Aspose.PDF**
The following steps explains how to update existing demos to use Aspose.PDF for JasperReports export extension rather than using JasperReport's standard PDF export feature.

1. Download JasperReports from <http://sourceforge.net/project/showfiles.php?group_id=36382&package_id=28579>.
   Make sure to download the entire archived project with the source code and demos, not just a single JAR. This tutorial was prepared using JasperReports-3.5.2.
1. Unpack the archived project to some location on your hard disk, for example C:\.
1. Copy **aspose.pdf.jasperreports.jar** from the \lib folder in **Aspose.PDF.JasperReports.zip** to <InstallDir>\jasperreports\lib.
1. Open <InstallDir>\jasperreports\demo\samples, (where <InstallDir> is the location you have unpacked JasperReports) to update an existing demo. If you have selected the fonts demo, for example, to use with Aspose.PDF for JasperReports, create a copy of it so that the original demo remains the same. For the purpose of this example, we have named the new folder **fonts.ap**.
   Note: demos will run from <InstallDir>\jasperreports\demo\samples because the demo build scripts rely on the JasperReports' folder structure. If you change the sample folder, you have to modify build scripts.
1. Open the **FontsApp.java** file from the src folder and add a reference to Aspose.PDF for JasperReports: 
   import com.aspose.pdf.jr3_7_0.jasperreports.*;
   (We are using jr3_7_0 because this tutorial was prepared with JasperReports 3.5.2.)
1. Add a new string: 
   private static final String TASK_ASPOSE_PDF = "aspose_pdf"; along with existing variables as an export option via Aspose.PDF for JasperReports.
1. Locate the for else if (TASK_PDF.equals(taskName)) code segment and copy the whole segment.
1. Paste the code snippet under same segment. 

{{< highlight csharp >}}

 else if (TASK_PDF.equals(taskName))

{

  File sourceFile = new File(fileName);

  JasperPrint jasperPrint = (JasperPrint)JRLoader.loadObject(sourceFile);

  File destFile = new File(sourceFile.getParent(), jasperPrint.getName() + ".pdf");

  JRPdfExporter exporter = new JRPdfExporter();

  HashMap fontMap = new HashMap();

  FontKey key = new FontKey("DejaVu Serif", true, false);

  PdfFont font = new PdfFont("DejaVuSerif-Bold.ttf", "Cp1252", true);

  fontMap.put(key, font);

  exporter.setParameter(JRExporterParameter.JASPER_PRINT, jasperPrint);

  exporter.setParameter(JRExporterParameter.OUTPUT_FILE_NAME, destFile.toString());

  exporter.setParameter(JRExporterParameter.FONT_MAP, fontMap);

  exporter.exportReport();

  System.err.println("PDF creation time : " + (System.currentTimeMillis() - start));

}

{{< /highlight >}}

{{< highlight csharp >}}

 update

else if (TASK_PDF.equals(taskName))

as

else if (TASK_ASPOSE_PDF.equals(taskName))

replace

JRPdfExporter exporter = new JRPdfExporter();

with

com.aspose.pdf.jr3_7_0.jasperreports.JrPdfExporter exporter = new com.aspose.pdf.jr3_7_0.jasperreports.JrPdfExporter();

{{< /highlight >}}

1. Open the **build.xml** file.
1. Make a copy of the following segment and place it inside the same file: 

{{< highlight csharp >}}

 <target name="pdf" description="Generat PDF via Aspose.PDF for JasperReports.">

	<java classname="${class.name}">

		<arg value="pdf"/>

		<arg value="${file.name}.jrprint"/>

		<classpath refid="classpath"/>

	</java>

</target>

{{< /highlight >}}

{{< highlight csharp >}}

 update  name="pdf"  as   name="aspose_pdf"

update  <arg value="pdf"/>  as   <arg value="aspose_pdf"/>



{{< /highlight >}}

1. To run the demo: 
   1. Download the ANT tool from <http://ant.apache.org/bindownload.cgi>.
   1. Unpack the ANT tool and set up environment variables as described in the tool’s manual.
   1. Change the current directory to <InstallDir>\demo\hsqldb and run the following command line: 
      ant runServer
1. Open a new command prompt instance and change the current directory to <InstallDir>\demo\samples\fonts.ap and run the following commands in the command line:
1. ant javac – to compile the Java source files of the test application
1. ant compile – to compile the XML report design and produce the .jasper file
1. ant fill – to fill the compiled report design with data and produce the .jrprint file
1. ant aspose_ pdf – to produce a PDF file using Aspose.PDF for JasperReports.
1. Open the resultant PDF (**FontsReport.pdf**) from the <InstallDir>\demo\samples\ fonts.ap\build\reports\ folder.
