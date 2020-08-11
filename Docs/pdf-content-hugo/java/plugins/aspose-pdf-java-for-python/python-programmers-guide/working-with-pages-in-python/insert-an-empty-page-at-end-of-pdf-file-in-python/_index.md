---
title: Insert an Empty Page at End of PDF File in Python
type: docs
weight: 60
url: /java/insert-an-empty-page-at-end-of-pdf-file-in-python/
---

To Insert an Empty Page at the end of PDF document using **Aspose.PDF Java for Python**, simply invoke **InsertEmptyPageAtEndOfFile** class.

**Python Code**

{{< highlight java >}}

 pdf_document = self.Document()

pdf_document=self.dataDir + 'input1.pdf'

\# insert a empty page in a PDF

pdf_document.getPages().add();

\# Save the concatenated output file (the target document)

pdf_document.save(self.dataDir + "output.pdf")

print "Empty page added successfully!"

{{< /highlight >}}

**Download Running Code**

Download **Insert an Empty Page at End of PDF File (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithPages/InsertEmptyPageAtEndOfFile/InsertEmptyPageAtEndOfFile.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithPages/InsertEmptyPageAtEndOfFile/InsertEmptyPageAtEndOfFile.py)
