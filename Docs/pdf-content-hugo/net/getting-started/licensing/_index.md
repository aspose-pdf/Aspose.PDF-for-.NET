---
title: Licensing
type: docs
weight: 60
url: /net/licensing/
---

## **Evaluation Version Limitations**
We want our customers to test our components thoroughly before buying so the evaluation version allows you to use it as you would normally.

**PDF created with an evaluation watermark** 
The evaluation version of Aspose.PDF for .NET provides full product functionality, but all the pages in the generated PDF documents are watermarked with "Evaluation Only. Created with Aspose.PDF. Copyright 2002-2016 Aspose Pty Ltd" at the top.

**Limit of the Number of Collection Items that can be Processed** 
In the evaluation version, only four items can be processed from any collection (for example, only four pages, four form fields, etc.).
## **Apply License using File or Stream Object**
The license can be loaded from a file or stream object. The easiest way to set a license is to put the license file in the same folder as the Aspose.PDF.dll file and specify the file name, without a path, as shown in the example below.

{{% alert color="primary" %}} 

If you use are using any other Aspose for .NET component along with Aspose.PDF for .NET, please specify the namespace for License like Aspose.Pdf.License.

{{% /alert %}} 
### **Loading a License from File**
The easiest way to apply a license is to put the license file in the same folder as the Aspose.PDF.dll file and specify just the file name without a path.

When you call the SetLicense method, the license name that you pass should be that of your license file. For example, if you change the license file name to "Aspose.PDF.lic.xml" pass that file name to the Pdf.SetLicense(…) method.




{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-QuickStart-LoadLicenseFromFile-1.cs" >}}
### **Loading a License from a Stream Object**
The following example shows how to load a license from a stream.



{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-QuickStart-LoadLicenseFromStreamObject-1.cs" >}}
### **Apply Metered License**
Aspose.PDF allows developers to apply metered key. It is a new licensing mechanism. The new licensing mechanism will be used along with existing licensing method. Those customers who want to be billed based on the usage of the API features can use the metered licensing. For more details, please refer to [Metered Licensing FAQ](http://www.aspose.com/corporate/purchase/policies/Licensing-Faqs/metered-faq.aspx) section.

A new class [Metered](https://apireference.aspose.com/net/pdf/aspose.pdf/metered/) has been introduced to apply metered key. Following is the sample code demonstrating how to set metered public and private keys.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-QuickStart-ApplyMeteredLicense-1.cs" >}}
## **Using as Embedded Resource**
To apply a license, you can [load it from file or stream](). Another neat way of packaging the license with your application is to include it as an embedded resource into one of the assemblies that calls Aspose.PDF for .NET.

To include the file as an embedded resource:

1. In Visual Studio .NET, include the .lic file into the project by clicking the **File** menu and selecting **Add Existing Item**.
1. Select the file in the Solution Explorer.
1. In the Properties window, set the **Build Action** to **Embedded Resource**.

MergedAPI is the application's default namespace.



{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-QuickStart-SetLicenseUsingEmbeddedResource-1.cs" >}}

{{% alert color="primary" %}} 

Please note that COM applications that work with Aspose.PDF for .NET should also use the License class.

{{% /alert %}} 

One point which needs consideration :- Please note that the embedded resources are included in assembly the way they are added i.e. if you add text file as an embedded resource in the application and open the resultant EXE in notepad, you will see the exact contents of text file. So when using license file as an embedded resource, anyone can open exe file in some simple text editor and see/extract the contents of embedded license.

Therefore, in order to put an extra layer of security when embedding the license with the application, you can compress/encrypt license and after that, you can embed it into the assembly. A free utility DotNetZip (<http://dotnetzip.codeplex.com/>) can help to fulfill this requirement. Suppose we have Aspose.Total.lic license file, so let's make Aspose.Total.lic.zip with password test and embed this zip file into solution. The following code snippet can be used to initialize the license:



{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-QuickStart-SecureLicense-1.cs" >}}
### **Applying a License Bought Before 2005/01/22**
Aspose.PDF for .NET no longer supports the old-style licenses. If you have a license from before 22 January 2005 and you have updated to a more recent version of Aspose.PDF, please [contact our Sales team](https://company.aspose.com/contact) to get a new license file.


