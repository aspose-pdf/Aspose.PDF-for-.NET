---
title: Convert PDF to Excel Workbook in Python
type: docs
weight: 20
url: /java/convert-pdf-to-excel-workbook-in-python/
---

To convert PDF document to Excel Workbook using **Aspose.PDF Java for Python**, simply invoke **PdfToExcel** module.

**Python Code**

{{< highlight java >}}

 doc=self.Document()

pdf = self.Document()

pdf=self.dataDir +'input1.pdf'

\# Instantiate ExcelSave Option object

excelsave=self.ExcelSaveOptions();

\# Save the output to XLS format

doc.save(self.dataDir + "Converted_Excel.xls", excelsave);

print "Document has been converted successfully"

{{< /highlight >}}

**Download Running Code**

Download **Convert PDF to Excel Workbook (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithDocumentConversion/PdfToExcel/PdfToExcel.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithDocumentConversion/PdfToExcel/PdfToExcel.py)
