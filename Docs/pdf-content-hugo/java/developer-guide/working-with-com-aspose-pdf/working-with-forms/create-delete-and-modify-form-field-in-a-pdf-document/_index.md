---
title: Create, Delete and Modify Form Field in a PDF Document
type: docs
weight: 10
url: /java/create-delete-and-modify-form-field-in-a-pdf-document/
---

## **Add Form Field in a PDF Document**
The [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) class provides a collection named Form which helps manage form fields in a PDF document.

To add a form field:

1. Create the form field which you want to add.
1. Call the Form collection's add method.

This example shows how to add a TextBoxField. You can add any form field using the same approach:

1. First, create a field object and set its properties.
1. Then, add the field to the Form collection.

The following code snippets shows how to add a TextBoxField to a PDF document.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-AddFormFieldInPDFDocument-AddFormFieldInPDFDocument.java" >}}
### **Adding RadioButtonField**
#### **Example 1**
The following code snippets show how to add RadioButtonField in a PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-AddFormFieldInPDFDocument-AddRadioButtonFieldInPDFDocument.java" >}}
#### **Example 2**
The following code snippet shows the steps to add RadioButtonField with three options and place them inside Table cells.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-AddFormFieldInPDFDocument-AddRadioButtonFieldWithThreeOptions.java" >}}
### **Adding ComboBox field**
The following code snippets show how to add ComboBox field in a PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-AddFormFieldInPDFDocument-AddingComboBoxField.java" >}}
### **Adding Signature field**
The following code snippets show how to add Signature field in a PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-AddFormFieldInPDFDocument-AddingSignatureField.java" >}}
## **Delete a Particular Form Field from a PDF Document**
All the form fields are contained in the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's Form collection. This collection provides different methods that manage form fields, including the delete method. If you want to delete a particular field, pass the field name as a parameter to the delete method and then save the updated PDF document.

The following code snippet shows how to delete a named field from a PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-DeleteParticularFormFieldFromPDFDocument-.java" >}}
## **Modify Form Field in a PDF Document**
The [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's Form collection allows you to manage form fields in a PDF document.

To modify a form field, get the field from the Form collection and set its properties. Then save the updated PDF document.

The following code snippet shows how to modify an existing form field in a PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-ModifyFormFieldInPDFDocument-.java" >}}
## **Move Form Field to a New Location in a PDF File**
If you want to move a form field to a new location on a PDF page, first get the field object and then specify a new value for its setRect method. A [Rectangle](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Rectangle) object with new coordinates is assigned to the setRect(..) method. Then save the updated PDF using the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document) object's save method.

The following code snippet shows you how to move a form field to a new location.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-MoveFormFieldToNewLocationInPDFFile-.java" >}}
