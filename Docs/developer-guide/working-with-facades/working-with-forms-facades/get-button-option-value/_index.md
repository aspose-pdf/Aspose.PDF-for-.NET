---
title: Get Button Option Value
type: docs
weight: 30
url: /net/get-button-option-value/
---

## **Get Button Option Values from an Existing PDF File**
The radion buttons provide a way to show different options. The **From** class allows you to get all the button option values for a particular radio button. You can get these values using **GetButtonOptionValues** method. This method requires the name of the radio button as input parameter and returns a Hashtable. You can iterate through this Hashtable to get the option values. The following code snippet shows you how to get button option values from existing PDF file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Forms-GetButtonOptionValue-GetButtonOptionValue.cs" >}}
## **Get Current Button Option Value from an Existing PDF File**
Radio buttons provide a way to set option values, however one of them can be selected at a time. If you want to get the currently selected option value then you can use **GetButtonOptionCurrentValue** method. **Form** class provides this method. The **GetButtonOptionCurrentValue** method requires radio button name as input parameter and returns the value as string. The following code snippet shows you how to get current button option value from an existing PDF file. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Forms-GetButtonOptionValue-GetCurrentValue.cs" >}}
