---
title: Aspose.Pdf for Java 16.10.0 Release Notes
type: docs
weight: 30
url: /java/aspose-pdf-for-java-16-10-0-release-notes/
---

### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|PDFJAVA-36204 |Html to PDF: display CSS tag is not being honored |Bug |
|PDFJAVA-35992 |HTML to PDF - Conversion process hangs |Bug |
|PDFJAVA-36208 |Breaking change in TableAbsorber |Bug |
|PDFJAVA-36179 |NullPointerException when executing PDF optimization in parallel. |Bug |
|PDFJAVA-36098 |PDF to JPEG results blank image |Bug |
|PDFNEWJAVA-34609 |Import of annotations from XFDF to PDF |Bug |
|PDFNEWJAVA-35819 |Digital signature with TimeStamp Server is not working |Bug |
|PDFNEWJAVA-34870 |PDF to PDFA2b: Converting PDF, generated from Aspose.Cells, to PDFA2b fails the compliance |Bug |
|PDFNEWJAVA-35196 |PDF to PDFA3b: resultant PDFA3b does not pass the compliance |Bug |
|PDFNEWJAVA-35195 |PDF to PDFA3a: resultant PDFA3a does not pass the compliance |Bug |
|PDFNEWJAVA-35185 |PDF to PDF/A_2a - Resultant file is not compliant |Bug |
|PDFNEWJAVA-35186 |PDF to PDF/A_2b - Resultant file is not compliant |Bug |
|PDFNEWJAVA-34871 |PDF to PDFA3b: Converting PDF, generated from Aspose.Cells, to PDFA3b fails the compliance |Bug |
### **Public API Changes**
Changes in class **com.aspose.pdf.AnnotationType**:

added constant:
public static final int RichMedia = 25;
changed constant:
from
public static final int Unknown = 25;
to
public static final int Unknown = 26;

Changes in class **com.aspose.pdf.LaTeXSaveOptions:**

added method:

- public void addFontEncs( String... fontEncs)
- public void clearFontEncs()

Added new class **com.aspose.pdf.Metered** with the default constructor and the following methods:

- public void setMeteredKey(String publicKey, String privateKey)
- public static java.math.BigDecimal getConsumptionQuantity()

Changes in class **com.aspose.pdf.Page**:

added method:

- public String asXml()

Changes in class **com.aspose.pdf.TextSegment**:

added method:

- public static void redactText(XForm form, Rectangle rect)

Changes in class **com.aspose.pdf.TextSegment**:

added method:

- public int getStartCharIndex()

Changes in class **com.aspose.pdf.TocInfo**:

added methods:

- public /* TabLeaderType */int getLineDash()
- public void setLineDash(/* TabLeaderType */int value)

Added the following **Classes**:

- com.aspose.pdf.groupprocessor.creators.PdfTypeObjectCreator
- com.aspose.pdf.groupprocessor.ExtractorFactory
- com.aspose.pdf.groupprocessor.TextExtractor
- com.aspose.pdf.groupprocessor.interfaces.IDocumentMetadataExtraxtor
- com.aspose.pdf.groupprocessor.interfaces.IPdfTypeExtractor
- com.aspose.pdf.groupprocessor.interfaces.IDocumentTextExtractor
- com.aspose.pdf.groupprocessor.interfaces.IDocumentPageTextExtractor
