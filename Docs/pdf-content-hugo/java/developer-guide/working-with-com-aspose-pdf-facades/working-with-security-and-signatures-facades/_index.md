---
title: Working with Security and Signatures - facades
type: docs
weight: 80
url: /java/working-with-security-and-signatures-facades/
---

## **Add Digital Signature in a PDF File (facades)**
{{% alert color="primary" %}} 

[**PdfFileSignature**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileSignature) class allows you to add signature in a PDF file. You need to create an object of [**PdfFileSignature**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileSignature) class using input and output PDF files. You also need to create a Rectangle object at which you want to add the signature and in order to set appearance you can specify an image using setSignatureAppearance property of the [**PdfFileSignature**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileSignature) object.

{{% /alert %}} 

Aspose.Pdf.Facades also provides different kinds of signatures like PKCS#1, PKCS#7, and PKCS#7Detached. In order to create a signature of a specific type, you need to create an object of the particular class like PKCS1 , PKCS7 or PKCS7Detached using the certificate file and the password.

Once the object of a particular signature type is created, you can use the sign method of the [**PdfFileSignature**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileSignature) class to sign the PDF and pass the particular signature object to this class. You can also specify other attributes for this method. Finally, you need to save the signed PDF using save method of the [**PdfFileSignature**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileSignature) class. The following code snippet shows you how to add signature in a PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-SecurityAndSignatures-AddDigitalSignatureInAPDFFile-.java" >}}
## **Set Privileges on an Existing PDF File (facades)**
To set a PDF file's privileges, create a [PdfFileSecurity](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileSecurity) class object and bind the input PDF using binPdf method. Then you have to call the setPrivilege method to set privileges. You can specify the privileges using the [DocumentPrivilege](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/DocumentPrivilege) object and then pass this object to the setPrivilege method and save the output PDF using save method.

The following code snippet shows you how to set the privileges of a PDF file.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-facades-SecurityAndSignatures-SetPrivilegesOnAnExistingPDFFile-.java" >}}
## **Suppress Location and Reason**
Aspose.PDF functionality allows flexible configuration for digital sign instance. [PdfFileSignature ](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfFileSignature)class provides ability sign PDF file. Sign method implementation allows to sign the PDF and pass the particular signature object to this class. Sign method contains set of attributes for the customization of output digital sing. In case if you need to suppress some text attributes from result sing you can leave them empty. The following code snippet demonstrate how to suppress Location and Reason two rows from signature block:

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfFacades-SecurityAndSignatures-SuppressLocationAndReason-SuppressLocationAndReason.java" >}}




