---
title: Aspose.PDF for CPP 19.11 Release Notes
type: docs
weight: 20
url: /cpp/aspose-pdf-for-cpp-19-11-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PDF for C++ 19.11.

{{% /alert %}} 
# **Improvements and Changes**
1. This new version of Aspose.PDF for C++ has codebase of Aspose.PDF for .NET 19.11.
1. Headers have been moved into Aspose.PDF.Cpp folder to avoid conflicts while using Aspose.PDF for C++ 19.11 together with other Aspose for C++ products (e.g. Aspose.Words for C++ 19.11).
1. Conversion from/to .xps format has been added.
1. Win32 platform is supported.
### **API Reference changes in Aspose.PDF for C++ 19.11**
Full API reference is available on [API Reference](https://apireference.aspose.com/cpp/pdf/) Page of Aspose.PDF for C++.
#### **Added APIs**
- Class Aspose.Pdf.Sanitization.SanitizationException
- Constructor Aspose.Pdf.Sanitization.SanitizationException
- Constructor Aspose.Pdf.Sanitization.SanitizationException(System.String)
- Constructor Aspose.Pdf.Sanitization.SanitizationException(System.String,System.Exception)
- Constructor Aspose.Pdf.Sanitization.SanitizationException(System.Exception)
- Property Aspose.Pdf.HtmlSaveOptions.PageMarginIfAny
- Class Aspose.Pdf.SaveOptions.MarginInfo
- Constructor Aspose.Pdf.SaveOptions.MarginInfo
- Constructor Aspose.Pdf.SaveOptions.MarginInfo(Aspose.Pdf.SaveOptions.MarginPartStyle)
- Property Aspose.Pdf.SaveOptions.MarginInfo.TopMarginIfAny
- Property Aspose.Pdf.SaveOptions.MarginInfo.RightMarginIfAny
- Property Aspose.Pdf.SaveOptions.MarginInfo.BottomMarginIfAny
- Property Aspose.Pdf.SaveOptions.MarginInfo.LeftMarginIfAny
- Class Aspose.Pdf.SaveOptions.MarginPartStyle
- Constructor Aspose.Pdf.SaveOptions.MarginPartStyle(System.Int32)
- Constructor Aspose.Pdf.SaveOptions.MarginPartStyle(System.Boolean)
- Property Aspose.Pdf.SaveOptions.MarginPartStyle.IsAuto
- Property Aspose.Pdf.SaveOptions.MarginPartStyle.ValueInPoints
- Property Aspose.Pdf.HtmlSaveOptions.BatchSize
- Class Aspose.Pdf.IPageSetOptions
- Property Aspose.Pdf.IPageSetOptions.ExplicitListOfSavedPages
- Class Aspose.Pdf.IPipelineOptions
- Property Aspose.Pdf.IPipelineOptions.BatchSize
- Property Aspose.Pdf.XpsLoadOptions.BatchSize
- Property Aspose.Pdf.XpsSaveOptions.BatchSize
#### **Removed APIs**
- Property Aspose.Pdf.HtmlSaveOptions.ProcessingBatchSize (renamed to Property Aspose.Pdf.HtmlSaveOptions.BatchSize)
