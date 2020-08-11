---
title: Working with Document - Facades
type: docs
weight: 80
url: /net/working-with-document-facades/
---

## **Set Viewer Preference of an existing PDF File**
**ViewerPreference** class represents display modes of PDF files; for example, positioning the document window in the center of the screen, hiding viewer application’s menu bar etc. **ChangeViewerPreference** method in **PdfContentEditor** class allows you to change the viewer preference. In order to do that, you need to create an object of **PdfContentEditor** class and bind the input PDF file using **BindPdf** method. Ater that, you can call **ChangeViewerPreference** method to set any preference. Finally, you have to save the updated PDF file using **Save** method. The following code snippet shows you how to change viewer preference in an existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Working-Document-SetViewerPreference-SetViewerPreference.cs" >}}
## **Set PDF File Information**
**PdfFileInfo** class allows you to set file specific information of a PDF file. You need to create an object of **PdfFileInfo** class and then set different file specific properties like Author, Title, Keyword, and Creator etc. Finally, save the updated PDF file using **SaveNewInfo** method of the **PdfFileInfo** object. The following code snippet shows you how to set PDF file information.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Working-Document-SetFileInfo-SetFileInfo.cs" >}}
## **Get PDF file information**
In order to get file specific information of a PDF file, you need to create an object of **PdfFileInfo** class. After that, you can get values of the individual properties like Subject, Title, Keywords and Creator etc. The following code snippet shows you how to get PDF file information.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Working-Document-GetFileInfo-GetFileInfo.cs" >}}
## **Set XMP Metadata of an existing PDF**
In order to set XMP metadata in a PDF file, you need to create **PdfXmpMetadata** object and bind the PDF file using **BindPdf** method. You can use **Add** method of the **PdfXmpMetadata** class to add different properties. Finally, call the **Save** method of the **PdfXmpMetadata** class. The following code snippet shows you how to add XMP metadata in a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Working-Document-SetXMPMetadata-SetXMPMetadata.cs" >}}
## **Get XMP Metadata of an Existing PDF File**
In order to get XMP metadata from a PDF file, you need to create **PdfXmpMetadata** object and bind the PDF file using **BindPdf** method. You can pass specific XMP metadata properties to the **PdfXmpMetadata** object to get their values. The following code snippet shows you how to get XMP metadata from a PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Working-Document-GetXMPMetadata-GetXMPMetadata.cs" >}}
## **Page Break in existing PDF**
As a default layout, the contents inside PDF files are added in Top-Left to Bottom-Right layout. Once the contents exceed beyond page bottom margin, the page break occurs. However you may come across a requirement to insert page break depending upon requirement. A method named AddPageBreak(...) method is added in **PdfFileEditor** class to accomplish this requirement.

1. public void AddPageBreak(Document src, Document dest, PageBreak[] pageBreaks)
1. public void AddPageBreak(string src, string dest, PageBreak[] pageBreaks)
1. public void AddPageBreak(Stream src, Stream dest, PageBreak[] pageBreaks)
- src is source document/path to document/stream with source document;
- dest is destination document/path where document will be saved/stream where document will be saved.;
- PageBreak is array of page break objects. It have two properties: index of page where page break must be placed and vertical position of the page break on the page.
### **Example-1**


{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Working-Document-PageBreak-PageBreak.cs" >}}
### **Example-2**


{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Working-Document-PageBreak-PageBreakWithDestPath.cs" >}}
### **Example-3**


{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Working-Document-PageBreak-PageBreakWithStream.cs" >}}
