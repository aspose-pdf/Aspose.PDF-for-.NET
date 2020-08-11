---
title: Set Custom Form Field Font
type: docs
weight: 50
url: /java/set-custom-form-field-font/
---

{{% alert color="primary" %}} 

Form fields in Adobe PDF files can be configured to use specific default fonts. Aspose.PDF allows developers to apply any font as a field default font, whether one of the 14 core fonts or a custom font.

{{% /alert %}} 

To set and update the default font used for form fields, Aspose.PDF has the DefaultAppearance(Font font, double size, Color color) class. This class can be accessed using com.aspose.pdf.DefaultAppearance. To use this object, use the Field class' setDefaultAppearance(..) method.

The following code snippet shows you how to set the default font for PDF form field.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-SetCustomFormFieldFont-.java" >}}



