---
title: Convert PDF pages to Images in Ruby
type: docs
weight: 20
url: /java/convert-pdf-pages-to-images-in-ruby/
---

## **Aspose.PDF - Convert PDF pages to Images**
To convert all Pages to Images of Pdf document using **Aspose.PDF Java for Ruby**, simply invoke **ConvertPagesToImages** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



converter = Rjb::import('com.aspose.pdf.facades.PdfConverter').new

converter.bindPdf(data_dir + 'input1.pdf')

converter.doConvert()

suffix = ".jpg"

image_count = 1

image_format_internal = Rjb::import('com.aspose.pdf.ImageFormatInternal')

while converter.hasNextImage()

    converter.getNextImage(data_dir + "image#{image_count}#{suffix}", image_format_internal.getJpeg())

    image_count +=1

end

puts "PDF pages are converted to individual images successfully!"


{{< /highlight >}}
## **Download Running Code**
Download **Convert PDF pages to Images (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Converter/convertpagestoimages.rb)
