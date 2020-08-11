---
title: Set PDF File Information in Python
type: docs
weight: 90
url: /java/set-pdf-file-information-in-python/
---

To update Pdf document information using **Aspose.PDF Java for Python**, simply invoke **SetPdfFileInfo** class.

**Python Code**

{{< highlight java >}}

 doc= self.Document()

pdf = self.Document()

pdf=self.dataDir + 'input1.pdf'

\# Get document information

doc_info = doc.getInfo();

doc_info.setAuthor("Aspose.PDF for java");

doc_info.setCreationDate(datetime.today.strftime("%m/%d/%Y"));

doc_info.setKeywords("Aspose.PDF, DOM, API");

doc_info.setModDate(datetime.today.strftime("%m/%d/%Y"));

doc_info.setSubject("PDF Information");

doc_info.setTitle("Setting PDF Document Information");

\# save update document with new information

doc.save(self.dataDir + "Updated_Information.pdf")

print "Update document information, please check output file."

{{< /highlight >}}

**Download Running Code**

Download **Set PDF File Information (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithDocumentObject/SetPdfFileInfo/SetPdfFileInfo.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithDocumentObject/SetPdfFileInfo/SetPdfFileInfo.py)
