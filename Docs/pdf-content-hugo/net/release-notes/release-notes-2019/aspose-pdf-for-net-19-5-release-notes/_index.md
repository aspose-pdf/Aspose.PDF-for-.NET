---
title: Aspose.PDF for .NET 19.5 Release Notes
type: docs
weight: 80
url: /net/aspose-pdf-for-net-19-5-release-notes/
---



{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 19.5](https://www.nuget.org/packages/Aspose.Pdf/19.5.0)

{{% /alert %}} 

**Improvements and Changes** 

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-45991|The customizing of Digitally Signed by: field in the signed PDF output|New Feature|
|PDFNET-45593|Generate PDF/UA compliant PDF|New Feature|
|PDFNET-38011|Implement Getter for BackgroundColor property|Enhancement|
|PDFNET-46138|The href attribute doesn't support linking to a specific element|Enhancement|
|PDFNET-45973|Hide the spanned cell border if broken to another row|Enhancement|
|PDFNET-46111|Is the HTML XSS safe?|Bug|
|PDFNET-41362|PDF to HTML: Incorrect print preview and print of output HTML in Chrome|Bug|
|PDFNET-45707|PDF to XPS - an empty argument error occurred in the console and incorrect output|Bug|
|PDFNET-46175|Some headings are duplicated in the output PDF|Bug|
|PDFNET-45980|An exception raises while saving to HTML document|Bug|
|PDFNET-46150|An exception raises while extracting bookmarks|Bug|
|PDFNET-46157|The text substitution doesn't work correctly|Bug|
|PDFNET-45181|Unable to load PDF document|Bug|
|PDFNET-46332|Words are splitting over two lines when adding HTML Content using HtmlFragment|Bug|
|PDFNET-46134|PDF header|Bug|
|PDFNET-45744|NullReferenceException when resize and concatenate documents|Bug|
|PDFNET-44205|Aspose.Pdf 18.2: Converting particular PDF to PDF/X3 or PDF/X1A do not pass validation|Bug|
|PDFNET-43161|Images have been extracted as blank/empty|Bug|
|PDFNET-43674|PDF to JPG - an argument error occurred|Bug|
|PDFNET-43307|PDF to PNG - the null pointer error occurred|Bug|
|PDFNET-41141|Exception when trying to replace the text|Bug|
|PDFNET-41401|Text cut off when using custom font|Bug|
|PDFNET-41322|Unable to create searchable PDF|Bug|
|PDFNET-40631|pdfFileEditor.Concatenate fails with large files|Bug|
|PDFNET-38022|Text Replacement issue: old background color remains intact|Bug|
|PDFNET-41523|Incorrect Text position|Bug|
|PDFNET-41464|Hyperlink color is not changing|Bug|
|PDFNET-38023|Text Replacement issue: Underline font style does not apply to replaced text properly|Bug|
|PDFNET-41651|HTML to PDF conversion hangs|Bug|
|PDFNET-41648|HTML to PDF: Conversion hangs|Bug|
|PDFNET-46317|Saving a newly created document in DOCX format.|Bug|
|PDFNET-42410|PDF to PDFA1b: resultant document is not PDFA compliant|Bug|
|PDFNET-46182|API is consuming a lot of memory causing Application to crash|Bug|
### **Public API changes in Aspose.PDF for .NET 19.5**
-----
### **Added APIs:**
Property Aspose.Pdf.HtmlFragment.IsBreakWords
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

