---
title: Working with Links and Actions - Facades
type: docs
weight: 60
url: /net/working-with-links-and-actions-facades/
---

## **Create Application Link in Existing PDF File**
**CreateApplicationLink** method allows you to add a link in a PDF file, which can be used to launch an external application. For example, in the following code, we have tried to create a link to a text file. When you click the link in the output PDF file, it will open the text file, using the text editor, on your computer. You can create an application link using **CreateApplicationlink** method of **PdfContentEditor** class. The **CreateApplicationLink** method requires three arguments: a rectangle (to specify the location where link is to be added), the application to be launched, and the page number at which the link needs to be added. You also need to save the output PDF file using **Save** method. The following code snippet shows you how to create an application link in a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Links-Actions-CreateAppLink-CreateAppLink.cs" >}}
## **Create Application Link with Color in Existing PDF File**
You can use **CreateApplicationLink** method to add a link, with the color, in a PDF file, which can be used to launch an external application. For example, in the following code, we have tried to create a link to a text file. When you click the link in the output PDF file, it will open the text file, using the text editor, on your computer. You can create an application link using **CreateApplicationlink** method of **PdfContentEditor** class. The **CreateApplicationLink** method requires four arguments: a rectangle (to specify the location where link is to be added), the application to be launched, the page number at which the link needs to be added, and the color of the link. You also need to save the output PDF file using **Save** method. The following code snippet shows you how to create an application link with color in a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Links-Actions-CreateAppLinkWithColor-CreateAppLinkWithColor.cs" >}}
## **Create Local Link in Existing PDF File**
**CreateLocalLink** method allows you to create a link within the PDF file. This link can take you to the specified page number. The **CreateLocalLink** method takes four arguments: a rectangle which specifies the area where link is to be added, the destination page number, the page number on which the link needs to be added, and a color attribute for the link. The following code snippet shows you how to create a local link in Existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Links-Actions-CreateLocalLink-CreateLocalLink.cs" >}}
## **Create JavaScript Link in Existing PDF File**
**CreateJavaScriptLink** method allows you to create a link, in a PDF file, which helps execute JavaScript on a click. This method takes four arguments: the JavaScript code, a rectangle which specifies the area where link needs to be added, page number at which the link needs to be added, and color attribute. 
You need to create an object of **PdfContentEditor** class and bind the input PDF file using **BindPdf** method. After that, you need to call **CreateJavaScriptLink** method and finally save the updated PDF using **Save** method of **PdfContentEditor** class. The following code snippet shows you how to create a JavaScript link in Existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Links-Actions-CreateJSLink-CreateJSLink.cs" >}}
## **Remove Document Open Action Command from Existing PDF File**
The **RemoveDocumentOpenAction** method allows you to remove open action from the document. You may want to remove opening action when concatenating multiple documents that use explicit GoTo action on startup. For example, the second document contains the GoTo action, which takes you to the first page of this document. When you concatenate this document with other documents, the command executes and it takes you to the first page of the second document, instead of the first page of the concatenated document. In such scenarios, you may remove the open action command. 
You need to create an object of **PdfContentEditor** class and bind the input PDF file using **BindPdf** method. After that, you need to call **RemoveDocumentOptionAction** method. Finally, you have to save the updated PDF file using **Save** method. The following code snippet shows you how to remove document open action command from PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Links-Actions-RemoveAction-RemoveAction.cs" >}}
## **Create Document Additional Action in an Existing PDF File**
**CreateDocumentAdditionalAction** method allows you to add additional actions, for PDF document events, in an existing PDF file. The document events include: **DocumentOpen**, **DocumentClose**, **DocumentPrinted**, **DocumentSaved**, **DocumentWillPrint**, **DocumentWillSave**. 
You need to create an object of **PdfContentEditor** class and bind input PDF file using **BindPdf** method. After that, you can call the **AddDocumentAdditionalAction** method. This method requires two arguments: the document event to which the action needs to be attached, the JavaScript code. Finally, you have to save the updated PDF file using **Save** method of **PdfContentEditor** class. The following code snippet shows you how add additional actions to an existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Links-Actions-CreateDocAdditionalAction-CreateDocAdditionalAction.cs" >}}
## **Create PDF Document Link in an Existing PDF File**
**CreatePdfDocumentLink** method allows you to add a link to a PDF file targeting a particular page. You need to create an object of **PdfContentEditor** class and bind input PDF file using **BindPdf** method. After that, you can call the **AddPdfDocumentLink** method. This method requires four arguments: the rectangle where link needs to be added, path to the PDF file, page number of the PDF where this link is to be added, and the page of the PDF to open. Finally, you have to save the updated PDF file using **Save** method of **PdfContentEditor** class. The following code snippet shows you how add PDF document link to an existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Links-Actions-CreateDocLink-CreateDocLink.cs" >}}
