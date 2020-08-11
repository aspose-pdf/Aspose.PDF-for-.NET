---
title: Optimize PDF Document for the Web in Ruby
type: docs
weight: 70
url: /java/optimize-pdf-document-for-the-web-in-ruby/
---

## **Aspose.PDF - Optimize PDF for Web**
To optimize PDF document for the web using **Aspose.PDF Java for Ruby**, simply invoke **optimize_web** method of  **Optimize** module.

**Ruby Code**

{{< highlight ruby >}}

 def optimize_web()

    # The path to the documents directory.

    data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



    # Open a pdf document.

    doc = Rjb::import('com.aspose.pdf.Document').new(data_dir + "input1.pdf")

    # Optimize for web

    doc.optimize()



    #Save output document

    doc.save(data_dir + "Optimized_Web.pdf")

    puts "Optimized PDF for the Web, please check output file."

end   


{{< /highlight >}}
## **Download Running Code**
Download **Optimize PDF for Web (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Document/optimize.rb)
