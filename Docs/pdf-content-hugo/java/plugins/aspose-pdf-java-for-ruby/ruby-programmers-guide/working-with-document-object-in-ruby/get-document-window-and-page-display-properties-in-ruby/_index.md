---
title: Get Document Window and Page Display Properties in Ruby
type: docs
weight: 40
url: /java/get-document-window-and-page-display-properties-in-ruby/
---

## **Aspose.PDF - Get Document Window and Page Display Properties**
To Get Document Window and Page Display Properties of Pdf document using **Aspose.PDF Java for Ruby**, simply invoke **GetDocumentWindow** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'

\# Open a pdf document.

doc = Rjb::import('com.aspose.pdf.Document').new(data_dir + "input1.pdf")

\# Get different document properties

\# Position of document's window - Default: false

puts "CenterWindow :- " + doc.getCenterWindow().to_s

\# Predominant reading order; determine the position of page

\# when displayed side by side - Default: L2R

puts "Direction :- " + doc.getDirection().to_s

\# Whether window's title bar should display document title.

\# If false, title bar displays PDF file name - Default: false

puts "DisplayDocTitle :- " + doc.getDisplayDocTitle().to_s

#Whether to resize the document's window to fit the size of

#first displayed page - Default: false

puts "FitWindow :- " + doc.getFitWindow().to_s

\# Whether to hide menu bar of the viewer application - Default: false

puts "HideMenuBar :-" + doc.getHideMenubar().to_s

\# Whether to hide tool bar of the viewer application - Default: false

puts "HideToolBar :-" + doc.getHideToolBar().to_s

\# Whether to hide UI elements like scroll bars

\# and leaving only the page contents displayed - Default: false

puts "HideWindowUI :-" + doc.getHideWindowUI().to_s

\# The document's page mode. How to display document on exiting full-screen mode.

puts "NonFullScreenPageMode :-" + doc.getNonFullScreenPageMode().to_s

\# The page layout i.e. single page, one column

puts "PageLayout :-" + doc.getPageLayout().to_s

#How the document should display when opened.

puts "pageMode :-" + doc.getPageMode().to_s


{{< /highlight >}}
## **Download Running Code**
Download **Get Document Window and Page Display Properties (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Document/getdocumentwindow.rb)
