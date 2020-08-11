---
title: Encrypt, Decrypt and Set Privileges on PDF File
type: docs
weight: 10
url: /net/encrypt-decrypt-and-set-privileges-on-pdf-file/
---

## **Encrypt PDF File using Different Encryption Types and Algorithms**
In order to encrypt a PDF file, you need to create **PdfFileSecurity** object and then call the **EncryptFile** method. You can pass user password, owner password and privileges to **EncryptFile** method. You also need to pass **KeySize** and **Algorithm** values to this method. 

{{% alert color="primary" %}} 

- The **User password**, if set, is what you need to provide in order to open a PDF. Acrobat/Reader will prompt a user to enter the user password. If it's not correct, the document will not open.
- The **Owner password**, if set, controls permissions, such as printing, editing, extracting, commenting, etc. Acrobat/Reader will disallow these things based on the permission settings. Acrobat will require this password if you want to set/change permissions.

{{% /alert %}} 

The following code snippet shows you how to encrypt PDF file.

{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Security-Signatures-EncryptFile-EncryptFile.cs" >}}
## **Decrypt PDF File using Owner Password**


Try online

You can try to unlock document using Aspose.PDF and get the results online at this link:

[products.aspose.app/pdf/unlock](https://products.aspose.app/pdf/unlock)

In order to decrypt a PDF file, you need to create **PdfFileSecurity** object and then call the **DecryptFile** method. You also need to pass the owner password to **DecryptFile** method. The following code snippet shows you how to decrypt PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Security-Signatures-DecryptFile-DecryptFile.cs" >}}
## **Set Privileges on an Existing PDF File**
To set a PDF file's privileges, create a [PdfFileSecurity](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdffilesecurity) object and call the SetPrivilege method. You can specify the privileges using the DocumentPrivilege object and then pass this object to the SetPrivilege method. The following code snippet shows you how to set the privileges of a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Security-Signatures-SetPrivilegesOnFile-SetPrivilegesOnFile.cs" >}}
## **Change Password of a PDF File**
In order to change password of a PDF file, you need to create **PdfFileSecurity** object and then call the **ChangePassword** method. You need to pass existing owner password and new user and owner passwords to the **ChangePassword** method. 

{{% alert color="primary" %}} 

- The **User password**, if set, is what you need to provide in order to open a PDF. Acrobat/Reader will prompt a user to enter the user password. If it's not correct, the document will not open.
- The **Owner password**, if set, controls permissions, such as printing, editing, extracting, commenting, etc. Acrobat/Reader will disallow these things based on the permission settings. Acrobat will require this password if you want to set/change permissions.

{{% /alert %}} 

The following code snippet shows you how to change passwords of a PDF file. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Security-Signatures-ChangeFilePassword-ChangeFilePassword.cs" >}}
## **Remove Extended Rights Feature from the PDF**
PDF documents support the extended rights feature to enable end-user to fill data into form fields by using Adobe Acrobat Reader and then save a copy of the filled form. However, it ensures that PDF file is not modified and if any modification to the structure of the PDF is made, the extended rights feature is lost. When viewing such a document, an error message is displayed, stating that extended rights are removed because the document was modified. Recently, we received a requirement to remove extended rights from PDF document.

To remove the extended rights from a PDF file, a new method named RemoveUsageRights() has been added to the PdfFileSignature class. Another method named ContainsUsageRights() is added to determine if source PDF contains extended rights.

Starting Aspose.PDF for .NET 9.5.0, names of following methods are updated. Please note that the previous methods are still in the API but they have been marked as obsolete and will be removed. Therefore, its recommended to try using the updated methods.

- The IsContainSignature(.) method was renamed ContainsSignature(..).
- The IsCoversWholeDocument(..) method was renamed CoversWholeDocument(..).

The following code shows ho to remove usage rights from the document:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Security-Signatures-RemoveRights-RemoveRights.cs" >}}
