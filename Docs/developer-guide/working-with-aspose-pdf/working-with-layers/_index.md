---
title: Working with Layers
type: docs
weight: 60
url: /net/working-with-layers/
---


## **Add Layers to PDF File**
Layers can be used in PDF documents in many ways. You might have a multilingual file that you want to distribute and have text in each language appear on different layers, with the background design appearing on a separate layer. You might also create documents with animation that appears on a separate layer. Or you might add a license agreement to your file, and prevent a user from viewing the content until they agree to the terms of the agreement. To work with layers in PDF files, use the following API members.

The Layer class contains the following properties:

- Name – The layer's name.
- Id – The layer's ID.
- Contents – The layer operator list.

Once the Layer objects have been defined, add them to the [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) object's Layers collection.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-AddLayers-AddLayers.cs" >}}