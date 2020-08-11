---
title: Aspose.PDF for .NET 18.3 Release Notes
type: docs
weight: 100
url: /net/aspose-pdf-for-net-18-3-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 18.3](https://www.nuget.org/packages/Aspose.Pdf/18.3.0)

{{% /alert %}} 
### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-44151|Support embedding SVG into HTML when saving PDF with images|New Feature|
|PDFNET-44211|Adding support for repeating columns in Aspose.Pdf.Table|New Feature|
|PDFNET-37340|High memory utilization when trying to extract text from PDF file|Bug|
|PDFNET-38631|Adding Vector image in Aspose.Pdf.Cell throws exception|Bug|
|PDFNET-38750|PDF to PDFA2a: Converting PDF, generated from Aspose.Cells, to PDFA2a fails the compliance|Bug|
|PDFNET-38973|PDF to HTML - Resultant file is not correct|Bug|
|PDFNET-39319|Image to PDF - Memory is not release even process is completed|Bug|
|PDFNET-39345|PNG to PDF - Application hangs during conversion|Bug|
|PDFNET-39471|PDF to HTML - Local hyperlinks are ignored when converted to HTML|Bug|
|PDFNET-39720|Remove Unused Fonts from PDF File Very Slow|Bug|
|PDFNET-40112|PDF to PPTX - Pie Charts are not appearing properly|Bug|
|PDFNET-40138|PDF with hieroglyphs is converted to the HTML with corrupted symbols|Bug|
|PDFNET-41133|PDF to TIFF: Character spacing is increased|Bug|
|PDFNET-41988|Checkboxes in pdf document are not rendered correctly |Bug|
|PDFNET-41996|Link with external url in pdf document is not rendered as hyperlink|Bug|
|PDFNET-42343|PDF to PDFA: resultant PDFA is not claiming PDFA standard|Bug|
|PDFNET-42344|PDF to PDFA1b: resultant PDFA does not claim PDFA standard|Bug|
|PDFNET-42345|PDF to PDFA1b: resultant PDFA does not claim PDFA1b standard|Bug|
|PDFNET-42346|PDF to PDFA1b: resultant PDFA1b does not claim PDFA1b standard|Bug|
|PDFNET-42931|Table column rendering issues when using TableBroken.Vertical|Bug|
|PDFNET-43346|PDF to HTML - the hyperlink is missing on an image|Bug|
|PDFNET-43499|PDF document does not pass compliance test after signing it|Bug|
|PDFNET-43913|Incorrect column splits with the TableBroken property|Bug|
|PDFNET-44077|PDF to HTML: text and lines are misplaced|Bug|
|PDFNET-44162|PDF to PDF/A-1b - the output PDF does not pass compliance test|Bug|
|PDFNET-44168|PDF to PDF/A-1b - the output PDF does not pass compliance test|Bug|
|PDFNET-44196|Underlines are moved to the bottom when the text is spread to more lines.|Bug|
|PDFNET-44209|The TextFragment throws an exception while editing the text property|Bug|
|PDFNET-44219|An exception raises while visiting document with Absorber object|Bug|
### **Public API changes in Aspose.PDF for .NET 18.3**
### **Added APIs:**
-----
Method Aspose.Pdf.DestinationCollection.GetExplicitDestination(System.String,System.Boolean) 
Method Aspose.Pdf.Text.TextFragment.IsolateTextSegments(System.Int32,System.Int32) 
Property Aspose.Pdf.Text.TextFragmentAbsorber.Text 
Method Aspose.Pdf.Text.TextFragmentAbsorber.ApplyForAllFragments(Aspose.Pdf.Text.Font) 
Method Aspose.Pdf.Text.TextFragmentAbsorber.ApplyForAllFragments(System.Single) 
Method Aspose.Pdf.Text.TextFragmentAbsorber.ApplyForAllFragments(Aspose.Pdf.Text.Font,System.Single)
