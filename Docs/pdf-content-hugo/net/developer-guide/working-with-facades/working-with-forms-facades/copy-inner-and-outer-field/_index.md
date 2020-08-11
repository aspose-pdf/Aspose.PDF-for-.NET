---
title: Copy Inner and Outer Field
type: docs
weight: 50
url: /net/copy-inner-and-outer-field/
---

## **Copy Inner Field in an Existing PDF File**
**CopyInnerField** method allows you to copy a field in the same file, at the same coordinates, on the specified page. This method requires the field name which you want to copy, the new field name, and the page number at which the field needs to be copied. **FormEditor** class provides this method. The following code snippet shows you how to copy the field at the same location in the same file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Forms-CopyInnerField-CopyInnerField.cs" >}}
## **Copy Outer Field in an Existing PDF File**
**CopyOuterField** method allows you to copy a form field from an external PDF file and then add it to the input PDF file at the same location and the specified page number. This method requires the PDF file from which the field needs to be copied, the field name, and the page number at which the field needs to be copied. This method is provided by **FormEditor** class.The following code snippet shows you how to copy a field from an external PDF file. 



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Forms-CopyOuterField-CopyOuterField.cs" >}}
