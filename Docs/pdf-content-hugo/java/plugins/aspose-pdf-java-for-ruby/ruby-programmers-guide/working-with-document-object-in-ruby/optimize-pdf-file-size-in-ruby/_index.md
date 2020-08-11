---
title: Optimize PDF File Size in Ruby
type: docs
weight: 80
url: /java/optimize-pdf-file-size-in-ruby/
---

## **Aspose.PDF - Optimize PDF File Size**
To optimize file Size of PDF document using **Aspose.PDF Java for Ruby**, call **optimize_filesize** method of **Optimize** module.

**Ruby Code**

{{< highlight ruby >}}

 def optimize_filesize()

    # The path to the documents directory.

    data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



    # Open a pdf document.

    doc = Rjb::import('com.aspose.pdf.Document').new(data_dir + "input1.pdf")

    # Optimize the file size by removing unused objects

    opt = Rjb::import('aspose.document.OptimizationOptions').new

    opt.setRemoveUnusedObjects(true)

    opt.setRemoveUnusedStreams(true)

    opt.setLinkDuplcateStreams(true)

    doc.optimizeResources(opt)



    # Save output document

    doc.save(data_dir + "Optimized_Filesize.pdf")

    puts "Optimized PDF Filesize, please check output file."

end 


{{< /highlight >}}
## **Download Running Code**
Download **Optimize PDF File Size (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Document/optimize.rb)
