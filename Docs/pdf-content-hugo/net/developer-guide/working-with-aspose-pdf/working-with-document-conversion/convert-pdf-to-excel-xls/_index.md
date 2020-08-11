---
title: Convert PDF to Excel XLS
type: docs
weight: 80
url: /net/convert-pdf-to-excel-xls/
---



Aspose.Cells for .NET provides the capability to create as well as manipulate existing Excel workbooks. It also provides the capability to transform Excel workbook to PDF format. As Aspose.PDF for .NET is a PDF manipulation component, we have introduced a feature that renders PDF file to Excel workbook ([XLS](https://wiki.fileformat.com/spreadsheet/xls/) files). During this conversion, the individual pages of the PDF file are converted to Excel worksheets.
## **Convert PDF to XLS**
{{% alert color="primary" %}} 

You can check the quality of Aspose.PDF conversion and view the results online at this link:

[products.aspose.app/pdf/conversion/pdf-to-xlsx](https://products.aspose.app/pdf/conversion/pdf-to-xlsx) {{% /alert %}} 

In order to convert PDF files to XLS format, Aspose.PDF has a class called ExcelSaveOptions. An object of the ExcelSaveOptions class is passed as a second argument to the Document.Save(..) constructor. The following code snippet shows the process for converting PDF file into XLS format.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToXLS-PDFToXLS.cs" >}}
### **Convert PDF to XLS with Control Column**
When converting a PDF to XLS format, a blank column is added to the output file as first column. The in ExcelSaveOptions class' InsertBlankColumnAtFirst option is used to control this column. Its default value is true.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToXLS-ControlColumn.cs" >}}
### **Convert PDF to Single Excel Worksheet**
When exporting a PDF file with a lot of pages to XLS, each page is exported to a different sheet in the Excel file. This is because the MinimizeTheNumberOfWorksheets property is set to false by default. To ensure that all pages are exported to one single sheet in the output Excel file, set the MinimizeTheNumberOfWorksheets property to true.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToXLS-ExportAllPagesToSingle.cs" >}}
