---
title: Migration from Pre 4.x.x version of Aspose.PDF for Java
type: docs
weight: 20
url: /java/migration-from-pre-4-x-x-version-of-aspose-pdf-for-java/
---

{{% alert color="primary" %}} 

A new auto-ported version of Aspose.PDF for Java has been released and now this single product supports the capability to generate PDF documents from scratch as well as provides the capability to manipulate existing PDF documents.

{{% /alert %}} 
#### **Product binaries**
In first release version (v4.0.0), we are shipping two jar files i.e. **aspose.pdf-3.3.0.jdk15.jar** and **aspose.pdf-new-4.0.0.jar**.

- **aspose.pdf-3.3.0.jdk14.jar** 
  This jar file is the same product version as currently available under the download module with title [Aspose.PDF for java 3.3.0](http://www.aspose.com/community/files/72/java-components/aspose.pdf-for-java/entry417659.aspx). Further onward, we are going to call this release version as legacy Aspose.PDF for Java. In this first release, existing users of Aspose.PDF for Java might not be impacted because they get the same release version. However, sometimes sooner, we will be removing this separate jar file and all the classes and enumerations of legacy Aspose.PDF for Java (pre 4.x.x) will become available under com.aspose.pdf.generator package of single aspose.pdf-new-4.x.x.jar file.
- **aspose.pdf-new-4.0.0.jar** 
  This jar file is an actual new auto-ported version of Aspose.PDF for .NET to Java platform. This jar file contains the new Document Object Model (DOM) to create as well as manipulate existing PDF files and also the current Aspose.PDF.Kit for Java. All the classes and enumerations of Aspose.PDF.Kit for Java is bundled under com.aspose.pdf.facades package and in Q3 of 2013, Aspose.PDF.Kit for Java will be discontinued. Therefore we encourage our current Aspose.PDF.Kit for Java customers to try migrating their code to new auto-ported release.

Please check out the following blog post to get more insight about [Structure of autoported Aspose.PDF for Java](http://www.aspose.com/blogs/aspose-products/aspose-pdf-product-family/archive/2013/04/07/jump-start-about-autoported-aspose.pdf-for-java.html).
