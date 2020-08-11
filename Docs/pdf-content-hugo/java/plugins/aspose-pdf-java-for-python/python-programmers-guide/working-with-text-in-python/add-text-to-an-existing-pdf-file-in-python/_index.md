---
title: Add Text to an existing PDF file in Python
type: docs
weight: 20
url: /java/add-text-to-an-existing-pdf-file-in-python/
---

To add Text string in Pdf document using **Aspose.PDF Java for Python**, simply invoke **AddText** module.

**Python Code**

{{< highlight java >}}

 doc=self.Document()

doc=self.dataDir + 'input1.pdf'

pdf_page=self.Document()

pdf_page.getPages().get_Item(1)

text_fragment=self.TextFragment("main text")

position=self.Position()

text_fragment.setPosition(position(100,600))

font_repository=self.FontRepository()

color=self.Color()

text_fragment.getTextState().setFont(font_repository.findFont("Verdana"))

text_fragment.getTextState().setFontSize(14)

text_builder=self.TextBuilder(pdf_page)

text_builder.appendText(text_fragment)

\# Save PDF file

doc.save(self.dataDir + "Text_Added.pdf")

print "Text added successfully"


{{< /highlight >}}

**Download Running Code**

Download **Add Text (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithText/AddText/AddText.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithText/AddText/AddText.py)
