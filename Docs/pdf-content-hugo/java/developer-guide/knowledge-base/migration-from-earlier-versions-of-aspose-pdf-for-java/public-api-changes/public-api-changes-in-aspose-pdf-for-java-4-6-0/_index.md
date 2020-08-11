---
title: Public API Changes in Aspose.PDF for Java 4.6.0
type: docs
weight: 20
url: /java/public-api-changes-in-aspose-pdf-for-java-4-6-0/
---

{{% alert color="primary" %}} 

This page lists public API changes that were introduced in Aspose.PDF for Java 4.6.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.PDF for Java which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

{{% /alert %}} 

In the latest version 4.6.0, we had removed all **ms-classes**. Therefore it is necessary to use internal wrappers.
This applies to the following classes:

com.aspose.ms.System.Drawing.Imaging.ImageFormat -> com.aspose.pdf.ImageFormatInternal

com.aspose.ms.System.Text.TextEncoding -> com.aspose.pdf.TextEncodingInternal

com.aspose.html.HtmlDocumentType -> com.aspose.pdf.HtmlDocumentTypeInternal

**Moved**:

com.aspose.pdf.facades.PageSize - to: com.aspose.pdf.PageSize

com.aspose.doc.wordcore.DocConverter - to: com.aspose.pdf.DocConverter

com.aspose.pdf.ITable  - to: com.aspose.pdf.generator.legacyxmlmodel.ITable 

com.aspose.pdf.ITableCell  - to: com.aspose.pdf.generator.legacyxmlmodel.ITableCell 

com.aspose.pdf.ITableRow  - to: com.aspose.pdf.generator.legacyxmlmodel.ITableRow 

**Added**:

package com.aspose.pdf.drawing 

and the next classes:

com.aspose.pdf.drawing.Arc 

com.aspose.pdf.drawing.Circle 

com.aspose.pdf.drawing.Curve 

com.aspose.pdf.drawing.Graph 

com.aspose.pdf.drawing.Line 

com.aspose.pdf.drawing.Rectangle 

com.aspose.pdf.drawing.Shape 

**Added**:

package com.aspose.pdf.excel

and the next classes:

com.aspose.pdf.excel.ColumnManager 

com.aspose.pdf.excel.ContentManager 

com.aspose.pdf.excel.DataKeeper 

com.aspose.pdf.excel.DataManager 

com.aspose.pdf.excel.ExcelConverterInternal 

com.aspose.pdf.excel.ItemPropertyStore 

com.aspose.pdf.excel.Log 

com.aspose.pdf.excel.OverrideContentManager 

com.aspose.pdf.excel.RegexManager 

com.aspose.pdf.excel.SpreadSheetManager 

com.aspose.pdf.excel.SSCell 

com.aspose.pdf.excel.SSColumn 

com.aspose.pdf.excel.SSConvertToXml 

com.aspose.pdf.excel.SSFileComponents 

com.aspose.pdf.excel.SSFont 

com.aspose.pdf.excel.SSRow 

com.aspose.pdf.excel.SSStyle 

com.aspose.pdf.excel.SSTable 

com.aspose.pdf.excel.SSWorkbook 

com.aspose.pdf.excel.SSWorksheet 

**Added classes:**

com.aspose.pdf.exceptions.FontNotFoundException 

com.aspose.pdf.generator.legacyxmlmodel.enums.InconsistentXmlImageParamsHandlingTypes 

com.aspose.pdf.text.FontTypes 

com.aspose.pdf.text.TextProcessingContext 

com.aspose.pdf.EpubConverter 

com.aspose.pdf.EpubLoadOptions 

com.aspose.pdf.EpubSaveOptions 

com.aspose.pdf.ExcelConverter 

com.aspose.pdf.ExcelSaveOptions 

com.aspose.pdf.FolderFontSource 

com.aspose.pdf.GraphInfo 

com.aspose.pdf.HtmlDocumentType 

com.aspose.pdf.InvalidFormTypeOperationException 

com.aspose.pdf.IWarningCallback 

com.aspose.pdf.LatexLoadOptions 

com.aspose.pdf.LatexToPdfConverter 

com.aspose.pdf.MhtMainHtmlPart 

com.aspose.pdf.MhtParcedPackage 

