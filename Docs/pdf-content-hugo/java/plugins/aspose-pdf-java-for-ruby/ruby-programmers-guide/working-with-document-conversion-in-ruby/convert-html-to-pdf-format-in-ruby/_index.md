---
title: Convert HTML to PDF Format in Ruby
type: docs
weight: 10
url: /java/convert-html-to-pdf-format-in-ruby/
---

## **Aspose.PDF - Convert HTML to PDF Format**
To convert HTML to PDF format using **Aspose.PDF Java for Ruby**, simply invoke **HtmlToPdf** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'

htmloptions = Rjb::import('com.aspose.pdf.HtmlLoadOptions').new(data_dir)

\# Load HTML file

pdf = Rjb::import('com.aspose.pdf.Document').new(data_dir + "index.html", htmloptions)

\# Save the concatenated output file (the target document)

pdf.save(data_dir + "html.pdf")

puts "Document has been converted successfully"


{{< /highlight >}}
## **Download Running Code**
Download **Convert HTML to PDF Format (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Converter/htmltopdf.rb)
