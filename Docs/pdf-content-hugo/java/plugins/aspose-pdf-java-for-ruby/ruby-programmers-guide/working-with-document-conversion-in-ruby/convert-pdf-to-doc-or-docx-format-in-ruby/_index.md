---
title: Convert PDF to DOC or DOCX format in Ruby
type: docs
weight: 30
url: /java/convert-pdf-to-doc-or-docx-format-in-ruby/
---

## **Aspose.PDF - Convert PDF to DOC or DOCX**
To convert PDF document to DOC or DOCX format using **Aspose.PDF Java for Ruby**, simply invoke **PdfToDoc** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Open the target document

pdf = Rjb::import('com.aspose.pdf.Document').new(data_dir + 'input1.pdf')

\# Save the concatenated output file (the target document)

pdf.save(data_dir + "output.doc")

puts "Document has been converted successfully"


{{< /highlight >}}
## **Download Running Code**
Download **Convert PDF to DOC or DOCX (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Converter/pdftodoc.rb)
