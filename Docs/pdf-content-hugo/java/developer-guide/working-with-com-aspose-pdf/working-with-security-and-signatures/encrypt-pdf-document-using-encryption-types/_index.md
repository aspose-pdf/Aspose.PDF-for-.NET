---
title: Encrypt PDF document using Encryption Types
type: docs
weight: 10
url: /java/encrypt-pdf-document-using-encryption-types/
---

The [encrypt(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#encrypt-java.lang.String-java.lang.String-int-int-) method of the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object supports the feature to encrypt a PDF document. You can pass user password, owner password and permissions to the [encrypt(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#encrypt-java.lang.String-java.lang.String-int-int-) method. In addition to that, you can pass any value from [CryptoAlgorithm](https://apireference.aspose.com/java/pdf/com.aspose.pdf/CryptoAlgorithm) Enumeration. This enum provides different combinations of encryption algorithms and key sizes. Finally, save the encrypted PDF file using [save(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#save--) method of [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object.

{{% alert color="primary" %}} 

Please specify different user and owner passwords while encrypting the PDF document.

{{% /alert %}} 

The following code snippet shows you how to encrypt the PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-securityandsignatures-EncryptPDFDocumentUsingEncryptionTypes-.java" >}}
