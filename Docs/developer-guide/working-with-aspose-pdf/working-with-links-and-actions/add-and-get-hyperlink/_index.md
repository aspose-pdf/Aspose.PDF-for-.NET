---
title: Add and Get Hyperlink
type: docs
weight: 20
url: /net/add-and-get-hyperlink/
---

## **Add Hyperlink in a PDF File**
It is possible to add hyperlinks to PDF files, either to allow readers to navigate to another part of the PDF, or to external content.

In order to add web hyperlinks to PDF documents:

1. Create a [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) Class object.
1. Get the [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) Class you want to add the link to.
1. Create a [LinkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/linkannotation) object using the Page and [Rectangle](https://apireference.aspose.com/net/pdf/aspose.pdf/rectangle) objects.
   The rectangle object is used to specify the location on the page where the link should be added.
1. Set the Action property to the [GoToURIAction](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/gotouriaction) object which specifies the location of the remote URI.
1. To display a hyperlink text, add a text string on a location similar to where the LinkAnnotation object is placed.
1. To add a free text:
   1. Instantiate an [FreeTextAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/freetextannotation) object. It also accepts Page and Rectangle objects as argument, so it is possible to provide same values as specified against the [LinkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/linkannotation) constructor.
   1. Using the FreeTextAnnotation object's Contents property, specify the string that should be displayed in the output PDF.
   1. Optionally, set the border width of both the [LinkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/linkannotation) and [FreeTextAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/freetextannotation) objects to 0 so that they do not appear in the PDF document.
1. Once the [LinkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/linkannotation) and [FreeTextAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/freetextannotation) objects have been defined, add these links to the [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) object's Annotations collection.
1. Finally, save the updated PDF using the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's [Save](https://apireference.aspose.com/net/pdf/aspose.pdf/document/methods/save) method.

The following code snippet shows you how to add a hyperlink to a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Links-Actions-AddHyperlink-AddHyperlink.cs" >}}
## **Create hyperlink to pages in same PDF**
Aspose.PDF for .NET provides a great feature to PDF creation as well as its manipulation. It also offers the feature to add links to PDF pages and a link can either direct to pages in another PDF file, a web URL, link to launch an Application or even link to pages in same PDF file. In order to add local hyperlinks (links to pages in same PDF file), a class named [LocalHyperlink](https://apireference.aspose.com/net/pdf/aspose.pdf/localhyperlink) is added to Aspose.PDF namespace and this class has a property named **TargetPageNumber**, which is used to specify the target/destination page for hyperlink.

In order to add the local hyperlink, we need to create a TextFragment so that link can be associated with the TextFragment. The [TextFragment](https://apireference.aspose.com/net/pdf/aspose.pdf.text/textfragment) class has a property named **Hyperlink** which is used to associate LocalHyperlink instance. The following code snippet shows the steps to accomplish this requirement.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Links-Actions-CreateLocalHyperlink-CreateLocalHyperlink.cs" >}}
## **Get PDF Hyperlink Destination (URL)**
Links are represented as annotations in a PDF file and they can be added, updated or deleted. Aspose.PDF for .NET also supports getting the destination (URL) of the hyperlink in PDF file.

To get a link's URL:

1. Create a [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object.
1. Get the [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) you want to extract links from.
1. Use the [AnnotationSelector](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationselector) class to extract all the [LinkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/linkannotation) objects from the specified page.
1. Pass the [AnnotationSelector](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationselector) object to the [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) object's Accept() method.
1. Get all the selected link annotations into an IList object using the [AnnotationSelector](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationselector) object's Selected property.
1. Finally, extract the LinkAnnotation Action as GoToURIAction.

The following code snippet shows how to get hyperlink destinations (URL) from a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Links-Actions-GetHyperlinkDestinations-GetHyperlinkDestinations.cs" >}}
### **Get Hyperlink Text**
A hyperlink has two parts: the text that shows in the document, and the destination URL. In some cases, it's the text rather than the URL we need.

Text and annotations/actions in a PDF file are represented by different entities. Text on а page is just а set of words and characters, while annotations bring some interactivity such as that inherent in a hyperlink.

To find the URL content, you need to work with both annotation and text. The [Annotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotation) object does not have itself have the text but sits under the text on the page. So to get the text, the Annotation gives the URL's bounds, while the **Text** object gives the URL contents. Please see the following code snippet.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Links-Actions-GetHyperlinkText-GetHyperlinkText.cs" >}}
## **Remove Document Open Action from a PDF File**
[How to Specify PDF Page when Viewing Document](https://docs.aspose.com/pdf/net/manipulate-page-in-a-pdf-file/) explained how to tell a document to open on a different page than the first. When concatenating several documents, and one or more has a GoTo action set, you probably want to remove them. For example, if combining two documents and the second one has a GoTo action that takes you to the second page, the output document will open on the second page of the second document instead of the first page of the combined document. To avoid this behavior, remove the open action command.

To remove an open action:

1. Set the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object's [OpenAction](https://apireference.aspose.com/net/pdf/aspose.pdf/document/properties/openaction) property to null.
1. Save the updated PDF using the Document object's [Save](https://apireference.aspose.com/net/pdf/aspose.pdf/document/methods/save) method.

The following code snippet shows how to remove a document open action from the PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Links-Actions-RemoveOpenAction-RemoveOpenAction.cs" >}}
## **How to Specify PDF Page when Viewing Document**
When viewing PDF files in a PDF viewer such as Adobe Reader, the files usually open on the first page. However, it is possible to set the file to open on a different page.

The [XYZExplicitDestination](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/xyzexplicitdestination) class allows you to specify a page in a PDF file that you want to open. When passing the GoToAction object value to the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class OpenAction property, the document opens at the page specified against the XYZExplicitDestination object. The following code snippet shows how to specify a page as the document open action.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Links-Actions-SpecifyPageWhenViewing-SpecifyPageWhenViewing.cs" >}}
