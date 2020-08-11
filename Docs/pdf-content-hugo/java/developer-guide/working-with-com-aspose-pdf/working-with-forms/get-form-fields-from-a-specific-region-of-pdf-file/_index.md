---
title: Get Form Fields from a Specific Region of PDF File
type: docs
weight: 60
url: /java/get-form-fields-from-a-specific-region-of-pdf-file/
---

{{% alert color="primary" %}} 

Sometimes, you might know where in a document a form field is, but not have it's name. For example, if all you have to go from is a schematic of a printed form. With Aspose.PDF for Java, this is not a problem. You can find out which fields are in a given region of a PDF file.

{{% /alert %}} 

To get form fields from a specific region of a PDF file:

1. Open the PDF file using the [Document](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Document) object.
1. Get the form from the Forms collection.
1. Specify the rectangular region and pass it to the Form object's GetFieldsInRect method. A Fields collection is returned.
1. Use this to manipulate the fields.

The following code snippet shows how to get form fields in a specific rectangular region of a PDF file.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-GetFormFieldsFromSpecificRegionOfPDFFile-.java" >}}
