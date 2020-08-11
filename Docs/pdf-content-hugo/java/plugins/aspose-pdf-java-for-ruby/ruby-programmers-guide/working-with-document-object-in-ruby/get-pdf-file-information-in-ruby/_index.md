---
title: Get PDF File Information in Ruby
type: docs
weight: 50
url: /java/get-pdf-file-information-in-ruby/
---

## **Aspose.PDF - Get PDF File Information**
To Get File Information of Pdf document using **Aspose.PDF Java for Ruby**, simply invoke **GetPdfFileInfo** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'

\# Open a pdf document.

doc = Rjb::import('com.aspose.pdf.Document').new(data_dir + "input1.pdf")

\# Get document information

doc_info = doc.getInfo()

\# Show document information

puts "Author:-" + doc_info.getAuthor().to_s

puts "Creation Date:-" + doc_info.getCreationDate().to_string

puts "Keywords:-" + doc_info.getKeywords().to_s

puts "Modify Date:-" + doc_info.getModDate().to_string

puts "Subject:-" + doc_info.getSubject().to_s

puts "Title:-" + doc_info.getTitle().to_s


{{< /highlight >}}
## **Download Running Code**
Download **Get PDF File Information (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Document/getpdffileinfo.rb)
