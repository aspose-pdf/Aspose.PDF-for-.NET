---
title: Aspose.PDF for Java 18.6 Release Notes
type: docs
weight: 70
url: /java/aspose-pdf-for-java-18-6-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for Java 18.6](https://repository.aspose.com/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-pdf/18.6)

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-35922|Rotation angle of Text Character|Feature|
|PDFJAVA-34777|Support of PDF to XLSX|Feature|
|PDFJAVA-35410|PDF to HTML: problems with visibility and formatting symbols|Bug|
|PDFJAVA-37778|Incorrect string calculations result in cropped italic watermark|Bug|
|PDFJAVA-37798|Cannot retrieve size of all fonts|Bug|
|PDFJAVA-37217|Test aspose.pdf compatibility with JDK 9|Bug|
|PDFJAVA-36143|Some threads hangs for the latest Java for PDF|Bug|
|PDFJAVA-34359|Exception while instantiating license in Web application|Bug|
|PDFJAVA-35700|Exception when trying to run project through maven on MAC|Bug|
|PDFJAVA-36893|Exception trying to read bookmark from PDF file|Bug|
|PDFJAVA-35212|Creating a PDF from Text in Cloud Environment throws missing font error|Bug|
|PDFJAVA-33962|JVM memory consumption issue with table creation|Bug|
|PDFJAVA-36952|Formula based field is not working after converting from XFA to Standard|Bug|
|PDFJAVA-37484|PDF to PDF/A-2b - some labels get blurred|Bug|
|PDFJAVA-37786|` `RedactArea throws NPE in non-licensed mode|Bug|
|PDFJAVA-37674|RedactAnnotation does not work in non-licensed mode|Bug|
|PDFJAVA-37476|PDF to PDF/A-2b - the chart labels are rotated|Bug|
### **Public API Changes**
All descendants of com.aspose.pdf.Operator were moved into namespace com.aspose.pdf.operators. Thus 'new com.aspose.pdf.operators.GSave()' should be used, instead of 'new com.aspose.pdf.Operator.GSave()'.

Added new classes:
com.aspose.pdf.**DocumentElement** 
com.aspose.pdf.taggedpdf.**TaggedPdfChildElements** 
com.aspose.pdf.taggedpdf.**TaggedPdfDocumentElement** 
com.aspose.pdf.taggedpdf.**TaggedPdfElement** 
com.aspose.pdf.taggedpdf.**TaggedPdfParentTree** 
com.aspose.pdf.taggedpdf.**TaggedPdfTextElement**

Added new methods:
com.aspose.pdf.**ActionCollection**.isReadOnly()
com.aspose.pdf.ActionCollection.copyTo(PdfAction[],int)
com.aspose.pdf.ActionCollection.clear()
com.aspose.pdf.ActionCollection.contains(PdfAction)
com.aspose.pdf.ActionCollection.remove(PdfAction)

com.aspose.pdf.**AnnotationCollection**.isReadOnly()
com.aspose.pdf.AnnotationCollection.copyTo(Annotation[],int)
com.aspose.pdf.AnnotationCollection.clear()
com.aspose.pdf.AnnotationCollection.contains(Annotation)
com.aspose.pdf.AnnotationCollection.remove(Annotation)

com.aspose.pdf.**AnnotationSelector**.getSelected()
com.aspose.pdf.AnnotationSelector.AnnotationSelector()

com.aspose.pdf.**BaseOperatorCollection**.remove(Operator)
com.aspose.pdf.BaseOperatorCollection.contains(Operator)
com.aspose.pdf.BaseOperatorCollection.clear()

com.aspose.pdf.**CharInfoCollection**.isReadOnly()
com.aspose.pdf.CharInfoCollection.add(CharInfo)
com.aspose.pdf.CharInfoCollection.contains(CharInfo)

com.aspose.pdf.**DestinationCollection**.size()
com.aspose.pdf.DestinationCollection.isReadOnly()

com.aspose.pdf.**EmbeddedFileCollection**.isReadOnly()
com.aspose.pdf.EmbeddedFileCollection.copyTo(FileSpecification[],int)
com.aspose.pdf.EmbeddedFileCollection.remove(FileSpecification)
com.aspose.pdf.EmbeddedFileCollection.contains(FileSpecification)
com.aspose.pdf.EmbeddedFileCollection.clear()

com.aspose.pdf.facades.**PdfXmpMetadata**.containsKey(String)
com.aspose.pdf.facades.PdfXmpMetadata.tryGetValue(String,Object[])

com.aspose.pdf.**Field**.copyTo(Field[],int)
com.aspose.pdf.Field.add(WidgetAnnotation)
com.aspose.pdf.Field.clear()
com.aspose.pdf.Field.contains(WidgetAnnotation)
com.aspose.pdf.Field.copyTo(WidgetAnnotation[],int)
com.aspose.pdf.Field.isReadOnly()
com.aspose.pdf.Field.remove(WidgetAnnotation)

com.aspose.pdf.**FontCollection**.isReadOnly()
com.aspose.pdf.FontCollection.copyTo(Font[],int)
com.aspose.pdf.FontCollection.contains(Font)
com.aspose.pdf.FontCollection.remove(Font)

com.aspose.pdf.**Form**.copyTo(Field[],int)
com.aspose.pdf.Form.get(int)
com.aspose.pdf.Form.add(WidgetAnnotation)
com.aspose.pdf.Form.clear()
com.aspose.pdf.Form.contains(WidgetAnnotation)
com.aspose.pdf.Form.copyTo(WidgetAnnotation[],int)
com.aspose.pdf.Form.isReadOnly()
com.aspose.pdf.Form.remove(WidgetAnnotation)
com.aspose.pdf.Form.FlattenSettings.isHideButtons()
com.aspose.pdf.Form.FlattenSettings.setHideButtons(boolean)

com.aspose.pdf.**IDocument**.getTaggedPdfContent()

com.aspose.pdf.**ImagePlacementCollection**.isReadOnly()
com.aspose.pdf.ImagePlacementCollection.add(ImagePlacement)
com.aspose.pdf.ImagePlacementCollection.copyTo(ImagePlacement[],int)

com.aspose.pdf.**LightweightOperatorCollection**.remove(Operator)
com.aspose.pdf.LightweightOperatorCollection.contains(Operator)
com.aspose.pdf.LightweightOperatorCollection.clear()
com.aspose.pdf.LightweightOperatorCollection.isReadOnly()

com.aspose.pdf.**Metadata**.containsKey(String)
com.aspose.pdf.Metadata.tryGetValue(String,Object[])
com.aspose.pdf.Metadata.tryGetValue(String,XmpValue[])
com.aspose.pdf.Metadata.addItem(String,Object)

com.aspose.pdf.**PageCollection**.isReadOnly()
com.aspose.pdf.PageCollection.copyTo(Page[],int)
com.aspose.pdf.PageCollection.contains(Page)
com.aspose.pdf.PageCollection.remove(Page)

com.aspose.pdf.**Rows**.dispose()

com.aspose.pdf.**TableElementCollection**.isReadOnly()
com.aspose.pdf.TableElementCollection.addItem(ITableElement)
com.aspose.pdf.TableElementCollection.copyToTArray(T[],int)
com.aspose.pdf.TableElementCollection.clear()
com.aspose.pdf.TableElementCollection.containsItem(T)
com.aspose.pdf.TableElementCollection.removeItem(T)

com.aspose.pdf.text.**FontSourceCollection**.copyTo(FontSource[],int)
com.aspose.pdf.text.FontSourceCollection.contains(FontSource)
com.aspose.pdf.text.FontSourceCollection.remove(FontSource)

com.aspose.pdf.text.**FontSubstitutionCollection**.contains(FontSubstitution)
com.aspose.pdf.text.FontSubstitutionCollection.remove(FontSubstitution)

com.aspose.pdf.**TextFragmentCollection**.isReadOnly()
com.aspose.pdf.TextFragmentCollection.add(TextFragment)
com.aspose.pdf.TextFragmentCollection.copyTo(TextFragment[],int)
com.aspose.pdf.TextFragmentCollection.clear()
com.aspose.pdf.TextFragmentCollection.contains(TextFragment)
com.aspose.pdf.TextFragmentCollection.remove(TextFragment)

com.aspose.pdf.**TextMarkupAnnotation**.getMarkedText()
com.aspose.pdf.TextMarkupAnnotation.getMarkedTextFragments

com.aspose.pdf.**TextParagraphCollection**.isReadOnly()
com.aspose.pdf.TextParagraphCollection.add(TextParagraph)
com.aspose.pdf.TextParagraphCollection.copyTo(TextParagraph[],int)
com.aspose.pdf.TextParagraphCollection.clear()
com.aspose.pdf.TextParagraphCollection.contains(TextParagraph)
com.aspose.pdf.TextParagraphCollection.remove(TextParagraph)

com.aspose.pdf.**TextSegmentCollection**.copyTo(TextSegment[],int)
com.aspose.pdf.TextSegmentCollection.isReadOnly()
com.aspose.pdf.TextSegmentCollection.clear()
com.aspose.pdf.TextSegmentCollection.contains(TextSegment)
com.aspose.pdf.TextSegmentCollection.remove(TextSegment)

com.aspose.pdf.**TextState**.measureString(String,boolean)

com.aspose.pdf.**XFormCollection**.isReadOnly()
com.aspose.pdf.XFormCollection.copyTo(XForm[],int)
com.aspose.pdf.XFormCollection.clear()
com.aspose.pdf.XFormCollection.contains(XForm)
com.aspose.pdf.XFormCollection.remove(XForm)

com.aspose.pdf.**XImageCollection**.isReadOnly()
com.aspose.pdf.XImageCollection.copyTo(XImage[],int)
com.aspose.pdf.XImageCollection.clear()
com.aspose.pdf.XImageCollection.contains(XImage)
com.aspose.pdf.XImageCollection.remove(XImage)

Changed methods:
com.aspose.pdf.**DocumentInfo**.addItem(Object,Object) -> com.aspose.pdf.DocumentInfo.addItem(String,String)
com.aspose.pdf.DocumentInfo.removeItem(Object) -> com.aspose.pdf.DocumentInfo.remove(String)
com.aspose.pdf.DocumentInfo.get_Item(Object)> -> com.aspose.pdf.DocumentInfo.get_Item(String)
com.aspose.pdf.DocumentInfo.set_Item(Object,Object) -> com.aspose.pdf.DocumentInfo.set_Item(String,String)

com.aspose.pdf.facades.**PdfXmpMetadata**.add(int,Object) -> com.aspose.pdf.facades.PdfXmpMetadata.addItem(int,XmpValue)
com.aspose.pdf.facades.PdfXmpMetadata.addItem(Object,Object) -> com.aspose.pdf.facades.PdfXmpMetadata.addItem(String,Object)
com.aspose.pdf.facades.PdfXmpMetadata.contains(Object) -> com.aspose.pdf.facades.PdfXmpMetadata.contains(String)
com.aspose.pdf.facades.PdfXmpMetadata.removeItem(Object) -> com.aspose.pdf.facades.PdfXmpMetadata.removeItemByKey(String)
com.aspose.pdf.facades.PdfXmpMetadata.get_Item(Object) -> com.aspose.pdf.facades.PdfXmpMetadata.get_Item(String)
com.aspose.pdf.facades.PdfXmpMetadata.set_Item(Object,Object) -> com.aspose.pdf.facades.PdfXmpMetadata.set_Item(String,XmpValue)
com.aspose.pdf.facades.PdfXmpMetadata.setByDefaultMetadataProperties(int,Object) -> com.aspose.pdf.facades.PdfXmpMetadata.setByDefaultMetadataProperties(int,XmpValue)

com.aspose.pdf.**Metadata**.addItem(Object,Object) -> com.aspose.pdf.Metadata.addItem(String,XmpValue)
com.aspose.pdf.Metadata.add(String,XmpPdfAExtensionObject) -> com.aspose.pdf.Metadata.addItem(String,XmpPdfAExtensionObject)
com.aspose.pdf.Metadata.contains(Object) -> com.aspose.pdf.Metadata.contains(String)
com.aspose.pdf.Metadata.removeItem(Object) -> com.aspose.pdf.Metadata.removeItemByKey(String)
com.aspose.pdf.Metadata.get_Item(Object) -> com.aspose.pdf.Metadata.get_Item(String)
com.aspose.pdf.Metadata.set_Item(Object,Object) -> com.aspose.pdf.Metadata.set_Item(String,XmpValue)

Removed obsoleted methods:

com.aspose.pdf.**ArtifactCollection**.contains(Artifact)
com.aspose.pdf.**BaseOperatorCollection**.getSyncRoot()
com.aspose.pdf.**BaseOperatorCollection**.isSynchronized()

com.aspose.pdf.**LightweightOperatorCollection**.getSyncRoot()
com.aspose.pdf.**LightweightOperatorCollection**.isSynchronized()

Removed obsoleted class:

com.aspose.pdf.**Selector**
