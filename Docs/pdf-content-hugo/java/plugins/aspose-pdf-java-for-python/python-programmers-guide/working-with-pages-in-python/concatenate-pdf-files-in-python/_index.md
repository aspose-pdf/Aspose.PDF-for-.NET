---
title: Concatenate PDF Files in Python
type: docs
weight: 10
url: /java/concatenate-pdf-files-in-python/
---

To concatenate PDF files using **Aspose.PDF Java for Python**, simply invoke **ConcatenatePdfFiles** class.

**PHP Code**

{{< highlight php >}}

 doc= self.Document()

pdf = self.Document()

pdf=self.dataDir + 'input1.pdf'

\# Open the source document

pdf1 = self.Document()

pdf1=self.dataDir + 'input2.pdf'

\# Add the pages of the source document to the target document

pdf1.getPages().add(pdf1.getPages())

\# Save the concatenated output file (the target document)

doc.save(self.dataDir + "Concatenate_output.pdf")

print "New document has been saved, please check the output file"

{{< /highlight >}}

**Download Running Code**

Download **Concatenate PDF Files (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithPages/ConcatenatePdfFiles/ConcatenatePdfFiles.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithPages/ConcatenatePdfFiles/ConcatenatePdfFiles.py)