com.aspose.pdf.MhtPart 

com.aspose.pdf.MhtResourcePart 

com.aspose.pdf.MhtToPdfConverter 

com.aspose.pdf.MhtUtility 

com.aspose.pdf.MobiXmlConverter 

com.aspose.pdf.MobiXmlSaveOptions 

com.aspose.pdf.ReturnAction 

com.aspose.pdf.SvgConverter 

com.aspose.pdf.WarningInfo 

com.aspose.pdf.WarningType 

**Changes in the next classes:**

com.aspose.pdf.facades.AForm

was extended from SaveableFacade

added:

` `internal public static class FormImportResult

` `public FormImportResult[] getImportResult()

` `public void importXml(InputStream inputXmlStream)

` `public void extractXfaData(OutputStream outputXmlStream)

` `public void setXfaData(InputStream inputXmlStream)

` `public boolean isRequiredField(String fieldName)

` `public void importXml(InputStream inputXmlStream, boolean IgnoreFormTemplateChanges)

next methods were marked as @Deprecated:

` `public String getSrcFileName() 

` `public void setSrcFileName(String value)

` `public String getDestFileName() 

` `public AForm(String srcFileName, String destFileName)

` `public AForm(String srcFileName, OutputStream destStream)

` `public AForm(InputStream srcStream, String destFileName)

` `public AForm(IDocument document, String destFileName)

com.aspose.pdf.facades.AFormEditor 

added:

` `public double getRadioButtonItemSize()

` `public void setRadioButtonItemSize(double value)

` `public  int getFieldAppearance(String fieldName)

` `public boolean addFieldScript(String fieldName, String script)



next methods were marked as @Deprecated:

` `public String getSrcFileName() 

` `public void setSrcFileName(String value)

` `public String getDestFileName() 

` `public void setDestFileName(String value)

` `public AFormEditor(String srcFileName, String destFileName)

` `public void save()

` `public AFormEditor(IDocument document, String destFileName)

com.aspose.pdf.facades.AlignmentType 

class was marked as @Deprecated

added:

` `public  String toString()

com.aspose.pdf.facades.APdfFileEditor 

added:
` `public String getConversionLog()
` `public boolean getMergeDuplicateLayers()
` `public void setMergeDuplicateLayers(boolean value)
` `public boolean getMergeDuplicateOutlines()
` `public void setMergeDuplicateOutlines(boolean value)
` `public boolean getPreserveUserRights()
` `public void setPreserveUserRights(boolean value)
` `public boolean getIncrementalUpdates()
` `public void setIncrementalUpdates(boolean value)
` `public boolean getOptimizeSize()
` `public void setOptimizeSize(boolean value)
` `public static ContentsResizeParameters pageResize(double width, double height)
` `public static ContentsResizeParameters pageResizePct(double widthPct, double heightPct)
` `public boolean concatenate(Document[] src, Document dest)
` `public void splitToPages(String inputFile, String fileNameTemplate)
` `public void splitToPages(InputStream inputStream, String fileNameTemplate)

com.aspose.pdf.facades.APdfFileStamp 

added:
` `public boolean getOptimizeSize()
` `public void setOptimizeSize(boolean value)
` `public int getStampId()
` `public void setStampId(int value)

com.aspose.pdf.facades.AutoFiller 

implements ISaveableFacade

next methods were marked as @Deprecated:
` `void setOutputStreamInternal(Stream value)
` `public String getInputFileName() 
` `public void setInputFileName(String value)
` `public String getOutputFileName() 
` `public void setOutputFileName(String value)
` `public void save()

added:
` `public InputStream getInputStream() 
` `public void setInputStream(InputStream value)
` `public void save(String destFile)
` `public void save(OutputStream destStream)
` `public void bindPdf(String srcFile)
` `public void bindPdf(InputStream srcStream)
` `public void bindPdf(IDocument srcDoc)
` `public void close()


com.aspose.pdf.facades.Facade 

added:
` `public  void bindPdf(InputStream srcStream, String password)

com.aspose.pdf.facades.Form 

added:

` `internal public static  final class ImportStatus

com.aspose.pdf.facades.FormFieldFacade 

` `next constant were marked as @Deprecated:
` `public static final float BORDER_WIDTH_UNDIFIED = 0;

