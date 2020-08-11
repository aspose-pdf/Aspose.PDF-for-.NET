---
title: Aspose.Pdf for Java 17.12 Release Notes
type: docs
weight: 10
url: /java/aspose-pdf-for-java-17-12-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-36627|PDF Incremental updates when load pdf document from binary|Enhancement|
|PDFJAVA-34590|PDF to JPEG - Missing text in output JPG|Bug|
|PDFJAVA-35855|PDF to HTML: text misplaced in resultant HTML|Bug|
|PDFJAVA-35728|HTML to PDF - Conversion process hangs|Bug|
|PDFJAVA-36681|PDF to HTML - Text changes its position|Bug|
|PDFJAVA-37105|Text absorber retrieves the garbled text|Bug|
|PDFJAVA-36157|PDF to Doc: Text in the word document are wrapped one on another|Bug|
|PDFJAVA-35678|PDF to XPS: colored images changes to greyscale|Bug|
|PDFJAVA-36375|PDF to PDF/A - Text starts appearing overlapped|Bug|
|PDFJAVA-35030|Text replacement issue: Characters are missing in replaced text|Bug|
|PDFJAVA-36293|PDF to DOCX - text is overlapping in resultant file|Bug|
|PDFJAVA-36290|PDF to HTML: text shifted to left side|Bug|
|PDFJAVA-36966|PDF to Excel - Blank File is Generated|Bug|
|PDFJAVA-35284|Remove text underline in a PDF document|Bug|
|PDFJAVA-36629|Open PDF file from stream add annotation invalidates the signature|Bug|
|PDFJAVA-35106|PDF to PNG - invisible objects become visible|Bug|
### **Public API changes**
Changes in class **com.aspose.pdf.Annotation** 
new method:
com.aspose.pdf.Annotation.getPdfActions()

Changes in class **com.aspose.pdf.BaseParagraph** 
new method:
com.aspose.pdf.BaseParagraph.getVerticalAlignment()

Changes in class **com.aspose.pdf.Document** 
new method:
com.aspose.pdf.Document.saveIncrementally(OutputStream)

Changes in interface **com.aspose.pdf.IDocument** 
new method:
com.aspose.pdf.IDocument.saveIncrementally(OutputStream)

Changes in class **com.aspose.pdf.Font** 
new method:
com.aspose.pdf.Font.getDecodedFontName()

Added new class **com.aspose.pdf.FormattedFragment**

Added new class **com.aspose.pdf.HideAction** 
constructors:
com.aspose.pdf.HideAction.#ctor(Annotation)
com.aspose.pdf.HideAction.#ctor(Annotation,boolean)
com.aspose.pdf.HideAction.#ctor(String)
com.aspose.pdf.HideAction.#ctor(String,boolean)
com.aspose.pdf.HideAction.#ctor(Annotation[])
com.aspose.pdf.HideAction.#ctor(Annotation[],boolean)
com.aspose.pdf.HideAction.#ctor(String[])
com.aspose.pdf.HideAction.#ctor(String[],boolean)
methods:
com.aspose.pdf.HideAction.isHidden()
com.aspose.pdf.HideAction.setHidden(boolean)

Changes in class **com.aspose.pdf.HtmlFragment** 
renamed methods:
com.aspose.pdf.HtmlFragment.getHtmlLoadOptionsOfInstance() -> com.aspose.pdf.HtmlFragment.getHtmlLoadOptions()
com.aspose.pdf.HtmlFragment.setHtmlLoadOptionsOfInstance(HtmlLoadOptions) -> com.aspose.pdf.HtmlFragment.setHtmlLoadOptions(HtmlLoadOptions)

Changes in class **com.aspose.pdf.WidgetAnnotation** 
renamed methods:
com.aspose.pdf.WidgetAnnotation.getActions -> com.aspose.pdf.WidgetAnnotation.getAnnotationActions

