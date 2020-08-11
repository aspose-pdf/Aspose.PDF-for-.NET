---
title: Aspose.Pdf for Java 17.11 Release Notes
type: docs
weight: 20
url: /java/aspose-pdf-for-java-17-11-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-37154|An exception has thrown in a multi-threaded environment.|Bug|
|PDFJAVA-37137|Named destinations are lost when processing bookmarks.|Bug|
|PDFJAVA-37250|PDF cropping problem.|Bug|
|PDFJAVA-37135|PDF to PDF/A-2U - does not highlight target phrase after search.|Bug|
|PDFJAVA-35181|Text Replace - Underline property does not work in text replace functionality.|Bug|
|PDFJAVA-36227|Replacing Text Causes Text to Go Off-screen.|Bug|
|PDFJAVA-35491|PDF to PNG - Conversion is slow.|Bug|
|PDFJAVA-37138|Null pointer exception occurs when calling flatten.|Bug|
|PDFJAVA-37078|A null pointer error occurred on getting form fields.|Bug|
### **Public API changes**
Changes in class **com.aspose.pdf.BaseParagraph** 
Added method:
public /* VerticalAlignment */int getVerticalAlignment()

Added new class **com.aspose.pdf.DefaultDirectory** 
methods:
public static String getDefaultDirectory()
public static void setDefaultDirectory(String value)

Added new class **com.aspose.pdf.HideAction** 
constructors:
public HideAction(Annotation annotation)
public HideAction(Annotation annotation, boolean isHidden)
public HideAction(String fieldName)
public HideAction(String fieldName, boolean isHidden)
public HideAction(Annotation[] annotations)
public HideAction(Annotation[] annotations, boolean isHidden)
public HideAction(String[] names)
public HideAction(String[] names, boolean isHidden)
methods:
public boolean isHidden()
public void setHidden(boolean value)

Changes in class **com.aspose.pdf.MemoryExtender** 
Added methods:
public static boolean isSkipHeavyContentEnabled()
public static void setSkipHeavyContentEnabled(boolean value)
public static CallBackPageImage getCallBackPageImage()
public static void setCallBackPageImage(CallBackPageImage callBackPageImage)
public static boolean isEnabledMultiPageImageCache()
public static void setEnableMultiPageCache(boolean enableMultiPageImageCache)
Added internal interface:
public interface **CallBackPageImage**

Changes in class **com.aspose.pdf.SignatureField** 
Added method:
public InputStream extractImage(ImageType format)

Changes in class **com.aspose.pdf.TextFormattingOptions** 
added constructor:
public TextFormattingOptions()

Changes in class **com.aspose.pdf.TextFormattingOptions.WordWrapMode** 
added field:
public static final int Undefined = 3;

Changes in class **com.aspose.pdf.TextReplaceOptions** 
added constructor:
public TextReplaceOptions()

Changes in class **com.aspose.pdf.TocInfo** 
Added methods:
public boolean isShowPageNumbers()
public void setShowPageNumbers(boolean value)

Changes in class **com.aspose.pdf.XFA** 
Added method:
public String tryGetTemplateString(String value)
