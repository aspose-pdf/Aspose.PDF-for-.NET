---
title: Install Aspose.PDF for Android via Java
type: docs
weight: 60
url: /java/install-aspose-pdf-for-android-via-java/
---

{{% alert color="primary" %}} 

The machine that runs Aspose.PDF for Android via Java does not need to have [Adobe Acrobat](http://www.adobe.com/products/acrobatpro/main.html) installed to produce PDF documents. Aspose.PDF for Android via Java is a PDF document creation engine. However, to view PDF documents produced by Aspose.PDF for Android via Java, the machine does need at least an [Adobe Acrobat Reader](http://www.adobe.com/products/acrobat/readermain.html). It can be [downloaded](http://www.adobe.com/products/acrobat/readermain.html) for free.

{{% /alert %}} 
### **Supported Android OS versions**
Aspose.PDF for Android via Java is platform independent and can be used on any platform where Android Runtime environment is installed and will run on Android systems running Android OS 2.0 or higher. At present, the component has been tested with:

- Android 4.2 v 17
### **Installation**
1. Download the latest version of Aspose.PDF for Android via Java from [Aspose Repository](https://repository.aspose.com/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-pdf-android-via-java).
1. Unzip the installation package and copy the aspose.pdf.android-4.0.jar file to your Java application.
1. Provide a reference to the aspose.pdf.android-4.0.jar file so the compiler can find it.
### **Install Aspose.PDF for Android via Java from Aspose Repository**
1. Add maven repository into your build.gradle 
1. Add 'Aspose.PDF for Android via Java' JAR as a dependency

{{< highlight java >}}

 // 1. Add maven repository into your build.gradle 

repositories {

    mavenCentral()

    maven { url "http://repository.aspose.com/repo/" }

}



// 2. Add 'Aspose.PDF for Android via Java' JAR as a dependency

dependencies {

    ...

    ...

    compile (group: 'com.aspose', name: 'aspose-pdf', version: '18.6', classifier: 'android.via.java')

}

{{< /highlight >}}
