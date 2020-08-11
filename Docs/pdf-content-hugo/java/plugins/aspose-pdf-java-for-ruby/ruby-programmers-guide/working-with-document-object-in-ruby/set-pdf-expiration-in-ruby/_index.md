---
title: Set PDF Expiration in Ruby
type: docs
weight: 110
url: /java/set-pdf-expiration-in-ruby/
---

## **Aspose.PDF - Set PDF Expiration**
To set expiration of  Pdf document using **Aspose.PDF Java for Ruby**, simply invoke **SetExpiration** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'

\# Open a pdf document.

doc = Rjb::import('com.aspose.pdf.Document').new(data_dir + "input1.pdf")

javascript = Rjb::import('com.aspose.pdf.JavascriptAction').new(

    "var year=2014;

    var month=4;

    today = new Date();

    today = new Date(today.getFullYear(), today.getMonth());

    expiry = new Date(year, month);

    if (today.getTime() > expiry.getTime())

    app.alert('The file is expired. You need a new one.');")

doc.setOpenAction(javascript)

\# save update document with new information

doc.save(data_dir + "set_expiration.pdf")

puts "Update document information, please check output file."


{{< /highlight >}}
## **Download Running Code**
Download **Set PDF Expiration (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Document/setexpiration.rb)
