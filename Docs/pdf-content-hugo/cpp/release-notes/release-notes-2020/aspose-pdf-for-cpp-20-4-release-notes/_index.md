---
title: Aspose.PDF for CPP 20.4 Release Notes
type: docs
weight: 10
url: /cpp/aspose-pdf-for-cpp-20-4-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PDF for C++ 20.4.

{{% /alert %}} 

This new version of Aspose.PDF for C++ has codebase of Aspose.PDF for .NET 20.4 and includes all the improvements in terms of bug fixes. We have also included:

- Support for Converting PDF to PowerPoint PPTX format
- Support for TIFF images - The API now supports TIFF images based on the support in asposecpplib (CodePorting.Native.Cs2Cpp.API) by Aspose.Words API
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFCPP-1187|Memory leaks in annotation classes [PDF]|Bug|
|PDFCPP-1194|Memory leaks in [Aspose.Pdf.Engine.CommonData.Text]|Bug|
|PDFCPP-1203|Memory leaks in Aspose.Svg|Bug|
|PDFCPP-1204|Memory leaks in Aspose.Pdf [XFormCollection <-> XForm]|Bug|
|PDFCPP-1205|Memory leaks in Aspose.Doc project [XslFoProperties <->XmlWordElement]|Bug|
|PDFCPP-1209|Memory leaks in Aspose.Doc project [other leaks]|Bug|
|PDFCPP-1213|Memory leaks in Aspose.Float2Fixed|Bug|
|PDFCPP-1217|Aspose Float2Fixed Memory leak with FONode::parent and child classes|Bug|
|PDFCPP-1223|template keyword for gcc compiler|Bug|
|PDFCPP-1230|Aspose Float2Fixed Memory leaks [classes FOText, BasicLink] [FONode]|Bug|
|PDFCPP-1231|Aspose Float2Fixed Memory leaks [classes TableBody, TableCell, Block] [FONode]|Bug|
|PDFCPP-1232|Aspose Float2Fixed Memory leaks [classes ListBlock, ListItem]|Bug|
|PDFCPP-1239|Fix XslCompiledTransform|Bug|
|PDFCPP-1240|Aspose Float2Fixed Memory leaks [SimplePageMaster::*::siblings]|Bug|
|PDFCPP-1241|Issue with converting to DOC format on Linux|Bug|
|PDFCPP-1243|implement some System.Linq.Enumerable methods|Bug|
|PDFCPP-1247|Fix SortedList class|Bug|
|PDFCPP-1255|Fix regression in TiffMakerTest|Bug|
|PDFCPP-1104|Implement progress handler while performing conversion|Bug|
## **Public API and Backward Incompatible Changes**
### **Added APIs**
- Property Aspose.Pdf.Cell.BackgroundImage
### **Removed APIs**
- Class Aspose.Pdf.LatexLoadOptions is renamed to Aspose.Pdf.TeXLoadOptions (Aspose.Pdf.LatexLoadOptions is declared obsolete)
- Class Aspose.Pdf.LaTeXSaveOptions is renamed to Aspose.Pdf.TeXSaveOptions (Aspose.Pdf.LaTeXSaveOptions is declared obsolete)
- Class Aspose.Pdf.LatexFragment    is renamed to Aspose.Pdf.TeXFragment    (Aspose.Pdf.LatexFragment is declared obsolete)
