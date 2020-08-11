---
title: Public API Changes in Aspose.PDF for Java 10.1.0
type: docs
weight: 100
url: /java/public-api-changes-in-aspose-pdf-for-java-10-1-0/
---

{{% alert color="primary" %}} 

This page lists the public API changes introduced in [Aspose.PDF for Java 10.1.0](http://www.aspose.com/community/files/72/java-components/aspose.pdf-for-java/entry615512.aspx). It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.PDF for Java which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

{{% /alert %}} 

**Public API and Backwards Incompatible Changes**
#### **Added new exception classes:**
- com.aspose.pdf.exceptions.UnsupportedFontTypeException
- com.aspose.pdf.exceptions.InvalidFormTypeOperationException
- com.aspose.pdf.exceptions.InvalidCgmFileFormatException
#### **com.aspose.pdf.facades.PdfViewer**
*Added methods:*

- public boolean getUseIntermidiateImage()
- public void setUseIntermidiateImage(boolean value)
#### **com.aspose.pdf.XForm**
*Added method:*

- public void freeMemory()
#### **com.aspose.pdf.TextSearchOptions**
*Added methods:*

- public boolean getUseFontEngineEncoding()
- public void setUseFontEngineEncoding(boolean value)
#### **com.aspose.pdf.TextEditOptions**
*Added methods:*

- public TextEditOptions(boolean allowLanguageTransformation)
- public boolean getAllowLanguageTransformation()
- public void setAllowLanguageTransformation(boolean value)
#### **com.aspose.pdf.Page**
*Added methods:*

- public void processParagraphs()
- public void dispose()
#### **com.aspose.pdf.IDocument**
*Added methods:*

- public void processParagraphs();
#### **com.aspose.pdf.Document**
*Added methods:*

- public void processParagraphs();
#### **com.aspose.pdf.DocSaveOptions**
*Added methods:*

- public boolean getAddReturnToLineEnd()
- public void setAddReturnToLineEnd(boolean value)
#### **com.aspose.pdf.HtmlDocumentTypeInternal - removed.**
