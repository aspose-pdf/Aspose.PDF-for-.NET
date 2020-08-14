---
title: Get and Set Form Field
type: docs
weight: 20
url: /net/get-and-set-form-field/
---

## **Get Values from all the Fields of PDF Document**
To get values from all the fields in a PDF document, you need to navigate through all the form fields and then get the value using the Value property. Get each field from the Form collection, in the base field type called Field and access its Value property.

The following code snippets show how to get the values of all the fields from a PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-GetValuesFromAllFields-GetValuesFromAllFields.cs" >}}
### **Get/Set FieldLimit**
The FormEditor class SetFieldLimit("textbox1", 20) method allows you to set a field limit, the maximum number of characters that can be entered into a field.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-SetFieldLimit-SetFieldLimit.cs" >}}

Similarly, Aspose.PDF has a method that gets the field limit using the DOM approach. The following code snippet shows the steps.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-SetFieldLimit-GetMaxFieldLimit.cs" >}}



You can also get the same value using the **Aspose.PDF.Facades** namespace using the following code snippet.



{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-SetFieldLimit-GetMaxFieldLimitUsingFacades.cs" >}}
## **Get Value from an Individual Field of PDF Document**
The form field's Value property allows you to get the value of a particular field. To get the value, get the form field from the Document object's Form collection. This example selects a [TextBoxField](https://apireference.aspose.com/net/pdf/aspose.pdf.forms/textboxfield) and retrieves its value using the Value property.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-GetValueFromField-GetValueFromField.cs" >}}

To get the submit button's URL, use the following lines of code.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-GetValueFromField-GetSubmitButtonURL.cs" >}}
## **Get Form Fields from a Specific Region of PDF File**
Sometimes, you might know where in a document a form field is, but not have it's name. For example, if all you have to go from is a schematic of a printed form. With Aspose.PDF for .NET, this is not a problem. You can find out which fields are in a given region of a PDF file. To get form fields from a specific region of a PDF file:

1. Open the PDF file using the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) object.
1. Get the form from the document's Forms collection.
1. Specify the rectangular region and pass it to the Form object's GetFieldsInRect method.
   A Fields collection is returned.
1. Use this to manipulate the fields.

The following code snippet shows how to get form fields in a specific rectangular region of a PDF file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-GetFieldsFromRegion-GetFieldsFromRegion.cs" >}}
## **Set Form Field Font Other Than the 14 Core PDF Fonts**
Form fields in Adobe PDF files can be configured to use specific default fonts. In the early versions of Aspose.PDF, only the 14 default fonts were supported. Later releases allowed developers to apply any font. To set and update the default font used for form fields, use the [DefaultAppearance(Font font, double size, Color color)](http://www.aspose.com/api/net/pdf/aspose.pdf.interactivefeatures/defaultappearance) class. This class can be found under the Aspose.PDF.InteractiveFeatures namespace. To use this object, use the Field class DefaultAppearance property.

The following code snippet shows how to set the default font for PDF form fields.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-FormFieldFont14-FormFieldFont14.cs" >}}
## **Retrieve RadioHoriz Property for RadioButton Field**
The RadioHoriz property is required to control how radio buttons are added:

- if RadioHoriz is true, items are added horizontally,
- if it is false they are added vertically.

This property is specific to the [FormEditor](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/formeditor) class and defines the most used scenarios for creating radio buttons. Usually it does not make any sense to read the RadioHoriz property for radio button field and you can access RadioButtonField sub-items and read their coordinates, instead of trying to read the RadioHoriz property.

The following example illustrates the RadioHoriz property's behavior, shows how to create radio button items with arbitrary positions and how to read these positions.
### **Create a New Document and Add Radio Button with 3 Items (DOM Approach)**
{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-CreateDoc-CreateDoc.cs" >}}
### **Adding Horizontally and Vertically Laid-out Radio Buttons with FormEditor**
{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-HorizontallyAndVerticallyRadioButtons-HorizontallyAndVerticallyRadioButtons.cs" >}}
### **How to Get RadioButton Item Coordinates**
{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-GetCoordinates-GetCoordinates.cs" >}}
## **Set JavaScript on Form Field**
Aspose.PDF for .NET allows developers to restrict form fields so that only numeric values can be entered into them. To accomplish this requirement, the OnModifyCharacter and OnFormat properties have been added to Field.Actions.

To add validation of user entry, the AFNumber_Keystroke and AFNumber_Format JavaScript functions can be used. The following code snippets show how.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Forms-SetJavaScript-SetJavaScript.cs" >}}
## **Retrieve Form Fields in Tab Order**
Sometimes we need to change the order of form fields while proceeding with our PDF document. By default when you iterate through the form fields, the fields are returned in the order in which they were created. In order to retrieve form fields in tab orders, Aspose.PDF offers the following two properties:

1. **Field.TabOrder** - the tab order of the field which allows to set or get tab order of the field on the page.
2. **Page.FieldsInTabOrder** - returns a list of fields in the tab order

The following code snippet shows how to use this feature.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Forms-RetrieveFormFieldInTabOrder-RetrieveFormFieldInTabOrder.cs" >}}
