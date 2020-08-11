---
title: Determine if the Source PDF file is Password Protected
type: docs
weight: 60
url: /java/determine-if-the-source-pdf-file-is-password-protected/
---

Aspose.PDF for Java provides great capabilities of dealing with PDF documents. When using [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class of com.aspose.pdf package to open a PDF document which is password protected, we need to provide the password information as an argument to Document constructor and in case this information is not provided, an error message is generated. In fact when trying to open a PDF file with Document object, the constructor is trying to read the contents of PDF file and in case correct password is not provided, an error message is generated (it happens to prevent unauthorised access of document)

When dealing with encrypted PDF files, you may come across the scenario where you would be interested to detect if a PDF has an open password and/or an edit password. Sometimes there are documents which do not require password information while opening them, but they require information in order to edit the contents of file.. So in order to fulfil the above requirements, PdfFileInfo class present under com.aspose.pdf.facades package provides the methods which can help in determining the required information.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-SecurityAndSignatures-HowToDetermineIfTheSourcePDFIsPasswordProtected-HowToDetermineIfTheSourcePDFIsPasswordProtected.java" >}}
#### **Get information about PDF document security**
PdfFileInfo contains three methods to get information about PDF document security.

1. **getPasswordType()** method returns PasswordType enumeration value:
   1. PasswordType.None - document is not password protected
   1. PasswordType.User - document was opened with user (or document open) password
   1. PasswordType.Owner - document was opened with owner (or permissions, edit) password
   1. PasswordType.Inaccessible - document is password protected but password is needed to open it while invalid password (or no password) was supplied.
1. **hasOpenPassword()** method is used to determine if input file requires password, when opening it.
1. **hasEditPassword()** method is used to determine if input file requires password to edit its contents.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-HowToDetermineIfTheSourcePDFIsPasswordProtected-GetInformationAboutPDFDocumentSecurity.java" >}}
#### **Determine correct password from Array**
Sometimes there is a requirement to determine the correct password from array of passwords and open the document with correct password. The following code snippet demonstrates the steps to iterate through the array of passwords and try opening the document with correct password.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-HowToDetermineIfTheSourcePDFIsPasswordProtected-DetermineCorrectPasswordFromArray.java" >}}