` `added:
` `public static final float BORDER_WIDTH_UNDEFINED = -1;


com.aspose.pdf.facades.PdfAnnotationEditor 

` `extends SaveableFacade

` `added:

` `public void importAnnotationFromXfdf(InputStream xfdfSteam, int[] annotType)

` `public void importAnnotationFromXfdf(InputStream xfdfSteam)

` `public void exportAnnotationsXfdf(OutputStream xmlOutputStream, int start, int end, String[] annotTypes)

` `public void exportAnnotationsXfdf(OutputStream xmlOutputStream, int start, int end, int[] annotTypes)

com.aspose.pdf.facades.PdfBookmarkEditor 

extends SaveableFacade

com.aspose.pdf.facades.PdfConverter 

added:

` `public boolean getShowHiddenAreas()

` `public void setShowHiddenAreas(boolean value)

com.aspose.pdf.facades.PdfFileEditor 

added:

` `public static final String E_EMPTY_PAGE_RANGE = "Page ranges array is not set";

` `public static final String E_SMALL_PAGE_RANGE = "Page range array must have two elements";

` `public static final String E_WRONG_PAGE_RANGE = "Invalid page range";

` `public boolean concatenate(Document[] src, Document dest)

` `public boolean resizeContents(InputStream source, OutputStream destination, int[] pages, ContentsResizeParameters parameters)

