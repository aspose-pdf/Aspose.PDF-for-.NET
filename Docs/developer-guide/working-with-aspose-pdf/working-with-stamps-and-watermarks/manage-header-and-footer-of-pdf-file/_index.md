---
title: Manage Header and Footer of PDF File
type: docs
weight: 20
url: /net/manage-header-and-footer-of-pdf-file/
---

## **Adding Text in Header of PDF File**
You can use **TextStamp** class to add text in the header of a PDF file. **TextStamp** class provides properties necessary to create a text based stamp like font size, font style, and font color etc. In order to add text in the header, you need to create a **Document** object and a **TextStamp** object using required properties. After that, you can call **AddStamp** method of the **Page** to add the text in the header of the PDF. 

You need to set the **TopMargin** property in such a way that it adjusts the text in the header area of your PDF. You also need to set **HorizontalAlignment** to **Center** and **VerticalAlignment** to **Top**. The following code snippet shows you how to add text in the header of a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-TextinHeader-TextinHeader.cs" >}}
## **Adding Text in Footer of PDF File**
You can use **TextStamp** class to add text in the footer of a PDF file. **TextStamp** class provides properties necessary to create a text based stamp like font size, font style, and font color etc. In order to add text in the footer, you need to create a **Document** object and a **TextStamp** object using required properties. After that, you can call **AddStamp** method of the **Page** to add the text in the footer of the PDF. 

{{% alert color="primary" %}} 

You need to set the **Bottom** **Margin** property in such a way that it adjusts the text in the footer area of your PDF. You also need to set **HorizontalAlignment** to **Center** and **VerticalAlignment** to **Bottom** . 

{{% /alert %}} 

The following code snippet shows you how to add text in the footer of a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-TextinFooter-TextinFooter.cs" >}}
## **Adding Image in Header of PDF File**
You can use **Image** **Stamp** class to add image in the header of a PDF file. **Image** **Stamp** class provides properties necessary to create image based stamp like font size, font style, and font color etc. In order to add image in the header, you need to create a **Document** object and a **Image** **Stamp** object using required properties. After that, you can call **AddStamp** method of the **Page** to add the image in the header of the PDF. 
 

{{% alert color="primary" %}}  

You need to set the **TopMargin** property in such a way that it adjusts the image in the header area of your PDF. You also need to set **HorizontalAlignment** to **Center** and **VerticalAlignment** to **Top** . 

{{% /alert %}} 
The following code snippet shows you how to add image in the header of a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-ImageinHeader-ImageinHeader.cs" >}}
## **Adding Image in Footer of PDF File**
You can use **Image** **Stamp** class to add image in the footer of a PDF file. **Image** **Stamp** class provides properties necessary to create image based stamp like font size, font style, and font color etc. In order to add image in the footer, you need to create a **Document** object and an **Image** **Stamp** object using required properties. After that, you can call **AddStamp** method of the **Page** to add the image in the footer of the PDF. 

{{% alert color="primary" %}} 

You need to set the **Bottom** **Margin** property in such a way that it adjusts the image in the footer area of your PDF. You also need to set **HorizontalAlignment** to **Center** and **VerticalAlignment** to **Bottom** . 

{{% /alert %}} 

The following code snippet shows you how to add image in the footer of a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-ImageInFooter-ImageInFooter.cs" >}}
## **Adding different Headers in one PDF File**
We know that we can add TextStamp in Header/Footer section of the document by using TopMargin or **Bottom** **Margin** properties, but sometimes we may have the requirement to add multiple header/footers in a single PDF document. In order to accomplish this requirement, we will create individual TextStamp objects ( *number of objects depends upon the number of Header/Footers required* )and will add them to PDF document. We may also specify different formatting information for individual stamp object. In following example, we have created **Document** object and three **TextStamp** objects and then we have used **AddStamp** method of the **Page** to add the text in the header section of the PDF. The following code snippet shows you how to add image in the footer of a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-AddingDifferentHeaders-AddingDifferentHeaders.cs" >}}
