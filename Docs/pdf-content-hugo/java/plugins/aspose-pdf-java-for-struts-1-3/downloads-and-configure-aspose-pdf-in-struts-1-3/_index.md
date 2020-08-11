---
title: Downloads and Configure Aspose.Pdf in Struts 1.3
type: docs
weight: 10
url: /java/downloads-and-configure-aspose-pdf-in-struts-1-3/
---

## **Downloading Aspose.PDF Java for Struts 1.3**
You can downloaded the pre-built (binary) .war file from the latest releases hosted on [codeplex](http://aspose-pdfforstruts.codeplex.com/releases).

-OR-

You can download / check out the project source codes from the following locations:

- [CodePlex](https://asposepdfforstruts.codeplex.com)
- [Github](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_for_Struts)
## **Building Aspose.PDF Java for Struts 1.3 from Source Codes**
After checking out source codes from any of the above repository, apply the following mvn commands:

{{< highlight java >}}

 $ mvn -U clean package 

{{< /highlight >}}

This will build "Strutsbookapp.war" in the target tolder.

To deploy the .war file just copy it to the running Apache tomcat server webapp directory.
