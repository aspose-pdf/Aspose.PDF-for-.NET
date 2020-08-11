---
title: Working with Existing Watermarks
type: docs
weight: 30
url: /net/working-with-existing-watermarks/
---

## **Working with Existing Watermarks**
A watermark created with Adobe Acrobat is called an artifact (as described in 14.8.2.2 Real Content and Artifacts of the PDF specification). In order to work with artifacts, Aspose.PDF has two classes: [Artifact](https://apireference.aspose.com/net/pdf/aspose.pdf/artifact) and [ArtifactCollection](https://apireference.aspose.com/net/pdf/aspose.pdf/artifactcollection).

In order to get all artifacts on a particular page, the [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) class has the Artifacts property. This topic explains how to work with artifact in PDF files.
### **Working with Artifacts**
The [Artifact](https://apireference.aspose.com/net/pdf/aspose.pdf/artifact) class contains following properties:

- **Artifact.Type** – gets the artifact type (supports values of the Artifact.ArtifactType enumeration where values include Background, Layout, Page, Pagination and Undefined).
- **Artifact.Subtype** – gets artifact subtype (supports the values of the Artifact.ArtifactSubtype enumeration where values include Background, Footer, Header, Undefined, Watermark).

{{% alert color="primary" %}} 

Please note that watermarks created with Adobe Acrobat have the type Pagination and subtype Watermark.

{{% /alert %}} 

- **Artifact.Contents** – Gets a collection of artifact internal operators. Its supported type is System.Collections.ICollection.
- **Artifact.Form** – Gets an artifact's XForm (if XForm is used). Watermarks, header, and footer artifacts contains XForm which shows all artifact contents.
- **Artifact.Image** – Gets an artifact's image (if an image is presents, else null).
- **Artifact.Text** – Gets an artifact's text.
- **Artifact.Rectangle** – Gets an position of an artifact on the page.
- **Artifact.Rotation** – Gets an artifact's rotation (in degrees, positive value indicates counter-clockwise rotation).
- **Artifact.Opacity** – Gets an artifact's opacity. Possible values are in the range 0...1, where 1 is completely opaque.
#### **Programming Samples: Getting Watermarks**
The following code snippet shows how to get each watermark on the first page of a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-GetWatermark-GetWatermark.cs" >}}
#### **Programming Samples: Counting Artifacts of a Particular Type**
To calculate the total count of artifacts of a particular type (for example, the total number of watermarks), use the following code:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Stamps-Watermarks-CountingArtifacts-CountingArtifacts.cs" >}}
