---
title: Applying a License
type: docs
weight: 10
url: /java/applying-a-license/
---

{{% alert color="primary" %}} 

You can download an evaluation version of **Aspose.PDF** for Java from [Aspose Repository](https://repository.aspose.com/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-pdf). The evaluation version provides absolutely the same capabilities as the licensed version of the product. Furthermore, evaluation version simply becomes licensed when you purchase a license and add a couple of lines of code to apply the license.

Once you are happy with your evaluation of **Aspose.PDF**, you can [purchase a license](https://purchase.aspose.com/) at the Aspose website. Make yourself familiar with the different subscription types offered. If you have any questions, do not hesitate to contact the Aspose sales team.

Every Aspose license carries a one-year subscription for free upgrades to any new versions or fixes that come out during this time. Technical support is free and unlimited and provided both to licensed and evaluation users.

{{% /alert %}} 
### **Evaluation Version Limitations**
The evaluation version of Aspose.PDF for Java provides full product functionality, with a couple of restrictions.

All pages of the generated PDF documents are watermarked with "Evaluation Only. Created with Aspose.PDF. Copyright 2002-2016 Aspose Pty Ltd" as demos run with an evaluation license. The watermark inserted by the evaluation version are shown below.

|![todo:image_alt_text](http://i.imgur.com/bNVuzsU.png)|
| :- |
|**Figure: A file showing the evaluation watermark**|
### **Setting a License**
The license is a plain text XML file that contains details such as the product name, number of developers it is licensed to, subscription expiry date and so on. The file is digitally signed, so do not modify the file; even the inadvertent addition of an extra line break into the file will invalidate it.

You need to set a license before performing any operations with documents. You are only required to set a license once per application or process.

The license can be loaded from a stream or file in the following locations:

1. Explicit path.
1. The folder that contains the aspose-pdf-xx.x.jar.

Use the License.setLicense method to license the component. Often the easiest way to set a license is to put the license file in the same folder as Aspose.PDF.jar and specify just the file name without path as shown in the following example:

Starting from Aspose.PDF for Java 4.2.0, you need to call the following code lines to initialize the license.
#### **Setting License from File**
In this example **Aspose.PDF** will attempt to find the license file in the folder that contain the JARs of your application.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-pdf-QuickStart-SetLicenseFromFile-1.java" >}}
#### **Setting License from Stream Object**
Initializes a license from a stream.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-pdf-QuickStart-SetLicenseFromStream-1.java" >}}
#### **Setting a License Purchased Before 2005/01/22**
**Aspose.PDF** for Java doesn't support old licenses anymore so please contact our [sales team](https://company.aspose.com/contact) to get new license file.
### **Validate the License**
It is possible to validate if the license has been set properly or not. The Document class has the isLicensed method that will return true if license has been properly set.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-pdf-QuickStart-ValidateLicense-1.java" >}}
