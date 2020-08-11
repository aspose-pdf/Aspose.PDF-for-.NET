---
title: Convert SVG file to PDF format in Ruby
type: docs
weight: 60
url: /java/convert-svg-file-to-pdf-format-in-ruby/
---

## **Aspose.PDF - Convert SVG to PDF**
To convert SVG file to PDF format using **Aspose.PDF Java for Ruby**, simply invoke **SvgToPdf** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'

\# Instantiate LoadOption object using SVG load option

options = Rjb::import('com.aspose.pdf.SvgLoadOptions').new



\# Create document object

pdf = Rjb::import('com.aspose.pdf.Document').new(data_dir + 'Example.svg', options)

\# Save the output to XLS format

pdf.save(data_dir + "SVG.pdf")

puts "Document has been converted successfully"


{{< /highlight >}}
## **Download Running Code**
Download **Convert SVG to PDF (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Converter/svgtopdf.rb)
