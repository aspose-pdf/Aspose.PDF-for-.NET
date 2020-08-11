---
title: Aspose.Pdf for Java 17.5 Release Notes
type: docs
weight: 80
url: /java/aspose-pdf-for-java-17-5-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-36696|Support RichMediaAnnotation|New Feature|
|PDFJAVA-34399|Check compatibility of Aspose.PDF for Java with Grails|Bug|
|PDFJAVA-34733|Multi-page tiff to PDF with portrait orientation loses fidelity|Bug|
|PDFJAVA-34819|PDF to HTML - Space and positioning issues|Bug|
|PDFJAVA-34860|PDF to HTML conversion loses the text|Bug|
|PDFJAVA-34862|PDF to HTML: TOC links are lost in output HTML|Bug|
|PDFJAVA-34926|Support of Docker platform|Bug|
|PDFJAVA-34933|Support of Oracle Agile Product Lifecycle Management application|Bug|
|PDFJAVA-35416|License not working with Apache server|Bug|
|PDFJAVA-35562|Image to PDF - Image output is not correct in PDF|Bug|
|PDFJAVA-35579|PDF to HTML results into incorrect text|Bug|
|PDFJAVA-35607|PDF creation process keeps running and never stops|Bug|
|PDFJAVA-35748|PDF to PDFA1B: compliance failure due to transparency in the document|Bug|
|PDFJAVA-35788|PDF to PDF/A - Resultant file is not compliant|Bug|
|PDFJAVA-35814|PDF to Image conversion loses the text|Bug|
|PDFJAVA-36325|HighlightAnnotation background color issue with QuadPoint array|Bug|
|PDFJAVA-36578|PDF to Image hangs for ever|Bug|
|PDFJAVA-36669|Text appearing on wrong location after placing inside PDF|Bug|
|PDFJAVA-36685|Highlight Annotation background color Problem|Bug|
|PDFJAVA-36708|PDFA gets corrupted when setOptimizeFileSize is used|Bug|
|PDFJAVA-36727|Aspose.PDF 17.4 exception throws when getting character by index|Bug|
|PDFJAVA-36728|HTML to PDF - Ambiguous mismatch exception|Bug|
|PDFJAVA-36785|getMeasure() method is missing in PolyAnnotation class|Bug|
|PDFJAVA-36621|When PDF is converted to PDFA, the word in text is messed up.|Bug|
|PDFJAVA-36387|PDF to PDFA: decrease in quality of transparent images|Bug|
### **Public API Changes in Aspose.PDF for Java 17.5**


Added new class com.aspose.pdf.Document.**FontSubsetStrategy** with the following fields:

public static final byte SubsetEmbeddedFontsOnly = 0;
public static final byte SubsetAllFonts = 1;

Added new interface com.aspose.pdf.Document.**IDocumentFontUtilities** with the following method:

public void subsetFonts(/* FontSubsetStrategy */byte subsetStrategy);

Added new exception class com.aspose.pdf.exceptions.**IncorrectCMapUsageException** with the following constructor:

M:com.aspose.pdf.exceptions.IncorrectCMapUsageException.#ctor(String)

Changes in class com.aspose.pdf.exceptions.**PdfException**:

Added constructor:
public PdfException(String message, java.lang.Throwable innerException)


Changes in class com.aspose.pdf.facades.**PdfViewer**:

**Added methods:** 
public boolean getPrintAsGrayscale()
public void setPrintAsGrayscale(boolean value)

Changes in class com.aspose.pdf.**Font**:

**Added method:** 
public String getType()

Added new class com.aspose.pdf.**Opi** with the following methods:

public Opi(XForm xform)
public String getFileSpecification()
public double[] getPosition()
public String getVersion()

Changes in class com.aspose.pdf.**Page**:

**Added method:
**public boolean isBlank(double fillThresholdFactor)

Added new class com.aspose.pdf.**PdfASymbolicFontEncodingStrategy** with the following methods:

public PdfASymbolicFontEncodingStrategy()
public PdfASymbolicFontEncodingStrategy(/* CMapEncodingTableType */short preferredEncodingTable)
public/* CMapEncodingTableType */short getPreferredCmapEncodingTable()
public void setCmapEncodingTablesPriorityQueue(Queue<QueueItem> value)
public void setPreferredCmapEncodingTable(/* CMapEncodingTableType */short value)

Added new class com.aspose.pdf.PdfASymbolicFontEncodingStrategy.**QueueItem** with the following methods:

public QueueItem()
public QueueItem(int platformID, int platformSpecificID)
public QueueItem(/* CMapEncodingTableType */short cmapTable)
public /* CMapEncodingTableType */ short getCMapEncodingTable()
public void setCMapEncodingTable(/* MapEncodingTableType */short value)
public int getPlatformID()
public void setPlatformID(int value)
public int getPlatformSpecificID()
public void setPlatformSpecificID(int value)

Added new enum class com.aspose.pdf.PdfASymbolicFontEncodingStrategy.QueueItem.**CMapEncodingTableType** with the following fields:

public static final short WindowsUnicodeTable = 0;
public static final short WindowsSymbolicTable = 1;
public static final short MacTable = 2;
public static final short UnicodeTable = 3;

Changes in class com.aspose.pdf.**PolyAnnotation**:

**Added methods:
**public Measure getMeasure()
public void setMeasure(Measure value)

Changes in class com.aspose.pdf.**Rectangle**:

**Added method:
**public Rectangle join(Rectangle otherRect)

Changes in class com.aspose.pdf.**TextFragmentState**:

**Added methods:
**public TextFormattingOptions getFormattingOptions()
public void setFormattingOptions(TextFormattingOptions value)
public double getRotation()
public void setRotation(double value)

Changes in class com.aspose.pdf.**TextParagraph**:

**Added methods:
**public double getRotation()
public void setRotation(double value)

Changes in class com.aspose.pdf.**XForm**:

Added method:
public Opi getOpi()
