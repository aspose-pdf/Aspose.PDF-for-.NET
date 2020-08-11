---
title: Convert Dynamic XFA Form to Standard AcroForm
type: docs
weight: 70
url: /java/convert-dynamic-xfa-form-to-standard-acroform/
---

{{% alert color="primary" %}} 

Dynamic forms are based on an XML specification known as XFA, the “XML Forms Architecture”. The information about the form (as far as PDF is concerned) is very vague – it specifies that fields exist, with properties, and JavaScript events, but does not specify any rendering.

{{% /alert %}} 

Currently PDF supports two different methods for integrating data and PDF forms:

- AcroForms (also known as Acrobat forms), introduced and included in the PDF 1.2 format specification.
- Adobe XML Forms Architecture (XFA) forms, introduced in the PDF 1.5 format specification as an optional feature. (The XFA specification is not included in the PDF specification, it is only referenced.)

It's not possible to extract or manipulate pages of XFA Forms, because the form content is generated at runtime (during XFA form viewing) within the application trying to display or render the XFA form. Aspose.PDF has a feature that allows developers to convert XFA forms to standard AcroForms.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-ConvertDynamicXFAFormToStandardAcroForm-.java" >}}



