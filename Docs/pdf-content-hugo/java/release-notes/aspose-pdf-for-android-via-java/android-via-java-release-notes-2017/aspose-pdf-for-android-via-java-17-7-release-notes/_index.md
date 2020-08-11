---
title: Aspose.Pdf for Android via Java 17.7 Release Notes
type: docs
weight: 20
url: /java/aspose-pdf-for-android-via-java-17-7-release-notes/
---

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFANDROID-474|Support Aspose for Pdf for Java.Android license mechanism|Enhancement|
|PDFANDROID-411|java.lang.OutOfMemoryError in com.aspose.pdf.Table.process|Exception|
|PDFANDROID-406|NullPointerException in the class at com.aspose.pdf.facades.PdfBookmarkEditor|Exception|
|PDFANDROID-409|OutOfMemoryError in the class com.aspose.pdf.devices.JpegDevice|Exception|
|PDFANDROID-412|OutOfMemoryError in the class com.aspose.pdf.TextState|Exception|
|PDFANDROID-380|Image disappears if we set RowSpan for the cell|Bug|
## **Public API Changes**
Changes in the following classes:
com.aspose.pdf.**BaseParagraph**

- Added method: com.aspose.pdf.BaseParagraph.deepClone

com.aspose.pdf.**Cell**

- Added method: com.aspose.pdf.Cell.getWidth

com.aspose.pdf.**ColumnAdjustment**

- Added method: com.aspose.pdf.ColumnAdjustment.Customized
- Added method: com.aspose.pdf.ColumnAdjustment.AutoFitToContent
- Added method: com.aspose.pdf.ColumnAdjustment.AutoFitToWindow

com.aspose.pdf.**Field**

- Added method: com.aspose.pdf.Field.setFitIntoRectangle(boolean)

com.aspose.pdf.**FontCollection**

- Added method: com.aspose.pdf.FontCollection.add(Font)

com.aspose.pdf.**HtmlLoadOptions**

- Added method: com.aspose.pdf.HtmlLoadOptions.CustomLoaderOfExternalResources

com.aspose.pdf.**OperatorCollection**

- Added method: com.aspose.pdf.OperatorCollection.isFastTextExtractionMode

com.aspose.pdf.**OperatorCollection**

- Added method: com.aspose.pdf.OperatorCollection.toList

com.aspose.pdf.**RadioButtonOptionField**

- Added method: com.aspose.pdf.RadioButtonOptionField.#ctor(Page,Rectangle)

com.aspose.pdf.**Table**

- Added method: com.aspose.pdf.Table.drawRoundedRectangle(GraphInfo,Point,Point,java.util.List<Operator>,double)
- Added method: com.aspose.pdf.Table.getWidth_
- Added method: com.aspose.pdf.Table.getBreakText
- Added method: com.aspose.pdf.Table.setBreakText(TextFragment)
- Added method: com.aspose.pdf.Table.isBordersIncluded
- Added method: com.aspose.pdf.Table.getColumnAdjustment
- Added method: com.aspose.pdf.Table.setColumnAdjustment(int)
- Added method: com.aspose.pdf.Table.getParentTable
- Added method: com.aspose.pdf.Table.setParentTable(Table)
- Renamed method: com.aspose.pdf.Table.isBroken(boolean)-> com.aspose.pdf.Table.setBroken(boolean)
- Changed constructor: com.aspose.pdf.TextBuilder.#ctor(Page,OperatorCollection)->com.aspose.pdf.TextBuilder.#ctor(Page,BaseOperatorCollection)

com.aspose.pdf.**TextFragment**

- Added method: com.aspose.pdf.TextFragment.deepClone

Removed internal classes:

- com.aspose.pdf.**InternalHelper**
- com.aspose.pdf.text.**InternalHelper**

Removed internal method:

- com.aspose.pdf.Color.fromRgb(com.aspose.ms.System.Drawing.Color)
- com.aspose.pdf.Color.fromRgbInternal(com.aspose.ms.System.Drawing.Color)
- com.aspose.pdf.devices.BmpDevice.process(Page,com.aspose.ms.System.Drawing.Graphics)
- com.aspose.pdf.facades.PdfExtractor.extractText(com.aspose.ms.System.Text.Encoding)
- com.aspose.pdf.TextState.#ctor(com.aspose.ms.System.Drawing.Color)
- com.aspose.pdf.TextState.#ctor(com.aspose.ms.System.Drawing.Color,double)
- com.aspose.pdf.Watermark.#ctor(com.aspose.ms.System.Drawing.Image,Rectangle)
- com.aspose.pdf.Watermark.#ctor(com.aspose.ms.System.Drawing.Image)
