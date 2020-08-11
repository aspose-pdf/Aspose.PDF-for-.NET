---
title: Get and Set value of Form Field in a PDF Document
type: docs
weight: 20
url: /java/get-and-set-value-of-form-field-in-a-pdf-document/
---

## **Set Value of Form Field in a PDF Document**
To fill a form field, get the field from the [Document](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Document) object's Form collection. Then set the field value using the field's setValue method.

This example selects a TextBoxField and sets its value using the setValue(..) method.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-FillFormFieldInPDFDocument-.java" >}}
## **Get Value from an Individual Field of PDF Document**
The form field's getValue() method allows you to get the value of a particular field.

To get the value, get the form field from the [Document](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Document) object's Form collection.

This example selects a TextBoxField and retrieves its value using the getValue() method.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-GetValueFromAnIndividualFieldOfPDFDocument-.java" >}}
## **Get Values from All Fields in a PDF Document**
To get values from all the fields in a PDF document, you need to navigate through all the form fields and then get the value using the getValue() property. Get each field from the Form collection using the [Document](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Document) object's [getForm()](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/document/methods/getForm\(\)/) method and get the list of form fields into an Field[] array using getFields() and traverse through array to get value of fields.

The following code snippet shows how to get the values of all the fields in a PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-GetValuesFromAllFieldsInPDFDocument-.java" >}}
