---
title: Get a Particular Page in a PDF File in Ruby
type: docs
weight: 30
url: /java/get-a-particular-page-in-a-pdf-file-in-ruby/
---

## **Aspose.PDF - Get Page**
To get a Particular Page in a PDF document using **Aspose.PDF Java for Ruby**, simply invoke **GetPage** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Open the target document

pdf = Rjb::import('com.aspose.pdf.Document').new(data_dir + 'input1.pdf')

\# get the page at particular index of Page Collection

pdf_page = pdf.getPages().get_Item(1)

\# create a new Document object

new_document = Rjb::import('com.aspose.pdf.Document').new

\# add page to pages collection of new document object

new_document.getPages().add(pdf_page)

\# save the newly generated PDF file

new_document.save(data_dir + "output.pdf")

puts "Process completed successfully!"


{{< /highlight >}}
## **Download Running Code**
Download **Get Page (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Pages/getpage.rb)
