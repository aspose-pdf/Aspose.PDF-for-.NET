---
title: Working with Attachments - Facades
type: docs
weight: 40
url: /net/working-with-attachments-facades/
---

## **Add Attachment from a File in an Existing PDF**
You can add an attachment in an existing PDF file using **PdfContentEditor** class. The attachment can be added from a file on the disk using the file path. You can add attachment using **AddDocumentAttachment** method. This method takes two arguments: file path and attachment description. First, you need to open the existing PDF file and add the attachement into it. Then you can save the output PDF file using **Save** method of **PdfContentEditor**. The following code snippet shows you how to add attachment from a file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Attachments-AddAttachment-AddAttachment.cs" >}}
## **Add Attachment from a Stream in an Existing PDF**
Attachment can be added in a PDF file from a stream – FileStream or MemoryStream – using **AddDocumentAttachment** method. This method takes three arguments: stream, attachment name, and attachment description. In order to add attachment, you need to create an object of **PdfContentEditor** class and bind the input PDF file using **BindPdf** method. After that, you can call **AddDocumentAttachment** method to add the attachment. Finally, you can call Save method to save the updated PDF file. The following code snippet shows you how to add attachment from a Stream.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Attachments-AddAttachmentStream-AddAttachmentStream.cs" >}}
## **Delete All Attachments from an Existing PDF File**
**DeleteAttachments** method of **PdfContentEditor** class allows you to delete all the attachments from an existing PDF file. You need to create an object of **PdfContentEditor** class and bind input PDF file using **BindPdf** method. After that, call the **DeleteAttachments** method. Finally, you have to call **Save** method to save the updated PDF file. The following code snippet shows you how to delete all attachments from an existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Attachments-DeleteAllAttachments-DeleteAllAttachments.cs" >}}
## **Extract All Attachments to Disk from Existing PDF File**
You can extract all attachments, from a PDF file, to disk using **GetAttachment** method. This method takes a single argument: the path to the location where the files to be saved. However, before calling **GetAttachment** method, you need to create **PdfExtractor** object and bind the input PDF file using **BindPdf** method. Also, you need to call **ExtractAttachment** method. This method extracts the attachments to memory, which can be further retrieved using **GetAttachment** method. The following code snippet shows you how to extract all attachments from existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Attachments-ExtractAllAttachments-ExtractAllAttachments.cs" >}}
## **Get Attachment Names from a PDF Document**
**GetAttachNames** method allows you to get the names of all the attachments in the PDF file. This method is provided by **PdfExtractor** class. In order to get attachment names, you first need to create **PdfExtractor** object and bind the input PDF file. After that, you need to call **ExtractAttachment** method, and then call **GetAttachnames** method. **GetAttachnames** method returns IList object, and you may cast this object to ArrayList type. Finally, you can navigate through all of the attachment names. The following code snippet shows you how to get attachment names from the PDF document.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Attachments-GetAttachmentNames-GetAttachmentNames.cs" >}}
