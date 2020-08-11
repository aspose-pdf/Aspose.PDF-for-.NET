---
title: Change Passwords and Decrypt PDF Document
type: docs
weight: 10
url: /cpp/change-passwords-and-decrypt-pdf-document/
---

## **Change Password of a PDF document**
In order to change the password of a PDF file, you must know the owner password of that document. You can load password protected PDF document with Aspose.PDF for C++ by specifying its owner password and use **ChangePasswords** method to change the password. Please check following code snippet which changes the password of an existing PDF file.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-SecurityAndSignatures-ChangePassword-1.cpp" >}}
## **Decrypt a PDF Document**
In order to decrypt a PDF file, you need to create **Document** object and then call the **Decrypt** method. You also need to pass the owner password to **Decrypt** method. The following code snippet shows you how to decrypt PDF file.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-SecurityAndSignatures-DecryptPDFFile-1.cpp" >}}

