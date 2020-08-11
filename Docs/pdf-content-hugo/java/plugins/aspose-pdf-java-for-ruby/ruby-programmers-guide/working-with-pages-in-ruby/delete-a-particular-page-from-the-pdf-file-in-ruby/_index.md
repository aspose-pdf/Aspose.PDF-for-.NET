---
title: Delete a Particular Page from the PDF File in Ruby
type: docs
weight: 20
url: /java/delete-a-particular-page-from-the-pdf-file-in-ruby/
---

## **Aspose.PDF - Delete Page**
To delete a Particular Page from the PDF document using **Aspose.PDF Java for Ruby**, simply invoke **DeletePage** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Open the target document

pdf = Rjb::import('com.aspose.pdf.Document').new(data_dir + 'input1.pdf')

\# delete a particular page

pdf.getPages().delete(2)

\# save the newly generated PDF file

pdf.save(data_dir + "output.pdf")

puts "Page deleted successfully!"


{{< /highlight >}}
## **Download Running Code**
Download **Delete Page (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Pages/deletepage.rb)
