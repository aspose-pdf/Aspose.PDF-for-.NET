---
title: Redact certain page region with RedactionAnnotation
type: docs
weight: 10
url: /net/redact-certain-page-region-with-redactionannotation/
---

## **Redact certain page region with RedactionAnnotation**
Aspose.PDF for .NET supports the feature to add as well as manipulate Annotations in an existing PDF file. Recently some of our customers posted a required to redact (remove text, image, etc elements from) a certain page region of PDF document. In order to fulfill this requirement, a class named RedactionAnnotation is provided, which can be used to redact certain page regions or it can be used to manipulate existing RedactionAnnotations and redact them (i.e. flatten annotation and remove the text under it).

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-RedactPage-RedactPage.cs" >}}
### **Facades approach**
Aspose.PDF.Facades namespace also has a class named **PdfAnnotationEditor** which provides the feature to manipulate existing Annotations inside PDF file. This class contains a method named **RedactArea(..)** which provides the capability to remove certain page regions.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-RedactPage-FacadesApproach.cs" >}}
