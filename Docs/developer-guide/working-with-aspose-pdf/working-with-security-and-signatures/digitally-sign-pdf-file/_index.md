---
title: Digitally sign PDF file
type: docs
weight: 10
url: /net/digitally-sign-pdf-file/
---

## **Digitally sign PDF file**
Aspose.PDF for .NET supports the feature to digitally sign the PDF files using the SignatureField class. You can also certify a PDF file with a PKCS12-Certificate. Something similar to [Adding Signatures and Security in Adobe Acrobat](http://www.adobepress.com/articles/article.asp?p=1272495&seqNum=6).

When signing a PDF document using a signature, you basically confirm its contents "as is". Consequently, any other changes made afterward invalidate the signature and thus, you would know if the document was altered. Whereas, certifying a document first allows you to specify the changes that a user can make to the document without invalidating the certification.

In other words, the document would still be considered to retain its integrity and the recipient could still trust the document. For further details, please visit [Certifying and signing a PDF](http://blogs.adobe.com/security/2012/03/what-is-a-certified-document-and-when-should-you-use-it.html)[. In general, certifying a document can be compared to Code-signing a .NET executable.](http://www.investintech.com/resources/articles/certifyingsigningpdf/)

In order to accomplish the above stated requirement, following **Public API changes** have been made.

- [**DocMDPSignature**](https://apireference.aspose.com/net/pdf/aspose.pdf.forms/docmdpsignature) class was added
- **DocMDPAccessPermissions** enumeration was added
- **IsCertified** property is added to **PdfFileSignature** class

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Security-Signatures-DigitallySign-DigitallySign.cs" >}}
## **Digitally Signing PDF with Timestamp Server**
Aspose.PDF for .NET supports to digitally sign the PDF with a timestamp server or Web service.

In order to accomplish this requirement, the [TimestampSettings](https://apireference.aspose.com/net/pdf/aspose.pdf/timestampsettings) class has been added to the Aspose.PDF namespace. Please take a look at the following code snippet which obtains timestamp and adds it to PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Security-Signatures-DigitallySignWithTimeStamp-DigitallySignWithTimeStamp.cs" >}}
