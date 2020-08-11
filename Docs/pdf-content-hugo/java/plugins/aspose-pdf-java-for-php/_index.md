---
title: Aspose.PDF Java for PHP
type: docs
weight: 50
url: /java/aspose-pdf-java-for-php/
---

## **Introduction to Aspose.PDF Java for PHP**
### **PHP / Java Bridge**
The PHP/Java Bridge is an implementation of a streaming, XML-based [network protocol](http://php-java-bridge.sourceforge.net/pjb/PROTOCOL.TXT), which can be used to connect a native script engine, for example PHP, Scheme or Python, with a Java virtual machine. It is up to 50 times faster than local RPC via SOAP, requires less resources on the web-server side. It is [faster](http://php-java-bridge.sourceforge.net/pjb/FAQ.html#performance) and more reliable than direct communication via the Java Native Interface, and it requires no additional components to invoke Java procedures from PHP or PHP procedures from Java.

Read more at [sourceforge.net](http://php-java-bridge.sourceforge.net/pjb/)
### **Aspose.PDF for Java**
Aspose.PDF for Java is a PDF document creation component that enables your Java applications to read, write and manipulate PDF documents without using Adobe Acrobat.

Aspose.PDF for Java is an affordably priced component that offers an incredible wealth of features, these include: PDF compression options, table creation and manipulation, graph support, image functions, extensive hyperlink functionality, extended security controls and custom font handling.

Aspose.PDF for Java allows you to create PDF files directly through the provided API and XML templates. Using Aspose.PDF for Java will also enable you to add PDF capabilities to your applications in no time.
### **Aspose.PDF Java for PHP**
Project Aspose.PDF for PHP shows how different tasks can be performed using Aspose.PDF Java APIs in PHP. This project is aimed to provide useful examples for PHP Developers who want to utilise Aspose.PDF for Java in their PHP Projects using [PHP/Java Bridge](http://php-java-bridge.sourceforge.net/pjb/).
## **System Requirements and Supported Platforms**
### **System Requirements**
**Following are the system requirements to use Aspose.Words Java for PHP:**

- Tomcat Server 8.0 or above installed.
- PHP/JavaBridge is configured.
- FastCGI is installed.
- Downloaded Aspose.PDF component.
### **Supported Platforms**
**Following are the supported platforms:**

- PHP 5.3 or above
- Java 1.8 or above
## **Downloads and Configure**
### **Download Required Libraries**
Download required libraries mentioned below. These are the required for executing Aspose.PDF Java for PHP examples.

- **Aspose:** [Aspose.PDF for Java Component](http://www.aspose.com/community/files/72/java-components/aspose.pdf-for-java/default.aspx)
- [PHP/Java Bridge](http://citylan.dl.sourceforge.net/project/php-java-bridge/Binary%20package/php-java-bridge_6.2.1/php-java-bridge_6.2.1_documentation.zip)
### **Download Examples from Social Coding Sites**
Following releases of running examples are available to download on below mentioned social coding sites:

-----
#### **GitHub**
- **Aspose.PDF Java for PHP Examples**
  - [Aspose.PDF Java for PHP](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_PHP)
### **How to configure the source code on Linux Platform**
Please follow these simple steps in order to open and extend the source code while using:
#### **1. Install Tomcat Server**
To install tomcat server, issue following command on the linux console. This will successfully install tomcat server.

{{< highlight actionscript3 >}}

 sudo apt-get install tomcat8

{{< /highlight >}}
#### **2. Download and Configure PHP/JavaBridge**
In order to download the PHP/JavaBridge binaries, issue following command on the linux console.

{{< highlight actionscript3 >}}

  wget http://citylan.dl.sourceforge.net/project/php-java-bridge/Binary%20package/php-java-bridge_6.2.1/php-java-bridge_6.2.1_documentation.zip 

{{< /highlight >}}


Unzip the PHP/JavaBridge binaries by issuing the following command on linux console.

{{< highlight actionscript3 >}}

  unzip -d php-java-bridge_6.2.1_documentation.zip 

{{< /highlight >}}


This will extract **JavaBridge.war** file. Copy it to tomcat88 **webapps** folder by issuing the following command on Linux console.

{{< highlight actionscript3 >}}

  sudo cp JavaBridge.war /var/lib/tomcat8/webapps/JavaBridge.war 

{{< /highlight >}}


By copying, tomcat8 will automatically create a new folder "**JavaBridge**" in **webapps**. Once the folder is created, make sure your tomcat8 is running and then check <http://localhost:8080/JavaBridge> in browser, it should open a default page of JavaBridge.

If any error message appears then install  **FastCGI** by issuing the following command on Linux console.

{{< highlight actionscript3 >}}

  sudo apt-get install php55-cgi 

{{< /highlight >}}

After installing php5.5 cgi, restart tomcat8 server and check <http://localhost:8080/JavaBridge> again in the browser.

If **JAVA_HOME** error is displayed, then open /etc/default/tomcat8 file and uncomment the line that sets the JAVA_HOME. Check <http://localhost:8080/JavaBridge> in browser again, it should come with PHP/JavaBridge Examples page. 
#### **3. Configure Aspose.PDF Java for PHP Examples**
Clone, PHP examples by issuing the following commands inside webapps/JavaBridge folder. 

{{< highlight actionscript3 >}}

 $ git init&nbsp;

$ git clone [https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose.PDF-for-Java_for_PHP] 

{{< /highlight >}}


### **How to configure the source code on Windows Platform**
Please follow below simple steps to configure PHP/Java Bridge on Windows Platform

\1. Install PHP5 and configure as you normally do
\2. Install JRE 6 (Java Runtime Environment) if you don’t already have it. You can check this in C:\Program Files etc. You can download it here . I am using JRE 6 as It is compatible with PHP Java Bridge (PJB).

\3. Install Apache Tomcat 8.0. You can download it here

4.Download [JavaBridge.war](http://sourceforge.net/projects/php-java-bridge/files/Binary%20package/php-java-bridge_6.2.1/JavaBridgeTemplate621.war/download). Copy this file to tomcat webapps directory.
(ex: C:\Program Files\Apache Software Foundation\Tomcat 8.0\webapps )

\5. Restart tomcat apache service.

6.Go to <http://localhost:8080/JavaBridge/test.php> to check if php works. You can find other examples in there

7.Copy your [Aspose.PDF Java](http://www.aspose.com/community/files/72/java-components/aspose.pdf-for-java/default.aspx) jar file to C:\Program Files\Apache Software Foundation\Tomcat 8.0\webapps\JavaBridge\WEB-INF\lib

\8. Clone [Aspose.PDF Java for PHP](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose.PDF-for-Java_for_PHP) examples inside C:\Program Files\Apache Software Foundation\Tomcat 8.0\webapps\ folder.

\8. Copy folder C:\Program Files\Apache Software Foundation\Tomcat 8.0\webapps\JavaBridge\java to your Aspose.PDF Java for PHP examples folder.

\10. Restart apache tomcat service and start using examples.
## **Support, Extend and Contribute**
### **Support**
From the very first days of Aspose, we knew that just giving our customers good products would not be enough. We also needed to deliver good service. We are developers ourselves and understand how frustrating it is when a technical issue or a quirk in the software stops you from doing what you need to do. We're here to solve problems, not create them.

This is why we offer free support. Anyone who uses our product, whether they have bought them or are using an evaluation, deserves our full attention and respect.

You can log any issues or suggestions related to Aspose.Cells Java for PHP using any of the following platforms:

- [Github](https://github.com/aspose-pdf/Aspose.PDF-for-Java/issues)
### **Extend and Contribute**
Aspose.PDF Java for PHP is open source and its source code is available on the major social coding websites listed below. Developers are encouraged to download the source code and contribute by suggesting or adding new feature or improving the existing ones, so that others could also benefit from it.
### **Source Code**
You can get the latest source code from one of the following locations

- [Github](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_PHP)
