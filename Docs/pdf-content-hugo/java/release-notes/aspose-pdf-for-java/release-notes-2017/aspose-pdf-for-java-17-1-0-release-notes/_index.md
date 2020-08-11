---
title: Aspose.Pdf for Java 17.1.0 Release Notes
type: docs
weight: 120
url: /java/aspose-pdf-for-java-17-1-0-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-34502|LaTeX to PDF support|New Feature|
|PDFJAVA-35949|PDF to PDFA: distorted image|Bug|
|PDFJAVA-36338|PDF to PPTX - Some text is absent|Bug|
|PDFJAVA-34864|PDF to HTML - Text is not properly being rendered|Bug|
|PDFJAVA-35352|Latex to PDF throws internal exception|Bug|
|PDFJAVA-35551|HTML to PDF: incorrect alignment of the page contents|Bug|
|PDFJAVA-35007|PDF to DOCX throws StringIndexOutOfBoundsException|Bug|
|PDFJAVA-34445|PDF to DOC: formatting of half table is lost|Bug|
|PDFJAVA-33152|Problems in PCL to PDF conversion|Bug|
|PDFJAVA-36261|TIFF to PDF - Conversion takes too much time|Bug|
|PDFJAVA-36266|PDF to XPS: Transparent rectangle rendering issue|Bug|
|PDFJAVA-35619|NullPointerException when encrypting documents from different threads|Bug|
|PDFJAVA-36371|While converting PDF to docx TOO MANY OPEN FILES error occurs|Bug|
### **Public API Changes in Aspose.PDF for Java 17.1.0**
Changes in class **com.aspose.pdf.drawing.Shape**:

Added methods:

- public TextFragment getText()
- public void setText(TextFragment value)

Changes in class **com.aspose.pdf.HtmlSaveOptions**:

Added methods:

- public boolean getDisableImageSelection()
- public void setDisableImageSelection(boolean value)

Changes in class **com.aspose.pdf.LevelFormat**:

Added methods:

- public /* TabLeaderType */int getLineDash()
- public void setLineDash(/* TabLeaderType */int value)

Changes in class **com.aspose.pdf.RenderingOptions**:

Added methods:

- public boolean getConvertFontsToUnicodeTTF()
- public void setConvertFontsToUnicodeTTF(boolean value)

Changes in class **com.aspose.pdf.Table**:

Added methods:

- public TextFragment getBreakText()
- public void setBreakText(TextFragment value)

Changes in class **com.aspose.pdf.TextStamp**:

Added methods:

- public double getMaxRowWidth()
- public void setMaxRowWidth(double value)

Changes in class **com.aspose.pdf.XImage**:

Added methods:

- public boolean isTheSameObject(XImage image)
- public String getNameInCollection()

Changes in class **com.aspose.pdf.XImageCollection**:

Added methods:

- public String add(XImage image)
- public String getImageName(XImage image)
