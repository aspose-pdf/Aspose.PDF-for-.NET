---
title: Get Page Count of PDF in Ruby
type: docs
weight: 40
url: /java/get-page-count-of-pdf-in-ruby/
---

## **Aspose.PDF - Get Page Count**
To get page count of Pdf document using **Aspose.PDF Java for Ruby**, simply invoke **GetNumberOfPages** module.

**Ruby Code**

{{< highlight ruby >}}

 data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Create PDF document

pdf = Rjb::import('com.aspose.pdf.Document').new(data_dir + 'input1.pdf')

page_count = pdf.getPages().size()

puts "Page Count:" + page_count.to_s


{{< /highlight >}}
## **Download Running Code**
Download **Get Page Count (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Pages/getnumberofpages.rb)
