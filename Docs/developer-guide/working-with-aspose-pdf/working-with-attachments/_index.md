---
title: Working with Attachments
type: docs
weight: 30
url: /net/working-with-attachments/
---

PDF files allow attaching files as content and are one of the key features of PDF file format. Different file formats such as Word DOC/DOCX, Excel XLS/XLSX, EML, JPG, PNG, GLB, etc. can be embedded in a PDF file. Aspose.PDF for .NET API lets you work with attachments in a PDF file using your .NET applications. You can add/embed attachments in a PDF file, get attachments information from a PDF, access individual attachment from PDF file, and remove attachments from PDF in C# or any other .NET programming language. This article demonstrates the functionality of working with attachments in a PDF file.
## **Add Attachment to PDF**
Attachments can contain a wide variety of information and can be of a variety of file types. This article explains how to add an attachment to a PDF file.

1. Create a new C# project.
1. Add a reference to Aspose.PDF DLL.
1. Create a [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object.
1. Create a [FileSpecification](https://apireference.aspose.com/net/pdf/aspose.pdf/filespecification) object with the file you are adding, and file description.
1. Add the [FileSpecification](https://apireference.aspose.com/net/pdf/aspose.pdf/filespecification) object to the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's [EmbeddedFiles](https://apireference.aspose.com/net/pdf/aspose.pdf/embeddedfilecollection) collection, with the collection’s Add method.

The [EmbeddedFiles](https://apireference.aspose.com/net/pdf/aspose.pdf/embeddedfilecollection) collection contains all the attachments in the PDF file. The following code snippet shows you how to add an attachment in a PDF document.
#### **C#**
{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Attachments-AddAttachment-AddAttachment.cs" >}}
## **Get all Attachments from a PDF Document**
With Aspose.PDF, it is possible to get all attachments from a PDF document. This is useful either when you want to save the documents separately from the PDF, or if you need to strip a PDF of attachments.

To get all attachments from a PDF file:

1. Loop through the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's [EmbeddedFiles](https://apireference.aspose.com/net/pdf/aspose.pdf/embeddedfilecollection) collection. The [EmbeddedFiles](https://apireference.aspose.com/net/pdf/aspose.pdf/embeddedfilecollection) collection contains all attachments. Each element of this collection represents a [FileSpecification](https://apireference.aspose.com/net/pdf/aspose.pdf/filespecification) object. Each iteration of the foreach loop through the [EmbeddedFiles](https://apireference.aspose.com/net/pdf/aspose.pdf/embeddedfilecollection) collection returns a [FileSpecification](https://apireference.aspose.com/net/pdf/aspose.pdf/filespecification) object.
1. Once the object is available, retrieve either all the attached file's properties or the file itself.

The following code snippets show how to get all the attachments from a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Attachments-GetAlltheAttachments-GetAlltheAttachments.cs" >}}
### **Get Individual Attachment**
In order to get an individual attachment, we can specify the index of attachment in **EmbeddedFiles** object of Document instance. Please try using following code snippet.
#### **C#**
{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Attachments-GetIndividualAttachment-GetIndividualAttachment.cs" >}}
## **Delete All Attachments from PDF Document**
Aspose.PDF can remove attachments from PDF files. A PDF document's attachments are held in the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's EmbeddedFiles collection.

To delete all attachments associated with a PDF file:

1. Call the [EmbeddedFiles](https://apireference.aspose.com/net/pdf/aspose.pdf/embeddedfilecollection) collection's [Delete](https://apireference.aspose.com/net/pdf/aspose.pdf/embeddedfilecollection/methods/delete) method.
1. Save the updated file using the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's [Save](https://apireference.aspose.com/net/pdf/aspose.pdf.document/save/methods/4) method.

The following code snippet shows how to remove attachments from a PDF document.
#### **C#**
{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Attachments-DeleteAllAttachments-DeleteAllAttachments.cs" >}}
## **Get Attachment Information**
As mentioned in [Get All Annotations from the Page of a PDF Document](), attachment information is held in the [FileSpecification](https://apireference.aspose.com/net/pdf/aspose.pdf/filespecification) object, gathered with other attachments in the Document object's EmbeddedFiles collection. The FileSpecification object provides methods that get information about the attachment, for example:

- Name - the file name.
- Description - the file description.
- MIMEType - the file's MIME type.
- Params - information about the file parameters, for example CheckSum, CreationDate, ModDate and Size.

To get these parameters, first make sure that the Params property is not null. Either loop through all of the attachments in the EmbeddedFiles collection using a foreach loop, or get an individual attachment by specifying its index value. The following code snippets show how to get information about a specific attachment.
#### **C#**
{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Attachments-GetAttachmentInfo-GetAttachmentInfo.cs" >}}
## **Disable Files Compression when Adding as Embedded Resources**
The FileSpecification class allows developers to add attachments to PDF documents. By default, attachments are compressed. We have updated the API to allow developers to disable compression when adding files as embedded resource. This gives developers more control over how files are processed.

To allow developers to control file compression the Encoding property has been added to the FileSpecification class. This property determines which encoding will be used for file compression. The property accepts a value from the FileEncoding enumerator. The possible values are FileEncoding.None and FileEncoding.Zip.

{{% alert color="primary" %}} 

If Encoding is set to FileEncoding.None, then the attachment is not compressed. The default encoding is FileEncoding.Zip.

{{% /alert %}} 

The following code snippet shows how to add an attachment to a PDF document.
#### **C#**
{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Attachments-DisableFilesCompression-DisableFilesCompression.cs" >}}
