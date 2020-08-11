---
title: Installation
type: docs
weight: 60
url: /java/installation/
---

## **Installing Aspose.PDF for Java from Aspose Repository**
Aspose hosts all Java APIs on [Aspose Repository](https://repository.aspose.com/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-pdf). You can easily use Aspose.PDF for Java API directly in your Maven Projects with simple configurations.
### **Specify Aspose Repository Configuration**
First you need to specify Aspose Repository configuration / location in your Maven pom.xml as follows:

{{< highlight java >}}

 <repositories>

    <repository>

        <id>AsposeJavaAPI</id>

        <name>Aspose Java API</name>

        <url>http://repository.aspose.com/repo/</url>

    </repository>

</repositories>

{{< /highlight >}}
### **Define Aspose.PDF for Java API Dependency**
Then define Aspose.PDF for Java API dependency in your pom.xml as follows:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-pdf</artifactId>

        <version>19.11</version>

    </dependency>

</dependencies>

{{< /highlight >}}

After performing above steps, Aspose.PDF for Java dependency will finally be defined in your Maven Project.
### **JDK 11 Compatibility and Usage Guideline**
The API is optimized for Java 11 environment and all the tests and functionality works fine. However, for some classes you should add the external dependency to add classpath of the class: javax.xml.bind.annotation.adapters.HexBinaryAdapter, which was deleted from JRE.

For example:

{{< highlight java >}}

 <dependency>

    <groupId>javax.xml.bind</groupId>

    <artifactId>jaxb-api</artifactId>

    <version>2.3.0</version>

</dependency>

{{< /highlight >}}
