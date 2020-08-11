---
title: Delete a Particular Page from the PDF File in Python
type: docs
weight: 20
url: /java/delete-a-particular-page-from-the-pdf-file-in-python/
---

To delete a Particular Page from the PDF document using **Aspose.PDF Java for Python**, simply invoke **DeletePage** class.

**Python Code**

{{< highlight java >}}

 doc= self.Document()

pdf = self.Document()

pdf=self.dataDir + 'input1.pdf'

\# delete a particular page

pdf.getPages().delete(2)

\# save the newly generated PDF file

doc.save(self.dataDir + "output.pdf")

print "Page deleted successfully!"

{{< /highlight >}}

**Download Running Code**

Download **Delete Page (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithPages/DeletePage/DeletePage.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithPages/DeletePage/DeletePage.py)
