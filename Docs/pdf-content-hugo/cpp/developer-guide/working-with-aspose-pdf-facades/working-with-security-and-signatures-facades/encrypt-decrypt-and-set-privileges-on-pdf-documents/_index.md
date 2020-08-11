---
title: Encrypt, Decrypt and set Privileges on PDF documents
type: docs
weight: 10
url: /cpp/encrypt-decrypt-and-set-privileges-on-pdf-documents/
---

## **Set Privileges on an Existing PDF File**
In order to set privileges on an existing PDF document, you can use **Document->Encrypt(...)** method, which takes **DocumentPrivilege** object. A **DocumentPrivilege** class is used to set different privileges to access PDF document. Furthermore, there are 4 following ways using this class:

1. ` `Using predefined privilege directly.
1. Based on a predefined privilege and change some specific permissions.
1. Based on a predefined privilege and change some specific Adobe Professional permissions combination.
1. Mixes the way 2 and way 3.

Following code snippet will demonstrate above 4 ways to set document privileges:





{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-SecurityAndSignatures-SetPrivileges-Priveleges.cpp" >}}
