---
title: Split PDF File into Individual Pages in Python
type: docs
weight: 80
url: /java/split-pdf-file-into-individual-pages-in-python/
---

To split PDF document into individual pages using **Aspose.PDF Java for PHP**, simply invoke **SplitAllPages** class.

**Python Code**

{{< highlight java >}}

 pdf = self.Document()

pdf=self.dataDir + 'input1.pdf'

\# loop through all the pages

pdf_page = 1

total_size = pdf.getPages().size()

while (pdf_page <= total_size):

\# create a new Document object

new_document = self.Document();

\# get the page at particular index of Page Collection

new_document.getPages().add(pdf.getPages().get_Item(pdf_page))

\# save the newly generated PDF file

new_document.save(self.dataDir + "page_#{$pdf_page}.pdf")

pdf_page+=1

print "Split process completed successfully!";


{{< /highlight >}}

**Download Running Code**

Download **Split Pages (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithPages/SplitAllPages/SplitAllPages.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithPages/SplitAllPages/SplitAllPages.py)
