---
title: Convert PDF to SVG Format in Python
type: docs
weight: 30
url: /java/convert-pdf-to-svg-format-in-python/
---

To convert PDF to SVG format using **Aspose.PDF Java for Python**, simply invoke **PdfToSvg** module.

**Python Code**

{{< highlight java >}}

 # Open the target document

doc=self.Document()

pdf = self.Document()

pdf=self.dataDir +'input1.pdf'

\# instantiate an object of SvgSaveOptions

save_options = self.SvgSaveOptions()

\# do not compress SVG image to Zip archive

save_options.CompressOutputToZipArchive = False;

\# Save the output to XLS format

doc.save(self.dataDir + "Output1.svg", save_options)

print "Document has been converted successfully"

{{< /highlight >}}

**Download Running Code**

Download **Convert PDF to SVG Format (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithDocumentConversion/PdfToSvg/PdfToSvg.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithDocumentConversion/PdfToSvg/PdfToSvg.py)
