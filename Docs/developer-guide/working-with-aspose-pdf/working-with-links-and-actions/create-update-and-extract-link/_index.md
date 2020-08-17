---
title: Create, Update and Extract Link
type: docs
weight: 10
url: /net/create-update-and-extract-link/
---

## **Create Application Link in a PDF File**
By adding a link to an application into a document, it is possible to link to applications from a document. This is useful when you want readers to take a certain action at a specific point in a tutorial, for example, or to create a feature-rich document. To create an application link:

1. Create a [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object.
1. Get the [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) you want to add link to.
1. Create a [LinkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/linkannotation) object using the Page and [Rectangle](https://apireference.aspose.com/net/pdf/aspose.pdf/rectangle) objects.
1. Set the link attributes using the [LinkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/linkannotation) object.
1. Also, set the to [LaunchAction](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/launchaction) object's Action property.
1. When creating the [LaunchAction](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/launchaction) object, specify the application you want to launch.
1. Add the link to the Page object's [Annotations](https://apireference.aspose.com/net/pdf/aspose.pdf/page/properties/annotations) property.
1. Finally, save the updated PDF using the Document object's [Save](https://apireference.aspose.com/net/pdf/aspose.pdf/document/methods/save) method.

The following code snippet shows how to create a link to an application in a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Links-Actions-CreateApplicationLink-CreateApplicationLink.cs" >}}
## **Create PDF Document Link in a PDF File**
Aspose.PDF for .NET allows you to add a link to an external PDF file so that you can link several documents together. To create a PDF document link:

1. First, create a [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object.
1. Then, get the particular [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) you want to add the link to.
1. Create a [LinkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/linkannotation) object using the Page and [Rectangle](https://apireference.aspose.com/net/pdf/aspose.pdf/rectangle) objects.
1. Set the link attributes using the [LinkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/linkannotation) object.
1. Set the Action property to the [GoToRemoteAction](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/gotoremoteaction) object.
1. While creating the GoToRemoteAction object, specify the PDF file that should launch, as well as the page number it should open on.
1. Add the link to the Page object's Annotations collection.
1. Save the updated PDF using the Document object's [Save](https://apireference.aspose.com/net/pdf/aspose.pdf/document/methods/save) method.

The following code snippet shows how to create PDF document link in a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Links-Actions-CreateDocumentLink-CreateDocumentLink.cs" >}}
## **Update Links in a PDF File**
As discussed in [Add Hyperlink in a PDF File](https://docs.aspose.com/pdf/net/add-and-get-hyperlink/), the [LinkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/linkannotation) class makes it possible to add links in a PDF file. There's also a similar class used to get existing links from inside PDF files. Use this if you need to update an existing link. To update an existing link:

1. Load a PDF file.
1. Go to a specific page in the PDF file.
1. Specify the link destination using the [GoToAction](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/gotoaction) object's Destination property.
1. The destination page is specified using the [](http://www.aspose.com/api/net/pdf/aspose.pdf.interactivefeatures/xyzexplicitdestination)[XYZExplicitDestination](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/xyzexplicitdestination) constructor.
### **Set Link Target to a Page in the Same Document**
The following code snippet shows you how to update a link in a PDF file and set its target to the second page of the document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Links-Actions-UpdateLinks-UpdateLinks.cs" >}}
### **Set Link Destination to a Web Address**
To update the hyperlink so that it points to a web address, instantiate the [GoToURIAction](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/gotouriaction) object and pass it to the LinkAnnotation's Action property. The following code snippet shows how to update a link in a PDF file and set its target to a web address.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Links-Actions-SetDestinationLink-SetDestinationLink.cs" >}}
### **Set Link Target to Another PDF File**
The following code snippet shows how to update a link in a PDF file and set its target to another PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Links-Actions-SetTargetLink-SetTargetLink.cs" >}}
### **Update LinkAnnotation Text Color**
The link annotation does not contain text. Instead, the text is placed in the contents of the page under the annotation. Therefore, to change the color of the text, replace the color of the page text instead of trying change color of the annotation. The following code snippet shows how to update the color of link annotation in a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Links-Actions-UpdateLinkTextColor-UpdateLinkTextColor.cs" >}}
## **Extract Links from the PDF File**
Links are represented as annotations in a PDF file, so to extract links, extract all the [LinkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/linkannotation) objects.

1. Create a [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object.
1. Get the [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) you want to extract links from.
1. Use the [AnnotationSelector](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationselector) class to extract all the [LinkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/linkannotation) objects from the specified page.
1. Pass the [AnnotationSelector](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationselector) object to the Page object's Accept method.
1. Get all the selected link annotations into an IList object using the [AnnotationSelector](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationselector) object's Selected property.

The following code snippet shows you how to extract links from a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Links-Actions-ExtractLinks-ExtractLinks.cs" >}}
