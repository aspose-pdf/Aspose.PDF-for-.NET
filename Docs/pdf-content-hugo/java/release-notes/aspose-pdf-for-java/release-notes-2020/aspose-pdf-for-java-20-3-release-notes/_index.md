---
title: Aspose.PDF for Java 20.3 Release Notes
type: docs
weight: 20
url: /java/aspose-pdf-for-java-20-3-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.PDF for Java 20.3 release notes.

{{% /alert %}} 
## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-39126|PDFJAVA-39126 Add Markdown Documentation File (*.md) file format support|New Feature|
|PDFJAVA-39247|Track the progress of converting a PDF to PowerPoint presentation|New Feature|
|PDFJAVA-38605|Improve API reference description|Enhancement|
|PDFJAVA-39154|PDF to JPG - Fonts are not rendered correctly in output JPG|Bug|
|PDFJAVA-37884|TIFF to PDF - output PDF has image with wrong color pattern|Bug|
## **Public API and Backward Incompatible Changes**
**New Feature - PDFJAVA-39126 Add Markdown Documentation File (*.md) file format support**

- Implemented support for loading MD format:
- Added constant: com.aspose.pdf.LoadFormat#MD
- Added class: com.aspose.pdf.MdLoadOptions

**Usage**

{{< highlight java >}}

 Document doc = new_Document("input.md", new MdLoadOptions());

doc.save("outFileName.pdf");

{{< /highlight >}}

**New Feature - PDFJAVA-39247 Track the progress of converting a PDF to PowerPoint presentation**

- Added method: com.aspose.pdf.PptxSaveOptions#setCustomProgressHandler.

**Usage**

{{< highlight java >}}

 PptxSaveOptions saveOptions = new PptxSaveOptions();

saveOptions.setCustomProgressHandler( new UnifiedSaveOptions.ConversionProgressEventHandler() {

@Override

public void invoke(UnifiedSaveOptions.ProgressEventHandlerInfo eventInfo) {

//example how to handle progress events:

                    System.out.println(ProgressEventType.getName(ProgressEventType.class,eventInfo.EventType) +

                "\t" +eventInfo.Value + " from: \t" +eventInfo.MaxValue);

                }

            });

Document doc = new Document(inFile);

doc.save(outFileName, saveOptions);

{{< /highlight >}}
### **Public API Changes**
**New Classes Added**

- com.aspose.pdf.CustomExplicitDestination
- com.aspose.pdf.**MdLoadOptions**

**Added New Field**

- com.aspose.pdf.LoadFormat.MD

**Added New Methods**

- com.aspose.pdf.**PclLoadOptions**.getBatchSize()
- com.aspose.pdf.**PclLoadOptions**.setBatchSize(int)
- com.aspose.pdf.**PptxSaveOptions**.getCustomProgressHandler()
- com.aspose.pdf.**PptxSaveOptions**.setCustomProgressHandler(ConversionProgressEventHandler)

**Field Name Renamed**

- com.aspose.pdf.**ProgressEventType**.SourcePageAnalized -> com.aspose.pdf.**ProgressEventType**.SourcePageAnalysed
