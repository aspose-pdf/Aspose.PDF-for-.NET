---
title: Update Page Dimensions in Python
type: docs
weight: 90
url: /java/update-page-dimensions-in-python/
---

To update page Dimensions using **Aspose.PDF Java for Python**, simply invoke **UpdatePageDimensions** class.

**Python Code**

{{< highlight java >}}

 pdf = self.Document()

pdf=self.dataDir + 'input1.pdf'

\# get page collection

page_collection = pdf.getPages()

\# get particular page

pdf_page = page_collection.get_Item(1)

\# set the page size as A4 (11.7 x 8.3 in) and in Aspose.PDF, 1 inch = 72 points

\# so A4 dimensions in points will be (842.4, 597.6)

pdf_page.setPageSize(597.6,842.4)

\# save the newly generated PDF file

pdf.save(self.dataDir + "output.pdf")

print "Dimensions updated successfully!"

{{< /highlight >}}

**Download Running Code**

Download **Update Page Dimensions (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithPages/UpdatePageDimensions/UpdatePageDimensions.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithPages/UpdatePageDimensions/UpdatePageDimensions.py)
