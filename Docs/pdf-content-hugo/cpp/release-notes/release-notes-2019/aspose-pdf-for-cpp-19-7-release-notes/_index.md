---
title: Aspose.PDF for CPP 19.7 Release Notes
type: docs
weight: 60
url: /cpp/aspose-pdf-for-cpp-19-7-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for C++ 19.7](https://www.nuget.org/packages/Aspose.PDF.CPP/19.7.0)

{{% /alert %}} 
### **Improvements and Changes**
New version of Aspose.PDF for C++ has a codebase of Aspose.PDF for .Net 19.7.
### **Changes in Globalization Subsystem and Connected Classes**
- Totally rewritten System.Convert, System.DateTime, System.TimeSpan classes (corresponding to dotNET)
- Implemented System.DateTimeOffset class
- Extended System.TimeZoneInfo class
- Totally rewritten CultureInfo, NumberFormatInfo, DateTimeFormatInfo, RegionInfo classes
- Generated tables with cultures and regions data used in Windows 10 (these tables are used in linux by default)
- Implemented the caching of CultureInfo and RegionInfo objects
- Totally rewritten numbers, DateTime and TimeSpan values formatting and parsing
- Fixed issues in System.Decimal
- Totally rewritten String::Format implementation
- Introduced System.Globalization.CharUnicodeInfo class
- Extended System.Globalization.CompareInfo, System.Globalization.StringInfo classes
- Implemented System.Globalization.IdnMapping class
- Partially implemented SortKey and SortMapping classes
- Introduced System.IFormattable interface
- Introduced SpinLock and OptionalSpinLock classes
- All culture classes are thread safe
### **Minor Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFCPP-608|Improved performance of Blender and some other classes|Bug|
|PDFCPP-967|Fixed memory leaks in Doc, Floar2Fixed, Fixed2Float|Bug|
|PDFCPP-992|SEH exception in PCL6BinaryCommandsReaderTest|Bug|
|PDFCPP-993|Abnormal breaks in Pcl2ApsRectangularAreaFillTest|Bug|
|PDFCPP-998|RegressionTests_v6_1|Bug|
|PDFCPP-999|RegressionTests_v6_3|Bug|
|PDFCPP-1000|RegressionTests_v10_1|Bug|
|PDFCPP-1002|Abort error in Thread.Join|Bug|
|PDFCPP-1004|Fix CsToCppPorter IntPtr with initializer|Bug|
|PDFCPP-1005|Support of PixelFormat::Format32bppPArgb|Bug|
### **API Reference changes in Aspose.PDF for C++ 19.7**
Full API reference is available on [API Reference](https://apireference.aspose.com/cpp/pdf/) Page of Aspose.PDF for C++.
#### **Added APIs:**
Property Aspose.Pdf.Text.TextEditOptions.ReplacementFont
Enumeration member Aspose.Pdf.Text.TextEditOptions.NoCharacterAction.UseCustomReplacementFont
Property Aspose.Pdf.PptxSaveOptions.ImageResolution
Property Aspose.Pdf.HtmlSaveOptions.ProcessingBatchSize
Property Aspose.Pdf.HtmlSaveOptions.SimpleTextboxModeGrouping
Property Aspose.Pdf.HtmlSaveOptions.ExcludeFontNameList
Property Aspose.Pdf.HtmlLoadOptions.IsEmbedFonts
Method Aspose.Pdf.Document.Convert(System.IO.Stream,Aspose.Pdf.PdfFormat,Aspose.Pdf.ConvertErrorAction,Aspose.Pdf.ConvertTransparencyAction)
Enumeration member Aspose.Pdf.Facades.FieldType.Numeric
Enumeration member Aspose.Pdf.Facades.FieldType.DateTime
Method Aspose.Pdf.XmpValue.ToStructure
Method Aspose.Pdf.XmpValue.ToField
Method Aspose.Pdf.XmpValue.ToNamedValue
Method Aspose.Pdf.XmpValue.ToNamedValues
Property Aspose.Pdf.Forms.Form.SignaturesExist
Property Aspose.Pdf.Forms.Form.SignaturesAppendOnly
Class Aspose.Pdf.XmpField
Property Aspose.Pdf.XmpField.Empty
Property Aspose.Pdf.XmpField.Lang
Property Aspose.Pdf.XmpField.Prefix
Property Aspose.Pdf.XmpField.NamespaceUri
Property Aspose.Pdf.XmpField.LocalName
Property Aspose.Pdf.XmpField.Name
Property Aspose.Pdf.XmpField.Value
Property Aspose.Pdf.XmpField.FieldType
Property Aspose.Pdf.XmpField.IsEmpty
Method Aspose.Pdf.XmpField.ToStructure
Method Aspose.Pdf.XmpField.ToArray
Enumeration Aspose.Pdf.XmpFieldType
Enumeration member Aspose.Pdf.XmpFieldType.Struct
Enumeration member Aspose.Pdf.XmpFieldType.Array
Enumeration member Aspose.Pdf.XmpFieldType.Property
Enumeration member Aspose.Pdf.XmpFieldType.Packet
Enumeration member Aspose.Pdf.XmpFieldType.Unknown
