---
title: Add a Table
type: docs
weight: 10
url: /cpp/add-a-table/
---

## **Add Table to PDF using C++**
Tables in a PDF document organize data in rows and columns in a systematic manner. Aspose.PDF for C++ API lets you add tables to a PDF document, and add rows and columns to it in your C++ applications. The [Table](https://apireference.aspose.com/cpp/pdf/class/aspose.pdf.table/) class is used to add a table to the document. The following steps can be followed to add a table to a PDF document using C++.

1. Create a Document object
1. Add a Page to the pages collection of the document
1. Create a Table object using the MakeObject call
1. Add a table border using the BorderInfo class
1. Set properties of the table such as default cell color and column width
1. Add Rows to the Table
1. Add Cells to rows
1. Add table to the Document Paragraphs collection
1. Save PDF document to disc

{{< gist "aspose-com-gists" "75e8ca987a3e6221279259cfca4dccc9" "Examples-PdfCPP-Table-AddTable.cpp" >}}
