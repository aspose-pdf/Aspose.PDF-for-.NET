---
title: Concatenate PDF Files in Ruby
type: docs
weight: 10
url: /java/concatenate-pdf-files-in-ruby/
---

## **Aspose.PDF - Concatenate PDF Files**
To concatenate PDF files using **Aspose.PDF Java for Ruby**, simply invoke **ConcatenatePdfFiles** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Open the target document

pdf1 = Rjb::import('com.aspose.pdf.Document').new(data_dir + 'input1.pdf')

\# Open the source document

pdf2 = Rjb::import('com.aspose.pdf.Document').new(data_dir + 'input2.pdf')

\# Add the pages of the source document to the target document

pdf1.getPages().add(pdf2.getPages())

\# Save the concatenated output file (the target document)

pdf1.save(data_dir+ "Concatenate_output.pdf")

puts "New document has been saved, please check the output file"


{{< /highlight >}}
## **Download Running Code**
Download **Concatenate PDF Files (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Pages/concatenatepdffiles.rb)
