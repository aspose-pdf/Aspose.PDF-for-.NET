---
title: Add HTML String using DOM in Ruby
type: docs
weight: 10
url: /java/add-html-string-using-dom-in-ruby/
---

## **Aspose.PDF - Add HTML**
To add HTML string in Pdf document using **Aspose.PDF Java for Ruby**, simply invoke **AddHtml** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Instantiate Document object

doc = Rjb::import('com.aspose.pdf.Document').new

\# Add a page to pages collection of PDF file

page = doc.getPages().add()

\# Instantiate HtmlFragment with HTML contents

title = Rjb::import('com.aspose.pdf.HtmlFragment').new("<fontsize=10><b><i>Table</i></b></fontsize>")

\# set MarginInfo for margin details

margin = Rjb::import('com.aspose.pdf.MarginInfo').new

margin.setBottom(10)

margin.setTop(200)

\# Set margin information

title.setMargin(margin)

\# Add HTML Fragment to paragraphs collection of page

page.getParagraphs().add(title)

\# Save PDF file

doc.save(data_dir + "html.output.pdf")

puts "HTML added successfully"


{{< /highlight >}}
## **Download Running Code**
Download **Add HTML (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Text/addhtml.rb)
