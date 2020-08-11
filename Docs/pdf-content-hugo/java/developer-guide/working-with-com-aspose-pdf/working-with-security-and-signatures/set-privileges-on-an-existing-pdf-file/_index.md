---
title: Set Privileges on an Existing PDF File
type: docs
weight: 50
url: /java/set-privileges-on-an-existing-pdf-file/
---

{{% alert color="primary" %}} 

To set privileges on a PDF file, create an object of the DocumentPrivilege class and specify the rights you want to apply to the document. Once the privileges have been defined, pass this object as an argument to the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's [encrypt(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document#encrypt-java.lang.String-java.lang.String-com.aspose.pdf.facades.DocumentPrivilege-int-boolean-) method.

{{% /alert %}} 

The following code snippet shows how to set the privileges of a PDF file. When viewing the output PDF's security properties in Adobe Reader (after providing the password), they appear as in the screenshot below.

|![todo:image_alt_text](http://i.imgur.com/1WXaa4m.png)|
| :- |
|**Figure: Security properties**|
{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-securityandsignatures-SetPrivilegesOnAnExistingPDFFile-.java" >}}
