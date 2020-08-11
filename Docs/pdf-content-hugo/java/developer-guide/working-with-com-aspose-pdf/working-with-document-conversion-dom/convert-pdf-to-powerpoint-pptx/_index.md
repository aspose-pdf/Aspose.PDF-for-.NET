---
title: Convert PDF to PowerPoint PPTX
type: docs
weight: 90
url: /java/convert-pdf-to-powerpoint-pptx/
---

We have an API named [Aspose.Slides](https://products.aspose.com/slides/java) which offers the feature to create as well as manipulate PPT/PPTX presentations. This API also provides the feature to convert PPT/PPTX files to PDF format. In Aspose.PDF for Java, we have introduced a feature to transform PDF documents into PPTX format. During this conversion, the individual pages of the PDF file are converted to separate slides in the PPTX file.
## **Convert PDF to PPTX using Java**
During PDF to PPTX conversion, the text is rendered as Text where you can select/update it, instead of its rendered as an image. Please note that in order to convert PDF files to PPTX format, Aspose.PDF provides a class named PptxSaveOptions. An object of the PptxSaveOptions class is passed as a second argument to the [Document](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Document).save(..) method. The following code snippet shows the process for converting PDF files into PPTX format.

|![todo:image_alt_text](http://i.imgur.com/htHaEpP.png)|
| :- |
{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertPDFToPPTX-.java" >}}
