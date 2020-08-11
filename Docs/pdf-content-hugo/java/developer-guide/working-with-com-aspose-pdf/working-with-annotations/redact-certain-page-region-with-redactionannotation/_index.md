---
title: Redact certain page region with RedactionAnnotation
type: docs
weight: 30
url: /java/redact-certain-page-region-with-redactionannotation/
---

Aspose.PDF for Java supports the feature to add as well as manipulate Annotations in an existing PDF file. Recently some of our customers requested the Redaction feature, to redact (remove text, image, etc elements from) certain page region of PDF document. In order to fulfill this requirement, a class named RedactionAnnotation is provided, which can be used to redact certain page region or it can be used to manipulate existing RedactionAnnotations and redact them (i.e. flatten annotation and remove the text under it).
## **Redact Page Region with RedactionAnnotation**
In order to redact a page region with RedactionAnnotation, the following steps can be used.

1. Create a new object of Document class
1. Define a Rectangle object with desired region parameters
1. Create an object of RedactionAnnotation with page information
1. Add annotation to the desired page of Document object
1. Save the document 

{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-Annotations-RedactCertainPageRegionWithRedactionAnnotation-RedactCertainPageRegionWithRedactionAnnotation.java" >}}
## **Redact Page Region - Facades approach**
com.aspose.pdf.facades namespace also has a class named [**PdfAnnotationEditor**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfAnnotationEditor) which provides the feature to manipulate existing Annotations inside PDF file. This class contains a method named [**redactArea(..)**](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/PdfAnnotationEditor#redactArea-int-com.aspose.pdf.Rectangle-java.awt.Color-) which provides the capability to remove certain page regions.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-annotations-RedactCertainPageRegionWithRedactionAnnotation-FacadesApproach.java" >}}
