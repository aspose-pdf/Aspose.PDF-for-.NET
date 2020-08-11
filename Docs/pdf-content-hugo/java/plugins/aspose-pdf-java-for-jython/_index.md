---
title: Aspose.PDF Java for Jython
type: docs
weight: 60
url: /java/aspose-pdf-java-for-jython/
---

## **Introduction**
### **What is Jython?**
Jython is a Java implementation of Python that combines expressive power with clarity. Jython is freely available for both commercial and non-commercial use and is distributed with source code. Jython is complementary to Java and is especially suited for the following tasks:

- **Embedded scripting** - Java programmers can add the Jython libraries to their system to allow end users to write simple or complicated scripts that add functionality to the application.
- **Interactive experimentation** - Jython provides an interactive interpreter that can be used to interact with Java packages or with running Java applications. This allows programmers to experiment and debug any Java system using Jython.
- **Rapid application development** - Python programs are typically 2-10X shorter than the equivalent Java program. This translates directly to increased programmer productivity. The seamless interaction between Python and Java allows developers to freely mix the two languages both during development and in shipping products. 
### **Aspose.PDF for Java**
Aspose.PDF for Java is a PDF document creation component that enables your Java applications to read, write and manipulate PDF documents without using Adobe Acrobat.

Aspose.PDF for Java is an affordably priced component that offers an incredible wealth of features, these include: PDF compression options, table creation and manipulation, graph support, image functions, extensive hyperlink functionality, extended security controls and custom font handling.

Aspose.PDF for Java allows you to create PDF files directly through the provided API and XML templates. Using Aspose.PDF for Java will also enable you to add PDF capabilities to your applications in no time.
### **Aspose.PDF Java for Jython**
Aspose.PDF Java for Jython is a project that demonstrates / provides the Aspose.PDF for Java API usage examples in Jython.
## **System Requirements and Supported Platforms**
### **System Requirements**
**Following are the system requirements to use Aspose.PDF Java for Jython:**

- Java 1.5 or above installed
- Downloaded Aspose.PDF component
- Jython 2.7.0
### **Supported Platforms**
**Following are the supported platforms:**

- Aspose.PDF 15.4 and above.
- Java IDE (Eclipse, NetBeans ...)
## **Download Installation and Usage**
### **Downloading**
**Download Examples from social coding websites**

Following releases of running examples are available to download on all of the below mentioned social coding sites:

- [CodePlex](http://asposepdfjavajython.codeplex.com/releases)
- [Github](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose-Pdf-Java-for-Jython)

**Download Aspose.PDF for Java component**

- [Aspose.PDF for Java](https://downloads.aspose.com/pdf/java)
### **Installing**
- Place downloaded Aspose.PDF for Java jar file into "lib" directory.
- Replace "your-lib" with the downloaded jar filename in _*init*_.py file.
### **Using**
You can convert Pdf to doc document using the following example code:

{{< highlight java >}}

 from aspose-pdf import Settings

from com.aspose.pdf import Document

class PdfToDoc:

    def __init__(self):

        dataDir = Settings.dataDir + 'WorkingWithDocumentConversion/PdfToDoc/'



        # Open the target document

        pdf = Document(dataDir + 'input1.pdf')

        # Save the concatenated output file (the target document)

        pdf.save(dataDir + "output.doc")

        print "Document has been converted successfully"



if __name__ == '__main__':        

    PdfToDoc()

{{< /highlight >}}
## **Support, Extend and Contribute**
### **Support**
From the very first days of Aspose, we knew that just giving our customers good products would not be enough. We also needed to deliver good service. We are developers ourselves and understand how frustrating it is when a technical issue or a quirk in the software stops you from doing what you need to do. We're here to solve problems, not create them.

This is why we offer free support. Anyone who uses our product, whether they have bought them or are using an evaluation, deserves our full attention and respect.

You can log any issues or suggestions related to Aspose.PDF Java for Jython using any of the following platforms:

- [CodePlex](http://asposepdfjavajython.codeplex.com/workitem/list/basic)
- [Github](https://github.com/aspose-pdf/Aspose.PDF-for-Java/issues)
### **Extend and Contribute**
Aspose.PDF Java for Jython is open source and its source code is available on the major social coding websites listed below. Developers are encouraged to download the source code and contribute by suggesting or adding new feature or improving the existing ones, so that others could also benefit from it.
### **Source Code**
You can get the latest source code from one of the following locations

- [CodePlex](http://asposepdfjavajython.codeplex.com/SourceControl/latest)
- [Github](https://github.com/aspose-pdf/Aspose.PDF-for-Java)
