---
title: Working with Signature in a PDF File
type: docs
weight: 20
url: /net/working-with-signature-in-a-pdf-file/
---

## **Add Digital Signature in a PDF File**
**PdfFileSignature** class allows you to add signature in a PDF file. You need to create an object of **PdfFileSignature** class using input and output PDF files. You also need to create a **Rectangle** object at which you want to add the signature and in order to set appearance you can specify an image using **SignatureAppearance** property of the **PdfFileSignature** object. Aspose.Pdf.Facades also provides different kinds of signatures like PKCS#1, PKCS#7, and PKCS#7Detached. In order to create a signature of a specific type, you need to create an object of the particular class like **PKCS1** , **PKCS7** or **PKCS7Detached** using the certificate file and the password.

Once the object of a particular signature type is created, you can use the **Sign** method of the **PdfFileSignature** class to sign the PDF and pass the particular signature object to this class. You can also specify other attributes for this method. Finally, you need to save the signed PDF using **Save** method of the **PdfFileSignature** class. The following code snippet shows you how to add signature in a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Security-Signatures-DigitallySignature-DigitallySignature.cs" >}}
## **Remove Digital Signature from the PDF File**
When a signature has been added to a PDF files, it is possible to remove it. You can remove either a particular signature, or all signatures in a file. The fastest method for removing the signature also removes the signature field, but it is possible to just [remove the signature](/pdf/net/working-with-signature-in-a-pdf-file-html/), keeping the signature field so the file can be signed again.

The [PdfFileSignature](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdffilesignature) class RemoveSignature method allows you to remove a signature from a PDF file. This method takes the signature name as an input. Either specify the signature name directly, to remove all signatures, get the signature names using the GetSignNames method. The following code snippet shows how to remove digital signature from the PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Security-Signatures-RemoveSignature-RemoveSignature.cs" >}}
### **Remove Signature but Keep the Signature field**
As shown above, the [PdfFileSignature](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdffilesignature) class RemoveSignature() method lets you remove signature fields from PDF files. When using this method with versions prior to 9.3.0, both the signature and signature field are removed. Some develoeprs want to remove only the signature and keep the signature field so that it can be used to resign the document. To keep the signature field and only remove the signature, please use the following code snippet.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Security-Signatures-RemoveSignature-Run_34561_tests.cs" >}}
## **Verify Whether the PDF File is Signed Using a Signature**
To verify whether a PDF file is signed using a [particular signature](/pdf/net/working-with-signature-in-a-pdf-file-html/), use the VerifySigned method of the [PdfFileSignature](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdffilesignature) class. This method requires the signature name and returns true if the PDF is signed using that signature name. It is also possible to verify that a [PDF is signed](/pdf/net/working-with-signature-in-a-pdf-file-html/), without verifying which signature it is signed with.
### **Verifying that a PDF is Signed with a Given Signature**
The following code snippet shows you how to verify whether PDF is signed using a given signature.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Security-Signatures-VerifySignature-VerifySignature.cs" >}}
### **Verifying that a PDF is Signed**
To determine if a file is singed, without providing the signature name, use the following code.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Security-Signatures-VerifySignature-VerifyPDFSigned.cs" >}}
## **Verify whether the Signature is Valid**
**VerifySignature** method of **PdfFileSignature** class allows you to validate a particular signature. This method requires signature name as input and returns true if the signature is valid. The following code snippet shows you how to validate a signature.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Security-Signatures-VerifyValidSignature-VerifyValidSignature.cs" >}}
## **How to Extract Signature Information**
Aspose.PDF for .NET supports the feature to digitally sign PDF files using the PdfFileSignature class. Currently, it is also possible to determine the validity of a certificate but we cannot extract the whole certificate. The information that can be extracted is the public key, thumbprint, and issuer, etc.

To extract signature information, we have introduced the ExtractCertificate(..) method to the PdfFileSignature class. Please take a look at the following code snippet which demonstrates the steps to extract certificate from the PdfFileSignature object:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Security-Signatures-ExtractSignatureInfo-ExtractSignatureInfo.cs" >}}
## **Extracting Image from Signature Field (PdfFileSignature)**
Aspose.PDF for .NET supports the feature to digitally sign the PDF files using the PdfFileSignature class and while signing the document, you can also set an image for SignatureAppearance. Now this API also provides the capability to extract signature information as well as the image associated with the signature field.

In order to extract signature information, we have introduced the ExtractImage(..) method to the PdfFileSignature class. Please take a look at the following code snippet which demonstrates the steps to extract image from the PdfFileSignature object:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Security-Signatures-ExtractImages-ExtractImages.cs" >}}
## **Suppress Location and Reason**
Aspose.PDF functionality allows flexible configuration for digital sign instance. [PdfFileSignature ](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdffilesignature)class provides ability sign PDF file. Sign method implementation allows to sign the PDF and pass the particular signature object to this class. Sign method contains set of attributes for the customization of output digital sing. In case if you need to suppress some text attributes from result sing you can leave them empty. The following code snippet demonstrate how to suppress Location and Reason two rows from signature block:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePdfFacades-Security-Signatures-SuppressLocationAndReason-SuppressLocationAndReason.cs" >}}
## **Customization Features for Digital Sign**
Aspose.PDF for .NET allows customization features for a digital sign. The Sign method of class [SignatureCustomAppearance ](https://apireference.aspose.com/net/pdf/aspose.pdf.forms/signaturecustomappearance)implements with 6 overloads for your comfortable usage. For example, you can configure result sign only by SignatureCustomAppearance class instance and its properties values. The following code snippet demonstrates how to hide "Digitally signed by" caption from output digital sign of your PDF. 

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePdfFacades-Security-Signatures-HideDigitallySignedByCaption-HideDigitallySignedByCaption.cs" >}}
## **Change Language In Digital Sign Text**
Using Aspose.PDF for .NET API, you can sign a PDF file using any of the following three types of signatures:

- PKCS#1
- PKCS#7
- PKCS#7

Each of provided signatures contains a set of configuration properties implemented for your convenience(localization, date time format, font family etc). Class [SignatureCustomAppearance](https://apireference.aspose.com/net/pdf/aspose.pdf.forms/signaturecustomappearance) provides corresponding functionality. The following code snippet demonstrates how to change language in digital sign text:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePdfFacades-Security-Signatures-ChangeLanguageInDigitalSignText-ChangeLanguageInDigitalSignText.cs" >}}
