---
title: Improved and Flexible PDF Signing Mechanism
type: docs
weight: 270
url: /net/improved-and-flexible-pdf-signing-mechanism/
---

{{% alert color="primary" %}}

[Aspose.Pdf.Facades namespace](https://apireference.aspose.com/pdf/net/aspose.pdf.facades) in [Aspose.PDF for .NET](/pdf/net/) has introduced an improved and flexible PDF signing mechanism. It allows you to sign the PDF file using different signature types. It also allows you to add signature fields and sign the PDF file using multiple signatures. You can verify the signatures as well.

{{% /alert %}}
## **Implementation details**
You can sign a PDF file using any of the following three types of signatures: PKCS#1, PKCS#7 and PKCS#7 Detached. These three types of signatures have been supported using two new classes: **Pkcs1Signature** and **Pkcs7Signature**. A property named **Detached**, defined in the **Pkcs7Signature** class, can be used to specify the PKCS#7 Detached signature type. Both of these classes have been inherited from **Signature** class.

In order to sign a PDF file using any of the above three types of the signatures, you need to first create an instance from one of the above two classes and then pass this object to the **Sign** method of **PdfFileSignature** class.

The following code snippet shows you how to sign the PDF file:



{{< highlight java >}}

 // Create PdfFileSignature object and bind input and output PDF files

PdfFileSignature pdfSign = new PdfFileSignature("input.pdf", "output.pdf");

// Create a rectangle for signature location

System.Drawing.Rectangle rect = new System.Drawing.Rectangle(100, 100, 200, 100);

// Set signature appearance

pdfSign.SignatureAppearance = "butterfly.jpg";

// Set certification level

pdfSign.CertificationLevel = PdfFileSignature.NotCertified;

// Create any of the three signature types

Pkcs1Signature signature = new Pkcs1Signature("test.pfx", "password"); // PKCS#1 or

// Pkcs7Signature signature = new Pkcs7Signature("test.pfx", "password"); // PKCS#7 detached or

// Pkcs7Signature signature = new Pkcs7Signature(false, "test.pfx", "password"); // PKCS#7

pdfSign.Sign(1, "Signature Reason", "Alice", "Odessa", true, rect, signature);

// Save output PDF file

pdfSign.Save();



{{< /highlight >}}

{{% alert color="primary" %}}

You can also sign a PDF file using multiple signatures. For that matter, you can add multiple signature fields using **FormEditor** class and then add signatures in those fields. You can add the signature using its own name, so that you would be able to access it later using the same name. If you add a signature without a name i.e. without using a signature field, Aspose.PDF for .NET will assign a unique name like “Signature#” i.e. Signature1, Signature2 etc.
{{% /alert %}}

The following code snippet shows you how to add signature fields and then add signatures:



{{< highlight java >}}

 // Create FormEditor object

FormEditor editor = new FormEditor("input.pdf", "WithSignatureFields.pdf");

// Add signature fields

editor.AddField(FieldType.Signature, "Signature from Alice", 1, 10, 10, 110, 110);

editor.AddField(FieldType.Signature, "Signature from John", 1, 120, 150, 220, 250);

editor.AddField(FieldType.Signature, "Signature from Smith", 1, 300, 200, 400, 300);

// Save the form

editor.Save();

// Add signature to any of the signature fields

PdfFileSignature pdfSign = new PdfFileSignature("WithSignatureFields.pdf", "SignedByJohn.pdf");

pdfSign.Sign("Signature from John", "Signature Reason", "John", "Kharkov", new Pkcs1Signature("test.pfx", "password"));

// Each time new signature is added you must save the document

pdfSign.Save();

// Add second signature

PdfFileSignature pdfSign2 = new PdfFileSignature("SignedByJohn.pdf","SignedByJohnAndAlice.pdf");

pdfSign2.Sign("Signature from Alice", "Signature Reason", "Alice", "Odessa", new Pkcs7Signature(false, "test2.pfx", "password"));

// Each time new signature is added you must save the document

pdfSign2.Save();



{{< /highlight >}}

{{% alert color="primary" %}}

Signatures can also be verified using [Aspose.Pdf.Facades namespace](https://apireference.aspose.com/pdf/net/aspose.pdf.facades). In the following code snippet, we’ll show you how to find whether a file is signed or to verify a particular signature.

{{% /alert %}}

{{< highlight java >}}

 // Create PdfFileSignature object

PdfFileSignature pdfVerify = new PdfFileSignature();

// Bind input PDF file

pdfVerify.BindPdf("input.pdf");

// Check if PDF contains signature

bool isSigned = pdfVerify.IsContainSignature();

// All signatures have names Signaure#, this names kit generates automatically

bool isSignatureVerified = pdfVerify.VerifySignature("Signature1");

// However we can set necessary name manualy if we use signature fields (see below)

bool isSignatureVerified2 = pdfVerify.VerifySignature("Signature from Alice");



{{< /highlight >}}
## **Conclusion**

{{% alert color="primary" %}}

In this article, we have seen that how conveniently the PDF files can be signed in different ways using [Aspose.PDF for .NET](/pdf/net/)

{{% /alert %}}
