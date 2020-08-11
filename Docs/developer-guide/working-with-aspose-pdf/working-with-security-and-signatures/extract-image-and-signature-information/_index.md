---
title: Extract Image and Signature Information
type: docs
weight: 30
url: /net/extract-image-and-signature-information/
---

## **Extracting Image from Signature Field**
Aspose.PDF for .NET supports the feature to digitally sign the PDF files using the [SignatureField](https://apireference.aspose.com/net/pdf/aspose.pdf.forms/signaturefield) class and while signing the document, you can also set an image for SignatureAppearance. Now, this API also provides the capability to extract signature information as well as the image associated with the signature field.

In order to extract signature information, we have introduced the [ExtractImage](https://apireference.aspose.com/net/pdf/aspose.pdf.forms/signaturefield/methods/extractimage)(..) method to the SignatureField class. Please take a look at the following code snippet which demonstrates the steps to extract an image from the SignatureField object:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Security-Signatures-ExtractingImage-ExtractingImage.cs" >}}
### **Replace signature Image**
Sometimes you may have a requirement to only replace the image of an already present signature field inside PDF file. In order to accomplish this requirement, first, we need to search form fields inside the PDF file, identify Signature fields, get the dimensions (Rectangular dimensions) of the signature field and then stamp an image over the same dimensions.
## **Extract Signature Information**
Aspose.PDF for .NET supports the feature to digitally sign the PDF files using the SignatureField class. Currently, we can also determine the validity of the certificate but we cannot extract the whole certificate. The information which can be extracted is a public key, thumbprint, issuer, etc.

To extract signature information, we have introduced the [ExtractCertificate](https://apireference.aspose.com/net/pdf/aspose.pdf.forms/signaturefield/methods/extractcertificate)(..) method to the SignatureField class. Please take a look at the following code snippet which demonstrates the steps to extract the certificate from SignatureField object:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Security-Signatures-ExtractSignatureInfo-ExtractSignatureInfo.cs" >}}
