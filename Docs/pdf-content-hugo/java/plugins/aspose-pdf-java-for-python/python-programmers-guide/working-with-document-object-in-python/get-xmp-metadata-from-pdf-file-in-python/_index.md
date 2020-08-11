---
title: Get XMP Metadata from PDF File in Python
type: docs
weight: 50
url: /java/get-xmp-metadata-from-pdf-file-in-python/
---

To get XMP Metadata from Pdf document using **Aspose.PDF Java for Python**, simply invoke **GetXMPMetadata** class.

**Python Code**

{{< highlight java >}}

 doc= self.Document()

pdf = self.Document()

pdf=self.dataDir + 'input1.pdf'

\# Get properties

print "xmp:CreateDate: " + str(doc.getMetadata().get_Item("xmp:CreateDate"))

print "xmp:Nickname: " + str(doc.getMetadata().get_Item("xmp:Nickname"))

print "xmp:CustomProperty: " + str(doc.getMetadata().get_Item("xmp:CustomProperty"))

{{< /highlight >}}

**Download Running Code**

Download **Get XMP Metadata (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithDocumentObject/GetXMPMetadata/GetXMPMetadata.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithDocumentObject/GetXMPMetadata/GetXMPMetadata.py)