Added new class **com.aspose.pdf.LatexFragment** 
constructors:
com.aspose.pdf.LatexFragment.#ctor(String)
com.aspose.pdf.LatexFragment.#ctor(String,boolean)
methods:
com.aspose.pdf.LatexFragment.getLatexLoadOptionsOfInstance()
com.aspose.pdf.LatexFragment.setLatexLoadOptionsOfInstance(LatexLoadOptions)
com.aspose.pdf.LatexFragment.deepClone

Changes in class **com.aspose.pdf.LightweightOperatorCollection** 
new method:
com.aspose.pdf.LightweightOperatorCollection.addRange(LightweightOperatorCollection)

Added new class **com.aspose.pdf.PdfActionCollection** 
methods:
com.aspose.pdf.PdfActionCollection.getCount()
com.aspose.pdf.PdfActionCollection.get_Item(int)
com.aspose.pdf.PdfActionCollection.delete(int)
com.aspose.pdf.PdfActionCollection.add(PdfAction)
com.aspose.pdf.PdfActionCollection.iterator()

Changes in class **com.aspose.pdf.Point** 
new method:
com.aspose.pdf.Point.toString()

Changes in class **com.aspose.pdf.SignatureField** 
new method:
com.aspose.pdf.SignatureField.extractImage(ImageType)

Changes in class **com.aspose.pdf.TextAbsorber** 
new methods:
com.aspose.pdf.TextAbsorber.hasErrors()
com.aspose.pdf.TextAbsorber.getErrors()

Added new class **com.aspose.pdf.TextExtractionError** 
methods:
com.aspose.pdf.TextExtractionError.getSummary()
com.aspose.pdf.TextExtractionError.getDescription()
com.aspose.pdf.TextExtractionError.getLocation()
com.aspose.pdf.TextExtractionError.getFontKey()
com.aspose.pdf.TextExtractionError.getFontName()
com.aspose.pdf.TextExtractionError.getExtractedText()
com.aspose.pdf.TextExtractionError.toString()

Added new class **com.aspose.pdf.TextExtractionErrorLocation** 
methods:
com.aspose.pdf.TextExtractionErrorLocation.getPath()
com.aspose.pdf.TextExtractionErrorLocation.getPageNumber()
com.aspose.pdf.TextExtractionErrorLocation.getObjectType()
com.aspose.pdf.TextExtractionErrorLocation.getFormKey()
com.aspose.pdf.TextExtractionErrorLocation.getOperatorIndex()
com.aspose.pdf.TextExtractionErrorLocation.getOperatorString()
com.aspose.pdf.TextExtractionErrorLocation.getFontUsedKey()
com.aspose.pdf.TextExtractionErrorLocation.getTextStartPoint()
com.aspose.pdf.TextExtractionErrorLocation.toString()

Changes in class **com.aspose.pdf.TextFormattingOptions** 
new constructor:
com.aspose.pdf.TextFormattingOptions.#ctor()
new field:
com.aspose.pdf.TextFormattingOptions.WordWrapMode.Undefined

Changes in class **com.aspose.pdf.TextFragmentAbsorber** 
new methods:
com.aspose.pdf.TextFragmentAbsorber.hasErrors_Fragment()
com.aspose.pdf.TextFragmentAbsorber.getErrors()

Changes in class **com.aspose.pdf.TextReplaceOptions** 
new methods:
com.aspose.pdf.TextReplaceOptions.getAdjustmentNewLineSpacing()
com.aspose.pdf.TextReplaceOptions.setAdjustmentNewLineSpacing(double)
com.aspose.pdf.TextReplaceOptions.#ctor()

Changes in class **com.aspose.pdf.TextReplaceOptions** 
new methods:
com.aspose.pdf.TextSearchOptions.getLogTextExtractionErrors()
com.aspose.pdf.TextSearchOptions.setLogTextExtractionErrors(boolean)

Changes in class **com.aspose.pdf.TextReplaceOptions** 
new methods:
com.aspose.pdf.TocInfo.isShowPageNumbers()
com.aspose.pdf.TocInfo.setShowPageNumbers(boolean)

Changes in class **com.aspose.pdf.XFA** 
new method:
com.aspose.pdf.XFA.tryGetTemplateString(String)
