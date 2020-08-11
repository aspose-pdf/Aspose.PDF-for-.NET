---
title: Optimize PDF Document for the Web in Python
type: docs
weight: 60
url: /java/optimize-pdf-document-for-the-web-in-python/
---

To optimize PDF document for the web using **Aspose.PDF Java for Python**, simply invoke **optimize_web** method of  **Optimize** class.

**Python Code**

{{< highlight java >}}

 doc= self.Document()

pdf = self.Document()

pdf=self.dataDir + 'input1.pdf'

\# Optimize for web

doc.optimize();

#Save output document

doc.save(self.dataDir + "Optimized_Web.pdf")

print "Optimized PDF for the Web, please check output file."


{{< /highlight >}}

**Download Running Code**

Download **Optimize PDF for Web (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithDocumentObject/Optimize/Optimize.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithDocumentObject/Optimize/Optimize.py)
