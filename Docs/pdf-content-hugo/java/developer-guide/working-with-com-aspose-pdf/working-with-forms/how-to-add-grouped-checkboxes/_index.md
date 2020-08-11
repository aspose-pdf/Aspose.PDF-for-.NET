---
title: How to add Grouped CheckBoxes
type: docs
weight: 40
url: /java/how-to-add-grouped-checkboxes/
---



The [**Document**](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Document) class provides a collection named **Form** which helps you to manage form fields in a PDF document. The **RadioButtonField** provides the feature to add RadioButtons field to PDF document and in order to represent CheckBoxes, you may consider setting border style for RadioButtonField.

Once the RadioButtonField object is created, you need to add **RadioButtonOptionField** instances to RadioButtonField object and in order to set border style, you need to use **Style** property and set value from **BoxStyle** enumeration.

The **BoxStyle** enumeration supports following values.

|**Sr. #**|**BoxStyle**|
| :- | :- |
|1|Check|
|2|Circle|
|3|Cross|
|4|Diamond|
|5|Square|
|6|Star|
The following code snippets show how to create grouped CheckBoxes to a PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-forms-HowToAddGroupedCheckBoxes-.java" >}}