` `public boolean resizeContents(InputStream source, OutputStream destination, int[] pages, 

` `public boolean resizeContentsPct(InputStream source, OutputStream destination, int[] pages, double newWidth, double newHeight)

` `public boolean addMargins(InputStream source, OutputStream destination, int[] pages, double leftMargin, double rightMargin, double topMargin, double bottomMargin)

` `public boolean addMarginsPct(InputStream source, OutputStream destination, int[] pages, double leftMargin, double rightMargin, double topMargin, double bottomMargin)

com.aspose.pdf.facades.PdfFileInfo 

extends SaveableFacade

added:

` `public java.util.Map getHeader() 

` `public void setHeader(java.util.Map value) 

` `public void save(OutputStream destStream)  

next constant were marked as @Deprecated:

` `public String getInputFile() 

` `public void setInputFile(String value)

` `public InputStream getInputStream() 

` `public void setInputStream(InputStream value)

com.aspose.pdf.facades.PdfFileSecurity 

extends SaveableFacade 

next methods were marked as @Deprecated:

` `public void setOutputFile(String value) 

` `public PdfFileSecurity(String inputFile, String outputFile)

` `public PdfFileSecurity(IDocument document, String outputFile) 

` `public PdfFileSecurity(IDocument document, OutputStream outputStream)

added:

` `public void bindPdf(String srcFile)

` `public void bindPdf(InputStream srcStream)

` `public void close()

com.aspose.pdf.facades.PdfFileSignature 

extends SaveableFacade

next constant were marked as @Deprecated:

` `public PdfFileSignature(String inputFile)

` `public PdfFileSignature(String inputFile, String outputFile)

` `public void save()

added:

` `public void removeSignature(String signName, boolean removeField) 

` `public java.util.Date getDateTime(String signName)

com.aspose.pdf.facades.PdfPageEditor 

added:

` `public java.util.Map getPageRotations()

` `public java.util.Map getPageRotations()

` `public int getHorizontalAlignment() 

` `public void setHorizontalAlignment(int value)

` `public int getVerticalAlignmentType() 

` `public void setVerticalAlignmentType(int value)

` `public java.awt.Rectangle getPageBoxSize(int page, String pageBoxName)

` `public void applyChanges()

next constant were marked as @Deprecated:

` `public AlignmentType getAlignment()

` `public void setAlignment(AlignmentType value)

` `public VerticalAlignmentType getVerticalAlignment()

` `public void setVerticalAlignment(VerticalAlignmentType value)

removed:

` `public void setAlignment(AlignmentType value)

com.aspose.pdf.facades.PdfViewer 

added:
` `public boolean getShowHiddenAreas()

` `public void setShowHiddenAreas(boolean value)

` `public int getCopiesPrinted()

` `public void printLargePdf(InputStream inputStream, PrinterSettings printerSettings)

` `public void printLargePdf(InputStream inputStream, PageSettings pageSettings, PrinterSettings printerSettings)

` `public void bindPdf(InputStream srcStream)

com.aspose.pdf.facades.VerticalAlignmentType 

was marked as @Deprecated

com.aspose.pdf.generator.legacyxmlmodel.EndNote 

renamed:
` `getNumberingContinuation_EndNote_New() to getNumberingContinuation()
` `setNumberingContinuation_EndNote_New() to setNumberingContinuation()

com.aspose.pdf.generator.legacyxmlmodel.Image 

added:
` `public  void load(XmlTextReader xmlReader, LoadingContext context)

com.aspose.pdf.generator.legacyxmlmodel.LegacyPdf 

added:

` `public int InconsistentXmlImageParamsHandlingType;

com.aspose.pdf.generator.legacyxmlmodel.Table 

added:

` `public int getColumnCount()

com.aspose.pdf.text.Font 

removed since it dublicates com.aspose.pdf.Font 

com.aspose.pdf.ADocument 

added:

` `public boolean isPdfaCompliant()

` `public int getPdfaFormat() 

com.aspose.pdf.Annotation 

added:

` `public int getHorizontalAlignment_Annotation_New() 

` `public void setHorizontalAlignment_Annotation_New(int value)

next constant were marked as @Deprecated:

` `public int getAlignment() 

` `public void setAlignment(int value)

com.aspose.pdf.AnnotationActionCollection 

added:

` `public PdfAction getOnModifyCharacter()

` `public void setOnModifyCharacter(PdfAction value)

` `public PdfAction getOnValidate()

` `public void setOnValidate(PdfAction value)

` `public PdfAction getOnFormat()

` `public void setOnFormat(PdfAction value)

` `public PdfAction getOnCalculate()

` `public void setOnCalculate(PdfAction value)

com.aspose.pdf.ApsToPdfConverter 

added:

` `public  void visitFormFieldButton(ApsButton field)

com.aspose.pdf.BackgroundArtifact 

added:

`  `public java.awt.Color getBackgroundColor()

`  `public void setBackgroundColor(java.awt.Color value)

com.aspose.pdf.BaseParagraph 

added:

` `public int getHorizontalAlignment()

com.aspose.pdf.BorderInfo 

`  `changes:

`  `public CellBorderStyle getLeft() -> public GraphInfo getLeft()

`  `public void setLeft(CellBorderStyle value) -> public void setLeft(GraphInfo value)

`  `public CellBorderStyle getRight() -> public GraphInfo getRight()

`  `public void setRight(CellBorderStyle value) -> public void setRight(GraphInfo value)

`  `public CellBorderStyle getTop() -> public GraphInfo getTop()

`  `public void setTop(CellBorderStyle value) -> public void setTop(GraphInfo value)

`  `public BorderInfo(int borderSide, CellBorderStyle borderStyle) -> public BorderInfo(int borderSide, GraphInfo borderStyle)



`  `added:

`  `public GraphInfo getBottom()

`  `public void setBottom(GraphInfo value)  public double getRoundedBorderRadius()

`  `public void setRoundedBorderRadius(double value)

`  `removed:

`  `public CellBorderStyle getBottom()

`  `public void setBottom(CellBorderStyle value)

`  `public double getRoundedBorderRadius()

`  `public void setRoundedBorderRadius(double value)

com.aspose.pdf.BuildVersionInfo 

renamed:

` `Assembly_version -> AssemblyVersion

` `File_version -> FileVersion

com.aspose.pdf.ButtonField 

added:

` `public ButtonField() 

com.aspose.pdf.CellBorderStyle 

class was removed

com.aspose.pdf.CheckboxField 

added:

` `public java.util.ArrayList getAllowedStates()

` `public String getOnState() 

com.aspose.pdf.ComboBoxField 

added:

` `public ComboBoxField()

com.aspose.pdf.Field 

added:

` `public int getPageIndex()

` `public static boolean getFitIntoRectangle()

` `public static void setFitIntoRectangle(boolean value)

com.aspose.pdf.FitBExplicitDestination 

next constant were marked as @Deprecated:

` `public FitBExplicitDestination(Document document, int pageNumber) 

` `added:

` `public FitBExplicitDestination(int pageNumber)

com.aspose.pdf.FitBHExplicitDestination 

next constant were marked as @Deprecated:

` `public FitBHExplicitDestination(Document document, int pageNumber, double top)

added:

` `public FitBHExplicitDestination(int pageNumber, double top)

com.aspose.pdf.FitBVExplicitDestination 

next constant were marked as @Deprecated:

` `public FitBVExplicitDestination(Document document, int pageNumber, double left)

added:

` `public FitBVExplicitDestination(int pageNumber, double left)

com.aspose.pdf.FitHExplicitDestination

next constant were marked as @Deprecated:

` `public FitHExplicitDestination(Document document, int pageNumber, double top)

added:

` `public FitHExplicitDestination(int pageNumber, double top)

com.aspose.pdf.FitRExplicitDestination 

next constant were marked as @Deprecated:

` `public FitRExplicitDestination(Document document, int pageNumber, double left, double bottom, double right, double top)

added:

` `public FitRExplicitDestination(int pageNumber, double left, double bottom, double right, double top)

com.aspose.pdf.FitVExplicitDestination 

next constant were marked as @Deprecated:

` `public FitVExplicitDestination(Document document, int pageNumber, double left)

added:

` `public FitVExplicitDestination(int pageNumber, double left)

com.aspose.pdf.FontRepository 

` `added:
` `public static FontSubstitutionCollection getSubstitutions() 
` `public static FontSourceCollection getSources()
` `public static Font openFont(InputStream fontStream,int fontType)


com.aspose.pdf.FontSource 

changes:

` `public abstract FontDefinition[] getFontDefinitions() - > abstract FontDefinition[] getFontDefinitions()

com.aspose.pdf.Form 

changes:

` `com.aspose.pdf.Form.getFields_Rename_Namesake() - renamed to: com.aspose.pdf.Form.getFields();

added:

`  `public void setType(int value)

`  `public void add(Field field)

`  `public void addFieldAppearance(Field field, int pageNumber, Rectangle rect)

com.aspose.pdf.FreeTextAnnotation 

added:

` `public int getStartingStyle()

` `public void setStartingStyle(int value)

` `public int getEndingStyle()

` `public void setEndingStyle(int value)

` `public DefaultAppearance getDefaultAppearanceObject()

com.aspose.pdf.HtmlSaveOptions 

` `added inner classes:
` `public static  final class HtmlImageType
` `public static class HtmlImageSavingInfo
` `public static class CssSavingInfo
` `public static class CssUrlRequestInfo
` `public interface ResourceSavingStrategy
` `public interface CssUrlMakingStrategy
` `public interface CssSavingStrategy

com.aspose.pdf.ImagePlacement 

added:

` `public int getRotation()

` `public void save(OutputStream outputStream)

` `public void save(OutputStream outputStream,ImageFormat format)

com.aspose.pdf.ListBoxField 

added:

` `public ListBoxField()

com.aspose.pdf.LoadOptions 

added:

` `public IWarningCallback getWarningHandler()

` `public void setWarningHandler

` `public String ApsIntermediateFileIfAny;

` `public String XpsIntermediateFileIfAny;

com.aspose.pdf.MarkupAnnotation 

added:

` `public java.util.Date getCreationDate()

com.aspose.pdf.Matrix 

added:

` `public IPdfArray getMatrix(ITrailerable trailer)

com.aspose.pdf.Page 

implements ISupportsMemoryCleanup

added:

` `public void setBackground(Color value) 

com.aspose.pdf.PageCollection 

added:

` `public int indexOf(Page entity)

com.aspose.pdf.PageLabelCollection 

changes:

` `UpdateLabel  -> updateLabel

` `RemoveLabel -> removeLabel

` `GetPages      -> getPages

com.aspose.pdf.PageSize 

added:

` `public static final float LEAVE_INTACT = -1; 

com.aspose.pdf.RichTextBoxField 

added:

` `public RichTextBoxField(Page page, java.awt.Rectangle rect)  

com.aspose.pdf.SaveOptions 

added inner classes:

` `public static  final class HtmlBorderLineType

` `public static class BorderPartStyle

` `public static class BorderInfo

` `public static  final class NodeLevelResourceType

` `public static class ResourceSavingInfo

added:

` `public IWarningCallback getWarningHandler()

` `public void setWarningHandler(IWarningCallback value) 

` `public boolean getCloseResponse()

` `public void setCloseResponse(boolean value) 

com.aspose.pdf.Signature 

added:

` `public java.util.Date getDate()

` `public void setDate(java.util.Date value)

` `public Signature(InputStream pfx, String password) 

com.aspose.pdf.SignatureField 

added:

` `public void sign(Signature signature,InputStream pfx, String pass)

` `public void clear()

com.aspose.pdf.Stamp 

added:

` `public double getZoomX()

` `public void setZoomX(double value)

` `public  double getWidth()

` `public  void setWidth(double value)

` `public  double getHeight()

` `public  void setHeight(double value)

` `public double getZoomY()

` `public void setZoomY(double value)

com.aspose.pdf.SvgSaveOptions 

added inner classes:

` `public interface EmbeddedImagesSavingStrategy

` `public static  final class SvgExternalImageType

` `public static class SvgImageSavingInfo 

added:

` `public EmbeddedImagesSavingStrategy CustomStrategyOfEmbeddedImagesSaving 

com.aspose.pdf.TextParagraph 

added:

` `public float getSubsequentLinesIndent()

` `public void setSubsequentLinesIndent(float value) 

com.aspose.pdf.TextSearchOptions 

added:

` `public void isRegularExpressionUsed(boolean value)

com.aspose.pdf.TextStamp 

added:

` `public boolean getWordWrap()

` `public void setWordWrap(boolean value)

` `public boolean getJustify()

` `public void setJustify(boolean value)

` `public boolean getScale()

` `public void setScale(boolean value)

` `public  double getWidth()

` `public  void setWidth(double value)

` `public  double getHeight()

` `public  void setHeight(double value)

com.aspose.pdf.TextState 

added:

` `TextState( java.awt.Color backgroundColor, java.awt.Color foregroundColor, int fontStyle, Font font, float fontSize)

changes:

` `public java.awt.Color getForegroundColor() -> public com.aspose.pdf.Color getForegroundColor() 

` `public void setForegroundColor(java.awt.Color value) -> public void setForegroundColor(com.aspose.pdf.Color value)

` `public java.awt.Color getBackgroundColor() -> public com.aspose.pdf.Color getBackgroundColor() 

` `public void setBackgroundColor(java.awt.Color value) -> public void setBackgroundColor(com.aspose.pdf.Color value)

com.aspose.pdf.TextStyle 

next methods were marked as @Deprecated:

` `public void setAlignment(int value)

` `public int getAlignment() 

added:

` `public void setHorizontalAlignment(int value)

` `public int getHorizontalAlignment()

` `public java.awt.Color getColor()

` `public void setColor(java.awt.Color value)

com.aspose.pdf.XfdfReader 

added:

` `public static  void readAnnotations(InputStream stream,IDocument document)

` `public static  void readFields(InputStream stream,Document document)

` `public static java.util.Map getElements(XmlReader reader)

changes:

` `public static void readFields(Stream stream, IDocument document) -> public static void readFields(Stream stream, IDocument document, IList foundFields, IList notFoundFields)

com.aspose.pdf.XfdfTags 

added:

` `public static final String CalloutLine = "callout-line";

` `public static final String TextRectangle = "text-recangle";

com.aspose.pdf.XslFoLoadOptions 

added:

` `public boolean isUseOldXslFoEngine() 

` `public void setUseOldXslFoEngine(boolean useOldXslFoEngine) 

com.aspose.pdf.XYZExplicitDestination 

next methods were marked as @Deprecated:

` `public XYZExplicitDestination(Document document, int pageNumber, double left, double top, double zoom)

added:

` `public XYZExplicitDestination(int pageNumber, double left, double top, double zoom)

Back in version 4.4.0 were created some "enum" classes to replace ms libraries, and starting the release 4.6.0, we had to remove all ms-classes them from public access. Therefore it is necessary to use internal wrappers.

This applies to the following classes:

com.aspose.pdf.HtmlDocumentTypeInternal - instead com.aspose.html.HtmlDocumentType
com.aspose.pdf.ImageFormatInternal - instead com.aspose.ms.System.Drawing.Imaging.ImageFormat
com.aspose.pdf.TextEncodingInternal - instead com.aspose.ms.System.Text.TextEncoding
