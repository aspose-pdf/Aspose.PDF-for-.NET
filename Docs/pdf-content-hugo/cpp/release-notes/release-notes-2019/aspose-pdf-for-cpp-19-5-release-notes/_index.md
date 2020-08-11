---
title: Aspose.PDF for CPP 19.5 Release Notes
type: docs
weight: 80
url: /cpp/aspose-pdf-for-cpp-19-5-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for C++ 19.5](https://www.nuget.org/packages/Aspose.PDF.CPP/19.5.0)

{{% /alert %}} 
### **Improvements and Changes**
New version of Aspose.PDF for C++ has codebase of Aspose.PDF for .Net 19.5.

Saving PDF document into Office Open XML (docx) and SVG format has been implemented.

Code snippets for saving PDF document into doc, docx, svg formats were added.
### **Minor Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFCPP-896|Fix incorrect building of table's borders|Bug|
|PDFCPP-913|Memory Leaks in TaggedPdfStructure tests|Bug|
|PDFCPP-951|Memory leaks in Float2Fixed & Fixed2Float tests|Bug|
|PDFCPP-915|Merge fixes from SLIDES|Bug|
|PDFCPP-953|Fix saving document in docx format|Bug|
|PDFCPP-954|Fix XmlDocument::CreateAttribute with xml namespace|Bug|
|PDFCPP-956|Fix ApsUsingConverter.PdfToAps|Bug|
|PDFCPP-957|Extend CsToCppPorter with enum descriptions support|Bug|
|PDFCPP-959|Fix drawing empty path with customized pen|Bug|
|PDFCPP-960|Testing refactored doc(implement enumtostring), foundation|Bug|
Some bugs and issues in library have been fixed.
### **API Reference changes in Aspose.PDF for C++ 19.5**
Full API reference is available on API Reference Page of Aspose.PDF for C++.
#### **Added APIs:**
` `Property Aspose.Pdf.HtmlFragment.IsBreakWords
Class Aspose.Pdf.LogicalStructure.AnnotationElement
Property Aspose.Pdf.LogicalStructure.AnnotationElement.AlternateDescriptions
Method   Aspose.Pdf.LogicalStructure.Element.FindElements<T>(System.Boolean)
Property Aspose.Pdf.LogicalStructure.LinkElement.Hyperlink
Property Aspose.Pdf.LogicalStructure.LinkElement.StructureTextState
Method Aspose.Pdf.LogicalStructure.LinkElement.SetText(System.String)
Method Aspose.Pdf.LogicalStructure.StructureElement.ChangeParentElement(Aspose.Pdf.LogicalStructure.StructureElement)
Method Aspose.Pdf.LogicalStructure.TableElement.CreateTHead
Method Aspose.Pdf.LogicalStructure.TableElement.CreateTBody
Method Aspose.Pdf.LogicalStructure.TableElement.CreateTFoot
Class Aspose.Pdf.LogicalStructure.TableRowCollectionElement
Method Aspose.Pdf.LogicalStructure.TableRowCollectionElement.CreateTR
Method Aspose.Pdf.LogicalStructure.TableTRElement.CreateTH
Method Aspose.Pdf.LogicalStructure.TableTRElement.CreateTD
Method Aspose.Pdf.Metered.GetConsumptionCredit
Property Aspose.Pdf.OutlineCollection.VisibleCount
Property Aspose.Pdf.OutlineItemCollection.VisibleCount
Method Aspose.Pdf.Tagged.ITaggedContent.CreateTableTHeadElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateTableTBodyElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateTableTFootElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateTableTRElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateTableTHElement
Method Aspose.Pdf.Tagged.ITaggedContent.CreateTableTDElement
Property Aspose.Pdf.Text.TextSearchOptions.SearchForTextRelatedGraphics
Method Aspose.Pdf.XmpPdfAExtensionSchema.GetProperty(System.String)                                                      
Property Aspose.Pdf.XpsSaveOptions.SaveTransparentTexts


