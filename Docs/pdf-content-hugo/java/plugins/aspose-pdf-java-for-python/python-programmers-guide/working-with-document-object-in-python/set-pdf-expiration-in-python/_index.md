---
title: Set PDF Expiration in Python
type: docs
weight: 80
url: /java/set-pdf-expiration-in-python/
---

To set expiration of  Pdf document using **Aspose.PDF Java for Python**, simply invoke **SetExpiration** class.

**Python Code**

{{< highlight java >}}

 doc= self.Document()

pdf = self.Document()

pdf=self.dataDir + 'input1.pdf'

javascript = self.JavascriptAction(

"var year=2014; var month=4;today = new Date();today = new Date(today.getFullYear(), today.getMonth());expiry = new Date(year, month);if (today.getTime() > expiry.getTime())app.alert('The file is expired. You need a new one.');");

doc.setOpenAction(javascript);

\# save update document with new information

doc.save(self.dataDir + "set_expiration.pdf");

print "Update document information, please check output file."

{{< /highlight >}}

**Download Running Code**

Download **Set PDF Expiration (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithDocumentObject/SetExpiration/SetExpiration.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithDocumentObject/SetExpiration/SetExpiration.py)
