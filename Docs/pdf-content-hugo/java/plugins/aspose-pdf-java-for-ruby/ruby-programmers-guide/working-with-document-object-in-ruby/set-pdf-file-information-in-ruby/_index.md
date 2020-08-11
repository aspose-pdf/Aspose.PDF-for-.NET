---
title: Set PDF File Information in Ruby
type: docs
weight: 120
url: /java/set-pdf-file-information-in-ruby/
---

## **Aspose.PDF - Set PDF File Information**
To update Pdf document information using **Aspose.PDF Java for Ruby**, simply invoke **SetPdfFileInfo** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'

\# Open a pdf document.

doc = Rjb::import('com.aspose.pdf.Document').new(data_dir + "input1.pdf")

\# Get document information

doc_info = doc.getInfo()

doc_info.setAuthor("Aspose.PDF for java")

doc_info.setCreationDate(Rjb::import('java.util.Date').new)

doc_info.setKeywords("Aspose.PDF, DOM, API")

doc_info.setModDate(Rjb::import('java.util.Date').new)

doc_info.setSubject("PDF Information")

doc_info.setTitle("Setting PDF Document Information")

\# save update document with new information

doc.save(data_dir + "Updated_Information.pdf")

puts "Update document information, please check output file."


{{< /highlight >}}
## **Download Running Code**
Download **Set PDF File Information (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Document/setpdffileinfo.rb)
