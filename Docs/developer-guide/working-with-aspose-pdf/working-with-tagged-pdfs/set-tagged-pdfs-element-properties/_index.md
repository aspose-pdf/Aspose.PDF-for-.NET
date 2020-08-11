---
title: Set Tagged PDFs Element Properties
type: docs
weight: 30
url: /net/set-tagged-pdfs-element-properties/
---

## **Setting Structure Elements Properties**
In order to set structure elements properties in a Tagged PDF Document, Aspose.PDF offers **CreateSectElement()** and **CreateHeaderElement()** methods of **ITaggedContent** Interface. Following code snippet shows how to set structure elements properties of a Tagged PDF Document:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-StructureElementsProperties-StructureElementsProperties.cs" >}}
## **Setting Text Structure Elements**
In order to set text structure elements of a Tagged PDF Document, Aspose.PDF offers **ParagraphElement** Class. Following code snippet shows how to set text structure elements of a Tagged PDF Document:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-TextStructureElements-TextStructureElements.cs" >}}
## **Setting Text Block Structure Elements**
In order to set text block structure elements of a Tagged PDF Document, Aspose.PDF offers **HeaderElement** and **ParagraphElement** Classes. You can append objects of these classes as a child of **StructureElement** object. Following code snippet shows how to set text block structure elements of a Tagged PDF Document:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-TextBlockStructureElements-TextBlockStructureElements.cs" >}}
## **Setting Inline Structure Elements**
In order to set inline structure elements of a Tagged PDF Document, Aspose.PDF offers **SpanElement** and **ParagraphElement** Classes. You can append objects of these classes as a child of **StructureElement** object. Following code snippet shows how to set inline structure elements of a Tagged PDF Document:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-InlineStructureElements-InlineStructureElements.cs" >}}
## **Setting Custom Tag Name**
In order to set a custom tag name of the elements of a Tagged PDF Document, Aspose.PDF offers **SetTag()** method for elements. Following code snippet shows how to set custom tag name:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-Document-CustomTagName-CustomTagName.cs" >}}
## **Adding Structure Element into Elements**
{{% alert color="primary" %}} 

This feature is supported by version 19.4 or greater.

{{% /alert %}} 

In order to set link structure elements in a Tagged PDF Document, Aspose.PDF offers **CreateLinkElement()** method of **ITaggedContent** Interface. Following code snippet shows how to set structure elements in paragraph with text of Tagged PDF Document:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-with-TaggedPDFs-LinkStructureElements-LinkStructureElements.cs" >}}
## **Setting Link Structure Element**
{{% alert color="primary" %}} 
This feature is supported by version 19.4 or greater.
{{% /alert %}} 
Aspose.PDF for .NET API also allows you to add link structure elements. Following code snippet shows how to add link structure element into Tagged PDF Document:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-with-TaggedPDFs-AddStructureElementIntoElement-AddStructureElementIntoElement.cs" >}}
## **Setting Note Structure Element**
Aspose.PDF for .NET API also allows you to add [NoteElement](https://apireference.aspose.com/net/pdf/aspose.pdf.logicalstructure/noteelement) in a tagged PDF document. Following code snippet shows how to add note element in Tagged PDF Document:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-with-TaggedPDFs-CreateNoteStructureElement-CreateNoteStructureElement.cs" >}}
## **Setting Language and Title**
{{% alert color="primary" %}} 

This feature is supported by version 19.6 or greater.

{{% /alert %}} 

Aspose.PDF for .NET API also allows you to set language and title for a document according to specification PDF/UA. The language can be set up as for whole document as for its separate structural elements. Following code snippet shows how to et language and title in Tagged PDF Document:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Working-with-TaggedPDFs-SetupLanguageAndTitle-1.cs" >}}
