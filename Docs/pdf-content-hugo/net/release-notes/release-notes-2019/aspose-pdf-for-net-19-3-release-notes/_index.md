---
title: Aspose.PDF for .NET 19.3 Release Notes
type: docs
weight: 100
url: /net/aspose-pdf-for-net-19-3-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 19.3](https://www.nuget.org/packages/Aspose.PDF/19.3.0)

{{% /alert %}} 

**Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-45929|PDF/UA: Support note structure element for tagged PDF|New Feature|
|PDFNET-45996|Add a field to the ScreenAnnotation class that provides access to the annotation resource|New Feature|
|PDFNET-37164 |Does Aspose.Pdf support signing PDF with X509 certificate|Enhancement|
|PDFNET-41622 |Signing PDF document with X509 string without password|Enhancement|
|PDFNET-45962|Implement FirstLineIndent property for TextFragment in new generator|Enhancement|
|PDFNET-43989|Support to move SVG image to next page if it overflows|Enhancement|
|PDFNET-29443|Read pfx file from local key store and sign the document|Enhancement|
|PDFNET-35677|Adjust digital signature font size|Enhancement|
|PDFNET-29354|Provide support for signing PDF file from KeyStore|Enhancement|
|PDFNET-45811|An exception raises while removing a stamp|Bug|
|PDFNET-45990|The contact field in the signature rectangle is missing|Bug|
|PDFNET-43442|Bookmarks aren't visible with Adobe Acrobat Reader after open/save the scanned PDF document|Bug|
|PDFNET-45225|Unable to create HTML fragment with custom font|Bug|
|PDFNET-45880|StrikeOut annotations disappear after flattening|Bug|
|PDFNET-44338|IndexOutOfBounds exception while working with form|Bug|
|PDFNET-42978|Setting security on the PDF generates a corrupt PDF|Bug|
|PDFNET-37193|Facades PdfFileSecurity SetPrivilege distorts document when no password is set|Bug|
|PDFNET-40217|Text Replace - when two words in the same line are edited the second manipulation is shifted|Bug|
|PDFNET-41285|StackOverflowError when manipulating PDF document|Bug|
|PDFNET-38577|NullReferenceException occurs when trying to attached XML file with PDF|Bug|
|PDFNET-38759|Text Replace - Word wrap is not working properly|Bug|
|PDFNET-39970|PDF gets corrupted after sencryption|Bug|
|PDFNET-41314|Exception when trying to get signature names|Bug|
|PDFNET-41576|Updating PDF security corrupts the document|Bug|
|PDFNET-45968|TextEditOptions.FontReplace.RemoveUnusedFonts slows down document save|Bug|
|PDFNET-45920|HTML header and footer not properly aligned in the output PDF|Bug|
|PDFNET-45971|HTML - PDF - on save hangs|Bug|
|PDFNET-39980|Setting document privileges corrupt the resultant document|Bug|
|PDFNET-38818|Position property of TextFragment is not being honored|Bug|
|PDFNET-38764|Text is not being replaced completely|Bug|
|PDFNET-45049|Missing characters when saving PDF as HTML|Bug|
|PDFNET-45924|PDF/UA: Validator doesn't recognize warning "Possibly inappropriate use ..." for text inline structure elements|Bug|
### **Public API changes in Aspose.PDF for .NET 19.3**
-----
### **Added APIs:**
Property Aspose.Pdf.Annotations.RenditionAction.Rendition
P:Aspose.Pdf.Annotations.RenditionAction.RenditionOperation
Property Aspose.Pdf.Annotations.RenditionAction.JavaScript
Property Aspose.Pdf.Forms.Signature.CustomAppearance
Class Aspose.Pdf.Forms.SignatureCustomAppearance
Constructor Aspose.Pdf.Forms.SignatureCustomAppearance
Property Aspose.Pdf.Forms.SignatureCustomAppearance.FontFamilyName
Property Aspose.Pdf.Forms.SignatureCustomAppearance.FontSize
Property Aspose.Pdf.Forms.SignatureCustomAppearance.ShowContactInfo
Property Aspose.Pdf.Forms.SignatureCustomAppearance.ShowReason
Property Aspose.Pdf.Forms.SignatureCustomAppearance.ShowLocation
Property Aspose.Pdf.Forms.SignatureCustomAppearance.ContactInfoLabel
Property Aspose.Pdf.Forms.SignatureCustomAppearance.ReasonLabel
Property Aspose.Pdf.Forms.SignatureCustomAppearance.LocationLabel
Property Aspose.Pdf.Forms.SignatureCustomAppearance.DigitalSignedLabel
Property Aspose.Pdf.Forms.SignatureCustomAppearance.DateSignedAtLabel
Property Aspose.Pdf.Forms.SignatureCustomAppearance.DateTimeLocalFormat
Property Aspose.Pdf.Forms.SignatureCustomAppearance.DateTimeFormat
Property Aspose.Pdf.Forms.SignatureCustomAppearance.Culture
Property Aspose.Pdf.LogicalStructure.StructureElement.ID
Method Aspose.Pdf.LogicalStructure.StructureElement.GenerateId
Method Aspose.Pdf.LogicalStructure.StructureElement.SetId(System.String)
Method Aspose.Pdf.LogicalStructure.StructureElement.ClearId
Property Aspose.Pdf.OutlineItemCollection.HasNext
Property Aspose.Pdf.Text.TextFormattingOptions.FirstLineIndent
Property Aspose.Pdf.Text.TextParagraph.FirstLineIndent
Class Aspose.Pdf.Annotations.MediaClip
Class Aspose.Pdf.Annotations.MediaClipData
Property Aspose.Pdf.Annotations.MediaClipData.Data
Class Aspose.Pdf.Annotations.MediaClipSection
Class Aspose.Pdf.Annotations.MediaRendition
Property Aspose.Pdf.Annotations.MediaRendition.MediaClip
Class Aspose.Pdf.Annotations.Rendition
Property Aspose.Pdf.Annotations.Rendition.Name
Property Aspose.Pdf.Annotations.Rendition.RenditionType
Enumeration Aspose.Pdf.Annotations.RenditionOperation
Enumeration member Aspose.Pdf.Annotations.RenditionOperation.PlayStop
Enumeration member Aspose.Pdf.Annotations.RenditionOperation.Stop
Enumeration member Aspose.Pdf.Annotations.RenditionOperation.Pause
Enumeration member Aspose.Pdf.Annotations.RenditionOperation.Resume
Enumeration member Aspose.Pdf.Annotations.RenditionOperation.PlayResume
Enumeration member Aspose.Pdf.Annotations.RenditionOperation.Undefined
Enumeration Aspose.Pdf.Annotations.RenditionType
Enumeration member Aspose.Pdf.Annotations.RenditionType.Media
Enumeration member Aspose.Pdf.Annotations.RenditionType.Selector
Enumeration member Aspose.Pdf.Annotations.RenditionType.Undefined
Class Aspose.Pdf.Annotations.SelectorRendition
Property Aspose.Pdf.Annotations.SelectorRendition.Renditions
