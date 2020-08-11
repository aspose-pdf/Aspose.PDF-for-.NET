---
title: Public API Changes in Aspose.PDF for Java 9.0.0
type: docs
weight: 30
url: /java/public-api-changes-in-aspose-pdf-for-java-9-0-0/
---

{{% alert color="primary" %}} 

This page lists the public API changes introduced in Aspose.PDF for Java 9.0.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.PDF for Java which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

{{% /alert %}} 
#### **Moved**
com.aspose.pdf.Text.FontSourceCollection moved to com.aspose.pdf.FontSourceCollection}
#### **Added**
- com.aspose.pdf.LoadFormat.MHT
- com.aspose.pdf.SoundSampleData
- com.aspose.pdf.SoundSampleDataEncodingFormat 
- com.aspose.security.impl.digests.Sha1
- com.aspose.security.impl.digests.Sha384 
- com.aspose.security.impl.digests.HashAlgorithm
#### **Changed Classes**
##### **com.aspose.pdf.facades.AForm**
**Added**

- java.util.Map getButtonOptionValues(String fieldName)
##### **com.aspose.pdf.IForm**
**Added**

- java.util.Map getButtonOptionValues(String fieldName)
##### **com.aspose.pdf.facades.PdfAnnotationEditor**
**Added**

- void importAnnotations(InputStream[] annotFileInputStream, int[] annotType)
- void importAnnotations(InputStream[] annotFileInputStream)
- void exportBookmarksToXML(OutputStream output)
- void importBookmarksWithXML(InputStream stream)
##### **com.aspose.pdf.facades.PdfFileSignature**
**Added**

- InputStream extractImage(String signName)
- InputStream extractCertificate(String signName)
##### **com.aspose.pdf.ApsToPdfConverter**
**Added**

- boolean getShowFieldsBorders()
- void setShowFieldsBorders(boolean value)
##### **com.aspose.pdf.DocumentInfo**
**Added**

- String getTrapped()
- void setTrapped(String value)
##### **com.aspose.pdf.LevelFormat**
**Added**

- float getSubsequentLinesIndent()
- void setSubsequentLinesIndent(float value)
##### **com.aspose.pdf.MarkupAnnotation**
**Added**

- public MarkupAnnotation()
##### **com.aspose.pdf.TextAnnotation**
**Added**

- public TextAnnotation()
##### **com.aspose.pdf.facades.PdfAnnotationEditor**
**Changed**

- void modifyAnnotations(int start, int end, Enum annotType, Annotation annotation) changed to void modifyAnnotations(int start, int end, int annotType, Annotation annotation)
- IList extractAnnotations(int start, int end, String[] annotTypes) changed to Iterable extractAnnotations(int start, int end, String[] annotTypes)
- ArrayList getAttachmentInfo() changed to Iterable PdfExtractor.getAttachmentInfo()
##### **com.aspose.pdf.Field**
**Changed**

- void recalculate() changed to boolean recalculate()
##### **com.aspose.pdf.TextState**
**Changed**

- boolean isFontSizeSet() changed to boolean getIsFontSizeSet()
- void isFontSizeSet(boolean value) changed to void setIsFontSizeSet(boolean value)
##### **com.aspose.pdf.BidiLine**
**Changed**

- static boolean hasRTLChar(String text) changed to static boolean containsRTLChar(String text)
##### **com.aspose.pdf.Element**
**Changed**

- getStructureType() is internalized similar to the .NET API.
- getgetAttributes() is internalized similar to .NET API.
