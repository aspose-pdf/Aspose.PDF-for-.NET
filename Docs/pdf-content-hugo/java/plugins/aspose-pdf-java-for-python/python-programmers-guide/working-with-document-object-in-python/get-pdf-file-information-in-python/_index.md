---
title: Get PDF File Information in Python
type: docs
weight: 40
url: /java/get-pdf-file-information-in-python/
---

To Get File Information of Pdf document using **Aspose.PDF Java for Python**, simply invoke **GetPdfFileInfo** class.

**Python Code**

{{< highlight java >}}

 doc= self.Document()

pdf = self.Document()

pdf=self.dataDir + 'input1.pdf'

\# Get document information

doc_info = doc.getInfo();

\# Show document information

print "Author:-" + str(doc_info.getAuthor())

print "Creation Date:-" + str(doc_info.getCreationDate())

print "Keywords:-" + str(doc_info.getKeywords())

print "Modify Date:-" + str(doc_info.getModDate())

print "Subject:-" + str(doc_info.getSubject())

print "Title:-" + str(doc_info.getTitle())


{{< /highlight >}}

**Download Running Code**

Download **Get PDF File Information (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithDocumentObject/GetPdfFileInfo/GetPdfFileInfo.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithDocumentObject/GetPdfFileInfo/GetPdfFileInfo.py)
