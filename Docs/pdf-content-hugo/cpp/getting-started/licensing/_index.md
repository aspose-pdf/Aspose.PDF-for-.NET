---
title: Licensing
type: docs
weight: 50
url: /cpp/licensing/
---

## **Evaluation Version Limitations**
We want our customers to test our components thoroughly before buying, so the evaluation version allows you to use it as you would normally. However there would be following limitations while using an evaluation version of the API:

**PDF created with an evaluation watermark** 
The evaluation version of Aspose.PDF for C++ provides full product functionality, but all the pages in the generated PDF documents are watermarked with "Evaluation Only. Created with Aspose.PDF. Copyright 2002-2017 Aspose Pty Ltd" at the top.

**Limit of the Number of Collection Items that can be Processed** 
In the evaluation version, only four items can be processed from any collection (for example, only four pages, four form fields, etc.).
## **Apply License using File or Stream Object**
The license can be loaded from a file or stream object. Aspose.PDF for C++ will try to find the license in the following locations:

1. Explicit path.
1. The folder that contains Aspose.PDF.dll.
1. The folder that contains the assembly that called Aspose.PDF.dll.
1. The folder that contains the entry assembly (your .exe).
1. An embedded resource in the assembly that called Aspose.PDF.dll.

The easiest way to set a license is to put the license file in the same folder as the Aspose.PDF.dll file and specify the file name, without a path, as shown in the example below.
### **Loading a License from File**
The easiest way to apply a license is to put the license file in the same folder as the Aspose.PDF.dll file and specify just the file name without a path.

{{% alert color="primary" %}} 

When you call the SetLicense method, the license name that you pass should be that of the license file. For example, if you change the license file name to "Aspose.PDF.lic.xml" pass that file name to the Pdf->SetLicense(…) method.

{{% /alert %}} 

**C++**

{{< highlight csharp >}}

 auto lic = MakeObject<Aspose::Pdf::License>();

lic->SetLicense(L"Aspose.PDF.Cpp.lic");

{{< /highlight >}}
### **Loading a License from a Stream Object**
The following example shows how to load a license from a stream.

**C++**

{{< highlight csharp >}}

 intrusive_ptr<License>license = new License();

intrusive_ptr<FileStream> myStream = new FileStream(new String("Aspose.PDF.Cpp.lic"), FileMode_Open);

license->SetLicense(myStream);

{{< /highlight >}}
