---
title: Change in class name
type: docs
weight: 20
url: /java/change-in-class-name/
---

{{% alert color="primary" %}} 

The autoported MergedAPI of Aspose.PDF for Java is ported from its sibling Aspose.PDF for .NET and during this migration, names of some classes have been changed. Specified below is the list of classes whose names have been changed after the migration activity.

{{% /alert %}} 
#### **PdfPrivilege changed to DocumentPrivilege**
In autoported Aspose.PDF for Java, the PdfPrivilege class is changed to DocumentPrivilege (as per .NET).

**Java**

{{< highlight csharp >}}

 String inFile = "c:/pdftest/Alignment_DOM.pdf";



String outFile1 = "c:/pdftest/TestEncrypt1.pdf";

com.aspose.pdf.facades.PdfFileSecurity fileSecurity = newcom.aspose.pdf.facades.PdfFileSecurity(inFile, outFile1);

// PdfPrivilege came to DocumentPrivilege, true -> KeySize.x128

fileSecurity.encryptFile(null, "mypassword", com.aspose.pdf.facades.DocumentPrivilege.getScreenReaders(), com.aspose.pdf.facades.KeySize.x128);

fileSecurity.close();



String outFile2 = "c:/pdftest/TestEncrypt2.pdf";

com.aspose.pdf.facades.PdfFileSecurity fileSecurity2 = newcom.aspose.pdf.facades.PdfFileSecurity(inFile, outFile2);

fileSecurity2.encryptFile("", "owner", com.aspose.pdf.facades.DocumentPrivilege.getAllowAll(), com.aspose.pdf.facades.KeySize.x128); // was PdfPrivilege.AllowAll

fileSecurity2.close();



String outFile4 = "c:/pdftest/TestEncrypt4.pdf";

com.aspose.pdf.facades.PdfFileSecurity fileSecurity4 = newcom.aspose.pdf.facades.PdfFileSecurity(inFile, outFile4);

fileSecurity4.encryptFile("user", "owner", com.aspose.pdf.facades.DocumentPrivilege.getCopy(), com.aspose.pdf.facades.KeySize.x40);// was PdfPrivilege.Copy

fileSecurity4.close();

{{< /highlight >}}
