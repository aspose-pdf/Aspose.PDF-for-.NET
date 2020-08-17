---
title: Add, Delete and Modify Form Field
type: docs
weight: 10
url: /net/add-delete-and-modify-form-field/
---

## **Add Form Field in a PDF Document**
The [Document](https://apireference.aspose.com/pdf/net/aspose.pdf/document) class provides a collection named [Form](https://apireference.aspose.com/net/pdf/aspose.pdf/document/properties/form) which helps you manage form fields in a PDF document.

To add a form field:

1. Create the form field you want to add.
1. Call the [Form](https://apireference.aspose.com/net/pdf/aspose.pdf/document/properties/form) collection's Add method.
### **Adding TextBoxField**
Below example shows how to add a [TextBoxField](https://apireference.aspose.com/net/pdf/aspose.pdf.forms/textboxfield).

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-TextBox-AddTextBoxField.cs" >}}
### **Adding RadioButtonField**
The following code snippets show how to add RadioButtonField in a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-RadioButton-RadioButton.cs" >}}

The following code snippet shows the steps to add RadioButtonField with three options and place them inside Table cells.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-RadioButtonWithOptions-RadioButtonWithOptions.cs" >}}
### **Adding Caption to RadioButtonField**
Following code snippet shows how to add caption which will be associated with RadioButtonField:



{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-SetRadioButtonCaption-1.cs" >}}
### **Adding ComboBox field**
The following code snippets show how to add ComboBox field in a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-ComboBox-ComboBox.cs" >}}
## **Add Tooltip to Form Field**
The [Document](https://apireference.aspose.com/pdf/net/aspose.pdf/document) class provides a collection named [Form](https://apireference.aspose.com/net/pdf/aspose.pdf/document/properties/form) which manages form fields in a PDF document. To add a tooltip to a form field, use the Field class AlternateName. Adobe Acrobat uses the 'alternate name' as a field tooltip.

The code snippets that follow show how to add a tooltip to a form field, first using C# and then Visual Basic.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-AddTooltipToField-AddTooltipToField.cs" >}}
## **How to add Grouped Checkboxes**
The **Document** class provides a collection named **Form** which helps you manage form fields in a PDF document. The **RadioButtonField** provides the feature to add RadioButtons field to PDF document and in order to represent checkboxes, you may consider setting border style for RadioButtonField.

Once the RadioButtonField object is created, you need to add **RadioButtonOptionField** instances to RadioButtonField object and in order to set border style, you need to use **Style** property and set value from **BoxStyle** enumeration. The **BoxStyle** enumeration supports following values.

|**Sr. #**|**BoxStyle**|
| :- | :- |
|1|Check|
|2|Circle|
|3|Cross|
|4|Diamond|
|5|Square|
|6|Star|
The following code snippets show how to create grouped CheckBoxes to a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-GroupedCheckBoxes-GroupedCheckBoxes.cs" >}}
## **Determine if a Field is Marked as Required**
Aspose.PDF for .NET allows you to retrieve information related to form fields in a document. It also allows you to get the information and properties associated with a particular form field. The following code snippet shows how to determine if a particular form field is marked as required or not.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-DetermineRequiredField-DetermineRequiredField.cs" >}}
## **Delete a Particular Form Field from a PDF Document**
All the form fields are contained in the [Document](https://apireference.aspose.com/pdf/net/aspose.pdf/document) object's [Form](https://apireference.aspose.com/net/pdf/aspose.pdf/document/properties/form) collection. This collection provides different methods that manage form fields, including the Delete method. If you want to delete a particular field, pass the field name as a parameter to the Delete method and then save the updated PDF document. The following code snippet shows how to delete a particular field from a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-DeleteFormField-DeleteFormField.cs" >}}
## **Modify Form Field in a PDF Document**
To modify an existing form field, you can get the field from the Form collection and set its properties. Then save the updated PDF document. The following code snippet shows how to modify an existing form field in a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-ModifyFormField-ModifyFormField.cs" >}}
## **Fill Form Field in a PDF Document**
To fill a form field, get the field from the [Document](https://apireference.aspose.com/pdf/net/aspose.pdf/document) object's Form collection. then set the field value using the field's Value property.

This example selects a [TextBoxField](https://apireference.aspose.com/net/pdf/aspose.pdf.forms/textboxfield) and sets its value using the Value property.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-FillFormField-FillFormField.cs" >}}
### **Support Arabic text filling in Textboxfield**
Non-English languages including Arabic can be used to fill form fields. Please take a look over following code snippet to fill Form fields with Arabic text/contents.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-ArabicTextFilling-ArabicTextFilling.cs" >}}
### **Select RadioButton from group**
Radio buttons can be added in group and following code snippet can be used to select particular radio button from group.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-SelectRadioButton-SelectRadioButton.cs" >}}
## **Move Form Field to a New Location in a PDF File**
If you want to move a form field to a new location on a PDF page, first get the field oobject and then specify a new value for its Rect property. A [Rectangle](https://apireference.aspose.com/net/pdf/aspose.pdf/rectangle) object with new coordinates is assigned to the Rect property. Then save the updated PDF using [Document](https://apireference.aspose.com/pdf/net/aspose.pdf/document) object's [Save](https://apireference.aspose.com/net/pdf/aspose.pdf/document/methods/save) method.

The following code snippet shows you how to move a form field to a new location in a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-MoveFormField-MoveFormField.cs" >}}
## **Preserve Extended Rights when Working with Forms**
When manipulating a PDF form that has extended features enabled, there is a chance that these rights are lost. To preserve extended rights, it is recommended that you use the incremental approach when dealing with such documents: # Open the source file in a Stream object (with read/write file access).

1. Perform any required operation.
1. Call the Document.Save(..) method with no argument.
   This saves the updated document in the original Stream.

The following code snippet shows how to access the PDF form and save it back on the system without losing the extended rights.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-PreserveRights-PreserveRights.cs" >}}
### **Preserving Rights when Using the Form Class**
When using the [Form](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/form) class in the Aspose.PDF.Facades namespace to populate PDF forms, use the same output path or stream as the input path or stream.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-PreserveRights-PreserveRightsUsingFormClass.cs" >}}
