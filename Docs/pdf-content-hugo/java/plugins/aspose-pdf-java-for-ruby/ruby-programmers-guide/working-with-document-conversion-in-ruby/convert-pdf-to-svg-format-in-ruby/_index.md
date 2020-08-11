---
title: Convert PDF to SVG Format in Ruby
type: docs
weight: 50
url: /java/convert-pdf-to-svg-format-in-ruby/
---

## **Aspose.PDF - Convert PDF to SVG**
To convert PDF to SVG format using **Aspose.PDF Java for Ruby**, simply invoke **PdfToSvg** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Open the target document

pdf = Rjb::import('com.aspose.pdf.Document').new(data_dir + 'input1.pdf')

\# instantiate an object of SvgSaveOptions

save_options = Rjb::import('com.aspose.pdf.SvgSaveOptions').new

\# do not compress SVG image to Zip archive

save_options.CompressOutputToZipArchive = false

\# Save the output to XLS format

pdf.save(data_dir + "Output.svg", save_options)

puts "Document has been converted successfully"


{{< /highlight >}}
## **Download Running Code**
Download **Convert PDF to SVG Format (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Converter/pdftosvg.rb)
