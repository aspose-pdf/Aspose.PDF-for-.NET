---
title: Convert PDF to Excel Workbook in Ruby
type: docs
weight: 40
url: /java/convert-pdf-to-excel-workbook-in-ruby/
---

## **Aspose.PDF - Convert PDF to Excel Workbook**
To convert PDF document to Excel Workbook using **Aspose.PDF Java for Ruby**, simply invoke **PdfToExcel** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Open the target document

pdf = Rjb::import('com.aspose.pdf.Document').new(data_dir + 'input1.pdf')

\# Instantiate ExcelSave Option object

excelsave = Rjb::import('com.aspose.pdf.ExcelSaveOptions').new

\# Save the output to XLS format

pdf.save(data_dir + "Converted_Excel.xls", excelsave)

puts "Document has been converted successfully"


{{< /highlight >}}
## **Download Running Code**
Download **Convert PDF to Excel Workbook (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Converter/pdftoexcel.rb)
