---
title: Aspose.PDF for Java 18.1 Release Notes
type: docs
weight: 120
url: /java/aspose-pdf-for-java-18-1-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-35762|Extract text from PDF by paragraphs|New Feature|
|PDFJAVA-34279|PostScript to PDF conversion|New Feature|
|PDFJAVA-37411|EPS to PDF conversion support|New Feature|
|PDFJAVA-36111|Converting XFA form to standard adds two extra pages|Bug|
|PDFJAVA-36039|PCL to PDF: PCL Line Space sequences do not work|Bug|
|PDFJAVA-35365|XFA to Standard - Exception during conversion|Bug|
|PDFJAVA-34893|HTML to PDF conversion: contents are moving off the page|Bug|
|PDFJAVA-36582|DropDown value is not completely visible when calling flatten() method|Bug|
|PDFJAVA-35674|PDF to PDF/A - Exception during conversion|Bug|
|PDFJAVA-35991|PDF to PDFA: Vertical text renders in different order|Bug|
|PDFJAVA-37071|PDF to JPG - the missing text on the first page|Bug|
|PDFJAVA-35601|SVG to PDF - The image does not appear within table cell|Bug|
|PDFJAVA-35686|Exception message is not meaningful or related to missing fonts|Bug|
|PDFJAVA-35223|Set ID for Image resource inside PDF|Bug|
|PDFJAVA-37349|An exception raises when adding a local font path|Bug|
|PDFJAVA-37286|An exception raises while saving the document which contains HtmlFragments|Bug|
### **Public API changes**
Added new class **com.aspose.pdf.AutoDetectedFormatLoadOptions** 
constructors:
com.aspose.pdf.AutoDetectedFormatLoadOptions()

Added new method:
**com.aspose.pdf.facades.PdfAnnotationEditor**.redactExactArea(int,Rectangle,java.awt.Color)

Added new method:
**com.aspose.pdf.facades.Stamp**.bindTextState(TextState)

Added new class **com.aspose.pdf.IResourceLoadingCallback** 
method:
com.aspose.pdf.IResourceLoadingCallback.resourceLoading(Object,ResourceLoadingEventArgs)

Removed internal fields in the class **com.aspose.pdf.LoadFormat** 
public static final int Plugin = 11;
public static final int AutoDetect = 12;
Added new field:
public static final int PS = 10;

Added new class **com.aspose.pdf.MarkupParagraph** 
methods:
com.aspose.pdf.MarkupParagraph.getPoints()
com.aspose.pdf.MarkupParagraph.getFragments()
com.aspose.pdf.MarkupParagraph.getLines()

Added new class **com.aspose.pdf.MarkupSection** 
methods:
com.aspose.pdf.MarkupSection.getRectangle()
com.aspose.pdf.MarkupSection.getFragments()
com.aspose.pdf.MarkupSection.getParagraphs()

Added new class **com.aspose.pdf.PageMarkup** 
methods:
com.aspose.pdf.PageMarkup.getNumber()
com.aspose.pdf.PageMarkup.getRectangle()
com.aspose.pdf.PageMarkup.getSections()
com.aspose.pdf.PageMarkup.getParagraphs()
com.aspose.pdf.PageMarkup.getTextFragments()

Added new class **com.aspose.pdf.ParagraphAbsorber** 
methods:
com.aspose.pdf.ParagraphAbsorber.getPageMarkups()
com.aspose.pdf.ParagraphAbsorber.getSectionsSearchDepth()
com.aspose.pdf.ParagraphAbsorber.setSectionsSearchDepth(int)
com.aspose.pdf.ParagraphAbsorber.visit(Document)
com.aspose.pdf.ParagraphAbsorber.visit(Page)
constructors:
com.aspose.pdf.ParagraphAbsorber.#ctor
com.aspose.pdf.ParagraphAbsorber.#ctor(int)

Added new class **com.aspose.pdf.PsLoadOptions** 
methods:
com.aspose.pdf.PsLoadOptions.getFontsFolders()
com.aspose.pdf.PsLoadOptions.setFontsFolders(String[])
constructor:
com.aspose.pdf.PsLoadOptions.#ctor

Added new method: 
**com.aspose.pdf.RedactionAnnotation**.redactExact()

Added new class **com.aspose.pdf.ResourceLoadingEventArgs** 
method:
com.aspose.pdf.ResourceLoadingEventArgs.getUri_ResourceLoadingEventArgs_New()
constructor:
com.aspose.pdf.ResourceLoadingEventArgs.#ctor(String)

Added new class **com.aspose.pdf.ResourceLoadingResult** 
methods:
com.aspose.pdf.ResourceLoadingResult.getData_ResourceLoadingResult_New()
com.aspose.pdf.ResourceLoadingResult.getEncoding_ResourceLoadingResult_New()
constructors:
com.aspose.pdf.ResourceLoadingResult.#ctor(byte[])
com.aspose.pdf.ResourceLoadingResult.#ctor(byte[],java.nio.charset.Charset)

Added new methods: 
**com.aspose.pdf.TextFormattingOptions**.getSubsequentLinesIndent()
**com.aspose.pdf.TextFormattingOptions**.setSubsequentLinesIndent(float)

Changed the method's name in the class **com.aspose.pdf.TextFragmentAbsorber**:
com.aspose.pdf.TextFragmentAbsorber.hasErrors_Rename_Namesake() -> com.aspose.pdf.TextFragmentAbsorber.hasErrors_Fragment()

Added new methods:
**com.aspose.pdf.TextFragmentState**.getRenderingMode()
**com.aspose.pdf.TextFragmentState**.setRenderingMode(int)

Added new methods: 
**com.aspose.pdf.TextFragmentState**.getStrokingColor()
**com.aspose.pdf.TextFragmentState**.setStrokingColor(Color)
**com.aspose.pdf.TextFragmentState**.getDrawTextRectangleBorder()

Added new class **com.aspose.pdf.TextRenderingMode** 
Fields
public static final int FillText = 0;
public static final int StrokeText = 1;
public static final int FillThenStrokeText = 2;
public static final int Invisible = 3;
public static final int FillTextAndAddPathToClipping = 4;
public static final int StrokeTextAndAddPathToClipping = 5;
public static final int FillThenStrokeTextAndAddPathToClipping = 6;
public static final int AddPathToClipping = 7;

Added new constructor: 
**com.aspose.pdf.TextStamp**.#ctor(String,TextState)

Added new methods: 
**com.aspose.pdf.TextState**.getRenderingMode()
**com.aspose.pdf.TextState**.setRenderingMode(int)
**com.aspose.pdf.TextState**.getStrokingColor()
**com.aspose.pdf.TextState**.setStrokingColor(com.aspose.pdf.Color)

The following methods return resource name now:
**com.aspose.pdf.XImageCollection**.add(BufferedImage)
**com.aspose.pdf.XImageCollection**.addWithImageFilterType(InputStream,int)
**com.aspose.pdf.XImageCollection**.add(InputStream,int)


