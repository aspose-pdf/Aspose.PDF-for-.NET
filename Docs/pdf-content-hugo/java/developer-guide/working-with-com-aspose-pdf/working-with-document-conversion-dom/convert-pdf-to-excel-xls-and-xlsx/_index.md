---
title: Convert PDF to Excel XLS and XLSX
type: docs
weight: 80
url: /java/convert-pdf-to-excel-xls-and-xlsx/
---

## **Convert PDF to Excel XLS and XSLX in Java**
Aspose.PDF for Java API lets you render your PDF files to Excel [XLS](https://wiki.fileformat.com/spreadsheet/xls/) and [XLSX](https://wiki.fileformat.com/spreadsheet/xlsx/) file formats. We already have another API, known as [Aspose.Cells for Java](https://products.aspose.com/cells/java), that provides the capability to create and manipulate existing Excel workbooks. It also provides the capability to transform Excel workbooks to PDF format.
### **Convert PDF to Excel XLS**
To convert PDF files to XLS format, Aspose.PDF has a class called [ExcelSaveOptions](https://apireference.aspose.com/java/pdf/com.aspose.pdf/ExcelSaveOptions). An object of the [ExcelSaveOptions](https://apireference.aspose.com/java/pdf/com.aspose.pdf/ExcelSaveOptions) class is passed as a second argument to the Document.Save(..) constructor. The following code snippet shows the process for converting a PDF file into XLS format.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertPDFToExcelWorkbook-.java" >}}
### **Convert PDF to Excel XLSX**
Converting a PDF file into XLSX format is part of the library from Aspose.PDF for Java 18.6 version. In order to convert PDF files to XLSX format, you need to set format as XLSX using **setFormat()** method of **ExcelSaveOptions** Class. Following code snippet shows how to convert a PDF file into .xlsx format:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-CovertPDFtoXLSX.java" >}}
