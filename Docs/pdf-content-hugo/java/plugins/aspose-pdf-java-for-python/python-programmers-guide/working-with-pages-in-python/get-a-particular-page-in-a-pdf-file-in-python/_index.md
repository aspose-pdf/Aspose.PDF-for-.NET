---
title: Get a Particular Page in a PDF File in Python
type: docs
weight: 30
url: /java/get-a-particular-page-in-a-pdf-file-in-python/
---

To get a Particular Page in a PDF document using **Aspose.PDF Java for Python**, simply invoke **GetPage** class.

**Python Code**

{{< highlight java >}}

 doc= self.Document()

pdf = self.Document()

pdf=self.dataDir + 'input1.pdf'

\# get the page at particular index of Page Collection

pdf_page = pdf.getPages().get_Item(1)

\# create a new Document object

new_document = self.Document()

\# add page to pages collection of new document object

new_document.getPages().add(pdf_page)

\# save the newly generated PDF file

new_document.save(self.dataDir + "output.pdf")

print "Process completed successfully!"

{{< /highlight >}}

**Download Running Code**

Download **Get Page (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose.PDF-for-Java_for_Python/test/WorkingWithPages/GetPage/GetPage.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithPages/GetPage/GetPage.py)
