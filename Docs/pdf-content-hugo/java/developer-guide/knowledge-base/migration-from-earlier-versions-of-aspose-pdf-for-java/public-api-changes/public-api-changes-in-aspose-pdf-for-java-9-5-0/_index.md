---
title: Public API Changes in Aspose.PDF for Java 9.5.0
type: docs
weight: 70
url: /java/public-api-changes-in-aspose-pdf-for-java-9-5-0/
---

{{% alert color="primary" %}} 

This page lists the public API changes introduced in [Aspose.PDF for Java 9.5.0](http://www.aspose.com/community/files/72/java-components/aspose.pdf-for-java/entry576058.aspx). It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.PDF for Java which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

{{% /alert %}} 

**Property CoordinateType is added to PdfViewer and PdfConverter
**The CoordinateType property allows to set printable area to MediaBox or CropBox (default value)

**SetFieldImage method was added to XFA class:** 

public void SetFieldImage(string fieldName, Stream image)

Example:
Following code snippet shows how to set image for XFA form field:

{{< highlight java >}}

 Document doc = new Document("doc.pdf");

InputStream fs = new FileInputStream("image.jpg");

doc.getForm().getXFA().setFieldImage("form1\[0\].ImageField1\[0\]", fs);

doc.save("37017-1.pdf");

{{< /highlight >}}

**ReplaceAdjustment** enumeration is added to **TextReplaceOptions** class

This enum provides following values:

- **None** - No action, length of the line may be changed
- **AdjustSpaceWidth** - Try to adjust spaces between words to keep line length

**ReplaceAdjustmentAction** property is added into **TextReplaceOptions** class

**TextReplaceOptions** class has new constructor that allows to set **ReplaceAdjustment** parameter:

TextReplaceOptions(int adjustment, int scope)

**TextReplaceOptions** property is added into **TextFragmentAbsorber** class

**Ellipse** class is implemented:

Constructor:

public Ellipse(float left, float bottom, float width, float height)

Properties:

- Left - float value that indicates the left position of the ellipse.
- Bottom - float value that indicates the bottom position of the ellipse.
- Width - float value that indicates the width of the ellipse.
- Height - float value that indicates the height of the ellipse.

Example:
Following code snippet shows how to add Ellipse:

{{< highlight java >}}

 String outFile = "Ellipse.pdf";

Document doc = new Document();

Page page = doc.getPages().add();

Graph canvas = new Graph(400, 100);

page.getParagraphs().add(canvas);

Ellipse ellipse1 = new Ellipse(50, 10, 100, 50);

canvas.getShapes().add(ellipse1);

doc.save(outFile);

{{< /highlight >}}

**Path** class was implemented

Constructors:

public Path()
public Path(Shape[] shapes)

Property:

- Shapes - shapes collection

Example:
following code snippet shows how o add Path:

{{< highlight java >}}

 Document doc = new Document();

Page page = doc.getPages().add();

Graph graph = new Graph(100, 400);

page.getParagraphs().add(graph);

Path path = new Path();

path.getGraphInfo().setFillColor ( Color.getRed());

graph.getShapes().add(path);

Line line = new Line(new float[] { 200, 80, 200, 100 });

path.getShapes().add(line);

Arc arc = new Arc(200, 50, 50, 90, 270);

path.getShapes().add(arc);

float[] curPos = arc.getEndPosition();

line = new Line(new float[] { curPos[0], curPos[1], 200, 20 });

path.getShapes().add(line);

arc = new Arc(200, 50, 30, 270, 90);

path.getShapes().add(arc);

doc.Save(outFile);

{{< /highlight >}}

**HtmlFragment** class was added into package com.aspose.pdf*

Constructor:

- public HtmlFragment(string text)

Parameter:

- Text - HTML text
  Property:
- Text - HTML text

Example:
Following code snippet shows how to add HTML fragment:

{{< highlight java >}}

 Document doc = new Document();

Page page = doc.getPages().add();

HtmlFragment titel = new HtmlFragment("<fontsize=10><b><i>Table</i></b></fontsize>");

titel.setKeptWithNext (true);

titel.getMargin().setBottom (10);

titel.getMargin().setTop (200);

page.getParagraphs().add(titel);

doc.Save(outFile);

{{< /highlight >}}

**ContainsUsageRights()** method was added into **PdfFileSignature** class

**RemoveUsageRights()** method was added into **PdfFileSignature** class

Example:
Following code shows ho to remove usage rights feature from the document:

{{< highlight java >}}

 PdfFileSignature pdfSign = new PdfFileSignature();

try

{

    String inputFile = "c:\\36908.pdf";

    String outputFile = "c:\\36908_output.pdf";

    pdfSign.bindPdf(inputFile);

    if (pdfSign.containsUsageRights())

    {

        pdfSign.removeUsageRights();

    }

    pdfSign.getDocument().save(outputFile);

}

finally

{

    pdfSign.dispose();

}

{{< /highlight >}}

**isContainSignature()** method was renamed into **ContainsSignature(...)**

  - Previous method name was not removed but marked as obsolete to be removed in future.
    **isCoversWholeDocument()** method was renamed into **CoversWholeDocument(...)**
  - Previous method name was not removed but marked as obsolete to be removed in future.

**Measure** class was added into **com.aspose.pdf** package

The Class describes Measure coordinate system. Members of Measure class:

Constructor:

- public Measure(Annotation annotation)

get/set Properties:

- ScaleRatio - A text string expressing the scale ratio of the drawing.
- XFormat - A number format array for measurement of change along the xaxis and, if Y is not present, along the y axis as well
- YFormat - A number format array for measurement of change along the y axis.
- DistanceFormat - A number format array for measurement of distance in any direction.
- AreaFormat - A number format array for measurement of area.
- AngleFormat - A number format array for measurement of angles.
- SlopeFormat - A number format array for measurement of the slope of a line.
- Origin - Point that shall specify the origin of the measurement coordinate system in default user space coordinates.
- XYFactor - A factor that shall be used to convert the largest units along the y axis to the largest units along the x axis.

**NumberFormat** class was added into **Measure** class

The class represents Number format for measure.

Constructor:

- public NumberFormat(Measure measure)

get/set Properties:

- UnitLabel - A text string specifying a label for displaying the units.
- ConvresionFactor - The conversion factor used to multiply a value in partial units of the previous number format array element to obtain a value in the units of this number format.
- FractionDisplayment - In what manner fractional values are displayed.
- Precision - If FractionDisplayment is ShowAsDecimal, this value is precision of fractional value; It shall me multiple of 10. Default is 100.
- Denominator - If FractionDisplayment is ShowAsFraction, this value is denominator of the fraction. Default value is 16.
- ForceDenominator - If FractionDisplayment is ShowAsFraction, this value determines meay or not the fraction be reduced. If value is true fraction may not be reduced.
- ThousandsSeparator - Text that shall be used between orders of thousands in display of numerical values. An empty string indicates that no text shall be added. Default is comma.
- FractionSeparator - Text that shall be used as the decimal position in displaying numerical values. An empty string indicates that the default shall be used. Default is period character.
- BeforeText - Text that shall be concatenated to the left of the label.
- AfterText - Text that shall be concatenated after the label

Enumeration **FractionStyle** was added into **NumberFormat** class

FractionStyle values:

- ShowAsDecimal - Show fractional values as decimal fraction.
- ShowAsFraction - Show fractional value as fraction.
- Round - Round fractional values to the nearest whole integer.
- Truncate - Truncate to achieve whole units.

**NumberFormatList** class was added into **Measure** class

The class represents Represents list of number formats.

Constructor:

- public NumberFormatList(Measure measure)

Properties:

- get_Item(int) and set_Item(int index, NumberFormat value) - Gets or sets number format in list by its index.
- getCount()- Count if items in the list.

Methods:

- public void add(NumberFormat value)
  - Adds number format to list.
- public void insert(int index, NumberFormat value)
  - Inserts number format into list.
- public void removeAt(int index)
  - Removes number format from list.

**Measure** property was added to **LineAnnotation** and **PolyLineAnnotation** classes.

Examples:
Following example demonstrates how to use Measure with LineAnnotation:

{{< highlight java >}}

 Document doc = new Document("source.pdf");

Rectangle rect = new Rectangle(260, 630, 451, 662);

LineAnnotation line = new LineAnnotation(doc.getPages().get_Item(1), rect, new Point(266, 657), new Point(446, 656));

line.setColor(Color.getRed());

//set extension line parameters.

line.setLeaderLine(-15);

line.setLeaderLineExtension(5);

//set line endings 

line.setStartingStyle(LineEnding.OpenArrow);

line.setEndingStyle(LineEnding.OpenArrow);

//create Measure element

line.setMeasure(new Measure(line));

line.getMeasure().setDistanceFormat(new Measure.NumberFormatList(line.getMeasure()));

line.getMeasure().getDistanceFormat().add(new Measure.NumberFormat(line.getMeasure()));

line.getMeasure().getDistanceFormat().get_Item(1).setUnitLabel("mm");

line.getMeasure().getDistanceFormat().get_Item(1).setFractionSeparator(".");

line.getMeasure().getDistanceFormat().get_Item(1).setConvresionFactor(1);

//text of measure line

line.setContents("155 mm");

//this must be set to show the text.

line.setShowCaption(true);

line.setCaptionPosition(CaptionPosition.Top);

doc.getPages().get_Item(1).getAnnotations().add(line);

doc.save("output.pdf");

{{< /highlight >}}

Following example demonstrates how to use Measure with PolylineAnnotation:

{{< highlight java >}}

 Document doc = new Document("source.pdf");

Point[] vertices = new Point[]

{

	new Point(100, 600), 

	new Point(500, 600), 

	new Point(500, 500), 

	new Point(400, 300), 

	new Point(100, 500), 

	new Point(100, 600)

};

Rectangle rect = new Rectangle(100, 500, 500, 600);

//area or perimeter line

PolylineAnnotation area = new PolylineAnnotation(doc.getPages().get_Item(1), rect, vertices);

area.setColor(Color.getRed());

//line engins can be set for perimeter line. 

area.setStartingStyle(LineEnding.OpenArrow);

area.setEndingStyle(LineEnding.OpenArrow);

area.setMeasure(new Measure(area));

area.getMeasure().setDistanceFormat(new Measure.NumberFormatList(area.getMeasure()));

area.getMeasure().getDistanceFormat().add(new Measure.NumberFormat(area.getMeasure()));

area.getMeasure().getDistanceFormat().get_Item(1).setUnitLabel("mm");

doc.getPages().get_Item(1).getAnnotations().add(area);

doc.save("output.pdf");

{{< /highlight >}}

Following code snippet demonstrates how to read Measure properties:

{{< highlight java >}}

 //read Measure properties

Document doc = new Document("measure.pdf");

System.out.println(((LineAnnotation)doc.getPages().get_Item(1).getAnnotations().get_Item(1)).getMeasure().getScaleRatio());

System.out.println(((LineAnnotation)doc.getPages().get_Item(1).getAnnotations().get_Item(1)).getMeasure().getAreaFormat().get_Item(1).getUnitLabel());

System.out.println(((LineAnnotation)doc.getPages().get_Item(1).getAnnotations().get_Item(1)).getMeasure().getAreaFormat().get_Item(1).getConvresionFactor());

System.out.println(((LineAnnotation)doc.getPages().get_Item(1).getAnnotations().get_Item(1)).getMeasure().getAreaFormat().get_Item(1).getFractionSeparator());

{{< /highlight >}}

**Breaking change** - PdfPageEditor.Pages property was renamed to **ProcessPages**

Following code snippet shows the property usage (sets zoom coefficient for page #1 of the document):

{{< highlight java >}}

 PdfPageEditor editor = new PdfPageEditor();

editor.bindPdf("input.pdf");

editor.setZoom(0.5f);

editor.setProcessPages(new int[] { 1 });

editor.save("output.pdf");

{{< /highlight >}}

**Breaking change** - RichTextBoxField.RValue property was renamed to **RichTextValue**

Following code snippet shows a sample where the renamed field was used:

{{< highlight java >}}

 Document doc = new Document("input.pdf");

RichTextBoxField rt = new RichTextBoxField(doc.getPages().get_Item(1), new Rectangle(50, 600, 250, 650));

rt.setPartialName("rt");

doc.getForm().add(rt);

doc.save("34834.pdf");

Document doc1 = new Document("34834.pdf");

((RichTextBoxField)doc1.getForm().get("rt")).setRichTextValue("<p>This is my <b>paragraph</b></p>");

doc1.save("output.pdf");

{{< /highlight >}}

**InsertBlankColumnAtFirst** option was added into **ExcelSaveOptions class**

Following code snippet shows how to suppress appearing of first blank column:

{{< highlight java >}}

 Document doc = new Document(inFile);

ExcelSaveOptions options = new ExcelSaveOptions();

options.setInsertBlankColumnAtFirst(false);

doc.save(outFile, options);

{{< /highlight >}}

**PageInfo** property was added to **SvgLoadOptions** class.

Following code snippet shows how to use SvgLoadOptions and set margin info with PageInfo property:

{{< highlight java >}}

 SvgLoadOptions options = new SvgLoadOptions();

options.ConversionEngine = SvgLoadOptions.ConversionEngines.NewEngine;

options.getPageInfo().getMargin().setTop(0);

options.getPageInfo().getMargin().setLeft(0);

options.getPageInfo().getMargin().setBottom(0);

options.getPageInfo().getMargin().setRight(0);

String inFile = "35730.svg";

String outFile = "35730.pdf";

Document pdfDocument = new Document(inFile, options);

pdfDocument.save(outFile);

{{< /highlight >}}

**ConversionEngines** enumeration was added to **SvgLoadOptions** class.

Following values are defined:

- **LegacyEngine** - legacy engine of Svg processing
- **NewEngine** - new Svg processing engine

**ConversionEngine** property was added to **SvgLoadOptions** class

The LegacyEngine is still default value because NewEngine is in B-testing stages.
Following code snippet shows sample how to use new engine:

{{< highlight java >}}

 SvgLoadOptions options = new SvgLoadOptions();

options.ConversionEngine = SvgLoadOptions.ConversionEngines.NewEngine;

String inFile = "36516_2_income.svg";

String outFile = "36516_2_income.pdf";

Document pdfDocument = new Document(inFile, options);

pdfDocument.save(outFile);

{{< /highlight >}}

**ColumnAdjustment** property was added to **Table** class

ColumnAdjustment enumeration was added into com.aspose.pdf package

following values were added:

- **Customized** - The user sets the ColumnWidth manually.
- **AutoFitToContent** - Performs auto fit to content

**ColumnAdjustment** property was added to **Table** class

The Default value is Customized.

Following code snippet shows sample of the ColumnAdjustment property usage:

{{< highlight java >}}

 Table hTable = new Table();

hTable.getMargin().setTop(4);

hTable.setDefaultCellBorder(new BorderInfo(BorderSide.All, 0.5F, Color.getBlack()));

hTable.setDefaultCellPadding(new MarginInfo(1, 1, 1, 1));

hTable.setAlignment(HorizontalAlignment.Left);

hTable.setColumnAdjustment(ColumnAdjustment.AutoFitToContent);

{{< /highlight >}}

**MinimizeTheNumberOfWorksheets** property was introduced into **ExcelSaveOptions** object.

Following code snippet shows how to minimize possible number of worksheets:

{{< highlight java >}}

 Document doc = new Document("Original.pdf");

ExcelSaveOptions options = new ExcelSaveOptions();

//Set this property to true

options.setMinimizeTheNumberOfWorksheets(true);

doc.save("output.xls", options);

{{< /highlight >}}

**Default** value was added to **PageLayout** enumeration.

Following code snippet sets PageLayout to Default value:

{{< highlight java >}}

 Document doc1 = new Document("input.pdf");

doc1.setPageLayout (PageLayout.Default);

doc1.save("output.pdf");

{{< /highlight >}}

**Rounded Ends** support was implemented for **InkAnnotation**

**CapStyle** enumeration was added into **com.aspose.pdf** package
The following values are present

- **Rectangular** - Default specified value
- **Rounded** - rounded corners
- **CapStyle** property was added to **InkAnnotation** class

Following code snippet shows how to set the InkAnnotation corners as rounded:

{{< highlight java >}}

 Document doc = new Document("PdfWithText.pdf");

Page pdfPage = doc.getPages().get_Item(1);

java.awt.Rectangle drect = new java.awt.Rectangle();

drect.height = (int)pdfPage.getRect().getHeight();

drect.width = (int)pdfPage.getRect().getWidth();

drect.x = 0;

drect.y = 0;

com.aspose.pdf.Rectangle arect = com.aspose.pdf.Rectangle.fromRect(drect);

java.util.ArrayList inkList = new java.util.ArrayList();

com.aspose.pdf.Point[] arrpt = new com.aspose.pdf.Point[3];

inkList.add(arrpt);

arrpt[0] = new Point(100, 800);

arrpt[1] = new Point(200, 800);

arrpt[2] = new Point(200, 700);

InkAnnotation ia = new InkAnnotation(pdfPage, arect, inkList);

ia.setTitle("XXX");

ia.setColor(Color.getLightBlue());

ia.setCapStyle(CapStyle.Rounded);

Border border = new Border(ia);

border.setWidth(25);

ia.setOpacity(0.5);

pdfPage.getAnnotations().add(ia);

doc.save("37071.pdf");

{{< /highlight >}}

**PDFNEWJAVA-33498** - Provide support to add Image from BufferedImage into PDF document

Following code snippet shows adding Image from BufferedImage:

{{< highlight java >}}

 BufferedImage originalImage = ImageIO.read(new File("c:\\image\\anyImage.jpg"));

Document pdfDocument1 = new Document();

Page page2 = pdfDocument1.getPages().add();

page2.getResources().getImages().add(originalImage)

{{< /highlight >}}

**PDFNEWJAVA-34088** - PDF to HTML conversion: To specify image folder

Following code snippet shows how to specify image folder:

{{< highlight java >}}

 Document pdfDocument = new Document(testdata + "PDFNEWJAVA_34088.pdf");

HtmlSaveOptions saveOptions = new HtmlSaveOptions();

saveOptions.SpecialFolderForAllImages = testdata + "SpecialFolderForAllImages";        

pdfDocument.save(testout + "PDFNEWJAVA_34088.html", saveOptions);

{{< /highlight >}}

**PDFNEWJAVA-33203** - Setting DPI/PPI of images in PDF

Following code snippet shows how to change image resolution in the pdf file:

{{< highlight java >}}

 String myDir = "D:\\Temp\\";

File fileIn = new File(myDir+"image.jpg");

FileInputStream in = new FileInputStream(fileIn);



File fileOut = new File(myDir+"image.pdf");

FileOutputStream out = new FileOutputStream(fileOut);

//test pdf creation

Document doc = new Document();

Page page = doc.getPages().add();

com.aspose.pdf.Image image1 = new com.aspose.pdf.Image();

image1.setImageStream(in);

image1.setFixHeight(page.getMediaBox().getHeight()/4);

image1.setFixWidth(page.getMediaBox().getWidth()/2);	

NewParagraphPlacementInfo placementInfo = new NewParagraphPlacementInfo();

placementInfo.setStartNewPage(true);

page.getParagraphs().add(image1, placementInfo);	

page.getPageInfo().getMargin().setLeft(5);

page.getPageInfo().getMargin().setRight(0);

page.getPageInfo().getMargin().setTop(0);

page.getPageInfo().getMargin().setBottom(0);	 

doc.save(out);



//internal image resolution change

doc = new Document(myDir+"image.pdf");

XImageCollection images = doc.getPages().get_Item(1).getResources().getImages();

ByteArrayOutputStream baos = new ByteArrayOutputStream();

images.get_Item(1).save(baos, 10, 10);//define horizontal and vertical resolutions

images.get_Item(1).replace(new ByteArrayInputStream(baos.toByteArray()));

doc.save(myDir+"imageWithNewResolution.pdf");

{{< /highlight >}}
#### **Summary:**
**Added classes:**

- com.aspose.pdf.drawing.Ellipse
- com.aspose.pdf.drawing.Path
- com.aspose.pdf.generator.legacyxmlmodel.BadHtmlHandlingStrategy
- com.aspose.pdf.generator.legacyxmlmodel.BookmarkIncludeType
- com.aspose.pdf.generator.legacyxmlmodel.BorderSide
- com.aspose.pdf.generator.legacyxmlmodel.ColumnInfo
- com.aspose.pdf.generator.legacyxmlmodel.HeaderFooterType
- com.aspose.pdf.generator.legacyxmlmodel.HtmlInfo
- com.aspose.pdf.generator.legacyxmlmodel.ImportOptions
- com.aspose.pdf.generator.legacyxmlmodel.MediaType
- com.aspose.pdf.generator.legacyxmlmodel.PathArea
- com.aspose.pdf.generator.legacyxmlmodel.TableFormatInfo
- com.aspose.pdf.AutoDetectedFormatLoadOptions
- com.aspose.pdf.CapStyle
- com.aspose.pdf.ColumnAdjustment
- com.aspose.pdf.ComHelper
- com.aspose.pdf.EpubLoadOptions
- com.aspose.pdf.EpubSaveOptions
- com.aspose.pdf.FileFontSource
- com.aspose.pdf.FontAbsorber
- com.aspose.pdf.HtmlFragment
- com.aspose.pdf.Measure
- com.aspose.pdf.MemoryFontSource
#### **Changes in the classes:**
**com.aspose.pdf.facades.Form** 
Changes:

- public java.util.Map getButtonOptionValues(String fieldName) -> public java.util.Hashtable<String,String> getButtonOptionValues(String fieldName)

**com.aspose.pdf.facades.PdfConverter** 
Added:

- public int getCoordinateType()
- public void setCoordinateType(int value)
  Depricated:
- public boolean getShowHiddenAreas()
- public void setShowHiddenAreas(boolean value)

**com.aspose.pdf.facades.PdfFileInfo** 
Changes:

- public java.util.Map getHeader() -> public java.util.Map<String, String> getHeader()
- public void setHeader(java.util.Map value) -> public void setHeader(java.util.Map<String,String> value

**com.aspose.pdf.facades.PdfFileSignature** 
Depricated:

- public boolean isContainSignature()
- public boolean isCoversWholeDocument(String signName)
  Added:
- public boolean containsSignature()
- public boolean containsUsageRights()
- public void removeUsageRights()

**com.aspose.pdf.facades.PdfPageEditor** 
Changes:

- public int[] getPages_Rename_Namesake() -> public int[] getProcessPages()
- public void setPages(int[] value) -> public void setProcessPages(int[] value)
- public java.util.Map getPageRotations() -> public java.util.Map<Integer, Integer> getPageRotations()
- public void setPageRotations(java.util.Map value) -> public void setPageRotations(java.util.Map<Integer, Integer> value)

**com.aspose.pdf.facades.PdfViewer** 
Depricated:

- public boolean getShowHiddenAreas()
- public void setShowHiddenAreas(boolean value)
  Added:
- public int getCoordinateType()
- public void setCoordinateType(int value)

**com.aspose.pdf.facades.PdfXmpMetadata** 
Changes:

- public IDictionary getExtensionFields() -> public java.util.Hashtable<String, XmpPdfAExtensionSchema> getExtensionFields()

**com.aspose.pdf.generator.legacyxmlmodel.Attachment** 
Added:

- public InputStream AttachedStream

**com.aspose.pdf.generator.legacyxmlmodel.BorderInfo** 
Added:

- public void setBorderStyle(int borderSide, int style)

**com.aspose.pdf.generator.legacyxmlmodel.BoxVerticalAlignmentType**

- Removed Deprecated status from the class

**com.aspose.pdf.generator.legacyxmlmodel.Cell** 
Added:

- public TextInfo getDefaultCellTextInfo()
- public void setDefaultCellTextInfo(TextInfo value)
- public String getText()

**com.aspose.pdf.generator.legacyxmlmodel.HeaderFooter** 
Added:

- public Object completeClone()
- public Object completeCloneAll()

**com.aspose.pdf.generator.legacyxmlmodel.Heading** 
Removed Deprecated status from:

- public int getBulletAlignment()
- public void setBulletAlignment(int value)

**com.aspose.pdf.generator.legacyxmlmodel.Image** 
Added:

- public Image(HeaderFooter hf)

**com.aspose.pdf.generator.legacyxmlmodel.JavaScripts** 
Added:

- public void remove(Cell jsToRemove)

**com.aspose.pdf.generator.legacyxmlmodel.LegacyPdf** 
Added:

- public boolean DigitSubstitution
- public boolean IsAutoFontAdjusted
- public boolean IsBuffered
- public InputStream TruetypeFontMapStream
- public boolean IsImageNotFoundErrorIgnored
- public boolean Linearized;
- public int getPageCount()
- public void save(OutputStream output)
- public byte[] getBuffer()
- public void save(String pdfFile)
- public void bindXML(String xmlFile, String xslFileIfAny)
- public void bindXML(InputStream xmlStream, InputStream xslStream)
- public void setUnicode()
- public Object getObjectByID(String ID)
- public HtmlInfo HtmlInfo

Added Deprecated:

- public int getBookMarkLevel()
- public void setBookMarkLevel(int value)
- public int getDirectModeItemType()
- public void setDirectModeItemType(int value)
- public int getDirectModeItemsCount()
- public void setDirectModeItemsCount(int value)

**com.aspose.pdf.generator.legacyxmlmodel.LinkAction** 
Added:

- public String SoundFileName

**com.aspose.pdf.generator.legacyxmlmodel.Paragraphs** 
Added:

- public void add(Paragraph paragraph)
- void addHeading(Paragraph paragraph)
- public int indexOf(Paragraph paragraph)
- public void copyTo(Paragraph[] paraArray, int index)
- public void insert(Paragraph paragraphToInsertAfter, Paragraph newParagraph)

**com.aspose.pdf.generator.legacyxmlmodel.Row** 
Changed:

- DefaultCellTextInfo into getter and setter field
  Added:
- public TextInfo getDefaultCellTextInfo()
- public void setDefaultCellTextInfo(TextInfo value)
- public Object deepClone()

**com.aspose.pdf.generator.legacyxmlmodel.Section** 
Added:

- public ColumnInfo ColumnInfo
- public int getPageCount()
- public void setPageCount(int value)
- public String BreakParaText
- public Object deepClone()
- public Object completeClone()
- public HeaderFooter insertHeader(int type)
- public HeaderFooter insertFooter(int type)
- public Object getObjectByID(String ID)

**com.aspose.pdf.generator.legacyxmlmodel.Sections** 
Added:

- public Sections()
- public Section add()
- public void insert(int index, Section section)
- public void insert(Section sectionToInsertAfter, Section newSection)
- public void remove(Section sectionToRemove)
- public void copyTo(Section[] secArray, int index)
- public int indexOf(Section section)
- public void set_Item(int index, Section value)
- public Section get_Item(String sectionID)
- public void set_Item(String sectionID, Section value)

**com.aspose.pdf.generator.legacyxmlmodel.Security** 
Added:

- public boolean isDefaultAllAllowed()
- public void setDefaultAllAllowed(boolean value)

**com.aspose.pdf.generator.legacyxmlmodel.Shapes** 
Added:

- public void add(Shape shape)
- public void remove(Shape shapeToRemove)
- public void copyTo(Shape[] shapeArray, int index)
- public int indexOf(Shape shape)

**com.aspose.pdf.generator.legacyxmlmodel.Table** 
Changed:

- FixedWidth into getter and setter field
- DefaultCellTextInfo into getter and setter field
  Added:
- public float getFixedWidth()
- public void setFixedWidth(float value)
- public TextInfo getDefaultCellTextInfo()
- public void setDefaultCellTextInfo(TextInfo value)
- public Cell getCell(int row, int column, boolean isTableChanged)
- public void formatColumnsWithFormatInfo(TableFormatInfo info, int firstColumn, int maxColumns)
- public void formatTableWithFormatInfo(TableFormatInfo info, int firstColumn, int firstRow, int maxRows, int maxColumns)
- public void formatRowsWithFormatInfo(TableFormatInfo info, int firstRow, int maxRows)
- public void setColumnWidth(int columnNumber, float width)
- public String getColumnWidths()
- public void setColumnWidths(String value)

**com.aspose.pdf.generator.legacyxmlmodel.TabStops** 
Added:

- public int getCapacity()
- public void setCapacity(int value)

**com.aspose.pdf.generator.legacyxmlmodel.TextInfo** 
Changed:

- The next list of the fields was changed to the separate getter and setter field:

{{< highlight java >}}

 FontSize, FontName, TruetypeFontFileName, IsUnicode, FontAfmFile, FontPfmFile, FontOutlineFile, FontEncodingFile, IsTrueTypeFontBold, IsTrueTypeFontItalic,{color} {color:#222222}FontEncoding, IsFontEmbedded, IsUnderline,{color} {color:#222222}IsOverline,{color} {color:#222222}CharSpace, WordSpace, LineSpacing, OverlineOffset, UnderlineOffset, \_RenderingMode, Color, BackgroundColor, IsRightToLeft, StrokeWidth, StrokeColor, IsBaseline, Alignment.

{{< /highlight >}}

Added:

- public float getFontSize()
- public void setFontSize(float value)
- public String getFontName()
- public void setFontName(String value)
- public String getTruetypeFontFileName()
- public void setTruetypeFontFileName(String value)
- public boolean isUnicode()
- public void setUnicode(boolean value)
- public String getFontAfmFile()
- public void setFontAfmFile(String value)
- public String getFontPfmFile()
- public void setFontPfmFile(String value)
- public String getFontOutlineFile()
- public void setFontOutlineFile(String value)
- public String getFontEncodingFile()
- public void setFontEncodingFile(String value)
- public boolean isTrueTypeFontBold()
- public void setTrueTypeFontBold(boolean value)
- public boolean isTrueTypeFontItalic()
- public void setTrueTypeFontItalic(boolean value)
- public String getFontEncoding()
- public void setFontEncoding(String value)
- public boolean isFontEmbedded()
- public void setFontEmbedded(boolean value)
- public boolean isUnderline()
- public void setUnderline(boolean value)
- public boolean isOverline()
- public void setOverline(boolean value)
- public float getCharSpace()
- public void setCharSpace(float value)
- public float getWordSpace()
- public void setWordSpace(float value)
- public float getLineSpacing()
- public void setLineSpacing(float value)
- public float getOverlineOffset()
- public void setOverlineOffset(float value)
- public float getUnderlineOffset()
- public void setUnderlineOffset(float value)
- public int getRenderingMode()
- public void setRenderingMode(int value)
- public Color getColor()
- public void setColor(Color value)
- public Color getBackgroundColor()
- public void setBackgroundColor(Color value)
- public boolean isRightToLeft()
- public void setRightToLeft(boolean value)
- public float getStrokeWidth()
- public void setStrokeWidth(float value)
- public Color getStrokeColor()
- public void setStrokeColor(Color value)
- public boolean isBaseline()
- public void setBaseline(boolean value)
- public int getAlignment()
- public void setAlignment(int value)

**com.aspose.pdf.BaseOperatorCollection** 
Changes:

- implements ICollection -> implements ICollection<Operator>

**com.aspose.pdf.Border** 
Changes:

- public int getVCornerRaduis() -> public int getVCornerRadius()
- public void setVCornerRaduis(int value) -> public void setVCornerRadius(int value)
  Added Deprecated:
- public int getVCornerRaduis()
- public void setVCornerRaduis(int value)

**com.aspose.pdf.DataUtils** 
Changes:

- Internalized

**com.aspose.pdf.ExcelSaveOptions** 
Added:

- public boolean getMinimizeTheNumberOfWorksheets()
- public void setMinimizeTheNumberOfWorksheets(boolean value)
- public boolean getInsertBlankColumnAtFirst()
- public void setInsertBlankColumnAtFirst(boolean value)
- public boolean getUniformWorksheets()
- public void setUniformWorksheets(boolean value)

**com.aspose.pdf.Font** 
Added:

- public void save(OutputStream stream)

**com.aspose.pdf.Form** 
Added:

- public FieldsEnumerator(IDocument document, List<Object> fields)

**com.aspose.pdf.HtmlSaveOptions:** 
Added:

- public FontSourceCollection getFontSources()

**com.aspose.pdf.InkAnnotation** 
Added:

- public int getCapStyle()
- public void setCapStyle(int value)

**com.aspose.pdf.LineAnnotation** 
Added:

- public Measure getMeasure()
- public void setMeasure(Measure value)

**com.aspose.pdf.LoadFormat:** 
Changes:

- public static final int InfoPath - was removed
- public static final int AutoDetect - Added

**com.aspose.pdf.Metadata** 
Changes:

- public IDictionary getExtensionFields() -> public java.util.Hashtable<String, XmpPdfAExtensionSchema> getExtensionFields() 

**com.aspose.pdf.PageLayout** 
Added:

- public static final int Default

**com.aspose.pdf.PolylineAnnotation** 
Added:

- public Measure getMeasure()
- public void setMeasure(Measure value)

**com.aspose.pdf.PopupAnnotation** 
Added:

- public MarkupAnnotation getParent()
- public void setParent(MarkupAnnotation value)

**com.aspose.pdf.RichTextBoxField** 
Changes:

- public String getRValue() -> public String getRichTextValue()
- public void setRValue(String value) -> public void setRichTextValue(String value)

**com.aspose.pdf.SaveOptions.BorderPartStyle** 
Added:

- public java.awt.Color color

**com.aspose.pdf.SvgLoadOptions** 
Added:

- public static final class ConversionEngines
- public int ConversionEngine
- public PageInfo getPageInfo()
- public void setPageInfo(PageInfo value)

**com.aspose.pdf.Table** 
Added:

- public int getColumnAdjustment()
- public void setColumnAdjustment(int value)

**com.aspose.pdf.TextFragmentAbsorber** 
Added:

- public TextReplaceOptions getTextReplaceOptions()
- public void setTextReplaceOptions(TextReplaceOptions value)

**com.aspose.pdf.TextReplaceOptions** 
Added:

- public static final class ReplaceAdjustment
- public int getReplaceAdjustmentAction()
- public void setReplaceAdjustmentAction(int value)
- public TextReplaceOptions(int adjustment, int scope)

**com.aspose.pdf.XFA** 
Added:

- public void setFieldImage(String fieldName, InputStream image)
